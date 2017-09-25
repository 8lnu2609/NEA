Public Class physicsForm
    Dim MouseHeldDown As Boolean = False
    Dim mouseLocation As New Point
    Dim currentSim As Simulation

    Public Sub New(simIN As Int16)
        InitializeComponent()
        Select Case simIN
            Case Is = sim.projectile
                currentSim = New Projectiles(picBoxMain.Size)
        End Select

    End Sub

    Private Sub PhysicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawTimer.Interval = 1
        drawTimer.Start()
        dropTimer.Interval = 50
        dropTimer.Start()
    End Sub

    Private Sub PicBoxMain_MouseDown(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseDown
        'If e.Button = MouseButtons.Left Then
        '    MouseHeldDown = True
        'End If
        currentSim.MouseDown(e)

    End Sub

    Private Sub PicBoxMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseMove
        'If e.X > 0 And e.X < picBoxMain.Width And e.Y > 0 And e.Y < picBoxMain.Height Then
        '    mouseLocation = New Point(e.X, e.Y)
        'End If
        currentSim.MouseMove(e)
    End Sub

    Private Sub PicBoxMain_MouseUp(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseUp
        'If e.Button = MouseButtons.Left Then
        '    MouseHeldDown = False
        'End If
        currentSim.MouseUp(e)
    End Sub

    Private Sub PicBoxMain_Paint(sender As Object, e As PaintEventArgs) Handles picBoxMain.Paint
        'drawGrid(e)
        currentSim.paint(e)
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
    End Sub
End Class