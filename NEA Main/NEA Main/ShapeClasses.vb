Public MustInherit Class Shape
    Public Const WIDTH As Int32 = 20
    Public Const LINEWIDTH As Int32 = 20
    Public myPen As New Pen(Color.Black)
    Public MustOverride Sub Draw(e As PaintEventArgs)
    Public Property PosX As Single
    Public Property PosY As Single
End Class

Public Class Circle : Inherits Shape
    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.FillEllipse(Brushes.Black, PosX, PosY, WIDTH, WIDTH)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, diameter As Int32)
        e.Graphics.FillEllipse(Brushes.Black, PosX, PosY, diameter, diameter)
    End Sub

End Class

Public Class Square : Inherits Shape

    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.DrawRectangle(Pens.Black, PosX, PosY, WIDTH, WIDTH)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, length As Int32)
        e.Graphics.DrawRectangle(Pens.Black, PosX, PosY, length, length)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, length As Int32, colour As Color)
        Dim myBrush As New SolidBrush(colour)
        myPen.Color = Color.Black
        myPen.Width = 2
        myPen.Alignment = Drawing2D.PenAlignment.Left
        e.Graphics.FillRectangle(myBrush, PosX, PosY, length, length)
        e.Graphics.DrawRectangle(myPen, PosX, PosY, length, length)
    End Sub


End Class

Public Class RotateBox
    Private _posX As Single
    Private _posY As Single
    Public Property Location As PointF
        Get
            Return New Point(_posX, _posY)
        End Get
        Set(value As PointF)
            _posX = value.X
            _posY = value.Y
            SetPoints()
        End Set
    End Property
    Public Property Angle As Single = 0
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
    Private height As Integer

    Public Sub New(x As Single, y As Single, widthIN As Integer, heightIN As Integer)
        _posX = x
        _posY = y
        width = widthIN
        height = heightIN
        SetPoints()
    End Sub

    Public Sub New(location As PointF, widthIN As Integer, heightIN As Integer)
        _posX = location.X
        _posY = location.Y
        width = widthIN
        height = heightIN
        SetPoints()
    End Sub

    Public Sub New(widthIN As Integer, heightIN As Integer)
        width = widthIN
        height = heightIN
        _posX = 0
        _posY = 0
    End Sub

    Private Sub SetPoints()
        BoxPoints(0) = New PointF(_posX, _posY)
        BoxPoints(1) = New PointF(width * Math.Cos((Angle) * Math.PI / 180) + BoxPoints(0).X, BoxPoints(0).Y - width * Math.Sin((Angle) * Math.PI / 180))
        BoxPoints(2) = New PointF(height * Math.Cos((90 + Angle) * Math.PI / 180) + BoxPoints(1).X, BoxPoints(1).Y - height * Math.Sin((90 + Angle) * Math.PI / 180))
        BoxPoints(3) = New PointF(height * Math.Cos((90 + Angle) * Math.PI / 180) + BoxPoints(0).X, BoxPoints(0).Y - height * Math.Sin((90 + Angle) * Math.PI / 180))
        BoxPoints(4) = BoxPoints(0)
    End Sub

    Public Sub Draw(e As PaintEventArgs)
        SetPoints()
        e.Graphics.DrawLines(Pens.Black, BoxPoints)
    End Sub

End Class

Public Class Line : Inherits Shape

    Public Property PosXe As Single

    Public Property PosYe As Single

    Public Overrides Sub Draw(e As PaintEventArgs)
        myPen.Color = Color.Black
        myPen.Width = LINEWIDTH
        e.Graphics.DrawLine(myPen, PosX, PosY, PosXe, PosYe)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, lineWidth As Int32)
        myPen.Width = lineWidth
        e.Graphics.DrawLine(myPen, PosX, PosY, PosXe, PosYe)
    End Sub

End Class

Public Class Triangle : Inherits Shape
    Public up As Boolean

    Public Overrides Sub Draw(e As PaintEventArgs)
        Dim triangleUp() As Point = {New Point(PosX + (WIDTH / 2), PosY), New Point(PosX, PosY + WIDTH), New Point(PosX + WIDTH, PosY + WIDTH)}
        Dim triangleRight() As Point = {New Point(PosX, PosY), New Point(PosX, PosY + WIDTH), New Point(PosX + WIDTH, PosY + (WIDTH / 2))}
        If up Then
            e.Graphics.FillPolygon(Brushes.Black, triangleUp)
        Else
            e.Graphics.FillPolygon(Brushes.Black, triangleRight)
        End If

    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, Lenght As Int32)
        Dim triangleUp() As Point = {New Point(PosX + (Lenght / 2), PosY), New Point(PosX, PosY + Lenght), New Point(PosX + Lenght, PosY + Lenght)}
        Dim triangleRight() As Point = {New Point(PosX, PosY), New Point(PosX, PosY + Lenght), New Point(PosX + Lenght, PosY + (Lenght / 2))}
        If up Then
            e.Graphics.FillPolygon(Brushes.Black, triangleUp)
        Else
            e.Graphics.FillPolygon(Brushes.Black, triangleRight)
        End If

    End Sub


End Class

Public Class ParabolicArc : Inherits Shape
    Public ArcPoints(500) As Point

    Public Overrides Sub Draw(e As PaintEventArgs)
        myPen.Width = 1
        myPen.DashPattern = {10, 2}
        e.Graphics.DrawCurve(myPen, ArcPoints)
    End Sub
End Class

Public Class Arc : Inherits Shape
    Public angle As Single
    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.DrawArc(Pens.Black, PosX, PosY, 50, 50, 0, -angle)
    End Sub
End Class

Public Class LabelText

    Public Shared Sub Draw(e As PaintEventArgs, labelText As String, fontSize As Int32, posX As Single, posY As Single)
        Dim drawFont As New Font("Arial", fontSize)
        e.Graphics.DrawString(labelText, drawFont, Brushes.Black, posX, posY)
    End Sub


End Class