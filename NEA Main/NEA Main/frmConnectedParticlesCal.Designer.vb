<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectedParticlesCal
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.updAngle = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updCOE = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updFreeMass = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updSlopeMass = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.updAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updCOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updFreeMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updSlopeMass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(189, 360)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'updAngle
        '
        Me.updAngle.DecimalPlaces = 3
        Me.updAngle.Location = New System.Drawing.Point(144, 44)
        Me.updAngle.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.updAngle.Name = "updAngle"
        Me.updAngle.Size = New System.Drawing.Size(120, 20)
        Me.updAngle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Angle of slope:"
        '
        'updCOE
        '
        Me.updCOE.DecimalPlaces = 3
        Me.updCOE.Location = New System.Drawing.Point(144, 76)
        Me.updCOE.Name = "updCOE"
        Me.updCOE.Size = New System.Drawing.Size(120, 20)
        Me.updCOE.TabIndex = 34
        Me.updCOE.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 26)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Coefficient of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "friction (N): "
        '
        'updFreeMass
        '
        Me.updFreeMass.DecimalPlaces = 3
        Me.updFreeMass.Location = New System.Drawing.Point(144, 140)
        Me.updFreeMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updFreeMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updFreeMass.Name = "updFreeMass"
        Me.updFreeMass.Size = New System.Drawing.Size(120, 20)
        Me.updFreeMass.TabIndex = 32
        Me.updFreeMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 26)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Object hanging" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "free mass' (kg): "
        '
        'updSlopeMass
        '
        Me.updSlopeMass.DecimalPlaces = 3
        Me.updSlopeMass.Location = New System.Drawing.Point(144, 108)
        Me.updSlopeMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updSlopeMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updSlopeMass.Name = "updSlopeMass"
        Me.updSlopeMass.Size = New System.Drawing.Size(120, 20)
        Me.updSlopeMass.TabIndex = 30
        Me.updSlopeMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Object on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "slopes's mass (kg): "
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(144, 12)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(120, 21)
        Me.cboGravity.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 26)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Acceleration due" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to gravity (m/s²):"
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(14, 172)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(250, 185)
        Me.lblOutput.TabIndex = 37
        '
        'frmConnectedParticlesCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(276, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboGravity)
        Me.Controls.Add(Me.updCOE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.updFreeMass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updSlopeMass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updAngle)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnectedParticlesCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculator"
        CType(Me.updAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updCOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updFreeMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updSlopeMass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As Button
    Friend WithEvents updAngle As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents updCOE As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents updFreeMass As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents updSlopeMass As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents lblOutput As Label
End Class
