Public Class frmTurningPoints
    Dim BOXWIDTH As Int32
    Dim BOXHEIGHT As Int32
    Const SHAPEWIDTH As Int32 = 40
    Dim isMouseDown As Boolean = False
    Dim MouseOffset As Point
    Dim currentBox As Int32 = 0
    Dim colours As New Dictionary(Of Color, Int32) From {{Color.FromName("Red"), 1}, {Color.FromName("Blue"), 2}, {Color.FromName("Green"), 3}, {Color.FromName("Orange"), 4}, {Color.FromName("Violet"), 4}}
    Dim Boxes As New List(Of BoxClass)
    Dim LineLength As Int32 = 10

    Public Sub New()
        InitializeComponent()
        BOXWIDTH = picDisplay.Width
        BOXHEIGHT = picDisplay.Height
        tmrDraw.Start()
        For i = 0 To 4
            Boxes.Add(New BoxClass With {.colour = colours.Keys(i), .shape = New Square With {.posX = SHAPEWIDTH * i}, .mass = 1, .showing = False, .onLine = False})
        Next
        clbBoxes.SelectedIndex = 0

    End Sub

    Private Sub picDisplay_Paint(sender As Object, e As PaintEventArgs) Handles picDisplay.Paint
        DrawSeeSaw(e)
        For Each box As BoxClass In Boxes
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
        baseTriangle.Draw(e, 100)
        baseLine.Draw(e, 10)

    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        For i = 0 To 4
            If clbBoxes.CheckedItems.Contains(Boxes(i).colour.Name) Then
                Boxes(i).ChangeShowing(True)
            Else
                Boxes(i).ChangeShowing(False)
            End If
        Next
        If Boxes(currentBox).onLine Then
            lblDistanceFromTuring.Visible = True
            lblDistanceFromTuring.Visible = True
        Else
            lblDistanceFromTuring.Visible = False
            lblDistanceFromTuring.Visible = False
        End If
        picDisplay.Refresh()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub clbBoxes_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbBoxes.SelectedIndexChanged
        currentBox = colours.Item(Color.FromName(clbBoxes.SelectedItem))
        lblMass.Text = clbBoxes.SelectedItem & "'s Mass: "
        updMass.Value = Boxes(currentBox).mass
        If Boxes(currentBox).onLine Then
            lblDistanceFromTuring.Visible = True
            lblDistanceFromTuring.Visible = True
        Else
            lblDistanceFromTuring.Visible = False
            lblDistanceFromTuring.Visible = False
        End If
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

    Private Sub picDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles picDisplay.MouseMove
        If isMouseDown Then
            For i = 0 To 4
                If Boxes(i).colour = Color.FromName(clbBoxes.SelectedItem) Then
                    With Boxes(i)
                        If .shape.posX + SHAPEWIDTH / 2 > (BOXWIDTH / 2 - 500) And .shape.posX + SHAPEWIDTH / 2 < (BOXWIDTH / 2 + 500) And e.Y > (BOXHEIGHT / 2) - (SHAPEWIDTH) And e.Y < (BOXHEIGHT / 2 + Shape.WIDTH) Then
                            .shape.posY = 488
                            Boxes(i).ChangeOnLine(True)
                        Else
                            .shape.posY = e.Y - MouseOffset.Y
                            Boxes(i).ChangeOnLine(False)
                        End If
                        .shape.posX = e.X - MouseOffset.X
                    End With
                End If
            Next
        End If
    End Sub

    Private Sub updMass_ValueChanged(sender As Object, e As EventArgs) Handles updMass.ValueChanged
        Try
            Boxes(colours.Item(Color.FromName(clbBoxes.SelectedItem))).ChangeMass(updMass.Value)
        Catch
        End Try
    End Sub

    Private Sub updLength_ValueChanged(sender As Object, e As EventArgs) Handles updLength.ValueChanged
        LineLength = updLength.Value
    End Sub
End Class

Class BoxClass
    Public colour As Color
    Public shape As Square
    Public mass As Single
    Public showing As Boolean
    Public onLine As Boolean
    Public distanceFromTurning As Int32

    Public Sub ChangeMass(ByVal massIn As Single)
        mass = massIn
    End Sub

    Public Sub ChangeShowing(ByVal boolIn As Boolean)
        showing = boolIn
    End Sub

    Public Sub ChangeOnLine(ByVal boolIn As Boolean)
        onLine = boolIn
    End Sub


End Class