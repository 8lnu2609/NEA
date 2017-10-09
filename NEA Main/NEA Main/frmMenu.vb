Public Class frmMenu
    Private Sub cmdProjectileSim_Click(sender As Object, e As EventArgs) Handles cmdProjectileSim.Click
        Dim Projectiles As New frmProjectile
        Projectiles.Show()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class