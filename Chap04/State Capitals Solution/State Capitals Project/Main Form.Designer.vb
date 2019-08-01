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
        Me.radAlabama = New System.Windows.Forms.RadioButton()
        Me.radCalifornia = New System.Windows.Forms.RadioButton()
        Me.radDelaware = New System.Windows.Forms.RadioButton()
        Me.radFlorida = New System.Windows.Forms.RadioButton()
        Me.radGeorgia = New System.Windows.Forms.RadioButton()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radAlabama
        '
        Me.radAlabama.AutoSize = True
        Me.radAlabama.Location = New System.Drawing.Point(12, 12)
        Me.radAlabama.Name = "radAlabama"
        Me.radAlabama.Size = New System.Drawing.Size(72, 19)
        Me.radAlabama.TabIndex = 0
        Me.radAlabama.TabStop = True
        Me.radAlabama.Text = "&Alabama"
        Me.radAlabama.UseVisualStyleBackColor = True
        '
        'radCalifornia
        '
        Me.radCalifornia.AutoSize = True
        Me.radCalifornia.Location = New System.Drawing.Point(12, 37)
        Me.radCalifornia.Name = "radCalifornia"
        Me.radCalifornia.Size = New System.Drawing.Size(76, 19)
        Me.radCalifornia.TabIndex = 1
        Me.radCalifornia.TabStop = True
        Me.radCalifornia.Text = "&California"
        Me.radCalifornia.UseVisualStyleBackColor = True
        '
        'radDelaware
        '
        Me.radDelaware.AutoSize = True
        Me.radDelaware.Location = New System.Drawing.Point(12, 62)
        Me.radDelaware.Name = "radDelaware"
        Me.radDelaware.Size = New System.Drawing.Size(73, 19)
        Me.radDelaware.TabIndex = 2
        Me.radDelaware.TabStop = True
        Me.radDelaware.Text = "Dela&ware"
        Me.radDelaware.UseVisualStyleBackColor = True
        '
        'radFlorida
        '
        Me.radFlorida.AutoSize = True
        Me.radFlorida.Location = New System.Drawing.Point(12, 87)
        Me.radFlorida.Name = "radFlorida"
        Me.radFlorida.Size = New System.Drawing.Size(61, 19)
        Me.radFlorida.TabIndex = 3
        Me.radFlorida.TabStop = True
        Me.radFlorida.Text = "&Florida"
        Me.radFlorida.UseVisualStyleBackColor = True
        '
        'radGeorgia
        '
        Me.radGeorgia.AutoSize = True
        Me.radGeorgia.Location = New System.Drawing.Point(12, 112)
        Me.radGeorgia.Name = "radGeorgia"
        Me.radGeorgia.Size = New System.Drawing.Size(66, 19)
        Me.radGeorgia.TabIndex = 4
        Me.radGeorgia.TabStop = True
        Me.radGeorgia.Text = "&Georgia"
        Me.radGeorgia.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCapital.Location = New System.Drawing.Point(180, 38)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(110, 25)
        Me.lblCapital.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(146, 112)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "State Capital:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 171)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.radGeorgia)
        Me.Controls.Add(Me.radFlorida)
        Me.Controls.Add(Me.radDelaware)
        Me.Controls.Add(Me.radCalifornia)
        Me.Controls.Add(Me.radAlabama)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Capitals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radAlabama As RadioButton
    Friend WithEvents radCalifornia As RadioButton
    Friend WithEvents radDelaware As RadioButton
    Friend WithEvents radFlorida As RadioButton
    Friend WithEvents radGeorgia As RadioButton
    Friend WithEvents lblCapital As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
