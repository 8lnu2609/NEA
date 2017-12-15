Public Class frmConnectedParticlesSim
    Dim angle As Single = 45
    Dim BOXWIDTH, BOXHEIGHT As Single
    Dim mousePoint As PointF
    Dim mouseIsDown As Boolean
    Dim dragPoint As PointF
    Dim onSlope As RotateBox()


    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
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
    End Sub

    Function checkMouse(e As MouseEventArgs) As Boolean
        If e.X >= dragPoint.X - 10 And e.X <= dragPoint.X + 10 And e.Y >= dragPoint.Y - 10 And e.Y <= dragPoint.Y + 10 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        Cursor = Cursors.Arrow
        mousePoint = e.Location
        If checkMouse(e) Then
            Cursor = Cursors.Hand
            updAngle.Value = angle
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

    Private Sub updAngle_ValueChanged(sender As Object, e As EventArgs) Handles updAngle.ValueChanged
        angle = updAngle.Value
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
            '.DrawLine(Pens.Black, )
            LabelText.Draw(e, String.Format("{0:#,0.000}°", Math.Round(angle, 3)), 12, pivotPoint.X, pivotPoint.Y)
        End With
        onSlope = New RotateBox(pivotPoint, 100)

    End Sub

    Sub rotateBox(e As PaintEventArgs, angleIn As Single, posX As Single, posY As Single)
        Dim BoxPoints(4) As PointF
        BoxPoints(0) = New PointF(posX, posY)
        BoxPoints(1) = New PointF(100 * Math.Cos(Maths.DegToRad(angle)) + BoxPoints(0).X, BoxPoints(0).Y - 100 * Math.Sin(Maths.DegToRad(angle)))
        BoxPoints(2) = New PointF(50 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(1).X, BoxPoints(1).Y - 50 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(3) = New PointF(50 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(0).X, BoxPoints(0).Y - 50 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(4) = BoxPoints(0)
        e.Graphics.DrawLines(Pens.Black, BoxPoints)

    End Sub

End Class

Public Class RotateBox
    Private _posX As Single
    Private _posY As Single
    Public Property Location As Point
        Get
            Return New Point(_posX, _posY)
        End Get
        Set(value As Point)
            _posX = value.X
            _posY = value.Y
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

    Public Sub New(x As Single, y As Single, widthIN As Integer)
        _posX = x
        _posY = y
        width = widthIN
    End Sub

    Public Sub New(location As PointF, widthIN As Integer)
        _posX = location.X
        _posY = location.Y
        width = widthIN
    End Sub

    Sub setPoints(width)
        BoxPoints(0) = New PointF(_posX, _posY)
        BoxPoints(1) = New PointF(100 * Math.Cos(Maths.DegToRad(angle)) + BoxPoints(0).X, BoxPoints(0).Y - 100 * Math.Sin(Maths.DegToRad(angle)))
        BoxPoints(2) = New PointF(50 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(1).X, BoxPoints(1).Y - 50 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(3) = New PointF(50 * Math.Cos(Maths.DegToRad(90 + angle)) + BoxPoints(0).X, BoxPoints(0).Y - 50 * Math.Sin(Maths.DegToRad(90 + angle)))
        BoxPoints(4) = BoxPoints(0)
    End Sub

    Public Sub draw(e As PaintEventArgs, width As Integer)

        e.Graphics.DrawLines(Pens.Black, BoxPoints)
    End Sub

End Class

