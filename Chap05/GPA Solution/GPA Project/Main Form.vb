'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For decGPA As Decimal = 1D To 4D Step 0.1D
            lstGPA.Items.Add(decGPA.ToString("N1"))
        Next decGPA
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblGPA As Double
        Static dblMaleGPA As Double
        Static dblFemaleGPA As Double
        Static dblTotalGPA As Double
        Static dblInputF As Double = 0
        Static dblInputM As Double = 0
        Dim dblInputTotal As Double
        Static dblFemaleAcc As Double
        Static dblMaleAcc As Double
        Static dblAllAcc As Double

        Double.TryParse(lstGPA.SelectedItem.ToString, dblGPA)

        If radFemale.Checked = True Then
            dblFemaleGPA += dblGPA
            dblTotalGPA += dblGPA
            dblInputF += 1
        ElseIf radMale.Checked = True Then
            dblMaleGPA += dblGPA
            dblTotalGPA += dblGPA
            dblInputM += 1
        End If

        If dblInputF > 0 Then
            dblFemaleAcc = dblFemaleGPA / dblInputF
            lblFemale.Text = dblFemaleAcc.ToString("N1")
        End If

        If dblInputM > 0 Then
            dblMaleAcc = dblMaleGPA / dblInputM
            lblMale.Text = dblMaleAcc.ToString("N1")
        End If

        dblInputTotal = dblInputF + dblInputM
        If dblInputTotal > 0 Then
            dblAllAcc = dblTotalGPA / dblInputTotal
            lblAllStudents.Text = dblAllAcc.ToString("N1")
        End If

    End Sub
End Class
