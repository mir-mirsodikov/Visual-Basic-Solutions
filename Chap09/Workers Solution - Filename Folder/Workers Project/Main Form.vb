Option Explicit On
Option Strict On
Option Infer Off
' Name:         Workers Project
' Purpose:      Saves worker names to a sequential access files.
' Programmer:   Mukhammad Mirsodikov

Imports System.ComponentModel

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstWorkers.Items.Add(txtName.Text)
        txtName.Focus()
        txtName.SelectAll()


    End Sub

    Private Sub WriteFile(ByVal strFilename As String)
        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText(strFilename)
        For intSub As Integer = 0 To lstWorkers.Items.Count - 1
            outFile.WriteLine(lstWorkers.Items(intSub))
        Next
        outFile.Close()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim strFilename As String
        Dim dlgButton As DialogResult

        strFilename = txtFilename.Text
        strFilename = strFilename + ".txt"

        If IO.File.Exists(strFilename) = False Then
            WriteFile(strFilename)
        Else
            dlgButton = MessageBox.Show("Replace existing file before exiting?", "Restaraunt workers", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If dlgButton = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf dlgButton = DialogResult.Yes Then
                WriteFile(strFilename)
            End If
        End If

        If txtFilename.Text = String.Empty Then
            MessageBox.Show("Please provide a filename.", "Restaraunt workers", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If


    End Sub

    Private Sub txtFilename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilename.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso
            (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
