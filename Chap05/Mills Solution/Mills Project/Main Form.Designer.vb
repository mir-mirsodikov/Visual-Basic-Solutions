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
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRecordScore = New System.Windows.Forms.Button()
        Me.btnNewSkater = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNumOfScores = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 15
        Me.lstScores.Location = New System.Drawing.Point(26, 51)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(53, 169)
        Me.lstScores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Score:"
        '
        'btnRecordScore
        '
        Me.btnRecordScore.Location = New System.Drawing.Point(112, 51)
        Me.btnRecordScore.Name = "btnRecordScore"
        Me.btnRecordScore.Size = New System.Drawing.Size(132, 23)
        Me.btnRecordScore.TabIndex = 2
        Me.btnRecordScore.Text = "&Record score"
        Me.btnRecordScore.UseVisualStyleBackColor = True
        '
        'btnNewSkater
        '
        Me.btnNewSkater.Location = New System.Drawing.Point(261, 51)
        Me.btnNewSkater.Name = "btnNewSkater"
        Me.btnNewSkater.Size = New System.Drawing.Size(132, 23)
        Me.btnNewSkater.TabIndex = 3
        Me.btnNewSkater.Text = "&Next skater"
        Me.btnNewSkater.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(409, 51)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAverageScore)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblNumOfScores)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblTotalScore)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 184)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblAverageScore
        '
        Me.lblAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageScore.Location = New System.Drawing.Point(9, 145)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(83, 21)
        Me.lblAverageScore.TabIndex = 5
        Me.lblAverageScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Average score:"
        '
        'lblNumOfScores
        '
        Me.lblNumOfScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumOfScores.Location = New System.Drawing.Point(9, 89)
        Me.lblNumOfScores.Name = "lblNumOfScores"
        Me.lblNumOfScores.Size = New System.Drawing.Size(83, 21)
        Me.lblNumOfScores.TabIndex = 3
        Me.lblNumOfScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Number of scores:"
        '
        'lblTotalScore
        '
        Me.lblTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScore.Location = New System.Drawing.Point(9, 34)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(83, 21)
        Me.lblTotalScore.TabIndex = 1
        Me.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total score:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 327)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewSkater)
        Me.Controls.Add(Me.btnRecordScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstScores)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mills Skating Rink"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstScores As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRecordScore As Button
    Friend WithEvents btnNewSkater As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAverageScore As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumOfScores As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents Label2 As Label
End Class
