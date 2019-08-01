'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays the sales tax.

        Dim dblSales As Double
        Dim strRate As String
        Dim dblRate As Double
        Dim dblTax As Double

        Double.TryParse(txtSales.Text, dblSales)

        strRate = lstRates.SelectedItem.ToString.TrimEnd("%"c)
        Double.TryParse(strRate, dblRate)
        dblTax = dblSales * dblRate / 100
        lblTax.Text = dblTax.ToString("C2")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with tax rates.

        For dblRate As Double = 0.02 To 0.04 Step 0.01
            lstRates.Items.Add(dblRate.ToString("P0"))
        Next dblRate
        lstRates.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub ClearTax(sender As Object, e As EventArgs) Handles lstRates.SelectedValueChanged, txtSales.TextChanged
        lblTax.Text = String.Empty
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
