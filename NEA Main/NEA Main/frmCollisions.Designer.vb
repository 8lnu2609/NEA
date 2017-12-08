<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollisions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollisions))
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.grpRight = New System.Windows.Forms.GroupBox()
        Me.updVelocityRight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updMassRight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLeft = New System.Windows.Forms.GroupBox()
        Me.cboMaterialLeft = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updVelocityLeft = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updMassLeft = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.grpRight.SuspendLayout()
        CType(Me.updVelocityRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMassRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.updVelocityLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMassLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDisplay
        '
        Me.picDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(12, 12)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(1120, 711)
        Me.picDisplay.TabIndex = 27
        Me.picDisplay.TabStop = False
        '
        'tmrDraw
        '
        Me.tmrDraw.Interval = 1
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(119, 682)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 28
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpData
        '
        Me.grpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.Controls.Add(Me.cboMaterialLeft)
        Me.grpData.Controls.Add(Me.grpRight)
        Me.grpData.Controls.Add(Me.Label5)
        Me.grpData.Controls.Add(Me.grpLeft)
        Me.grpData.Controls.Add(Me.cmdClose)
        Me.grpData.Location = New System.Drawing.Point(1138, 12)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(200, 711)
        Me.grpData.TabIndex = 29
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'grpRight
        '
        Me.grpRight.Controls.Add(Me.updVelocityRight)
        Me.grpRight.Controls.Add(Me.Label3)
        Me.grpRight.Controls.Add(Me.updMassRight)
        Me.grpRight.Controls.Add(Me.Label4)
        Me.grpRight.Location = New System.Drawing.Point(6, 184)
        Me.grpRight.Name = "grpRight"
        Me.grpRight.Size = New System.Drawing.Size(188, 86)
        Me.grpRight.TabIndex = 32
        Me.grpRight.TabStop = False
        Me.grpRight.Text = "Right"
        '
        'updVelocityRight
        '
        Me.updVelocityRight.DecimalPlaces = 3
        Me.updVelocityRight.Location = New System.Drawing.Point(68, 51)
        Me.updVelocityRight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updVelocityRight.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updVelocityRight.Name = "updVelocityRight"
        Me.updVelocityRight.Size = New System.Drawing.Size(114, 20)
        Me.updVelocityRight.TabIndex = 3
        Me.updVelocityRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Velocity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ms^-1): "
        '
        'updMassRight
        '
        Me.updMassRight.DecimalPlaces = 3
        Me.updMassRight.Location = New System.Drawing.Point(68, 19)
        Me.updMassRight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updMassRight.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updMassRight.Name = "updMassRight"
        Me.updMassRight.Size = New System.Drawing.Size(114, 20)
        Me.updMassRight.TabIndex = 1
        Me.updMassRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mass" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(kg):"
        '
        'grpLeft
        '
        Me.grpLeft.Controls.Add(Me.updVelocityLeft)
        Me.grpLeft.Controls.Add(Me.Label2)
        Me.grpLeft.Controls.Add(Me.updMassLeft)
        Me.grpLeft.Controls.Add(Me.Label1)
        Me.grpLeft.Location = New System.Drawing.Point(6, 93)
        Me.grpLeft.Name = "grpLeft"
        Me.grpLeft.Size = New System.Drawing.Size(188, 85)
        Me.grpLeft.TabIndex = 31
        Me.grpLeft.TabStop = False
        Me.grpLeft.Text = "Left"
        '
        'cboMaterialLeft
        '
        Me.cboMaterialLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaterialLeft.FormattingEnabled = True
        Me.cboMaterialLeft.Location = New System.Drawing.Point(68, 24)
        Me.cboMaterialLeft.Name = "cboMaterialLeft"
        Me.cboMaterialLeft.Size = New System.Drawing.Size(114, 21)
        Me.cboMaterialLeft.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Material:"
        '
        'updVelocityLeft
        '
        Me.updVelocityLeft.DecimalPlaces = 3
        Me.updVelocityLeft.Location = New System.Drawing.Point(68, 51)
        Me.updVelocityLeft.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updVelocityLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updVelocityLeft.Name = "updVelocityLeft"
        Me.updVelocityLeft.Size = New System.Drawing.Size(114, 20)
        Me.updVelocityLeft.TabIndex = 3
        Me.updVelocityLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Velocity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ms^-1): "
        '
        'updMassLeft
        '
        Me.updMassLeft.DecimalPlaces = 3
        Me.updMassLeft.Location = New System.Drawing.Point(68, 19)
        Me.updMassLeft.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updMassLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updMassLeft.Name = "updMassLeft"
        Me.updMassLeft.Size = New System.Drawing.Size(114, 20)
        Me.updMassLeft.TabIndex = 1
        Me.updMassLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mass" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(kg):"
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 0
        '
        'frmCollisions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1350, 728)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCollisions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collisions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpRight.ResumeLayout(False)
        Me.grpRight.PerformLayout()
        CType(Me.updVelocityRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMassRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        Me.grpLeft.PerformLayout()
        CType(Me.updVelocityLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMassLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents cmdClose As Button
    Friend WithEvents grpData As GroupBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents grpLeft As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpRight As GroupBox
    Friend WithEvents updVelocityRight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents updMassRight As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents updVelocityLeft As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents updMassLeft As NumericUpDown
    Friend WithEvents cboMaterialLeft As ComboBox
    Friend WithEvents Label5 As Label
End Class
