Public Class frmProjectile
    Const BOXWIDTH As Integer = 1686
    Const BOXHEIGHT As Integer = 1024
    Dim MouseHeldDown As Boolean = False
    Dim StartTime As Date
    Dim TotalTime As Single
    Dim Range As Single
    Dim MaxHeight As Single
    Dim Scalar As Single = 1
    Dim MouseLocation As New Point
    Dim VelocityInput As New frmVelocityInput
    Dim TracingArc As New ParabolicArc
    Dim Projectile As New Circle With {
    .posX = 0,
    .posY = BOXHEIGHT - Shape.WIDTH / 2
    }
    Dim AccelerationDictionary As New Dictionary(Of String, Single) From {
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
        For Each pair As KeyValuePair(Of String, Single) In AccelerationDictionary
            cboAcceleration.Items.Add(pair.Key)
        Next
        cboAcceleration.SelectedIndex = 3
        Range = BOXWIDTH
        VelocityInput.ShowDialog()
        UpdateValues()
        'MessageBox.Show(Size.ToString)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
        VelocityInput.Close()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        tmrCalculation.Start()
        Projectile.posX = 0
        Projectile.posY = BOXHEIGHT - Shape.WIDTH / 2
        StartTime = Now
    End Sub

    Private Sub cboAcceleration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcceleration.SelectedIndexChanged
        ToolTips.SetToolTip(cboAcceleration, AccelerationDictionary.Item(cboAcceleration.SelectedItem()) & "ms^-2")
        UpdateValues()
    End Sub

    Private Sub trbZoom_Scroll(sender As Object, e As EventArgs) Handles trbZoom.Scroll
        If trbZoom.Value > 0 Then
            Scalar = trbZoom.Value
            lblZoomLevel.Text = String.Format("Zoom: {0}x", trbZoom.Value)
        Else
            Scalar = 1 / (Math.Abs(trbZoom.Value) + 1)
            lblZoomLevel.Text = String.Format("Zoom: 1/{0}x", Math.Abs(trbZoom.Value) + 1)
        End If
        UpdateValues()

    End Sub

    Function GetAcceleration() As Single
        Return AccelerationDictionary.Item(cboAcceleration.SelectedItem())
    End Function

    'Private Sub PicBoxMain_MouseDown(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseDown
    '    'If e.Button = MouseButtons.Left Then
    '    '    blnMouseHeldDown = True
    '    'End If
    'End Sub

    'Private Sub PicBoxMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseMove
    '    'If e.X > 0 And e.X < picBoxMain.Width And e.Y > 0 And e.Y < picBoxMain.Height Then
    '    '    pntMouseLocation = New Point(e.X, e.Y)
    '    'End If
    'End Sub

    'Private Sub PicBoxMain_MouseUp(sender As Object, e As MouseEventArgs) Handles picBoxMain.MouseUp
    '    'If e.Button = MouseButtons.Left Then
    '    '    blnMouseHeldDown = False
    '    'End If
    'End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        'e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.High
        DrawGrid(e)
        txtVelocityY_Out.Text = yVelocity
        txtVelocityX_Out.Text = xVelocity
        Projectile.Draw(e)
        TracingArc.Draw(e)
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
        If VelocityInput.IsShowing Then
            UpdateValues()
        End If
    End Sub

    Sub GetArcPoints()
        For i = 0 To 500 Step 1
            TracingArc.ArcPoints(i) = New Point(((i * Range / 500) * Scalar) + Shape.WIDTH / 2, BOXHEIGHT - (GetYPosition(i * Range / 500, GetAcceleration) * Scalar))
        Next
    End Sub

    Function GetYPosition(x As Integer, Acceleration As Single) As Single
        If xVelocity <> 0 Then
            Return yVelocity * (x / xVelocity) + 0.5 * -Acceleration * (x / xVelocity) ^ 2
        Else
            Return 0
        End If
    End Function

    Private Sub DrawGrid(e As PaintEventArgs)
        Dim MyPen As New Pen(Color.FromArgb(25, 0, 0, 0))
        For iCounter = 0 To picDisplay.Width Step Shape.WIDTH
            e.Graphics.DrawLine(MyPen, iCounter, 0, iCounter, picDisplay.Height)
        Next
    End Sub

    Private Sub tmrCalculation_Tick(sender As Object, e As EventArgs) Handles tmrCalculation.Tick
        If Projectile.posX < Range * Scalar Then
            Projectile.posX = (xVelocity * (Now - StartTime).TotalSeconds) * Scalar
            Projectile.posY = (BOXHEIGHT - Shape.WIDTH / 2) - ((yVelocity * (Now - StartTime).TotalSeconds - 0.5 * GetAcceleration() * (Now - StartTime).TotalSeconds ^ 2) * Scalar)
            lblDistanceDisplay.Text = "Distance: " & Math.Round((xVelocity * (Now - StartTime).TotalSeconds), 3) & "m"
            lblHeightDisplay.Text = "Height: " & Math.Round((yVelocity * (Now - StartTime).TotalSeconds - 0.5 * GetAcceleration() * (Now - StartTime).TotalSeconds ^ 2), 3) & "m"

        Else
            tmrCalculation.Stop()
        End If
    End Sub

    Private Sub optRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles optRealTime.CheckedChanged
        If optRealTime.Checked Then
            trbTime.Hide()
            cmdStart.Show()
        Else
            trbTime.Show()
            cmdStart.Hide()
            tmrCalculation.Stop()
        End If
    End Sub

    Private Sub cmdShowVelocityIn_Click(sender As Object, e As EventArgs) Handles cmdShowVeloctiyIn.Click
        Range = BOXWIDTH
        VelocityInput.ShowDialog()
        UpdateValues()
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll
        If optStepByStep.Checked Then
            ToolTips.SetToolTip(trbTime, "Time: " & trbTime.Value / 100)
            Projectile.posX = (xVelocity * (trbTime.Value / 100)) * Scalar
            Projectile.posY = (BOXHEIGHT - Shape.WIDTH / 2) - ((yVelocity * (trbTime.Value / 100) + -0.5 * GetAcceleration() * (trbTime.Value / 100) ^ 2) / Scalar)
            lblDistanceDisplay.Text = "Distance: " & Math.Round((xVelocity * (trbTime.Value / 100)), 3) & "m"
            lblHeightDisplay.Text = "Height: " & Math.Round((yVelocity * (trbTime.Value / 100) + -0.5 * GetAcceleration() * (trbTime.Value / 100) ^ 2), 3) & "m"
        End If
    End Sub

    Sub UpdateValues()
        TotalTime = Maths.QuadraticSolve(-0.5 * GetAcceleration(), yVelocity, 0)
        Range = xVelocity * TotalTime
        MaxHeight = (-yVelocity) / (2 * -GetAcceleration())
        trbTime.Maximum = TotalTime * 100
        lblTotalTime.Text = "Total time of flight: " & TotalTime & "s"
        lblRange.Text = "Range: " & Range & "m"
        lblMaxHeightDisplay.Text = "Max height: " & MaxHeight & "m"
        tmrCalculation.Stop()
        Projectile.posX = 0
        Projectile.posY = BOXHEIGHT - Shape.WIDTH / 2
        GetArcPoints()
    End Sub

End Class