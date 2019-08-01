Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private Function GetDouble(ByVal dblNum1 As Double) As Double
        Dim dblDouble As Double

        dblDouble = dblNum1 * 2
        Return dblDouble
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblNum1 As Double

        Double.TryParse(txtNum.Text, dblNum1)

        lblMessage.Text = GetDouble(dblNum1).ToString

    End Sub
End Class
