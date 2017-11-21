Imports System.Drawing.Drawing2D
Public Class frmVelocityInput
    Dim MouseIsDown As Boolean = False
    Public xVelocity As Single = 100
    Public yVelocity As Single = 100
    Public IsShowing As Boolean

    Dim XLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 120,
        .posYe = 300
    }

    Dim YLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 20,
        .posYe = 200
    }

    Dim angleArc As Arc = New Arc With {
        .posX = -5,
        .posY = 275
    }

    Public Sub New()
        InitializeComponent()
        Using bigArrowCap As New AdjustableArrowCap(5, 5)
            XLine.myPen.CustomEndCap = bigArrowCap
            YLine.myPen.CustomEndCap = bigArrowCap
        End Using
    End Sub

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If MouseIsDown Then
            If optComponents.Checked Then
                If 320 - e.Y > e.X And e.Y > 20 And e.Y < 320 Then
                    updVelocityY_In.Value = Int((320 - e.Y) / 3)

                ElseIf e.X > 320 - e.Y And e.X > 20 And e.X < 320 Then
                    updVelocityX_In.Value = Int(((e.X - 20) / 3))
                End If

            Else
                If e.X >= 20 And e.X <= 320 And e.Y >= 0 And e.Y <= 300 Then
                    YLine.posYe = e.Y
                    YLine.posXe = e.X
                    updSpeed_In.Value = Maths.Pythag(Int((e.X - 20) / 3), Int((320 - e.Y) / 3))
                    updAngle_In.Value = Maths.RadToDeg((Math.Atan(Int(((320 - e.Y) / 3) / ((e.X - 20) / 3)))))
                    angleArc.angle = Maths.RadToDeg(Math.Atan((320 - e.Y) / e.X))
                End If
            End If
        End If
    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        MouseIsDown = True

    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        MouseIsDown = False
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        If optComponents.Checked Then
            updSpeed_In.Maximum = Math.Round(Math.Sqrt(2 * 100 ^ 2), 4)
            updSpeed_In.Value = Maths.Pythag(xVelocity, yVelocity)
            If yVelocity = 0 Then
                updAngle_In.Value = 0
            Else
                updAngle_In.Value = Maths.RadToDeg(Math.Atan(yVelocity / xVelocity))
            End If
        Else
            updSpeed_In.Maximum = 146
            updVelocityY_In.Value = yVelocity
            updVelocityX_In.Value = xVelocity
        End If
        SharedVariables.xVelocity = xVelocity
        SharedVariables.yVelocity = yVelocity
        picDisplay.Refresh()
    End Sub

    Private Sub optComponents_CheckedChanged(sender As Object, e As EventArgs) Handles optComponents.CheckedChanged
        If optComponents.Checked Then
            updVelocityX_In.Enabled = True
            updVelocityY_In.Enabled = True

        Else
            updVelocityX_In.Enabled = False
            updVelocityY_In.Enabled = False
        End If
    End Sub

    Private Sub optSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles optSpeed.CheckedChanged
        If optSpeed.Checked Then
            updSpeed_In.Enabled = True
            updAngle_In.Enabled = True
        Else
            updSpeed_In.Enabled = False
            updAngle_In.Enabled = False

        End If
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        If optComponents.Checked Then
            XLine.posXe = 20 + xVelocity * 3
            YLine.posYe = 300 - yVelocity * 3
            YLine.posXe = 20
            LabelText.Draw(e, xVelocity & "m/s", 10, 30 + xVelocity, 300)
            LabelText.Draw(e, yVelocity & "m/s", 10, 30, 300 - yVelocity)
        ElseIf optSpeed.Checked Then
            XLine.posXe = 50
            LabelText.Draw(e, updSpeed_In.Value & "m/s", 10, 20 + xVelocity, 300 - yVelocity)
            LabelText.Draw(e, updAngle_In.Value & "°", 10, 25, 300)

            angleArc.Draw(e)
        End If

        XLine.Draw(e, 2)
        YLine.Draw(e, 2)
    End Sub

    Private Sub updVelocityY_In_ValueChanged(sender As Object, e As EventArgs) Handles updVelocityY_In.ValueChanged
        yVelocity = updVelocityY_In.Value
    End Sub

    Private Sub updVelocityX_In_ValueChanged(sender As Object, e As EventArgs) Handles updVelocityX_In.ValueChanged
        xVelocity = updVelocityX_In.Value
    End Sub

    Private Sub updAngle_In_Leave(sender As Object, e As EventArgs) Handles updAngle_In.Leave
        xVelocity = updSpeed_In.Value * Math.Cos(updAngle_In.Value * Math.PI / 180)
        yVelocity = updSpeed_In.Value * Math.Sin(updAngle_In.Value * Math.PI / 180)
    End Sub

    Private Sub updSpeed_In_Leave(sender As Object, e As EventArgs) Handles updSpeed_In.Leave
        xVelocity = updSpeed_In.Value * Math.Cos(updAngle_In.Value * Math.PI / 180)
        yVelocity = updSpeed_In.Value * Math.Sin(updAngle_In.Value * Math.PI / 180)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub frmVelocityInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsShowing = True
    End Sub

    Private Sub frmVelocityInput_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        IsShowing = False
    End Sub

End Class