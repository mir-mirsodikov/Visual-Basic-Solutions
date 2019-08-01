'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display calorie information.

        Dim intCalories() As Integer = {2250, 1920, 2125, 2505, 2010, 1950, 1825,
                                        2025, 2000, 1820, 1990, 1950, 1875, 1750}
        Dim dblAverage As Double
        Dim dblTotal As Double
        Dim intAtAvg As Integer
        Dim intBelowAvg As Integer
        Dim intAboveAvg As Integer

        For Each intX As Integer In intCalories
            dblTotal += intX
        Next

        dblAverage = dblTotal / intCalories.Length
        dblAverage = Math.Round(dblAverage, 0)
        'MessageBox.Show(intCalories.Length.ToString)
        For Each intX As Integer In intCalories
            If intX = dblAverage Then
                intAtAvg += 1
            ElseIf intX > dblAverage Then
                intAboveAvg += 1
            ElseIf intX < dblAverage Then
                intBelowAvg += 1
            End If
        Next

        lblAvg.Text = dblAverage.ToString
        lblAtAvg.Text = intAtAvg.ToString
        lblAboveAvg.Text = intAboveAvg.ToString
        lblBelowAvg.Text = intBelowAvg.ToString

    End Sub
End Class
