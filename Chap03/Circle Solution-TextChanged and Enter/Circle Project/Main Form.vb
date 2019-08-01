'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the circle's area.

        Const dblPI As Double = 3.14159
        Dim dblRadius As Double
        Dim dblArea As Double

        Double.TryParse(txtRadius.Text, dblRadius)
        dblArea = dblPI * dblRadius ^ 2
        lblArea.Text = dblArea.ToString("N2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        lblArea.Text = String.Empty
    End Sub

    Private Sub txtRadius_Enter(sender As Object, e As EventArgs) Handles txtRadius.Enter
        txtRadius.SelectAll()

    End Sub
End Class
