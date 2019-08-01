'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Function GetTotalResidential(ByVal dblPrevious As Double, ByVal dblCurrent As Double, ByVal dblUsage As Double) As Double
        Dim dblTotal As Double

        dblUsage = dblCurrent - dblPrevious

        dblTotal = dblUsage * 0.09
        If dblTotal <= 17.65 Then
            dblTotal = 17.65
        Else
            dblTotal = dblUsage * 0.09
        End If

        Return dblTotal
    End Function

    Private Function GetTotalCommercial(ByVal dblPrevious As Double, ByVal dblCurrent As Double, ByVal dblUsage As Double) As Double
        Dim dblTotal As Double

        dblTotal = dblUsage * 0.11
        If dblTotal <= 21.75 Then
            dblTotal = 21.75
        Else
            dblTotal = dblUsage * 0.11
        End If

        Return dblTotal
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblUsage As Double
        Dim dblTotal As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)

        dblUsage = dblCurrent - dblPrevious
        If dblCurrent >= dblPrevious Then
            If radResidential.Checked Then
                dblTotal = GetTotalResidential(dblPrevious, dblCurrent, dblUsage)
            ElseIf radCommercial.Checked Then
                dblTotal = GetTotalCommercial(dblPrevious, dblCurrent, dblUsage)
            End If

            lblMonthly.Text = dblUsage.ToString("N2")
            lblTotal.Text = dblTotal.ToString("C2")

        Else
            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("You have entered the data incorrectly.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles txtPrevious.TextChanged, txtCurrent.TextChanged, radCommercial.CheckedChanged, radResidential.CheckedChanged

        lblMonthly.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub HighlightAll(sender As Object, e As EventArgs) _
        Handles txtPrevious.Enter, txtCurrent.Enter
        txtPrevious.SelectAll()

    End Sub
End Class
