Public Class frmCollisions
    Dim leftParticle As New Particle
    Dim rightParticle As New Particle
    Dim BOXHEIGHT, BOXWIDTH As Int16
    Const SHAPEWIDTH As Int32 = 40
    Dim COEofRestitution As Single = 1
    Dim MaterialDictionary As New Dictionary(Of String, Single) From {
        {"Brass", 0.3},
        {"Bronze", 0.52},
        {"Copper", 0.22},
        {"Cork", 0.6},
        {"Elm", 0.48},
        {"Glass", 0.96},
        {"Iron", 0.67},
        {"Ivory", 0.78},
        {"Lead", 0.16},
        {"Maple", 0.65},
        {"Rubber", 0.75},
        {"Steel", 0.9}
    }


    Public Sub New()
        InitializeComponent()
        BOXHEIGHT = picDisplay.Height
        BOXWIDTH = picDisplay.Width
        setHandlers()
        leftParticle.Shape.posY = BOXHEIGHT / 2
        rightParticle.Shape.posY = BOXHEIGHT / 2
    End Sub

    Sub setHandlers()
        For Each group As Control In grpData.Controls
            If group.GetType = GetType(GroupBox) Then
                For Each control As Control In group.Controls
                    AddHandler control.Leave, AddressOf UpdateValues
                    If control.GetType = GetType(ComboBox) Then
                        Dim combo As ComboBox = DirectCast(control, ComboBox)
                        For Each pair As KeyValuePair(Of String, Single) In MaterialDictionary
                            combo.Items.Add(pair.Key)
                            combo.SelectedIndex = 0
                            AddHandler combo.SelectedIndexChanged, AddressOf SetToolTipCOE
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picDisplay.Refresh()
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        leftParticle.Shape.Draw(e, SHAPEWIDTH)
        rightParticle.Shape.Draw(e, SHAPEWIDTH)
    End Sub

    Sub SetToolTipCOE(sender As ComboBox, e As EventArgs)
        ToolTips.SetToolTip(sender, MaterialDictionary.Item(sender.SelectedItem))
    End Sub

    Sub UpdateValues()

    End Sub

End Class

Class Particle
    Public Property Velocity As Single
    Public Property Mass As Single
    Public Property Shape As Square

End Class