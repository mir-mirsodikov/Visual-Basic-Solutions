' Name:         Months Project
' Purpose:      Displays the contents of an array in a list box.
' Programmer:   <Mukhammad Mirsodikov> on <3/20/19>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display the contents of the array in a list box.

        Dim strMonths(,) As String = {{"Jan", "31"},
                                      {"Feb", "28 or 29"},
                                      {"Mar", "31"},
                                      {"Apr", "30"}}

        lstMonths.Items.Clear()

        For Each strElement As String In strMonths
            lstMonths.Items.Add(strElement)
        Next strElement
    End Sub
End Class
