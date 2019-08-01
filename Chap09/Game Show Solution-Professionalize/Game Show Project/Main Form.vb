' Name:         Game Show Project
' Purpose:      Writes names to and read names from a sequential access file.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        ' Writes a name to a sequential access file.

        ' Declare a StreamWriter variable.
        Dim outFile As IO.StreamWriter

        ' Open the file for append.
        outFile = IO.File.AppendText("contestants.txt")

        ' Write the name on a separate line in the file.
        outFile.WriteLine(txtName.Text.Trim)

        ' Close the file.
        outFile.Close()

        ' Clear the Contestants box and then set the focus.
        txtContestants.Text = String.Empty
        txtName.Focus()
        lblMessage.Visible = True
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' Reads names from a sequential access file and displays them in the interface.

        ' Declare variable.
        Dim inFile As IO.StreamReader

        ' Determine whether the file exists.
        If IO.File.Exists("contestants.txt") Then
            ' Open the file for input.
            inFile = IO.File.OpenText("contestants.txt")
            ' Read the file and assign to Contestants box.
            txtContestants.Text = inFile.ReadToEnd
            inFile.Close()
        Else
            MessageBox.Show("Cannot find the file.", "Game Show",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblMessage.Visible = False

    End Sub
End Class
