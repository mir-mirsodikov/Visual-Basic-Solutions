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
        Dim dblPassingTotal As Double
        Dim dblFailingTotal As Double

        If intTotalStudents = 0 Then
            lblPercentFailing.Text = "0.0%"
            lblPercentPassing.Text = "0.0%"
        Else
            dblPassingTotal = intPassing / intTotalStudents
            dblFailingTotal = intFailing / intTotalStudents
        End If

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

    Private Sub txtPassing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassing.KeyPress
        If (e.KeyChar < "0 " OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFailing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFailing.KeyPress
        If (e.KeyChar < "0 " OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
