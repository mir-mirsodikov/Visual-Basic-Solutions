'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click, btnExit.Click
        Dim dblItem1 As Double
        Dim dblItem2 As Double
        Dim dblTotal As Double
        Dim dblSaving As Double

        Double.TryParse(txtItem1.Text, dblItem1)
        Double.TryParse(txtItem2.Text, dblItem2)

        If dblItem1 > dblItem2 Then
            dblItem2 = dblItem2 * 0.5
            dblSaving = dblItem2
        Else
            dblItem1 = dblItem1 * 0.5
            dblSaving = dblItem1
        End If

        dblTotal = dblItem1 + dblItem2

        lblTotal.Text = dblTotal.ToString("C2")
        lblSaving.Text = dblSaving.ToString("C2")
    End Sub

    Private Sub txtItem1_TextChanged(sender As Object, e As EventArgs) Handles txtItem1.TextChanged
        lblSaving.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtItem2_TextChanged(sender As Object, e As EventArgs) Handles txtItem2.TextChanged
        lblSaving.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtItem1_Enter(sender As Object, e As EventArgs) Handles txtItem1.Enter
        txtItem1.SelectAll()

    End Sub

    Private Sub txtItem2_Enter(sender As Object, e As EventArgs) Handles txtItem2.Enter
        txtItem2.SelectAll()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtItem1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItem2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
