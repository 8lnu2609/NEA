Public Class ProjectileForm
    Dim MouseHeldDown As Boolean = False
    Dim mouseLocation As New Point
    Dim velocityIn As VelocityInput = New VelocityInput
    Dim projectle As Circle
    Dim arc As Parabolic = New Parabolic
    Dim startTime As DateTime
    Dim xVelocity As Single
    Dim yVelocity As Single

    Private Sub PhysicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawTimer.Interval = 1
        drawTimer.Start()
        dropTimer.Interval = 50
        dropTimer.Start()
        velocityIn.Show()
    End Sub

    'Private Sub PicBoxMain_MouseDown(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseDown
    '    'If e.Button = MouseButtons.Left Then
    '    '    MouseHeldDown = True
    '    'End If
    'End Sub

    'Private Sub PicBoxMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseMove
    '    'If e.X > 0 And e.X < picBoxMain.Width And e.Y > 0 And e.Y < picBoxMain.Height Then
    '    '    mouseLocation = New Point(e.X, e.Y)
    '    'End If
    'End Sub

    'Private Sub PicBoxMain_MouseUp(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseUp
    '    'If e.Button = MouseButtons.Left Then
    '    '    MouseHeldDown = False
    '    'End If
    'End Sub

    Private Sub PicBoxMain_Paint(sender As Object, e As PaintEventArgs) Handles picBoxMain.Paint
        DrawGrid(e)
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles drawTimer.Tick
        picBoxMain.Refresh()
    End Sub

    Private Sub DrawGrid(e As PaintEventArgs)
        Dim myPen As New Pen(Color.FromArgb(25, 0, 0, 0))
        For iCounter = 0 To picBoxMain.Width Step Shape.WIDTH
            e.Graphics.DrawLine(myPen, iCounter, 0, iCounter, picBoxMain.Height)
        Next
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
        velocityIn.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles startButton.Click

    End Sub

    Private Sub dropTimer_Tick(sender As Object, e As EventArgs) Handles dropTimer.Tick
        yVelIn.Text = SharedVariables.yVelocity
        xVelIn.Text = SharedVariables.xVelocity
    End Sub
End Class