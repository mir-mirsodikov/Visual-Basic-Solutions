'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On



Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Const dblCM_PER_INCH As Double = 2.54
        Const intIN_PER_FEET As Integer = 12
        Const intCM_PER_METER As Integer = 100
        Dim dblCentimeters As Double
        Dim dblInches As Double

        Double.TryParse(txtCentimeters.Text, dblCentimeters)
        Double.TryParse(txtInches.Text, dblInches)

        Dim dblCentimetersToInches As Double = dblCentimeters / dblCM_PER_INCH
        Dim dblCentimertsToFeet As Double = dblCentimetersToInches / intIN_PER_FEET

        lblConvertInches.Text = dblCentimetersToInches.ToString("N2")
        lblConvertFeet.Text = dblCentimertsToFeet.ToString("N2")

        Dim dblInchesInCentimeters As Double = dblInches * dblCM_PER_INCH
        Dim dblInchesInMeters As Double = dblInchesInCentimeters / intCM_PER_METER

        lblConvertCentimeters.Text = dblInchesInCentimeters.ToString("N2")
        lblConvertMeters.Text = dblInchesInMeters.ToString("N2")

    End Sub

    Private Sub txtCentimeters_TextChanged(sender As Object, e As EventArgs) Handles txtCentimeters.TextChanged
        lblConvertFeet.Text = String.Empty
        lblConvertInches.Text = String.Empty

    End Sub

    Private Sub txtCentimeters_Enter(sender As Object, e As EventArgs) Handles txtCentimeters.Enter
        txtCentimeters.SelectAll()

    End Sub

    Private Sub txtInches_TextChanged(sender As Object, e As EventArgs) Handles txtInches.TextChanged
        lblConvertCentimeters.Text = String.Empty
        lblConvertMeters.Text = String.Empty

    End Sub

    Private Sub txtInches_Enter(sender As Object, e As EventArgs) Handles txtInches.Enter
        txtInches.SelectAll()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
