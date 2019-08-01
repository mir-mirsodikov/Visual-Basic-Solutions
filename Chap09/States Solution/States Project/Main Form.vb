' Name:         States Project
' Purpose:      Sort the contents of a file and then save to the file.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add file's contents to a list box.

        Dim inFile As IO.StreamReader

        If IO.File.Exists("states.txt") Then
            inFile = IO.File.OpenText("states.txt")
            Do Until inFile.Peek = -1
                lstStates.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Cannot find the file.", "States",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        ' Write the sorted contents of the list box to a file.
        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText("states.txt")
        For intIndex As Integer = 0 To lstStates.Items.Count - 1
            outFile.WriteLine(lstStates.Items(intIndex))
        Next intIndex
        outFile.Close()
        MessageBox.Show("File written succesfully.", "States", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
