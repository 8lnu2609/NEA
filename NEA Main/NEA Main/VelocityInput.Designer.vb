<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VelocityInput
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
        Me.MainPicBox = New System.Windows.Forms.PictureBox()
        Me.InputSelectGB = New System.Windows.Forms.GroupBox()
        Me.AngleIn = New System.Windows.Forms.NumericUpDown()
        Me.SpeedIn = New System.Windows.Forms.NumericUpDown()
        Me.HorzIn = New System.Windows.Forms.NumericUpDown()
        Me.VertIn = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpeedRadio = New System.Windows.Forms.RadioButton()
        Me.ComponetsRadio = New System.Windows.Forms.RadioButton()
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MainPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputSelectGB.SuspendLayout()
        CType(Me.AngleIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorzIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VertIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPicBox
        '
        Me.MainPicBox.BackColor = System.Drawing.Color.White
        Me.MainPicBox.Location = New System.Drawing.Point(12, 12)
        Me.MainPicBox.Name = "MainPicBox"
        Me.MainPicBox.Size = New System.Drawing.Size(320, 320)
        Me.MainPicBox.TabIndex = 0
        Me.MainPicBox.TabStop = False
        '
        'InputSelectGB
        '
        Me.InputSelectGB.Controls.Add(Me.AngleIn)
        Me.InputSelectGB.Controls.Add(Me.SpeedIn)
        Me.InputSelectGB.Controls.Add(Me.HorzIn)
        Me.InputSelectGB.Controls.Add(Me.VertIn)
        Me.InputSelectGB.Controls.Add(Me.Label3)
        Me.InputSelectGB.Controls.Add(Me.Label4)
        Me.InputSelectGB.Controls.Add(Me.Label2)
        Me.InputSelectGB.Controls.Add(Me.Label1)
        Me.InputSelectGB.Controls.Add(Me.SpeedRadio)
        Me.InputSelectGB.Controls.Add(Me.ComponetsRadio)
        Me.InputSelectGB.Dock = System.Windows.Forms.DockStyle.Right
        Me.InputSelectGB.Location = New System.Drawing.Point(338, 0)
        Me.InputSelectGB.Name = "InputSelectGB"
        Me.InputSelectGB.Size = New System.Drawing.Size(212, 344)
        Me.InputSelectGB.TabIndex = 1
        Me.InputSelectGB.TabStop = False
        Me.InputSelectGB.Text = "Input"
        '
        'AngleIn
        '
        Me.AngleIn.DecimalPlaces = 3
        Me.AngleIn.Enabled = False
        Me.AngleIn.Location = New System.Drawing.Point(123, 186)
        Me.AngleIn.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.AngleIn.Name = "AngleIn"
        Me.AngleIn.Size = New System.Drawing.Size(83, 20)
        Me.AngleIn.TabIndex = 12
        Me.AngleIn.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'SpeedIn
        '
        Me.SpeedIn.DecimalPlaces = 3
        Me.SpeedIn.Enabled = False
        Me.SpeedIn.Location = New System.Drawing.Point(123, 155)
        Me.SpeedIn.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SpeedIn.Name = "SpeedIn"
        Me.SpeedIn.Size = New System.Drawing.Size(83, 20)
        Me.SpeedIn.TabIndex = 11
        Me.SpeedIn.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'HorzIn
        '
        Me.HorzIn.DecimalPlaces = 3
        Me.HorzIn.Location = New System.Drawing.Point(123, 126)
        Me.HorzIn.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HorzIn.Name = "HorzIn"
        Me.HorzIn.Size = New System.Drawing.Size(83, 20)
        Me.HorzIn.TabIndex = 10
        Me.HorzIn.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'VertIn
        '
        Me.VertIn.DecimalPlaces = 3
        Me.VertIn.Location = New System.Drawing.Point(123, 95)
        Me.VertIn.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.VertIn.Name = "VertIn"
        Me.VertIn.Size = New System.Drawing.Size(83, 20)
        Me.VertIn.TabIndex = 9
        Me.VertIn.Value = New Decimal(New Integer() {100, 0, 0, 0})
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
        'SpeedRadio
        '
        Me.SpeedRadio.AutoSize = True
        Me.SpeedRadio.Location = New System.Drawing.Point(6, 55)
        Me.SpeedRadio.Name = "SpeedRadio"
        Me.SpeedRadio.Size = New System.Drawing.Size(106, 17)
        Me.SpeedRadio.TabIndex = 3
        Me.SpeedRadio.Text = "Speed and angle"
        Me.SpeedRadio.UseVisualStyleBackColor = True
        '
        'ComponetsRadio
        '
        Me.ComponetsRadio.AutoSize = True
        Me.ComponetsRadio.Checked = True
        Me.ComponetsRadio.Location = New System.Drawing.Point(6, 19)
        Me.ComponetsRadio.Name = "ComponetsRadio"
        Me.ComponetsRadio.Size = New System.Drawing.Size(124, 30)
        Me.ComponetsRadio.TabIndex = 2
        Me.ComponetsRadio.TabStop = True
        Me.ComponetsRadio.Text = "X and Y components" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of velocity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ComponetsRadio.UseVisualStyleBackColor = True
        '
        'DrawTimer
        '
        Me.DrawTimer.Enabled = True
        Me.DrawTimer.Interval = 1
        '
        'VelocityInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 344)
        Me.Controls.Add(Me.InputSelectGB)
        Me.Controls.Add(Me.MainPicBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "VelocityInput"
        Me.Text = "Velocity Input"
        CType(Me.MainPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputSelectGB.ResumeLayout(False)
        Me.InputSelectGB.PerformLayout()
        CType(Me.AngleIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorzIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VertIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPicBox As PictureBox
    Friend WithEvents InputSelectGB As GroupBox
    Friend WithEvents SpeedRadio As RadioButton
    Friend WithEvents ComponetsRadio As RadioButton
    Friend WithEvents DrawTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AngleIn As NumericUpDown
    Friend WithEvents SpeedIn As NumericUpDown
    Friend WithEvents HorzIn As NumericUpDown
    Friend WithEvents VertIn As NumericUpDown
End Class
