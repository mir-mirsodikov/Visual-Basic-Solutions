'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intNum As Integer = 1

        Do
            lblDisplay.Text = lblDisplay.Text & intNum.ToString & "     "
            intNum += 2
        Loop Until intNum > 7
    End Sub
End Class
