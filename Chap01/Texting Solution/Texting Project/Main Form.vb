'Mukhammad Mirsodikov 
'Period 5

Public Class frmMain


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBff.Click
        lblMeaning.Text = "Best Friends Forever"
    End Sub

    Private Sub picBrb_Click(sender As Object, e As EventArgs) Handles picBrb.Click
        lblMeaning.Text = "Be Right Back"
    End Sub

    Private Sub picIdk_Click(sender As Object, e As EventArgs) Handles picIdk.Click
        lblMeaning.Text = "I Don't Know"
    End Sub

    Private Sub picLol_Click(sender As Object, e As EventArgs) Handles picLol.Click
        lblMeaning.Text = "Laughing Out Loud"
    End Sub

    Private Sub picSry_Click(sender As Object, e As EventArgs) Handles picSry.Click
        lblMeaning.Text = "Sorry"
    End Sub

    Private Sub picXo_Click(sender As Object, e As EventArgs) Handles picXo.Click
        lblMeaning.Text = "Hugs and Kisses"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
