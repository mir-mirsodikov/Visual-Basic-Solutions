' Name:         FixIt Project
' Purpose:      Calculates the bonus and then saves the name and bonus amount to a sequential access file.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalcAndSave_Click(sender As Object, e As EventArgs) Handles btnCalcAndSave.Click
        ' Writes the name and 5% bonus amount to a sequential access file.

        Const dblBONUS_RATE As Double = 0.05
        Dim outFile As IO.StreamWriter
        Dim dblSales As Double
        Dim dblBonus As Double

        ' Assign sales amount to a variable.
        Double.TryParse(txtSales.Text, dblSales)
        ' Calculate and display bonus.
        dblBonus = dblSales * dblBONUS_RATE
        lblBonus.Text = dblBonus.ToString("N2")

        ' Save name and bonus to the file.
        outFile = IO.File.AppendText("bonus.txt")
        outFile.WriteLine(txtName.Text)
        outFile.WriteLine(lblBonus.Text)

        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub
End Class
