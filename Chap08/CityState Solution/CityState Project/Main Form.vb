'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the contents of the arrays using this format: city, state.
        Dim strStates() As String = {"Alabama", "Alaska", "Arizona", "Arkansas", "California"}
        Dim strCities() As String = {"Montgomery", "Juneau", "Phoenix", "Little Rock", "Sacramento"}

        lstCitiesAndStates.Items.Clear()

        For intSub As Integer = 0 To strStates.GetUpperBound(0)
            lstCitiesAndStates.Items.Add(strCities(intSub) & ", " & strStates(intSub))
        Next
    End Sub
End Class
