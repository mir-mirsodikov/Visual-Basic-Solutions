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
End Class
