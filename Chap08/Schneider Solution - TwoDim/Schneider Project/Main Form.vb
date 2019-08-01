'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPoints_TextChanged(sender As Object, e As EventArgs) Handles txtPoints.TextChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strGradeInfo(,) As String = {{"465", "A"}, {"415", "B"}, {"350", "C"}, {"300", "D"}, {"0", "F"}}
        Dim intPoints As Integer
        Dim intScore As Integer
        Dim intRows As Integer

        Integer.TryParse(txtPoints.Text, intPoints)

        If intPoints <= 500 Then
            intRows = 0
            Integer.TryParse(strGradeInfo(intRows, 0).ToString, intScore)
            Do Until intRows > strGradeInfo.GetUpperBound(0) OrElse intPoints >= intScore
                intRows += 1
                Integer.TryParse(strGradeInfo(intRows, 0).ToString, intScore)
            Loop

            If intRows <= strGradeInfo.GetUpperBound(0) Then
                lblGrade.Text = strGradeInfo(intRows, 1)
            End If
        Else
            MessageBox.Show("Professor Schneider", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblGrade.Text = "N/A"
        End If

        txtPoints.Focus()
        txtPoints.SelectAll()


    End Sub
End Class
