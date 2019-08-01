'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with values and then selects the first value.

        lstCandy.Items.Add("Choco Bar")
        lstCandy.Items.Add("Choco Bar-Peanuts")
        lstCandy.Items.Add("Kit Kat")
        lstCandy.Items.Add("Peanut Butter Cups")
        lstCandy.Items.Add("Take 5 Bar")
        lstCandy.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Adds the amount sold to the appropriate total.

        ' Declare array and variable.
        Static intCandy(4) As Integer
        Dim intSold As Integer

        Integer.TryParse(txtSold.Text, intSold)
        ' Update array value.
        intCandy(lstCandy.SelectedIndex) += intSold
        ' Display array values.

        lblChocoBar.Text = intCandy(0).ToString
        lblChocoBarPeanuts.Text = intCandy(1).ToString
        lblKitKat.Text = intCandy(2).ToString
        lblPeanutButCups.Text = intCandy(3).ToString
        lblTake5Bar.Text = intCandy(4).ToString
        txtSold.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSold_Enter(sender As Object, e As EventArgs) Handles txtSold.Enter
        txtSold.SelectAll()
    End Sub

    Private Sub txtSold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSold.KeyPress
        ' Accept only numbers, the hyphen, and the Backspace.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearOutput(sender As Object, e As EventArgs) Handles txtSold.TextChanged, lstCandy.SelectedIndexChanged
        lblChocoBar.Text = String.Empty
        lblChocoBarPeanuts.Text = String.Empty
        lblKitKat.Text = String.Empty
        lblPeanutButCups.Text = String.Empty
        lblTake5Bar.Text = String.Empty
    End Sub
End Class
