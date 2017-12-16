Public Class frmConnectedParticlesCal
    Dim accelerationGravity As Single

    Public Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        For Each control As Control In Controls
            If control.GetType = GetType(NumericUpDown) Then
                AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf Calculate
            End If
        Next
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        accelerationGravity = GetGravityAcceleration(cboGravity)
        ToolTips.SetToolTip(cboGravity, accelerationGravity & "m/s²")
    End Sub

    Sub Calculate()
        Dim tension As Single = updFreeMass.Value * accelerationGravity
        Dim normalReaction As Single = updSlopeMass.Value * accelerationGravity * Math.Cos(Maths.DegToRad(updAngle.Value))
        Dim maxFriction As Single = updCOE.Value * normalReaction
        Dim weightDown As Single = updSlopeMass.Value * accelerationGravity * Math.Sin(Maths.DegToRad(updAngle.Value))
        Dim friction As Single
        If Math.Abs(tension - weightDown) > maxFriction Then
            friction = maxFriction
        Else
            friction = Math.Abs(tension - weightDown)
        End If
        Dim resultantForce = tension - friction - weightDown
        Dim acceleration = resultantForce / updSlopeMass.Value
        Dim direction As String
        If acceleration = 0 Then
            direction = "the system is in equilibrium"
        ElseIf acceleration < 0 Then
            direction = "acting down the slope"
        Else
            direction = "acting up the slope"
        End If

        lblOutput.Text = String.Format("The tension in the rope is {0:0.###}N,
the normal reaction between object 1 and the slope is {1:0.###}N,
the maximum friction between object 1 and the slope is {2:0.###}N,
the friction between object 1 and the slope is {3:0.###}N,
the component of weight acting down the slope is {4:0.###}N,
this gives a resultant force of {5:0.###}N
the resultant force accelerates the box at {6:0.###}m/s², {7}", tension, normalReaction, maxFriction, friction, weightDown, resultantForce, Math.Abs(acceleration), direction)

    End Sub

End Class