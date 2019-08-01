'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intWeight As Integer = 0 To 30 Step 5
            cboWeight.Items.Add(intWeight)
        Next intWeight
        cboWeight.SelectedItem = 15

    End Sub

    Private Function GetGrade(ByVal dblCurrentGrade As Double, ByVal dblDesiredGrade As Double, ByVal dblWeight As Double) As Double
        Dim dblTestGrade As Double
        dblTestGrade = (dblDesiredGrade - dblCurrentGrade * (1.0 - dblWeight)) / dblWeight
        dblTestGrade /= 100

        Return dblTestGrade
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblCurrentGrade As Double
        Dim dblDesiredGrade As Double
        Dim dblWeight As Double
        Dim dblTestGrade As Double

        Double.TryParse(txtCurrent.Text, dblCurrentGrade)
        Double.TryParse(txtDesired.Text, dblDesiredGrade)
        Double.TryParse(cboWeight.Text, dblWeight)
        dblWeight = dblWeight / 100

        If (dblCurrentGrade < 0 OrElse dblDesiredGrade < 0 OrElse dblWeight < 0) Then
            lblOutput.Text = "Please enter valid values"
        Else
            dblTestGrade = GetGrade(dblCurrentGrade, dblDesiredGrade, dblWeight)
        End If

        lblOutput.Text = "You need at least a " & dblTestGrade.ToString("P2") & " to get a " & (dblDesiredGrade / 100).ToString("P2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles txtCurrent.TextChanged, txtDesired.TextChanged, cboWeight.TextChanged
        lblOutput.Text = String.Empty

    End Sub

    Private Sub NumbersOnly(sender As Object, e As KeyPressEventArgs) _
        Handles txtDesired.KeyPress, txtCurrent.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso
            e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Grade Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)


        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub
End Class
