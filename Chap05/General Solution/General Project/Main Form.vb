'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private dblTotal As Double

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblPrice As Double
        'Static dblTotal As Double


        Double.TryParse(txtPrice.Text, dblPrice)

        txtEntered.Text = txtEntered.Text & dblPrice.ToString & ControlChars.NewLine

        dblTotal = (dblPrice * 1.03) + dblTotal

        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dblTotal = 0

        txtEntered.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
