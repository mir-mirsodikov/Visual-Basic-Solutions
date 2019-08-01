'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with values.

        lstDelivery.Items.Add("Mail - Standard")
        lstDelivery.Items.Add("Mail - Priority")
        lstDelivery.Items.Add("FedEx - Standard")
        lstDelivery.Items.Add("FedEx - Overnight")
        lstDelivery.Items.Add("UPS")
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        ' Clears the list box selection.

        lstDelivery.SelectedIndex = -1
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        Dim strCode As String

        strCode = txtCode.Text.Trim
        strCode = strCode.ToUpper

        lstDelivery.Enabled = True
        If strCode Like "##[M][S]" Then
            lstDelivery.SelectedItem = "Mail - Standard"
        ElseIf strCode Like "##[M][P]" Then
            lstDelivery.SelectedItem = "Mail - Priority"
        ElseIf strCode Like "##[F][S]" Then
            lstDelivery.SelectedItem = "FedEx - Standard"
        ElseIf strCode Like "##[F][O]" Then
            lstDelivery.SelectedItem = "FedEx - Overnight"
        ElseIf strCode Like "##[U]" Then
            lstDelivery.SelectedItem = "UPS"
        Else
            MessageBox.Show("Enter a valid code.", "Shipping", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            lstDelivery.Enabled = False
        End If
    End Sub
End Class
