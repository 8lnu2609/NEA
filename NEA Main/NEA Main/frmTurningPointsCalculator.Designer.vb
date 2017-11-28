<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurningPointsCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurningPointsCalculator))
        Me.cboGravity = New System.Windows.Forms.ComboBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstObjects = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGravity
        '
        Me.cboGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGravity.FormattingEnabled = True
        Me.cboGravity.Location = New System.Drawing.Point(197, 12)
        Me.cboGravity.Name = "cboGravity"
        Me.cboGravity.Size = New System.Drawing.Size(121, 21)
        Me.cboGravity.TabIndex = 0
        '
        'lstObjects
        '
        Me.lstObjects.FormattingEnabled = True
        Me.lstObjects.Location = New System.Drawing.Point(12, 12)
        Me.lstObjects.Name = "lstObjects"
        Me.lstObjects.Size = New System.Drawing.Size(120, 95)
        Me.lstObjects.TabIndex = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Location = New System.Drawing.Point(243, 39)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "Add object"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(243, 143)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Enabled = False
        Me.cmdRemove.Location = New System.Drawing.Point(138, 39)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(243, 81)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 55)
        Me.cmdCalculate.TabIndex = 6
        Me.cmdCalculate.Text = "Calculate Moment"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'frmTurningPointsCalculator
        '
        Me.AcceptButton = Me.cmdAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(330, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstObjects)
        Me.Controls.Add(Me.cboGravity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTurningPointsCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Turning Points Calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboGravity As ComboBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents lstObjects As ListBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdCalculate As Button
End Class
