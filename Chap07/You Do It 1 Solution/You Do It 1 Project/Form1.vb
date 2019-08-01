'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strString As String

        strString = txtMessage.Text.Trim

        If strString.Length >= 2 AndAlso strString.Length < 7 Then
            strString = strString.Insert(1, "#")
            strString = strString.PadRight(10, "*"c)
        End If

        lblAnswer.Text = strString

    End Sub
End Class
