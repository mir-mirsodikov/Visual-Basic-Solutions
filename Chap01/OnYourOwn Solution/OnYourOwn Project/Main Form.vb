'Name: World Cup Finals
'Purpose: Shows the final score for the World Cup over the years
'Programmer: Mukhammad Mirsodikov on August 28, 2018

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picRussia.Click
        picWin.Image = My.Resources.france

        picLose.Image = My.Resources.croatia
        'Displays the flag of the winner and the loser
        lblScore.Text = "France 4 - 2 Croatia"
        picChampions.Image = My.Resources.francewin
        'Displays the score for the final game
        lblInfo.Text = "France are the 2018 World Cup Champions!"
    End Sub

    Private Sub picBrazil_Click(sender As Object, e As EventArgs) Handles picBrazil.Click
        picWin.Image = My.Resources.germany
        picLose.Image = My.Resources.argentina
        lblInfo.Text = "Germany are the 2014 World Cup Champions!"

        lblScore.Text = "Germany 1 - 0 Argentina"
        picChampions.Image = My.Resources.germanywin
    End Sub

    Private Sub picAfrica_Click(sender As Object, e As EventArgs) Handles picAfrica.Click
        picWin.Image = My.Resources.spain
        picLose.Image = My.Resources.netherlands
        lblInfo.Text = "Spain are the 2010 World Cup Champions!"

        lblScore.Text = "Spain 1 - 0 Netherlands"
        picChampions.Image = My.Resources.spainwin
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
