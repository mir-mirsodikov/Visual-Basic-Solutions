' Name:         Voter Project
' Purpose:      Displays a message indicating whether a person can vote.
'               The message is based on the person's age and registration status.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays a message indicating whether a person can vote.

        Dim intAge As Integer

        Integer.TryParse(txtAge.Text, intAge)
        ' Determine age.
        If intAge < 18 Then
            lblMsg.Text = "You are too young to vote"
        Else
            If txtRegistered.Text.Trim.ToUpper = "Y" Then
                lblMsg.Text = "You can vote"
            Else
                lblMsg.Text = "You must register before you can vote"
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAge_Enter(sender As Object, e As EventArgs) Handles txtAge.Enter
        txtAge.SelectAll()
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub txtRegistered_Enter(sender As Object, e As EventArgs) Handles txtRegistered.Enter
        txtRegistered.SelectAll()
    End Sub

    Private Sub txtRegistered_TextChanged(sender As Object, e As EventArgs) Handles txtRegistered.TextChanged
        lblMsg.Text = String.Empty
    End Sub
End Class
