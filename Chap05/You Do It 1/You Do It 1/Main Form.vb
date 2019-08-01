'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intNum As Integer

        intNum = 1
        Do While intNum <= 7
            lblDisplay.Text = lblDisplay.Text & intNum.ToString & "  "
            intNum += 2
        Loop


    End Sub
End Class
