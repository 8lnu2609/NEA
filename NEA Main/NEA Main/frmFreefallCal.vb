Public Class frmFreefallCal
    Dim DragCOEDictionary As New Dictionary(Of String, Single) From {
        {"Sphere", 0.47},
        {"Half-sphere", 0.42},
        {"Cone", 0.5},
        {"Cube", 1.05},
        {"Angled cube", 0.8},
        {"Long cylinder", 0.82},
        {"Short cylinder", 1.15},
        {"Stream lined", 0.04}
    }


    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        For Each pair As KeyValuePair(Of String, Single) In DragCOEDictionary
            cboDragCOE.Items.Add(pair.Value)
        Next
    End Sub


    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, AccelerationDictionary.Item(cboGravity.SelectedItem))
    End Sub

    Private Sub cboDragCOE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDragCOE.SelectedIndexChanged

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class