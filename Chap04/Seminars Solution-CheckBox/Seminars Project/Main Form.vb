'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the amount due.

        Dim intAmountDue As Integer

        ' Determine which (if any) check boxes are selected
        ' and add the associated fee to the amount due.
        If chkFinance.Checked = True Then
            intAmountDue = intAmountDue + 150
        End If

        If chkHealth.Checked = True Then
            intAmountDue = intAmountDue + 125
        End If

        If chkMarketing.Checked = True Then
            intAmountDue = intAmountDue + 135
        End If

        lblAmountDue.Text = intAmountDue.ToString("C0")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkFinance_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinance.CheckedChanged
        lblAmountDue.Text = String.Empty
    End Sub

    Private Sub chkHealth_CheckedChanged(sender As Object, e As EventArgs) Handles chkHealth.CheckedChanged
        lblAmountDue.Text = String.Empty
    End Sub

    Private Sub chkMarketing_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty
    End Sub
End Class
