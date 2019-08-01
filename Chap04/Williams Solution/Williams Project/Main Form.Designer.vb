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
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radDiamond = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCinnematic = New System.Windows.Forms.CheckBox()
        Me.chkHBI = New System.Windows.Forms.CheckBox()
        Me.chkShowtimer = New System.Windows.Forms.CheckBox()
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonthlyBill = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Location = New System.Drawing.Point(6, 22)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(52, 19)
        Me.radBasic.TabIndex = 0
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "&Basic"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(6, 57)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(53, 19)
        Me.radSilver.TabIndex = 1
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "&Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(6, 92)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(50, 19)
        Me.radGold.TabIndex = 2
        Me.radGold.TabStop = True
        Me.radGold.Text = "&Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radDiamond
        '
        Me.radDiamond.AutoSize = True
        Me.radDiamond.Location = New System.Drawing.Point(6, 127)
        Me.radDiamond.Name = "radDiamond"
        Me.radDiamond.Size = New System.Drawing.Size(74, 19)
        Me.radDiamond.TabIndex = 3
        Me.radDiamond.TabStop = True
        Me.radDiamond.Text = "&Diamond"
        Me.radDiamond.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDiamond)
        Me.GroupBox1.Controls.Add(Me.radGold)
        Me.GroupBox1.Controls.Add(Me.radSilver)
        Me.GroupBox1.Controls.Add(Me.radBasic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 168)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packages"
        '
        'chkCinnematic
        '
        Me.chkCinnematic.AutoSize = True
        Me.chkCinnematic.Location = New System.Drawing.Point(19, 15)
        Me.chkCinnematic.Name = "chkCinnematic"
        Me.chkCinnematic.Size = New System.Drawing.Size(173, 19)
        Me.chkCinnematic.TabIndex = 5
        Me.chkCinnematic.Text = "Ci&nnematic movie channels"
        Me.chkCinnematic.UseVisualStyleBackColor = True
        '
        'chkHBI
        '
        Me.chkHBI.AutoSize = True
        Me.chkHBI.Location = New System.Drawing.Point(19, 43)
        Me.chkHBI.Name = "chkHBI"
        Me.chkHBI.Size = New System.Drawing.Size(131, 19)
        Me.chkHBI.TabIndex = 6
        Me.chkHBI.Text = "&HBI movie channels"
        Me.chkHBI.UseVisualStyleBackColor = True
        '
        'chkShowtimer
        '
        Me.chkShowtimer.AutoSize = True
        Me.chkShowtimer.Location = New System.Drawing.Point(19, 71)
        Me.chkShowtimer.Name = "chkShowtimer"
        Me.chkShowtimer.Size = New System.Drawing.Size(169, 19)
        Me.chkShowtimer.TabIndex = 7
        Me.chkShowtimer.Text = "Sho&wtimer movie channels"
        Me.chkShowtimer.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(19, 99)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(98, 19)
        Me.chkLocal.TabIndex = 8
        Me.chkLocal.Text = "&Local stations"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkLocal)
        Me.GroupBox2.Controls.Add(Me.chkShowtimer)
        Me.GroupBox2.Controls.Add(Me.chkHBI)
        Me.GroupBox2.Controls.Add(Me.chkCinnematic)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 133)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional features"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Monthly cable bill:"
        '
        'lblMonthlyBill
        '
        Me.lblMonthlyBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyBill.Location = New System.Drawing.Point(18, 213)
        Me.lblMonthlyBill.Name = "lblMonthlyBill"
        Me.lblMonthlyBill.Size = New System.Drawing.Size(115, 31)
        Me.lblMonthlyBill.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(240, 248)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(346, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 292)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMonthlyBill)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Williams Cable Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radBasic As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radDiamond As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCinnematic As CheckBox
    Friend WithEvents chkHBI As CheckBox
    Friend WithEvents chkShowtimer As CheckBox
    Friend WithEvents chkLocal As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMonthlyBill As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
