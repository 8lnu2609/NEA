Enum Sim
    projectile = 0
End Enum

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