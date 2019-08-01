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
        Me.radPremium = New System.Windows.Forms.RadioButton()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPink = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.chkFold = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPremium)
        Me.GroupBox1.Controls.Add(Me.radDeluxe)
        Me.GroupBox1.Controls.Add(Me.radStandard)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'radPremium
        '
        Me.radPremium.AutoSize = True
        Me.radPremium.Location = New System.Drawing.Point(15, 88)
        Me.radPremium.Name = "radPremium"
        Me.radPremium.Size = New System.Drawing.Size(109, 19)
        Me.radPremium.TabIndex = 2
        Me.radPremium.Text = "&Premium ($179)"
        Me.radPremium.UseVisualStyleBackColor = True
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Location = New System.Drawing.Point(15, 55)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(95, 19)
        Me.radDeluxe.TabIndex = 1
        Me.radDeluxe.Text = "&Deluxe ($129)"
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(15, 22)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(101, 19)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "&Standard ($99)"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radPink)
        Me.GroupBox2.Controls.Add(Me.radRed)
        Me.GroupBox2.Controls.Add(Me.radBlue)
        Me.GroupBox2.Location = New System.Drawing.Point(181, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 115)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color"
        '
        'radPink
        '
        Me.radPink.AutoSize = True
        Me.radPink.Location = New System.Drawing.Point(16, 88)
        Me.radPink.Name = "radPink"
        Me.radPink.Size = New System.Drawing.Size(105, 19)
        Me.radPink.TabIndex = 2
        Me.radPink.Text = "Pin&k ($15 Extra)"
        Me.radPink.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(16, 55)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(102, 19)
        Me.radRed.TabIndex = 1
        Me.radRed.Text = "&Red ($10 Extra)"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Checked = True
        Me.radBlue.Location = New System.Drawing.Point(16, 22)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(48, 19)
        Me.radBlue.TabIndex = 0
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "&Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'chkFold
        '
        Me.chkFold.AutoSize = True
        Me.chkFold.Location = New System.Drawing.Point(346, 47)
        Me.chkFold.Name = "chkFold"
        Me.chkFold.Size = New System.Drawing.Size(128, 19)
        Me.chkFold.TabIndex = 2
        Me.chkFold.Text = "&Foldable ($25 extra)"
        Me.chkFold.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(376, 80)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 27)
        Me.lblTotal.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(332, 117)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(413, 117)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 166)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFold)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mats-R-Us"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radPremium As RadioButton
    Friend WithEvents radDeluxe As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radPink As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents chkFold As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
