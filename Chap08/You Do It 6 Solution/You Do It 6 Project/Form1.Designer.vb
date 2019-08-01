<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstOne = New System.Windows.Forms.ListBox()
        Me.lstTwo = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOne
        '
        Me.lstOne.FormattingEnabled = True
        Me.lstOne.ItemHeight = 16
        Me.lstOne.Location = New System.Drawing.Point(16, 15)
        Me.lstOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstOne.Name = "lstOne"
        Me.lstOne.Size = New System.Drawing.Size(159, 164)
        Me.lstOne.TabIndex = 0
        '
        'lstTwo
        '
        Me.lstTwo.FormattingEnabled = True
        Me.lstTwo.ItemHeight = 16
        Me.lstTwo.Location = New System.Drawing.Point(203, 15)
        Me.lstTwo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstTwo.Name = "lstTwo"
        Me.lstTwo.Size = New System.Drawing.Size(159, 164)
        Me.lstTwo.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 201)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstTwo)
        Me.Controls.Add(Me.lstOne)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOne As ListBox
    Friend WithEvents lstTwo As ListBox
    Friend WithEvents Button1 As Button
End Class
