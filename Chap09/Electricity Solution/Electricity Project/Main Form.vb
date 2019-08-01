' Name:         Electricity Project
' Purpose:      Calculate the average monthly electric bill.
' Programmer:   Mukhammad Mirsodikov

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblAverage As Double
        Dim dblNum As Double
        Dim inFile As IO.StreamReader
        Dim intSub As Integer

        If IO.File.Exists("monthlyBills.txt") Then
            inFile = IO.File.OpenText("monthlyBills.txt")
            Do Until inFile.Peek = -1
                Double.TryParse(inFile.ReadLine, dblNum)
                dblAverage += dblNum
                intSub += 1
            Loop
            inFile.Close()
            dblAverage /= intSub
        Else
            MessageBox.Show("Text file does not exist.", "Electricity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        lblAvg.Text = dblAverage.ToString("C2")
    End Sub
End Class
