Public Class frmForcesFlat
    Dim BOXWIDTH, BOXHEIGHT As Int32
    Dim Particle As New Square
    Dim BaseLine As New Line
    Dim force As Single
    Dim mass As Single
    Dim coeFriction As Single
    Dim scalar As Single = 1
    Dim timeStart As DateTime
    Dim weight As Single
    Dim resultantForce As Single
    Dim friction As Single
    Dim acceleration As Single


    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboAcceleration)
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        Particle.posY = BOXHEIGHT / 2 - Shape.LINEWIDTH / 2
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        With BaseLine
            .posX = 0
            .posXe = BOXWIDTH
            .posY = BOXHEIGHT / 2 + Shape.LINEWIDTH
            .posYe = .posY
        End With
        BaseLine.Draw(e, Shape.LINEWIDTH * scalar)
        Particle.Draw(e, Shape.WIDTH * scalar)
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub trbForce_Scroll(sender As Object, e As EventArgs) Handles trbForce.Scroll
        force = 10 ^ (trbForce.Value / 10)
        updForce.Value = force
        updateValues()
    End Sub

    Private Sub updForce_ValueChanged(sender As Object, e As EventArgs) Handles updForce.ValueChanged
        force = updForce.Value
        If force <> 0 Then
            trbForce.Value = Math.Log10(force) * 10
        End If

        updateValues()
    End Sub

    Private Sub updTotalTime_ValueChanged(sender As Object, e As EventArgs) Handles updTotalTime.ValueChanged
        trbTime.Maximum = updTotalTime.Value * 100

    End Sub

    Private Sub optRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles optRealTime.CheckedChanged
        If optRealTime.Checked Then
            trbTime.Hide()
            updTotalTime.Hide()
            lblTotalTime.Hide()
            cmdStartStop.Show()
        Else
            trbTime.Show()
            updTotalTime.Show()
            lblTotalTime.Show()
            cmdStartStop.Hide()
            tmrCalculation.Stop()
        End If
    End Sub

    Private Sub trbZoom_Scroll(sender As Object, e As EventArgs) Handles trbZoom.Scroll
        If trbZoom.Value > 0 Then
            scalar = trbZoom.Value
            lblZoomLevel.Text = String.Format("Zoom: {0}x", trbZoom.Value)
        Else
            scalar = 1 / (Math.Abs(trbZoom.Value) + 2)
            lblZoomLevel.Text = String.Format("Zoom: 1/{0}x", Math.Abs(trbZoom.Value) + 2)
        End If

        BaseLine.posY = BOXHEIGHT / 2 + Shape.LINEWIDTH * scalar
        BaseLine.posYe = BaseLine.posY
        Particle.posY = BOXHEIGHT / 2 - Shape.LINEWIDTH / 2 * scalar

    End Sub

    Private Sub cboAcceleration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcceleration.SelectedIndexChanged
        ToolTips.SetToolTip(cboAcceleration, AccelerationDictionary.Item(cboAcceleration.SelectedItem()) & "ms^-2")
        updateValues()
    End Sub

    Private Sub cmdStartStop_Click(sender As Object, e As EventArgs) Handles cmdStartStop.Click
        If tmrCalculation.Enabled Then
            tmrCalculation.Stop()
            cmdStartStop.Text = "Start"
        Else
            Particle.posX = 0
            tmrCalculation.Start()
            timeStart = Now
            cmdStartStop.Text = "Stop"
        End If
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll
        If optStepByStep.Checked Then
            ToolTips.SetToolTip(trbTime, "Time: " & trbTime.Value / 100)
            Particle.posX = 0.5 * acceleration * (trbTime.Value / 100) ^ 2
        End If
    End Sub

    Private Sub tmrCalculation_Tick(sender As Object, e As EventArgs) Handles tmrCalculation.Tick
        Dim velocity As Single
        velocity = GetResultant() * (Now - timeStart).TotalSeconds
        Particle.posX += velocity * scalar

    End Sub

    Function GetResultant() As Single
        If force < coeFriction * weight Then
            Return 0
        Else
            Return force - coeFriction * weight
        End If
    End Function

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        updateValues()
    End Sub

    Private Sub updFrictionCOE_ValueChanged(sender As Object, e As EventArgs) Handles updFrictionCOE.ValueChanged
        updateValues()
    End Sub

    Public Sub updateValues()

        coeFriction = updFrictionCOE.Value
        mass = updMass.Value
        weight = GetGravityAcceleration(cboAcceleration) * mass
        lblResultantForce.Text = String.Format("Resultant Force: {0}N", Math.Round(GetResultant, 3))
        lblMaxFriction.Text = String.Format("Max Friction: {0}N", Math.Round(coeFriction * weight, 3))
        If force < coeFriction * weight Then
            lblTotalFriction.Text = String.Format("Friction: {0}N", Math.Round(force, 3))
        Else
            lblTotalFriction.Text = String.Format("Friction: {0}N", Math.Round(coeFriction * weight, 3))
        End If
        acceleration = GetResultant() / mass
        lblAcceleration.Text = String.Format("Accleration: {0}ms^-2", Math.Round(acceleration, 3))
    End Sub


End Class