'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If radAlabama.Checked = True Then
            lblCapital.Text = "Montgomery"
        ElseIf radCalifornia.Checked = True Then
            lblCapital.Text = "Sacramento"
        ElseIf radDelaware.Checked = True Then
            lblCapital.Text = "Dover"
        ElseIf radFlorida.Checked = True Then
            lblCapital.Text = "Tallahassee"
        ElseIf radGeorgia.Checked = True Then
            lblCapital.Text = "Atlanta"
        End If
    End Sub

    Private Sub radAlabama_CheckedChanged(sender As Object, e As EventArgs) Handles radAlabama.CheckedChanged
        lblCapital.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub radCalifornia_CheckedChanged(sender As Object, e As EventArgs) Handles radCalifornia.CheckedChanged
        lblCapital.Text = String.Empty
    End Sub

    Private Sub radDelaware_CheckedChanged(sender As Object, e As EventArgs) Handles radDelaware.CheckedChanged
        lblCapital.Text = String.Empty

    End Sub

    Private Sub radFlorida_CheckedChanged(sender As Object, e As EventArgs) Handles radFlorida.CheckedChanged
        lblCapital.Text = String.Empty

    End Sub

    Private Sub radGeorgia_CheckedChanged(sender As Object, e As EventArgs) Handles radGeorgia.CheckedChanged
        lblCapital.Text = String.Empty

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
