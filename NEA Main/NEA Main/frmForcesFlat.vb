Public Class frmForcesFlat
    Dim baseLine As New Line With
    {
        .posY = BOXHEIGHT / 2 + 100,
        .posYe = BOXHEIGHT / 2 + 100,
        .posX = 0,
        .posXe = BOXWIDTH,
        .LineWidth = 20
    }
    Dim Particle As New Square With
        {
        .posX = 0,
        .posY = BOXHEIGHT / 2 + 89 - Shape.WIDTH
        }
    Dim force As Single
    Dim mass As Single
    Dim coeFriction As Single
    Dim scalar As Single = 1
    Dim timeStart As DateTime
    Dim weight As Single
    Dim resultantForce As Single

    Private Sub frmForcesFlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAccelerationCbo(cboAcceleration)
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        baseLine.Draw(e)
        Particle.Draw(e)
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
    End Sub

    Private Sub updForce_ValueChanged(sender As Object, e As EventArgs) Handles updForce.ValueChanged
        force = updForce.Value
        trbForce.Value = Math.Log10(force) * 10
    End Sub

    Private Sub updTotalTime_ValueChanged(sender As Object, e As EventArgs) Handles updTotalTime.ValueChanged
        trbTime.Maximum = updTotalTime.Value
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
            scalar = 1 / (Math.Abs(trbZoom.Value) + 1)
            lblZoomLevel.Text = String.Format("Zoom: 1/{0}x", Math.Abs(trbZoom.Value) + 1)
        End If
    End Sub

    Private Sub cboAcceleration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcceleration.SelectedIndexChanged
        ToolTips.SetToolTip(cboAcceleration, AccelerationDictionary.Item(cboAcceleration.SelectedItem()) & "ms^-2")
    End Sub

    Private Sub cmdStartStop_Click(sender As Object, e As EventArgs) Handles cmdStartStop.Click
        If tmrCalculation.Enabled Then
            tmrCalculation.Stop()
            cmdStartStop.Text = "Start"
        Else
            Particle.posX = 0
            Particle.posY = BOXHEIGHT / 2 + 89 - Shape.WIDTH
            tmrCalculation.Start()
            timeStart = Now
            cmdStartStop.Text = "Stop"
        End If
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll

    End Sub

    Private Sub tmrCalculation_Tick(sender As Object, e As EventArgs) Handles tmrCalculation.Tick
        Dim velocity As Single
        velocity = velocity + getAcceleration() * (Now - timeStart).TotalSeconds
        Particle.posX += velocity
        lblForce.Text = velocity
        timeStart = Now
    End Sub

    Function GetResultant() As Single

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
        lblForce.Text = String.Format("Force: {0}N", force)
        lblMaxFriction.Text = String.Format("Max Friction: {0}N", coeFriction * weight)

    End Sub


End Class