' Name:         Net Project
' Purpose:      Displays net income or loss.
' Programmer:   <your name> on <currrent date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display net income or net loss.

        Dim decIncome As Decimal
        Dim decExpenses As Decimal
        Dim decNet As Decimal

        Decimal.TryParse(txtIncome.Text, decIncome)
        Decimal.TryParse(txtExpenses.Text, decExpenses)

        decNet = decIncome - decExpenses
        ' Change font color to red if it's a net loss; 
        ' otherwise, change font color to black.
        If decNet < 0 Then
            lblNet.ForeColor = Color.Red
        Else
            lblNet.ForeColor = Color.Black
        End If

        lblNet.Text = decNet.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtExpenses_Enter(sender As Object, e As EventArgs) Handles txtExpenses.Enter
        txtExpenses.SelectAll()
    End Sub

    Private Sub txtExpenses_TextChanged(sender As Object, e As EventArgs) Handles txtExpenses.TextChanged
        lblNet.Text = String.Empty
    End Sub

    Private Sub txtIncome_Enter(sender As Object, e As EventArgs) Handles txtIncome.Enter
        txtIncome.SelectAll()
    End Sub

    Private Sub txtIncome_TextChanged(sender As Object, e As EventArgs) Handles txtIncome.TextChanged
        lblNet.Text = String.Empty
    End Sub
End Class
