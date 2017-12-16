Imports System.Drawing.Drawing2D
Public Class frmVelocityInput
    Dim MouseIsDown As Boolean = False
    Dim mousePoint As PointF
    Public xVelocity As Single = 100
    Public yVelocity As Single = 100
    Public IsShowing As Boolean
    Public angle As Single = 45
    Public speed As Single = 50

    Dim myPen As New Pen(Color.Black, 3) With {
        .CustomEndCap = New AdjustableArrowCap(5, 5)
        }


    Public Sub New()
        InitializeComponent()
        addHandle()
    End Sub

    Public Overloads Sub Show()
        MyBase.Show()
        IsShowing = True
    End Sub

    Public Overloads Sub ShowDialog()
        IsShowing = True
        MyBase.ShowDialog()

    End Sub

    Public Sub addHandle()
        For Each control As Control In grbInputSelect.Controls
            If control.GetType = GetType(NumericUpDown) Then
                AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf UpdateValues
            End If
        Next
    End Sub

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If CheckMouse(e) Then
            mousePoint = e.Location
            Cursor = Cursors.Hand
            updAngle_In.Value = angle
            updSpeed_In.Value = speed
            updVelocityX_In.Value = xVelocity
            updVelocityY_In.Value = yVelocity
            If e.X > 340 - e.Y And e.Button = MouseButtons.Left Then
                xVelocity = e.X - 20
            ElseIf e.Button = MouseButtons.Left Then
                yVelocity = 320 - e.Y
            End If
        Else
        Cursor = Cursors.Default
        End If

    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left And CheckMouse(e) Then
            MouseIsDown = True
        End If
    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        If e.Button = MouseButtons.Left Then
            MouseIsDown = False
            Cursor = Cursors.Default
        End If
    End Sub

    Function CheckMouse(e As MouseEventArgs) As Boolean
        If e.X >= 20 And e.X <= 320 And e.Y >= 20 And e.Y <= 320 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
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
        With e.Graphics
            If optComponents.Checked Then
                .DrawLine(myPen, 20, 320, CInt(20 + xVelocity), 320)
                .DrawLine(myPen, 20, 320, 20, 320 - yVelocity)
                LabelText.Draw(e, xVelocity & "m/s", 10, xVelocity + 10, 320)
                LabelText.Draw(e, yVelocity & "m/s", 10, 30, 300 - yVelocity)
                angle = Maths.RadToDeg(Math.Atan2(yVelocity, xVelocity))
                speed = Math.Sqrt(xVelocity ^ 2 + yVelocity ^ 2)
            ElseIf optSpeed.Checked Then
                If MouseIsDown Then
                    angle = Maths.RadToDeg(Math.Atan((320 - mousePoint.Y) / (mousePoint.X - 20)))
                    speed = Math.Sqrt((mousePoint.X - 20) ^ 2 + (320 - mousePoint.Y) ^ 2)
                    xVelocity = speed * Math.Cos(Maths.DegToRad(angle))
                    yVelocity = speed * Math.Cos(Maths.DegToRad(angle))
                End If
                .DrawLine(New Pen(Color.Black, 3), 20, 320, 200, 320)
                .DrawLine(myPen, 20, 320, CInt(20 + speed * Math.Cos(Maths.DegToRad(angle))), CInt(320 - speed * Math.Sin(Maths.DegToRad(angle))))
                .DrawArc(Pens.Black, 20 - 50, 320 - 50, 100, 100, 0, -angle)
                LabelText.Draw(e, Math.Round(angle, 3) & "°", 10, 20, 320)
                LabelText.Draw(e, Math.Round(speed, 3) & "m/s", 10, CInt(20 + speed * Math.Cos(Maths.DegToRad(angle))), CInt(320 - speed * Math.Sin(Maths.DegToRad(angle))))
            End If
        End With

    End Sub

    Sub UpdateValues()
        xVelocity = updVelocityX_In.Value
        yVelocity = updVelocityY_In.Value
        angle = updAngle_In.Value
        speed = updSpeed_In.Value
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub frmVelocityInput_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        IsShowing = False
    End Sub

End Class