<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectileForm
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
        Me.picBoxMain = New System.Windows.Forms.PictureBox()
        Me.drawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dataGroupBox = New System.Windows.Forms.GroupBox()
        Me.MaxHeightLabel = New System.Windows.Forms.Label()
        Me.RangeLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ShowVelocity = New System.Windows.Forms.Button()
        Me.TimePannel = New System.Windows.Forms.Panel()
        Me.TimeTrackBar = New System.Windows.Forms.TrackBar()
        Me.StepByStepRadio = New System.Windows.Forms.RadioButton()
        Me.RealTimeRadio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AccelerationCombo = New System.Windows.Forms.ComboBox()
        Me.xVelIn = New System.Windows.Forms.MaskedTextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.yVelIn = New System.Windows.Forms.MaskedTextBox()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dropTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataGroupBox.SuspendLayout()
        Me.TimePannel.SuspendLayout()
        CType(Me.TimeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxMain
        '
        Me.picBoxMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxMain.BackColor = System.Drawing.Color.White
        Me.picBoxMain.Location = New System.Drawing.Point(12, 12)
        Me.picBoxMain.Name = "picBoxMain"
        Me.picBoxMain.Size = New System.Drawing.Size(1670, 1020)
        Me.picBoxMain.TabIndex = 0
        Me.picBoxMain.TabStop = False
        '
        'drawTimer
        '
        '
        'dataGroupBox
        '
        Me.dataGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.dataGroupBox.Controls.Add(Me.MaxHeightLabel)
        Me.dataGroupBox.Controls.Add(Me.RangeLabel)
        Me.dataGroupBox.Controls.Add(Me.TimeLabel)
        Me.dataGroupBox.Controls.Add(Me.ShowVelocity)
        Me.dataGroupBox.Controls.Add(Me.TimePannel)
        Me.dataGroupBox.Controls.Add(Me.Label3)
        Me.dataGroupBox.Controls.Add(Me.AccelerationCombo)
        Me.dataGroupBox.Controls.Add(Me.xVelIn)
        Me.dataGroupBox.Controls.Add(Me.startButton)
        Me.dataGroupBox.Controls.Add(Me.yVelIn)
        Me.dataGroupBox.Controls.Add(Me.closeButton)
        Me.dataGroupBox.Controls.Add(Me.Label2)
        Me.dataGroupBox.Controls.Add(Me.Label1)
        Me.dataGroupBox.Location = New System.Drawing.Point(1688, 12)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(205, 1021)
        Me.dataGroupBox.TabIndex = 14
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data"
        '
        'MaxHeightLabel
        '
        Me.MaxHeightLabel.AutoSize = True
        Me.MaxHeightLabel.Location = New System.Drawing.Point(6, 330)
        Me.MaxHeightLabel.Name = "MaxHeightLabel"
        Me.MaxHeightLabel.Size = New System.Drawing.Size(65, 13)
        Me.MaxHeightLabel.TabIndex = 25
        Me.MaxHeightLabel.Text = "Max height: "
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Location = New System.Drawing.Point(6, 300)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(45, 13)
        Me.RangeLabel.TabIndex = 24
        Me.RangeLabel.Text = "Range: "
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(6, 270)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(96, 13)
        Me.TimeLabel.TabIndex = 23
        Me.TimeLabel.Text = "Total time of flight: "
        '
        'ShowVelocity
        '
        Me.ShowVelocity.Location = New System.Drawing.Point(6, 19)
        Me.ShowVelocity.Name = "ShowVelocity"
        Me.ShowVelocity.Size = New System.Drawing.Size(99, 23)
        Me.ShowVelocity.TabIndex = 22
        Me.ShowVelocity.Text = "Enter Velocity"
        Me.ShowVelocity.UseVisualStyleBackColor = True
        '
        'TimePannel
        '
        Me.TimePannel.Controls.Add(Me.TimeTrackBar)
        Me.TimePannel.Controls.Add(Me.StepByStepRadio)
        Me.TimePannel.Controls.Add(Me.RealTimeRadio)
        Me.TimePannel.Location = New System.Drawing.Point(6, 162)
        Me.TimePannel.Name = "TimePannel"
        Me.TimePannel.Size = New System.Drawing.Size(189, 105)
        Me.TimePannel.TabIndex = 21
        '
        'TimeTrackBar
        '
        Me.TimeTrackBar.Location = New System.Drawing.Point(3, 49)
        Me.TimeTrackBar.Name = "TimeTrackBar"
        Me.TimeTrackBar.Size = New System.Drawing.Size(183, 45)
        Me.TimeTrackBar.TabIndex = 17
        Me.TimeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ToolTips.SetToolTip(Me.TimeTrackBar, "Time: 0")
        Me.TimeTrackBar.Visible = False
        '
        'StepByStepRadio
        '
        Me.StepByStepRadio.AutoSize = True
        Me.StepByStepRadio.Location = New System.Drawing.Point(9, 26)
        Me.StepByStepRadio.Name = "StepByStepRadio"
        Me.StepByStepRadio.Size = New System.Drawing.Size(105, 17)
        Me.StepByStepRadio.TabIndex = 16
        Me.StepByStepRadio.Text = "Run step by step"
        Me.StepByStepRadio.UseVisualStyleBackColor = True
        '
        'RealTimeRadio
        '
        Me.RealTimeRadio.AutoSize = True
        Me.RealTimeRadio.Checked = True
        Me.RealTimeRadio.Location = New System.Drawing.Point(9, 3)
        Me.RealTimeRadio.Name = "RealTimeRadio"
        Me.RealTimeRadio.Size = New System.Drawing.Size(98, 17)
        Me.RealTimeRadio.TabIndex = 15
        Me.RealTimeRadio.TabStop = True
        Me.RealTimeRadio.Text = "Run in real time"
        Me.RealTimeRadio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Acceleration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "due to gravity"
        '
        'AccelerationCombo
        '
        Me.AccelerationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccelerationCombo.FormattingEnabled = True
        Me.AccelerationCombo.Location = New System.Drawing.Point(84, 121)
        Me.AccelerationCombo.Name = "AccelerationCombo"
        Me.AccelerationCombo.Size = New System.Drawing.Size(114, 21)
        Me.AccelerationCombo.TabIndex = 19
        '
        'xVelIn
        '
        Me.xVelIn.Location = New System.Drawing.Point(124, 75)
        Me.xVelIn.Name = "xVelIn"
        Me.xVelIn.ReadOnly = True
        Me.xVelIn.Size = New System.Drawing.Size(76, 20)
        Me.xVelIn.TabIndex = 18
        '
        'startButton
        '
        Me.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.startButton.Location = New System.Drawing.Point(123, 963)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 16
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'yVelIn
        '
        Me.yVelIn.Location = New System.Drawing.Point(124, 44)
        Me.yVelIn.Name = "yVelIn"
        Me.yVelIn.ReadOnly = True
        Me.yVelIn.Size = New System.Drawing.Size(76, 20)
        Me.yVelIn.TabIndex = 17
        '
        'closeButton
        '
        Me.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(124, 992)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 15
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Horizontal Component"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Vertical Component"
        '
        'dropTimer
        '
        Me.dropTimer.Interval = 1
        '
        'ToolTips
        '
        Me.ToolTips.AutoPopDelay = 5000
        Me.ToolTips.InitialDelay = 1
        Me.ToolTips.ReshowDelay = 100
        '
        'ProjectileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.picBoxMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "ProjectileForm"
        Me.ShowIcon = False
        Me.Text = "Physics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataGroupBox.ResumeLayout(False)
        Me.dataGroupBox.PerformLayout()
        Me.TimePannel.ResumeLayout(False)
        Me.TimePannel.PerformLayout()
        CType(Me.TimeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBoxMain As System.Windows.Forms.PictureBox
    Friend WithEvents drawTimer As System.Windows.Forms.Timer
    Friend WithEvents dataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents dropTimer As System.Windows.Forms.Timer
    Friend WithEvents closeButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents xVelIn As MaskedTextBox
    Friend WithEvents yVelIn As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AccelerationCombo As ComboBox
    Friend WithEvents TimePannel As Panel
    Friend WithEvents StepByStepRadio As RadioButton
    Friend WithEvents RealTimeRadio As RadioButton
    Friend WithEvents TimeTrackBar As TrackBar
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents ShowVelocity As Button
    Friend WithEvents MaxHeightLabel As Label
    Friend WithEvents RangeLabel As Label
    Friend WithEvents TimeLabel As Label
End Class
