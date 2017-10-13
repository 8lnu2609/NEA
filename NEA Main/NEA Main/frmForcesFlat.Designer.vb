﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForcesFlat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.trbTime = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAcceleration = New System.Windows.Forms.ComboBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVelocityX_Out = New System.Windows.Forms.TextBox()
        Me.tmrCalculation = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTimeSelect = New System.Windows.Forms.Panel()
        Me.optStepByStep = New System.Windows.Forms.RadioButton()
        Me.optRealTime = New System.Windows.Forms.RadioButton()
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.lblZoomLevel = New System.Windows.Forms.Label()
        Me.trbZoom = New System.Windows.Forms.TrackBar()
        Me.txtVelocityY_Out = New System.Windows.Forms.TextBox()
        Me.lblMaxHeightDisplay = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.cmdShowVeloctiyIn = New System.Windows.Forms.Button()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTimeSelect.SuspendLayout()
        CType(Me.trbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTips
        '
        Me.ToolTips.AutoPopDelay = 5000
        Me.ToolTips.InitialDelay = 1
        Me.ToolTips.ReshowDelay = 100
        '
        'trbTime
        '
        Me.trbTime.Location = New System.Drawing.Point(3, 49)
        Me.trbTime.Name = "trbTime"
        Me.trbTime.Size = New System.Drawing.Size(183, 45)
        Me.trbTime.TabIndex = 17
        Me.trbTime.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ToolTips.SetToolTip(Me.trbTime, "Time: 0")
        Me.trbTime.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Acceleration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "due to gravity"
        '
        'cboAcceleration
        '
        Me.cboAcceleration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAcceleration.FormattingEnabled = True
        Me.cboAcceleration.Location = New System.Drawing.Point(84, 121)
        Me.cboAcceleration.Name = "cboAcceleration"
        Me.cboAcceleration.Size = New System.Drawing.Size(114, 21)
        Me.cboAcceleration.TabIndex = 19
        '
        'cmdStart
        '
        Me.cmdStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdStart.Location = New System.Drawing.Point(123, 963)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 16
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(124, 992)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Horizontal Component"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Vertical Component"
        '
        'txtVelocityX_Out
        '
        Me.txtVelocityX_Out.Location = New System.Drawing.Point(124, 75)
        Me.txtVelocityX_Out.Name = "txtVelocityX_Out"
        Me.txtVelocityX_Out.ReadOnly = True
        Me.txtVelocityX_Out.Size = New System.Drawing.Size(76, 20)
        Me.txtVelocityX_Out.TabIndex = 27
        '
        'tmrCalculation
        '
        Me.tmrCalculation.Interval = 1
        '
        'pnlTimeSelect
        '
        Me.pnlTimeSelect.Controls.Add(Me.trbTime)
        Me.pnlTimeSelect.Controls.Add(Me.optStepByStep)
        Me.pnlTimeSelect.Controls.Add(Me.optRealTime)
        Me.pnlTimeSelect.Location = New System.Drawing.Point(6, 162)
        Me.pnlTimeSelect.Name = "pnlTimeSelect"
        Me.pnlTimeSelect.Size = New System.Drawing.Size(189, 105)
        Me.pnlTimeSelect.TabIndex = 21
        '
        'optStepByStep
        '
        Me.optStepByStep.AutoSize = True
        Me.optStepByStep.Location = New System.Drawing.Point(9, 26)
        Me.optStepByStep.Name = "optStepByStep"
        Me.optStepByStep.Size = New System.Drawing.Size(105, 17)
        Me.optStepByStep.TabIndex = 16
        Me.optStepByStep.Text = "Run step by step"
        Me.optStepByStep.UseVisualStyleBackColor = True
        '
        'optRealTime
        '
        Me.optRealTime.AutoSize = True
        Me.optRealTime.Checked = True
        Me.optRealTime.Location = New System.Drawing.Point(9, 3)
        Me.optRealTime.Name = "optRealTime"
        Me.optRealTime.Size = New System.Drawing.Size(98, 17)
        Me.optRealTime.TabIndex = 15
        Me.optRealTime.TabStop = True
        Me.optRealTime.Text = "Run in real time"
        Me.optRealTime.UseVisualStyleBackColor = True
        '
        'lblTotalTime
        '
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Location = New System.Drawing.Point(6, 270)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(107, 13)
        Me.lblTotalTime.TabIndex = 23
        Me.lblTotalTime.Text = "Total time of flight: 0s"
        '
        'lblZoomLevel
        '
        Me.lblZoomLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblZoomLevel.AutoSize = True
        Me.lblZoomLevel.Location = New System.Drawing.Point(6, 895)
        Me.lblZoomLevel.Name = "lblZoomLevel"
        Me.lblZoomLevel.Size = New System.Drawing.Size(51, 13)
        Me.lblZoomLevel.TabIndex = 29
        Me.lblZoomLevel.Text = "Zoom: 1x"
        '
        'trbZoom
        '
        Me.trbZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.trbZoom.Location = New System.Drawing.Point(6, 911)
        Me.trbZoom.Minimum = -9
        Me.trbZoom.Name = "trbZoom"
        Me.trbZoom.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trbZoom.Size = New System.Drawing.Size(45, 104)
        Me.trbZoom.TabIndex = 28
        Me.trbZoom.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trbZoom.Value = 1
        '
        'txtVelocityY_Out
        '
        Me.txtVelocityY_Out.Location = New System.Drawing.Point(124, 44)
        Me.txtVelocityY_Out.Name = "txtVelocityY_Out"
        Me.txtVelocityY_Out.ReadOnly = True
        Me.txtVelocityY_Out.Size = New System.Drawing.Size(76, 20)
        Me.txtVelocityY_Out.TabIndex = 26
        '
        'lblMaxHeightDisplay
        '
        Me.lblMaxHeightDisplay.AutoSize = True
        Me.lblMaxHeightDisplay.Location = New System.Drawing.Point(6, 330)
        Me.lblMaxHeightDisplay.Name = "lblMaxHeightDisplay"
        Me.lblMaxHeightDisplay.Size = New System.Drawing.Size(79, 13)
        Me.lblMaxHeightDisplay.TabIndex = 25
        Me.lblMaxHeightDisplay.Text = "Max height: 0m"
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(6, 300)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(59, 13)
        Me.lblRange.TabIndex = 24
        Me.lblRange.Text = "Range: 0m"
        '
        'grpData
        '
        Me.grpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.BackColor = System.Drawing.SystemColors.Control
        Me.grpData.Controls.Add(Me.lblZoomLevel)
        Me.grpData.Controls.Add(Me.trbZoom)
        Me.grpData.Controls.Add(Me.txtVelocityY_Out)
        Me.grpData.Controls.Add(Me.lblMaxHeightDisplay)
        Me.grpData.Controls.Add(Me.lblRange)
        Me.grpData.Controls.Add(Me.lblTotalTime)
        Me.grpData.Controls.Add(Me.cmdShowVeloctiyIn)
        Me.grpData.Controls.Add(Me.pnlTimeSelect)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Controls.Add(Me.cboAcceleration)
        Me.grpData.Controls.Add(Me.cmdStart)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.txtVelocityX_Out)
        Me.grpData.Location = New System.Drawing.Point(1691, 10)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(205, 1021)
        Me.grpData.TabIndex = 16
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'cmdShowVeloctiyIn
        '
        Me.cmdShowVeloctiyIn.Location = New System.Drawing.Point(6, 19)
        Me.cmdShowVeloctiyIn.Name = "cmdShowVeloctiyIn"
        Me.cmdShowVeloctiyIn.Size = New System.Drawing.Size(99, 23)
        Me.cmdShowVeloctiyIn.TabIndex = 22
        Me.cmdShowVeloctiyIn.Text = "Enter Velocity"
        Me.cmdShowVeloctiyIn.UseVisualStyleBackColor = True
        '
        'tmrDraw
        '
        Me.tmrDraw.Enabled = True
        Me.tmrDraw.Interval = 1
        '
        'picDisplay
        '
        Me.picDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(12, 10)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(1674, 1024)
        Me.picDisplay.TabIndex = 15
        Me.picDisplay.TabStop = False
        '
        'frmForcesFlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picDisplay)
        Me.Name = "frmForcesFlat"
        Me.Text = "frmForcesFlat"
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTimeSelect.ResumeLayout(False)
        Me.pnlTimeSelect.PerformLayout()
        CType(Me.trbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents trbTime As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents cboAcceleration As ComboBox
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVelocityX_Out As TextBox
    Friend WithEvents tmrCalculation As Timer
    Friend WithEvents pnlTimeSelect As Panel
    Friend WithEvents optStepByStep As RadioButton
    Friend WithEvents optRealTime As RadioButton
    Friend WithEvents lblTotalTime As Label
    Friend WithEvents lblZoomLevel As Label
    Friend WithEvents trbZoom As TrackBar
    Friend WithEvents txtVelocityY_Out As TextBox
    Friend WithEvents lblMaxHeightDisplay As Label
    Friend WithEvents lblRange As Label
    Friend WithEvents grpData As GroupBox
    Friend WithEvents cmdShowVeloctiyIn As Button
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents picDisplay As PictureBox
End Class