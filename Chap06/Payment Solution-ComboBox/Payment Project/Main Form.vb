'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill list box with rates and select 3.0 rate.

        For dblRates As Double = 2 To 7 Step 0.5
            cboRates.Items.Add(dblRates.ToString("N1"))
        Next dblRates
        cboRates.SelectedItem = "3.0"

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the monthly mortgage payment.

        Dim intPrincipal As Integer
        Dim dblRate As Double
        Dim dblPay As Double

        Integer.TryParse(txtPrincipal.Text, intPrincipal)
        Double.TryParse(cboRates.Text, dblRate)
        dblRate = dblRate / 100

        lblPay.Text = String.Empty
        For intTerm As Integer = 15 To 30 Step 5
            dblPay = -Financial.Pmt(dblRate / 12,
                                    intTerm * 12, intPrincipal)
            lblPay.Text = lblPay.Text & intTerm.ToString &
                " years:   " & dblPay.ToString("C2") &
                ControlChars.NewLine
        Next intTerm
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

    Private Sub ClearPay(sender As Object, e As EventArgs) _
        Handles txtPrincipal.TextChanged, cboRates.TextChanged

        lblPay.Text = String.Empty
    End Sub
End Class
