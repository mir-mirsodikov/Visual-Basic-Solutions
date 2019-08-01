'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Create a password.

        Const strALPHABET As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim intNum As Integer
        Dim strWords As String
        Dim strPassword As String
        Dim intSpaceIndex As Integer

        strWords = txtWords.Text.Trim

        If strWords <> String.Empty Then
            ' Assign the first character as the password.
            strPassword = strWords(0)
            intNum = strALPHABET.IndexOf(strWords.Substring(0, 1).ToUpper)
            intNum += 1
            ' Search for the first space in the input.
            intSpaceIndex = strWords.IndexOf(" ")
            Do Until intSpaceIndex = -1
                ' Concatenate the character that follows 
                ' the space to the password.
                strPassword = strPassword & strWords(intSpaceIndex + 1)
                ' Search for the next space.
                intSpaceIndex = strWords.IndexOf(" ", intSpaceIndex + 1)
            Loop

            ' Insert the number after the first character. 
            strPassword = strPassword.Insert(strPassword.Length, intNum.ToString)
            ' Display the final password.
            lblPassword.Text = strPassword
        End If
    End Sub

    Private Sub txtWords_Enter(sender As Object, e As EventArgs) Handles txtWords.Enter
        txtWords.SelectAll()
    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        lblPassword.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
