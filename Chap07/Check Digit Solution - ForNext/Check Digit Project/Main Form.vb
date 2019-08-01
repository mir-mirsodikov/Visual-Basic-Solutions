'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        ' Assign a check digit to an ISBN.

        Dim strIsbn As String
        Dim intDigit As Integer
        Dim intGrandTotal As Integer
        Dim intRemainder As Integer
        Dim intCheckDigit As Integer

        If txtIsbn.Text.Length = 12 Then
            strIsbn = txtIsbn.Text


            For intTotal As Integer = 0 To 10 Step 2
                Integer.TryParse(strIsbn(intTotal), intDigit)
                intGrandTotal += intDigit
                Integer.TryParse(strIsbn(intTotal + 1), intDigit)
                intGrandTotal += (intDigit * 3)
            Next

            intRemainder = intGrandTotal Mod 10

            If intRemainder <> 0 Then
                intCheckDigit = 10 - intRemainder
            End If

            lblFinalIsbn.Text = strIsbn & intCheckDigit.ToString

        Else
            MessageBox.Show("Please enter 12 numbers.", "Check Digit",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtIsbn_Enter(sender As Object, e As EventArgs) Handles txtIsbn.Enter
        txtIsbn.SelectAll()
    End Sub

    Private Sub txtIsbn_TextChanged(sender As Object, e As EventArgs) Handles txtIsbn.TextChanged
        lblFinalIsbn.Text = String.Empty
    End Sub

    Private Sub txtIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsbn.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
