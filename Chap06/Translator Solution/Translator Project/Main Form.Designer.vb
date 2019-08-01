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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLang = New System.Windows.Forms.ComboBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBrother)
        Me.GroupBox1.Controls.Add(Me.radSister)
        Me.GroupBox1.Controls.Add(Me.radFather)
        Me.GroupBox1.Controls.Add(Me.radMother)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "English"
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(7, 129)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(64, 19)
        Me.radBrother.TabIndex = 3
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(7, 93)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(53, 19)
        Me.radSister.TabIndex = 2
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(7, 58)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(58, 19)
        Me.radFather.TabIndex = 1
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(7, 22)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(64, 19)
        Me.radMother.TabIndex = 0
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T&ranslate to:"
        '
        'cboLang
        '
        Me.cboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLang.FormattingEnabled = True
        Me.cboLang.Location = New System.Drawing.Point(172, 45)
        Me.cboLang.Name = "cboLang"
        Me.cboLang.Size = New System.Drawing.Size(139, 23)
        Me.cboLang.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(172, 111)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(140, 53)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(349, 47)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(87, 27)
        Me.btnTranslate.TabIndex = 3
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 98)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboLanguage
        '
        Me.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(172, 49)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(139, 21)
        Me.cboLanguage.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 188)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cboLang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Translator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radMother As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cboLang As ComboBox
End Class
