Public Class frmFreefall
    Const SHAPEWIDTH As Int16 = 50
    Dim BOXWIDTH, BOXHEIGHT As Int32
    Dim ball As New Circle With {
        .posX = 0,
        .posY = 0
    }
    Dim dropHeight As Single = 10
    Dim mass As Single = 10
    Dim fluidDensity As Single = 1.25
    Dim area As Single = 10
    Dim dragCOE As Single = 1
    Dim resultantForce As Single
    Dim accelerationGravity As Single
    Dim velocity As Single
    Dim timeStart As DateTime
    Dim ballHeight As Single

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picBoxDisplay.Width
        BOXHEIGHT = picBoxDisplay.Height
        ball.posX = BOXWIDTH / 2 - 50
        ball.posY = SHAPEWIDTH
        For Each control As Control In grpData.Controls
            If control.GetType = GetType(NumericUpDown) Then
                Dim upd As NumericUpDown = DirectCast(control, NumericUpDown)
                AddHandler upd.ValueChanged, AddressOf UpdateValues
            End If
        Next

    End Sub

    Private Sub picBoxMain_Paint(sender As Object, e As PaintEventArgs) Handles picBoxDisplay.Paint
        DrawCliff(e)
        ball.posY = (dropHeight - ballHeight) * ((BOXHEIGHT - (2 * SHAPEWIDTH)) / dropHeight) + SHAPEWIDTH
        ball.Draw(e, SHAPEWIDTH)
    End Sub

    Sub DrawCliff(e As PaintEventArgs)
        BOXHEIGHT = picBoxDisplay.Height
        e.Graphics.DrawRectangle(Pens.Black, 0, SHAPEWIDTH * 2, CInt(BOXWIDTH / 2), BOXHEIGHT - SHAPEWIDTH * 2 - 1)
        Dim myPen As New Pen(Color.Black, 3) With {
            .CustomEndCap = New Drawing2D.AdjustableArrowCap(5, 5),
            .CustomStartCap = New Drawing2D.AdjustableArrowCap(5, 5),
            .DashStyle = Drawing2D.DashStyle.Dash
        }
        e.Graphics.DrawLine(myPen, CInt(BOXWIDTH / 2 - 100), SHAPEWIDTH * 2, CInt(BOXWIDTH / 2 - 100), BOXHEIGHT)
        LabelText.Draw(e, String.Format("{0:0.000}m", dropHeight), 10, BOXWIDTH / 2 - 90, BOXHEIGHT / 2)
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        accelerationGravity = GetGravityAcceleration(cboGravity)
        ToolTips.SetToolTip(cboGravity, accelerationGravity & "ms^-2")

    End Sub

    Private Sub frmFreefall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAccelerationCbo(cboGravity)
    End Sub

    Private Sub updHeight_ValueChanged(sender As Object, e As EventArgs) Handles updHeight.ValueChanged
        dropHeight = updHeight.Value
        ballHeight = dropHeight
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        picBoxDisplay.Refresh()
        UpdateValues()
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll
        If optStepByStep.Checked Then
            ToolTips.SetToolTip(trbTime, "Time: " & trbTime.Value / 100)
            ballHeight = dropHeight - Maths.Displacement(0, Single.NaN, -(resultantForce / mass), trbTime.Value / 100)
        End If
    End Sub

    Private Sub optRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles optRealTime.CheckedChanged
        If optRealTime.Checked Then
            ball.posX = BOXWIDTH / 2 - 50
            trbTime.Hide()
            cmdStart.Show()
        Else
            ball.posX = BOXWIDTH / 2 + 50
            trbTime.Show()
            cmdStart.Hide()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        ball.posX = BOXWIDTH / 2 + 50
        ball.posY = SHAPEWIDTH
        ballHeight = dropHeight
        UpdateValues()
        timeStart = Now
        velocity = 0
        DropTimer.Start()

    End Sub

    Private Sub DropTimer_Tick(sender As Object, e As EventArgs) Handles DropTimer.Tick
        If ballHeight > 0 Then
            ball.posY = 0
        Else
            DropTimer.Stop()
        End If
        UpdateValues()

    End Sub

    Sub UpdateValues()
        dropHeight = updHeight.Value
        mass = updMass.Value
        fluidDensity = updFluidDensity.Value
        area = updArea.Value
        dragCOE = updDragCOE.Value
        resultantForce = mass * accelerationGravity - (0.5 * fluidDensity * velocity ^ 2 * dragCOE * area)
        resultantForce = mass * accelerationGravity
        velocity = Maths.FinalVelocity(Single.NaN, 0, resultantForce / mass, (Now - timeStart).TotalSeconds)
        trbTime.Maximum = Maths.Time(dropHeight, 0, Single.NaN, (resultantForce / mass)) * 100
    End Sub

End Class