﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstContinents = New System.Windows.Forms.ListBox()
        Me.btnAscending = New System.Windows.Forms.Button()
        Me.btnDescending = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstContinents
        '
        Me.lstContinents.ItemHeight = 17
        Me.lstContinents.Location = New System.Drawing.Point(220, 10)
        Me.lstContinents.Name = "lstContinents"
        Me.lstContinents.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstContinents.Size = New System.Drawing.Size(115, 123)
        Me.lstContinents.TabIndex = 3
        '
        'btnAscending
        '
        Me.btnAscending.Location = New System.Drawing.Point(10, 146)
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(137, 29)
        Me.btnAscending.TabIndex = 0
        Me.btnAscending.Text = "&Ascending order"
        Me.btnAscending.UseVisualStyleBackColor = True
        '
        'btnDescending
        '
        Me.btnDescending.Location = New System.Drawing.Point(153, 146)
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(137, 29)
        Me.btnDescending.TabIndex = 1
        Me.btnDescending.Text = "&Descending order"
        Me.btnDescending.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(296, 146)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Continents_Project.My.Resources.Resources.Continents
        Me.PictureBox1.Location = New System.Drawing.Point(34, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 193)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDescending)
        Me.Controls.Add(Me.btnAscending)
        Me.Controls.Add(Me.lstContinents)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Continents"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstContinents As System.Windows.Forms.ListBox
    Friend WithEvents btnAscending As System.Windows.Forms.Button
    Friend WithEvents btnDescending As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
