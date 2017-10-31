﻿Public NotInheritable Class Maths
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
    Public Shared Function QuadraticSolve(a As Single, b As Single, c As Single) As Single
        Dim soultion(1) As Single
        If (b ^ 2 - 4 * a * c < 0) Then
            Return Nothing
        Else
            soultion(0) = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            soultion(1) = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            If soultion(0) > soultion(1) Then
                Return soultion(0)
            Else
                Return soultion(1)

            End If
        End If
    End Function
End Class

Public NotInheritable Class SUVAT
    Public Shared Function Displacement(ByVal u As Double, ByVal v As Double, ByVal a As Double, ByVal t As Double) As Double
        If IsDBNull(u) Then
            Return v * t + 0.5 * a * t ^ 2
        ElseIf IsDBNull(v) Then
            Return u * t - 0.5 * a * t ^ 2
        ElseIf IsDBNull(a) Then
            Return ((u + v) / 2) * t
        ElseIf IsDBNull(t) Then
            Return (v ^ 2 - u ^ 2) / 2 * a
        Else
            Return vbNull
        End If
    End Function

    Public Shared Function InitalVelocity(ByVal s As Double, ByVal v As Double, ByVal a As Double, ByVal t As Double) As Double
        If IsDBNull(s) Then
            Return v - a * t
        ElseIf IsDBNull(v) Then
            Return (s - (0.5 * a * t ^ 2)) / t
        ElseIf IsDBNull(a) Then
            Return (2 * s / t) - v
        ElseIf IsDBNull(t) Then
            Return Math.Sqrt(v ^ 2 - (2 * a * s))
        Else
            Return vbNull
        End If
    End Function

    Public Shared Function FinalVelocity(ByVal s As Double, ByVal u As Double, ByVal a As Double, ByVal t As Double) As Double
        If IsDBNull(s) Then
            Return u * t + 0.5 * a * t ^ 2
        ElseIf IsDBNull(u) Then
            Return (s + (0.5 * a * t ^ 2)) / t
        ElseIf IsDBNull(a) Then
            Return (2 * s / t) - u
        ElseIf IsDBNull(t) Then
            Return Math.Sqrt(u ^ 2 + 2 * a * s)
        Else
            Return vbNull
        End If
    End Function

    Public Shared Function Acceleration(ByVal s As Double, ByVal u As Double, ByVal v As Double, ByVal t As Double) As Double
        If IsDBNull(s) Then
            Return (v - u) / t
        ElseIf IsDBNull(u) Then
            Return (-2 * (s - v * t)) / t ^ 2
        ElseIf IsDBNull(v) Then
            Return (2 * (s - u * t)) / t ^ 2
        ElseIf IsDBNull(t) Then
            Return (v ^ 2 - u ^ 2) / 2 * s
        Else
            Return vbNull
        End If
    End Function

    Public Shared Function Time(ByVal s As Double, ByVal u As Double, ByVal v As Double, ByVal a As Double) As Double
        If IsDBNull(s) Then
            Return (v - u) / a
        ElseIf IsDBNull(u) Then
            Return Maths.QuadraticSolve(0.5 * a, -v, s)
        ElseIf IsDBNull(v) Then
            Return Maths.QuadraticSolve(0.5 * a, u, -s)
        ElseIf IsDBNull(a) Then
            Return (2 * s) / (u + v)
        Else
            Return vbNull
        End If
    End Function

End Class
