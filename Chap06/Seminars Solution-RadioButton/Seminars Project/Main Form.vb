'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub TotalAmount(ByRef intAmountDue As Integer)

        Select Case True
            Case radFinance.Checked
                intAmountDue = 150
            Case radHealth.Checked
                intAmountDue = 125
            Case radMarketing.Checked
                intAmountDue = 135
        End Select

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the amount due.

        Dim intAmountDue As Integer

        ' Determine which radio button is selected  
        ' and assign the associated fee.

        TotalAmount(intAmountDue)


        lblAmountDue.Text = intAmountDue.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearDue(sender As Object, e As EventArgs) _
        Handles radFinance.CheckedChanged, radHealth.CheckedChanged, radMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty
    End Sub
End Class
