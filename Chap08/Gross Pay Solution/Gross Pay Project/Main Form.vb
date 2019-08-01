'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Selects the first pay code in the list box.

        lstCodes.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearGross(sender As Object, e As EventArgs) Handles lstCodes.SelectedIndexChanged, txtHours.TextChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub txtHours_Enter(sender As Object, e As EventArgs) Handles txtHours.Enter
        txtHours.SelectAll()
    End Sub

    Private Sub txtHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHours.KeyPress
        ' Accept only numbers, the period, and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Dim strPayCode() As String = {"P23", "P56", "F45", "F68", "F96"}
        Dim dblPayRate() As Double = {10.5, 12.5, 14.25, 15.75, 17.65}
        Dim dblGrossPay As Double
        Dim intHours As Integer

        Integer.TryParse(txtHours.Text, intHours)
        dblGrossPay = dblPayRate(lstCodes.SelectedIndex) * intHours
        If intHours > 40 Then
            dblGrossPay = dblPayRate(lstCodes.SelectedIndex) * 40
            dblGrossPay += dblPayRate(lstCodes.SelectedIndex) * 1.5 * (intHours - 40)
        End If


        lblGross.Text = dblGrossPay.ToString("C2")
    End Sub
End Class
