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
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radSubtract = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.lstProblems = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(322, 209)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(91, 23)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "&Check Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(419, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Problem:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(399, 86)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(123, 23)
        Me.txtAnswer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ans&wer:"
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(6, 22)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(71, 19)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "&Addition"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDivision)
        Me.GroupBox1.Controls.Add(Me.radMultiplication)
        Me.GroupBox1.Controls.Add(Me.radSubtract)
        Me.GroupBox1.Controls.Add(Me.radAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Problem Type"
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(6, 94)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(67, 19)
        Me.radDivision.TabIndex = 3
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "&Division"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(6, 70)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(99, 19)
        Me.radMultiplication.TabIndex = 2
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "&Multiplication"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radSubtract
        '
        Me.radSubtract.AutoSize = True
        Me.radSubtract.Location = New System.Drawing.Point(6, 46)
        Me.radSubtract.Name = "radSubtract"
        Me.radSubtract.Size = New System.Drawing.Size(86, 19)
        Me.radSubtract.TabIndex = 1
        Me.radSubtract.TabStop = True
        Me.radSubtract.Text = "&Subtraction"
        Me.radSubtract.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Correct answers:"
        '
        'lblCorrect
        '
        Me.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorrect.Location = New System.Drawing.Point(228, 168)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(93, 26)
        Me.lblCorrect.TabIndex = 9
        Me.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrect
        '
        Me.lblIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncorrect.Location = New System.Drawing.Point(327, 168)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(93, 26)
        Me.lblIncorrect.TabIndex = 11
        Me.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Incorrect answers:"
        '
        'lblProblem
        '
        Me.lblProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProblem.Location = New System.Drawing.Point(399, 34)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(123, 26)
        Me.lblProblem.TabIndex = 12
        Me.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewProblem
        '
        Me.btnNewProblem.Location = New System.Drawing.Point(228, 209)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(91, 23)
        Me.btnNewProblem.TabIndex = 1
        Me.btnNewProblem.Text = "&New Problem"
        Me.btnNewProblem.UseVisualStyleBackColor = True
        '
        'lstProblems
        '
        Me.lstProblems.FormattingEnabled = True
        Me.lstProblems.ItemHeight = 15
        Me.lstProblems.Location = New System.Drawing.Point(569, 30)
        Me.lstProblems.Name = "lstProblems"
        Me.lstProblems.Size = New System.Drawing.Size(120, 169)
        Me.lstProblems.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(566, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Answered problems:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(547, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Problem #:"
        '
        'lblIndex
        '
        Me.lblIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndex.Location = New System.Drawing.Point(618, 209)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(71, 25)
        Me.lblIndex.TabIndex = 19
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercentage
        '
        Me.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentage.Location = New System.Drawing.Point(426, 168)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(93, 26)
        Me.lblPercentage.TabIndex = 21
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(423, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Percentage:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Challenge_Project.My.Resources.Resources.equations
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 116)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(203, 136)
        Me.lblInfo.TabIndex = 23
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnAnswer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 261)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstProblems)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnswer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Practice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents radAdd As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDivision As RadioButton
    Friend WithEvents radMultiplication As RadioButton
    Friend WithEvents radSubtract As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblProblem As Label
    Friend WithEvents btnNewProblem As Button
    Friend WithEvents lstProblems As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblIndex As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInfo As Label
End Class
