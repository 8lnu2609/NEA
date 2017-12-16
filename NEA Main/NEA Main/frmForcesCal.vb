Public Class frmForcesCal
    Dim accelerationGravity As Single

    Sub New()
        InitializeComponent()
        PopulateAccelerationCbo(cboGravity)
        For Each control As Control In Controls
            If control.GetType = GetType(NumericUpDown) Then
                AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf calc
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

    Sub calc()
        Dim mass As Single = updMass.Value
        Dim COEofFriction As Single = updFrictionCOE.Value
        Dim force As Single = updForce.Value
        Dim friction As Single
        If force > mass * accelerationGravity * COEofFriction Then
            friction = mass * accelerationGravity * COEofFriction
        Else
            friction = force
        End If
        Dim resultantForce As Single = force - friction
        lblOutput.Text = String.Format("The weight of the object is {0:#,0.0##}N,
the force of friction resisting motion is {1:#,0.0##}N,
and is accelerating at {2:#,0.0##}m/s²,", mass * accelerationGravity, friction, resultantForce / mass)


    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        calc()
    End Sub
End Class