Imports System.ComponentModel
Public Class frmMomentumCal
    Dim COEofRestitution As Single
    Dim leftMass, rightMass, leftVelocity, rightVelocity As Single
    Dim leftDirection As LeftRight = LeftRight.Left
    Dim rightDirection As LeftRight = LeftRight.Right
    Dim leftArrow As Bitmap
    Dim rightArrow As Bitmap

    Enum LeftRight
        Left = 1
        Right = -1
    End Enum

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
        getImages()

    End Sub

    Sub GetImages()
        Dim rBmp As New Bitmap(100, 23)
        Dim rgBmp As Graphics = Graphics.FromImage(rBmp)
        Using myPen As New Pen(Color.Black, 4)
            myPen.CustomEndCap = New Drawing2D.AdjustableArrowCap(5, 6)
            rgBmp.DrawLine(myPen, 0, 11, 100, 11)
            rightArrow = New Bitmap(rBmp)
            cmdLeftInitalDirection.BackgroundImage = rightArrow
        End Using

        Dim lBmp As New Bitmap(100, 23)
        Dim lgBmp As Graphics = Graphics.FromImage(lBmp)
        Using myPen As New Pen(Color.Black, 4)
            myPen.CustomEndCap = New Drawing2D.AdjustableArrowCap(5, 6)
            lgBmp.DrawLine(myPen, 100, 11, 0, 11)
            leftArrow = New Bitmap(lBmp)
            cmdRightInitalDirection.BackgroundImage = leftArrow
        End Using
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Public Sub TextBox_Leave_Handler(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(sender.text) And Not IsNumeric(sender.Text) Then
            MessageBox.Show(String.Format("The {0} textbox must have a number in it", sender.Tag), "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
        End If
    End Sub

    Private Sub CmdLeftInitalDirection_Click(sender As Object, e As EventArgs) Handles cmdLeftInitalDirection.Click
        SetPicture(leftDirection, cmdLeftInitalDirection.BackgroundImage)
        leftDirection = -1 * leftDirection
    End Sub

    Private Sub CmdRightInitalDirection_Click(sender As Object, e As EventArgs) Handles cmdRightInitalDirection.Click
        SetPicture(rightDirection, cmdRightInitalDirection.BackgroundImage)
        rightDirection = -1 * rightDirection
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

    Private Sub CmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        If CheckInputs() Then
            Dim returns() As Single = Maths.SimultaneousSolve(leftMass, rightMass, (leftMass * leftVelocity * leftDirection + rightMass * rightVelocity * rightDirection),
                                                                  -1, 1, COEofRestitution * (leftVelocity * leftDirection - rightVelocity * rightDirection))
            txtVelocityLeftFinal.Text = Math.Abs(returns(0))
            txtVelocityRightFinal.Text = Math.Abs(returns(1))
            SetPicture(-returns(0), picLeftFinalDirection.BackgroundImage)
            SetPicture(-returns(1), picRightFinalDirection.BackgroundImage)
        End If
    End Sub

    Sub SetPicture(value As Single, ByRef pic As Image)
        If value = 0 Then
            pic = New Bitmap(1, 1)
        ElseIf value > 0 Then
            pic = leftArrow
        Else
            pic = rightArrow
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