'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private dblTotal As Double
    Private dblValue As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Double.TryParse(txtNumOrdered.Text, dblValue)

        dblTotal = dblTotal + dblValue

        lblTotal.Text = dblTotal.ToString
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Double.TryParse(txtNumOrdered.Text, dblValue)

        dblTotal = dblTotal - dblValue

        lblTotal.Text = dblTotal.ToString
    End Sub

    Private Sub txtNumOrdered_TextChanged(sender As Object, e As EventArgs) Handles txtNumOrdered.TextChanged
        lblTotal.Text = String.Empty

    End Sub

    Private Sub txtNumOrdered_Enter(sender As Object, e As EventArgs) Handles txtNumOrdered.Enter
        txtNumOrdered.SelectAll()

    End Sub
End Class
