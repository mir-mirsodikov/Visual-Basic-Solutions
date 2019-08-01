'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRate10_Click(sender As Object, e As EventArgs) Handles btnRate10.Click
        ' Calculates and displays a 10% commission.
        Const decRATE10 As Decimal = 0.1D

        ' Declare two procedure-level variables that can
        ' be used only within the btnRate10_Click procedure.
        Dim decSales As Decimal
        Dim decComm10 As Decimal

        ' Convert the txtSales.Text property to Decimal. Store
        ' the result in the procedure-level decSales variable.
        Decimal.TryParse(txtSales.Text, decSales)

        ' Multiply the value in the procedure-level decSales
        ' variable by the Decimal named constant decRATE10. Assign the
        ' result to the procedure-level decComm10 variable.
        decComm10 = decSales * decRATE10

        ' Convert the value in the procedure-level decComm10
        ' variable to String. Assign the result to the
        ' lblCommission.Text property.
        lblCommission.Text = decComm10.ToString("C2")

    End Sub

    Private Sub btnRate8_Click(sender As Object, e As EventArgs) Handles btnRate8.Click
        ' Calculates and displays an 8% commission.
        Const decRATE8 As Decimal = 0.08D

        ' Declare two procedure-level variables that can
        ' be used only within the btnRate8_Click procedure.
        Dim decSales As Decimal
        Dim decComm8 As Decimal

        ' Convert the txtSales.Text property to Decimal. Store
        ' the result in the procedure-level decSales variable.
        Decimal.TryParse(txtSales.Text, decSales)

        ' Multiply the value in the procedure-level decSales
        ' variable by the Decimal named constant decRATE8. Assign the
        ' result to the procedure-level decComm8 variable.
        decComm8 = decSales * decRATE8

        ' Convert the value in the procedure-level decComm8
        ' variable to String. Assign the result to the
        ' lblCommission.Text property.
        lblCommission.Text = decComm8.ToString("C2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
