'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private strLetters As String = "ABCDEFGHIJ"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = strLetters(4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intIndex As Integer

        intIndex = strLetters.IndexOf("C")
        Label2.Text = String.Empty
        For intIndex = intIndex To intIndex + 3
            Label2.Text = Label2.Text & strLetters(intIndex)
        Next intIndex
    End Sub
End Class
