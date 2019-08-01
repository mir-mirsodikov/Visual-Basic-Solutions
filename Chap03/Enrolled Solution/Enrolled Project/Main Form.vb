'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private intTotal As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtNumEnrolled.TextChanged
        lblTotalEnrolled.Text = String.Empty

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim intStudents As Integer

        Integer.TryParse(txtNumEnrolled.Text, intStudents)

        intTotal = intTotal + intStudents

        lblTotalEnrolled.Text = intTotal.ToString
    End Sub

    Private Sub txtNumEnrolled_Enter(sender As Object, e As EventArgs) Handles txtNumEnrolled.Enter
        txtNumEnrolled.SelectAll()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
