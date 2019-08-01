'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays a server's tip.

        ' Declare Decimal variables.

        ' Convert txtBill.Text and txtPercentage.Text to numbers.

        ' Calculate the tip.

        ' Display the tip with a dollar sign and two decimal places.

        Dim dblBill As Double
        Dim dblTip As Double
        Dim dblTotal As Double

        Double.TryParse(txtBill.Text, dblBill)
        Double.TryParse(txtPercentage.Text, dblTip)

        dblTip = dblTip / 100
        dblTotal = dblTip * dblBill
        lblTip.Text = dblTotal.ToString("C2")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtBill_TextChanged(sender As Object, e As EventArgs) Handles txtBill.TextChanged
        lblTip.Text = String.Empty

    End Sub

    Private Sub txtBill_Enter(sender As Object, e As EventArgs) Handles txtBill.Enter
        txtBill.SelectAll()

    End Sub

    Private Sub txtPercentage_TextChanged(sender As Object, e As EventArgs) Handles txtPercentage.TextChanged
        lblTip.Text = String.Empty
    End Sub

    Private Sub txtPercentage_Enter(sender As Object, e As EventArgs) Handles txtPercentage.Enter
        txtPercentage.SelectAll()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
