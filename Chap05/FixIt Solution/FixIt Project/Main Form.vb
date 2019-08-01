'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the numbers 10, 9, 8, 7, 6, 5, 4, 3, 2, and 1.

        Dim intNum As Integer = 10

        lblNums.Text = String.Empty

        Do Until intNum < 1
            lblNums.Text = lblNums.Text & intNum.ToString & ControlChars.NewLine
            intNum -= 1
        Loop
    End Sub
End Class
