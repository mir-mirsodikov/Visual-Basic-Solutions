'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill list box with rates and select 3.0 rate.

        For dblRates As Double = 2 To 7 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N1"))
        Next dblRates
        lstRates.SelectedItem = "3.0"

        For intTerm As Integer = 15 To 30 Step 5
            lstTerm.Items.Add(intTerm)
        Next
        lstTerm.SelectedIndex = 1
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the monthly mortgage payment.

        Dim intPrincipal As Integer
        Dim dblRate As Double
        Dim dblPay As Double
        Dim intTerm As Integer

        Integer.TryParse(lstTerm.SelectedItem.ToString, intTerm)
        Integer.TryParse(txtPrincipal.Text, intPrincipal)
        Double.TryParse(lstRates.SelectedItem.ToString, dblRate)
        dblRate /= 100

        lblPay.Text = String.Empty
        For intMonth As Integer = 1 To 1 Step 1
            dblPay = -Financial.Pmt(dblRate / 12,
                                    intTerm * 12, intPrincipal)
            lblPay.Text = lblPay.Text & "Your monthly payment is: " &
                 dblPay.ToString("C2") &
                ControlChars.NewLine
        Next intMonth
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrincipal_Enter(sender As Object, e As EventArgs) Handles txtPrincipal.Enter
        txtPrincipal.SelectAll()
    End Sub

    Private Sub txtPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrincipal.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrincipal_TextChanged(sender As Object, e As EventArgs) Handles txtPrincipal.TextChanged
        lblPay.Text = String.Empty
    End Sub

    Private Sub lstRates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedIndexChanged
        lblPay.Text = String.Empty

    End Sub
End Class
