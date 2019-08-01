'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private intTotalScore As Double
    Private intNumberOfScores As Double

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intScore As Integer = 0 To 10
            lstScores.Items.Add(intScore)
        Next intScore
        lstScores.SelectedItem = 8
    End Sub

    Private Sub btnRecordScore_Click(sender As Object, e As EventArgs) Handles btnRecordScore.Click
        'Static intTotalScore As Integer
        'Static intNumberOfScores As Integer
        Dim dblAverageScore As Double
        Dim intScore As Integer

        Integer.TryParse(lstScores.SelectedItem.ToString, intScore)

        intTotalScore += intScore
        lblTotalScore.Text = intTotalScore.ToString
        intNumberOfScores += 1
        lblNumOfScores.Text = intNumberOfScores.ToString
        dblAverageScore = intTotalScore / intNumberOfScores
        lblAverageScore.Text = dblAverageScore.ToString("N1")



    End Sub

    Private Sub btnNewSkater_Click(sender As Object, e As EventArgs) Handles btnNewSkater.Click
        lblAverageScore.Text = String.Empty
        lblNumOfScores.Text = String.Empty
        lblTotalScore.Text = String.Empty

        intTotalScore = 0
        intNumberOfScores = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
