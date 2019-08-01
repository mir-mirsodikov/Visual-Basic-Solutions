'Mukhammad Mirsodikov - P5

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub btnWhichCar_Click(sender As Object, e As EventArgs) Handles btnWhichCar.Click
        Dim dblCar1MPG As Double
        Dim dblCar2MPG As Double
        Dim dblCar1CPG As Double
        Dim dblCar2CPG As Double
        Dim dblTotalMiles As Double
        Dim dblCar1Total As Double
        Dim dblCar2Total As Double
        Dim dblSavings As Double

        Double.TryParse(txtCar1MPG.Text, dblCar1MPG)
        Double.TryParse(txtCar2MPG.Text, dblCar2MPG)
        Double.TryParse(txtCar1CPG.Text, dblCar1CPG)
        Double.TryParse(txtCar2CPG.Text, dblCar2CPG)
        Double.TryParse(txtTotalMiles.Text, dblTotalMiles)

        dblCar1Total = (dblTotalMiles / dblCar1MPG) * dblCar1CPG
        dblCar2Total = (dblTotalMiles / dblCar2MPG) * dblCar2CPG

        lblCar1Total.Text = dblCar1Total.ToString("C2")
        lblCar2Total.Text = dblCar2Total.ToString("C2")

        If dblCar1Total > dblCar2Total Then
            lblCarChoice.Text = ("Car 2")
            dblSavings = dblCar1Total - dblCar2Total
        ElseIf dblCar1Total < dblCar2Total Then
            lblCarChoice.Text = ("Car 1")
            dblSavings = dblCar2Total - dblCar1Total
        ElseIf dblCar1Total = dblCar2Total Then
            lblCarChoice.Text = "Car 1"
            dblSavings = 0
        End If

        lblSavings.Text = dblSavings.ToString("C2")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtCar1MPG_TextChanged(sender As Object, e As EventArgs) Handles txtCar1MPG.TextChanged
        lblCar1Total.Text = String.Empty
        lblCar2Total.Text = String.Empty
        lblCarChoice.Text = String.Empty
        lblSavings.Text = String.Empty
    End Sub

    Private Sub txtTotalMiles_TextChanged(sender As Object, e As EventArgs) Handles txtTotalMiles.TextChanged


        lblCar1Total.Text = String.Empty
        lblCar2Total.Text = String.Empty
        lblCarChoice.Text = String.Empty
        lblSavings.Text = String.Empty
    End Sub

    Private Sub txtCar1CPG_TextChanged(sender As Object, e As EventArgs) Handles txtCar1CPG.TextChanged
        lblCar1Total.Text = String.Empty
        lblCar2Total.Text = String.Empty
        lblCarChoice.Text = String.Empty
        lblSavings.Text = String.Empty
    End Sub

    Private Sub txtCar2MPG_TextChanged(sender As Object, e As EventArgs) Handles txtCar2MPG.TextChanged
        lblCar1Total.Text = String.Empty
        lblCar2Total.Text = String.Empty
        lblCarChoice.Text = String.Empty
        lblSavings.Text = String.Empty
    End Sub

    Private Sub txtCar2CPG_TextChanged(sender As Object, e As EventArgs) Handles txtCar2CPG.TextChanged
        lblCar1Total.Text = String.Empty
        lblCar2Total.Text = String.Empty
        lblCarChoice.Text = String.Empty
        lblSavings.Text = String.Empty
    End Sub

    Private Sub txtCar1MPG_Enter(sender As Object, e As EventArgs) Handles txtCar1MPG.Enter
        txtCar1MPG.SelectAll()

    End Sub

    Private Sub txtTotalMiles_Enter(sender As Object, e As EventArgs) Handles txtTotalMiles.Enter
        txtTotalMiles.SelectAll()

    End Sub

    Private Sub txtCar1CPG_Enter(sender As Object, e As EventArgs) Handles txtCar1CPG.Enter
        txtCar1CPG.SelectAll()

    End Sub

    Private Sub txtCar2MPG_Enter(sender As Object, e As EventArgs) Handles txtCar2MPG.Enter
        txtCar2MPG.SelectAll()

    End Sub

    Private Sub txtCar2CPG_Enter(sender As Object, e As EventArgs) Handles txtCar2CPG.Enter
        txtCar2CPG.SelectAll()
    End Sub

    Private Sub txtTotalMiles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalMiles.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCar1MPG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCar1MPG.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCar2MPG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCar2MPG.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCar1CPG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCar1CPG.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCar2CPG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCar2CPG.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
