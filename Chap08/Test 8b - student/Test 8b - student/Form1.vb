'Visual Basic Test 8b
'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strMembership() As String = {"SINGLE", "STUDENT", "FAMILY", "SENIOR"}
        Dim intRate() As Integer = {50, 40, 100, 60}
        Dim strType As String
        Dim intFee As Integer

        strType = txtMembership.Text
        strType = strType.ToUpper

        For intSub As Integer = 0 To strMembership.GetUpperBound(0)
            If strType = strMembership(intSub) Then
                intFee = intRate(intSub)
                lblFee.Text = intFee.ToString("C2")
            End If
        Next

        If intFee = 0 Then
            MessageBox.Show("I'm sorry, that membership type could not be found.", "Stay Fit Health Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblFee.Text = "N/A"
        End If


        txtMembership.Focus()
        txtMembership.SelectAll()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtMembership_TextChanged(sender As Object, e As EventArgs) Handles txtMembership.TextChanged
        lblFee.Text = String.Empty
    End Sub
End Class
