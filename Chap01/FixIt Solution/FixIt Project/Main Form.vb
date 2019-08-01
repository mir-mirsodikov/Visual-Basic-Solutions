' Name:         FixIt Project
' Purpose:      Display the picture and price of a parrot.
' Programmer:   <Mukhammad Mirsodikov> on <August 28, 2018>

Public Class frmMain
    Private Sub btnExit_MouseClick(sender As Object, e As MouseEventArgs) Handles btnExit.MouseClick

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display the price.

        lblPrice.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBird.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
