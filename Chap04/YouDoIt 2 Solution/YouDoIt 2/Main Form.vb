'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblAnswer As Double

        Double.TryParse(txtNum1.Text, dblNum1)
        Double.TryParse(txtNum2.Text, dblNum2)

        'dblAnswer = dblNum1 / dblNum2

        If dblNum2 = 0 Then
            lblOutput.Text = "N/A"
        Else
            dblAnswer = dblNum1 / dblNum2
            lblOutput.Text = dblAnswer.ToString("N2")
        End If

        dblAnswer = dblNum1 / dblNum2

        'lblOutput.Text = dblAnswer.ToString("N2")
    End Sub
End Class
