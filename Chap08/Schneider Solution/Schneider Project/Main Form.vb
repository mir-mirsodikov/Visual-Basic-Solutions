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
        Dim intMins() As Integer = {0, 300, 350, 415, 465}
        Dim strGrade() As String = {"F", "D", "C", "B", "A"}
        Dim intPoints As Integer

        Integer.TryParse(txtPoints.Text, intPoints)

        If intPoints <= 500 Then
            For intSub As Integer = 0 To intMins.GetUpperBound(0)
                If intPoints > intMins(4) Then
                    lblGrade.Text = strGrade(4)
                ElseIf intPoints > intMins(intSub) AndAlso intPoints < intMins(intSub + 1) Then
                    lblGrade.Text = strGrade(intSub)
                ElseIf intPoints = intMins(intSub) Then
                    lblGrade.Text = strGrade(intSub)
                End If
            Next intSub
        Else
            MessageBox.Show("Invalid Input", "Prefessor Schneider", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblGrade.Text = "N/A"
        End If

        txtPoints.Focus()
        txtPoints.SelectAll()


    End Sub
End Class
