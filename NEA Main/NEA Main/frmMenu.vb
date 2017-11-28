Public Class frmMenu
    Private Sub cmdProjectileSim_Click(sender As Object, e As EventArgs) Handles cmdProjectileSim.Click
        Dim Projectiles As New frmProjectile
        Projectiles.Show()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdProjectileCal_Click(sender As Object, e As EventArgs) Handles cmdProjectileCal.Click
        Dim Cal As New frmProjectileCal
        Cal.Show()
    End Sub

    Private Sub cmdForceSim_Click(sender As Object, e As EventArgs) Handles cmdForceSim.Click
        Dim Forces As New frmForcesFlat
        Forces.Show()
    End Sub

    Private Sub cmdForceCal_Click(sender As Object, e As EventArgs) Handles cmdForceCal.Click
        Dim Cal As New frmForcesCal
        Cal.Show()
    End Sub

    Private Sub cmdTurningCal_Click(sender As Object, e As EventArgs) Handles cmdTurningCal.Click
        Dim Cal As New frmTurningPointsCalculator
        Cal.Show()
    End Sub

    Private Sub cmdTurningSim_Click(sender As Object, e As EventArgs) Handles cmdTurningSim.Click
        Dim Turning As New frmTurningPoints
        Turning.Show()
    End Sub
End Class