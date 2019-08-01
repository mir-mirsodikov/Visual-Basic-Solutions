'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intNum As Integer = 8 To 30
            cboLength.Items.Add(intNum)
            cboWidth.Items.Add(intNum)
            cboHeight.Items.Add(intNum)
        Next intNum
        cboLength.SelectedItem = 10
        cboWidth.SelectedItem = 10
        cboHeight.SelectedItem = 8

        For dblRoll As Double = 30 To 40 Step 0.5
            cboRoll.Items.Add(dblRoll)
        Next dblRoll
        cboRoll.SelectedItem = 37.0
    End Sub

    Private Sub Rolls(ByRef dblRolls As Double)
        Dim intHeight As Integer
        Dim intWidth As Integer
        Dim intLength As Integer
        Dim dblRollCoverage As Double

        Integer.TryParse(cboLength.SelectedItem.ToString, intLength)
        Integer.TryParse(cboWidth.SelectedItem.ToString, intWidth)
        Integer.TryParse(cboHeight.SelectedItem.ToString, intHeight)
        Double.TryParse(cboRoll.SelectedItem.ToString, dblRollCoverage)

        dblRolls = ((intHeight * intLength * 2) + (intHeight * intWidth * 2)) / dblRollCoverage

    End Sub

    Private Sub btnCalcl_Click(sender As Object, e As EventArgs) Handles btnCalcl.Click
        Dim dblRolls As Double

        Rolls(dblRolls)
        dblRolls = Math.Ceiling(dblRolls)

        lblRolls.Text = dblRolls.ToString
    End Sub

    Private Sub ClearText(sender As Object, e As EventArgs) _
        Handles cboLength.SelectedIndexChanged, cboWidth.SelectedIndexChanged, cboHeight.SelectedIndexChanged, cboRoll.SelectedIndexChanged
        lblRolls.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
