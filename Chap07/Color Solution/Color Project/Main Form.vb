'Mukhammmad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        lblColor.Text = String.Empty
    End Sub

    Private Sub txtItem_Enter(sender As Object, e As EventArgs) Handles txtItem.Enter
        txtItem.SelectAll()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strWord As String
        Dim strLetter As String
        Dim strColor As String = String.Empty

        If txtItem.Text.Trim.Length = 5 Then
            strWord = txtItem.Text
            strLetter = strWord.Substring(2, 1)

            Select Case strLetter.ToUpper
                Case "B"
                    strColor = "Blue"
                Case "G"
                    strColor = "Green"
                Case "R"
                    strColor = "Red"
                Case "W"
                    strColor = "White"
                Case Else
                    MessageBox.Show("Invalid Value", "Color Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
            lblColor.Text = strColor
            txtItem.Focus()

        Else
            MessageBox.Show("Invalid Value", "Color Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
