'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnAndAlso_Click(sender As Object, e As EventArgs) Handles btnAndAlso.Click
        ' Calculate and display weekly gross pay.

        Dim dblHours As Double
        Dim dblRate As Double
        Dim dblGross As Double

        Double.TryParse(txtHours.Text, dblHours)
        Double.TryParse(txtRate.Text, dblRate)

        If dblHours > 0 AndAlso dblHours <= 40 Then
            dblGross = dblHours * dblRate
            lblGross.Text = dblGross.ToString("C2")
        Else
            lblGross.Text = "N/A"
        End If
    End Sub

    Private Sub btnOrElse_Click(sender As Object, e As EventArgs) Handles btnOrElse.Click
        ' Calculate and display weekly gross pay.

        Dim dblHours As Double
        Dim dblRate As Double
        Dim dblGross As Double

        Double.TryParse(txtHours.Text, dblHours)
        Double.TryParse(txtRate.Text, dblRate)

        If dblHours <= 0 OrElse dblHours > 40 Then
            lblGross.Text = "N/A"
        Else
            dblGross = dblHours * dblRate
            lblGross.Text = dblGross.ToString("C2")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_Enter(sender As Object, e As EventArgs) Handles txtHours.Enter
        txtHours.SelectAll()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        lblGross.Text = String.Empty
    End Sub
End Class
