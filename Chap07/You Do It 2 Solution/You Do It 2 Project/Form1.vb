'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim blnPeriod As Boolean
        Dim intIndex As Integer

        blnPeriod = txtMessage.Text.Contains(".")
        lblOne.Text = blnPeriod.ToString

        If blnPeriod = True Then
            intIndex = txtMessage.Text.IndexOf(".")
            lblTwo.Text = intIndex.ToString
        Else
            lblTwo.Text = "N/A"
        End If

    End Sub
End Class
