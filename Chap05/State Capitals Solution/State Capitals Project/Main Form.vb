'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedIndexChanged


        Select Case lstStates.SelectedItem.ToString
            Case "Alabama"
                lblDisplay.Text = "Montgomery"
            Case "California"
                lblDisplay.Text = "Sacramento"
            Case "Delaware"
                lblDisplay.Text = "Dover"
            Case "Florida"
                lblDisplay.Text = "Tallahassee"
            Case "Georgia"
                lblDisplay.Text = "Atlanta"
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
