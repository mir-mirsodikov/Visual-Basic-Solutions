<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCandy = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSold = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblChocoBar = New System.Windows.Forms.Label()
        Me.lblChocoBarPeanuts = New System.Windows.Forms.Label()
        Me.lblKitKat = New System.Windows.Forms.Label()
        Me.lblPeanutButCups = New System.Windows.Forms.Label()
        Me.lblTake5Bar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Chocolate Fund Raiser"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Candy:"
        '
        'lstCandy
        '
        Me.lstCandy.FormattingEnabled = True
        Me.lstCandy.ItemHeight = 16
        Me.lstCandy.Location = New System.Drawing.Point(160, 75)
        Me.lstCandy.Name = "lstCandy"
        Me.lstCandy.Size = New System.Drawing.Size(127, 84)
        Me.lstCandy.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Sold:"
        '
        'txtSold
        '
        Me.txtSold.Location = New System.Drawing.Point(328, 75)
        Me.txtSold.Name = "txtSold"
        Me.txtSold.Size = New System.Drawing.Size(48, 22)
        Me.txtSold.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(438, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 27)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add to total"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(438, 103)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Choco Bar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Choco Bar-Peanuts:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kit Kat:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Peanut Butter Cups:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Take 5 Bar:"
        '
        'lblChocoBar
        '
        Me.lblChocoBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChocoBar.Location = New System.Drawing.Point(31, 233)
        Me.lblChocoBar.Name = "lblChocoBar"
        Me.lblChocoBar.Size = New System.Drawing.Size(49, 21)
        Me.lblChocoBar.TabIndex = 8
        Me.lblChocoBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChocoBarPeanuts
        '
        Me.lblChocoBarPeanuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChocoBarPeanuts.Location = New System.Drawing.Point(145, 233)
        Me.lblChocoBarPeanuts.Name = "lblChocoBarPeanuts"
        Me.lblChocoBarPeanuts.Size = New System.Drawing.Size(49, 21)
        Me.lblChocoBarPeanuts.TabIndex = 10
        Me.lblChocoBarPeanuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKitKat
        '
        Me.lblKitKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitKat.Location = New System.Drawing.Point(261, 233)
        Me.lblKitKat.Name = "lblKitKat"
        Me.lblKitKat.Size = New System.Drawing.Size(49, 21)
        Me.lblKitKat.TabIndex = 12
        Me.lblKitKat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPeanutButCups
        '
        Me.lblPeanutButCups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeanutButCups.Location = New System.Drawing.Point(368, 233)
        Me.lblPeanutButCups.Name = "lblPeanutButCups"
        Me.lblPeanutButCups.Size = New System.Drawing.Size(49, 21)
        Me.lblPeanutButCups.TabIndex = 14
        Me.lblPeanutButCups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTake5Bar
        '
        Me.lblTake5Bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTake5Bar.Location = New System.Drawing.Point(488, 233)
        Me.lblTake5Bar.Name = "lblTake5Bar"
        Me.lblTake5Bar.Size = New System.Drawing.Size(49, 21)
        Me.lblTake5Bar.TabIndex = 16
        Me.lblTake5Bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Warren_Project.My.Resources.Resources.Choco
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTake5Bar)
        Me.Controls.Add(Me.lblPeanutButCups)
        Me.Controls.Add(Me.lblKitKat)
        Me.Controls.Add(Me.lblChocoBarPeanuts)
        Me.Controls.Add(Me.lblChocoBar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstCandy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warren School"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCandy As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSold As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblChocoBar As System.Windows.Forms.Label
    Friend WithEvents lblChocoBarPeanuts As System.Windows.Forms.Label
    Friend WithEvents lblKitKat As System.Windows.Forms.Label
    Friend WithEvents lblPeanutButCups As System.Windows.Forms.Label
    Friend WithEvents lblTake5Bar As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    
End Class
