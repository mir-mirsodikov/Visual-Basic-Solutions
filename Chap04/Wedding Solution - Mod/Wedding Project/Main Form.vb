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
        Dim intBridalParty As Integer
        Dim dblExtraBridal As Double
        Dim intTablesRect As Integer

        Integer.TryParse(txtBridalParty.Text, intBridalParty)
        Integer.TryParse(txtGuests.Text, intGuests)

        dblExtra = intGuests Mod 8

        If dblExtra > 0 AndAlso dblExtra < 8 Then
            dblTables = intGuests \ 8
            dblTables += 1
        Else
            dblTables = intGuests \ 8
        End If

        dblExtraBridal = intBridalParty Mod 10

        If dblExtraBridal > 0 AndAlso dblExtraBridal < 10 Then
            intTablesRect = intBridalParty \ 10
            intTablesRect += 1
        Else
            intTablesRect = intBridalParty \ 10
        End If



        lblRectangle.Text = intTablesRect.ToString("N0")
        lblRound.Text = dblTables.ToString("N0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtGuests_TextChanged(sender As Object, e As EventArgs) Handles txtGuests.TextChanged
        lblRound.Text = String.Empty
        lblRectangle.Text = String.Empty
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

    Private Sub txtBridalParty_TextChanged(sender As Object, e As EventArgs) Handles txtBridalParty.TextChanged
        lblRectangle.Text = String.Empty
        lblRound.Text = String.Empty
    End Sub

    Private Sub txtBridalParty_Enter(sender As Object, e As EventArgs) Handles txtBridalParty.Enter
        txtBridalParty.SelectAll()

    End Sub

    Private Sub txtBridalParty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBridalParty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
