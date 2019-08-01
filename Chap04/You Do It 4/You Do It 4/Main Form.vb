'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dblInput As Double

        Double.TryParse(txtInput.Text, dblInput)

        If dblInput < 0 OrElse dblInput > 100 Then
            lblOutput.Text = "Invalid Number"
        Else
            lblOutput.Text = "Valid Number"
        End If
    End Sub
End Class
