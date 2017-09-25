Public Class VelocityInput
    Dim MouseIsDown As Boolean = False
    Dim XLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 120,
        .posYe = 300,
        .LineWidth = 2
    }

    Dim YLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 20,
        .posYe = 200,
        .LineWidth = 2
    }

    Private Sub MainPicBox_MouseMove(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseMove

        If MouseIsDown Then

        End If
    End Sub

    Private Sub MainPicBox_MouseDown(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseDown
        MouseIsDown = True
    End Sub

    Private Sub MainPicBox_MouseUp(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseUp
        MouseIsDown = False
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        MainPicBox.Refresh()

    End Sub

    Private Sub MainPicBox_Paint(sender As Object, e As PaintEventArgs) Handles MainPicBox.Paint
        XLine.Draw(e)
        YLine.Draw(e)
    End Sub

    Private Sub VelocityInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textMask As String = "1"
        HorzTextIn.Mask = textMask
        VertTextIn.Mask = textMask
    End Sub
End Class