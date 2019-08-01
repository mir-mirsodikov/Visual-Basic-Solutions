' Mukhammad Mirsodikov - P5 

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Class-level named constant.
    Private Const dblPI As Double = 3.14159

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the circle's area.

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
End Class
