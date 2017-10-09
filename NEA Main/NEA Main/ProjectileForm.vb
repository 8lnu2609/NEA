Public Class ProjectileForm
    Dim MouseHeldDown As Boolean = False
    Dim mouseLocation As New Point
    Dim velocityIn As VelocityInput = New VelocityInput
    Dim projectle As Circle = New Circle With {
    .posX = 0,
    .posY = BOXHEIGHT - Shape.WIDTH / 2
    }
    Dim arc As Parabolic = New Parabolic
    Dim startTime As DateTime
    Dim xVelocity As Single
    Dim yVelocity As Single
    Const BOXWIDTH As Integer = 1670
    Const BOXHEIGHT As Integer = 1020
    Dim totalTime As Single
    Dim range As Single
    Dim maxHeight
    Dim scalar As Integer = 1
    Dim AccelerationDictionary As Dictionary(Of String, Single) = New Dictionary(Of String, Single) From {
        {"Sun", 274.13},
        {"Mercury", 3.59},
        {"Venus", 8.89},
        {"Earth", 9.81},
        {"Moon", 1.62},
        {"Mars", 3.77},
        {"Jupiter", 25.95},
        {"Saturn", 11.08},
        {"Uranus", 10.67},
        {"Neptune", 14.07},
        {"Pluto", 0.42}
        }

    Private Sub PhysicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawTimer.Interval = 1
        drawTimer.Start()
        dropTimer.Interval = 1

        For Each pair As KeyValuePair(Of String, Single) In AccelerationDictionary
            AccelerationCombo.Items.Add(String.Format("{0}, {1}ms^-2", pair.Key, pair.Value))
        Next
        AccelerationCombo.SelectedIndex = 3
        velocityIn.ShowDialog()
        UpdateValues()

    End Sub

    Function GetAcceleration() As Single
        Return AccelerationDictionary.Item(AccelerationCombo.SelectedItem().ToString.Split(",")(0))
    End Function

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
        projectle.Draw(e)
        arc.Draw(e)
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles drawTimer.Tick
        picBoxMain.Refresh()
        If Not (SharedVariables.xVelocity = 0 Or SharedVariables.yVelocity = 0) Then
            For i = 0 To 500 Step 1
                arc.ArcPoints(i) = New Point(i * BOXWIDTH / 500 + Shape.WIDTH / 2, BOXHEIGHT - GetYPos(i * BOXWIDTH / 500, GetAcceleration))
            Next
        End If
    End Sub

    Function GetYPos(x As Integer, Acceleration As Single) As Single
        Return SharedVariables.yVelocity * (x / SharedVariables.xVelocity) + 0.5 * -Acceleration * (x / SharedVariables.xVelocity) ^ 2
    End Function

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
        projectle.posX += SharedVariables.xVelocity * (Now - startTime).TotalSeconds
        projectle.posY -= SharedVariables.yVelocity * (Now - startTime).TotalSeconds - 0.5 * GetAcceleration() * (Now - startTime).TotalSeconds ^ 2
        startTime = Now
    End Sub

    Private Sub RealTimeRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RealTimeRadio.CheckedChanged
        If RealTimeRadio.Checked Then
            TimeTrackBar.Hide()
            startButton.Show()
        Else
            TimeTrackBar.Show()
            startButton.Hide()
        End If
    End Sub

    Private Sub ShowVelocity_Click(sender As Object, e As EventArgs) Handles ShowVelocity.Click
        velocityIn.ShowDialog()
        UpdateValues()

    End Sub

    Private Sub TimeTrackBar_Scroll(sender As Object, e As EventArgs) Handles TimeTrackBar.Scroll
        If StepByStepRadio.Checked Then
            ToolTips.SetToolTip(TimeTrackBar, "Time: " & TimeTrackBar.Value / 100)
            projectle.posX = SharedVariables.xVelocity * (TimeTrackBar.Value / 100)
            projectle.posY = BOXHEIGHT - Shape.WIDTH / 2 - (SharedVariables.yVelocity * (TimeTrackBar.Value / 100) + -0.5 * GetAcceleration() * (TimeTrackBar.Value / 100) ^ 2)
        End If
    End Sub

    Sub UpdateValues()
        totalTime = Maths.QuadraticSolve(-0.5 * GetAcceleration(), SharedVariables.yVelocity, 0)
        range = SharedVariables.xVelocity * totalTime
        maxHeight = (-SharedVariables.yVelocity) / (2 * -GetAcceleration())
        TimeTrackBar.Maximum = totalTime * 100
        TimeLabel.Text = "Total time of flight: " & totalTime
        RangeLabel.Text = "Range: " & range
        MaxHeightLabel.Text = "Max height: " & maxHeight
    End Sub

    Private Sub AccelerationCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccelerationCombo.SelectedIndexChanged
        UpdateValues()
    End Sub

End Class