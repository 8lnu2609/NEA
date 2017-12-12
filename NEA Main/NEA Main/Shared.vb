Module SharedVariables
    Public xVelocity As Single = 50
    Public yVelocity As Single = 5

    Public AccelerationDictionary As New Dictionary(Of String, Single) From {
        {"Sun", 274.13},
        {"Mercury", 3.59},
        {"Venus", 8.89},
        {"Earth", 9.81},
        {"Moon", 1.62},
        {"Mars", 3.77},
        {"Jupiter", 25.95},
        {"Saturn", 11.08},
        {"Uranus", 10.67},
        {"Neptune", 14.07},
        {"Pluto", 0.42}
    }
    Public MaterialDictionary As New Dictionary(Of String, Single) From {
        {"Perfect", 1},
        {"Brass", 0.3},
        {"Bronze", 0.52},
        {"Copper", 0.22},
        {"Cork", 0.6},
        {"Elm", 0.48},
        {"Glass", 0.96},
        {"Iron", 0.67},
        {"Ivory", 0.78},
        {"Lead", 0.16},
        {"Maple", 0.65},
        {"Rubber", 0.75},
        {"Steel", 0.9}
    }


    Public Sub PopulateAccelerationCbo(ByRef combo As ComboBox)
        For Each pair As KeyValuePair(Of String, Single) In AccelerationDictionary
            combo.Items.Add(pair.Key)
        Next
        combo.SelectedIndex = 3
    End Sub

    Public Function GetGravityAcceleration(ByRef combo As ComboBox) As Single
        If combo.SelectedItem <> Nothing Then
            Return AccelerationDictionary.Item(combo.SelectedItem())
        Else
            Return AccelerationDictionary.Item("Earth")
        End If

    End Function

End Module
