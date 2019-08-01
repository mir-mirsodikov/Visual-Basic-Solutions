'Visual Basic chapter 7 test A
'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strId As String
        Dim intSales As Integer
        Static intFullTime As Integer
        Static intPartTime As Integer
        Static intNewCar As Integer
        Static intUsedCar As Integer

        Integer.TryParse(txtNumSold.Text, intSales)

        strId = txtID.Text.Trim
        strId = strId.ToUpper

        If strId Like "[P][A-Z][A-Z][1-2]" OrElse strId Like "[F][A-Z][A-Z][1-2]" Then

            If strId(0) = "P" Then
                intPartTime += intSales
            Else
                intFullTime += intSales
            End If

            If strId(3) = "1" Then
                intNewCar += intSales
            Else
                intUsedCar += intSales
            End If
        Else
            MessageBox.Show("Invalid code", "BobCat Motors", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Text = String.Empty
            txtID.Focus()
        End If

        lblFullTime.Text = intFullTime.ToString
        lblPartTime.Text = intPartTime.ToString
        lblNew.Text = intNewCar.ToString
        lblUsed.Text = intUsedCar.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
