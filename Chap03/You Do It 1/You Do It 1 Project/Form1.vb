'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Dim dblCost As Double

        Double.TryParse(txtMessage.Text, dblCost)

        lblMessage.Text = dblCost.ToString("C2")
    End Sub
End Class
