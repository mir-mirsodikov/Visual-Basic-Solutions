' Name:         Waterson Project
' Purpose:      Displays the average stock price.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' Class-level array.
    Private dblPrices() As Double = {85.7, 89.5, 91, 99, 97.5,
                                     96, 96.8, 96.8, 96, 99}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills list box with prices.

        For Each dblStockPrice As Double In dblPrices
            lstPrices.Items.Add(dblStockPrice.ToString("N2"))
        Next dblStockPrice
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays the average stock price.

        Dim dblTotal As Double
        Dim dblAvg As Double

        Dim intHighSub As Integer = dblPrices.GetUpperBound(0)
        Dim intSub As Integer

        Do While intSub <= intHighSub
            dblTotal += dblPrices(intSub)
            intSub += 1
        Loop

        dblAvg = dblTotal / dblPrices.Length
        lblAvg.Text = dblAvg.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
