' Name:         Seminars Project
' Purpose:      Display the amount due.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the amount due.

        Dim intAmountDue As Integer

        ' Determine which radio button is selected  
        ' and assign the associated fee.
        Select Case True
            Case radFinance.Checked
                intAmountDue = 150
            Case radHealth.Checked
                intAmountDue = 125
            Case radMarketing.Checked
                intAmountDue = 135
        End Select

        lblAmountDue.Text = intAmountDue.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radFinance_CheckedChanged(sender As Object, e As EventArgs) Handles radFinance.CheckedChanged
        lblAmountDue.Text = String.Empty

    End Sub

    Private Sub radHealth_CheckedChanged(sender As Object, e As EventArgs) Handles radHealth.CheckedChanged
        lblAmountDue.Text = String.Empty

    End Sub

    Private Sub radMarketing_CheckedChanged(sender As Object, e As EventArgs) Handles radMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty

    End Sub
End Class
