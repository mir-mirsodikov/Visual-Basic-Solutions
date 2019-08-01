'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblIncrease As Double = 0.1
        Dim dblSalesAmount As Double
        Dim dblProjectedSales As Double

        Double.TryParse(txtCurrent.Text, dblSalesAmount)

        dblProjectedSales = (dblIncrease + 1) * dblSalesAmount
        dblSalesAmount = dblSalesAmount * dblIncrease

        lblIncrease.Text = dblSalesAmount.ToString("N2")
        lblProjected.Text = dblProjectedSales.ToString("N2")


    End Sub

    Private Sub txtCurrent_TextChanged(sender As Object, e As EventArgs) Handles txtCurrent.TextChanged
        lblIncrease.Text = String.Empty
        lblProjected.Text = String.Empty
    End Sub

    Private Sub txtCurrent_Enter(sender As Object, e As EventArgs) Handles txtCurrent.Enter
        txtCurrent.SelectAll()

    End Sub
End Class
