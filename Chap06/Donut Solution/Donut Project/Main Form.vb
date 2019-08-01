'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub Subtotal(ByRef dblPrice As Double)

        Select Case True
            Case radGlazed.Checked OrElse radSugar.Checked
                dblPrice += 1.05
            Case radChocolate.Checked
                dblPrice += 1.25
            Case radFilled.Checked
                dblPrice += 1.5
        End Select

        Select Case True
            Case radNone.Checked
                dblPrice += 0
            Case radRegular.Checked
                dblPrice += 1.5
            Case radCappuccino.Checked
                dblPrice += 2.75
        End Select

    End Sub

    Private Function SalesTax(ByVal dblPrice As Double) As Double
        Dim dblTax As Double
        dblTax = dblPrice * 0.06

        Return dblTax
    End Function
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPrice As Double
        Dim dblSalesTax As Double
        Dim dblTotal As Double

        Subtotal(dblPrice)
        dblSalesTax = SalesTax(dblPrice)
        dblTotal = dblPrice + dblSalesTax
        lblSubtotal.Text = dblPrice.ToString("C2")
        lblTax.Text = dblSalesTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub ClearOutput(sender As Object, e As EventArgs) _
        Handles radGlazed.CheckedChanged, radSugar.CheckedChanged, radChocolate.CheckedChanged, radFilled.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged, radCappuccino.CheckedChanged

        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
