' Name:         ReDim Project
' Purpose:      Add sales to an array and then display the array.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private intSales() As Integer = {}

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Adds a sales amount to the array.

        Static intSub As Integer

        If txtSales.Text <> String.Empty Then
            Integer.TryParse(txtSales.Text, intSales(intSub))
            intSub += 1
        Else
            MessageBox.Show("Please enter a sales amount.", "Sales Listing",
                  MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtSales.Focus()
        txtSales.SelectAll()
        lstSales.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the sales amounts stored in an array.

        lstSales.Items.Clear()
        For intSub As Integer = 0 To intSales.GetUpperBound(0)
            lstSales.Items.Add(intSales(intSub).ToString)
        Next intSub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lstSales.Items.Clear()
    End Sub
End Class
