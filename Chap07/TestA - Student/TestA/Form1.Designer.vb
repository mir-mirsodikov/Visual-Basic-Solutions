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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNumSold = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFullTime = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPartTime = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblUsed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Number sold:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(52, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 23)
        Me.txtID.TabIndex = 1
        '
        'txtNumSold
        '
        Me.txtNumSold.Location = New System.Drawing.Point(207, 60)
        Me.txtNumSold.Name = "txtNumSold"
        Me.txtNumSold.Size = New System.Drawing.Size(100, 23)
        Me.txtNumSold.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cars sold by full-time employees: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cars sold by part-time employees: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cars sold by new car employees: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cars sold by used car employees: "
        '
        'lblFullTime
        '
        Me.lblFullTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullTime.Location = New System.Drawing.Point(233, 140)
        Me.lblFullTime.Name = "lblFullTime"
        Me.lblFullTime.Size = New System.Drawing.Size(68, 24)
        Me.lblFullTime.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(365, 59)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPartTime
        '
        Me.lblPartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartTime.Location = New System.Drawing.Point(233, 173)
        Me.lblPartTime.Name = "lblPartTime"
        Me.lblPartTime.Size = New System.Drawing.Size(68, 24)
        Me.lblPartTime.TabIndex = 11
        '
        'lblNew
        '
        Me.lblNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNew.Location = New System.Drawing.Point(233, 208)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(68, 24)
        Me.lblNew.TabIndex = 12
        '
        'lblUsed
        '
        Me.lblUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsed.Location = New System.Drawing.Point(233, 239)
        Me.lblUsed.Name = "lblUsed"
        Me.lblUsed.Size = New System.Drawing.Size(68, 24)
        Me.lblUsed.TabIndex = 13
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 326)
        Me.Controls.Add(Me.lblUsed)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPartTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFullTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumSold)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BobCat Motors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNumSold As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFullTime As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPartTime As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblUsed As Label
End Class
