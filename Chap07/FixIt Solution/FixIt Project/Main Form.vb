' Name:         Reverse Project
' Purpose:      Reverses the characters in a word.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        ' Displays the characters in reverse order.

        Dim strWord As String
        strWord = txtWord.Text.Trim

        For intIndex As Integer = strWord.Length To 0 Step -1
            lblReverse.Text = lblReverse.Text & strWord.Substring(intIndex)
        Next intIndex
        txtWord.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtWord_Enter(sender As Object, e As EventArgs) Handles txtWord.Enter
        txtWord.SelectAll()
    End Sub

    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        lblReverse.Text = String.Empty
    End Sub
End Class
