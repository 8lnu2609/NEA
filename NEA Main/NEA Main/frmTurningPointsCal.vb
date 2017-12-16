Public Class frmTurningPointsCal
    Dim objectList As New List(Of KeyValuePair(Of Int32, Int32))

    Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
    End Sub

    Sub RefreshListBox()
        lstObjects.Items.Clear()
        For Each pair As KeyValuePair(Of Int32, Int32) In objectList
            lstObjects.Items.Add(String.Format("{0}kg, {1}m", pair.Key, pair.Value))
        Next
        cmdRemove.Enabled = False
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, AccelerationDictionary.Item(cboGravity.SelectedItem) & "m/s²")
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        cboGravity.Enabled = False
        Dim massIn, distanceIn As New NumberInput
        distanceIn.updNumber.Minimum = -1000
        Dim mass, distance As Single

        If massIn.ShowDialog("Enter the mass of the new object") = DialogResult.OK And distanceIn.ShowDialog("Enter the distance from the turning point of the new object") = DialogResult.OK Then
            mass = massIn.Result
            distance = distanceIn.Result
            objectList.Add(New KeyValuePair(Of Integer, Integer)(mass, distance))
            RefreshListBox()
        End If


    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If lstObjects.SelectedIndex <> -1 Then
            objectList.RemoveAt(lstObjects.SelectedIndex)
            RefreshListBox()
        End If
        If lstObjects.Items.Count() = 0 Then
            cboGravity.Enabled = True
        End If
    End Sub

    Private Sub lstObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObjects.SelectedIndexChanged
        If lstObjects.SelectedIndex = -1 Then
            cmdRemove.Enabled = False
        Else
            cmdRemove.Enabled = True
        End If

    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim moment As Single = 0
        For Each pair In objectList
            moment += pair.Key * GetGravityAcceleration(cboGravity) * pair.Value
        Next
        If moment <> 0 Then
            MessageBox.Show("The moment acting about the point is " & moment & "Nm")
        Else
            MessageBox.Show("The system is in equilibrium")
        End If
    End Sub
End Class