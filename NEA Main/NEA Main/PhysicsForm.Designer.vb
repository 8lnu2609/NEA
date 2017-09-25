<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class physicsForm
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
        Me.startButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.dropTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HorzTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.VertTextIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataGroupBox.SuspendLayout()
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
        Me.picBoxMain.Size = New System.Drawing.Size(1100, 700)
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
        Me.dataGroupBox.Controls.Add(Me.startButton)
        Me.dataGroupBox.Controls.Add(Me.closeButton)
        Me.dataGroupBox.Location = New System.Drawing.Point(1117, 12)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(205, 699)
        Me.dataGroupBox.TabIndex = 14
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data"
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(123, 641)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 16
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(124, 670)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 15
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'HorzTextIn
        '
        Me.HorzTextIn.Location = New System.Drawing.Point(684, 365)
        Me.HorzTextIn.Name = "HorzTextIn"
        Me.HorzTextIn.Size = New System.Drawing.Size(76, 20)
        Me.HorzTextIn.TabIndex = 18
        '
        'VertTextIn
        '
        Me.VertTextIn.Location = New System.Drawing.Point(684, 334)
        Me.VertTextIn.Name = "VertTextIn"
        Me.VertTextIn.Size = New System.Drawing.Size(76, 20)
        Me.VertTextIn.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(566, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Horizontal Component"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Vertical Component"
        '
        'physicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(1327, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.HorzTextIn)
        Me.Controls.Add(Me.VertTextIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.picBoxMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "physicsForm"
        Me.ShowIcon = False
        Me.Text = "Physics"
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBoxMain As System.Windows.Forms.PictureBox
    Friend WithEvents drawTimer As System.Windows.Forms.Timer
    Friend WithEvents dataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents dropTimer As System.Windows.Forms.Timer
    Friend WithEvents closeButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents HorzTextIn As MaskedTextBox
    Friend WithEvents VertTextIn As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
