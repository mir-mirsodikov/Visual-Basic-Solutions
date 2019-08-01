'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' Displays a multiplication table.
        Dim intNum As Integer
        lblTable.Text = String.Empty
        Integer.TryParse(txtNumber.Text, intNum)

        Dim intMult As Integer = 1
        Do Until intMult > 9
            lblTable.Text = lblTable.Text & intNum & " * " & intMult.ToString & " = " & (intNum * intMult).ToString & ControlChars.NewLine
            intMult += 1
        Loop


    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Displays a multiplication table.
        Dim intNum As Integer
        lblTable.Text = String.Empty
        Integer.TryParse(txtNumber.Text, intNum)

        For intMult As Integer = 1 To 9
            lblTable.Text = lblTable.Text & intNum & " * " & intMult.ToString & " = " & (intNum * intMult).ToString & ControlChars.NewLine
        Next intMult


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
