'Mukhammad Mirsodikov
'Period 5
'Test 1

Public Class frmMain
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picBanana.Visible = True
        lblMessage.Text = "Happy dancing banana!!"
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picBanana.Visible = False
        lblMessage.Text = "Dancing banana, please come back!"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
