Public Class frmTurningPoints
    Dim BOXWIDTH As Int32
    Dim BOXHEIGHT As Int32
    Const LINEWIDTH As Single = 10
    Const SHAPEWIDTH As Single = 40
    Dim isMouseDown As Boolean = False
    Dim MouseOffset As Point
    Dim currentBox As Int32 = 0
    Dim colours As New Dictionary(Of Color, Int32) From {{Color.FromName("Red"), 0}, {Color.FromName("Blue"), 1}, {Color.FromName("Green"), 2}, {Color.FromName("Orange"), 3}, {Color.FromName("Violet"), 4}}
    Dim Boxes As New List(Of BoxClass)
    Dim LineLength As Int32 = 10
    Dim BalanceBoxDistance As Single

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        tmrDraw.Start()
        For i = 0 To 4
            Boxes.Add(New BoxClass(colours.Keys(i), New Square With {.posX = SHAPEWIDTH * i}, 1, False, False, 0))
            clbBoxes.Items.Add(colours.Keys(i).Name)
        Next
        clbBoxes.SelectedIndex = 0
    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        DrawSeeSaw(e)
        For Each box As BoxClass In Boxes
            If box.Showing = True Then
                box.Shape.Draw(e, SHAPEWIDTH, box.Colour)
            End If
        Next
        If chbBalance.Checked Then
            DrawBalanceBox(e)
        End If
    End Sub

    Sub DrawBalanceBox(ByVal e As PaintEventArgs)
        Dim myPen As New Pen(Color.Black)
        myPen.Width = 2
        myPen.Alignment = Drawing2D.PenAlignment.Inset
        Dim posX As Single = BalanceBoxDistance / LineLength * 500 + (BOXWIDTH / 2) - Shape.WIDTH
        Dim posY As Single = (BOXHEIGHT / 2) - (SHAPEWIDTH / 2) - (LINEWIDTH / 2)
        e.Graphics.FillRectangle(Brushes.Chocolate, posX, posY, SHAPEWIDTH, SHAPEWIDTH)
        e.Graphics.DrawRectangle(myPen, posX, posY, SHAPEWIDTH, SHAPEWIDTH)
        LabelText.Draw(e, "?", 25, posX + 4, posY)
    End Sub

    Sub DrawSeeSaw(ByVal e As PaintEventArgs)
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
            If clbBoxes.CheckedItems.Contains(.Colour.Name) Then
                .Showing = True
            Else
                .Showing = False
            End If

            If .OnLine Then
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
        updMass.Value = Boxes(currentBox).Mass
    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left Then
            For i = 0 To colours.Values.Count - 1
                With Boxes(i)
                    If e.X > .Shape.posX And e.X < .Shape.posX + SHAPEWIDTH And e.Y > .Shape.posY And e.Y < .Shape.posY + SHAPEWIDTH And .Showing = True Then
                        isMouseDown = True
                        clbBoxes.SelectedItem = .Colour.Name
                        MouseOffset = e.Location - New Point(.Shape.posX, .Shape.posY)
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub picDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub PicDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If isMouseDown Then
            With Boxes(currentBox)
                If .Shape.posX + SHAPEWIDTH / 2 > (BOXWIDTH / 2 - 500) And .Shape.posX + SHAPEWIDTH / 2 < (BOXWIDTH / 2 + 500) And e.Y > (BOXHEIGHT / 2) - (SHAPEWIDTH) And e.Y < (BOXHEIGHT / 2 + Shape.WIDTH) Then
                    .Shape.posY = (BOXHEIGHT / 2) - (SHAPEWIDTH / 2) - (LINEWIDTH / 2)
                    .OnLine = True
                    .DistanceFromTurning = ((.Shape.posX + Shape.WIDTH) - (BOXWIDTH / 2)) / 500 * LineLength
                    updDistance.Value = .DistanceFromTurning
                Else
                    .Shape.posY = e.Y - MouseOffset.Y
                    .OnLine = False
                End If
                .Shape.posX = e.X - MouseOffset.X
                chbBalance.Visible = False
                chbBalance.Checked = False
            End With
        End If
    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        Try
            Boxes(currentBox).Mass = updMass.Value
        Catch
        End Try
    End Sub

    Private Sub updLength_ValueChanged(sender As Object, e As EventArgs) Handles updLength.ValueChanged
        LineLength = updLength.Value
        updDistance.Maximum = updLength.Value
        updDistance.Minimum = -updLength.Value
        For Each Box As BoxClass In Boxes
            If Box.OnLine Then
                Box.Shape.posX = updDistance.Value / LineLength * 500 + (BOXWIDTH / 2) - Shape.WIDTH
            End If
        Next
    End Sub

    Private Sub updDistance_ValueChanged(sender As Object, e As EventArgs) Handles updDistance.ValueChanged
        Boxes(currentBox).Shape.posX = updDistance.Value / LineLength * 500 + (BOXWIDTH / 2) - Shape.WIDTH
    End Sub

    Private Sub cmdBalanceMass_Click(sender As Object, e As EventArgs) Handles cmdBalanceMass.Click
        Dim NewMass As Single = 0
        Dim numberIn As New NumberInput
        If numberIn.ShowDialog("Enter the mass of the known box") = DialogResult.OK Then
            NewMass = numberIn.Result
            BalanceBoxDistance = CalculateMoment(NewMass)
            If Math.Abs(BalanceBoxDistance) <= LineLength Then
                MessageBox.Show(String.Format("To balance the see saw with a box of mass {0}kg, it needs to be places {1}m from the turning point", NewMass, BalanceBoxDistance))
                chbBalance.Show()
            Else
                MessageBox.Show(String.Format("To balance the see saw with a box of mass {0}kg, it needs to be places {1}m from the turning point. This is a greater than the length of the see saw", NewMass, BalanceBoxDistance))
                chbBalance.Hide()
                chbBalance.Checked = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Calculate the clockwise moment of the boxes about a point and returns either the mass or distance a box is away
    ''' from the turning point
    ''' </summary>
    Function CalculateMoment(ByVal unknownIn As Single) As Single
        Dim moment As Single = 0
        For Each box As BoxClass In Boxes
            If box.OnLine Then
                moment += (box.Mass) * box.DistanceFromTurning
            End If
        Next
        Return -moment / unknownIn
    End Function

    Private Sub cmdBalanceDistance_Click(sender As Object, e As EventArgs) Handles cmdBalanceDistance.Click
        Dim NewDistance As Single = 0
        Dim numberIn As New NumberInput
        numberIn.updNumber.Minimum = -1000
        If numberIn.ShowDialog("Enter the distance from the turning point of the known box") = DialogResult.OK Then
            NewDistance = numberIn.Result
            BalanceBoxDistance = NewDistance
            Dim NewMass As Single = CalculateMoment(NewDistance)
            If NewMass >= 0 Then
                MessageBox.Show(String.Format("To balance the see saw with a box {0}m from the turning point, it needs to have a mass of {1}kg", NewDistance, NewMass))
                chbBalance.Show()
            Else
                MessageBox.Show(String.Format("To balance the see saw with a box {0}m from the turning point, it needs to provide a {1}N force underneath to support it", NewDistance, Math.Abs(NewMass * 9.81)))
                chbBalance.Hide()
                chbBalance.Checked = False
            End If
        End If
    End Sub

    Private Sub cmdAddBox_Click(sender As Object, e As EventArgs) Handles cmdAddBox.Click
        Dim newColourIn As New ColorDialog
        Dim newColour As Color
        If newColourIn.ShowDialog = DialogResult.OK Then
            newColour = newColourIn.Color
            Dim listCount As Int32 = colours.Values.Count
            colours.Add(newColour, listCount)
            Boxes.Add(New BoxClass(colours.Keys(listCount), New Square With {.posX = SHAPEWIDTH * listCount}, 1, False, False, 0))
            clbBoxes.Items.Add(colours.Keys(listCount).Name)
        End If
    End Sub
End Class

Class BoxClass

    Public Property Colour As Color

    Public Property Shape As Square

    Public Property Mass As Single

    Public Property Showing As Boolean

    Public Property OnLine As Boolean

    Public Property DistanceFromTurning As Single

    Public Sub New(ByVal colourIn As Color, ByVal shapeIn As Square, ByVal massIn As Single, ByVal showingIn As Boolean, ByVal onLineIn As Boolean, ByVal distanceFromTurningIn As Single)
        Colour = colourIn
        Shape = shapeIn
        Mass = massIn
        Showing = showingIn
        OnLine = onLineIn
        DistanceFromTurning = distanceFromTurningIn
    End Sub
End Class