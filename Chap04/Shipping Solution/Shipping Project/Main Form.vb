'Mukhammad Mirsodikov

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Determine and display the shipping charge.

        Dim intShipping As Integer

        If txtCode.Text.Trim.ToUpper = "FREESHIP" Then
            intShipping = 0
        Else
            intShipping = 5
        End If

        lblShipping.Text = intShipping.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        lblShipping.Text = String.Empty
    End Sub
End Class
