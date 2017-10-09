Public Class MenuForm
    Private Sub ProjectileBtn_Click(sender As Object, e As EventArgs) Handles projectileBtn.Click
        Dim ProjectileF As ProjectileForm = New ProjectileForm
        ProjectileF.Show()

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub
End Class