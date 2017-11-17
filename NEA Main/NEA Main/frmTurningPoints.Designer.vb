<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurningPoints
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
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdAddBox = New System.Windows.Forms.Button()
        Me.grpBoxData = New System.Windows.Forms.GroupBox()
        Me.clbBoxes = New System.Windows.Forms.CheckedListBox()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxData.SuspendLayout()
        Me.SuspendLayout()
        '
        'picDisplay
        '
        Me.picDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(12, 9)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(1674, 1024)
        Me.picDisplay.TabIndex = 1
        Me.picDisplay.TabStop = False
        '
        'tmrDraw
        '
        Me.tmrDraw.Interval = 1
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(1821, 1010)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdAddBox
        '
        Me.cmdAddBox.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAddBox.Location = New System.Drawing.Point(123, 224)
        Me.cmdAddBox.Name = "cmdAddBox"
        Me.cmdAddBox.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddBox.TabIndex = 17
        Me.cmdAddBox.Text = "Add Box"
        Me.cmdAddBox.UseVisualStyleBackColor = True
        '
        'grpBoxData
        '
        Me.grpBoxData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.grpBoxData.Controls.Add(Me.clbBoxes)
        Me.grpBoxData.Controls.Add(Me.cmdAddBox)
        Me.grpBoxData.Location = New System.Drawing.Point(1692, 9)
        Me.grpBoxData.Name = "grpBoxData"
        Me.grpBoxData.Size = New System.Drawing.Size(204, 253)
        Me.grpBoxData.TabIndex = 18
        Me.grpBoxData.TabStop = False
        Me.grpBoxData.Text = "Boxes"
        '
        'clbBoxes
        '
        Me.clbBoxes.FormattingEnabled = True
        Me.clbBoxes.Location = New System.Drawing.Point(6, 19)
        Me.clbBoxes.Name = "clbBoxes"
        Me.clbBoxes.Size = New System.Drawing.Size(120, 94)
        Me.clbBoxes.TabIndex = 19
        '
        'frmTurningPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAddBox
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.grpBoxData)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.picDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 658)
        Me.Name = "frmTurningPoints"
        Me.ShowIcon = False
        Me.Text = "Turning Points"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdAddBox As Button
    Friend WithEvents grpBoxData As GroupBox
    Friend WithEvents clbBoxes As CheckedListBox
End Class
