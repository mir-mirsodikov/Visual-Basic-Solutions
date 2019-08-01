'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate account balances for each of five years
        ' using rates from 3% to 7% in increments of 1%.

        Dim dblDeposit As Double
        Dim dblBalance As Double

        Double.TryParse(txtDeposit.Text, dblDeposit)

        txtBalance.Text = "Rate" & ControlChars.Tab &
            "Year" & ControlChars.Tab & "Balance" &
            ControlChars.NewLine

        ' Calculate and display account balances. 
        For intYear As Integer = 1 To 5
            txtBalance.Text = txtBalance.Text & intYear.ToString & ControlChars.NewLine
            For dblRate As Double = 0.03 To 0.07 Step 0.01
                dblBalance = dblDeposit * (1 + dblRate) ^ intYear
                txtBalance.Text = txtBalance.Text &
                    ControlChars.Tab & dblRate.ToString("P0") &
                    ControlChars.Tab & dblBalance.ToString("C2") &
                    ControlChars.NewLine
            Next dblRate
        Next intYear
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
