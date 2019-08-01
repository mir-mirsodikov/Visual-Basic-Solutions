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

        Double.TryParse(txtJim.Text, dblJimSales)
        Double.TryParse(txtKaren.Text, dblKarenSales)
        Double.TryParse(txtMartin.Text, dblMartinSales)
        Double.TryParse(txtTotal.Text, dblTotalSales)

        Dim dblJimPercentage As Double = dblJimSales / dblTotalSales
        lblJimPercentage.Text = dblJimPercentage.ToString("P2")
        Dim dblKarenPercentage As Double = dblKarenSales / dblTotalSales
        lblKarenPercentage.Text = dblKarenPercentage.ToString("P2")
        Dim dblMartinPercentage As Double = dblMartinSales / dblTotalSales
        lblMartinPercentage.Text = dblMartinPercentage.ToString("P2")






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
End Class
