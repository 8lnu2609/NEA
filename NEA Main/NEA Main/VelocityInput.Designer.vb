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
        Me.HorzTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.VertTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpeedRadio = New System.Windows.Forms.RadioButton()
        Me.ComponetsRadio = New System.Windows.Forms.RadioButton()
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AngleTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.SpeedTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.MainPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputSelectGB.SuspendLayout()
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
        Me.InputSelectGB.Controls.Add(Me.AngleTextIn)
        Me.InputSelectGB.Controls.Add(Me.SpeedTextIn)
        Me.InputSelectGB.Controls.Add(Me.Label3)
        Me.InputSelectGB.Controls.Add(Me.Label4)
        Me.InputSelectGB.Controls.Add(Me.HorzTextIn)
        Me.InputSelectGB.Controls.Add(Me.VertTextIn)
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
        'HorzTextIn
        '
        Me.HorzTextIn.Location = New System.Drawing.Point(124, 125)
        Me.HorzTextIn.Name = "HorzTextIn"
        Me.HorzTextIn.Size = New System.Drawing.Size(76, 20)
        Me.HorzTextIn.TabIndex = 6
        '
        'VertTextIn
        '
        Me.VertTextIn.Location = New System.Drawing.Point(124, 94)
        Me.VertTextIn.Name = "VertTextIn"
        Me.VertTextIn.Size = New System.Drawing.Size(76, 20)
        Me.VertTextIn.TabIndex = 5
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
        Me.DrawTimer.Interval = 1
        '
        'AngleTextIn
        '
        Me.AngleTextIn.Location = New System.Drawing.Point(124, 185)
        Me.AngleTextIn.Name = "AngleTextIn"
        Me.AngleTextIn.Size = New System.Drawing.Size(76, 20)
        Me.AngleTextIn.TabIndex = 10
        '
        'SpeedTextIn
        '
        Me.SpeedTextIn.Location = New System.Drawing.Point(124, 155)
        Me.SpeedTextIn.Name = "SpeedTextIn"
        Me.SpeedTextIn.Size = New System.Drawing.Size(76, 20)
        Me.SpeedTextIn.TabIndex = 9
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPicBox As PictureBox
    Friend WithEvents InputSelectGB As GroupBox
    Friend WithEvents SpeedRadio As RadioButton
    Friend WithEvents ComponetsRadio As RadioButton
    Friend WithEvents DrawTimer As Timer
    Friend WithEvents HorzTextIn As MaskedTextBox
    Friend WithEvents VertTextIn As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AngleTextIn As MaskedTextBox
    Friend WithEvents SpeedTextIn As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
