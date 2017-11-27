Public Class frmTurningPoints
    Dim BOXWIDTH As Int32
    Dim BOXHEIGHT As Int32
    Const LINEWIDTH As Int32 = 10
    Const SHAPEWIDTH As Int32 = 40
    Dim isMouseDown As Boolean = False
    Dim MouseOffset As Point
    Dim currentBox As Int32 = 0
    Dim colours As New Dictionary(Of Color, Int32) From {{Color.FromName("Red"), 0}, {Color.FromName("Blue"), 1}, {Color.FromName("Green"), 2}, {Color.FromName("Orange"), 3}, {Color.FromName("Violet"), 4}}
    Dim Boxes As New List(Of BoxClass)
    Dim LineLength As Int32 = 10

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        tmrDraw.Start()
        For i = 0 To 4
            Boxes.Add(New BoxClass(colours.Keys(i), New Square With {.posX = SHAPEWIDTH * i}, 1, False, False, 0))
        Next
        clbBoxes.SelectedIndex = 0
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawSeeSaw(e)
        For Each box As BoxClass In Boxes
            If box.GetShowing = True Then
                box.shape.Draw(e, SHAPEWIDTH, box.GetColour)
            End If
        Next
    End Sub

    Sub DrawSeeSaw(ByRef e As PaintEventArgs)
        Dim baseTriangle As New Triangle With {
            .up = True,
            .posY = BOXHEIGHT / 2 + Shape.WIDTH,
            .posX = BOXWIDTH / 2 - 50
        }
        Dim baseLine As New Line With {
            .posX = BOXWIDTH / 2 - 500,
            .posXe = .posX + 1000,
            .posY = baseTriangle.posY,
            .posYe = .posY
        }
        Dim myPen As New Pen(Color.Gray, 3)
        myPen.DashStyle = Drawing2D.DashStyle.Dash
        e.Graphics.DrawLine(myPen, baseLine.posX + 1, baseLine.posY, baseLine.posX + 1, baseLine.posY + 200)
        e.Graphics.DrawLine(myPen, baseLine.posXe - 2, baseLine.posY, baseLine.posXe - 2, baseLine.posY + 200)
        myPen.CustomEndCap = New Drawing2D.AdjustableArrowCap(5, 5)
        myPen.CustomStartCap = New Drawing2D.AdjustableArrowCap(5, 5)
        e.Graphics.DrawLine(myPen, baseLine.posX, baseLine.posY + 200, baseLine.posXe, baseLine.posY + 200)
        LabelText.Draw(e, LineLength & "m", 20, BOXWIDTH / 2, baseLine.posY + 210)
        baseTriangle.Draw(e, SHAPEWIDTH * 2.5)
        baseLine.Draw(e, LINEWIDTH)

    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        With Boxes(currentBox)
            If clbBoxes.CheckedItems.Contains(.GetColour.Name) Then
                .SetShowing(True)
            Else
                .SetShowing(False)
            End If

            If .GetOnLine Then
                lblDistanceFromTuring.Visible = True
                updDistance.Visible = True
            Else
                lblDistanceFromTuring.Visible = False
                updDistance.Visible = False
            End If
        End With
        picDisplay.Refresh()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub clbBoxes_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbBoxes.SelectedIndexChanged
        currentBox = colours.Item(Color.FromName(clbBoxes.SelectedItem))
        lblMass.Text = clbBoxes.SelectedItem & "'s Mass: "
        updMass.Value = Boxes(currentBox).GetMass
    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left Then
            With Boxes(currentBox)
                If e.X > .shape.posX And e.X < .shape.posX + SHAPEWIDTH And e.Y > .shape.posY And e.Y < .shape.posY + SHAPEWIDTH And .GetShowing = True Then
                    isMouseDown = True
                    clbBoxes.SelectedItem = .GetColour.Name
                    MouseOffset = e.Location - New Point(.shape.posX, .shape.posY)
                End If
            End With
        End If
    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If isMouseDown Then
            With Boxes(currentBox)
                If .shape.posX + SHAPEWIDTH / 2 > (BOXWIDTH / 2 - 500) And .shape.posX + SHAPEWIDTH / 2 < (BOXWIDTH / 2 + 500) And e.Y > (BOXHEIGHT / 2) - (SHAPEWIDTH) And e.Y < (BOXHEIGHT / 2 + Shape.WIDTH) Then
                    .shape.posY = (BOXHEIGHT / 2) - (SHAPEWIDTH / 2) - (LINEWIDTH / 2)
                    .SetOnLine(True)
                    .SetDistanceFromTurning(((.shape.posX + Shape.WIDTH) - (BOXWIDTH / 2)) / 500 * LineLength)
                    updDistance.Value = .GetDistanceFromTurning
                Else
                    .shape.posY = e.Y - MouseOffset.Y
                    .SetOnLine(False)
                End If
                .shape.posX = e.X - MouseOffset.X
            End With
        End If
    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        Try
            Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).SetMass(updMass.Value)
        Catch
        End Try
    End Sub

    Private Sub updLength_ValueChanged(sender As Object, e As EventArgs) Handles updLength.ValueChanged
        LineLength = updLength.Value
        updDistance.Maximum = updLength.Value
        updDistance.Minimum = -updLength.Value
        For Each Box As BoxClass In Boxes
            If Box.GetOnLine Then
                Box.shape.posX = updDistance.Value / LineLength * 500 + (BOXWIDTH / 2) - Shape.WIDTH
            End If
        Next
    End Sub

    Private Sub updDistance_ValueChanged(sender As Object, e As EventArgs) Handles updDistance.ValueChanged
        Boxes(currentBox).shape.posX = updDistance.Value / LineLength * 500 + (BOXWIDTH / 2) - Shape.WIDTH
    End Sub

    Private Sub cmdBalanceMass_Click(sender As Object, e As EventArgs) Handles cmdBalanceMass.Click
        Dim NewMass As Single = 0
        Dim newButton As Button


        Dim InputForma As Form = New Form With {
            .ShowIcon = False,
            .Text = "Input Mass"

        }
        InputForma.Show()

    End Sub

    Private Sub cmdBalanceDistance_Click(sender As Object, e As EventArgs) Handles cmdBalanceDistance.Click

    End Sub
