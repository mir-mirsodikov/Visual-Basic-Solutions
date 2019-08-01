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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.radFinance = New System.Windows.Forms.RadioButton()
        Me.radHealth = New System.Windows.Forms.RadioButton()
        Me.radMarketing = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount due:"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountDue.Location = New System.Drawing.Point(103, 101)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(126, 25)
        Me.lblAmountDue.TabIndex = 6
        Me.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(154, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(154, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'radFinance
        '
        Me.radFinance.AutoSize = True
        Me.radFinance.Checked = True
        Me.radFinance.Location = New System.Drawing.Point(23, 15)
        Me.radFinance.Name = "radFinance"
        Me.radFinance.Size = New System.Drawing.Size(101, 19)
        Me.radFinance.TabIndex = 2
        Me.radFinance.TabStop = True
        Me.radFinance.Text = "&Finance ($150)"
        Me.radFinance.UseVisualStyleBackColor = True
        '
        'radHealth
        '
        Me.radHealth.AutoSize = True
        Me.radHealth.Location = New System.Drawing.Point(23, 40)
        Me.radHealth.Name = "radHealth"
        Me.radHealth.Size = New System.Drawing.Size(95, 19)
        Me.radHealth.TabIndex = 3
        Me.radHealth.Text = "&Health ($125)"
        Me.radHealth.UseVisualStyleBackColor = True
        '
        'radMarketing
        '
        Me.radMarketing.AutoSize = True
        Me.radMarketing.Location = New System.Drawing.Point(23, 65)
        Me.radMarketing.Name = "radMarketing"
        Me.radMarketing.Size = New System.Drawing.Size(114, 19)
        Me.radMarketing.TabIndex = 4
        Me.radMarketing.Text = "&Marketing ($135)"
        Me.radMarketing.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 139)
        Me.Controls.Add(Me.radMarketing)
        Me.Controls.Add(Me.radHealth)
        Me.Controls.Add(Me.radFinance)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seminars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents radFinance As RadioButton
    Friend WithEvents radHealth As RadioButton
    Friend WithEvents radMarketing As RadioButton
End Class
