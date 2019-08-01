'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblSalary As Double
        Dim dblNewSalary As Double
        Dim dblSalary2 As Double

        Double.TryParse(txtSalary.Text, dblSalary)

        txtNewSalary.Text = String.Empty
        txtNewSalary.Text = txtNewSalary.Text & "Rate" & ControlChars.Tab & "Year" & ControlChars.Tab &
            "Salary" & ControlChars.NewLine
        For decRate As Double = 0.015D To 0.030000001 Step 0.005
            txtNewSalary.Text = txtNewSalary.Text & decRate.ToString("P1") & ControlChars.NewLine
            dblSalary2 = dblSalary
            For intYear As Integer = 1 To 5
                dblNewSalary = dblSalary2 * (1 + decRate)
                txtNewSalary.Text = txtNewSalary.Text & ControlChars.Tab & intYear.ToString & ControlChars.Tab &
                    dblNewSalary.ToString("C2") & ControlChars.NewLine
                dblSalary2 = dblNewSalary
            Next intYear
        Next decRate
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        txtNewSalary.Text = String.Empty
    End Sub

    Private Sub txtSalary_Enter(sender As Object, e As EventArgs) Handles txtSalary.Enter
        txtSalary.SelectAll()

    End Sub
End Class
