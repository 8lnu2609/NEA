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
    End Sub

    Structure SUVAT
        Dim s As Single?
        Dim u As Single?
        Dim v As Single?
        Dim a As Single?
        Dim t As Single?
    End Structure

    Private Sub cmdSolveY_Click(sender As Object, e As EventArgs) Handles cmdSolveY.Click
        Dim yComp As SUVAT

        Dim yEmpty As IEnumerable(Of TextBox) = grbComponentsY.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim messageString As String = ""
        If yEmpty.Count > 2 Then
            messageString = String.Format("You need to fill in {0} of the remaining {1} vertical boxes: {2}. " & vbNewLine, yEmpty.Count - 2, yEmpty.Count, String.Join(", ", (yEmpty.Select(Function(y) y.Tag))))
        End If

        If messageString <> "" Then
            MessageBox.Show(messageString, "Not enough inputs filled in")
        Else
            GetYInputs(yComp)
            Try
                If Single.IsNaN(yComp.s) Then
                    txtDisplacementY_In.Text = Maths.Displacement(yComp.u, yComp.v, yComp.a, yComp.t)
                End If
                If Single.IsNaN(yComp.u) Then
                    txtInitalVelocityY_In.Text = Maths.InitalVelocity(yComp.s, yComp.v, yComp.a, yComp.t)
                End If
                If Single.IsNaN(yComp.v) Then
                    txtFinalVelocityY_In.Text = Maths.FinalVelocity(yComp.s, yComp.u, yComp.a, yComp.t)
                End If
                If Single.IsNaN(yComp.a) Then
                    txtAccelerationY_In.Text = Maths.Acceleration(yComp.s, yComp.u, yComp.v, yComp.t)
                End If
                If Single.IsNaN(yComp.t) Then
                    txtTimeY_In.Text = Maths.Time(yComp.s, yComp.u, yComp.v, yComp.a)
                End If
            Catch
                MessageBox.Show("That calculation was not possible")
            End Try

        End If


    End Sub
    Private Sub cmdSolveX_Click(sender As Object, e As EventArgs) Handles cmdSolveX.Click
        Dim xComp As SUVAT
        Dim xEmpty As IEnumerable(Of TextBox) = grbComponentsX.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim messageString As String = ""
        If xEmpty.Count > 2 Then
            messageString = messageString & String.Format("You need to fill in {0} of the remaining {1} horizontal boxes: {2}. ", xEmpty.Count - 2, xEmpty.Count, (String.Join(", ", (xEmpty.Select(Function(x) x.Tag)))))
        End If
        If messageString <> "" Then
            MessageBox.Show(messageString, "Not enough inputs filled in")
        Else
            GetXInputs(xComp)
            Try
                If Single.IsNaN(xComp.s) Then
                    txtDisplacementX_In.Text = Maths.Displacement(xComp.u, xComp.v, xComp.a, xComp.t)
                End If
                If Single.IsNaN(xComp.u) Then
                    txtInitalVelocityX_In.Text = Maths.InitalVelocity(xComp.s, xComp.v, xComp.a, xComp.t)
                End If
                If Single.IsNaN(xComp.v) Then
                    txtFinalVelocityX_In.Text = Maths.FinalVelocity(xComp.s, xComp.u, xComp.a, xComp.t)
                End If
                If Single.IsNaN(xComp.a) Then
                    txtAccelerationX_In.Text = Maths.Acceleration(xComp.s, xComp.u, xComp.v, xComp.t)
                End If
                If Single.IsNaN(xComp.t) Then
                    txtTimeX_In.Text = Maths.Time(xComp.s, xComp.u, xComp.v, xComp.a)
                End If
            Catch
                MessageBox.Show("That calculation was not possible")
            End Try


        End If
    End Sub
    Sub GetYInputs(ByRef yComponents As SUVAT)
        yComponents.s = dataOrNull(txtDisplacementY_In)
        yComponents.u = dataOrNull(txtInitalVelocityY_In)
        yComponents.v = dataOrNull(txtFinalVelocityY_In)
        yComponents.a = dataOrNull(txtAccelerationY_In)
        yComponents.t = dataOrNull(txtTimeY_In)
    End Sub

    Sub GetXInputs(ByRef xComponents As SUVAT)
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
            Return Single.NaN
        End If
    End Function

    Sub TextBoxLeave_Handler(ByVal sender As TextBox, ByVal e As EventArgs)
        If sender.Text <> "" And Not IsNumeric(sender.Text) Then
            MessageBox.Show(String.Format("The {0} textbox must have a number in it", sender.Tag), "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
        End If
    End Sub


End Class