' Name:         Jenko Project
' Purpose:      Displays the total of the sales amounts stored in a two-dimensional array.
' Programmer:   <Mukhammad Mirsodikov> on <3/19/20>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Displays the total sales.
        Dim intSales(,) As Integer = {{1500, 2535}, {2300, 3675}, {1850, 2475}}
        Dim intTotal As Integer

        For Each intElement As Integer In intSales
            intTotal += intElement
        Next intElement
        lblTotal.Text = intTotal.ToString("C0")
    End Sub
End Class
