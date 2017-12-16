<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMomentumCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMomentumCal))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpLeft = New System.Windows.Forms.GroupBox()
        Me.txtVelocityLeftInital = New System.Windows.Forms.TextBox()
        Me.txtMassLeft = New System.Windows.Forms.TextBox()
        Me.grpRight = New System.Windows.Forms.GroupBox()
        Me.txtVelocityRightInital = New System.Windows.Forms.TextBox()
        Me.txtMassRight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updRestitution = New System.Windows.Forms.NumericUpDown()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVelocityLeftFinal = New System.Windows.Forms.TextBox()
        Me.txtVelocityRightFinal = New System.Windows.Forms.TextBox()
        Me.cmdRightInitalDirection = New System.Windows.Forms.Button()
        Me.cmdLeftInitalDirection = New System.Windows.Forms.Button()
        Me.picLeftFinalDirection = New System.Windows.Forms.PictureBox()
        Me.picRightFinalDirection = New System.Windows.Forms.PictureBox()
        Me.grpLeft.SuspendLayout()
        Me.grpRight.SuspendLayout()
        CType(Me.updRestitution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftFinalDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightFinalDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(272, 223)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpLeft
        '
        Me.grpLeft.Controls.Add(Me.txtVelocityLeftInital)
        Me.grpLeft.Controls.Add(Me.txtMassLeft)
        Me.grpLeft.Location = New System.Drawing.Point(90, 81)
        Me.grpLeft.Name = "grpLeft"
        Me.grpLeft.Size = New System.Drawing.Size(112, 73)
        Me.grpLeft.TabIndex = 1
        Me.grpLeft.TabStop = False
        Me.grpLeft.Text = "Left Particle"
        '
        'txtVelocityLeftInital
        '
        Me.txtVelocityLeftInital.Location = New System.Drawing.Point(6, 45)
        Me.txtVelocityLeftInital.Name = "txtVelocityLeftInital"
        Me.txtVelocityLeftInital.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityLeftInital.TabIndex = 3
        Me.txtVelocityLeftInital.Tag = "Left Inital Velocity"
        '
        'txtMassLeft
        '
        Me.txtMassLeft.Location = New System.Drawing.Point(6, 19)
        Me.txtMassLeft.Name = "txtMassLeft"
        Me.txtMassLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtMassLeft.TabIndex = 2
        Me.txtMassLeft.Tag = "Left Mass"
        '
        'grpRight
        '
        Me.grpRight.Controls.Add(Me.txtVelocityRightInital)
        Me.grpRight.Controls.Add(Me.txtMassRight)
        Me.grpRight.Location = New System.Drawing.Point(237, 81)
        Me.grpRight.Name = "grpRight"
        Me.grpRight.Size = New System.Drawing.Size(112, 73)
        Me.grpRight.TabIndex = 2
        Me.grpRight.TabStop = False
        Me.grpRight.Text = "Right Particle"
        '
        'txtVelocityRightInital
        '
        Me.txtVelocityRightInital.Location = New System.Drawing.Point(6, 45)
        Me.txtVelocityRightInital.Name = "txtVelocityRightInital"
        Me.txtVelocityRightInital.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityRightInital.TabIndex = 5
        Me.txtVelocityRightInital.Tag = "Right Inital Velocity"
        '
        'txtMassRight
        '
        Me.txtMassRight.Location = New System.Drawing.Point(6, 19)
        Me.txtMassRight.Name = "txtMassRight"
        Me.txtMassRight.Size = New System.Drawing.Size(100, 20)
        Me.txtMassRight.TabIndex = 4
        Me.txtMassRight.Tag = "Right Mass"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 26)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Coefficent of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "restitution: "
        '
        'updRestitution
        '
        Me.updRestitution.DecimalPlaces = 4
        Me.updRestitution.Enabled = False
        Me.updRestitution.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.updRestitution.Location = New System.Drawing.Point(267, 7)
        Me.updRestitution.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updRestitution.Name = "updRestitution"
        Me.updRestitution.Size = New System.Drawing.Size(82, 20)
        Me.updRestitution.TabIndex = 1
        Me.updRestitution.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cboMaterial
        '
        Me.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Location = New System.Drawing.Point(74, 6)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(114, 21)
        Me.cboMaterial.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Material:"
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Mass:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Inital Velocity:"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCalculate.Location = New System.Drawing.Point(191, 223)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 6
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Final Velocity:"
        '
        'txtVelocityLeftFinal
        '
        Me.txtVelocityLeftFinal.Enabled = False
        Me.txtVelocityLeftFinal.Location = New System.Drawing.Point(96, 160)
        Me.txtVelocityLeftFinal.Name = "txtVelocityLeftFinal"
        Me.txtVelocityLeftFinal.ReadOnly = True
        Me.txtVelocityLeftFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityLeftFinal.TabIndex = 4
        Me.txtVelocityLeftFinal.Tag = "Left Final Velocity"
        '
        'txtVelocityRightFinal
        '
        Me.txtVelocityRightFinal.Enabled = False
        Me.txtVelocityRightFinal.Location = New System.Drawing.Point(243, 160)
        Me.txtVelocityRightFinal.Name = "txtVelocityRightFinal"
        Me.txtVelocityRightFinal.ReadOnly = True
        Me.txtVelocityRightFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityRightFinal.TabIndex = 6
        Me.txtVelocityRightFinal.Tag = "Right Final Velocity"
        '
        'cmdRightInitalDirection
        '
        Me.cmdRightInitalDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRightInitalDirection.Location = New System.Drawing.Point(243, 52)
        Me.cmdRightInitalDirection.Name = "cmdRightInitalDirection"
        Me.cmdRightInitalDirection.Size = New System.Drawing.Size(100, 23)
        Me.cmdRightInitalDirection.TabIndex = 42
        Me.cmdRightInitalDirection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRightInitalDirection.UseVisualStyleBackColor = True
        '
        'cmdLeftInitalDirection
        '
        Me.cmdLeftInitalDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdLeftInitalDirection.Location = New System.Drawing.Point(96, 52)
        Me.cmdLeftInitalDirection.Name = "cmdLeftInitalDirection"
        Me.cmdLeftInitalDirection.Size = New System.Drawing.Size(100, 23)
        Me.cmdLeftInitalDirection.TabIndex = 41
        Me.cmdLeftInitalDirection.UseVisualStyleBackColor = True
        '
        'picLeftFinalDirection
        '
        Me.picLeftFinalDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLeftFinalDirection.Location = New System.Drawing.Point(96, 186)
        Me.picLeftFinalDirection.Name = "picLeftFinalDirection"
        Me.picLeftFinalDirection.Size = New System.Drawing.Size(100, 23)
        Me.picLeftFinalDirection.TabIndex = 43
        Me.picLeftFinalDirection.TabStop = False
        '
        'picRightFinalDirection
        '
        Me.picRightFinalDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRightFinalDirection.Location = New System.Drawing.Point(243, 186)
        Me.picRightFinalDirection.Name = "picRightFinalDirection"
        Me.picRightFinalDirection.Size = New System.Drawing.Size(100, 23)
        Me.picRightFinalDirection.TabIndex = 44
        Me.picRightFinalDirection.TabStop = False
        '
        'frmMomentumCal
        '
        Me.AcceptButton = Me.cmdCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(359, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.picRightFinalDirection)
        Me.Controls.Add(Me.picLeftFinalDirection)
        Me.Controls.Add(Me.cmdRightInitalDirection)
        Me.Controls.Add(Me.cmdLeftInitalDirection)
        Me.Controls.Add(Me.txtVelocityRightFinal)
        Me.Controls.Add(Me.txtVelocityLeftFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.updRestitution)
        Me.Controls.Add(Me.cboMaterial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpRight)
        Me.Controls.Add(Me.grpLeft)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMomentumCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculator"
        Me.grpLeft.ResumeLayout(False)
        Me.grpLeft.PerformLayout()
        Me.grpRight.ResumeLayout(False)
        Me.grpRight.PerformLayout()
        CType(Me.updRestitution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftFinalDirection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightFinalDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents grpLeft As GroupBox
    Friend WithEvents txtMassLeft As TextBox
    Friend WithEvents txtVelocityLeftInital As TextBox
    Friend WithEvents grpRight As GroupBox
    Friend WithEvents txtVelocityRightInital As TextBox
    Friend WithEvents txtMassRight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents updRestitution As NumericUpDown
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents txtVelocityLeftFinal As TextBox
    Friend WithEvents txtVelocityRightFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdLeftInitalDirection As Button
    Friend WithEvents cmdRightInitalDirection As Button
    Friend WithEvents picLeftFinalDirection As PictureBox
    Friend WithEvents picRightFinalDirection As PictureBox
End Class
