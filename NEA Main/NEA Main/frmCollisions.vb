Public Class frmCollisions
    Dim leftParticle As New Particle
    Dim rightParticle As New Particle
    Dim BOXHEIGHT, BOXWIDTH As Int16
    Const SHAPEWIDTH As Int32 = 40
    Dim COEofRestitution As Single = 1
    Dim playing As Boolean = False
    Dim MaterialDictionary As New Dictionary(Of String, Single) From {
        {"Brass", 0.3},
        {"Bronze", 0.52},
        {"Copper", 0.22},
        {"Cork", 0.6},
        {"Elm", 0.48},
        {"Glass", 0.96},
        {"Iron", 0.67},
        {"Ivory", 0.78},
        {"Lead", 0.16},
        {"Maple", 0.65},
        {"Rubber", 0.75},
        {"Steel", 0.9}
    }
    Dim timeStart As Date

    Public Sub New()
        InitializeComponent()
        BOXHEIGHT = picDisplay.Height
        BOXWIDTH = picDisplay.Width
        setHandlers()
        leftParticle.Shape.posY = BOXHEIGHT / 2
        leftParticle.Shape.posX = SHAPEWIDTH
        rightParticle.Shape.posY = BOXHEIGHT / 2
        rightParticle.Shape.posX = BOXWIDTH - 2 * SHAPEWIDTH
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
            cboMaterial.SelectedIndex = 0
        Next
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        leftParticle.Shape.Draw(e, SHAPEWIDTH)
        rightParticle.Shape.Draw(e, SHAPEWIDTH)
    End Sub

    Sub SetToolTipCOE(sender As ComboBox, e As EventArgs) Handles cboMaterial.SelectedIndexChanged
        ToolTips.SetToolTip(sender, MaterialDictionary.Item(sender.SelectedItem))
    End Sub

    Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        If playing = False Then
            tmrCalculations.Start()
            cmdStart.Text = "Stop"
            timeStart = Now
        Else
            tmrCalculations.Stop()
            cmdStart.Text = "Start"
        End If
        playing = Not playing
    End Sub

    Private Sub tmrCalculations_Tick(sender As Object, e As EventArgs) Handles tmrCalculations.Tick
        If leftParticle.Shape.posX + SHAPEWIDTH < rightParticle.Shape.posX Then
            leftParticle.Shape.posX = SHAPEWIDTH + Maths.Displacement(leftParticle.Velocity, leftParticle.Velocity, Single.NaN, (Now - timeStart).TotalSeconds)
            rightParticle.Shape.posX = BOXWIDTH - (2 * SHAPEWIDTH) - Maths.Displacement(rightParticle.Velocity, rightParticle.Velocity, Single.NaN, (Now - timeStart).TotalSeconds)
        End If
    End Sub

    Sub UpdateValues()
        tmrCalculations.Stop()
        playing = False
        cmdStart.Text = "Start"
        leftParticle.Velocity = updVelocityLeft.Value
        leftParticle.Mass = updMassLeft.Value
        rightParticle.Velocity = updVelocityRight.Value
        rightParticle.Mass = updMassRight.Value
    End Sub

End Class

Class Particle
    Private _Velocity As Single
    Public Property Velocity As Single
        Get
            Return _Velocity * 100
        End Get
        Set(value As Single)
            _Velocity = value
        End Set
    End Property
    Public Property Mass As Single
    Public Property Shape As New Square

End Class