End Class

Class BoxClass
    Private colour As Color
    Public shape As Square
    Private mass As Single
    Private showing As Boolean
    Private onLine As Boolean
    Private distanceFromTurning As Single

    Public Sub New(ByVal colourIn As Color, ByVal shapeIn As Square, ByVal massIn As Single, ByVal showingIn As Boolean, ByVal onLineIn As Boolean, ByVal distanceFromTurningIn As Single)
        colour = colourIn
        shape = shapeIn
        mass = massIn
        showing = showingIn
        onLine = onLineIn
        distanceFromTurning = distanceFromTurningIn
    End Sub

    Public Sub SetColour(ByVal colourIn As Color)
        colour = colourIn
    End Sub

    Public Sub SetMass(ByVal intIn As Single)
        mass = intIn
    End Sub

    Public Sub SetShowing(ByVal boolIn As Boolean)
        showing = boolIn
    End Sub

    Public Sub SetOnLine(ByVal boolIn As Boolean)
        onLine = boolIn
    End Sub

    Public Sub SetDistanceFromTurning(ByVal intIn As Single)
        distanceFromTurning = intIn
    End Sub

    Public Function GetColour() As Color
        Return colour
    End Function

    Public Function GetMass() As Single
        Return mass
    End Function

    Public Function GetShowing() As Boolean
        Return showing
    End Function

    Public Function GetOnLine() As Boolean
        Return onLine
    End Function

    Public Function GetDistanceFromTurning() As Single
        Return distanceFromTurning
    End Function


End Class