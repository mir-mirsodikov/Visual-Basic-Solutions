'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblGolf As Double = 30
        Const dblTennis As Double = 25
        Const dblRaquetball As Double = 20

        Dim dblFee As Double
        Dim dblExtra As Double
        Dim dblTotal As Double

        Double.TryParse(txtBasicFee.Text, dblFee)

        If chkGolf.Checked = True Then
            dblExtra += dblGolf
        End If

        If chkTennis.Checked = True Then
            dblExtra += dblTennis
        End If

        If chkRacquetball.Checked = True Then
            dblExtra += dblRaquetball
        End If

        dblTotal = dblExtra + dblFee

        lblAdditional.Text = dblExtra.ToString("C2")
        lblMonthlyDues.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub Changed(sender As Object, e As EventArgs) _
        Handles txtBasicFee.TextChanged, chkGolf.CheckedChanged, chkTennis.CheckedChanged, chkRacquetball.CheckStateChanged

        lblAdditional.Text = String.Empty
        lblMonthlyDues.Text = String.Empty
    End Sub

    Private Sub txtBasicFee_Enter(sender As Object, e As EventArgs) Handles txtBasicFee.Enter
        txtBasicFee.SelectAll()

    End Sub

    Private Sub txtBasicFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBasicFee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
