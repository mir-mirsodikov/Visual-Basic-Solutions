'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the first 10 Fibonacci numbers.
        Dim intX As Integer = 1
        Dim intY As Integer = 0
        Dim intSum As Integer
        Dim intCounter As Integer

        lblNumbers.Text = lblNumbers.Text & intX.ToString & "   "


        Do Until intCounter = 9
            intSum = intX + intY
            lblNumbers.Text = lblNumbers.Text & intSum.ToString & "   "
            intY = intX
            intX = intSum
            intCounter += 1
        Loop

    End Sub
End Class
