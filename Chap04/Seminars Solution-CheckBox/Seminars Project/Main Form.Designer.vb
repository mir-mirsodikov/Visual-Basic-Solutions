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
        Me.chkHealth = New System.Windows.Forms.CheckBox()
        Me.chkMarketing = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chkFinance = New System.Windows.Forms.CheckBox()
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
        'chkHealth
        '
        Me.chkHealth.AutoSize = True
        Me.chkHealth.Location = New System.Drawing.Point(23, 40)
        Me.chkHealth.Name = "chkHealth"
        Me.chkHealth.Size = New System.Drawing.Size(96, 19)
        Me.chkHealth.TabIndex = 3
        Me.chkHealth.Text = "&Health ($125)"
        Me.chkHealth.UseVisualStyleBackColor = True
        '
        'chkMarketing
        '
        Me.chkMarketing.AutoSize = True
        Me.chkMarketing.Location = New System.Drawing.Point(23, 65)
        Me.chkMarketing.Name = "chkMarketing"
        Me.chkMarketing.Size = New System.Drawing.Size(115, 19)
        Me.chkMarketing.TabIndex = 4
        Me.chkMarketing.Text = "&Marketing ($135)"
        Me.chkMarketing.UseVisualStyleBackColor = True
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
        'chkFinance
        '
        Me.chkFinance.AutoSize = True
        Me.chkFinance.Location = New System.Drawing.Point(23, 15)
        Me.chkFinance.Name = "chkFinance"
        Me.chkFinance.Size = New System.Drawing.Size(102, 19)
        Me.chkFinance.TabIndex = 2
        Me.chkFinance.Text = "&Finance ($150)"
        Me.chkFinance.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 139)
        Me.Controls.Add(Me.chkFinance)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.chkMarketing)
        Me.Controls.Add(Me.chkHealth)
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
    Friend WithEvents chkHealth As CheckBox
    Friend WithEvents chkMarketing As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents chkFinance As CheckBox
End Class
