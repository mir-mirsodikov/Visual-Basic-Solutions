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
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEight = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFiveIncrease = New System.Windows.Forms.Label()
        Me.lblEightIncrease = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(12, 114)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 23)
        Me.txtSalary.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current &Salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 50)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "5% of Salary:"
        '
        'lblFive
        '
        Me.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFive.Location = New System.Drawing.Point(12, 183)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(100, 23)
        Me.lblFive.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "5% Salary Increase:"
        '
        'lblEight
        '
        Me.lblEight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEight.Location = New System.Drawing.Point(12, 243)
        Me.lblEight.Name = "lblEight"
        Me.lblEight.Size = New System.Drawing.Size(100, 23)
        Me.lblEight.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "8% of Salary:"
        '
        'lblFiveIncrease
        '
        Me.lblFiveIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiveIncrease.Location = New System.Drawing.Point(185, 183)
        Me.lblFiveIncrease.Name = "lblFiveIncrease"
        Me.lblFiveIncrease.Size = New System.Drawing.Size(100, 23)
        Me.lblFiveIncrease.TabIndex = 12
        '
        'lblEightIncrease
        '
        Me.lblEightIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEightIncrease.Location = New System.Drawing.Point(185, 243)
        Me.lblEightIncrease.Name = "lblEightIncrease"
        Me.lblEightIncrease.Size = New System.Drawing.Size(100, 23)
        Me.lblEightIncrease.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(182, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "8% Salary Increase:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(18, 328)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(114, 328)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 372)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblEightIncrease)
        Me.Controls.Add(Me.lblFiveIncrease)
        Me.Controls.Add(Me.lblEight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSalary)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEight As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFiveIncrease As Label
    Friend WithEvents lblEightIncrease As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
End Class
