'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblDRILL_PRICE As Double = 25.99
        Dim dblEmployeeDiscount As Double
        Dim intOrdered As Integer
        Dim dblTotal As Double
        Dim dblShippingFee As Double

        Integer.TryParse(txtOrdered.Text, intOrdered)

        If chkCoupon.Checked = True Then
            dblShippingFee = 4.99
        Else
            dblShippingFee = 9.99
        End If

        If chkDiscount.Checked = True Then
            dblEmployeeDiscount = 0.9
        Else
            dblEmployeeDiscount = 1
        End If

        dblTotal = (intOrdered * dblDRILL_PRICE * dblEmployeeDiscount) + dblShippingFee

        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtOrdered_TextChanged(sender As Object, e As EventArgs) Handles txtOrdered.TextChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub chkDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscount.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub chkCoupon_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoupon.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtOrdered_Enter(sender As Object, e As EventArgs) Handles txtOrdered.Enter
        txtOrdered.SelectAll()

    End Sub
End Class
