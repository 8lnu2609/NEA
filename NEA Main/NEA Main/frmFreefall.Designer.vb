﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreefall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFreefall))
        Me.picBoxDisplay = New System.Windows.Forms.PictureBox()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.pnlTimeSelect = New System.Windows.Forms.Panel()
        Me.trbTime = New System.Windows.Forms.TrackBar()
        Me.optStepByStep = New System.Windows.Forms.RadioButton()
        Me.optRealTime = New System.Windows.Forms.RadioButton()
        Me.updHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboShapes = New System.Windows.Forms.ComboBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.updLength = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picBoxDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.pnlTimeSelect.SuspendLayout()
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxDisplay
        '
        Me.picBoxDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxDisplay.BackColor = System.Drawing.Color.White
        Me.picBoxDisplay.Location = New System.Drawing.Point(12, 12)
        Me.picBoxDisplay.Name = "picBoxDisplay"
        Me.picBoxDisplay.Size = New System.Drawing.Size(1132, 718)
        Me.picBoxDisplay.TabIndex = 0
        Me.picBoxDisplay.TabStop = False
        '
        'grpData
        '
        Me.grpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.Controls.Add(Me.updLength)
        Me.grpData.Controls.Add(Me.Label4)
        Me.grpData.Controls.Add(Me.pnlTimeSelect)
        Me.grpData.Controls.Add(Me.updHeight)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.cboGravity)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.cboShapes)
        Me.grpData.Location = New System.Drawing.Point(1150, 12)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(200, 718)
        Me.grpData.TabIndex = 1
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'pnlTimeSelect
        '
        Me.pnlTimeSelect.Controls.Add(Me.cmdStart)
        Me.pnlTimeSelect.Controls.Add(Me.trbTime)
        Me.pnlTimeSelect.Controls.Add(Me.optStepByStep)
        Me.pnlTimeSelect.Controls.Add(Me.optRealTime)
        Me.pnlTimeSelect.Location = New System.Drawing.Point(6, 263)
        Me.pnlTimeSelect.Name = "pnlTimeSelect"
        Me.pnlTimeSelect.Size = New System.Drawing.Size(189, 105)
        Me.pnlTimeSelect.TabIndex = 22
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
        'updHeight
        '
        Me.updHeight.DecimalPlaces = 3
        Me.updHeight.Location = New System.Drawing.Point(78, 110)
        Me.updHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updHeight.Name = "updHeight"
        Me.updHeight.Size = New System.Drawing.Size(120, 20)
        Me.updHeight.TabIndex = 5
        Me.updHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Height of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the cliff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Acceleration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "due to gravity"
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(83, 26)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(111, 21)
        Me.cboGravity.TabIndex = 2
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(119, 689)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shape:"
        '
        'cboShapes
        '
        Me.cboShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShapes.FormattingEnabled = True
        Me.cboShapes.Location = New System.Drawing.Point(73, 64)
        Me.cboShapes.Name = "cboShapes"
        Me.cboShapes.Size = New System.Drawing.Size(121, 21)
        Me.cboShapes.TabIndex = 0
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        '
        'DrawTimer
        '
        Me.DrawTimer.Enabled = True
        Me.DrawTimer.Interval = 1
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(111, 58)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 23
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'updLength
        '
        Me.updLength.DecimalPlaces = 3
        Me.updLength.Location = New System.Drawing.Point(80, 136)
        Me.updLength.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updLength.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updLength.Name = "updLength"
        Me.updLength.Size = New System.Drawing.Size(120, 20)
        Me.updLength.TabIndex = 24
        Me.updLength.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Length"
        '
        'frmFreefall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picBoxDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFreefall"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Free fall"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBoxDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.pnlTimeSelect.ResumeLayout(False)
        Me.pnlTimeSelect.PerformLayout()
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBoxDisplay As PictureBox
    Friend WithEvents grpData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboShapes As ComboBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents cmdClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents updHeight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents DrawTimer As Timer
    Friend WithEvents pnlTimeSelect As Panel
    Friend WithEvents trbTime As TrackBar
    Friend WithEvents optStepByStep As RadioButton
    Friend WithEvents optRealTime As RadioButton
    Friend WithEvents cmdStart As Button
    Friend WithEvents updLength As NumericUpDown
    Friend WithEvents Label4 As Label
End Class