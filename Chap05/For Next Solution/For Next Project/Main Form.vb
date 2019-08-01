'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Use the For...Next statement to display the numbers from 1 to 5.

        For intNum As Integer = 1 To 5
            lblNums.Text = lblNums.Text & intNum.ToString & "     "
        Next intNum
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
