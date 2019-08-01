'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        ' Format the net pay.

        Dim decNet As Decimal
        Dim strFormatted As String

        Decimal.TryParse(txtNet.Text, decNet)
        ' Format with two decimal places.
        strFormatted = decNet.ToString("N2")
        ' Pad with asterisks until 10 characters.
        strFormatted = strFormatted.PadLeft(10, "*"c)
        ' Insert a dollar sign at the beginning.
        strFormatted = strFormatted.Insert(0, "$")

        lblFormatted.Text = strFormatted
    End Sub

    Private Sub txtNet_Enter(sender As Object, e As EventArgs) Handles txtNet.Enter
        txtNet.SelectAll()
    End Sub

    Private Sub txtNet_TextChanged(sender As Object, e As EventArgs) Handles txtNet.TextChanged
        lblFormatted.Text = String.Empty
    End Sub
End Class
