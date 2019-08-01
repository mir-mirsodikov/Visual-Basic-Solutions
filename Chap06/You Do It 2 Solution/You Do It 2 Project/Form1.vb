Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblNum As Double

        Double.TryParse(txtNum.Text, dblNum)
        CalcDouble(dblNum)
        lblMessage.Text = dblNum.ToString
    End Sub

    Private Sub CalcDouble(ByRef dblNum As Double)
        dblNum *= 2
    End Sub
End Class
