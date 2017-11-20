Public Class frmTurningPoints
    Dim BOXWIDTH As Integer
    Dim BOXHEIGHT As Integer
    Const SHAPEWIDTH As Integer = 40
    Dim isMouseDown As Boolean = False
    Dim MouseOffset As Point
    Dim currentBox As Color = Color.Red
    'Dim colours() As Color = {Color.FromName("Red"), Color.FromName("Blue"), Color.FromName("Green"), Color.FromName("Orange"), Color.FromName("Violet")}
    Dim colours As New Dictionary(Of Color, Integer) From {{Color.FromName("Red"), 1}, {Color.FromName("Blue"), 2}, {Color.FromName("Green"), 3}, {Color.FromName("Orange"), 4}, {Color.FromName("Violet"), 4}}
    Dim Boxes As New List(Of BoxStruct)

    'New BoxStruct With {.colour = currentBox, .shape = Boxes(colours.item(color.FromName(clbBoxes.SelectedItem))).shape, .mass = Boxes(colours.item(color.FromName(clbBoxes.SelectedItem))).mass, .showing = Boxes(colours.item(color.FromName(clbBoxes.SelectedItem))).showing, .onLine = Boxes(colours.item(color.FromName(clbBoxes.SelectedItem))).onLine}

    Structure BoxStruct
        Dim colour As Color
        Dim shape As Square
        Dim mass As Single
        Dim showing As Boolean
        Dim onLine As Boolean
    End Structure

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        tmrDraw.Start()
        For i = 0 To 4
            Boxes.Add(New BoxStruct With {.colour = colours.Keys(i), .shape = New Square With {.posX = SHAPEWIDTH * i}, .mass = 1, .showing = False, .onLine = False})
        Next
        clbBoxes.SelectedIndex = 0

    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawSeeSaw(e)
        For Each box As BoxStruct In Boxes
            If box.showing = True Then
                box.shape.Draw(e, SHAPEWIDTH, box.colour)
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
            .posX = 50,
            .posXe = BOXWIDTH - 50,
            .posY = baseTriangle.posY,
            .posYe = .posY
        }
        baseTriangle.Draw(e, 100)
        baseLine.Draw(e, 10)

    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        For i = 0 To 4
            If clbBoxes.CheckedItems.Contains(Boxes(i).colour.Name) Then
                Boxes.Item(i) = New BoxStruct With {.colour = Boxes.Item(i).colour, .shape = Boxes.Item(i).shape, .mass = Boxes.Item(i).mass, .showing = True, .onLine = False}
            Else
                Boxes.Item(i) = New BoxStruct With {.colour = Boxes.Item(i).colour, .shape = Boxes.Item(i).shape, .mass = Boxes.Item(i).mass, .showing = False, .onLine = False}
            End If
        Next
        picDisplay.Refresh()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub clbBoxes_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbBoxes.SelectedIndexChanged
        lblMass.Text = clbBoxes.SelectedItem & "'s Mass: "
        updMass.Value = Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).mass
    End Sub

    Private Sub picDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseDown
        If e.Button = MouseButtons.Left Then
            For i = 0 To 4
                With Boxes(i)
                    If e.X > .shape.posX And e.X < .shape.posX + SHAPEWIDTH And e.Y > .shape.posY And e.Y < .shape.posY + SHAPEWIDTH And .showing = True Then
                        isMouseDown = True
                        clbBoxes.SelectedItem = .colour.Name
                        MouseOffset = e.Location - New Point(.shape.posX, .shape.posY)
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

    Private Sub picDisplay_Move(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If isMouseDown Then
            For i = 0 To 4
                If Boxes(i).colour = Color.FromName(clbBoxes.SelectedItem) Then
                    With Boxes(i)
                        If e.Y > 470 And e.Y < 500 + SHAPEWIDTH Then
                            .shape.posY = 488
                            Dim temp As New BoxStruct
                            temp = Boxes(i)
                            temp.onLine = True
                            Boxes(i) = temp

                        Else
                            .shape.posY = e.Y - MouseOffset.Y
                            Dim temp As BoxStruct
                            temp = Boxes(i)
                            temp.onLine = False
                            Boxes(i) = temp

                        End If
                        .shape.posX = e.X - MouseOffset.X
                    End With
                End If
            Next
        End If
    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        Try
            Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))) = New BoxStruct With {.colour = Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).colour, .shape = Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).shape, .mass = updMass.Value, .showing = Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).showing, .onLine = Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).onLine}
        Catch
        End Try
    End Sub
End Class

Class BoxClass
    Public colour As Color
    Public shape As Square
    Public mass As Single
    Public showing As Boolean
    Public onLine As Boolean

    Public Sub ChangeMass(ByVal massIn As Single)
        mass = massIn
    End Sub

    Public Sub ChangeShowing(ByVal boolIn As Boolean)

    End Sub

    Public Sub ChangeOnLine(ByVal boolIn As Boolean)

    End Sub


End Class

