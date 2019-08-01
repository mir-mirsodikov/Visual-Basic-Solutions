'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intPassing As Integer
        Dim intFailing As Integer

        Integer.TryParse(txtPassing.Text, intPassing)
        Integer.TryParse(txtFailing.Text, intFailing)

        Dim intTotalStudents As Integer = intPassing + intFailing
        Dim dblPassingTotal As Double = intPassing / intTotalStudents
        Dim dblFailingTotal As Double = intFailing / intTotalStudents

        lblPercentPassing.Text = dblPassingTotal.ToString("P2")
        lblPercentFailing.Text = dblFailingTotal.ToString("P2")





    End Sub

    Private Sub txtPassing_TextChanged(sender As Object, e As EventArgs) Handles txtPassing.TextChanged
        lblPercentFailing.Text = String.Empty
        lblPercentPassing.Text = String.Empty
    End Sub

    Private Sub txtPassing_Enter(sender As Object, e As EventArgs) Handles txtPassing.Enter
        txtPassing.SelectAll()

    End Sub

    Private Sub txtFailing_TextChanged(sender As Object, e As EventArgs) Handles txtFailing.TextChanged
        lblPercentFailing.Text = String.Empty
        lblPercentPassing.Text = String.Empty
    End Sub

    Private Sub txtFailing_EnabledChanged(sender As Object, e As EventArgs) Handles txtFailing.EnabledChanged


    End Sub

    Private Sub txtFailing_Enter(sender As Object, e As EventArgs) Handles txtFailing.Enter
        txtFailing.SelectAll()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
