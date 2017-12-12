Public Class frmMenu
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdProjectileSim_Click(sender As Object, e As EventArgs) Handles cmdProjectileSim.Click
        Dim Projectiles As New frmProjectileSim With {
            .Width = Screen.PrimaryScreen.Bounds.Width - 100,
            .Height = Screen.PrimaryScreen.Bounds.Height - 100
        }
        Projectiles.ShowDialog()
    End Sub

    Private Sub cmdProjectileCal_Click(sender As Object, e As EventArgs) Handles cmdProjectileCal.Click
        Dim Cal As New frmProjectileCal
        Cal.Show()
    End Sub

    Private Sub cmdForceSim_Click(sender As Object, e As EventArgs) Handles cmdForceSim.Click
        Dim Forces As New frmForcesFlatSim With {
            .Width = Screen.PrimaryScreen.Bounds.Width - 100,
            .Height = Screen.PrimaryScreen.Bounds.Height - 100
        }
        Forces.ShowDialog()
    End Sub

    Private Sub cmdForceCal_Click(sender As Object, e As EventArgs) Handles cmdForceCal.Click
        Dim Cal As New frmForcesCal
        Cal.Show()
    End Sub

    Private Sub cmdTurningSim_Click(sender As Object, e As EventArgs) Handles cmdTurningSim.Click
        Dim Turning As New frmTurningPointsSim With {
            .Width = Screen.PrimaryScreen.Bounds.Width - 100,
            .Height = Screen.PrimaryScreen.Bounds.Height - 100
        }
        Turning.ShowDialog()
    End Sub

    Private Sub cmdTurningCal_Click(sender As Object, e As EventArgs) Handles cmdTurningCal.Click
        Dim Cal As New frmTurningPointsCal
        Cal.Show()
    End Sub

    Private Sub cmdFreefallSim_Click(sender As Object, e As EventArgs) Handles cmdFreefallSim.Click
        Dim Freefall As New frmFreefallSim With {
            .Width = Screen.PrimaryScreen.Bounds.Width - 100,
            .Height = Screen.PrimaryScreen.Bounds.Height - 100
        }
        Freefall.ShowDialog()
    End Sub

    Private Sub cmdFreefallCal_Click(sender As Object, e As EventArgs) Handles cmdFreefallCal.Click
        Dim Cal As New frmFreefallCal
        Cal.Show()
    End Sub

    Private Sub cmdMomentumSim_Click(sender As Object, e As EventArgs) Handles cmdMomentumSim.Click
        Dim Collision As New frmMomentumSim With {
            .Width = Screen.PrimaryScreen.Bounds.Width - 100,
            .Height = Screen.PrimaryScreen.Bounds.Height - 100
        }
        Collision.ShowDialog()
    End Sub

    Private Sub cmdMomentumCal_Click(sender As Object, e As EventArgs) Handles cmdMomentumCal.Click
        Dim Cal As New frmMomentumCal
        Cal.Show()
    End Sub
End Class