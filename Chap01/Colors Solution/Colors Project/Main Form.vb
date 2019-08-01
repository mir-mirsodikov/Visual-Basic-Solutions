' Name:         Colors Project
' Purpose:      Display the Spanish names for the colors.
' Programmer:   <your name> on <current date>

Public Class frmMain
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        ' Display the Spanish word for blue.

        lblSpanish.Text = "Azul"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        lblSpanish.Text = "Verde"
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        lblSpanish.Text = "Rojo"
    End Sub
End Class
