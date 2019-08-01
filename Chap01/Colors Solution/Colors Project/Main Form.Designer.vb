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
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSpanish = New System.Windows.Forms.Label()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(25, 20)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 0
        Me.btnBlue.Text = "&Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(25, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSpanish
        '
        Me.lblSpanish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpanish.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpanish.Location = New System.Drawing.Point(131, 20)
        Me.lblSpanish.Name = "lblSpanish"
        Me.lblSpanish.Size = New System.Drawing.Size(126, 44)
        Me.lblSpanish.TabIndex = 4
        Me.lblSpanish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(25, 58)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(75, 23)
        Me.btnGreen.TabIndex = 5
        Me.btnGreen.Text = "&Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(25, 96)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 6
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 164)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.lblSpanish)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBlue)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colors in Spanish"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSpanish As Label
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnRed As Button
End Class
