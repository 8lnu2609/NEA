Public Class VelocityInput
    Dim MouseIsDown As Boolean = False
    Public xVelocity As Single = 100
    Public yVelocity As Single = 100

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

    Dim angleArc As Arc = New Arc With {
        .posX = -5,
        .posY = 275
    }


    Private Sub MainPicBox_MouseMove(sender As Object, e As MouseEventArgs) Handles MainPicBox.MouseMove
        If MouseIsDown Then
            If ComponetsRadio.Checked Then
                If 320 - e.Y > e.X And e.Y > 20 And e.Y < 320 Then
                    VertIn.Value = Int((320 - e.Y) / 3)

                ElseIf e.X > 320 - e.Y And e.X > 20 And e.X < 320 Then
                    HorzIn.Value = Int(((e.X - 20) / 3))
                End If
            Else
                If e.X > 20 And e.X < 320 And e.Y < 300 And e.Y > 0 Then
                    SpeedIn.Value = Maths.Pythag(Int((e.X - 20) / 3), Int((320 - e.Y) / 3))
                    AngleIn.Value = Maths.RadToDeg(Math.Abs(Math.Atan(Int(((320 - e.Y) / 3) / ((e.X - 30) / 3)))))
                End If
            End If
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
            SpeedIn.Maximum = 142
            SpeedIn.Value = Maths.Pythag(xVelocity, yVelocity)
            If yVelocity = 0 Then
                AngleIn.Value = 0
            Else
                AngleIn.Value = Maths.RadToDeg(Math.Atan(yVelocity / xVelocity))
            End If


        Else
            SpeedIn.Maximum = 100
            VertIn.Value = yVelocity
            HorzIn.Value = xVelocity
        End If
        SharedVariables.xVelocity = xVelocity
        SharedVariables.yVelocity = yVelocity
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
        rightTriangle.posX = 20 + xVelocity * 3
        rightTriangle.posY = 300 - Shape.WIDTH / 2
        If ComponetsRadio.Checked Then
            XLine.posXe = 20 + xVelocity * 3
            YLine.posYe = 300 - yVelocity * 3
            YLine.posXe = 20
            upTriangle.posX = Shape.WIDTH / 2
            upTriangle.posY = 300 - (Shape.WIDTH) - yVelocity * 3
            rightTriangle.Draw(e)
            upTriangle.Draw(e)
            LabelText.Draw(e, xVelocity & "m/s", 30 + xVelocity, 300)
            LabelText.Draw(e, yVelocity & "m/s", 30, 300 - yVelocity)
        ElseIf SpeedRadio.Checked Then
            YLine.posYe = 0 - yVelocity * 3
            YLine.posXe = (20 + xVelocity) * 3
            XLine.posXe = 50
            LabelText.Draw(e, SpeedIn.Value & "m/s", 20 + xVelocity, 300 - yVelocity)
            LabelText.Draw(e, AngleIn.Value & "°", 25, 300)
            angleArc.angle = Maths.RadToDeg(Math.Atan(yVelocity / xVelocity))
            angleArc.Draw(e)
        End If


        XLine.Draw(e)
        YLine.Draw(e)
    End Sub

    Private Sub VertIn_ValueChanged(sender As Object, e As EventArgs) Handles VertIn.ValueChanged
        yVelocity = VertIn.Value
    End Sub

    Private Sub HorzIn_ValueChanged(sender As Object, e As EventArgs) Handles HorzIn.ValueChanged
        xVelocity = HorzIn.Value
    End Sub

    Private Sub AngleIn_Leave(sender As Object, e As EventArgs) Handles AngleIn.Leave
        xVelocity = SpeedIn.Value * Math.Cos(AngleIn.Value * Math.PI / 180)
        yVelocity = SpeedIn.Value * Math.Sin(AngleIn.Value * Math.PI / 180)
    End Sub

    Private Sub SpeedIn_Leave(sender As Object, e As EventArgs) Handles SpeedIn.Leave
        xVelocity = SpeedIn.Value * Math.Cos(AngleIn.Value * Math.PI / 180)
        yVelocity = SpeedIn.Value * Math.Sin(AngleIn.Value * Math.PI / 180)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class