'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblLength As Double
        Dim dblWidth As Double
        Dim dblAreaFeet As Double
        Dim dblAreaYards As Double

        Double.TryParse(txtLength.Text, dblLength)
        Double.TryParse(txtWidth.Text, dblWidth)

        dblAreaFeet = dblLength * dblWidth
        dblAreaYards = (dblLength * dblWidth) / 9

        lblAreaFeet.Text = dblAreaFeet.ToString("N1")
        lblAreaYards.Text = dblAreaYards.ToString("N1")


    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        lblAreaFeet.Text = String.Empty
        lblAreaYards.Text = String.Empty
    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        lblAreaFeet.Text = String.Empty
        lblAreaYards.Text = String.Empty
    End Sub

    Private Sub txtLength_Enter(sender As Object, e As EventArgs) Handles txtLength.Enter
        txtLength.SelectAll()

    End Sub

    Private Sub txtWidth_Enter(sender As Object, e As EventArgs) Handles txtWidth.Enter
        txtWidth.SelectAll()

    End Sub
End Class
