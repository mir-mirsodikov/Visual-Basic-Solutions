'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Dim dblNum As Double

        Double.TryParse(txtNum.Text, dblNum)
        ShowDouble(dblNum)

    End Sub

    Private Sub ShowDouble(ByVal dblNum As Double)
        dblNum *= 2
        lblMessage.Text = dblNum.ToString
    End Sub
End Class
