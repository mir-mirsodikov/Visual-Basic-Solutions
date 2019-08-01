Option Explicit On
Option Strict On
Option Infer Off
' Name:         Warren Project
' Purpose:      Displays the amount sold for each candy type.
' Programmer:   Mukhammad Mirsodikov

Imports System.ComponentModel


Public Class frmMain
    Private intCandy(4) As Integer

    Private Sub DisplayArray()
        lblChocoBar.Text = intCandy(0).ToString
        lblChocoBarPeanuts.Text = intCandy(1).ToString
        lblKitKat.Text = intCandy(2).ToString
        lblPeanutButCups.Text = intCandy(3).ToString
        lblTake5Bar.Text = intCandy(4).ToString
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list box with values and then selects the first value.
        Dim inFile As IO.StreamReader

        If IO.File.Exists("candySales.txt") Then
            inFile = IO.File.OpenText("candySales.txt")
            Do Until inFile.Peek = -1
                Integer.TryParse(inFile.ReadLine, intCandy(0))
                Integer.TryParse(inFile.ReadLine, intCandy(1))
                Integer.TryParse(inFile.ReadLine, intCandy(2))
                Integer.TryParse(inFile.ReadLine, intCandy(3))
                Integer.TryParse(inFile.ReadLine, intCandy(4))
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Could not find file.", "Warren School", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lstCandy.Items.Add("Choco Bar")
        lstCandy.Items.Add("Choco Bar-Peanuts")
        lstCandy.Items.Add("Kit Kat")
        lstCandy.Items.Add("Peanut Butter Cups")
        lstCandy.Items.Add("Take 5 Bar")
        lstCandy.SelectedIndex = 0

        DisplayArray()



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Adds the amount sold to the appropriate total.

        ' Declare array and variable.
        Dim intSold As Integer

        Integer.TryParse(txtSold.Text, intSold)

        ' Update array value.
        intCandy(lstCandy.SelectedIndex) += intSold
        DisplayArray()

        ' Display array values.


        txtSold.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSold_Enter(sender As Object, e As EventArgs) Handles txtSold.Enter
        txtSold.SelectAll()
    End Sub

    Private Sub txtSold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSold.KeyPress
        ' Accept only numbers, the hyphen, and the Backspace.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearOutput(sender As Object, e As EventArgs) Handles txtSold.TextChanged, lstCandy.SelectedIndexChanged
        lblChocoBar.Text = String.Empty
        lblChocoBarPeanuts.Text = String.Empty
        lblKitKat.Text = String.Empty
        lblPeanutButCups.Text = String.Empty
        lblTake5Bar.Text = String.Empty
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim outFile As IO.StreamWriter

        If IO.File.Exists("candySales.txt") Then
            outFile = IO.File.CreateText("candySales.txt")
            outFile.WriteLine(intCandy(0).ToString)
            outFile.WriteLine(intCandy(1).ToString)
            outFile.WriteLine(intCandy(2).ToString)
            outFile.WriteLine(intCandy(3).ToString)
            outFile.WriteLine(intCandy(4).ToString)
            outFile.Close()
        Else
            MessageBox.Show("Unable to locate file.", "Warren School", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
