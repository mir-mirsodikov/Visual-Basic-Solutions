' Name:         Colors Project
' Purpose:      Display the Spanish names for the colors.
' Programmer:   <Mukhammad Mirsodikov> on <August 24, 2018>

Public Class frmMain
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        ' Display the Spanish word for blue.
        lblSpanish.BackColor = Color.Blue

        lblSpanish.Text = "Azul"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        lblSpanish.BackColor = Color.Green
        lblSpanish.Text = "Verde"
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        lblSpanish.BackColor = Color.Red
        lblSpanish.Text = "Rojo"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
