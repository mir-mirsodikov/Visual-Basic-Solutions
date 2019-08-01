' Name:         Continents Project
' Purpose:      Displays the names of the continents in either ascending or descending order.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' Class-level array and variable.
    Private strContinents() As String = {"North America", "Africa",
        "South America", "Antarctica", "Australia", "Asia", "Europe"}
    Private intLastSub As Integer = strContinents.GetUpperBound(0)

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click
        ' Sorts the array values in ascending order.

        lstContinents.Items.Clear()
        Array.Sort(strContinents)
        For intSub As Integer = 0 To intLastSub
            lstContinents.Items.Add(strContinents(intSub))
        Next intSub
    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        ' Sorts the array values in descending order.

        lstContinents.Items.Clear()
        Array.Sort(strContinents)
        Array.Reverse(strContinents)
        For intSub As Integer = 0 To intLastSub
            lstContinents.Items.Add(strContinents(intSub))
        Next intSub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
