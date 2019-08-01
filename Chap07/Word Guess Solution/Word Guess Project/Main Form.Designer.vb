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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.grpLetter = New System.Windows.Forms.GroupBox()
        Me.btnTryLetter = New System.Windows.Forms.Button()
        Me.btnNewWord = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpWord = New System.Windows.Forms.GroupBox()
        Me.grpLetter.SuspendLayout()
        Me.grpWord.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Word (5 letters):"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(120, 25)
        Me.txtWord.MaxLength = 5
        Me.txtWord.Name = "txtWord"
        Me.txtWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtWord.Size = New System.Drawing.Size(79, 23)
        Me.txtWord.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Letter:"
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(69, 22)
        Me.txtLetter.MaxLength = 1
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(32, 23)
        Me.txtLetter.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(71, 55)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(126, 24)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLetter
        '
        Me.grpLetter.Controls.Add(Me.btnTryLetter)
        Me.grpLetter.Controls.Add(Me.txtLetter)
        Me.grpLetter.Controls.Add(Me.lblResult)
        Me.grpLetter.Controls.Add(Me.Label2)
        Me.grpLetter.Controls.Add(Me.Label3)
        Me.grpLetter.Enabled = False
        Me.grpLetter.Location = New System.Drawing.Point(55, 98)
        Me.grpLetter.Name = "grpLetter"
        Me.grpLetter.Size = New System.Drawing.Size(221, 100)
        Me.grpLetter.TabIndex = 1
        Me.grpLetter.TabStop = False
        '
        'btnTryLetter
        '
        Me.btnTryLetter.Location = New System.Drawing.Point(108, 22)
        Me.btnTryLetter.Name = "btnTryLetter"
        Me.btnTryLetter.Size = New System.Drawing.Size(89, 23)
        Me.btnTryLetter.TabIndex = 2
        Me.btnTryLetter.Text = "&Try this letter"
        Me.btnTryLetter.UseVisualStyleBackColor = True
        '
        'btnNewWord
        '
        Me.btnNewWord.Location = New System.Drawing.Point(215, 24)
        Me.btnNewWord.Name = "btnNewWord"
        Me.btnNewWord.Size = New System.Drawing.Size(84, 23)
        Me.btnNewWord.TabIndex = 2
        Me.btnNewWord.Text = "&New word"
        Me.btnNewWord.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(294, 175)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpWord
        '
        Me.grpWord.Controls.Add(Me.Label1)
        Me.grpWord.Controls.Add(Me.txtWord)
        Me.grpWord.Controls.Add(Me.btnNewWord)
        Me.grpWord.Location = New System.Drawing.Point(52, 29)
        Me.grpWord.Name = "grpWord"
        Me.grpWord.Size = New System.Drawing.Size(326, 63)
        Me.grpWord.TabIndex = 0
        Me.grpWord.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnTryLetter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 226)
        Me.Controls.Add(Me.grpWord)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpLetter)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess the Word Game"
        Me.grpLetter.ResumeLayout(False)
        Me.grpLetter.PerformLayout()
        Me.grpWord.ResumeLayout(False)
        Me.grpWord.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents grpLetter As GroupBox
    Friend WithEvents btnTryLetter As Button
    Friend WithEvents btnNewWord As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpWord As GroupBox
End Class
