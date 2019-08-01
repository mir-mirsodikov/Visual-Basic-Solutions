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
        Me.lstCandidate = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStone = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPatel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPerez = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Candidate:"
        '
        'lstCandidate
        '
        Me.lstCandidate.FormattingEnabled = True
        Me.lstCandidate.ItemHeight = 15
        Me.lstCandidate.Location = New System.Drawing.Point(12, 70)
        Me.lstCandidate.Name = "lstCandidate"
        Me.lstCandidate.Size = New System.Drawing.Size(120, 64)
        Me.lstCandidate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mark Stone:"
        '
        'lblStone
        '
        Me.lblStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStone.Location = New System.Drawing.Point(34, 238)
        Me.lblStone.Name = "lblStone"
        Me.lblStone.Size = New System.Drawing.Size(54, 24)
        Me.lblStone.TabIndex = 3
        Me.lblStone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(220, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save Vote"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblPatel
        '
        Me.lblPatel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPatel.Location = New System.Drawing.Point(145, 238)
        Me.lblPatel.Name = "lblPatel"
        Me.lblPatel.Size = New System.Drawing.Size(54, 24)
        Me.lblPatel.TabIndex = 6
        Me.lblPatel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sheima Patel:"
        '
        'lblPerez
        '
        Me.lblPerez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPerez.Location = New System.Drawing.Point(264, 238)
        Me.lblPerez.Name = "lblPerez"
        Me.lblPerez.Size = New System.Drawing.Size(54, 24)
        Me.lblPerez.TabIndex = 8
        Me.lblPerez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(261, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sam Perez:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(220, 117)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(105, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Display Vote"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 153)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Location = New System.Drawing.Point(9, 291)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(89, 15)
        Me.lblSuccess.TabIndex = 9
        Me.lblSuccess.Text = "Save succesfull."
        Me.lblSuccess.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 315)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblPerez)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPatel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstCandidate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StuCo Voting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstCandidate As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStone As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPatel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPerez As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSuccess As Label
End Class
