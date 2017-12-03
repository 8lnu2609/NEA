<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreefallCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFreefallCal))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updHeight = New System.Windows.Forms.NumericUpDown()
        Me.updMass = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updVelocity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDragCOE = New System.Windows.Forms.ComboBox()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(321, 142)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(275, 12)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(121, 21)
        Me.cboGravity.TabIndex = 1
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Height (m):"
        '
        'updHeight
        '
        Me.updHeight.Location = New System.Drawing.Point(117, 12)
        Me.updHeight.Name = "updHeight"
        Me.updHeight.Size = New System.Drawing.Size(120, 20)
        Me.updHeight.TabIndex = 3
        '
        'updMass
        '
        Me.updMass.Location = New System.Drawing.Point(117, 38)
        Me.updMass.Name = "updMass"
        Me.updMass.Size = New System.Drawing.Size(120, 20)
        Me.updMass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mass (kg):"
        '
        'updVelocity
        '
        Me.updVelocity.Location = New System.Drawing.Point(117, 99)
        Me.updVelocity.Name = "updVelocity"
        Me.updVelocity.Size = New System.Drawing.Size(120, 20)
        Me.updVelocity.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Velocity (ms^-1):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Coefficent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of drag:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboDragCOE
        '
        Me.cboDragCOE.FormattingEnabled = True
        Me.cboDragCOE.Location = New System.Drawing.Point(116, 69)
        Me.cboDragCOE.Name = "cboDragCOE"
        Me.cboDragCOE.Size = New System.Drawing.Size(121, 21)
        Me.cboDragCOE.TabIndex = 10
        '
        'frmFreefallCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(408, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDragCOE)
        Me.Controls.Add(Me.updVelocity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updMass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updHeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGravity)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFreefallCal"
        Me.Text = "Calculator"
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents updHeight As NumericUpDown
    Friend WithEvents updMass As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents updVelocity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDragCOE As ComboBox
End Class
