'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Use a pretest loop to display the numbers from 1 to 5.

        Dim intNum As Integer = 1
        Do While intNum <= 5
            lblNums.Text = lblNums.Text & intNum.ToString & "     "
            intNum += 1
        Loop
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
