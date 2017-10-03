Public Class ProjectileForm
    Dim MouseHeldDown As Boolean = False
    Dim mouseLocation As New Point
    Dim velocityIn As VelocityInput = New VelocityInput
    Dim projectle As Circle = New Circle With {
    .posX = Shape.WIDTH / 2,
    .posY = 1020 - Shape.WIDTH / 2
    }
    Dim arc As Parabolic = New Parabolic
    Dim startTime As DateTime
    Dim xVelocity As Single
    Dim yVelocity As Single
    Const BOXWIDTH As Integer = 1670
    Const BOXHEIGHT As Integer = 1020
    Dim AccelerationDictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
            {"Sun", 274.13},
            {"Mercury", 3.59},
            {"Venus", 8.89}
"Earth", 9.81	
"Moon", 1.62	
"Mars", 3.77	
"Jupiter", 25.95	
"Saturn", 11.08	
"Uranus", 10.67	
"Neptune", 14.07	
"Pluto", 0.42	
        }
    Private Sub PhysicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawTimer.Interval = 1
        drawTimer.Start()
        dropTimer.Interval = 1
        velocityIn.Show()

        For Each pair As KeyValuePair(Of String, Integer) In AccelerationDictionary
            AccelerationCombo.Items.Add(pair.Key)
        Next
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
        yVelIn.Text = SharedVariables.yVelocity
        xVelIn.Text = SharedVariables.xVelocity
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
        dropTimer.Start()
        startTime = Now
    End Sub

    Private Sub DropTimer_Tick(sender As Object, e As EventArgs) Handles dropTimer.Tick
        If projectle.posY >= 0 Then
            projectle.posX += xVelocity * (Now - startTime).TotalSeconds
            projectle.posY += yVelocity * (Now - startTime).TotalSeconds -
        Else
            dropTimer.Stop()
        End If
    End Sub
End Class