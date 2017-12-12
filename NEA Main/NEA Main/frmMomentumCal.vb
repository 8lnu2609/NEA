Public Class frmMomentumCal
    Dim COEofRestitution As Single
    Dim leftMass, rightMass, leftVelocity, rightVelocity As Single

    Public Sub New()
        InitializeComponent()
        For Each control As Control In Controls
            If control.GetType = GetType(TextBox) Then
                AddHandler control.Leave, AddressOf TextBox_Leave_Handler
            End If
        Next
        For Each pair As KeyValuePair(Of String, Single) In MaterialDictionary
            cboMaterial.Items.Add(pair.Key)
        Next
        cboMaterial.Items.Add("Custom coefficient")
        cboMaterial.SelectedIndex = 0
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Public Sub TextBox_Leave_Handler(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(sender.text) And Not IsNumeric(sender.Text) Then
            MessageBox.Show(String.Format("The {0} textbox must have a number in it", sender.Tag), "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
        End If
    End Sub

    Sub CoeffcientChanged(sender As Object, e As EventArgs) Handles cboMaterial.SelectedIndexChanged, updRestitution.ValueChanged
        If cboMaterial.SelectedIndex <> cboMaterial.Items.Count - 1 Then
            updRestitution.Enabled = False
            COEofRestitution = MaterialDictionary.Item(cboMaterial.SelectedItem)
            ToolTips.SetToolTip(sender, COEofRestitution)
            updRestitution.Value = COEofRestitution
        Else
            updRestitution.Enabled = True
            COEofRestitution = updRestitution.Value
        End If
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        If CheckInputs() Then
            Dim returns() As Single = Maths.SimultaneousSolve(leftMass, rightMass, (leftMass * leftVelocity + rightMass * rightVelocity),
                                                                  -1, 1, COEofRestitution * (leftVelocity - rightVelocity))
            txtVelocityLeftFinal.Text = returns(0)
            txtVelocityRightFinal.Text = returns(1)
        End If
    End Sub

    Function CheckInputs() As Boolean
        Dim emptyBoxes As IEnumerable(Of TextBox) = grpLeft.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0).Concat(
            grpRight.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0))
        If emptyBoxes.Count() > 0 Then
            MessageBox.Show(String.Format("You need to fill in {0} more of the 4 textboxes: {1}", emptyBoxes.Count, String.Join(", ", emptyBoxes.Select(Function(x) x.Tag))), "Empty textboxes", MessageBoxButtons.OK)
            Return False
        Else
            leftMass = Single.Parse(txtMassLeft.Text)
            rightMass = Single.Parse(txtMassRight.Text)
            leftVelocity = Single.Parse(txtVelocityLeftInital.Text)
            rightVelocity = Single.Parse(txtVelocityRightInital.Text)
            Return True
        End If

    End Function

End Class