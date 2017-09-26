Imports System.Drawing.Drawing2D

Public MustInherit Class Shape
    Public posX, posY As Single
    Public Const WIDTH As Integer = 20
    Public MustOverride Sub Draw(e As PaintEventArgs)
End Class

Public Class Circle : Inherits Shape
    Public Overrides Sub Draw(e As PaintEventArgs)
        e.Graphics.FillEllipse(Brushes.Black, posX, posY, WIDTH, WIDTH)
    End Sub
End Class

Public Class Line : Inherits Shape
    Public posXe, posYe As Single
    Public LineWidth As Integer

    Public Overrides Sub Draw(e As PaintEventArgs)
        Dim myPen As Pen = New Pen(Color.Black, LineWidth)
        e.Graphics.DrawLine(myPen, posX, posY, posXe, posYe)
    End Sub
End Class

Public Class Triangle : Inherits Shape
    Public up As Boolean
    Public angle As Single
    Public Overrides Sub Draw(e As PaintEventArgs)
        Dim triangleUp() As Point = {New Point(posX + (WIDTH / 2), posY), New Point(posX, posY + WIDTH), New Point(posX + WIDTH, posY + WIDTH)}
        Dim triangleRight() As Point = {New Point(posX, posY), New Point(posX, posY + WIDTH), New Point(posX + WIDTH, posY + (WIDTH / 2))}
        If up Then
            e.Graphics.FillPolygon(Brushes.Black, triangleUp)
        Else
            e.Graphics.FillPolygon(Brushes.Black, triangleRight)
        End If

    End Sub

End Class

Public Class LabelText

    Public Shared Sub Draw(e As PaintEventArgs, labelText As String, posX As Single, posY As Single)
        Dim drawFont As New Font("Arial", 10)
        e.Graphics.DrawString(labelText, drawFont, Brushes.Black, posX, posY)
    End Sub
End Class

#Region "Impelement"
'Public Class Square : Inherits FallingShapes
'    Public Sub New()
'        timeStart = Now
'        acceleration = EARTH
'        CoR = 0.5
'    End Sub

'    Public Overrides Sub draw(e As PaintEventArgs)
'        If canDrop Then
'            If posY > boxHeight - WIDTH Then
'                posY = boxHeight - WIDTH
'                velocity = -CoR * velocity
'            End If
'            move()
'        End If

'        e.Graphics.DrawRectangle(Pens.Black, CInt(posX), CInt(posY), WIDTH, WIDTH)
'    End Sub

'End Class

'Public Class Triangle : Inherits FallingShapes
'    Public Sub New()
'        timeStart = Now
'        acceleration = EARTH
'        CoR = 0.5
'    End Sub

'    Public Overrides Sub draw(e As PaintEventArgs)
'        If canDrop Then
'            If posY > boxHeight - WIDTH Then
'                posY = boxHeight - WIDTH
'                velocity = -CoR * velocity
'            End If
'            move()
'        End If
'        Dim trianglePoints() As Point = {New Point(posX + (WIDTH / 2), posY), New Point(posX, posY + WIDTH), New Point(posX + WIDTH, posY + WIDTH)}
'        e.Graphics.DrawPolygon(Pens.Black, trianglePoints)

'    End Sub
'End Class

'Public Class Pentagon : Inherits FallingShapes
'    Public Sub New()
'        timeStart = Now
'        acceleration = EARTH
'        CoR = 0.5
'    End Sub
'    Public Overrides Sub draw(e As PaintEventArgs)
'        If canDrop Then
'            If posY > boxHeight - WIDTH Then
'                posY = boxHeight - WIDTH
'                velocity = -CoR * velocity
'            End If
'            move()
'        End If
'        Dim pentagonPoints() As Point = {New Point(posX + (WIDTH / 2), posY), New Point(posX + WIDTH, posY + ((2 / 5) * WIDTH)), New Point(posX + ((4 / 5) * WIDTH), posY + WIDTH), New Point(posX + ((1 / 5) * WIDTH), posY + WIDTH), New Point(posX, posY + ((2 / 5) * WIDTH))}
'        e.Graphics.DrawPolygon(Pens.Black, pentagonPoints)
'    End Sub

'    Public Class Line
'        Public startPoint, endPoint As Point

'        Public Sub draw(e As PaintEventArgs)
'            e.Graphics.DrawLine(Pens.Black, startPoint, endPoint)
'        End Sub
'    End Class
'End Class
#End Region

'Public MustInherit Class FallingShapes : Inherits Shape
'    Public velocity As Double
'    Public timeStart As Date
'    Public Const EARTH As Double = 9.81
'    Public acceleration As Double
'End Class