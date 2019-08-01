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
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.btnAndAlso = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOrElse = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Hours worked:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(60, 37)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(51, 23)
        Me.txtHours.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hourly &rate:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(169, 37)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(51, 23)
        Me.txtRate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gross pay:"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(274, 36)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(78, 23)
        Me.lblGross.TabIndex = 8
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAndAlso
        '
        Me.btnAndAlso.Location = New System.Drawing.Point(31, 88)
        Me.btnAndAlso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAndAlso.Name = "btnAndAlso"
        Me.btnAndAlso.Size = New System.Drawing.Size(130, 23)
        Me.btnAndAlso.TabIndex = 4
        Me.btnAndAlso.Text = "Calculate-&AndAlso"
        Me.btnAndAlso.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(302, 88)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOrElse
        '
        Me.btnOrElse.Location = New System.Drawing.Point(166, 88)
        Me.btnOrElse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOrElse.Name = "btnOrElse"
        Me.btnOrElse.Size = New System.Drawing.Size(130, 23)
        Me.btnOrElse.TabIndex = 5
        Me.btnOrElse.Text = "Calculate-&OrElse"
        Me.btnOrElse.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 132)
        Me.Controls.Add(Me.btnOrElse)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAndAlso)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gross Pay Calculator"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents btnAndAlso As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOrElse As Button
End Class
