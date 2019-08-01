'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        lblTax.Text = String.Empty

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblTaxRate As Double = 0.0135
        Dim dblValue As Double

        Double.TryParse(txtAmount.Text, dblValue)

        dblValue = dblValue * dblTaxRate

        lblTax.Text = dblValue.ToString("C2")
    End Sub

    Private Sub txtAmount_Enter(sender As Object, e As EventArgs) Handles txtAmount.Enter
        txtAmount.SelectAll()

    End Sub
End Class
