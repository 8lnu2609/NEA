Public Class frmConnectedParticlesSim
    Dim angle As Single = 45
    Dim BOXWIDTH, BOXHEIGHT As Single
    Dim mousePoint As PointF
    Dim mouseIsDown As Boolean
    Dim dragPoint As PointF
    Dim slopeObject As New RotateBox(0, 0, 100, 50)
    Dim slopeObjectDistance As Single = 150
    Dim freeObject As New Square
    Dim COEofFriction As Single
    Dim massSlope As Single = 1
    Dim massFree As Single = 1
    Dim accelerationDueToGravity As Single
    Dim playing As Boolean = False
    Dim tension As Single
    Dim normalReaction As Single
    Dim maxFriction As Single
    Dim weightDown As Single
    Dim friction As Single
    Dim resultantForce As Single
    Dim acceleration As Single
    Dim direction As String
    Dim timeStart As DateTime

    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        For Each control As Control In grpData.Controls
            If control.GetType = GetType(NumericUpDown) Then
                AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf updateValues
            End If
        Next
    End Sub

    Public Overloads Sub ShowDialog()
        MyBase.ShowDialog()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, GetGravityAcceleration(cboGravity))
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawObjects(e)
        slopeObject.angle = angle
        slopeObject.draw(e)
        freeObject.Draw(e, 50)
    End Sub

    Function checkMouse(mPoint As Point) As Boolean
        If mPoint.X >= dragPoint.X - 25 And mPoint.X <= dragPoint.X + 25 And mPoint.Y >= dragPoint.Y - 25 And mPoint.Y <= dragPoint.Y + 25 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        mousePoint = e.Location
        If checkMouse(e.Location) Then
            Cursor = Cursors.Hand
            updateValues()
        Else
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left And checkMouse(e.Location) Then
            mouseIsDown = True
        End If
    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        If e.Button = MouseButtons.Left Then
            mouseIsDown = False
            angle = updAngle.Value
        End If
    End Sub

    Sub DrawObjects(e As PaintEventArgs)
        Dim pivotPoint As New PointF(50, BOXHEIGHT - 200)
        Dim myPen As New Pen(Color.Black, 4)
        myPen.EndCap = Drawing2D.LineCap.DiamondAnchor
        myPen.StartCap = Drawing2D.LineCap.RoundAnchor

        If mouseIsDown Then
            If mousePoint.X >= pivotPoint.X And mousePoint.Y <= pivotPoint.Y Then
                angle = Maths.RadToDeg(Math.Atan((pivotPoint.Y - mousePoint.Y) / (mousePoint.X - pivotPoint.X)))
                updAngle.Value = angle
                playing = True
                toggleStart()
            End If
        End If
        If playing = False Then
            freeObject.posY = dragPoint.Y + 150
            freeObject.posX = dragPoint.X
            slopeObjectDistance = 150
        End If
        dragPoint = New PointF(400 * Math.Cos(Maths.DegToRad(angle)) + pivotPoint.X, pivotPoint.Y - 400 * Math.Sin(Maths.DegToRad(angle)))
        With e.Graphics
            .DrawLine(myPen, pivotPoint, New PointF(pivotPoint.X + 200, pivotPoint.Y))
            .DrawLine(myPen, pivotPoint, dragPoint)
            .DrawArc(Pens.Black, pivotPoint.X - 50, pivotPoint.Y - 50, 100, 100, 0, -angle)
            .DrawEllipse(Pens.Black, dragPoint.X - 25, dragPoint.Y - 25, 50, 50)
            .DrawLine(Pens.Black, (slopeObject.Points(1).X + slopeObject.Points(2).X) / 2, (slopeObject.Points(1).Y + slopeObject.Points(2).Y) / 2,
                      CInt(dragPoint.X + 25 * Math.Cos(Maths.DegToRad(90 + angle))), CInt(dragPoint.Y - 25 * Math.Sin(Maths.DegToRad(90 + angle))))
            .DrawLine(Pens.Black, freeObject.posX + 25, freeObject.posY,
                      CInt(dragPoint.X + 25), CInt(dragPoint.Y))

            LabelText.Draw(e, String.Format("{0:#,0.###}°", Math.Round(angle, 3)), 12, pivotPoint.X, pivotPoint.Y)
            LabelText.Draw(e, String.Format("1: {0:#,0.000} kg", massSlope), 10, slopeObject.Location.X + 10, slopeObject.Location.Y + 10)
            LabelText.Draw(e, String.Format("2: {0:#,0.000} kg", massFree), 10, freeObject.posX + 25, freeObject.posY + 60)
        End With
        slopeObject.Location = New PointF(slopeObjectDistance * Math.Cos(Maths.DegToRad(angle)) + pivotPoint.X, pivotPoint.Y - slopeObjectDistance * Math.Sin(Maths.DegToRad(angle)))


    End Sub

    Private Sub tmrCalculation_Tick(sender As Object, e As EventArgs) Handles tmrCalculation.Tick
        Output()
        If slopeObjectDistance > 25 And slopeObjectDistance < 275 Then
            freeObject.posY = dragPoint.Y + 150 - Maths.Displacement(0, Single.NaN, acceleration, (Now - timeStart).TotalSeconds)
            slopeObjectDistance = 150 - Maths.Displacement(0, Single.NaN, acceleration, (Now - timeStart).TotalSeconds)
        Else
        End If
    End Sub

    Sub Output()
        tension = massFree * accelerationDueToGravity
        normalReaction = massSlope * accelerationDueToGravity * Math.Cos(Maths.DegToRad(angle))
        maxFriction = COEofFriction * normalReaction
        weightDown = massSlope * accelerationDueToGravity * Math.Sin(Maths.DegToRad(angle))
        If Math.Abs(tension - weightDown) > maxFriction Then
            friction = maxFriction
        Else
            friction = Math.Abs(tension - weightDown)
        End If
        resultantForce = tension - friction - weightDown
        acceleration = resultantForce / massSlope
        If acceleration = 0 Then
            direction = "the system is in equilibrium"
        ElseIf acceleration < 0 Then
            direction = "acting down the slope"
        Else
            direction = "acting up the slope"
        End If
        lblOutput.Text = String.Format("The tension in the rope is {0:0.###}N,
the normal reaction between object 1 and the slope is {1:0.###}N,
the maximum friction between object 1 and the slope is {2:0.###}N,
the friction between object 1 and the slope is {3:0.###}N,
the component of weight acting down the slope is {4:0.###}N,
this gives a resultant force of {5:0.###}N
the resultant force accelerates the box at {6:0.###}m/s²
{7}", tension, normalReaction, maxFriction, friction, weightDown, resultantForce, Math.Abs(acceleration), direction)

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        toggleStart()
    End Sub

    Sub toggleStart()
        If playing = False Then
            tmrCalculation.Start()
            cmdStart.Text = "Stop"
            timeStart = Now
            playing = True
        Else
            tmrCalculation.Stop()
            cmdStart.Text = "Start"
            playing = False
        End If
    End Sub

    Sub updateValues()
        playing = True
        toggleStart()
        accelerationDueToGravity = GetGravityAcceleration(cboGravity)
        massFree = updFreeMass.Value
        massSlope = updSlopeMass.Value
        angle = updAngle.Value
        COEofFriction = updCOE.Value

    End Sub
End Class

