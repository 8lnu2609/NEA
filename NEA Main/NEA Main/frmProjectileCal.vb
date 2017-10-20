Public Class frmProjectileCal
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub frmProjectileCal_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each Control As Control In grbComponentsY.Controls
            If Control.GetType = GetType(TextBox) Then
                Dim TextBox As TextBox = DirectCast(Control, TextBox)
                AddHandler TextBox.Leave, AddressOf TextBoxLeave_Handler
            End If
        Next

        For Each Control As Control In grbComponentsX.Controls
            If Control.GetType = GetType(TextBox) Then
                Dim TextBox As TextBox = DirectCast(Control, TextBox)
                AddHandler TextBox.Leave, AddressOf TextBoxLeave_Handler
            End If
        Next
    End Sub

    Structure SUVAT
        Dim s As Single
        Dim u As Single
        Dim v As Single
        Dim a As Single
        Dim t As Single
    End Structure

    Private Sub cmdSolve_Click(sender As Object, e As EventArgs) Handles cmdSolve.Click
        Dim yEmpty As IEnumerable(Of TextBox) = grbComponentsY.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim xEmpty As IEnumerable(Of TextBox) = grbComponentsX.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)

        If yEmpty.Count > 2 Then
            MessageBox.Show("You need to fill in " & String.Join(", ", (yEmpty.Select(Function(y) y.Tag))))
        End If
        If xEmpty.Count > 2 Then
            MessageBox.Show(String.Join(", ", (xEmpty.Select(Function(x) x.Tag))))
        End If
    End Sub

    Private Sub txtTimeY_In_TextChanged(sender As Object, e As EventArgs) Handles txtTimeY_In.TextChanged
        txtTimeX_In.Text = sender.text
    End Sub

    Sub TextBoxLeave_Handler(ByVal sender As TextBox, ByVal e As EventArgs)
        If sender.Text <> "" And Not IsNumeric(sender.Text) Then
            MessageBox.Show(String.Format("The {0} textbox must have a number in it", sender.Tag), "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
        End If
    End Sub

End Class