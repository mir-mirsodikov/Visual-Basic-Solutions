' Name:         Proper Case Project
' Purpose:      Displays the name using proper case.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strName As String
        Dim strNameFirst As String
        Dim strNameLast As String
        Dim intSpaceIndex As Integer

        strName = txtName.Text.Trim


        If strName.Contains(" ") Then
            intSpaceIndex = strName.IndexOf(" ")
            strNameFirst = strName.Substring(0, intSpaceIndex)
            Do While strName(intSpaceIndex + 1) = " "
                intSpaceIndex = strName.IndexOf(" ", intSpaceIndex + 1)
            Loop
            strNameLast = strName.Substring(intSpaceIndex)

            'strCaptial1 = strNameFirst(0)
            'strCaptial1 = strCaptial1.ToUpper & strNameFirst.Substring(1).ToLower

            strNameFirst = strNameFirst.Substring(0, 1).ToUpper & strNameFirst.Substring(1).ToLower
            ' MessageBox.Show(strNameLast.Substring(1, 1).ToUpper)
            strNameLast = strNameLast.Substring(1, 1).ToUpper & strNameLast.Substring(2).ToLower


            lblName.Text = strNameFirst & " " & strNameLast
        Else
            lblName.Text = strName.Substring(0, 1).ToUpper & strName.Substring(1).ToLower
        End If

    End Sub
End Class
