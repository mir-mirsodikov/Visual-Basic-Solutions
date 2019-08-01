Option Explicit On
Option Infer Off
Option Strict On
'Mukhammad Mirsodikov - P3

Imports System.ComponentModel

Public Class frmMain
    Private Function MatPrice() As Integer
        Dim intPrice As Integer
        Select Case True
            Case radStandard.Checked
                intPrice = 99
            Case radDeluxe.Checked
                intPrice = 129
            Case radPremium.Checked
                intPrice = 179
        End Select

        Return intPrice
    End Function

    Private Sub ExtraPrice(ByRef intExtra As Integer)
        Select Case True
            Case radBlue.Checked
                intExtra = 0
            Case radRed.Checked
                intExtra = 10
            Case radPink.Checked
                intExtra = 15
        End Select

        If chkFold.Checked = True Then
            intExtra += 25
        End If

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intPrice As Integer
        Dim intExtra As Integer
        Dim intTotal As Integer

        intPrice = MatPrice()
        ExtraPrice(intExtra)
        intTotal = intPrice + intExtra
        lblTotal.Text = intTotal.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles radStandard.CheckedChanged, radDeluxe.CheckedChanged, radPremium.CheckedChanged, radBlue.CheckedChanged, radRed.CheckedChanged, radPink.CheckedChanged, chkFold.CheckedChanged

        lblTotal.Text = String.Empty
    End Sub


    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Mats-R-Us", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
