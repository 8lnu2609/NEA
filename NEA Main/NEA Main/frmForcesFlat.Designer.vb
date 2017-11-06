<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tmrCalculation = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTimeSelect = New System.Windows.Forms.Panel()
        Me.updTotalTime = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optStepByStep = New System.Windows.Forms.RadioButton()
        Me.optRealTime = New System.Windows.Forms.RadioButton()
        Me.lblZoomLevel = New System.Windows.Forms.Label()
        Me.trbZoom = New System.Windows.Forms.TrackBar()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.pnlFrictionSelect = New System.Windows.Forms.Panel()
        Me.lblForce = New System.Windows.Forms.Label()
        Me.lblTotalFriction = New System.Windows.Forms.Label()
        Me.updFrictionCOE = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAcceleration = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updMass = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.trbForce = New System.Windows.Forms.TrackBar()
        Me.updForce = New System.Windows.Forms.NumericUpDown()
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTimeSelect.SuspendLayout()
        CType(Me.updTotalTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.pnlFrictionSelect.SuspendLayout()
        CType(Me.updFrictionCOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbForce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updForce, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tmrCalculation
        '
        Me.tmrCalculation.Interval = 1
        '
        'pnlTimeSelect
        '
        Me.pnlTimeSelect.Controls.Add(Me.updTotalTime)
        Me.pnlTimeSelect.Controls.Add(Me.Label5)
        Me.pnlTimeSelect.Controls.Add(Me.trbTime)
        Me.pnlTimeSelect.Controls.Add(Me.optStepByStep)
        Me.pnlTimeSelect.Controls.Add(Me.optRealTime)
        Me.pnlTimeSelect.Location = New System.Drawing.Point(6, 228)
        Me.pnlTimeSelect.Name = "pnlTimeSelect"
        Me.pnlTimeSelect.Size = New System.Drawing.Size(189, 126)
        Me.pnlTimeSelect.TabIndex = 21
        '
        'updTotalTime
        '
        Me.updTotalTime.DecimalPlaces = 3
        Me.updTotalTime.Location = New System.Drawing.Point(78, 95)
        Me.updTotalTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updTotalTime.Name = "updTotalTime"
        Me.updTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.updTotalTime.Size = New System.Drawing.Size(108, 20)
        Me.updTotalTime.TabIndex = 19
        Me.updTotalTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.updTotalTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total time"
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
        'grpData
        '
        Me.grpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.BackColor = System.Drawing.SystemColors.Control
        Me.grpData.Controls.Add(Me.pnlFrictionSelect)
        Me.grpData.Controls.Add(Me.updFrictionCOE)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Controls.Add(Me.cboAcceleration)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.updMass)
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.lblZoomLevel)
        Me.grpData.Controls.Add(Me.trbZoom)
        Me.grpData.Controls.Add(Me.pnlTimeSelect)
        Me.grpData.Controls.Add(Me.cmdStart)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Location = New System.Drawing.Point(1691, 10)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(205, 1021)
        Me.grpData.TabIndex = 16
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'pnlFrictionSelect
        '
        Me.pnlFrictionSelect.Controls.Add(Me.updForce)
        Me.pnlFrictionSelect.Controls.Add(Me.trbForce)
        Me.pnlFrictionSelect.Controls.Add(Me.lblForce)
        Me.pnlFrictionSelect.Controls.Add(Me.lblTotalFriction)
        Me.pnlFrictionSelect.Location = New System.Drawing.Point(6, 119)
        Me.pnlFrictionSelect.Name = "pnlFrictionSelect"
        Me.pnlFrictionSelect.Size = New System.Drawing.Size(189, 103)
        Me.pnlFrictionSelect.TabIndex = 20
        '
        'lblForce
        '
        Me.lblForce.AutoSize = True
        Me.lblForce.Location = New System.Drawing.Point(6, 10)
        Me.lblForce.Name = "lblForce"
        Me.lblForce.Size = New System.Drawing.Size(54, 13)
        Me.lblForce.TabIndex = 0
        Me.lblForce.Text = "Force: 0N"
        '
        'lblTotalFriction
        '
        Me.lblTotalFriction.AutoSize = True
        Me.lblTotalFriction.Location = New System.Drawing.Point(6, 88)
        Me.lblTotalFriction.Name = "lblTotalFriction"
        Me.lblTotalFriction.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalFriction.TabIndex = 36
        Me.lblTotalFriction.Text = "Friction: 0N"
        '
        'updFrictionCOE
        '
        Me.updFrictionCOE.DecimalPlaces = 3
        Me.updFrictionCOE.Location = New System.Drawing.Point(133, 48)
        Me.updFrictionCOE.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updFrictionCOE.Name = "updFrictionCOE"
        Me.updFrictionCOE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.updFrictionCOE.Size = New System.Drawing.Size(66, 20)
        Me.updFrictionCOE.TabIndex = 35
        Me.updFrictionCOE.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.updFrictionCOE.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Acceleration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "due to gravity"
        '
        'cboAcceleration
        '
        Me.cboAcceleration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAcceleration.FormattingEnabled = True
        Me.cboAcceleration.Location = New System.Drawing.Point(85, 78)
        Me.cboAcceleration.Name = "cboAcceleration"
        Me.cboAcceleration.Size = New System.Drawing.Size(114, 21)
        Me.cboAcceleration.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Coefficient of Friction (μ)"
        '
        'updMass
        '
        Me.updMass.DecimalPlaces = 3
        Me.updMass.Location = New System.Drawing.Point(124, 19)
        Me.updMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updMass.Name = "updMass"
        Me.updMass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.updMass.Size = New System.Drawing.Size(75, 20)
        Me.updMass.TabIndex = 31
        Me.updMass.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.updMass.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Mass"
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
        'trbForce
        '
        Me.trbForce.Location = New System.Drawing.Point(3, 36)
        Me.trbForce.Maximum = 50
        Me.trbForce.Name = "trbForce"
        Me.trbForce.Size = New System.Drawing.Size(183, 45)
        Me.trbForce.TabIndex = 37
        Me.trbForce.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'updForce
        '
        Me.updForce.Location = New System.Drawing.Point(78, 8)
        Me.updForce.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.updForce.Name = "updForce"
        Me.updForce.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.updForce.Size = New System.Drawing.Size(108, 20)
        Me.updForce.TabIndex = 38
        Me.updForce.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'frmForcesFlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "frmForcesFlat"
        Me.ShowIcon = False
        Me.Text = "frmForcesFlat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTimeSelect.ResumeLayout(False)
        Me.pnlTimeSelect.PerformLayout()
        CType(Me.updTotalTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.pnlFrictionSelect.ResumeLayout(False)
        Me.pnlFrictionSelect.PerformLayout()
        CType(Me.updFrictionCOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbForce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updForce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents trbTime As TrackBar
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents tmrCalculation As Timer
    Friend WithEvents pnlTimeSelect As Panel
    Friend WithEvents optStepByStep As RadioButton
    Friend WithEvents optRealTime As RadioButton
    Friend WithEvents lblZoomLevel As Label
    Friend WithEvents trbZoom As TrackBar
    Friend WithEvents grpData As GroupBox
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents updMass As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cboAcceleration As ComboBox
    Friend WithEvents updTotalTime As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalFriction As Label
    Friend WithEvents updFrictionCOE As NumericUpDown
    Friend WithEvents pnlFrictionSelect As Panel
    Friend WithEvents lblForce As Label
    Friend WithEvents trbForce As TrackBar
    Friend WithEvents updForce As NumericUpDown
End Class
