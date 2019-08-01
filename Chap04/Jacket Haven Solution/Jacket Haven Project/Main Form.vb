'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblPriceBlack As Double = 45.99
        Const dblPriceNavy As Double = 39.99
        Const dblPriceRed As Double = 39.99

        Dim intBlack As Integer
        Dim intNavy As Integer
        Dim intRed As Integer
        Dim dblTotalPrice As Double
        Dim intTotalOrdered As Integer

        Dim dblBlackCost As Double
        Dim dblNavyCost As Double
        Dim dblRedCost As Double

        Integer.TryParse(txtBlack.Text, intBlack)
        Integer.TryParse(txtNavy.Text, intNavy)
        Integer.TryParse(txtRed.Text, intRed)

        dblBlackCost = intBlack * dblPriceBlack
        dblNavyCost = intNavy * dblPriceNavy
        dblRedCost = intRed * dblPriceRed

        intTotalOrdered = intBlack + intNavy + intRed
        dblTotalPrice = (dblBlackCost + dblNavyCost + dblRedCost)

        If chkCredit.Checked = True Then
            dblTotalPrice *= 0.9
        End If

        If chkCredit.Checked = False AndAlso intTotalOrdered >= 2 Then
            dblTotalPrice *= 0.95
        End If

        lblOrdered.Text = intTotalOrdered.ToString("N0")
        lblTotal.Text = dblTotalPrice.ToString("C2")


    End Sub

    Private Sub txtBlack_TextChanged(sender As Object, e As EventArgs) Handles txtBlack.TextChanged
        lblTotal.Text = String.Empty
        lblOrdered.Text = String.Empty
    End Sub

    Private Sub txtNavy_TextChanged(sender As Object, e As EventArgs) Handles txtNavy.TextChanged
        lblTotal.Text = String.Empty
        lblOrdered.Text = String.Empty
    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        lblTotal.Text = String.Empty
        lblOrdered.Text = String.Empty
    End Sub

    Private Sub chkCredit_CheckedChanged(sender As Object, e As EventArgs) Handles chkCredit.CheckedChanged
        lblTotal.Text = String.Empty
        lblOrdered.Text = String.Empty
    End Sub

    Private Sub txtBlack_Enter(sender As Object, e As EventArgs) Handles txtBlack.Enter
        txtBlack.SelectAll()

    End Sub

    Private Sub txtNavy_Enter(sender As Object, e As EventArgs) Handles txtNavy.Enter
        txtNavy.SelectAll()

    End Sub

    Private Sub txtRed_Enter(sender As Object, e As EventArgs) Handles txtRed.Enter
        txtRed.SelectAll()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
