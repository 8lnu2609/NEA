<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberInput
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
        Me.updNumber = New System.Windows.Forms.NumericUpDown()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        CType(Me.updNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updNumber
        '
        Me.updNumber.DecimalPlaces = 3
        Me.updNumber.Location = New System.Drawing.Point(5, 39)
        Me.updNumber.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updNumber.Name = "updNumber"
        Me.updNumber.Size = New System.Drawing.Size(92, 20)
        Me.updNumber.TabIndex = 0
        Me.updNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(216, 39)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(66, 20)
        Me.cmdEnter.TabIndex = 1
        Me.cmdEnter.Text = "Enter"
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(0, 13)
        Me.lblPrompt.TabIndex = 2
        '
        'NumberInput
        '
        Me.AcceptButton = Me.cmdEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 65)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.cmdEnter)
        Me.Controls.Add(Me.updNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NumberInput"
        CType(Me.updNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updNumber As NumericUpDown
    Friend WithEvents cmdEnter As Button
    Friend WithEvents lblPrompt As Label
End Class
