'Name:          Florist Project
'Purpose:       Display store information.
'Programmer:    Mukhammad Mirsodikov on August 22, 2018



Public Class frmMain
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picHours.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picSign.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picHours.Visible = True



    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picHours.Visible = False



    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
