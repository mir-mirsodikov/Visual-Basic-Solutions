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
        Me.txtAssest = New System.Windows.Forms.TextBox()
        Me.lstLife = New System.Windows.Forms.ListBox()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstSum = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDeclining = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Asset cost:"
        '
        'txtAssest
        '
        Me.txtAssest.Location = New System.Drawing.Point(135, 92)
        Me.txtAssest.Name = "txtAssest"
        Me.txtAssest.Size = New System.Drawing.Size(116, 23)
        Me.txtAssest.TabIndex = 1
        '
        'lstLife
        '
        Me.lstLife.FormattingEnabled = True
        Me.lstLife.ItemHeight = 15
        Me.lstLife.Location = New System.Drawing.Point(434, 92)
        Me.lstLife.Name = "lstLife"
        Me.lstLife.Size = New System.Drawing.Size(93, 79)
        Me.lstLife.TabIndex = 5
        '
        'txtSalvage
        '
        Me.txtSalvage.Location = New System.Drawing.Point(285, 92)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(116, 23)
        Me.txtSalvage.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Salvage value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Useful life:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(135, 194)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(266, 27)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "&Display depreciation schedules"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(434, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstSum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lstDeclining)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 213)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation schedules"
        '
        'lstSum
        '
        Me.lstSum.FormattingEnabled = True
        Me.lstSum.ItemHeight = 15
        Me.lstSum.Items.AddRange(New Object() {"Year" & Global.Microsoft.VisualBasic.ChrW(9) & "Depreciation"})
        Me.lstSum.Location = New System.Drawing.Point(280, 52)
        Me.lstSum.Name = "lstSum"
        Me.lstSum.Size = New System.Drawing.Size(185, 139)
        Me.lstSum.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sum-of-the-years' digits:"
        '
        'lstDeclining
        '
        Me.lstDeclining.FormattingEnabled = True
        Me.lstDeclining.ItemHeight = 15
        Me.lstDeclining.Items.AddRange(New Object() {"Year" & Global.Microsoft.VisualBasic.ChrW(9) & "Depreciation"})
        Me.lstDeclining.Location = New System.Drawing.Point(56, 52)
        Me.lstDeclining.Name = "lstDeclining"
        Me.lstDeclining.Size = New System.Drawing.Size(185, 139)
        Me.lstDeclining.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Double-declining balance:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstLife)
        Me.Controls.Add(Me.txtAssest)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canton Manufacturing Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAssest As TextBox
    Friend WithEvents lstLife As ListBox
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstSum As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstDeclining As ListBox
    Friend WithEvents Label4 As Label
End Class
