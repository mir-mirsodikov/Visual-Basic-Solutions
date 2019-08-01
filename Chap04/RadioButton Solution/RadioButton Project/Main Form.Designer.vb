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
        Me.radCoffee = New System.Windows.Forms.RadioButton()
        Me.radTea = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radCoffee
        '
        Me.radCoffee.AutoSize = True
        Me.radCoffee.Checked = True
        Me.radCoffee.Location = New System.Drawing.Point(6, 19)
        Me.radCoffee.Name = "radCoffee"
        Me.radCoffee.Size = New System.Drawing.Size(64, 21)
        Me.radCoffee.TabIndex = 1
        Me.radCoffee.TabStop = True
        Me.radCoffee.Text = "&Coffee"
        Me.radCoffee.UseVisualStyleBackColor = True
        '
        'radTea
        '
        Me.radTea.AutoSize = True
        Me.radTea.Location = New System.Drawing.Point(6, 46)
        Me.radTea.Name = "radTea"
        Me.radTea.Size = New System.Drawing.Size(46, 21)
        Me.radTea.TabIndex = 2
        Me.radTea.Text = "&Tea"
        Me.radTea.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(6, 19)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(57, 21)
        Me.radSmall.TabIndex = 3
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "&Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 46)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(74, 21)
        Me.radMedium.TabIndex = 4
        Me.radMedium.Text = "&Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 73)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(59, 21)
        Me.radLarge.TabIndex = 5
        Me.radLarge.Text = "&Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(381, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCoffee)
        Me.GroupBox1.Controls.Add(Me.radTea)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 85)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radLarge)
        Me.GroupBox2.Controls.Add(Me.radMedium)
        Me.GroupBox2.Controls.Add(Me.radSmall)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 124)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Size"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 207)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Radio Button Groups"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radCoffee As RadioButton
    Friend WithEvents radTea As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
