'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        lblFiveIncrease.Text = String.Empty
        lblFive.Text = String.Empty
        lblEight.Text = String.Empty
        lblEightIncrease.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblFive As Double = 0.05
        Const dblEight As Double = 0.08
        Dim dblFiveSalary As Double
        Dim dblEightSalary As Double
        Dim dblFiveIncrease As Double
        Dim dblEightIncrease As Double
        Dim dblSalary As Double

        Double.TryParse(txtSalary.Text, dblSalary)

        dblFiveSalary = dblFive * dblSalary
        dblEightSalary = dblEight * dblSalary

        dblFiveIncrease = dblFiveSalary + dblSalary
        dblEightIncrease = dblEightSalary + dblSalary

        lblFive.Text = dblFiveSalary.ToString("C2")
        lblEight.Text = dblEightSalary.ToString("C2")

        lblFiveIncrease.Text = dblFiveIncrease.ToString("C2")
        lblEightIncrease.Text = dblEightIncrease.ToString("C2")




    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblFiveIncrease.Text = String.Empty
        lblFive.Text = String.Empty
        lblEight.Text = String.Empty
        lblEightIncrease.Text = String.Empty
        txtSalary.Text = String.Empty
    End Sub

    Private Sub txtSalary_Enter(sender As Object, e As EventArgs) Handles txtSalary.Enter
        txtSalary.SelectAll()

    End Sub
End Class
