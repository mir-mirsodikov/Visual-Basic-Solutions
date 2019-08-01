'Mukhammad Mirsodikov - p5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblBasic As Double = 24.99
        Const dblSilver As Double = 42.99
        Const dblGold As Double = 84.99
        Const dblDiamond As Double = 99.99
        Dim dblPackageTotal As Double

        Const dblCinnematic As Double = 9.5
        Const dblHBI As Double = 9.5
        Const dblShowtimer As Double = 10.5
        Const dblLocal As Double = 6.0
        Dim dblFeaturesTotal As Double

        Dim dblMonthlyBill As Double

        Select Case True
            Case radBasic.Checked
                dblPackageTotal = dblBasic
            Case radSilver.Checked
                dblPackageTotal = dblSilver
            Case radGold.Checked
                dblPackageTotal = dblGold
            Case radDiamond.Checked
                dblPackageTotal = dblDiamond
        End Select

        'Select Case True
        'Case chkCinnematic.Checked
        'dblFeaturesTotal += dblCinnematic
        'Case chkHBI.Checked
        'dblFeaturesTotal += dblHBI
        'Case chkShowtimes.Checked
        'dblFeaturesTotal += dblShowtimers
        'End Select

        If chkCinnematic.Checked Then
            dblFeaturesTotal += dblCinnematic
        End If

        If chkHBI.Checked Then
            dblFeaturesTotal += dblHBI
        End If

        If chkShowtimer.Checked Then
            dblFeaturesTotal += dblShowtimer
        End If

        If chkLocal.Checked Then
            dblFeaturesTotal += dblLocal
        End If

        dblMonthlyBill = dblPackageTotal + dblFeaturesTotal

        lblMonthlyBill.Text = dblMonthlyBill.ToString("C2")





    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub radBasic_CheckedChanged(sender As Object, e As EventArgs) Handles radBasic.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub radSilver_CheckedChanged(sender As Object, e As EventArgs) Handles radSilver.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub radGold_CheckedChanged(sender As Object, e As EventArgs) Handles radGold.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub radDiamond_CheckedChanged(sender As Object, e As EventArgs) Handles radDiamond.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub chkCinnematic_CheckedChanged(sender As Object, e As EventArgs) Handles chkCinnematic.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub chkHBI_CheckedChanged(sender As Object, e As EventArgs) Handles chkHBI.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub chkShowtimer_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowtimer.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub

    Private Sub chkLocal_CheckedChanged(sender As Object, e As EventArgs) Handles chkLocal.CheckedChanged
        lblMonthlyBill.Text = String.Empty
    End Sub
End Class
