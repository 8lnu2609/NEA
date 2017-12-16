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

    Public Shared Function DegToRad(angle As Single) As Double
        Return angle * Math.PI / 180
    End Function

    Public Shared Function RadToDeg(angle As Single) As Double
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
    ''' <summary>
    ''' Solves simultaneous equation ax+by=m, cx+dy=n
    ''' x = (0), y = (1)
    ''' </summary>
    ''' <param name="a">x coefficient</param>
    ''' <param name="b">y coefficient</param>
    ''' <param name="m">RHS first line</param>
    ''' <param name="c">x coefficient</param>
    ''' <param name="d">y coefficient</param>
    ''' <param name="n">RHS second Line</param>
    ''' <returns></returns>
    Public Shared Function SimultaneousSolve(a As Single, b As Single, m As Single, c As Single, d As Single, n As Single) As Single()
        Dim answer(1) As Single
        answer(0) = (b * n - d * m) / (b * c - a * d)
        answer(1) = (a * n - c * m) / (a * d - b * c)
        Return answer
    End Function

#Region "SUVAT Solve"
    Public Shared Function Displacement(ByVal u As Single?, ByVal v As Single?, ByVal a As Single?, ByVal t As Single?) As Single?
        If Single.IsNaN(u) Then
            Return v * t + 0.5 * a * t ^ 2
        ElseIf Single.IsNaN(v) Then
            Return u * t - 0.5 * a * t ^ 2
        ElseIf Single.IsNaN(a) Then
            Return ((u + v) / 2) * t
        ElseIf Single.IsNaN(t) Then
            Return (v ^ 2 - u ^ 2) / 2 * a
        Else
            Return Single.NaN
        End If
    End Function

    Public Shared Function InitalVelocity(ByVal s As Single?, ByVal v As Single?, ByVal a As Single?, ByVal t As Single?) As Single?
        If Single.IsNaN(s) Then
            Return v - a * t
        ElseIf Single.IsNaN(v) Then
            Return (s - (0.5 * a * t ^ 2)) / t
        ElseIf Single.IsNaN(a) Then
            Return (2 * s / t) - v
        ElseIf Single.IsNaN(t) Then
            Return Math.Sqrt(v ^ 2 - (2 * a * s))
        Else
            Return Math.Sqrt(v ^ 2 - (2 * a * s))
        End If
    End Function

    Public Shared Function FinalVelocity(ByVal s As Single?, ByVal u As Single?, ByVal a As Single?, ByVal t As Single?) As Single?
        If Single.IsNaN(s) Then
            Return u * t + 0.5 * a * t ^ 2
        ElseIf Single.IsNaN(u) Then
            Return (s + (0.5 * a * t ^ 2)) / t
        ElseIf Single.IsNaN(a) Then
            Return (2 * s / t) - u
        ElseIf Single.IsNaN(t) Then
            Return Math.Sqrt(u ^ 2 + 2 * a * s)
        Else
            Return Math.Sqrt(u ^ 2 + 2 * a * s)
        End If
    End Function

    Public Shared Function Acceleration(ByVal s As Single?, ByVal u As Single?, ByVal v As Single?, ByVal t As Single?) As Single?
        If Single.IsNaN(s) Then
            Return (v - u) / t
        ElseIf Single.IsNaN(u) Then
            Return (-2 * (s - v * t)) / t ^ 2
        ElseIf Single.IsNaN(v) Then
            Return (2 * (s - u * t)) / t ^ 2
        ElseIf Single.IsNaN(t) Then
            Return (v ^ 2 - u ^ 2) / 2 * s
        Else
            Return (v ^ 2 - u ^ 2) / 2 * s
        End If
    End Function

    Public Shared Function Time(ByVal s As Single?, ByVal u As Single?, ByVal v As Single?, ByVal a As Single?) As Single?
        If Single.IsNaN(s) Then
            Return (v - u) / a
        ElseIf Single.IsNaN(u) Then
            Return QuadraticSolve(0.5 * a, -v, s)
        ElseIf Single.IsNaN(v) Then
            Return QuadraticSolve(0.5 * a, u, -s)
        ElseIf Single.IsNaN(a) Then
            Return (2 * s) / (u + v)
        Else
            Return (2 * s) / (u + v)
        End If
    End Function
#End Region
End Class
