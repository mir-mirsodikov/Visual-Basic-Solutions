Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intCount As Integer
        Dim intSum As Integer

        For intNum As Integer = 14 To 23
            intCount += 1
            intSum += intNum
        Next intNum
        lblNum.Text = intCount.ToString
        lblSum.Text = intSum.ToString
    End Sub
End Class
