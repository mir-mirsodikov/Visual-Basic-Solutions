'Mukhammad Mirsodikov - P2

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Function procedure.

    Private Function GetDiscount(ByVal intNum As Integer,
                                 ByVal dblBeforeDiscount As Double) As Double
        Dim dblDisc As Double
        Select Case intNum
            Case Is >= 10
                dblDisc = dblBeforeDiscount * 0.1
            Case Is >= 5
                dblDisc = dblBeforeDiscount * 0.05
            Case Else
                dblDisc = 0
        End Select

        Return dblDisc
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display subtotal, discount, and total due.

        Const dblSTANDARD As Double = 62.5
        Const dblVIP As Double = 102.75
        Dim intTickets As Integer
        Dim dblSubtotal As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Integer.TryParse(txtTickets.Text, intTickets)

        ' Calculate the subtotal.
        If radStandard.Checked Then
            dblSubtotal = intTickets * dblSTANDARD
        Else
            dblSubtotal = intTickets * dblVIP
        End If

        ' Use a function to get the discount.
        dblDiscount = GetDiscount(intTickets, dblSubtotal)
        ' Calculate the total due.
        dblSubtotal = Math.Round(dblSubtotal, 2)
        dblDiscount = Math.Round(dblDiscount, 2)
        dblTotalDue = dblSubtotal - dblDiscount

        lblSubtotal.Text = dblSubtotal.ToString("N2")
        lblDiscount.Text = dblDiscount.ToString("N2")
        lblTotalDue.Text = dblTotalDue.ToString("N2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTickets_Enter(sender As Object, e As EventArgs) Handles txtTickets.Enter
        txtTickets.SelectAll()
    End Sub

    Private Sub txtTickets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTickets.KeyPress
        ' Accept only only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtTickets.TextChanged, radStandard.CheckedChanged, radVip.CheckedChanged
        lblSubtotal.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub
End Class
