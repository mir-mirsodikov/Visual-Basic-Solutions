
'Visual Basic Test 8a
'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private dblCoffee() As Double = {511.4, 219.6, 173.4, 657.8, 843.8, 248.6, 177.5, 490.5, 383.6, 431.8, 510.4, 436.6}
    Dim dblTotal As Double
    Dim dblAvg As Double

    Private Sub displayNum(ByVal dblT As Double, ByVal dblA As Double)
        lblTotal.Text = dblT.ToString("N1")
        lblAverage.Text = dblAvg.ToString("N2")
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        dblTotal = 0
        dblAvg = 0

        For intSub As Integer = 0 To dblCoffee.GetUpperBound(0)
            dblTotal += dblCoffee(intSub)
        Next

        dblAvg = dblTotal / dblCoffee.Length

        displayNum(dblTotal, dblAvg)

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        Dim intSub As Integer

        dblAvg = 0
        dblTotal = 0

        Do While (intSub <= dblCoffee.GetUpperBound(0))
            dblTotal += dblCoffee(intSub)
            intSub += 1
        Loop

        dblAvg = dblTotal / dblCoffee.Length

        displayNum(dblTotal, dblAvg)

    End Sub

    Private Sub btnForEach_Click(sender As Object, e As EventArgs) Handles btnForEach.Click
        dblAvg = 0
        dblTotal = 0

        For Each dblSub As Double In dblCoffee
            dblTotal += dblSub
        Next

        dblAvg = dblTotal / dblCoffee.Length

        displayNum(dblTotal, dblAvg)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
