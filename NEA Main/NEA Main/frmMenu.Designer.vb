<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdProjectileSim = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdProjectileCal = New System.Windows.Forms.Button()
        Me.cmdForceCal = New System.Windows.Forms.Button()
        Me.cmdForceSim = New System.Windows.Forms.Button()
        Me.cmdTurningCal = New System.Windows.Forms.Button()
        Me.cmdTurningSim = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello and wlecome to the 'physics' simulator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select what area of mechanics you w" &
    "ould like " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to simulate or calculate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdProjectileSim
        '
        Me.cmdProjectileSim.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdProjectileSim.Location = New System.Drawing.Point(12, 87)
        Me.cmdProjectileSim.Name = "cmdProjectileSim"
        Me.cmdProjectileSim.Size = New System.Drawing.Size(75, 50)
        Me.cmdProjectileSim.TabIndex = 1
        Me.cmdProjectileSim.Text = "Projectile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Simulator"
        Me.cmdProjectileSim.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(209, 327)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdProjectileCal
        '
        Me.cmdProjectileCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdProjectileCal.Location = New System.Drawing.Point(12, 143)
        Me.cmdProjectileCal.Name = "cmdProjectileCal"
        Me.cmdProjectileCal.Size = New System.Drawing.Size(75, 50)
        Me.cmdProjectileCal.TabIndex = 2
        Me.cmdProjectileCal.Text = "Projectile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdProjectileCal.UseVisualStyleBackColor = True
        '
        'cmdForceCal
        '
        Me.cmdForceCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdForceCal.Location = New System.Drawing.Point(93, 143)
        Me.cmdForceCal.Name = "cmdForceCal"
        Me.cmdForceCal.Size = New System.Drawing.Size(75, 50)
        Me.cmdForceCal.TabIndex = 4
        Me.cmdForceCal.Text = "Force" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculator"
        Me.cmdForceCal.UseVisualStyleBackColor = True
        '
        'cmdForceSim
        '
        Me.cmdForceSim.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdForceSim.Location = New System.Drawing.Point(93, 87)
        Me.cmdForceSim.Name = "cmdForceSim"
        Me.cmdForceSim.Size = New System.Drawing.Size(75, 50)
        Me.cmdForceSim.TabIndex = 3
        Me.cmdForceSim.Text = "Force" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Simulator"
        Me.cmdForceSim.UseVisualStyleBackColor = True
        '
        'cmdTurningCal
        '
        Me.cmdTurningCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdTurningCal.Location = New System.Drawing.Point(174, 143)
        Me.cmdTurningCal.Name = "cmdTurningCal"
        Me.cmdTurningCal.Size = New System.Drawing.Size(75, 50)
        Me.cmdTurningCal.TabIndex = 22
        Me.cmdTurningCal.Text = "Turning Points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculator"
        Me.cmdTurningCal.UseVisualStyleBackColor = True
        '
        'cmdTurningSim
        '
        Me.cmdTurningSim.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdTurningSim.Location = New System.Drawing.Point(174, 87)
        Me.cmdTurningSim.Name = "cmdTurningSim"
        Me.cmdTurningSim.Size = New System.Drawing.Size(75, 50)
        Me.cmdTurningSim.TabIndex = 21
        Me.cmdTurningSim.Text = "Turning Points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Simulator"
        Me.cmdTurningSim.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdTurningCal)
        Me.Controls.Add(Me.cmdTurningSim)
        Me.Controls.Add(Me.cmdForceCal)
        Me.Controls.Add(Me.cmdForceSim)
        Me.Controls.Add(Me.cmdProjectileCal)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdProjectileSim)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdProjectileSim As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdProjectileCal As Button
    Friend WithEvents cmdForceCal As Button
    Friend WithEvents cmdForceSim As Button
    Friend WithEvents cmdTurningCal As Button
    Friend WithEvents cmdTurningSim As Button
End Class
