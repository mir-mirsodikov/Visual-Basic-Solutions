'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        'declare the prices of the meals and deserts
        Const dblMeal1 As Double = 7.29
        Const dblMeal2 As Double = 7.69
        Const dblMeal3 As Double = 8.2
        Const dblDesert As Double = 3.5
        Const dblMealDesert As Double = 3.0
        Const dblNoDesert As Double = 0

        Dim strDiscount As String
        Dim dblTotal As Double

        'write the if statement to determine the price of the meals
        If chkMeal1.Checked Then
            dblTotal += dblMeal1
        End If

        If chkMeal2.Checked Then
            dblTotal += dblMeal2
        End If

        If chkMeal3.Checked Then
            dblTotal += dblMeal3
        End If

        'an if statement that determines whether the desert is $3 or $3.5
        If (chkMeal1.Checked OrElse chkMeal2.Checked OrElse chkMeal3.Checked) AndAlso
        (radTurtle.Checked = True OrElse radDirt.Checked = True OrElse radPBCB.Checked = True) Then
            dblTotal += dblMealDesert
        ElseIf radTurtle.Checked = True OrElse radDirt.Checked = True OrElse radPBCB.Checked = True Then
            dblTotal += dblDesert
        ElseIf radNoDesert.Checked = True Then
            dblTotal += dblNoDesert
        End If

        'thiis is a discount code that gives the customer a %10 discount when using the word "TURTLE"
        strDiscount = txtDiscount.Text.ToUpper.Trim
        If strDiscount = "TURTLE" Then
            dblTotal *= 0.9
        End If

        lblTotal.Text = dblTotal.ToString("C2")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub chkMeal1_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeal1.CheckedChanged
        lblTotal.Text = String.Empty

    End Sub

    Private Sub chkMeal2_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeal2.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub chkMeal3_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeal3.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub radTurtle_CheckedChanged(sender As Object, e As EventArgs) Handles radTurtle.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub radDirt_CheckedChanged(sender As Object, e As EventArgs) Handles radDirt.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub radPBCB_CheckedChanged(sender As Object, e As EventArgs) Handles radPBCB.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        lblTotal.Text = String.Empty
    End Sub

    Private Sub txtDiscount_Enter(sender As Object, e As EventArgs) Handles txtDiscount.Enter
        txtDiscount.SelectAll()

    End Sub

    Private Sub radNoDesert_CheckedChanged(sender As Object, e As EventArgs) Handles radNoDesert.CheckedChanged
        lblTotal.Text = String.Empty
    End Sub
End Class
