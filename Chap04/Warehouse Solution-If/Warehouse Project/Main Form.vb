'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the location of a warehouse. The location
        ' is based on the designation entered by the user.

        Dim strWarehouse As String

        strWarehouse = txtDesignation.Text.Trim.ToUpper
        If strWarehouse = "A" Then
            lblLocation.Text = "Tennessee"
        ElseIf strWarehouse = "B" Then
            lblLocation.Text = "Kentucky"
        ElseIf strWarehouse = "C" OrElse strWarehouse = "D" Then
            lblLocation.Text = "Louisiana"
        Else
            lblLocation.Text = "N/A"
        End If



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
