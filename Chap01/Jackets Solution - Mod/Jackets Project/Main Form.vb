'Name:          Jackets Project
'Purpose:       Display size charts
'Programmer:    Mukhammad Mirsodikov on August 23, 2018


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        picChart.Visible = True


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        picJacket.Image = My.Resources.BlueJacket


    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        picJacket.Image = My.Resources.BlackJacket


    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        picJacket.Image = My.Resources.BrownJacket

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        picJacket.Image = My.Resources.RedJacket

    End Sub

    Private Sub picJacket_Click(sender As Object, e As EventArgs) Handles picJacket.Click

    End Sub
End Class
