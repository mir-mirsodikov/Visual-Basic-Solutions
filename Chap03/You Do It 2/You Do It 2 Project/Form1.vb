'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict Off

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Dim dblNum As Double

        Double.TryParse(txtMessage.Text, dblNum)

        dblNum = dblNum / 12

        lblMssage.Text = dblNum.ToString("N2")
    End Sub
End Class
