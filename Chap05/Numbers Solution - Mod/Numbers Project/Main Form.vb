'Mukhammad Mirsodikov - P5

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        If intFrom Mod 2 = 1 Then
            intFrom += 1
            If intFrom < intTo Then
                For intCount As Integer = intFrom To intTo Step 2
                    lstNumbers.Items.Add(intCount)
                Next intCount
            End If
        ElseIf intFrom Mod 2 = 0 Then
            If intFrom < intTo Then
                For intCount2 As Integer = intFrom To intTo Step 2
                    lstNumbers.Items.Add(intCount2)
                Next intCount2
            End If
        End If



    End Sub

    Private Sub btnDoPretest_Click(sender As Object, e As EventArgs) Handles btnDoPretest.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        Dim intCount As Integer = intFrom

        If intFrom Mod 2 = 1 Then
            If intFrom < intTo Then
                Do Until intCount > intTo
                    lstNumbers.Items.Add(intCount)
                    intCount += 2
                Loop
            End If
        ElseIf intFrom Mod 2 = 0 Then
            intFrom += 1
            intCount = intFrom
            If intFrom < intTo Then
                Do Until intCount > intTo
                    lstNumbers.Items.Add(intCount)
                    intCount += 2
                Loop
            End If
        End If

    End Sub

    Private Sub btnDoPosttest_Click(sender As Object, e As EventArgs) Handles btnDoPosttest.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        Dim intCount As Integer = intFrom

        If intFrom < intTo Then
            Do
                lstNumbers.Items.Add(intCount)
                intCount += 1
            Loop Until intCount > intTo
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrom.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTo.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFrom_Enter(sender As Object, e As EventArgs) Handles txtFrom.Enter
        txtFrom.SelectAll()
    End Sub

    Private Sub txtTo_Enter(sender As Object, e As EventArgs) Handles txtTo.Enter
        txtTo.SelectAll()
    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged
        lstNumbers.Items.Clear()
    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        lstNumbers.Items.Clear()
    End Sub
End Class
