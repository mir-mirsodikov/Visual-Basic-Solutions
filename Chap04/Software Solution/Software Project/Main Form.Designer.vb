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
        Me.btnGetPrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radUltimate = New System.Windows.Forms.RadioButton()
        Me.radProfessional = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNoDiscount = New System.Windows.Forms.RadioButton()
        Me.radDiscountUltimate = New System.Windows.Forms.RadioButton()
        Me.radDiscountStudent = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetPrice
        '
        Me.btnGetPrice.Location = New System.Drawing.Point(451, 82)
        Me.btnGetPrice.Name = "btnGetPrice"
        Me.btnGetPrice.Size = New System.Drawing.Size(87, 27)
        Me.btnGetPrice.TabIndex = 4
        Me.btnGetPrice.Text = "&Get Price"
        Me.btnGetPrice.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(451, 138)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radUltimate
        '
        Me.radUltimate.AutoSize = True
        Me.radUltimate.Location = New System.Drawing.Point(6, 22)
        Me.radUltimate.Name = "radUltimate"
        Me.radUltimate.Size = New System.Drawing.Size(70, 19)
        Me.radUltimate.TabIndex = 0
        Me.radUltimate.TabStop = True
        Me.radUltimate.Text = "&Ultimate"
        Me.radUltimate.UseVisualStyleBackColor = True
        '
        'radProfessional
        '
        Me.radProfessional.AutoSize = True
        Me.radProfessional.Location = New System.Drawing.Point(6, 60)
        Me.radProfessional.Name = "radProfessional"
        Me.radProfessional.Size = New System.Drawing.Size(89, 19)
        Me.radProfessional.TabIndex = 1
        Me.radProfessional.TabStop = True
        Me.radProfessional.Text = "&Professional"
        Me.radProfessional.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(6, 98)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(66, 19)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radStudent)
        Me.GroupBox1.Controls.Add(Me.radProfessional)
        Me.GroupBox1.Controls.Add(Me.radUltimate)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edition"
        '
        'radNoDiscount
        '
        Me.radNoDiscount.AutoSize = True
        Me.radNoDiscount.Checked = True
        Me.radNoDiscount.Location = New System.Drawing.Point(222, 61)
        Me.radNoDiscount.Name = "radNoDiscount"
        Me.radNoDiscount.Size = New System.Drawing.Size(91, 19)
        Me.radNoDiscount.TabIndex = 1
        Me.radNoDiscount.TabStop = True
        Me.radNoDiscount.Text = "&No Discount"
        Me.radNoDiscount.UseVisualStyleBackColor = True
        '
        'radDiscountUltimate
        '
        Me.radDiscountUltimate.AutoSize = True
        Me.radDiscountUltimate.Location = New System.Drawing.Point(222, 99)
        Me.radDiscountUltimate.Name = "radDiscountUltimate"
        Me.radDiscountUltimate.Size = New System.Drawing.Size(73, 19)
        Me.radDiscountUltimate.TabIndex = 2
        Me.radDiscountUltimate.Text = "Ul&timate "
        Me.radDiscountUltimate.UseVisualStyleBackColor = True
        '
        'radDiscountStudent
        '
        Me.radDiscountStudent.AutoSize = True
        Me.radDiscountStudent.Location = New System.Drawing.Point(222, 137)
        Me.radDiscountStudent.Name = "radDiscountStudent"
        Me.radDiscountStudent.Size = New System.Drawing.Size(158, 19)
        Me.radDiscountStudent.TabIndex = 3
        Me.radDiscountStudent.Text = " Stu&dent edition discount"
        Me.radDiscountStudent.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(219, 206)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(217, 31)
        Me.lblPrice.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 267)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radDiscountStudent)
        Me.Controls.Add(Me.radDiscountUltimate)
        Me.Controls.Add(Me.radNoDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetPrice)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software Solution"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetPrice As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radUltimate As RadioButton
    Friend WithEvents radProfessional As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNoDiscount As RadioButton
    Friend WithEvents radDiscountUltimate As RadioButton
    Friend WithEvents radDiscountStudent As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrice As Label
End Class
