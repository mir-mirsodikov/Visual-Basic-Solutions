'Mukhammad Mirsodikov - P5 

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intLife As Integer = 3 To 20 Step 1
            lstLife.Items.Add(intLife)
        Next intLife
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dblAsset As Double
        Dim dblSalvage As Double
        Dim intLife As Integer

        Integer.TryParse(lstLife.SelectedItem.ToString, intLife)
        Double.TryParse(txtAssest.Text, dblAsset)
        Double.TryParse(txtSalvage.Text, dblSalvage)

        lstDeclining.Items.Clear()
        lstSum.Items.Clear()

        lstDeclining.Items.Add("Years" & ControlChars.Tab & "Depreciation")
        lstSum.Items.Add("Years" & ControlChars.Tab & "Depreciation")
        For intYear As Integer = 1 To 5
            lstDeclining.Items.Add(intYear.ToString & ControlChars.Tab &
                 (Financial.DDB(dblAsset, dblSalvage, intLife, intYear)).ToString("N2") & ControlChars.NewLine)
            lstSum.Items.Add(intYear & ControlChars.Tab &
                             (Financial.SYD(dblAsset, dblSalvage, intLife, intYear)).ToString("N2") & ControlChars.NewLine)
        Next intYear

    End Sub

    Private Sub txtAssest_Enter(sender As Object, e As EventArgs) Handles txtAssest.Enter
        txtAssest.SelectAll()

    End Sub

    Private Sub txtSalvage_Enter(sender As Object, e As EventArgs) Handles txtSalvage.Enter
        txtSalvage.SelectAll()

    End Sub

    Private Sub txtAssest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAssest.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSalvage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalvage.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
