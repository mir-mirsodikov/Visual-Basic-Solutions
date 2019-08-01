Option Explicit On
Option Infer Off
Option Strict On
'Mukhammad Mirsodikov - P3

Imports System.ComponentModel

Public Class frmMain
    Dim intChange As Integer

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim strSelection As String

        strSelection = lstNeed.SelectedItem.ToString
        lstNeed.Items.Remove(strSelection)
        lstVisited.Items.Add(strSelection)
        lstNeed.SelectedIndex = 0

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader

        If IO.File.Exists("NeedToVisit.txt") Then
            inFile = IO.File.OpenText("NeedToVisit.txt")
            Do Until inFile.Peek = -1
                lstNeed.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
            lstNeed.SelectedIndex = 0
        Else
            MessageBox.Show("Unable to locate file.", "Vacation Destinations", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IO.File.Exists("Visited.txt") Then
            inFile = IO.File.OpenText("Visited.txt")
            Do Until inFile.Peek = -1
                lstVisited.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Unable to locate file.", "Vacation Destinations", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        intChange = lstVisited.Items.Count - 1

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim dlgButton As DialogResult
        Dim outFile As IO.StreamWriter

        If lstVisited.Items.Count - 1 > intChange Then
            dlgButton = MessageBox.Show("Do you want to save changes?", "Vacation Destinations", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgButton = DialogResult.Yes Then
                If IO.File.Exists("NeedToVisit.txt") Then
                    outFile = IO.File.CreateText("NeedToVisit.txt")
                    For intSub As Integer = 0 To lstNeed.Items.Count - 1
                        outFile.WriteLine(lstNeed.Items(intSub))
                    Next
                    outFile.Close()
                End If

                If IO.File.Exists("Visited.txt") Then
                    outFile = IO.File.CreateText("Visited.txt")
                    For intSub As Integer = 0 To lstVisited.Items.Count - 1
                        outFile.WriteLine(lstVisited.Items(intSub))
                    Next
                    outFile.Close()
                End If
            End If
        End If

    End Sub
End Class
