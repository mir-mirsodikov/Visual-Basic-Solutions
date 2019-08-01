' Name:         Harkins Project
' Purpose:      Display the company's annual sales amount.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the annual sales amount.

        ' Declare variables.
        Dim inFile As IO.StreamReader
        Dim strCategory As String
        Dim intSales As Integer
        Dim intAnnualSales As Integer

        If IO.File.Exists("sales.txt") Then
            inFile = IO.File.OpenText("sales.txt")
            Do Until inFile.Peek = -1
                strCategory = inFile.ReadLine
                Integer.TryParse(inFile.ReadLine, intSales)
                intAnnualSales += intSales
            Loop
            inFile.Close()
            lblAnnualSales.Text = intAnnualSales.ToString("C0")
        Else
            MessageBox.Show("Cannot find the file.", "Company Sales",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblAnnualSales.Text = "N/A"
        End If
    End Sub
End Class
