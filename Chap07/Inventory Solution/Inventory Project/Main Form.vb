'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add an inventory number to a list box.

        Dim strNumber As String

        strNumber = txtNumber.Text.ToUpper.Trim
        If strNumber Like "[A-Z][A-Z][A-Z]##" Then
            lstNumbers.Items.Add(strNumber)
        Else
            MessageBox.Show("Incorrect inventory number.",
                            "Inventory", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
