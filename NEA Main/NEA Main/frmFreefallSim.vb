﻿Public Class frmFreefallSim
    Const SHAPEWIDTH As Int16 = 50
    Dim BOXWIDTH, BOXHEIGHT As Int32
    Dim ball As New Circle With {
        .PosX = 0,
        .PosY = 0
    }
    Dim dropHeight As Double = 10
    Dim mass As Double = 10
    Dim resultantForce As Double
    Dim resistance As Double
    Dim accelerationGravity As Double
    Dim velocity As Double
    Dim timeStart As DateTime
    Dim ballHeight As Double

    Public Sub New()
        InitializeComponent()

        For Each control As Control In grpData.Controls
            If control.GetType = GetType(NumericUpDown) Then
                Dim upd As NumericUpDown = DirectCast(control, NumericUpDown)
                AddHandler upd.ValueChanged, AddressOf UpdateValues

            End If
        Next

    End Sub

    Public Overloads Sub ShowDialog()
        MyBase.Show()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        ball.PosX = BOXWIDTH / 2 - 50
        ball.PosY = SHAPEWIDTH
    End Sub

    Private Sub picBoxMain_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawCliff(e)
        ball.PosY = (dropHeight - ballHeight) * ((BOXHEIGHT - (2 * SHAPEWIDTH)) / dropHeight) + SHAPEWIDTH
        ball.Draw(e, SHAPEWIDTH)
    End Sub

    Sub DrawCliff(e As PaintEventArgs)
        BOXHEIGHT = picDisplay.Height
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
        ToolTips.SetToolTip(cboGravity, accelerationGravity & "m/s²")
        updResistance.Maximum = mass * accelerationGravity
    End Sub

    Private Sub frmFreefall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAccelerationCbo(cboGravity)
    End Sub

    Private Sub updHeight_ValueChanged(sender As Object, e As EventArgs) Handles updHeight.ValueChanged
        dropHeight = updHeight.Value
        ballHeight = dropHeight
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll
        If optStepByStep.Checked Then
            ToolTips.SetToolTip(trbTime, "Time: " & trbTime.Value / 100)
            ballHeight = dropHeight - Maths.Displacement(0, Single.NaN, -(resultantForce / mass), trbTime.Value / 100)
        End If
    End Sub

    Private Sub optRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles optRealTime.CheckedChanged
        DropTimer.Stop()
        UpdateValues()

        If optRealTime.Checked Then
            ball.PosX = BOXWIDTH / 2 - 50
            trbTime.Hide()
            cmdStart.Show()
        Else
            ball.PosX = BOXWIDTH / 2 + 50
            trbTime.Show()
            cmdStart.Hide()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        ball.PosX = BOXWIDTH / 2 + 50
        ball.PosY = SHAPEWIDTH
        ballHeight = dropHeight
        UpdateValues()
        timeStart = Now
        velocity = 0
        DropTimer.Start()

    End Sub

    Private Sub DropTimer_Tick(sender As Object, e As EventArgs) Handles DropTimer.Tick

        If ballHeight > 0 Then
            ballHeight = dropHeight - (velocity * (Now - timeStart).TotalSeconds)
        Else
            ballHeight = 0
            DropTimer.Stop()
        End If
        UpdateValues()

    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        updResistance.Maximum = mass * accelerationGravity

    End Sub

    Sub UpdateValues()
        dropHeight = updHeight.Value
        mass = updMass.Value
        resistance = updResistance.Value
        If mass * accelerationGravity > resistance Then
            resultantForce = mass * accelerationGravity - resistance
        Else
            resultantForce = 0
        End If
        velocity = ((resultantForce) / mass) * (Now - timeStart).TotalSeconds

        Try
            trbTime.Maximum = Maths.Time(dropHeight, 0, Single.NaN, (resultantForce / mass)) * 100
        Catch ex As Exception

        End Try

    End Sub

End Class