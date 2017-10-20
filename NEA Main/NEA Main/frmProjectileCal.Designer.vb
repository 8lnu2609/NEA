<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProjectileCal
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDisplacementY_In = New System.Windows.Forms.TextBox()
        Me.txtInitalVelocityY_In = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccelerationY_In = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFinalVeloctityY_In = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTimeY_In = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAccelerationX_In = New System.Windows.Forms.TextBox()
        Me.txtFinalVelocityX_In = New System.Windows.Forms.TextBox()
        Me.txtInitalVelocityX_In = New System.Windows.Forms.TextBox()
        Me.txtDisplacementX_In = New System.Windows.Forms.TextBox()
        Me.grbComponentsY = New System.Windows.Forms.GroupBox()
        Me.grbComponentsX = New System.Windows.Forms.GroupBox()
        Me.txtTimeX_In = New System.Windows.Forms.TextBox()
        Me.cmdSolve = New System.Windows.Forms.Button()
        Me.grbComponentsY.SuspendLayout()
        Me.grbComponentsX.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(288, 170)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Displacement, s (m)"
        '
        'txtDisplacementY_In
        '
        Me.txtDisplacementY_In.Location = New System.Drawing.Point(6, 19)
        Me.txtDisplacementY_In.Name = "txtDisplacementY_In"
        Me.txtDisplacementY_In.Size = New System.Drawing.Size(100, 20)
        Me.txtDisplacementY_In.TabIndex = 1
        Me.txtDisplacementY_In.Tag = "Displacement"
        '
        'txtInitalVelocityY_In
        '
        Me.txtInitalVelocityY_In.Location = New System.Drawing.Point(6, 45)
        Me.txtInitalVelocityY_In.Name = "txtInitalVelocityY_In"
        Me.txtInitalVelocityY_In.Size = New System.Drawing.Size(100, 20)
        Me.txtInitalVelocityY_In.TabIndex = 2
        Me.txtInitalVelocityY_In.Tag = "Inital Velocity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inital velocity, u (ms^-1)"
        '
        'txtAccelerationY_In
        '
        Me.txtAccelerationY_In.Location = New System.Drawing.Point(6, 97)
        Me.txtAccelerationY_In.Name = "txtAccelerationY_In"
        Me.txtAccelerationY_In.Size = New System.Drawing.Size(100, 20)
        Me.txtAccelerationY_In.TabIndex = 4
        Me.txtAccelerationY_In.Tag = "Acceleration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Acceleration, a (ms^-2)"
        '
        'txtFinalVeloctityY_In
        '
        Me.txtFinalVeloctityY_In.Location = New System.Drawing.Point(6, 71)
        Me.txtFinalVeloctityY_In.Name = "txtFinalVeloctityY_In"
        Me.txtFinalVeloctityY_In.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalVeloctityY_In.TabIndex = 3
        Me.txtFinalVeloctityY_In.Tag = "Final Velocity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Final velocity, v (ms^-1)"
        '
        'txtTimeY_In
        '
        Me.txtTimeY_In.Location = New System.Drawing.Point(6, 123)
        Me.txtTimeY_In.Name = "txtTimeY_In"
        Me.txtTimeY_In.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeY_In.TabIndex = 5
        Me.txtTimeY_In.Tag = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Time, t (s)"
        '
        'txtAccelerationX_In
        '
        Me.txtAccelerationX_In.Location = New System.Drawing.Point(6, 97)
        Me.txtAccelerationX_In.Name = "txtAccelerationX_In"
        Me.txtAccelerationX_In.Size = New System.Drawing.Size(100, 20)
        Me.txtAccelerationX_In.TabIndex = 9
        Me.txtAccelerationX_In.Tag = "Acceleration"
        '
        'txtFinalVelocityX_In
        '
        Me.txtFinalVelocityX_In.Location = New System.Drawing.Point(6, 71)
        Me.txtFinalVelocityX_In.Name = "txtFinalVelocityX_In"
        Me.txtFinalVelocityX_In.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalVelocityX_In.TabIndex = 8
        Me.txtFinalVelocityX_In.Tag = "Final Velocity"
        '
        'txtInitalVelocityX_In
        '
        Me.txtInitalVelocityX_In.Location = New System.Drawing.Point(6, 45)
        Me.txtInitalVelocityX_In.Name = "txtInitalVelocityX_In"
        Me.txtInitalVelocityX_In.Size = New System.Drawing.Size(100, 20)
        Me.txtInitalVelocityX_In.TabIndex = 7
        Me.txtInitalVelocityX_In.Tag = "Inital Velocity"
        '
        'txtDisplacementX_In
        '
        Me.txtDisplacementX_In.Location = New System.Drawing.Point(6, 19)
        Me.txtDisplacementX_In.Name = "txtDisplacementX_In"
        Me.txtDisplacementX_In.Size = New System.Drawing.Size(100, 20)
        Me.txtDisplacementX_In.TabIndex = 6
        Me.txtDisplacementX_In.Tag = "Displacement"
        '
        'grbComponentsY
        '
        Me.grbComponentsY.Controls.Add(Me.txtDisplacementY_In)
        Me.grbComponentsY.Controls.Add(Me.txtInitalVelocityY_In)
        Me.grbComponentsY.Controls.Add(Me.txtFinalVeloctityY_In)
        Me.grbComponentsY.Controls.Add(Me.txtTimeY_In)
        Me.grbComponentsY.Controls.Add(Me.txtAccelerationY_In)
        Me.grbComponentsY.Location = New System.Drawing.Point(133, 5)
        Me.grbComponentsY.Name = "grbComponentsY"
        Me.grbComponentsY.Size = New System.Drawing.Size(112, 152)
        Me.grbComponentsY.TabIndex = 17
        Me.grbComponentsY.TabStop = False
        Me.grbComponentsY.Text = "Vertical"
        '
        'grbComponentsX
        '
        Me.grbComponentsX.Controls.Add(Me.txtTimeX_In)
        Me.grbComponentsX.Controls.Add(Me.txtDisplacementX_In)
        Me.grbComponentsX.Controls.Add(Me.txtInitalVelocityX_In)
        Me.grbComponentsX.Controls.Add(Me.txtFinalVelocityX_In)
        Me.grbComponentsX.Controls.Add(Me.txtAccelerationX_In)
        Me.grbComponentsX.Location = New System.Drawing.Point(251, 5)
        Me.grbComponentsX.Name = "grbComponentsX"
        Me.grbComponentsX.Size = New System.Drawing.Size(112, 152)
        Me.grbComponentsX.TabIndex = 18
        Me.grbComponentsX.TabStop = False
        Me.grbComponentsX.Text = "Horizontal"
        '
        'txtTimeX_In
        '
        Me.txtTimeX_In.Location = New System.Drawing.Point(6, 123)
        Me.txtTimeX_In.Name = "txtTimeX_In"
        Me.txtTimeX_In.ReadOnly = True
        Me.txtTimeX_In.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeX_In.TabIndex = 10
        Me.txtTimeX_In.Tag = "Time"
        '
        'cmdSolve
        '
        Me.cmdSolve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSolve.Location = New System.Drawing.Point(207, 170)
        Me.cmdSolve.Name = "cmdSolve"
        Me.cmdSolve.Size = New System.Drawing.Size(75, 23)
        Me.cmdSolve.TabIndex = 9
        Me.cmdSolve.Text = "Solve"
        Me.cmdSolve.UseVisualStyleBackColor = True
        '
        'frmProjectileCal
        '
        Me.AcceptButton = Me.cmdSolve
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(375, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSolve)
        Me.Controls.Add(Me.grbComponentsX)
        Me.Controls.Add(Me.grbComponentsY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjectileCal"
        Me.Text = "Calculator"
        Me.grbComponentsY.ResumeLayout(False)
        Me.grbComponentsY.PerformLayout()
        Me.grbComponentsX.ResumeLayout(False)
        Me.grbComponentsX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDisplacementY_In As TextBox
    Friend WithEvents txtInitalVelocityY_In As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccelerationY_In As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFinalVeloctityY_In As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTimeY_In As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAccelerationX_In As TextBox
    Friend WithEvents txtFinalVelocityX_In As TextBox
    Friend WithEvents txtInitalVelocityX_In As TextBox
    Friend WithEvents txtDisplacementX_In As TextBox
    Friend WithEvents grbComponentsY As GroupBox
    Friend WithEvents grbComponentsX As GroupBox
    Friend WithEvents cmdSolve As Button
    Friend WithEvents txtTimeX_In As TextBox
End Class
