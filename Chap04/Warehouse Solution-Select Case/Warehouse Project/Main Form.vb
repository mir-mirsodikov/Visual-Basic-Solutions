' Name:         Warehouse Project
' Purpose:      Displays the warehouse location.
' Programmer:   <your name> on <currrent date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the location of a warehouse. The location
        ' is based on the designation entered by the user.

        Dim strWarehouse As String

        strWarehouse = txtDesignation.Text.Trim.ToUpper
        Select Case strWarehouse
            Case "A"
                lblLocation.Text = "Tennessee"
            Case "B"
                lblLocation.Text = "Kentucky"
            Case "C", "D"
                lblLocation.Text = "Louisiana"
            Case Else
                lblLocation.Text = "N/A"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDesignation_Enter(sender As Object, e As EventArgs) Handles txtDesignation.Enter
        txtDesignation.SelectAll()
    End Sub

    Private Sub txtDesignation_TextChanged(sender As Object, e As EventArgs) Handles txtDesignation.TextChanged
        lblLocation.Text = String.Empty
    End Sub
End Class
