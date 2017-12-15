Public Class frmConnectedParticlesSim
    Dim angle As Single = 45
    Dim BOXWIDTH, BOXHEIGHT As Single
    Dim mousePoint As PointF
    Dim mouseIsDown As Boolean
    Dim dragPoint As PointF
    Dim slopeObject As New RotateBox(0, 0, 100)
    Dim freeObject As New Square
    Dim COEofFriction As Single
    Dim massSlope As Single = 1
    Dim massFree As Single = 1
    Dim accelerationDueToGravity As Single

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

    Public Overloads Sub Show()
        MyBase.Show()
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
        DrawRamp(e)
        slopeObject.angle = angle
        slopeObject.draw(e)
        freeObject.Draw(e, 50)
    End Sub

    Function checkMouse(e As MouseEventArgs) As Boolean
        If e.X >= dragPoint.X - 25 And e.X <= dragPoint.X + 25 And e.Y >= dragPoint.Y - 25 And e.Y <= dragPoint.Y + 25 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        mousePoint = e.Location
        If checkMouse(e) Then
            Cursor = Cursors.Hand
            updAngle.Value = angle
            updateValues()
        Else
            Cursor = Cursors.Default
        End If


    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left And checkMouse(e) Then
            mouseIsDown = True
        End If
    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        If e.Button = MouseButtons.Left Then
            mouseIsDown = False
        End If
    End Sub

    Sub DrawRamp(e As PaintEventArgs)
        Dim pivotPoint As New PointF(BOXWIDTH / 4, BOXHEIGHT / 1.5)
        Dim myPen As New Pen(Color.Black, 4)
        myPen.EndCap = Drawing2D.LineCap.DiamondAnchor
        myPen.StartCap = Drawing2D.LineCap.RoundAnchor

        If mouseIsDown Then
            If mousePoint.X >= pivotPoint.X And mousePoint.Y <= pivotPoint.Y Then
                angle = Maths.RadToDeg(Math.Atan((pivotPoint.Y - mousePoint.Y) / (mousePoint.X - pivotPoint.X)))
            End If
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
                      CInt(dragPoint.X + 25 * Math.Cos(Maths.DegToRad(angle))), CInt(dragPoint.Y - 25 * Math.Sin(Maths.DegToRad(angle))))

            LabelText.Draw(e, String.Format("{0:#,0.000}°", Math.Round(angle, 3)), 12, pivotPoint.X, pivotPoint.Y)
            LabelText.Draw(e, String.Format("1: {0:#,0.000} kg", massSlope), 10, slopeObject.Location.X + 10, slopeObject.Location.Y + 10)
            LabelText.Draw(e, String.Format("2: {0:#,0.000} kg", massFree), 10, freeObject.posX, freeObject.posY + 60)
        End With
        slopeObject.Location = New PointF(200 * Math.Cos(Maths.DegToRad(angle)) + pivotPoint.X, pivotPoint.Y - 200 * Math.Sin(Maths.DegToRad(angle)))
        freeObject.posX = dragPoint.X
        freeObject.posY = dragPoint.Y + 100

    End Sub

    Private Sub tmrCalculation_Tick(sender As Object, e As EventArgs) Handles tmrCalculation.Tick
        Dim tension As Single = massFree * accelerationDueToGravity
        Dim normalReaction As Single = massSlope * accelerationDueToGravity * Math.Cos(Maths.RadToDeg(angle))
        Dim maxFriction As Single = COEofFriction * normalReaction
        Dim weightDown As Single = massSlope * accelerationDueToGravity * Math.Sin(Maths.RadToDeg(angle))
        Dim friction As Single
        If tension - weightDown > maxFriction Then
            friction = maxFriction
        Else
            friction = tension - weightDown
        End If
        Dim resultantForce As Single = tension - friction - weightDown
        Dim acceleration As Single = resultantForce / massSlope
        lblOutput.Text = String.Format("The tension in the rope is {0}N,
the normal reaction between object 1 and the slope is {1}N,
the friction between object 1 and the slope is {2}N
this gives a resultant force of {3}N acting", tension, normalReaction)

    End Sub

    Sub updateValues()
        accelerationDueToGravity = GetGravityAcceleration(cboGravity)
        massFree = updFreeMass.Value
        massSlope = updSlopeMass.Value
        angle = updAngle.Value
        COEofFriction = updCOE.Value

    End Sub
End Class

Public Class RotateBox
#Region "Variables"
    Private _posX As Single
    Private _posY As Single
    Public Property Location As PointF
        Get
            Return New Point(_posX, _posY)
        End Get
        Set(value As PointF)
            _posX = value.X
            _posY = value.Y
            setPoints()
        End Set
    End Property
    Public Property angle As Single
    Private BoxPoints(4) As PointF
    Public Property Points(Index As Integer) As PointF
        Get
            Return BoxPoints(Index)
        End Get
        Set(value As PointF)
            BoxPoints(Index) = value
        End Set
    End Property
    Private width As Integer
#End Region
    Public Sub New(x As Single, y As Single, widthIN As Integer)
        _posX = x
        _posY = y
        width = widthIN
        setPoints()
    End Sub

    Public Sub New(location As PointF, widthIN As Integer)
        _posX = location.X
        _posY = location.Y
        width = widthIN
        setPoints()
    End Sub

    Private Sub setPoints()
        BoxPoints(0) = New PointF(_posX, _posY)
        BoxPoints(1) = New PointF(width * Math.Cos(Maths.DegToRad(angle)) + BoxPoints(0).X, BoxPoints(0).Y - width * Math.Sin(Maths.DegToRad(angle)))
        BoxPoints(2) = New PointF(width / 2 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(1).X, BoxPoints(1).Y - width / 2 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(3) = New PointF(width / 2 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(0).X, BoxPoints(0).Y - width / 2 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(4) = BoxPoints(0)
    End Sub

    Public Sub draw(e As PaintEventArgs)
        setPoints()
        e.Graphics.DrawLines(Pens.Black, BoxPoints)
    End Sub

End Class