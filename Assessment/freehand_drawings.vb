Imports System
Imports System.Drawing
Imports System.Windows.Forms
Public Class freehand_drawing
    Dim MyDialog As New ColorDialog
    Public Col As New Color
    Dim Down = False
    Public BrushSize As Integer = 5
    Private Sub btnbtmain_Click(sender As Object, e As EventArgs) Handles btnbtmain.Click
        main_page.Show()
        Me.Dispose()
    End Sub
    Private Sub cbosize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbosize.SelectedIndexChanged

    End Sub
    Public Function ChooseColor() As Boolean
        Dim MyDialog As New ColorDialog
        Col = Color.Black
        Dim rec As New Rectangle
        Dim Temp As Color = btncolor.BackColor
        If MyDialog.ShowDialog = DialogResult.OK Then
            Col = MyDialog.Color
            btncolor.BackColor = MyDialog.Color
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub picbox_MouseMove(ByVal senter As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseMove
        Dim Abrush = New SolidBrush(Col)
        BrushSize = cbosize.SelectedItem
        If Down = True Then
            rdoeraser.Checked = False
            picbox.CreateGraphics.FillEllipse(Abrush, e.X, e.Y, BrushSize, BrushSize)
        ElseIf rdoeraser.Checked = True Then
            picbox.CreateGraphics.FillEllipse(Brushes.White, e.X, e.Y, BrushSize, BrushSize)
        End If
    End Sub
    Private Sub picbox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseDown
        Down = True
    End Sub
    Private Sub picbox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseUp
        Down = False
    End Sub
    Private Sub freehand_drawing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncolor.BackColor = Color.White
        rdoeraser.Checked = False
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        picbox.CreateGraphics.Clear(Color.White)
    End Sub
    Private Sub btncolor_Click(sender As Object, e As EventArgs) Handles btncolor.Click
        ChooseColor()
    End Sub
 
    Private Sub rdoeraser_CheckedChanged(sender As Object, e As EventArgs) Handles rdoeraser.CheckedChanged

    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class