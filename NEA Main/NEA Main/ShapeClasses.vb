Public MustInherit Class Shape
    Public Const WIDTH As Int32 = 20
    Public Const LINEWIDTH As Int32 = 20
    Public myPen As New Pen(Color.Black)
    Public MustOverride Sub Draw(e As PaintEventArgs)
    Public Property posX As Single
    Public Property posY As Single
End Class

Public Class Circle : Inherits Shape
    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.FillEllipse(Brushes.Black, posX, posY, WIDTH, WIDTH)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, diameter As Int32)
        e.Graphics.FillEllipse(Brushes.Black, posX, posY, diameter, diameter)
    End Sub

End Class

Public Class Square : Inherits Shape

    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.DrawRectangle(Pens.Black, posX, posY, WIDTH, WIDTH)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, length As Int32)
        e.Graphics.DrawRectangle(Pens.Black, posX, posY, length, length)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, length As Int32, colour As Color)
        Dim myBrush As New SolidBrush(colour)
        myPen.Color = Color.Black
        myPen.Width = 2
        myPen.Alignment = Drawing2D.PenAlignment.Inset
        e.Graphics.FillRectangle(myBrush, posX, posY, length, length)
        e.Graphics.DrawRectangle(myPen, posX, posY, length, length)
    End Sub


End Class

Public Class Line : Inherits Shape

    Public Property posXe As Single

    Public Property posYe As Single


    Public Overrides Sub Draw(e As PaintEventArgs)
        myPen.Color = Color.Black
        myPen.Width = LINEWIDTH
        e.Graphics.DrawLine(myPen, posX, posY, posXe, posYe)
    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, lineWidth As Int32)
        myPen.Width = lineWidth
        e.Graphics.DrawLine(myPen, posX, posY, posXe, posYe)
    End Sub

End Class

Public Class Triangle : Inherits Shape
    Public up As Boolean

    Public Overrides Sub Draw(e As PaintEventArgs)
        Dim triangleUp() As Point = {New Point(posX + (WIDTH / 2), posY), New Point(posX, posY + WIDTH), New Point(posX + WIDTH, posY + WIDTH)}
        Dim triangleRight() As Point = {New Point(posX, posY), New Point(posX, posY + WIDTH), New Point(posX + WIDTH, posY + (WIDTH / 2))}
        If up Then
            e.Graphics.FillPolygon(Brushes.Black, triangleUp)
        Else
            e.Graphics.FillPolygon(Brushes.Black, triangleRight)
        End If

    End Sub

    Public Overloads Sub Draw(e As PaintEventArgs, Lenght As Int32)
        Dim triangleUp() As Point = {New Point(posX + (Lenght / 2), posY), New Point(posX, posY + Lenght), New Point(posX + Lenght, posY + Lenght)}
        Dim triangleRight() As Point = {New Point(posX, posY), New Point(posX, posY + Lenght), New Point(posX + Lenght, posY + (Lenght / 2))}
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
        e.Graphics.DrawArc(Pens.Black, posX, posY, 50, 50, 0, -angle)
    End Sub
End Class

Public Class LabelText

    Public Shared Sub Draw(e As PaintEventArgs, labelText As String, fontSize As Int32, posX As Single, posY As Single)
        Dim drawFont As New Font("Arial", fontSize)
        e.Graphics.DrawString(labelText, drawFont, Brushes.Black, posX, posY)
    End Sub


End Class