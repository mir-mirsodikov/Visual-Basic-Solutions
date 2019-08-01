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


    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText("workers.txt")
        For intIndex As Integer = 0 To lstWorkers.Items.Count - 1
            outFile.WriteLine(lstWorkers.Items(intIndex))
        Next intIndex
        outFile.Close()
        'MessageBox.Show("File written succesfully.", "Restaraunt workers", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
