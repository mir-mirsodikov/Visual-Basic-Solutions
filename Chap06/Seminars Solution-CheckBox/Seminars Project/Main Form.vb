'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Function CalculateAmount() As Integer
        Dim intTotal As Integer
        If chkFinance.Checked = True Then
            intTotal += 150
        End If

        If chkHealth.Checked = True Then
            intTotal += 125
        End If

        If chkMarketing.Checked = True Then
            intTotal += 135
        End If
        Return intTotal
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the amount due.

        Dim intTotal As Integer

        ' Determine which (if any) check boxes are selected
        ' and add the associated fee to the amount due.

        intTotal = CalculateAmount()

        lblAmountDue.Text = intTotal.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ClearAmountDue(sender As Object, e As EventArgs) _
        Handles chkFinance.CheckedChanged, chkHealth.CheckedChanged, chkMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty

    End Sub

End Class
