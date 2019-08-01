'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the number of years 
        ' and the projected sales.

        Const dblGROWTH_RATE As Double = 0.03
        Dim dblSales As Double  ' Used as an accumulator.
        Dim dblIncrease As Double
        Dim intYears As Integer ' Used as a counter.
        Dim dblGoal As Double

        Double.TryParse(txtGoal.Text, dblGoal)
        Double.TryParse(txtCurrentSales.Text, dblSales)
        Do While dblSales > 0 AndAlso dblSales < dblGoal
            dblIncrease = dblSales * dblGROWTH_RATE
            dblSales += dblIncrease
            intYears += 1
        Loop

        lblProjSales.Text = "Projected sales " &
            intYears.ToString & " years from now: " &
            dblSales.ToString("C0")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCurrentSales_Enter(sender As Object, e As EventArgs) Handles txtCurrentSales.Enter
        txtCurrentSales.SelectAll()
    End Sub

    Private Sub Restrict(sender As Object, e As KeyPressEventArgs) _
        Handles txtCurrentSales.KeyPress, txtGoal.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9'") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCurrentSales_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentSales.TextChanged
        lblProjSales.Text = String.Empty
    End Sub

    Private Sub txtGoal_TextChanged(sender As Object, e As EventArgs) Handles txtGoal.TextChanged
        lblProjSales.Text = String.Empty
    End Sub

    Private Sub txtGoal_Enter(sender As Object, e As EventArgs) Handles txtGoal.Enter
        txtGoal.SelectAll()

    End Sub
End Class
