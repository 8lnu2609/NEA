Public Class frmProjectileSim
    Dim BOXWIDTH As Int32
    Dim BOXHEIGHT As Int32
    Dim StartTime As Date
    Dim TotalTime As Double
    Dim Range As Double
    Dim MaxHeight As Double
    Dim Scalar As Double = 1
    Dim MouseLocation As New Point
    Dim VelocityInput As New frmVelocityInput
    Dim TracingArc As New ParabolicArc
    Dim Projectile As Circle

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overloads Sub ShowDialog()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        Projectile = New Circle With {
            .PosX = 0,
            .PosY = BOXHEIGHT - (Shape.WIDTH)
            }
        VelocityInput.ShowDialog()
        MyBase.ShowDialog()
    End Sub

    Private Sub PhysicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAccelerationCbo(cboAcceleration)
        Range = BOXWIDTH
        UpdateValues()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
        VelocityInput.Close()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        tmrCalculation.Start()
        Projectile.PosX = 0
        Projectile.PosY = BOXHEIGHT - Shape.WIDTH
        StartTime = Now
    End Sub

    Private Sub cboAcceleration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcceleration.SelectedIndexChanged
        ToolTips.SetToolTip(cboAcceleration, AccelerationDictionary.Item(cboAcceleration.SelectedItem()) & "m/s²")
        UpdateValues()
    End Sub

    Private Sub trbZoom_Scroll(sender As Object, e As EventArgs) Handles trbZoom.Scroll
        If trbZoom.Value > 0 Then
            Scalar = trbZoom.Value
            lblZoomLevel.Text = String.Format("Zoom: {0}x", trbZoom.Value)
        Else
            Scalar = 1 / (Math.Abs(trbZoom.Value) + 2)
            lblZoomLevel.Text = String.Format("Zoom: 1/{0}x", Math.Abs(trbZoom.Value) + 2)
        End If
        UpdateValues()

    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
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
            TracingArc.ArcPoints(i) = New Point(((i * Range / 500) * Scalar) + Shape.WIDTH / 2, BOXHEIGHT - (Shape.WIDTH / 2) - (GetYPosition(i * Range / 500, GetGravityAcceleration(cboAcceleration)) * Scalar))
        Next
    End Sub

    Function GetYPosition(x As Single, Acceleration As Double) As Double
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
        If Projectile.PosX < Range * Scalar Then
            Projectile.PosX = (xVelocity * (Now - StartTime).TotalSeconds) * Scalar
            Projectile.PosY = (BOXHEIGHT - Shape.WIDTH) - ((yVelocity * (Now - StartTime).TotalSeconds - 0.5 * GetGravityAcceleration(cboAcceleration) * (Now - StartTime).TotalSeconds ^ 2) * Scalar)
            lblDistanceDisplay.Text = "Distance: " & Math.Round((xVelocity * (Now - StartTime).TotalSeconds), 3) & "m"
            lblHeightDisplay.Text = "Height: " & Math.Round((yVelocity * (Now - StartTime).TotalSeconds - 0.5 * GetGravityAcceleration(cboAcceleration) * (Now - StartTime).TotalSeconds ^ 2), 3) & "m"

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
            Projectile.PosX = (xVelocity * (trbTime.Value / 100)) * Scalar
            Projectile.PosY = (BOXHEIGHT - Shape.WIDTH) - ((yVelocity * (trbTime.Value / 100) + -0.5 * GetGravityAcceleration(cboAcceleration) * (trbTime.Value / 100) ^ 2) * Scalar)
            lblDistanceDisplay.Text = "Distance: " & Math.Round((xVelocity * (trbTime.Value / 100)), 3) & "m"
            lblHeightDisplay.Text = "Height: " & Math.Round((yVelocity * (trbTime.Value / 100) + -0.5 * GetGravityAcceleration(cboAcceleration) * (trbTime.Value / 100) ^ 2), 3) & "m"
        End If
    End Sub

    Sub UpdateValues()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        TotalTime = Maths.QuadraticSolve(-0.5 * GetGravityAcceleration(cboAcceleration), yVelocity, 0)
        Range = xVelocity * TotalTime
        MaxHeight = (yVelocity) ^ 2 / (2 * GetGravityAcceleration(cboAcceleration))
        trbTime.Maximum = TotalTime * 100
        lblTotalTime.Text = "Total time of flight: " & Math.Round(TotalTime, 3) & "s"
        lblRange.Text = "Range: " & Math.Round(Range, 3) & "m"
        lblMaxHeightDisplay.Text = "Max height: " & Math.Round(MaxHeight, 3) & "m"
        tmrCalculation.Stop()
        Projectile.PosX = 0
        Projectile.PosY = BOXHEIGHT - Shape.WIDTH
        GetArcPoints()
    End Sub

End Class