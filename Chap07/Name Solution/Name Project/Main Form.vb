'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        ' Add each character in a string to a list box.

        Dim strName As String

        strName = txtName.Text.Trim
        lstCharacters.Items.Clear()

        For intIndex As Integer = 0 To strName.Length - 1
            lstCharacters.Items.Add(strName(intIndex))
        Next intIndex
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lstCharacters.Items.Clear()
    End Sub
End Class
