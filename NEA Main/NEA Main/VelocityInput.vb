﻿Public Class VelocityInput
    Dim MouseIsDown As Boolean = False
    Dim xVelocity, yVelocity As Single

    Dim XLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 120,
        .posYe = 300,
        .LineWidth = 2
    }

    Dim YLine As Line = New Line With {
        .posX = 20,
        .posY = 300,
        .posXe = 20,
        .posYe = 200,
        .LineWidth = 2
    }

    Dim upTriangle As Triangle = New Triangle With {
            .up = True
        }

    Dim rightTriangle As Triangle = New Triangle With {
            .up = False
        }

    Private Sub MainPicBox_MouseMove(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseMove

        If MouseIsDown Then

        End If
    End Sub

    Private Sub MainPicBox_MouseDown(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseDown
        MouseIsDown = True
    End Sub

    Private Sub MainPicBox_MouseUp(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseUp
        MouseIsDown = False
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        If ComponetsRadio.Checked Then
            xVelocity = HorzIn.Value
            yVelocity = VertIn.Value
            SpeedIn.Value = Maths.Pythag(xVelocity, yVelocity)
            AngleIn.Value = Maths.RadToDeg(Math.Atan(yVelocity / xVelocity))

        Else
            xVelocity = SpeedIn.Value * Math.Cos(AngleIn.Value * Math.PI / 180)
            yVelocity = SpeedIn.Value * Math.Sin(AngleIn.Value * Math.PI / 180)
            VertIn.Value = yVelocity
            HorzIn.Value = xVelocity
        End If
        MainPicBox.Refresh()
    End Sub

    Private Sub ComponetsRadio_CheckedChanged(sender As Object, e As EventArgs) Handles ComponetsRadio.CheckedChanged
        If ComponetsRadio.Checked Then
            HorzIn.Enabled = True
            VertIn.Enabled = True
        Else
            HorzIn.Enabled = False
            VertIn.Enabled = False
        End If
    End Sub

    Private Sub SpeedRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SpeedRadio.CheckedChanged
        If SpeedRadio.Checked Then
            SpeedIn.Enabled = True
            AngleIn.Enabled = True
        Else
            SpeedIn.Enabled = False
            AngleIn.Enabled = False
        End If
    End Sub

    Private Sub MainPicBox_Paint(sender As Object, e As PaintEventArgs) Handles MainPicBox.Paint
        rightTriangle.posX = 20 + xVelocity
        rightTriangle.posY = 300 - Shape.WIDTH / 2
        If ComponetsRadio.Checked Then
            XLine.posXe = 20 + xVelocity
            YLine.posYe = 300 - yVelocity
            YLine.posXe = 20
            upTriangle.posX = Shape.WIDTH / 2
            upTriangle.posY = 300 - (Shape.WIDTH) - yVelocity
            rightTriangle.Draw(e)
            upTriangle.Draw(e)
            LabelText.Draw(e, xVelocity & "m/s", 30 + xVelocity, 300)
            LabelText.Draw(e, yVelocity & "m/s", 30, 300 - yVelocity)
        ElseIf SpeedRadio.Checked Then
            YLine.posYe = 300 - yVelocity
            YLine.posXe = 20 + xVelocity
            LabelText.Draw(e, SpeedIn.Value & "m/s", 20 + xVelocity, 300 - yVelocity)
            LabelText.Draw(e, AngleIn.Value & "°", 25, 300)
        End If


        XLine.Draw(e)
        YLine.Draw(e)
    End Sub

End Class