' Name:         Potter Project
' Purpose:      Displays the selected list box item.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with array values and then selects the first item.

        Dim strNames() As String = {"Harry Potter", "Ron Weasley", "Hermione Granger", "Lord Voldemort", "Albus Dumbledore"}

        For Each strElement As String In strNames
            lstNames.Items.Add(strElement)
        Next strElement
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNames.SelectedIndexChanged
        lblSelection.Text = lstNames.SelectedItem.ToString
    End Sub
End Class
