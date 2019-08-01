' Name:         Total Due Project
' Purpose:      Calculate and display the total due.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the total due.

        Const dblUNIT_PRICE As Double = 8.5
        Const dblDISCOUNT_RATE As Double = 0.1
        Dim intPurchased As Integer
        Dim dblTotalDue As Double
        Dim dblDiscount As Double

        Integer.TryParse(txtPurchased.Text, intPurchased)

        dblTotalDue = intPurchased * dblUNIT_PRICE
        ' If the number purchased is at least 5, give the discount.
        If intPurchased >= 5 Then
            dblDiscount = dblTotalDue * dblDISCOUNT_RATE
            dblTotalDue = dblTotalDue - dblDiscount
        End If

        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPurchased_Enter(sender As Object, e As EventArgs) Handles txtPurchased.Enter
        txtPurchased.SelectAll()
    End Sub

    Private Sub txtPurchased_TextChanged(sender As Object, e As EventArgs) Handles txtPurchased.TextChanged
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
