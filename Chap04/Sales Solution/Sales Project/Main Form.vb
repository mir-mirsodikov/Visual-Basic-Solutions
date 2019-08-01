'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblJimSales As Double
        Dim dblKarenSales As Double
        Dim dblMartinSales As Double
        Dim dblTotalSales As Double
        Dim dblJimPercentage As Double
        Dim dblKarenPercentage As Double
        Dim dblMartinPercentage As Double

        Double.TryParse(txtJim.Text, dblJimSales)
        Double.TryParse(txtKaren.Text, dblKarenSales)
        Double.TryParse(txtMartin.Text, dblMartinSales)
        Double.TryParse(txtTotal.Text, dblTotalSales)


        If dblTotalSales = 0 Then
            lblJimPercentage.Text = "0.0%"
            lblKarenPercentage.Text = "0.0%"
            lblMartinPercentage.Text = "0.0%"
        Else
            dblJimPercentage = dblJimSales / dblTotalSales
            dblKarenPercentage = dblKarenSales / dblTotalSales
            dblMartinPercentage = dblMartinSales / dblTotalSales
        End If



        lblMartinPercentage.Text = dblMartinPercentage.ToString("P2")
        lblJimPercentage.Text = dblJimPercentage.ToString("P2")
        lblKarenPercentage.Text = dblKarenPercentage.ToString("P2")




    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        lblJimPercentage.Text = String.Empty
        lblKarenPercentage.Text = String.Empty
        lblMartinPercentage.Text = String.Empty

    End Sub

    Private Sub txtTotal_Enter(sender As Object, e As EventArgs) Handles txtTotal.Enter
        txtTotal.SelectAll()

    End Sub

    Private Sub txtJim_TextChanged(sender As Object, e As EventArgs) Handles txtJim.TextChanged
        lblJimPercentage.Text = String.Empty
        lblKarenPercentage.Text = String.Empty
        lblMartinPercentage.Text = String.Empty

    End Sub

    Private Sub txtJim_Enter(sender As Object, e As EventArgs) Handles txtJim.Enter
        txtJim.SelectAll()

    End Sub

    Private Sub txtKaren_TextChanged(sender As Object, e As EventArgs) Handles txtKaren.TextChanged
        lblJimPercentage.Text = String.Empty
        lblKarenPercentage.Text = String.Empty
        lblMartinPercentage.Text = String.Empty

    End Sub

    Private Sub txtKaren_Enter(sender As Object, e As EventArgs) Handles txtKaren.Enter
        txtKaren.SelectAll()

    End Sub

    Private Sub txtMartin_TextChanged(sender As Object, e As EventArgs) Handles txtMartin.TextChanged
        lblJimPercentage.Text = String.Empty
        lblKarenPercentage.Text = String.Empty
        lblMartinPercentage.Text = String.Empty

    End Sub

    Private Sub txtMartin_Enter(sender As Object, e As EventArgs) Handles txtMartin.Enter
        txtMartin.SelectAll()

    End Sub

    Private Sub ClearText(sender As Object, e As KeyPressEventArgs) _
        Handles txtTotal.KeyPress, txtJim.KeyPress, txtKaren.KeyPress, txtMartin.KeyPress
        If (e.KeyChar < "0 " OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
