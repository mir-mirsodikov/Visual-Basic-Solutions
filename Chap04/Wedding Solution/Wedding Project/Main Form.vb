'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the number of required tables.
        Dim intGuests As Integer
        Dim dblTables As Double
        Dim dblExtra As Double

        Integer.TryParse(txtGuests.Text, intGuests)

        dblExtra = intGuests Mod 8

        If dblExtra > 0 AndAlso dblExtra < 8 Then
            dblTables = intGuests \ 8
            dblTables += 1
        Else
            dblTables = intGuests \ 8
        End If




        lblRound.Text = dblTables.ToString("N0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtGuests_TextChanged(sender As Object, e As EventArgs) Handles txtGuests.TextChanged
        lblRound.Text = String.Empty
    End Sub

    Private Sub txtGuests_Enter(sender As Object, e As EventArgs) Handles txtGuests.Enter
        txtGuests.SelectAll()

    End Sub

    Private Sub txtGuests_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuests.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
