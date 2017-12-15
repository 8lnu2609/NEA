Public Class frmForcesCal

    Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        For Each Control As Control In Controls
            If Control.GetType = GetType(TextBox) Then
                Dim TextBox As TextBox = DirectCast(Control, TextBox)
                AddHandler TextBox.Leave, AddressOf TextBoxLeave_Handler
            End If
        Next
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, AccelerationDictionary.Item(cboGravity.SelectedItem) & "m/s²")
    End Sub

    Sub TextBoxLeave_Handler(ByVal sender As TextBox, ByVal e As EventArgs)
        If sender.Text <> "" And Not IsNumeric(sender.Text) Then
            MessageBox.Show(String.Format("The {0} textbox must have a number in it", sender.Tag), "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
        End If
    End Sub

End Class