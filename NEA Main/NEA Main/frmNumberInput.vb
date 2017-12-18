Public Class frmNumberInput
    Public Result As Single
    Public Overloads Function ShowDialog(ByVal titleText As String) As DialogResult
        Text = titleText
        lblPrompt.Text = titleText
        ShowDialog()
        Return DialogResult
    End Function

    Private Sub cmdEnter_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click
        DialogResult = DialogResult.OK
        Result = updNumber.Value
    End Sub

    Sub key_Click(sender As Object, e As KeyPressEventArgs) Handles updNumber.KeyPress
        If e.KeyChar = ChrW(27) Then
            DialogResult = DialogResult.Cancel
        End If
    End Sub

End Class