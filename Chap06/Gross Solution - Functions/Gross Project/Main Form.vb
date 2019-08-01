'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedures.
    Private Function GetWeekly(ByVal intWeekly As Integer) As Double
        Dim dblPay As Double
        dblPay = intWeekly / 52

        Return dblPay
    End Function

    Private Function GetTwicePerMonth(ByVal intTwicePerMonth As Integer) As Double
        Dim dblPay As Double
        dblPay = intTwicePerMonth / 24

        Return dblPay
    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calls independent Sub procedures to calculate and display the gross pay.

        Dim intSalary As Integer
        Dim dblPay As Double

        Integer.TryParse(txtSalary.Text, intSalary)
        If radWeekly.Checked Then
            dblPay = GetWeekly(intSalary)
        Else
            dblPay = GetTwicePerMonth(intSalary)
        End If
        lblGross.Text = dblPay.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_Enter(sender As Object, e As EventArgs) Handles txtSalary.Enter
        txtSalary.SelectAll()
    End Sub

    Private Sub ClearGross(sender As Object, e As EventArgs) Handles txtSalary.TextChanged, radWeekly.CheckedChanged, radTwicePerMonth.CheckedChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        ' Accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
