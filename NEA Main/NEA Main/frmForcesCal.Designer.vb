<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForcesCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForcesCal))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.updMass = New System.Windows.Forms.NumericUpDown()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.updFrictionCOE = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updForce = New System.Windows.Forms.NumericUpDown()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updFrictionCOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updForce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(311, 150)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mass (kg):"
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(265, 11)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(121, 21)
        Me.cboGravity.TabIndex = 5
        '
        'updMass
        '
        Me.updMass.DecimalPlaces = 3
        Me.updMass.Location = New System.Drawing.Point(139, 12)
        Me.updMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updMass.Name = "updMass"
        Me.updMass.Size = New System.Drawing.Size(120, 20)
        Me.updMass.TabIndex = 6
        Me.updMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(311, 121)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 7
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'updFrictionCOE
        '
        Me.updFrictionCOE.DecimalPlaces = 3
        Me.updFrictionCOE.Location = New System.Drawing.Point(139, 42)
        Me.updFrictionCOE.Name = "updFrictionCOE"
        Me.updFrictionCOE.Size = New System.Drawing.Size(120, 20)
        Me.updFrictionCOE.TabIndex = 37
        Me.updFrictionCOE.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Coefficient of Friction (μ)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Force applied (N):"
        '
        'updForce
        '
        Me.updForce.Location = New System.Drawing.Point(139, 68)
        Me.updForce.Name = "updForce"
        Me.updForce.Size = New System.Drawing.Size(120, 20)
        Me.updForce.TabIndex = 39
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 101)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(247, 72)
        Me.lblOutput.TabIndex = 40
        '
        'frmForcesCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(398, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.updForce)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updFrictionCOE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.updMass)
        Me.Controls.Add(Me.cboGravity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForcesCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculator"
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updFrictionCOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updForce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents updMass As NumericUpDown
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents updFrictionCOE As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents updForce As NumericUpDown
    Friend WithEvents lblOutput As Label
End Class
