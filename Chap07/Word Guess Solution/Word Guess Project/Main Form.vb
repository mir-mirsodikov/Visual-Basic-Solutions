'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnNewWord_Click(sender As Object, e As EventArgs) Handles btnNewWord.Click
        ' Determine whether the word contains five letters.

        If txtWord.Text.Trim.ToUpper Like "[A-Z][A-Z][A-Z][A-Z][A-Z]" Then
            grpWord.Enabled = False
            grpLetter.Enabled = True
            lblResult.Text = "-----"
            txtLetter.Focus()
        Else
            MessageBox.Show("Please enter 5 letters.", "Guess the Word Game",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnTryLetter_Click(sender As Object, e As EventArgs) Handles btnTryLetter.Click
        ' Determine whether player 2 has guessed the word.

        Dim strWord As String
        Dim strLetter As String
        Dim strResult As String

        strWord = txtWord.Text.Trim.ToUpper
        strLetter = txtLetter.Text.Trim.ToUpper
        strResult = lblResult.Text

        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex, 1)
                    strResult = strResult.Insert(intIndex, strLetter)
                End If
            Next intIndex

            ' Display the contents of strResult.
            lblResult.Text = strResult

            ' Determine whether strResult contains any hyphens.
            If strResult.Contains("-") = False Then
                MessageBox.Show("You guessed it: " & strWord, "Guess the Word Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpWord.Enabled = True
                grpLetter.Enabled = False
                lblResult.Text = String.Empty
                txtWord.Focus()

            End If
        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtLetter.Focus()

        txtLetter.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtWord_Enter(sender As Object, e As EventArgs) Handles txtWord.Enter
        txtWord.SelectAll()
    End Sub

    Private Sub txtLetter_Enter(sender As Object, e As EventArgs) Handles txtLetter.Enter
        txtLetter.SelectAll()
    End Sub
End Class
