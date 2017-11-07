Public Class frmForcesFlat
    Const BOXWIDTH As Integer = 1686
    Const BOXHEIGHT As Integer = 1024
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
        Force = 10 ^ (trbForce.Value / 10)
        updForce.Value = Force
    End Sub

    Private Sub updForce_ValueChanged(sender As Object, e As EventArgs) Handles updForce.ValueChanged
        Force = updForce.Value
        trbForce.Value = Math.Log10(Force) * 10
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

    Function GetWeight() As Single
        Return AccelerationDictionary.Item(cboAcceleration.SelectedItem()) * updMass.Value
    End Function

    Function getAcceleration()
        If coeFriction * GetWeight() > force Then
            force = 0
        End If
        Return (force - (coeFriction * GetWeight())) / updMass.Value
    End Function

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
        Particle.posX = 0.5 * getAcceleration() * (Now - timeStart).TotalSeconds
    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        mass = updMass.Value
    End Sub

    Private Sub updFrictionCOE_ValueChanged(sender As Object, e As EventArgs) Handles updFrictionCOE.ValueChanged
        coeFriction = updFrictionCOE.Value
    End Sub
End Class