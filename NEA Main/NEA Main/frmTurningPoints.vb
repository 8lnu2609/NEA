Public Class frmTurningPoints
    Const BOXWIDTH As Integer = 1686
    Const BOXHEIGHT As Integer = 1024
    Dim boxes(4) As Square
    Dim boxCount As Integer = -1
    Dim colours() As Color = {Color.FromName("Red"), Color.FromName("Blue"), Color.FromName("Green"), Color.FromName("Orange"), Color.FromName("Violet")}

    Public Sub New()
        InitializeComponent()
        tmrDraw.Start()
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawSeeSaw(e)
        If boxCount > -1 And boxCount < 5 Then
            For i = 0 To 4
                boxes(i).Draw(e, colours(i))
            Next
        End If


    End Sub

    Sub DrawSeeSaw(ByRef e As PaintEventArgs)
        Dim baseTriangle As New Triangle With {
            .up = True,
            .posY = BOXHEIGHT / 2 + Shape.WIDTH,
            .posX = BOXWIDTH / 2 - 50
        }
        Dim baseLine As New Line With {
            .posX = 50,
            .posXe = BOXWIDTH - 50,
            .posY = baseTriangle.posY,
            .posYe = .posY
        }
        baseTriangle.Draw(e, 100)
        baseLine.Draw(e, 10)

    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdAddBox_Click(sender As Object, e As EventArgs) Handles cmdAddBox.Click
        If boxCount < 5 Then
            boxCount += 1
            boxes(boxCount) = New Square With {
                .posX = 50,
                .posY = 50
            }
            clbBoxes.Items.Add(String.Format("{0} box", colours(boxCount).Name))
        End If
    End Sub
End Class