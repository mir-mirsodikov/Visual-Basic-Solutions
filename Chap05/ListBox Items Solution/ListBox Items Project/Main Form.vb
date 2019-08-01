'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the list box items.

        lstNums.Items.Clear()
        lblItems.Text = String.Empty
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' Display the number of list box items.

        lblItems.Text = lstNums.Items.Count.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add items to the list box and select the first item.

        For intNum As Integer = 1 To 25
            lstNums.Items.Add(intNum)
        Next intNum
        lstNums.SelectedIndex = 0
    End Sub
End Class
