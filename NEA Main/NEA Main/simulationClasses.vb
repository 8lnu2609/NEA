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