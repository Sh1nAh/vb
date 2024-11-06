Public Class summary
    Dim mymark As New ArrayList
    Public totalmark As Integer = 0
    Public highestmark As Integer = 0
    Public lowestmark As Integer = 101
    Public count As Integer = 0
    Public avgmark As Integer = 0
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If txtmark.Text > 100 Or txtmark.Text < 0 Then
                MessageBox.Show("The input must be >100 or <0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtmark.Text = ""
            Else
                mymark.Add(txtmark.Text)
                totalmark += txtmark.Text
                If txtmark.Text > highestmark Then
                    highestmark = txtmark.Text
                End If
                If txtmark.Text < lowestmark Then
                    lowestmark = txtmark.Text
                End If
            End If
            count = count + 1
            txtmark.Text = ""
            txtmark.Focus()
        Catch ex As Exception
            MessageBox.Show("Please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtmark.Text = ""
        End Try
    End Sub
    Private Sub btnbtmain_Click(sender As Object, e As EventArgs) Handles btnbtmain.Click
        main_page.Show()
        Me.Dispose()
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmark.Text = ""
    End Sub
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            avgmark = totalmark.ToString / count
            calculate.Show()
        Catch ex As Exception
            MessageBox.Show("Summary can't show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class