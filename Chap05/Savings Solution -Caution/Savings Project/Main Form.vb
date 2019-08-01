' Name:         Savings Project
' Purpose:      Display a savings account balance
'               for each of 5 years using rates
'               from 3% to 6% in increments of 1%.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate account balances for each of five years
        ' using rates from 3% to 6% in increments of 1%.

        Dim dblDeposit As Double
        Dim dblBalance As Double

        Double.TryParse(txtDeposit.Text, dblDeposit)

        txtBalance.Text = "Rate" & ControlChars.Tab &
            "Year" & ControlChars.Tab & "Balance" &
            ControlChars.NewLine

        ' Calculate and display account balances. 
        For decRate As Decimal = 0.03D To 0.06D Step 0.01D
            txtBalance.Text = txtBalance.Text & decRate.ToString("P0") & ControlChars.NewLine
            For intYear As Integer = 1 To 5
                dblBalance = dblDeposit * (1 + decRate) ^ intYear
                txtBalance.Text = txtBalance.Text &
                    ControlChars.Tab & intYear.ToString &
                    ControlChars.Tab & dblBalance.ToString("C2") &
                    ControlChars.NewLine
            Next intYear
        Next decRate
    End Sub

    Private Sub txtDeposit_Enter(sender As Object, e As EventArgs) Handles txtDeposit.Enter
        txtDeposit.SelectAll()
    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged
        txtBalance.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeposit.KeyPress
        ' Allows the text box to accept only numbers, the period, and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
