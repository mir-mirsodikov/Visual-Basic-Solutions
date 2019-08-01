'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intCount As Integer = 0 To 20
            lstPremium.Items.Add(intCount)
        Next intCount
        lstPremium.SelectedIndex = 0

        For intNum As Integer = 0 To 100
            lstConnections.Items.Add(intNum)
        Next intNum
        lstConnections.SelectedIndex = 0

    End Sub

    Private Function Business(ByVal intChannel As Integer, ByVal intConnection As Integer) As Double
        Dim dblPrice As Double
        dblPrice = 16.5
        Select Case intConnection
            Case 0
                Dim dlgButton As DialogResult
                dlgButton = MessageBox.Show("You must have at least 1 connection.", "Cable Direct", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case 1 To 10
                dblPrice += 80
            Case Is > 10
                dblPrice += 80 + 4 * (intConnection - 10)
        End Select
        dblPrice += 50 * intChannel

        Return dblPrice
    End Function

    Private Function Residential(ByVal intChannel As Integer, ByVal intConnection As Integer) As Double
        Dim dblPrice As Double
        dblPrice = 34.5 + 5 * intChannel
        Return dblPrice
    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPrice As Double
        Dim intChannel As Integer
        Dim intConnection As Integer

        Integer.TryParse(lstConnections.SelectedItem.ToString, intConnection)
        Integer.TryParse(lstPremium.SelectedItem.ToString, intChannel)

        Select Case True
            Case radBusiness.Checked
                dblPrice = Business(intChannel, intConnection)
            Case radResidential.Checked
                dblPrice = Residential(intChannel, intConnection)
        End Select

        lblTotal.Text = dblPrice.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Mats-R-Us", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles radBusiness.CheckedChanged, radResidential.CheckedChanged, lstConnections.SelectedIndexChanged, lstPremium.SelectedIndexChanged
        lblTotal.Text = String.Empty
    End Sub
End Class
