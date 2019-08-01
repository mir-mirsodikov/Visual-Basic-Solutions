' Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblTax As Double = 0.05
        Dim dblPrice As Double

        Double.TryParse(txtSales.Text, dblPrice)

        Dim dblTotal As Double = dblPrice * (1 + dblTax)
        Dim dblSalesTax As Double = dblPrice * dblTax

        lblTax.Text = dblSalesTax.ToString("N2")
        lblTotal.Text = dblTotal.ToString("C2")



    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()

    End Sub
End Class
