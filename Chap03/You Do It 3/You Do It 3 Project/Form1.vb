'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Dim intScore As Integer = 1
        Static intNumber As Integer

        intNumber = intNumber + intScore

        lblMessage.Text = intNumber.ToString
    End Sub
    ' Private intNumber As Integer


End Class
