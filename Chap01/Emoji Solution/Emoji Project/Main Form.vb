' Name:         Emoji Project
' Purpose:      Display a message corresponding to an emoji.
' Programmer:   <Mukhammad Mirsodikov> on <August 24, 2018>

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picHappy.Click
        lblMessage.Text = "I am happy"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picCrying.Click
        lblMessage.Text = "I am crying"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picLove.Click
        lblMessage.Text = "I am in love"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picSad.Click
        lblMessage.Text = "I am sad"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picTired.Click
        lblMessage.Text = "I am tired"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
