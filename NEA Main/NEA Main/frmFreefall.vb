Public Class frmFreefall
    Const SHAPEWIDTH As Int16 = 50
    Dim BOXWIDTH, BOXHEIGHT As Int32
    Dim dropHeight As Single = 10
    Dim area
    'Dim Shapes As New Dictionary(Of String, Int32) From {
    '{"Cube", 1.05},
    '{"Sphere", 0.47},
    '{"Cone", 0.5},
    '{"Angled cube", 0.8},
    '{"Streamlined", 0.04}
    '}
    Dim Shapes As New List(Of FallingShapes) From {
        {New FallingShapes With {.name = "Cube", .shape = New Square, .coe = 1.05}},
        {New FallingShapes With {.name = "Sphere", .shape = New Circle, .coe = 0.47}},
        {New FallingShapes With {.name = "Cone", .shape = New Triangle, .coe = 0.5}}
    }

    Dim ball As New Circle With {
        .posX = 0,
        .posY = 0
    }

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picBoxDisplay.Width
        BOXHEIGHT = picBoxDisplay.Height
        For Each item As FallingShapes In Shapes
            cboShapes.Items.Add(item.name)
        Next
    End Sub

    Private Sub cboShapes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShapes.SelectedIndexChanged
        For Each item In Shapes
            If cboShapes.SelectedItem = item.name Then
                ToolTips.SetToolTip(cboShapes, item.coe)
            End If
        Next
    End Sub

    Private Sub picBoxMain_Paint(sender As Object, e As PaintEventArgs) Handles picBoxDisplay.Paint
        DrawCliff(e)
        ball.Draw(e, SHAPEWIDTH)
    End Sub

    Sub DrawCliff(e As PaintEventArgs)
        BOXHEIGHT = picBoxDisplay.Height
        e.Graphics.DrawRectangle(Pens.Black, 0, SHAPEWIDTH * 2, CInt(BOXWIDTH / 2), BOXHEIGHT - SHAPEWIDTH * 2 - 1)
        Dim myPen As New Pen(Color.Black, 3)
        myPen.CustomEndCap = New Drawing2D.AdjustableArrowCap(5, 5)
        myPen.CustomStartCap = New Drawing2D.AdjustableArrowCap(5, 5)
        myPen.DashStyle = Drawing2D.DashStyle.Dash
        e.Graphics.DrawLine(myPen, CInt(BOXWIDTH / 2 - 100), SHAPEWIDTH * 2, CInt(BOXWIDTH / 2 - 100), BOXHEIGHT)
        LabelText.Draw(e, String.Format("{0:0.000}m", dropHeight), 10, BOXWIDTH / 2 - 90, BOXHEIGHT / 2)
    End Sub

    Private Sub cboGravity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGravity.SelectedIndexChanged
        ToolTips.SetToolTip(cboGravity, AccelerationDictionary.Item(cboGravity.SelectedItem()) & "ms^-2")
    End Sub

    Private Sub frmFreefall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAccelerationCbo(cboGravity)
    End Sub

    Private Sub updHeight_ValueChanged(sender As Object, e As EventArgs) Handles updHeight.ValueChanged
        dropHeight = updHeight.Value
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        picBoxDisplay.Refresh()
    End Sub

    Private Sub trbTime_Scroll(sender As Object, e As EventArgs) Handles trbTime.Scroll
        If optStepByStep.Checked Then
            ToolTips.SetToolTip(trbTime, "Time: " & trbTime.Value / 100)
        End If
    End Sub

    Private Sub optRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles optRealTime.CheckedChanged
        If optRealTime.Checked Then
            trbTime.Hide()
            cmdStart.Show()
        Else
            trbTime.Show()
            cmdStart.Hide()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Sub UpdateValues()

    End Sub

End Class

Public Class FallingShapes
    Public Property shape As Shape
    Public Property name As String
    Public Property coe As Single

End Class