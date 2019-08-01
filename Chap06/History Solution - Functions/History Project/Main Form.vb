'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedures.

    Private Function DisplayGrade101(ByVal intPoints As Integer, ByRef strGrade As String) As String

        Select Case intPoints
            Case Is >= 90
                strGrade = "A"
            Case Is >= 80
                strGrade = "B"
            Case Is >= 70
                strGrade = "C"
            Case Is >= 60
                strGrade = "D"
            Case Else
                strGrade = "F"
        End Select

        Return strGrade
    End Function

    Private Function DisplayGrade201(ByVal intPoints As Integer, ByRef strGrade As String) As String

        If intPoints >= 75 Then
            strGrade = "P"
        Else
            strGrade = "F"
        End If
        Return strGrade
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calls independent Sub procedures to display a grade.
        Dim strGrade As String = String.Empty
        Dim intPoints As Integer

        Integer.TryParse(txtPoints.Text, intPoints)


        If radHis101.Checked Then
            DisplayGrade101(intPoints, strGrade)
        Else
            DisplayGrade201(intPoints, strGrade)
        End If

        lblGrade.Text = strGrade.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub ClearGrade(sender As Object, e As EventArgs) Handles txtPoints.TextChanged, radHis101.CheckedChanged, radHis201.CheckedChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
