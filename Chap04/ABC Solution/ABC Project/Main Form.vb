' Name:         ABC Project
' Purpose:      Display the price per item.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display the price per item, which is based on the quantity ordered.

        Dim intQuantity As Integer
        Dim intPrice As Integer

        Integer.TryParse(txtQuantity.Text, intQuantity)
        ' Determine the price per item.

        Select Case intQuantity
            Case 1 To 5
                intPrice = 25
            Case 6 To 10
                intPrice = 23
            Case Is > 10
                intPrice = 2
            Case Else
                intPrice = 0


        End Select



        lblItemPrice.Text = intPrice.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOrdered_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtOrdered_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        lblItemPrice.Text = String.Empty
    End Sub
End Class
