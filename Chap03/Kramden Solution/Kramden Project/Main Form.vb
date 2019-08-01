'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intPeople As Integer
        Dim dblAllowance As Double

        Integer.TryParse(txtPeople.Text, intPeople)
        Double.TryParse(txtAllowance.Text, dblAllowance)

        Dim dblTotal As Double = intPeople * dblAllowance

        lblCost.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub txtPeople_TextChanged(sender As Object, e As EventArgs) Handles txtPeople.TextChanged
        lblCost.Text = String.Empty

    End Sub

    Private Sub txtPeople_Enter(sender As Object, e As EventArgs) Handles txtPeople.Enter
        txtPeople.SelectAll()

    End Sub

    Private Sub txtAllowance_TextChanged(sender As Object, e As EventArgs) Handles txtAllowance.TextChanged
        lblCost.Text = String.Empty

    End Sub

    Private Sub txtAllowance_Enter(sender As Object, e As EventArgs) Handles txtAllowance.Enter
        txtAllowance.SelectAll()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
