﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grpBoxData = New System.Windows.Forms.GroupBox()
        Me.updDistance = New System.Windows.Forms.NumericUpDown()
        Me.lblDistanceFromTuring = New System.Windows.Forms.Label()
        Me.updMass = New System.Windows.Forms.NumericUpDown()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.clbBoxes = New System.Windows.Forms.CheckedListBox()
        Me.updLength = New System.Windows.Forms.NumericUpDown()
        Me.lblSeeSawLength = New System.Windows.Forms.Label()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxData.SuspendLayout()
        CType(Me.updDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updLength, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grpBoxData
        '
        Me.grpBoxData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.grpBoxData.Controls.Add(Me.updDistance)
        Me.grpBoxData.Controls.Add(Me.lblDistanceFromTuring)
        Me.grpBoxData.Controls.Add(Me.updMass)
        Me.grpBoxData.Controls.Add(Me.lblMass)
        Me.grpBoxData.Controls.Add(Me.clbBoxes)
        Me.grpBoxData.Location = New System.Drawing.Point(1692, 9)
        Me.grpBoxData.Name = "grpBoxData"
        Me.grpBoxData.Size = New System.Drawing.Size(204, 253)
        Me.grpBoxData.TabIndex = 18
        Me.grpBoxData.TabStop = False
        Me.grpBoxData.Text = "Boxes"
        '
        'updDistance
        '
        Me.updDistance.DecimalPlaces = 3
        Me.updDistance.Location = New System.Drawing.Point(128, 164)
        Me.updDistance.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updDistance.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.updDistance.Name = "updDistance"
        Me.updDistance.Size = New System.Drawing.Size(70, 20)
        Me.updDistance.TabIndex = 23
        Me.updDistance.Visible = False
        '
        'lblDistanceFromTuring
        '
        Me.lblDistanceFromTuring.AutoSize = True
        Me.lblDistanceFromTuring.Location = New System.Drawing.Point(6, 166)
        Me.lblDistanceFromTuring.Name = "lblDistanceFromTuring"
        Me.lblDistanceFromTuring.Size = New System.Drawing.Size(116, 13)
        Me.lblDistanceFromTuring.TabIndex = 19
        Me.lblDistanceFromTuring.Text = "Distance from balance:"
        Me.lblDistanceFromTuring.Visible = False
        '
        'updMass
        '
        Me.updMass.DecimalPlaces = 3
        Me.updMass.Location = New System.Drawing.Point(95, 120)
        Me.updMass.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updMass.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.updMass.Name = "updMass"
        Me.updMass.Size = New System.Drawing.Size(103, 20)
        Me.updMass.TabIndex = 19
        Me.updMass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Location = New System.Drawing.Point(6, 127)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(38, 13)
        Me.lblMass.TabIndex = 22
        Me.lblMass.Text = "Mass: "
        '
        'clbBoxes
        '
        Me.clbBoxes.FormattingEnabled = True
        Me.clbBoxes.Items.AddRange(New Object() {"Red", "Blue", "Green", "Orange", "Violet"})
        Me.clbBoxes.Location = New System.Drawing.Point(6, 19)
        Me.clbBoxes.Name = "clbBoxes"
        Me.clbBoxes.Size = New System.Drawing.Size(120, 79)
        Me.clbBoxes.TabIndex = 21
        '
        'updLength
        '
        Me.updLength.Location = New System.Drawing.Point(1812, 295)
        Me.updLength.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updLength.Name = "updLength"
        Me.updLength.Size = New System.Drawing.Size(84, 20)
        Me.updLength.TabIndex = 19
        Me.updLength.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblSeeSawLength
        '
        Me.lblSeeSawLength.AutoSize = True
        Me.lblSeeSawLength.Location = New System.Drawing.Point(1698, 297)
        Me.lblSeeSawLength.Name = "lblSeeSawLength"
        Me.lblSeeSawLength.Size = New System.Drawing.Size(94, 13)
        Me.lblSeeSawLength.TabIndex = 20
        Me.lblSeeSawLength.Text = "Length of see saw"
        '
        'frmTurningPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.lblSeeSawLength)
        Me.Controls.Add(Me.updLength)
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
        Me.grpBoxData.PerformLayout()
        CType(Me.updDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents cmdClose As Button
    Friend WithEvents grpBoxData As GroupBox
    Friend WithEvents clbBoxes As CheckedListBox
    Friend WithEvents lblMass As Label
    Friend WithEvents updMass As NumericUpDown
    Friend WithEvents lblDistanceFromTuring As Label
    Friend WithEvents updDistance As NumericUpDown
    Friend WithEvents updLength As NumericUpDown
    Friend WithEvents lblSeeSawLength As Label
End Class