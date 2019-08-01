'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dblTwin As Double
        Dim dblFull As Double
        Dim dblQueen As Double
        Dim dblKing As Double
        Dim dblCost As Double

        dblTwin = 39.99
        dblFull = 49.99
        dblQueen = 49.99
        dblKing = 69.99

        If radTwin.Checked = True Then
            dblCost += dblTwin
        ElseIf radFull.Checked = True Then
            dblCost += dblFull
        ElseIf radQueen.Checked = True Then
            dblCost += dblQueen
        ElseIf radKing.Checked = True Then
            dblCost += dblKing
        End If

        If chkShipping.Checked = False Then
            dblCost += 5
        End If

        lblCost.Text = dblCost.ToString("C2")
    End Sub

    Private Sub radTwin_CheckedChanged(sender As Object, e As EventArgs) Handles radTwin.CheckedChanged
        lblCost.Text = String.Empty
    End Sub

    Private Sub radFull_CheckedChanged(sender As Object, e As EventArgs) Handles radFull.CheckedChanged
        lblCost.Text = String.Empty
    End Sub

    Private Sub radQueen_CheckedChanged(sender As Object, e As EventArgs) Handles radQueen.CheckedChanged
        lblCost.Text = String.Empty
    End Sub

    Private Sub radKing_CheckedChanged(sender As Object, e As EventArgs) Handles radKing.CheckedChanged
        lblCost.Text = String.Empty
    End Sub

    Private Sub chkShipping_CheckedChanged(sender As Object, e As EventArgs) Handles chkShipping.CheckedChanged
        lblCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
