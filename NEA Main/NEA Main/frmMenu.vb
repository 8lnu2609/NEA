Public Class frmMenu
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub CmdProjectileSim_Click(sender As Object, e As EventArgs) Handles cmdProjectileSim.Click
        Dim Projectiles As New frmProjectileSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        Projectiles.ShowDialog()
    End Sub

    Private Sub CmdProjectileCal_Click(sender As Object, e As EventArgs) Handles cmdProjectileCal.Click
        Dim Cal As New frmProjectileCal
        Cal.Show()
    End Sub

    Private Sub CmdForceSim_Click(sender As Object, e As EventArgs) Handles cmdForceSim.Click
        Dim Forces As New frmForcesFlatSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        Forces.ShowDialog()
    End Sub

    Private Sub CmdForceCal_Click(sender As Object, e As EventArgs) Handles cmdForceCal.Click
        Dim Cal As New frmForcesCal
        Cal.Show()
    End Sub

    Private Sub CmdTurningSim_Click(sender As Object, e As EventArgs) Handles cmdTurningSim.Click
        Dim Turning As New frmTurningPointsSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        Turning.ShowDialog()
    End Sub

    Private Sub CmdTurningCal_Click(sender As Object, e As EventArgs) Handles cmdTurningCal.Click
        Dim Cal As New frmTurningPointsCal
        Cal.Show()
    End Sub

    Private Sub CmdFreefallSim_Click(sender As Object, e As EventArgs) Handles cmdFreefallSim.Click
        Dim Freefall As New frmFreefallSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        Freefall.ShowDialog()
    End Sub

    Private Sub CmdFreefallCal_Click(sender As Object, e As EventArgs) Handles cmdFreefallCal.Click
        Dim Cal As New frmFreefallCal
        Cal.Show()
    End Sub

    Private Sub CmdMomentumSim_Click(sender As Object, e As EventArgs) Handles cmdMomentumSim.Click
        Dim Momentum As New frmMomentumSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        Momentum.ShowDialog()
    End Sub

    Private Sub CmdMomentumCal_Click(sender As Object, e As EventArgs) Handles cmdMomentumCal.Click
        Dim Cal As New frmMomentumCal
        Cal.Show()
    End Sub

    Private Sub CmdConnected_Click(sender As Object, e As EventArgs) Handles cmdConnected.Click
        Dim ConnectedParticles As New frmConnectedParticlesSim With {
            .Width = My.Computer.Screen.WorkingArea.Width,
            .Height = My.Computer.Screen.WorkingArea.Height
        }
        ConnectedParticles.ShowDialog()
    End Sub

    Private Sub CmdConnectedCal_Click(sender As Object, e As EventArgs) Handles cmdConnectedCal.Click
        Dim Cal As New frmConnectedParticlesCal
        Cal.Show()
    End Sub

End Class