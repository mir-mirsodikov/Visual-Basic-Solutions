'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Class-level variable.
    Private strRandLetter As String

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        ' Select a random letter and prepare for a new game.

        Const strALPHABET As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim randGen As New Random
        Dim intRandNum As Integer

        ' Generate a random number and use it to select a letter.
        intRandNum = randGen.Next(0, 26)
        strRandLetter = strALPHABET(intRandNum)
        ' Clear lblGuesses, enable btnCheck, send focus to txtGuess.
        lblGuesses.Text = String.Empty
        btnCheck.Enabled = True
        btnNewGame.Enabled = False
        txtGuess.Focus()

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' Determine whether the user guessed the random letter.

        Dim strGuess As String

        strGuess = txtGuess.Text.Trim.ToUpper
        ' Display guess in lblGuesses.
        lblGuesses.Text += " " & strGuess

        If strGuess = strRandLetter Then
            MessageBox.Show("You guessed the correct letter: " & strGuess,
                            "Guess a Letter", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            btnCheck.Enabled = False
            btnNewGame.Enabled = True

        Else
            MessageBox.Show("Guess again!", "Guess a Letter",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtGuess.Text = String.Empty
        txtGuess.Focus()

    End Sub

    Private Sub txtGuess_Enter(sender As Object, e As EventArgs) Handles txtGuess.Enter
        txtGuess.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
