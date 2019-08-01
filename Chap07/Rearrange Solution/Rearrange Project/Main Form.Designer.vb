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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRearranged = New System.Windows.Forms.Label()
        Me.btnRearrange = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name (first, space, last):"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(29, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 23)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rearranged name (last, comma, space, first):"
        '
        'lblRearranged
        '
        Me.lblRearranged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRearranged.Location = New System.Drawing.Point(29, 103)
        Me.lblRearranged.Name = "lblRearranged"
        Me.lblRearranged.Size = New System.Drawing.Size(268, 30)
        Me.lblRearranged.TabIndex = 5
        Me.lblRearranged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRearrange
        '
        Me.btnRearrange.Location = New System.Drawing.Point(103, 149)
        Me.btnRearrange.Name = "btnRearrange"
        Me.btnRearrange.Size = New System.Drawing.Size(123, 30)
        Me.btnRearrange.TabIndex = 2
        Me.btnRearrange.Text = "&Rearrange the name"
        Me.btnRearrange.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 207)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRearrange)
        Me.Controls.Add(Me.lblRearranged)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rearrange Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRearranged As System.Windows.Forms.Label
    Friend WithEvents btnRearrange As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
