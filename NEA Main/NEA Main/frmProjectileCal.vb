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
        Dim s As Single?
        Dim u As Single?
        Dim v As Single?
        Dim a As Single?
        Dim t As Single?
    End Structure

    Enum SUVATName
        s = 0
        u = 1
        v = 2
        a = 3
        t = 4
    End Enum

    Private Sub cmdSolve_Click(sender As Object, e As EventArgs) Handles cmdSolve.Click
        Dim yComp, xComp As SUVAT
        'Dim yComponents(4), xComponents(4) As Single?

        Dim yEmpty As IEnumerable(Of TextBox) = grbComponentsY.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim xEmpty As IEnumerable(Of TextBox) = grbComponentsX.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim messageString As String = ""
        If yEmpty.Count > 2 Then
            messageString = String.Format("You need to fill in {0} of the remaining {1} vertical boxes: {2}. " & vbNewLine, yEmpty.Count - 2, yEmpty.Count, String.Join(", ", (yEmpty.Select(Function(y) y.Tag))))
        End If
        If xEmpty.Count > 2 Then
            messageString = messageString & String.Format("You need to fill in {0} of the remaining {1} horizontal boxes: {2}. ", xEmpty.Count - 2, xEmpty.Count, (String.Join(", ", (xEmpty.Select(Function(x) x.Tag)))))
        End If
        If messageString <> "" Then
            MessageBox.Show(messageString, "Not enough inputs filled in")
        Else
            GetInputs(xComp, yComp)
            txtDisplacementY_In.Text = Maths.Displacement(yComp.u, yComp.v, yComp.a, yComp.t)
            txtInitalVelocityY_In.Text = Maths.InitalVelocity(yComp.s, yComp.v, yComp.a, yComp.t)
            txtFinalVelocityY_In.Text = Maths.FinalVelocity(yComp.s, yComp.u, yComp.a, yComp.t)
            txtAccelerationY_In.Text = Maths.Acceleration(yComp.s, yComp.u, yComp.v, yComp.t)
            txtTimeY_In.Text = Maths.Time(yComp.s, yComp.u, yComp.v, yComp.a)

        End If


    End Sub

    Sub GetInputs(ByRef yComponents As SUVAT, ByRef xComponents As SUVAT)
        yComponents.s = dataOrNull(txtAccelerationY_In)
        yComponents.u = dataOrNull(txtInitalVelocityY_In)
        yComponents.v = dataOrNull(txtFinalVelocityY_In)
        yComponents.a = dataOrNull(txtAccelerationY_In)
        yComponents.t = dataOrNull(txtTimeY_In)

        xComponents.s = dataOrNull(txtDisplacementX_In)
        xComponents.u = dataOrNull(txtInitalVelocityX_In)
        xComponents.v = dataOrNull(txtFinalVelocityX_In)
        xComponents.a = dataOrNull(txtAccelerationX_In)
        xComponents.t = dataOrNull(txtTimeX_In)
    End Sub


    Function dataOrNull(txtBox As TextBox) As Single?
        If txtBox.Text <> "" And IsNumeric(txtBox.Text) Then
            Return Convert.ToSingle(txtBox.Text)
        Else
            Return vbNull
        End If
    End Function

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