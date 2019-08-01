'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtMessage.Text.ToString Like "##*" Then
            lblMessage.Text = "OK"
        Else
            lblMessage.Text = "Not OK"
        End If
    End Sub
End Class
