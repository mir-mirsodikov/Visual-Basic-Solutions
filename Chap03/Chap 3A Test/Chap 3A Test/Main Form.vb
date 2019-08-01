'Mukhammmad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblCOMMISSION As Double = 0.2
        Const intNewYorkPrice As Integer = 25
        Const intMainePrice As Integer = 15
        Const intFloridaPrice As Integer = 20

        Dim intNewYorkSales As Integer
        Dim intMaineSales As Integer
        Dim intFloridaSales As Integer

        Dim intTotal As Integer
        Dim dblCommissionTotal As Double

        Integer.TryParse(txtNewYork.Text, intNewYorkSales)
        Integer.TryParse(txtMaine.Text, intMaineSales)
        Integer.TryParse(txtFlorida.Text, intFloridaSales)

        intTotal = (intNewYorkSales * intNewYorkPrice) + (intMainePrice * intMaineSales) + (intFloridaSales * intFloridaPrice)
        lblTotal.Text = intTotal.ToString("C2")

        dblCommissionTotal = intTotal * dblCOMMISSION
        lblCommission.Text = dblCommissionTotal.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtNewYork_TextChanged(sender As Object, e As EventArgs) Handles txtNewYork.TextChanged
        lblCommission.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtMaine_TextChanged(sender As Object, e As EventArgs) Handles txtMaine.TextChanged
        lblCommission.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtFlorida_TextChanged(sender As Object, e As EventArgs) Handles txtFlorida.TextChanged
        lblCommission.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtNewYork_Enter(sender As Object, e As EventArgs) Handles txtNewYork.Enter
        txtNewYork.SelectAll()

    End Sub

    Private Sub txtMaine_Enter(sender As Object, e As EventArgs) Handles txtMaine.Enter
        txtMaine.SelectAll()

    End Sub

    Private Sub txtFlorida_Enter(sender As Object, e As EventArgs) Handles txtFlorida.Enter
        txtFlorida.SelectAll()

    End Sub
End Class
