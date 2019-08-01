' Name:         Electricity Project
' Purpose:      Calculate the average monthly electric bill.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the average monthly cost.

        Dim dblMonthly() As Double = {141.71, 156.75, 179.25, 141.71, 130.19, 115.05,
                                       95.65, 86.78, 85.45, 79.99, 98.45, 126.78}
        Dim dblTotal As Double
        For Each dblAverage As Double In dblMonthly
            dblTotal += dblAverage
        Next
        dblTotal /= dblMonthly.Length
        lblAvg.Text = dblTotal.ToString("c2")
    End Sub
End Class
