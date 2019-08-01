'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim dblTotal As Double
        Dim dblUnits As Double
        Dim dblPrice As Double

        Double.TryParse(txtUnits.Text, dblUnits)

        If radWholesaler.Checked = True Then
            Select Case dblUnits
                Case 1 To 50
                    dblPrice = 15
                Case 51 To 150
                    dblPrice = 13
                Case Is > 150
                    dblPrice = 10
            End Select
        ElseIf radRetailer.Checked = True Then
            Select Case dblUnits
                Case 1 To 25
                    dblPrice = 22
                Case Is > 25
                    dblPrice = 18
            End Select
        End If

        dblTotal = dblUnits * dblPrice

        lblTotal.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtUnits_TextChanged(sender As Object, e As EventArgs) Handles txtUnits.TextChanged
        lblTotal.Text = String.Empty

    End Sub

    Private Sub txtUnits_Enter(sender As Object, e As EventArgs) Handles txtUnits.Enter
        txtUnits.SelectAll()

    End Sub

    Private Sub txtUnits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnits.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub radWholesaler_CheckedChanged(sender As Object, e As EventArgs) Handles radWholesaler.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub radRetailer_CheckedChanged(sender As Object, e As EventArgs) Handles radRetailer.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub
End Class
