'Mukhammmad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGetPrice_Click(sender As Object, e As EventArgs) Handles btnGetPrice.Click
        Const dblUltimatePrice As Double = 899.99
        Const dblProfessionalPrice As Double = 599.99
        Const dblStudentPrice As Double = 99.99
        Dim dblDiscountPrice As Double
        Dim dblTotal As Double

        Select Case True
            Case radUltimate.Checked
                dblTotal = dblUltimatePrice
            Case radProfessional.Checked
                dblTotal = dblProfessionalPrice
            Case radStudent.Checked
                dblTotal = dblStudentPrice
        End Select

        If radUltimate.Checked = True AndAlso radDiscountUltimate.Checked = True Then
            dblDiscountPrice = 0.9
        ElseIf radStudent.Checked = True AndAlso radDiscountStudent.Checked = True Then
            dblDiscountPrice = 0.8
        ElseIf radNoDiscount.Checked = True Then
            dblDiscountPrice = 1
        End If

        If (radProfessional.Checked = True AndAlso (radDiscountUltimate.Checked = True OrElse radDiscountStudent.Checked = True)) OrElse
                (radDiscountStudent.Checked = True AndAlso radUltimate.Checked = True) OrElse
                (radDiscountUltimate.Checked = True AndAlso radStudent.Checked = True) Then
            lblPrice.Text = "The discount is not applicable"
        Else
            dblTotal *= dblDiscountPrice

            lblPrice.Text = dblTotal.ToString("C2")
        End If



    End Sub

    Private Sub radUltimate_CheckedChanged(sender As Object, e As EventArgs) Handles radUltimate.CheckedChanged
        lblPrice.Text = String.Empty
    End Sub

    Private Sub radProfessional_CheckedChanged(sender As Object, e As EventArgs) Handles radProfessional.CheckedChanged
        lblPrice.Text = String.Empty

    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        lblPrice.Text = String.Empty

    End Sub

    Private Sub radNoDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radNoDiscount.CheckedChanged
        lblPrice.Text = String.Empty

    End Sub

    Private Sub radDiscountUltimate_CheckedChanged(sender As Object, e As EventArgs) Handles radDiscountUltimate.CheckedChanged
        lblPrice.Text = String.Empty

    End Sub

    Private Sub radDiscountStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radDiscountStudent.CheckedChanged
        lblPrice.Text = String.Empty

    End Sub
End Class
