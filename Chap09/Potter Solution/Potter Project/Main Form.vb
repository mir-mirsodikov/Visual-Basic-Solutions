'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrade.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim inFile As IO.StreamReader
        Dim strGrade As String
        Dim strStudent As String

        lstStudents.Items.Clear()
        strGrade = lstGrade.SelectedItem.ToString

        If IO.File.Exists("NamesAndGrades.txt") Then
            inFile = IO.File.OpenText("NamesAndGrades.txt")
            Do Until inFile.Peek = -1
                strStudent = inFile.ReadLine
                If strGrade = inFile.ReadLine Then
                    lstStudents.Items.Add(strStudent)
                End If
            Loop
        Else
            MessageBox.Show("File could not be found.", "Potter Jr High", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lblNumber.Text = lstStudents.Items.Count.ToString
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstStudents.Items.Clear()
        lblNumber.Text = String.Empty

    End Sub
End Class
