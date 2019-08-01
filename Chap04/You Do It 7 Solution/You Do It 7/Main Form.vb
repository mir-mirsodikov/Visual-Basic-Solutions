'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intAmount As Integer
        Dim intPrice As Integer

        Integer.TryParse(txtAmount.Text, intAmount)

        Select Case intAmount
            Case 1 To 2
                intPrice = 15
            Case 3
                intPrice = 25
            Case 4 To 5
                intPrice = 35
        End Select
        lblPrice.Text = intPrice.ToString("C2")
    End Sub
End Class
