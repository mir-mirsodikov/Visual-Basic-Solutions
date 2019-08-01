'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For dblHours As Double = 20.0 To 50.0 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours
        lstHours.SelectedIndex = 0
        For dblRate As Double = 7.0 To 30.0 Step 0.5
            cboRate.Items.Add(dblRate.ToString("N2"))
        Next dblRate
        cboRate.SelectedIndex = 0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblHours As Double
        Dim dblRate As Double
        Dim dblOvertime As Double
        Dim dblOvertimePay As Double
        Dim dblRegularPay As Double

        Double.TryParse(lstHours.SelectedItem.ToString, dblHours)
        Double.TryParse(cboRate.Text, dblRate)

        'dblRegularPay = dblHours * dblRate
        If dblHours > 40.0 Then
            dblOvertime = (dblHours - 40) * (dblRate * 1.5)
            dblOvertimePay = dblRate * 40 + dblOvertime
            dblRegularPay = 40 * dblRate
        Else
            dblRegularPay = dblRate * dblHours
        End If

        lblRegularPay.Text = dblRegularPay.ToString("c2")
        lblOvertimePay.Text = dblOvertime.ToString("C2")
        lblGrossPay.Text = dblOvertimePay.ToString("C2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblGrossPay.Text = String.Empty
        lblOvertimePay.Text = String.Empty
        lblRegularPay.Text = String.Empty
        lstHours.SelectedIndex = 0
        cboRate.SelectedIndex = 0
    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles lstHours.SelectedIndexChanged, cboRate.SelectedIndexChanged
        lblGrossPay.Text = String.Empty
        lblOvertimePay.Text = String.Empty
        lblRegularPay.Text = String.Empty
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Would you like to close the program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
