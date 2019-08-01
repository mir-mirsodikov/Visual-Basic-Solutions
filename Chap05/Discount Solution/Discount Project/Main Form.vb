'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For dblDiscount As Double = 10 To 40 Step 5
            lstDiscount.Items.Add(dblDiscount)
        Next dblDiscount
        lstDiscount.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblItemPrice As Double
        Dim dblDiscountAmount As Double
        Dim dblDiscount As Double
        Dim dblDiscountPrice As Double

        lblDiscountAmount.Text = String.Empty

        Double.TryParse(lstDiscount.SelectedItem.ToString, dblDiscount)
        dblDiscount /= 100
        Double.TryParse(txtPrice.Text, dblItemPrice)

        dblDiscountAmount = dblItemPrice * dblDiscount
        lblDiscountAmount.Text = lblDiscountAmount.Text & dblDiscountAmount.ToString("C2")
        dblDiscountPrice = dblItemPrice - dblDiscountAmount
        lblDiscountPrice.Text = dblDiscountPrice.ToString("C2")
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblDiscountAmount.Text = String.Empty
        lblDiscountPrice.Text = String.Empty
    End Sub

    Private Sub lstDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDiscount.SelectedIndexChanged
        lblDiscountAmount.Text = String.Empty
        lblDiscountPrice.Text = String.Empty
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
