<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnectedParticlesSim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectedParticlesSim))
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.updCOE = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updFreeMass = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updSlopeMass = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updAngle = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCalculation = New System.Windows.Forms.Timer(Me.components)
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.grpData.SuspendLayout()
        CType(Me.updCOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updFreeMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updSlopeMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        Me.ToolTips.AutoPopDelay = 0
        Me.ToolTips.InitialDelay = 200
        Me.ToolTips.ReshowDelay = 40
        '
        'grpData
        '
        Me.grpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.BackColor = System.Drawing.SystemColors.Control
        Me.grpData.Controls.Add(Me.cmdStart)
        Me.grpData.Controls.Add(Me.lblOutput)
        Me.grpData.Controls.Add(Me.updCOE)
        Me.grpData.Controls.Add(Me.Label5)
        Me.grpData.Controls.Add(Me.updFreeMass)
        Me.grpData.Controls.Add(Me.Label4)
        Me.grpData.Controls.Add(Me.updSlopeMass)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Controls.Add(Me.updAngle)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.cboGravity)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Location = New System.Drawing.Point(1139, 7)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(219, 692)
        Me.grpData.TabIndex = 16
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'cmdStart
        '
        Me.cmdStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStart.Location = New System.Drawing.Point(50, 663)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 27
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(6, 232)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(196, 220)
        Me.lblOutput.TabIndex = 17
        '
        'updCOE
        '
        Me.updCOE.DecimalPlaces = 3
        Me.updCOE.Location = New System.Drawing.Point(91, 62)
        Me.updCOE.Name = "updCOE"
        Me.updCOE.Size = New System.Drawing.Size(116, 20)
        Me.updCOE.TabIndex = 26
        Me.updCOE.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 26)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Coefficient of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "friction (N): "
        '
        'updFreeMass
        '
        Me.updFreeMass.DecimalPlaces = 3
        Me.updFreeMass.Location = New System.Drawing.Point(92, 170)
        Me.updFreeMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updFreeMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updFreeMass.Name = "updFreeMass"
        Me.updFreeMass.Size = New System.Drawing.Size(116, 20)
        Me.updFreeMass.TabIndex = 24
        Me.updFreeMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Object 2's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mass (kg): "
        '
        'updSlopeMass
        '
        Me.updSlopeMass.DecimalPlaces = 3
        Me.updSlopeMass.Location = New System.Drawing.Point(92, 134)
        Me.updSlopeMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updSlopeMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updSlopeMass.Name = "updSlopeMass"
        Me.updSlopeMass.Size = New System.Drawing.Size(116, 20)
        Me.updSlopeMass.TabIndex = 22
        Me.updSlopeMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Object 1's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mass (kg): "
        '
        'updAngle
        '
        Me.updAngle.DecimalPlaces = 3
        Me.updAngle.Location = New System.Drawing.Point(92, 99)
        Me.updAngle.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.updAngle.Name = "updAngle"
        Me.updAngle.Size = New System.Drawing.Size(116, 20)
        Me.updAngle.TabIndex = 20
        Me.updAngle.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Angle (°):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Acceleration due" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to gravity (m/s²):"
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(107, 27)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(101, 21)
        Me.cboGravity.TabIndex = 17
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(131, 663)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tmrDraw
        '
        Me.tmrDraw.Enabled = True
        Me.tmrDraw.Interval = 10
        '
        'tmrCalculation
        '
        Me.tmrCalculation.Interval = 10
        '
        'picDisplay
        '
        Me.picDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(4, 7)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(1129, 692)
        Me.picDisplay.TabIndex = 15
        Me.picDisplay.TabStop = False
        '
        'frmConnectedParticlesSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1354, 695)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "frmConnectedParticlesSim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Connected Particles Simulator"
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        CType(Me.updCOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updFreeMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updSlopeMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents grpData As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents tmrCalculation As Timer
    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents updAngle As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents updSlopeMass As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents updFreeMass As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents updCOE As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdStart As Button
End Class
