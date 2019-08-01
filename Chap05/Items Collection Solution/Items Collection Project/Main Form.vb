'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with values and then selects the first value.

        lstNames.Items.Add("Jameston, Harry")
        lstNames.Items.Add("Neven, John")
        lstNames.Items.Add("Smith, Mary")
        lstNames.Items.Add("Woods, Janet")
        lstNames.Items.Add("Yardley, Pat")
        lstNames.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' Adds a name at a specified position in the list box.

        lstNames.Items.Insert(3, "Wayne, Bruce")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Removes a specified name from the list box.

        lstNames.Items.Remove("Wayne, Bruce")
    End Sub

    Private Sub btnRemoveAt_Click(sender As Object, e As EventArgs) Handles btnRemoveAt.Click
        ' Removes a name from a specified position in the list box.

        lstNames.Items.RemoveAt(1)
    End Sub
End Class
