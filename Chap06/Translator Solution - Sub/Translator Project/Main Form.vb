'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLang.Items.Add("French")
        cboLang.Items.Add("Spanish")
        cboLang.Items.Add("Italian")
        cboLang.SelectedIndex = 0

    End Sub

    Private Sub Spanish(ByRef strWord As String)
        Select Case True
            Case radMother.Checked
                strWord = "Madre"
            Case radFather.Checked
                strWord = "Padre"
            Case radSister.Checked
                strWord = "Hermana"
            Case radBrother.Checked
                strWord = "Hermano"
        End Select
    End Sub

    Private Sub French(ByRef strWord As String)
        Select Case True
            Case radMother.Checked
                strWord = "Mère"
            Case radFather.Checked
                strWord = "Père"
            Case radSister.Checked
                strWord = "Sœur"
            Case radBrother.Checked
                strWord = "Frère"
        End Select
    End Sub

    Private Sub Italian(ByRef strWord As String)
        Select Case True
            Case radMother.Checked
                strWord = "Madre"
            Case radFather.Checked
                strWord = "Padre"
            Case radSister.Checked
                strWord = "Sorella"
            Case radBrother.Checked
                strWord = "Fratello"
        End Select
    End Sub
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Dim strLang As String = String.Empty

        Select Case cboLang.SelectedItem.ToString
            Case "French"
                French(strLang)
            Case "Spanish"
                Spanish(strLang)
            Case "Italian"
                Italian(strLang)
        End Select

        lblOutput.Text = strLang.ToString
    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) _
        Handles radMother.CheckedChanged, radFather.CheckedChanged, radSister.CheckedChanged, radBrother.CheckedChanged, cboLang.SelectedIndexChanged
        lblOutput.Text = String.Empty
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Mats-R-Us", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
