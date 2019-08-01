'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display the names and number of students earning a specific grade.

        Dim strNames() As String = {"Helen", "Peter", "Yolanda", "Carl", "Jennifer", "Charles", "Addison", "Aiden", "Treyson", "Sydney", "Jacob", "Nancy", "George", "Ursula", "Jack"}
        Dim strGrades() As String = {"A", "B", "B", "A", "D", "F", "A", "B", "A", "B", "F", "C", "C", "B", "D"}
        Dim strScore As String

        strScore = lstGrades.SelectedItem.ToString

        lstNames.Items.Clear()

        For intSub As Integer = 0 To strGrades.GetUpperBound(0)
            If strScore = strGrades(intSub) Then
                lstNames.Items.Add(strNames(intSub))
            End If
        Next

        lblNumber.Text = (lstNames.Items.Count()).ToString


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrades.SelectedIndex = 0
    End Sub

    Private Sub lstGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrades.SelectedIndexChanged
        lstNames.Items.Clear()
        lblNumber.Text = String.Empty

    End Sub
End Class
