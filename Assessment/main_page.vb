Public Class main_page
    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        If rdogsa.Checked = True Then
            summary.Show()
            Me.Hide()
        End If
        If rdobda.Checked = True Then
            freehand_drawing.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
    Private Sub main_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        rdogsa.Checked = True
    End Sub
    Private Sub main_page_Activated(ByVal sender As Object, e As EventArgs) Handles Me.Activated
        summary.Dispose()
        freehand_drawing.Dispose()
    End Sub
End Class
