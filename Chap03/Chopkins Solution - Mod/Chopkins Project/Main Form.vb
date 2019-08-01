'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblTwelvePrice As Double = 14.99
        Const dblFivePrice As Double = 6.99
        Const dblTwoPrice As Double = 2.5
        Dim intTwelveAmount As Integer
        Dim intFiveAmount As Integer
        Dim intTwoAmount As Integer
        Dim dblShipping As Double

        Integer.TryParse(txtTwelve.Text, intTwelveAmount)
        Integer.TryParse(txtFive.Text, intFiveAmount)
        Integer.TryParse(txtTwo.Text, intTwoAmount)
        Double.TryParse(txtShipping.Text, dblShipping)

        Dim intTotalPacks As Integer = intTwelveAmount + intFiveAmount + intTwoAmount

        lblTotalPacks.Text = intTotalPacks.ToString()

        Dim dblTotalPrice As Double = (intTwelveAmount * dblTwelvePrice) + (intFiveAmount * dblFivePrice) + (intTwoAmount * dblTwoPrice) + dblShipping

        lblTotalPrice.Text = dblTotalPrice.ToString("C2")

        Dim dblTwelveTotalPrice As Double = intTwelveAmount * dblTwelvePrice
        Dim dblFiveTotalPrice As Double = intFiveAmount * dblFivePrice
        Dim dblTwoTotalPrice As Double = intTwoAmount * dblTwoPrice
        lblTwelvePrice.Text = dblTwelveTotalPrice.ToString("C2")
        lblFivePrice.Text = dblFiveTotalPrice.ToString("C2")
        lblTwoPrice.Text = dblTwoTotalPrice.ToString("C2")

    End Sub

    Private Sub txtTwelve_TextChanged(sender As Object, e As EventArgs) Handles txtTwelve.TextChanged
        lblTotalPacks.Text = String.Empty
        lblTotalPrice.Text = String.Empty
        lblTwelvePrice.Text = String.Empty
        lblFivePrice.Text = String.Empty
        lblTwoPrice.Text = String.Empty

    End Sub

    Private Sub txtTwelve_Enter(sender As Object, e As EventArgs) Handles txtTwelve.Enter
        txtTwelve.SelectAll()

    End Sub

    Private Sub txtFive_TextChanged(sender As Object, e As EventArgs) Handles txtFive.TextChanged
        lblTotalPacks.Text = String.Empty
        lblTotalPrice.Text = String.Empty
        lblTwelvePrice.Text = String.Empty
        lblFivePrice.Text = String.Empty
        lblTwoPrice.Text = String.Empty
    End Sub

    Private Sub txtFive_Enter(sender As Object, e As EventArgs) Handles txtFive.Enter
        txtFive.SelectAll()

    End Sub

    Private Sub txtTwo_TextChanged(sender As Object, e As EventArgs) Handles txtTwo.TextChanged
        lblTotalPacks.Text = String.Empty
        lblTotalPrice.Text = String.Empty
        lblTwelvePrice.Text = String.Empty
        lblFivePrice.Text = String.Empty
        lblTwoPrice.Text = String.Empty
    End Sub

    Private Sub txtTwo_Enter(sender As Object, e As EventArgs) Handles txtTwo.Enter
        txtTwo.SelectAll()

    End Sub

    Private Sub txtShipping_TextChanged(sender As Object, e As EventArgs) Handles txtShipping.TextChanged
        lblTotalPacks.Text = String.Empty
        lblTotalPrice.Text = String.Empty
        lblTwelvePrice.Text = String.Empty
        lblFivePrice.Text = String.Empty
        lblTwoPrice.Text = String.Empty
    End Sub

    Private Sub txtShipping_Enter(sender As Object, e As EventArgs) Handles txtShipping.Enter
        txtShipping.SelectAll()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
