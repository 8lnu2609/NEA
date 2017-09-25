Public Class MenuForm
    Private Sub ProjectileBtn_Click(sender As Object, e As EventArgs) Handles projectileBtn.Click
        Dim Form As physicsForm = New physicsForm(sim.projectile)
        Form.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub
End Class