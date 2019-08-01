'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblSales As Double
        Dim dblCommission As Double
        Dim dblAdditional As Double
        Dim dblTotal As Double

        Double.TryParse(txtSales.Text, dblSales)

        Select Case dblSales
            Case 1 To 5999.99
                dblCommission = dblSales * 0.1
            Case 6000 To 29999.99
                dblCommission = ((dblSales - 6000) * 0.13) + 600
            Case Is > 30000
                dblCommission = 3720 + ((dblSales - 30000) * 0.14)
        End Select

        If chk10Years.Checked AndAlso dblSales >= 10000 Then
            dblAdditional += 500
        End If

        If chkTraveling.Checked Then
            dblAdditional += 700
        End If

        dblTotal = dblAdditional + dblCommission

        lblTotal.Text = dblTotal.ToString("C2")
        lblAdditional.Text = dblAdditional.ToString("C2")
        lblCommission.Text = dblCommission.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblTotal.Text = String.Empty
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty

    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()

    End Sub

    Private Sub chk10Years_CheckedChanged(sender As Object, e As EventArgs) Handles chk10Years.CheckedChanged
        lblTotal.Text = String.Empty
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
    End Sub

    Private Sub chkTraveling_CheckedChanged(sender As Object, e As EventArgs) Handles chkTraveling.CheckedChanged
        lblTotal.Text = String.Empty
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
    End Sub
End Class
