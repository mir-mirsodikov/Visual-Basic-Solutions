'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strAlphabet As String
        Dim strLetters As String
        Dim intIndex As Integer

        strAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        intIndex = strAlphabet.IndexOf("O")
        strLetters = strAlphabet.Substring(intIndex, 5)
        lblResult.Text = strLetters.ToString
    End Sub
End Class
