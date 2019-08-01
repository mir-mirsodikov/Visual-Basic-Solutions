'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intX As Integer = 5 To 50 Step 5
            lstSale.Items.Add(intX)
        Next intX
        lstSale.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPrice As Double
        Dim dblPercentage As Double
        Dim dblPrice2 As Double
        Double.TryParse(txtPrice.Text, dblPrice)
        Double.TryParse(lstSale.SelectedItem.ToString, dblPercentage)

        dblPercentage /= 100

        txtOutput.Text = "Price" & ControlChars.Tab & "Percentage" & ControlChars.Tab & "Final Price" & ControlChars.NewLine


        For intX As Integer = 0 To 5
            txtOutput.Text = txtOutput.Text & dblPrice.ToString("c2") & ControlChars.NewLine
            For dblY As Double = dblPercentage To 0.5 Step 0.05
                dblPrice2 = dblPrice - (dblPrice * dblY)
                txtOutput.Text = txtOutput.Text & ControlChars.Tab & dblY.ToString("p0") & ControlChars.Tab &
                    ControlChars.Tab & dblPrice2.ToString("c2") & ControlChars.NewLine
            Next dblY
            dblPrice = dblPrice2
        Next intX


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtOutput.Text = String.Empty
    End Sub

    Private Sub lstSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSale.SelectedIndexChanged
        txtOutput.Text = String.Empty
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
