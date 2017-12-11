<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVelocityInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVelocityInput))
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.grbInputSelect = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.updAngle_In = New System.Windows.Forms.NumericUpDown()
        Me.updSpeed_In = New System.Windows.Forms.NumericUpDown()
        Me.updVelocityX_In = New System.Windows.Forms.NumericUpDown()
        Me.updVelocityY_In = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optSpeed = New System.Windows.Forms.RadioButton()
        Me.optComponents = New System.Windows.Forms.RadioButton()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbInputSelect.SuspendLayout()
        CType(Me.updAngle_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updSpeed_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updVelocityX_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updVelocityY_In, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDisplay
        '
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(12, 12)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(320, 320)
        Me.picDisplay.TabIndex = 0
        Me.picDisplay.TabStop = False
        '
        'grbInputSelect
        '
        Me.grbInputSelect.Controls.Add(Me.cmdClose)
        Me.grbInputSelect.Controls.Add(Me.updAngle_In)
        Me.grbInputSelect.Controls.Add(Me.updSpeed_In)
        Me.grbInputSelect.Controls.Add(Me.updVelocityX_In)
        Me.grbInputSelect.Controls.Add(Me.updVelocityY_In)
        Me.grbInputSelect.Controls.Add(Me.Label3)
        Me.grbInputSelect.Controls.Add(Me.Label4)
        Me.grbInputSelect.Controls.Add(Me.Label2)
        Me.grbInputSelect.Controls.Add(Me.Label1)
        Me.grbInputSelect.Controls.Add(Me.optSpeed)
        Me.grbInputSelect.Controls.Add(Me.optComponents)
        Me.grbInputSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.grbInputSelect.Location = New System.Drawing.Point(338, 0)
        Me.grbInputSelect.Name = "grbInputSelect"
        Me.grbInputSelect.Size = New System.Drawing.Size(212, 344)
        Me.grbInputSelect.TabIndex = 1
        Me.grbInputSelect.TabStop = False
        Me.grbInputSelect.Text = "Input"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(131, 315)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'updAngle_In
        '
        Me.updAngle_In.DecimalPlaces = 3
        Me.updAngle_In.Enabled = False
        Me.updAngle_In.Location = New System.Drawing.Point(123, 186)
        Me.updAngle_In.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.updAngle_In.Name = "updAngle_In"
        Me.updAngle_In.Size = New System.Drawing.Size(83, 20)
        Me.updAngle_In.TabIndex = 12
        Me.updAngle_In.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'updSpeed_In
        '
        Me.updSpeed_In.DecimalPlaces = 3
        Me.updSpeed_In.Enabled = False
        Me.updSpeed_In.Location = New System.Drawing.Point(123, 155)
        Me.updSpeed_In.Maximum = New Decimal(New Integer() {141421356, 0, 0, 393216})
        Me.updSpeed_In.Name = "updSpeed_In"
        Me.updSpeed_In.Size = New System.Drawing.Size(83, 20)
        Me.updSpeed_In.TabIndex = 11
        Me.updSpeed_In.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'updVelocityX_In
        '
        Me.updVelocityX_In.DecimalPlaces = 3
        Me.updVelocityX_In.Location = New System.Drawing.Point(123, 126)
        Me.updVelocityX_In.Name = "updVelocityX_In"
        Me.updVelocityX_In.Size = New System.Drawing.Size(83, 20)
        Me.updVelocityX_In.TabIndex = 10
        Me.updVelocityX_In.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'updVelocityY_In
        '
        Me.updVelocityY_In.DecimalPlaces = 3
        Me.updVelocityY_In.Location = New System.Drawing.Point(123, 95)
        Me.updVelocityY_In.Name = "updVelocityY_In"
        Me.updVelocityY_In.Size = New System.Drawing.Size(83, 20)
        Me.updVelocityY_In.TabIndex = 9
        Me.updVelocityY_In.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Angle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Speed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Horizontal Component"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vertical Component"
        '
        'optSpeed
        '
        Me.optSpeed.AutoSize = True
        Me.optSpeed.Location = New System.Drawing.Point(6, 55)
        Me.optSpeed.Name = "optSpeed"
        Me.optSpeed.Size = New System.Drawing.Size(106, 17)
        Me.optSpeed.TabIndex = 3
        Me.optSpeed.Text = "Speed and angle"
        Me.optSpeed.UseVisualStyleBackColor = True
        '
        'optComponents
        '
        Me.optComponents.AutoSize = True
        Me.optComponents.Checked = True
        Me.optComponents.Location = New System.Drawing.Point(6, 19)
        Me.optComponents.Name = "optComponents"
        Me.optComponents.Size = New System.Drawing.Size(124, 30)
        Me.optComponents.TabIndex = 2
        Me.optComponents.TabStop = True
        Me.optComponents.Text = "X and Y components" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of velocity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.optComponents.UseVisualStyleBackColor = True
        '
        'tmrDraw
        '
        Me.tmrDraw.Enabled = True
        Me.tmrDraw.Interval = 1
        '
        'frmVelocityInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(550, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbInputSelect)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVelocityInput"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Velocity Input"
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbInputSelect.ResumeLayout(False)
        Me.grbInputSelect.PerformLayout()
        CType(Me.updAngle_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updSpeed_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updVelocityX_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updVelocityY_In, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents grbInputSelect As GroupBox
    Friend WithEvents optSpeed As RadioButton
    Friend WithEvents optComponents As RadioButton
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents updAngle_In As NumericUpDown
    Friend WithEvents updSpeed_In As NumericUpDown
    Friend WithEvents updVelocityX_In As NumericUpDown
    Friend WithEvents updVelocityY_In As NumericUpDown
    Friend WithEvents cmdClose As Button
End Class
