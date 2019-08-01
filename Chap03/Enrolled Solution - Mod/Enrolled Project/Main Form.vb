'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtNumEnrolled.TextChanged
        lblTotalEnrolled.Text = String.Empty

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim intStudents As Integer
        Static intTotal As Integer

        Integer.TryParse(txtNumEnrolled.Text, intStudents)

        intTotal = intTotal + intStudents

        lblTotalEnrolled.Text = intTotal.ToString
    End Sub

    Private Sub txtNumEnrolled_Enter(sender As Object, e As EventArgs) Handles txtNumEnrolled.Enter
        txtNumEnrolled.SelectAll()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
