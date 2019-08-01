' Name:         Waterson Project
' Purpose:      Displays the highest stock price and the number of days at that price.
' Programmer:   <Mukhammad Mirsodikov> on <3/20/19>

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

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the highest stock price and the number of days at that price.

        ' Declare variables.
        Dim intLastSub As Integer = dblPrices.GetUpperBound(0)
        Dim dblLowest As Double = dblPrices(0)
        Dim intDays As Integer = 1

        For intSub As Integer = 1 To intLastSub
            If dblPrices(intSub) = dblLowest Then
                intDays += 1
            ElseIf dblPrices(intSub) < dblLowest Then
                dblLowest = dblPrices(intSub)
                intDays = 1
            End If
        Next intSub

        lblHighest.Text = dblLowest.ToString("C2")
        lblDays.Text = intDays.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
