' Name:         FixIt Project
' Purpose:      Displays the contents of an array in a list box.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays the first and last names in a list box.

        Dim strNames() As String = {{"Mary", "Jones"},
                                     {"Susan", "Washington"},
                                     {"Carol", "O'Brien"},
                                     {"Jacob", "Harper"},
                                     {"Sandy", "Washington"}}

        ' Clear list box and then display first and last names separated by a space.
        lstNames.Items.Clear()
        For intX As Integer = 1 To strNames.GetUpperBound(0)
            lstNames.Items.Add(strNames(0, intX) & " " & strNames(1, intX))
        Next intX
    End Sub
End Class
