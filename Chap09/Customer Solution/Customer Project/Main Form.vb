'Mukhammad Mirsodikov - P3

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim outFile As IO.StreamWriter

        If EmptyTextboxes() = True Then
            MessageBox.Show("Fill out all text boxes.", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If IO.File.Exists("customers.txt") Then
                outFile = IO.File.AppendText("customers.txt")
                outFile.WriteLine(txtFirst.Text + " " + txtLast.Text)
                outFile.WriteLine(txtAddress.Text + ", " + txtCity.Text + ", " + txtZip.Text)
                outFile.WriteLine(ControlChars.NewLine)
                lblSaved.Visible = True
                outFile.Close()

            Else
                MessageBox.Show("Text file could not be found", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function EmptyTextboxes() As Boolean
        If txtFirst.Text = String.Empty OrElse txtLast.Text = String.Empty _
            OrElse txtAddress.Text = String.Empty OrElse txtCity.Text = String.Empty OrElse txtZip.Text = String.Empty Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()

    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtFirst.TextChanged, txtLast.TextChanged, txtAddress.TextChanged, txtCity.TextChanged, txtZip.TextChanged
        lblSaved.Visible = False
    End Sub

    Private Sub txtFirst_Enter(sender As Object, e As EventArgs) Handles txtFirst.Enter
        txtFirst.SelectAll()
    End Sub

    Private Sub txtLast_Enter(sender As Object, e As EventArgs) Handles txtLast.Enter
        txtLast.SelectAll()
    End Sub

    Private Sub txtAddress_Enter(sender As Object, e As EventArgs) Handles txtAddress.Enter
        txtAddress.SelectAll()
    End Sub

    Private Sub txtCity_Enter(sender As Object, e As EventArgs) Handles txtCity.Enter
        txtCity.SelectAll()
    End Sub

    Private Sub txtZip_Enter(sender As Object, e As EventArgs) Handles txtZip.Enter
        txtZip.SelectAll()
    End Sub
End Class
