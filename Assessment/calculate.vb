Public Class calculate
    Private Sub calculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnmark.Text = summary.count
        txttotal.Text = summary.totalmark
        txtavg.Text = summary.avgmark
        txthighest.Text = summary.highestmark
        txtlowest.Text = summary.lowestmark
    End Sub
    Private Sub btnbtmain_Click(sender As Object, e As EventArgs) Handles btnbtmain.Click
        main_page.Show()
        Me.Dispose()
    End Sub
End Class