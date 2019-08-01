' Name:         Paper Project
' Purpose:      Displays the price of an item. 
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Declare parallel arrays.
    Private strIds() As String = {"A45G", "J63Y", "M93K", "C20P", "F77T"}
    Private dblPrices() As Double = {8.99, 12.99, 5.99, 13.5, 7.25}

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' Displays an item's price.

        Dim strSearchId As String
        Dim intSub As Integer

        strSearchId = txtId.Text.Trim.ToUpper

        ' Search the strIds array until the 
        ' end of the array or the ID Is found.
        Do Until intSub = strIds.Length OrElse strIds(intSub) = strSearchId
            intSub += 1
        Loop
        If intSub < strIds.Length Then
            lblPrice.Text = dblPrices(intSub).ToString("C2")
        Else
            MessageBox.Show("ID not found.", "Paper Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub ClearPrice(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblPrice.Text = String.Empty
    End Sub
End Class
