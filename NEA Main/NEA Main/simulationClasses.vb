Enum Sim
    projectile = 0
End Enum

Public NotInheritable Class Maths
    ''' <summary>
    ''' Find hypotenuse given both sides
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Shared Function Pythag(a As Single, b As Single) As Single
        Return Math.Sqrt(a ^ 2 + b ^ 2)
    End Function

    Public Shared Function DegToRad(angle As Single) As Single
        Return angle * Math.PI / 180
    End Function

    Public Shared Function RadToDeg(angle As Single) As Single
        Return angle * 180 / Math.PI
    End Function
    ''' <summary>
    ''' Solves a quadratic given as ax^2+bx+c
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <param name="c"></param>
    ''' <returns></returns>
    Public Shared Function QuadraticSolve(a As Single, b As Single, c As Single) As Single()
        Dim soultion(1) As Single
        If (b ^ 2 - 4 * a * c < 0) Then
            Return Nothing
        Else
            soultion(0) = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            soultion(1) = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            Return soultion
        End If
    End Function

End Class

Public MustInherit Class Simulation
    Overridable Sub MouseDown(e As MouseEventArgs)
        mouseIsDown = True
    End Sub
    Overridable Sub MouseMove(e As MouseEventArgs)
        mouseLocation = e.Location
    End Sub
    Overridable Sub MouseUp(e As MouseEventArgs)
        mouseIsDown = False
    End Sub
    MustOverride Sub Paint(e As PaintEventArgs)
    Protected mouseLocation As New Point
    Protected mouseIsDown As Boolean = False

End Class

Public Class Projectiles
    Inherits Simulation
    Protected projectle As Circle
    Protected bounds As Size
    Protected startTime As DateTime
    Protected startSpeed As Single
    Protected startAngle As Single

    Public Sub New(boxSize As Size)
        bounds = boxSize
        projectle = New Circle With {
            .posX = 0,
            .posY = bounds.Height - Shape.WIDTH
        }

    End Sub

    Public Overrides Sub mouseMove(e As MouseEventArgs)
        MyBase.MouseMove(e)
    End Sub

    Public Overrides Sub paint(e As PaintEventArgs)
        e.Graphics.DrawLine(Pens.Black, CInt(Shape.WIDTH / 2), CInt(bounds.Height - (Shape.WIDTH / 2)), bounds.Width, CInt(bounds.Height - (Shape.WIDTH / 2)))
        projectle.draw(e)

    End Sub

    Public Sub Move()

    End Sub

End Class