Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Dim strInputPrice As Double

        strInputPrice = txtPrice.Text.Trim.ToUpper
        If strInputPrice = "1" OrElse "2" Then
            lblShow.Text = "$15"
        ElseIf strInputPrice = "3" Then
            lblShow.Text = "$25"
        ElseIf strInputPrice = "4" OrElse "5" Then
            lblShow.Text = "$35"
        Else
            lblShow.Text = "N/A"
        End If
    End Sub
End Class
