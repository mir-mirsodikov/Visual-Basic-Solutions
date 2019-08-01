'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTotal_Enter(sender As Object, e As EventArgs) Handles txtTotal.Enter
        txtTotal.SelectAll()
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        ' accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'displays a shipping charge

        Dim dblTotal As Double
        Dim intShipping As Integer

        Double.TryParse(txtTotal.Text, dblTotal)

        Select Case dblTotal
            Case Is < 1
                intShipping = 0
            Case 1 To 99.99
                intShipping = 13
            Case 100 To 500.99
                intShipping = 10
            Case 501 To 1000.99
                intShipping = 7
            Case Is >= 1001
                intShipping = 5
        End Select

        lblShipping.Text = intShipping.ToString("C0")
    End Sub
End Class
