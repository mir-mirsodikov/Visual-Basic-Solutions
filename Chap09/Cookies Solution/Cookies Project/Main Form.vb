'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intTotal(3) As Integer
        Dim intSold As Integer
        Dim inFile As IO.StreamReader
        Dim strType As String

        If IO.File.Exists("cookieSales.txt") Then
            inFile = IO.File.OpenText("cookieSales.txt")
            Do Until inFile.Peek = -1
                strType = inFile.ReadLine
                Integer.TryParse(inFile.ReadLine, intSold)
                Select Case strType
                    Case "Chocolate chip"
                        intTotal(0) += intSold
                    Case "Oatmeal"
                        intTotal(1) += intSold
                    Case "Peanut butter"
                        intTotal(2) += intSold
                    Case "Sugar"
                        intTotal(3) += intSold
                End Select
            Loop
        Else
            MessageBox.Show("Unable to locate file.", "Cookie Sales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        lblChocolate.Text = intTotal(0).ToString
        lblOatmeal.Text = intTotal(1).ToString
        lblPeanutButter.Text = intTotal(2).ToString
        lblSugar.Text = intTotal(3).ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
