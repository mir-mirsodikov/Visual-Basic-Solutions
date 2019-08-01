'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with values.

        lstNames.Items.Add("Debbie")
        lstNames.Items.Add("Bill")
        lstNames.Items.Add("Jim")
        lstNames.Items.Add("Ahmad")
        lstNames.Items.Add("Carol")

    End Sub

    Private Sub btnSingle_Click(sender As Object, e As EventArgs) Handles btnSingle.Click
        lblResult.Text = lstNames.SelectedItem.ToString
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        lblResult.Text = String.Empty

        Dim intIndex As Integer

        Do While intIndex < lstNames.SelectedItems.Count
            lblResult.Text = lblResult.Text &
                lstNames.SelectedItems(intIndex).ToString & ControlChars.NewLine
            intIndex += 1
        Loop

    End Sub
End Class
