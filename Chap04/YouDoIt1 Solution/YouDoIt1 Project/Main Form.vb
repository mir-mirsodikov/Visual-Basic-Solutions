'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblInput As Double

        Double.TryParse(txtInput.Text, dblInput)

        If dblInput > 100 Then
            dblInput = dblInput * 5
        Else
            dblInput = dblInput / 5
        End If
        lblOutput.Text = dblInput.ToString("N2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
