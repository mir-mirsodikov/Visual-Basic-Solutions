Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblInterest As Double

        dblInterest = -Financial.Pmt(0.05 / 12, 3 * 12, 50000)

        lblDisplay.Text = dblInterest.ToString("C2")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
