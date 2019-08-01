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
        Me.cboLength = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboWidth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboHeight = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboRoll = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRolls = New System.Windows.Forms.Label()
        Me.btnCalcl = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboLength
        '
        Me.cboLength.FormattingEnabled = True
        Me.cboLength.Location = New System.Drawing.Point(12, 43)
        Me.cboLength.Name = "cboLength"
        Me.cboLength.Size = New System.Drawing.Size(97, 23)
        Me.cboLength.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Length (feet):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Width (feet):"
        '
        'cboWidth
        '
        Me.cboWidth.FormattingEnabled = True
        Me.cboWidth.Location = New System.Drawing.Point(164, 43)
        Me.cboWidth.Name = "cboWidth"
        Me.cboWidth.Size = New System.Drawing.Size(97, 23)
        Me.cboWidth.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Height (feet):"
        '
        'cboHeight
        '
        Me.cboHeight.FormattingEnabled = True
        Me.cboHeight.Location = New System.Drawing.Point(312, 43)
        Me.cboHeight.Name = "cboHeight"
        Me.cboHeight.Size = New System.Drawing.Size(97, 23)
        Me.cboHeight.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Roll coverage (sqFt):"
        '
        'cboRoll
        '
        Me.cboRoll.FormattingEnabled = True
        Me.cboRoll.Location = New System.Drawing.Point(455, 43)
        Me.cboRoll.Name = "cboRoll"
        Me.cboRoll.Size = New System.Drawing.Size(97, 23)
        Me.cboRoll.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Single rolls:"
        '
        'lblRolls
        '
        Me.lblRolls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRolls.Location = New System.Drawing.Point(105, 109)
        Me.lblRolls.Name = "lblRolls"
        Me.lblRolls.Size = New System.Drawing.Size(152, 29)
        Me.lblRolls.TabIndex = 11
        Me.lblRolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcl
        '
        Me.btnCalcl.Location = New System.Drawing.Point(263, 109)
        Me.btnCalcl.Name = "btnCalcl"
        Me.btnCalcl.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcl.TabIndex = 8
        Me.btnCalcl.Text = "&Calculate"
        Me.btnCalcl.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 109)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 149)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcl)
        Me.Controls.Add(Me.lblRolls)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRoll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboWidth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLength)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wallpaper Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboLength As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboWidth As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboHeight As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboRoll As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRolls As Label
    Friend WithEvents btnCalcl As Button
    Friend WithEvents btnExit As Button
End Class
