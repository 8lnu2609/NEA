Public Class frmMomentumSim
    Dim leftParticle As New Particle
    Dim rightParticle As New Particle
    Dim BOXHEIGHT, BOXWIDTH As Int16
    Const SHAPEWIDTH As Int32 = 20
    Dim COEofRestitution As Single = 1
    Dim playing As Boolean = False
    Dim timeStart As Date
    Dim velocityScalar As Single

    Public Sub New()
        InitializeComponent()
        setHandlers()
        UpdateValues()
    End Sub

    Public Overloads Sub ShowDialog()
        MyBase.Show()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        leftParticle.posY = BOXHEIGHT / 2
        leftParticle.posX = SHAPEWIDTH
        rightParticle.posY = BOXHEIGHT / 2
        rightParticle.posX = BOXWIDTH - SHAPEWIDTH
        UpdateValues()
    End Sub

    Sub setHandlers()
        For Each group As Control In grpData.Controls
            If group.GetType = GetType(GroupBox) Then
                For Each control As Control In group.Controls
                    If control.GetType = GetType(NumericUpDown) Then
                        AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf UpdateValues
                    End If
                Next
            End If
        Next
        For Each pair As KeyValuePair(Of String, Single) In MaterialDictionary
            cboMaterial.Items.Add(pair.Key)
        Next
        cboMaterial.SelectedIndex = 0
        cboMaterial.Items.Add("Custom coefficient")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        leftParticle.Shape.Draw(e, SHAPEWIDTH, Color.Black)
        rightParticle.Shape.Draw(e, SHAPEWIDTH, Color.White)
    End Sub

    Sub cboMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaterial.SelectedIndexChanged, updRestitution.ValueChanged
        If cboMaterial.SelectedIndex <> cboMaterial.Items.Count - 1 Then
            updRestitution.Enabled = False
            COEofRestitution = MaterialDictionary.Item(cboMaterial.SelectedItem)
            ToolTips.SetToolTip(sender, COEofRestitution)
            updRestitution.Value = COEofRestitution
        Else
            updRestitution.Enabled = True
            COEofRestitution = updRestitution.Value
        End If
        UpdateValues()
    End Sub

    Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        If playing = False Then
            If updVelocityLeft.Value <> 0 And updVelocityRight.Value <> 0 Then
                UpdateValues()
                collision = False
                tmrCalculations.Start()
                cmdStart.Text = "Stop"
                timeStart = Now
            Else
                MessageBox.Show("Both velocities cannot be 0 as there will be no collision")
                playing = Not playing
            End If
        Else
            tmrCalculations.Stop()
            cmdStart.Text = "Start"
        End If
        leftParticle.posX = SHAPEWIDTH
        rightParticle.posX = BOXWIDTH - 2 * SHAPEWIDTH
        playing = Not playing
    End Sub

    Dim collision As Boolean = False
    Dim collisionPoint As Single

    Private Sub tmrCalculations_Tick(sender As Object, e As EventArgs) Handles tmrCalculations.Tick
        If collision = False Then
            If leftParticle.posX + SHAPEWIDTH < rightParticle.posX Then
                leftParticle.posX = SHAPEWIDTH + Maths.Displacement(leftParticle.Velocity * velocityScalar, leftParticle.Velocity * velocityScalar, Single.NaN, (Now - timeStart).TotalSeconds)
                rightParticle.posX = (BOXWIDTH - 2 * SHAPEWIDTH) + Maths.Displacement(rightParticle.Velocity * velocityScalar, rightParticle.Velocity * velocityScalar, Single.NaN, (Now - timeStart).TotalSeconds)
            Else
                collision = True
                collisionPoint = (leftParticle.posX + SHAPEWIDTH + rightParticle.posX) / 2
                timeStart = Now
                Dim returns() As Single = Maths.SimultaneousSolve(leftParticle.Mass, rightParticle.Mass, (leftParticle.Mass * leftParticle.Velocity + rightParticle.Mass * rightParticle.Velocity),
                                                                  -1, 1, COEofRestitution * (leftParticle.Velocity - rightParticle.Velocity))
                leftParticle.Velocity = returns(0)
                rightParticle.Velocity = returns(1)
                lblOutput.Show()
                lblOutput.Text = String.Format("The left particle's inital
velocity was: {0}m/s²
The right particle's inital
velocity was: {1}m/s²

The left particle's velocity
is now: {2}m/s²
The right particle's velocity
is now: {3}m/s²
", Math.Round(Math.Abs(updVelocityLeft.Value), 3), Math.Round(Math.Abs(updVelocityRight.Value), 3),
    Math.Round(Math.Abs(leftParticle.Velocity), 3), Math.Round(Math.Abs(rightParticle.Velocity), 3))
            End If

        Else
            If leftParticle.posX > SHAPEWIDTH And rightParticle.posX < BOXWIDTH - SHAPEWIDTH Then
                leftParticle.posX = collisionPoint - SHAPEWIDTH + Maths.Displacement(leftParticle.Velocity * velocityScalar, leftParticle.Velocity * velocityScalar, Single.NaN, (Now - timeStart).TotalSeconds)
                rightParticle.posX = collisionPoint + Maths.Displacement(rightParticle.Velocity * velocityScalar, rightParticle.Velocity * velocityScalar, Single.NaN, (Now - timeStart).TotalSeconds)
            Else
                tmrCalculations.Stop()
            End If
        End If

    End Sub

    Sub UpdateValues()
        lblOutput.Hide()
        tmrCalculations.Stop()
        leftParticle.posX = SHAPEWIDTH
        rightParticle.posX = BOXWIDTH - 2 * SHAPEWIDTH
        playing = False
        cmdStart.Text = "Start"
        leftParticle.Velocity = updVelocityLeft.Value
        leftParticle.Mass = updMassLeft.Value
        rightParticle.Velocity = -updVelocityRight.Value
        rightParticle.Mass = updMassRight.Value

        If leftParticle.Velocity - rightParticle.Velocity >= 1 Then
            velocityScalar = 1000 / (Math.Ceiling((leftParticle.Velocity - rightParticle.Velocity) / 10) * 10)
        Else
            velocityScalar = 10000
        End If
    End Sub

End Class

Class Particle
    Public Property Velocity As Single
    Public Property Mass As Single
    Public Property Shape As New Square
    Public Property posX As Single
        Get
            Return Shape.posX
        End Get
        Set(value As Single)
            Shape.posX = value
        End Set
    End Property
    Public Property posY As Single
        Get
            Return Shape.posY
        End Get
        Set(value As Single)
            Shape.posY = value
        End Set
    End Property

End Class