﻿Public Class frmMenu
    Private Sub cmdProjectileSim_Click(sender As Object, e As EventArgs) Handles cmdProjectileSim.Click
        Dim Projectiles As New frmProjectile
        Projectiles.Show()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdProjectileCal_Click(sender As Object, e As EventArgs) Handles cmdProjectileCal.Click
        Dim Cal As New frmProjectileCal
        Cal.Show()
    End Sub

    Private Sub cmdForceSim_Click(sender As Object, e As EventArgs) Handles cmdForceSim.Click
        Dim Forces As New frmForcesFlat
        Forces.Show()
    End Sub

    Private Sub cmdForceCal_Click(sender As Object, e As EventArgs) Handles cmdForceCal.Click

    End Sub
End Class