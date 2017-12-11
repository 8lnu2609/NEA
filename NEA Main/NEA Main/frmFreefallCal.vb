Public Class frmFreefallCal

    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        For Each control As Control In Controls
            If control.GetType = GetType(NumericUpDown) Then
                Dim upd As NumericUpDown = DirectCast(control, NumericUpDown)
                AddHandler upd.ValueChanged, AddressOf Calculate
            End If
        Next


    End Sub

    Sub Calculate()
        lblTime.Text = String.Format("Time taken (s): {0}", Maths.Time(updHeight.Value, 0, Single.NaN, GetGravityAcceleration(cboGravity)))
    End Sub


    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, AccelerationDictionary.Item(cboGravity.SelectedItem))
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

End Class