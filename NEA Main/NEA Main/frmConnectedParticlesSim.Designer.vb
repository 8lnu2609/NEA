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
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.updAngle = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCalculation = New System.Windows.Forms.Timer(Me.components)
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.grpData.SuspendLayout()
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
        Me.grpData.Controls.Add(Me.updAngle)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.cboGravity)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Location = New System.Drawing.Point(1102, 7)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(214, 693)
        Me.grpData.TabIndex = 16
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'updAngle
        '
        Me.updAngle.DecimalPlaces = 3
        Me.updAngle.Location = New System.Drawing.Point(92, 64)
        Me.updAngle.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.updAngle.Name = "updAngle"
        Me.updAngle.Size = New System.Drawing.Size(116, 20)
        Me.updAngle.TabIndex = 20
        Me.updAngle.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
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
        Me.Label1.Size = New System.Drawing.Size(90, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Acceleration due" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to gravity (ms^-2):"
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
        Me.cmdClose.Location = New System.Drawing.Point(129, 664)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tmrDraw
        '
        Me.tmrDraw.Enabled = True
        Me.tmrDraw.Interval = 1
        '
        'tmrCalculation
        '
        Me.tmrCalculation.Interval = 1
        '
        'picDisplay
        '
        Me.picDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(4, 7)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(1092, 693)
        Me.picDisplay.TabIndex = 15
        Me.picDisplay.TabStop = False
        '
        'frmConnectedParticlesSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1319, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "frmConnectedParticlesSim"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Connected Particles Simulator"
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
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
End Class
