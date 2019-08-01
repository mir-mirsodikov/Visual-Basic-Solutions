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
        Dim intMins() As Integer = {465, 415, 350, 300, 0}
        Dim strGrade() As String = {"A", "B", "C", "D", "F"}
        Dim intPoints As Integer
        Dim intIndex As Integer

        Integer.TryParse(txtPoints.Text, intPoints)

        If intPoints <= 500 Then
            Do Until intIndex > intMins.GetUpperBound(0) OrElse intPoints >= intMins(intIndex)
                intIndex += 1
            Loop

            If intIndex <= intMins.GetUpperBound(0) Then
                lblGrade.Text = strGrade(intIndex)
            End If
        Else
            MessageBox.Show("Invalid Input", "Prefessor Schneider", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblGrade.Text = "N/A"
        End If

        txtPoints.Focus()
        txtPoints.SelectAll()


    End Sub
End Class
