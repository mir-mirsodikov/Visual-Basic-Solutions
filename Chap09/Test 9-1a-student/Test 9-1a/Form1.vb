'Test 10-1a
'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCandidate.Items.Add("Mark Stone")
        lstCandidate.Items.Add("Sheima Patel")
        lstCandidate.Items.Add("Sam Perez")
        lstCandidate.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intVotes(2) As Integer
        Dim strName As String
        Dim outFile As IO.StreamWriter

        strName = lstCandidate.SelectedItem.ToString

        outFile = IO.File.AppendText("candidates.txt")
        Select Case strName
            Case "Mark Stone"
                intVotes(0) = 1
                outFile.WriteLine("Stone")
                outFile.WriteLine(intVotes(0).ToString)
            Case "Sheima Patel"
                intVotes(1) = 1
                outFile.WriteLine("Patel")
                outFile.WriteLine(intVotes(1).ToString)
            Case "Sam Perez"
                intVotes(2) = 1
                outFile.WriteLine("Perez")
                outFile.WriteLine(intVotes(2).ToString)
        End Select
        lblSuccess.Visible = True
        outFile.Close()

        lblStone.Text = String.Empty
        lblPatel.Text = String.Empty
        lblPerez.Text = String.Empty

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strName As String
        Dim intVotes(2) As Integer
        Dim intTemp As Integer
        Dim inFile As IO.StreamReader

        lblSuccess.Visible = False
        If IO.File.Exists("candidates.txt") Then
            inFile = IO.File.OpenText("candidates.txt")
            Do Until inFile.Peek = -1
                strName = inFile.ReadLine
                Select Case strName
                    Case "Stone"
                        Integer.TryParse(inFile.ReadLine, intTemp)
                        intVotes(0) += intTemp
                    Case "Patel"
                        Integer.TryParse(inFile.ReadLine, intTemp)
                        intVotes(1) += intTemp
                    Case "Perez"
                        Integer.TryParse(inFile.ReadLine, intTemp)
                        intVotes(2) += intTemp
                End Select
            Loop
            inFile.Close()
        End If


        lblStone.Text = intVotes(0).ToString
        lblPatel.Text = intVotes(1).ToString
        lblPerez.Text = intVotes(2).ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstCandidate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCandidate.SelectedIndexChanged
        lblSuccess.Visible = False

        lblStone.Text = String.Empty
        lblPatel.Text = String.Empty
        lblPerez.Text = String.Empty
    End Sub
End Class
