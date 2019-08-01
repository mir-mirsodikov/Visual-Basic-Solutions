'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Function GetArea(ByVal intLen As Integer, ByVal intWid As Integer) As Integer
        Dim intArea As Integer

        intArea = intLen * intWid
        Return intArea
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Uses a function to calculate the area and then displays the area.

        Dim intLength As Integer
        Dim intWidth As Integer
        Dim intArea As Integer

        Integer.TryParse(cboLength.Text, intLength)
        Integer.TryParse(cboWidth.Text, intWidth)

        intArea = GetArea(intLength, intWidth)
        lblArea.Text = intArea.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the combo boxes with values and selects first item.

        For intNum As Integer = 10 To 40 Step 5
            cboLength.Items.Add(intNum)
            cboWidth.Items.Add(intNum)
        Next intNum

        cboLength.SelectedIndex = 0
        cboWidth.SelectedIndex = 0
    End Sub

    Private Sub ClearArea(sender As Object, e As EventArgs) Handles cboLength.TextChanged, cboWidth.TextChanged
        lblArea.Text = String.Empty
    End Sub
End Class
