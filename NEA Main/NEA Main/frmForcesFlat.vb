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
        .posX = BOXWIDTH / 2,
        .posY = BOXHEIGHT / 2 + 89 - Shape.WIDTH
        }
    Dim Force As Single

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
            cmdStart.Show()
        Else
            trbTime.Show()
            updTotalTime.Show()
            lblTotalTime.Show()
            cmdStart.Hide()
            tmrCalculation.Stop()
        End If
    End Sub
End Class