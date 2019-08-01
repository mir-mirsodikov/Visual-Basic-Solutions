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
        Me.radTwin = New System.Windows.Forms.RadioButton()
        Me.radFull = New System.Windows.Forms.RadioButton()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.radKing = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkShipping = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radTwin
        '
        Me.radTwin.AutoSize = True
        Me.radTwin.Location = New System.Drawing.Point(6, 22)
        Me.radTwin.Name = "radTwin"
        Me.radTwin.Size = New System.Drawing.Size(50, 19)
        Me.radTwin.TabIndex = 0
        Me.radTwin.TabStop = True
        Me.radTwin.Text = "&Twin"
        Me.radTwin.UseVisualStyleBackColor = True
        '
        'radFull
        '
        Me.radFull.AutoSize = True
        Me.radFull.Location = New System.Drawing.Point(6, 47)
        Me.radFull.Name = "radFull"
        Me.radFull.Size = New System.Drawing.Size(44, 19)
        Me.radFull.TabIndex = 1
        Me.radFull.TabStop = True
        Me.radFull.Text = "&Full"
        Me.radFull.UseVisualStyleBackColor = True
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Location = New System.Drawing.Point(6, 72)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(60, 19)
        Me.radQueen.TabIndex = 2
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "&Queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'radKing
        '
        Me.radKing.AutoSize = True
        Me.radKing.Location = New System.Drawing.Point(6, 97)
        Me.radKing.Name = "radKing"
        Me.radKing.Size = New System.Drawing.Size(49, 19)
        Me.radKing.TabIndex = 3
        Me.radKing.TabStop = True
        Me.radKing.Text = "&King"
        Me.radKing.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radKing)
        Me.GroupBox1.Controls.Add(Me.radTwin)
        Me.GroupBox1.Controls.Add(Me.radFull)
        Me.GroupBox1.Controls.Add(Me.radQueen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'chkShipping
        '
        Me.chkShipping.AutoSize = True
        Me.chkShipping.Location = New System.Drawing.Point(178, 12)
        Me.chkShipping.Name = "chkShipping"
        Me.chkShipping.Size = New System.Drawing.Size(107, 19)
        Me.chkShipping.TabIndex = 4
        Me.chkShipping.Text = "&Pick up in store"
        Me.chkShipping.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cost:"
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost.Location = New System.Drawing.Point(175, 63)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(110, 28)
        Me.lblCost.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(178, 105)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(110, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "&Display cost"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 206)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkShipping)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radTwin As RadioButton
    Friend WithEvents radFull As RadioButton
    Friend WithEvents radQueen As RadioButton
    Friend WithEvents radKing As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkShipping As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
