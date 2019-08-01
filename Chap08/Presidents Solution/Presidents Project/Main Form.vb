' Name:         Presidents Project
' Purpose:      Displays the name of a president's vice president.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' Class-level array.
    Private strVPs() As String = {"John Adams",
                                  "Dan Quayle",
                                  "Albert Gore",
                                  "Richard Cheney",
                                  "Joseph R. Biden",
                                  "Mike Pence"}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill list box with names of presidents and select first name.

        lstPresidents.Items.Add("George Washington")
        lstPresidents.Items.Add("George Bush")
        lstPresidents.Items.Add("Bill Clinton")
        lstPresidents.Items.Add("George W. Bush")
        lstPresidents.Items.Add("Barack Obama")
        lstPresidents.Items.Add("Donald J. Trump")
        lstPresidents.SelectedIndex = 0
    End Sub

    Private Sub lstPresidents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPresidents.SelectedIndexChanged
        ' Display associated name from strVPs array.

        lblVicePres.Text = strVPs(lstPresidents.SelectedIndex)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
