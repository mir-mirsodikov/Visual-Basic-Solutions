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
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(192, 51)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnPrice.TabIndex = 0
        Me.btnPrice.Text = "&Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblShow
        '
        Me.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow.Location = New System.Drawing.Point(40, 100)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(100, 23)
        Me.lblShow.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(40, 51)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtPrice.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 270)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.btnPrice)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You Do It 6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrice As Button
    Friend WithEvents lblShow As Label
    Friend WithEvents txtPrice As TextBox
End Class
