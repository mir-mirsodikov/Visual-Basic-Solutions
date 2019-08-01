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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnDoPretest = New System.Windows.Forms.Button()
        Me.btnDoPosttest = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(351, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "&Number list:"
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.ItemHeight = 15
        Me.lstNumbers.Location = New System.Drawing.Point(262, 35)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(49, 94)
        Me.lstNumbers.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTo)
        Me.GroupBox1.Controls.Add(Me.txtFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display numbers"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(66, 53)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(34, 23)
        Me.txtTo.TabIndex = 3
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(66, 23)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(34, 23)
        Me.txtFrom.TabIndex = 1
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(12, 149)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(75, 23)
        Me.btnForNext.TabIndex = 1
        Me.btnForNext.Text = "For...&Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnDoPretest
        '
        Me.btnDoPretest.Location = New System.Drawing.Point(93, 149)
        Me.btnDoPretest.Name = "btnDoPretest"
        Me.btnDoPretest.Size = New System.Drawing.Size(123, 23)
        Me.btnDoPretest.TabIndex = 2
        Me.btnDoPretest.Text = "&Do...Loop Pretest"
        Me.btnDoPretest.UseVisualStyleBackColor = True
        '
        'btnDoPosttest
        '
        Me.btnDoPosttest.Location = New System.Drawing.Point(222, 149)
        Me.btnDoPosttest.Name = "btnDoPosttest"
        Me.btnDoPosttest.Size = New System.Drawing.Size(123, 23)
        Me.btnDoPosttest.TabIndex = 3
        Me.btnDoPosttest.Text = "Do...&Loop Posttest"
        Me.btnDoPosttest.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 195)
        Me.Controls.Add(Me.btnDoPosttest)
        Me.Controls.Add(Me.btnDoPretest)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnDoPretest As Button
    Friend WithEvents btnDoPosttest As Button
End Class
