'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    'Variables that are used throughout the entire program
    Private RANDOM As New System.Random 'the random number generator
    Private intIncorrect As Integer     'counter for the incorrect number
    Private intCorrect As Integer       'counter for the correct number
    Private intRandom1 As Integer       'the variable for which one of the random numbers gets assigned to
    Private intRandom2 As Integer       'the second variable for which one of the random numbers gets assigned to

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnNewProblem_Click(sender As Object, e As EventArgs) Handles btnNewProblem.Click
        'A selective structure that determines which problem to display and how to display it

        txtAnswer.Text = String.Empty
        Select Case True
            Case radAdd.Checked 'addition
                intRandom1 = RANDOM.Next(1, 20)
                intRandom2 = RANDOM.Next(1, 20)
                lblProblem.Text = intRandom1.ToString & " + " & intRandom2.ToString
            Case radSubtract.Checked 'subtraction
                intRandom1 = RANDOM.Next(1, 20)
                intRandom2 = RANDOM.Next(1, 20)
                If intRandom1 > intRandom2 Then 'making sure the answer is not negative
                    lblProblem.Text = intRandom1.ToString & " - " & intRandom2.ToString
                ElseIf intRandom2 > intRandom1 Then
                    lblProblem.Text = intRandom2.ToString & " - " & intRandom1.ToString
                ElseIf intRandom1 = intRandom2 Then 'to get rid of the problem with '0' being an answer
                    lblProblem.Text = intRandom1.ToString & " - " & intRandom1.ToString
                End If
            Case radMultiplication.Checked 'multiplication
                intRandom1 = RANDOM.Next(1, 20)
                intRandom2 = RANDOM.Next(1, 20)
                lblProblem.Text = intRandom1.ToString & " * " & intRandom2.ToString
            Case radDivision.Checked 'division
                intRandom1 = RANDOM.Next(1, 50)
                intRandom2 = RANDOM.Next(1, 50)

                If intRandom1 > intRandom2 Then 'making sure the answer is a whole number and the bigger number is being divided by the smaller number
                    Do
                        intRandom1 = RANDOM.Next(1, 50)
                        intRandom2 = RANDOM.Next(1, 50)
                        lblProblem.Text = intRandom1.ToString & " / " & intRandom2.ToString
                    Loop Until intRandom1 Mod intRandom2 = 0
                ElseIf intRandom2 > intRandom1 Then
                    Do
                        intRandom1 = RANDOM.Next(1, 50)
                        intRandom2 = RANDOM.Next(1, 50)
                        lblProblem.Text = intRandom2.ToString & " / " & intRandom1.ToString
                    Loop Until intRandom2 Mod intRandom1 = 0
                End If


        End Select
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        Dim intAnswer As Integer

        Integer.TryParse(txtAnswer.Text, intAnswer)
        'A selective structure that grades the answer and determines the correct and incorrect counters
        Select Case True
            Case radAdd.Checked 'addition
                If intAnswer = intRandom1 + intRandom2 Then 'does the answer equal the equation?
                    txtAnswer.Text = String.Empty 'clears the text box
                    intCorrect += 1               'adds 1 to the correct counter
                    lstProblems.Items.Add(lblProblem.Text & " = " & intAnswer.ToString)     'adds the equation to the list
                    intRandom1 = RANDOM.Next(1, 20) 'initializing two new random variables
                    intRandom2 = RANDOM.Next(1, 20)
                    lblProblem.Text = intRandom1.ToString & " + " & intRandom2.ToString 'displaying the two new random variables
                Else
                    txtAnswer.Text = String.Empty
                    intIncorrect += 1 'adds 1 to the incorrect counter
                End If
            Case radSubtract.Checked
                If intAnswer = intRandom1 - intRandom2 OrElse intAnswer = intRandom2 - intRandom1 OrElse intAnswer = intRandom1 - intRandom1 Then 'all the possible solution outcomes
                    txtAnswer.Text = String.Empty
                    intCorrect += 1
                    lstProblems.Items.Add(lblProblem.Text & " = " & intAnswer.ToString)
                    intRandom1 = RANDOM.Next(1, 20)
                    intRandom2 = RANDOM.Next(1, 20)
                    If intRandom1 > intRandom2 Then 'making sure the smaller number is being subtracted from the bigger one
                        lblProblem.Text = intRandom1.ToString & " - " & intRandom2.ToString
                    Else
                        lblProblem.Text = intRandom2.ToString & " - " & intRandom2.ToString
                    End If
                Else
                    txtAnswer.Text = String.Empty
                    intIncorrect += 1
                End If
            Case radMultiplication.Checked
                If intAnswer = intRandom1 * intRandom2 Then
                    txtAnswer.Text = String.Empty
                    intCorrect += 1
                    lstProblems.Items.Add(lblProblem.Text & " = " & intAnswer)
                    intRandom1 = RANDOM.Next(1, 20)
                    intRandom2 = RANDOM.Next(1, 20)
                    lblProblem.Text = intRandom1.ToString & " * " & intRandom2.ToString
                Else
                    txtAnswer.Text = String.Empty
                    intIncorrect += 1
                End If
            Case radDivision.Checked
                If intAnswer = intRandom1 \ intRandom2 OrElse intAnswer = intRandom2 \ intRandom1 Then 'the possible answer soultions
                    txtAnswer.Text = String.Empty
                    intCorrect += 1
                    lstProblems.Items.Add(lblProblem.Text & " = " & intAnswer.ToString)
                    intRandom1 = RANDOM.Next(1, 50)
                    intRandom2 = RANDOM.Next(1, 50)
                    If intRandom1 > intRandom2 Then 'same selection structure as the one at the top
                        Do
                            intRandom1 = RANDOM.Next(1, 50)
                            intRandom2 = RANDOM.Next(1, 50)
                            lblProblem.Text = intRandom1.ToString & " / " & intRandom2.ToString
                        Loop Until intRandom1 Mod intRandom2 = 0
                    ElseIf intRandom2 > intRandom1 Then
                        Do
                            intRandom1 = RANDOM.Next(1, 50)
                            intRandom2 = RANDOM.Next(1, 50)
                            lblProblem.Text = intRandom2.ToString & " / " & intRandom1.ToString
                        Loop Until intRandom2 Mod intRandom1 = 0
                    End If
                Else
                    txtAnswer.Text = String.Empty
                    intIncorrect += 1
                End If
        End Select

        'the display code
        lblCorrect.Text = intCorrect.ToString("N0")
        lblIncorrect.Text = intIncorrect.ToString("N0")
        lblPercentage.Text = (intCorrect / (intCorrect + intIncorrect)).ToString("P2")
    End Sub

    Private Sub radAdd_Click(sender As Object, e As EventArgs) Handles radAdd.Click

    End Sub

    Private Sub radSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles radSubtract.CheckedChanged
        lblProblem.Text = String.Empty

    End Sub

    Private Sub radAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radAdd.CheckedChanged
        lblProblem.Text = String.Empty

    End Sub

    Private Sub radMultiplication_CheckedChanged(sender As Object, e As EventArgs) Handles radMultiplication.CheckedChanged
        lblProblem.Text = String.Empty

    End Sub

    Private Sub radDivision_CheckedChanged(sender As Object, e As EventArgs) Handles radDivision.CheckedChanged
        lblProblem.Text = String.Empty

    End Sub

    Private Sub lstProblems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProblems.SelectedIndexChanged

        lblIndex.Text = (lstProblems.SelectedIndex + 1).ToString
    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub

    Private Sub txtAnswer_Enter(sender As Object, e As EventArgs) Handles txtAnswer.Enter
        txtAnswer.SelectAll()

    End Sub

    Private Sub txtAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer.KeyPress
        'only numbers and the backspace key are allowed in the textbox
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the instructional label that opens up with the project
        lblInfo.Text = "Welcome to the Math Practice program!" & ControlChars.NewLine &
            "To get started, select one of the 4 problem types shown to the right." & ControlChars.NewLine &
            "Then, press the 'New Problem' button." & ControlChars.NewLine &
            "Input the answer into the text box provided and see click the 'Check Answer' button to see if your answer is correct!"

    End Sub
End Class
