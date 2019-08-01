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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCentimeters = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblConvertInches = New System.Windows.Forms.Label()
        Me.lblConvertFeet = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblConvertMeters = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblConvertCentimeters = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Measurement in Centi&meters:"
        '
        'txtCentimeters
        '
        Me.txtCentimeters.Location = New System.Drawing.Point(15, 101)
        Me.txtCentimeters.Name = "txtCentimeters"
        Me.txtCentimeters.Size = New System.Drawing.Size(100, 23)
        Me.txtCentimeters.TabIndex = 1
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(409, 101)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(100, 23)
        Me.txtInches.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Measurement in &Inches:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Or"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "In Inches:"
        '
        'lblConvertInches
        '
        Me.lblConvertInches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertInches.Location = New System.Drawing.Point(15, 200)
        Me.lblConvertInches.Name = "lblConvertInches"
        Me.lblConvertInches.Size = New System.Drawing.Size(100, 23)
        Me.lblConvertInches.TabIndex = 7
        '
        'lblConvertFeet
        '
        Me.lblConvertFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertFeet.Location = New System.Drawing.Point(15, 262)
        Me.lblConvertFeet.Name = "lblConvertFeet"
        Me.lblConvertFeet.Size = New System.Drawing.Size(100, 23)
        Me.lblConvertFeet.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "In Feet:"
        '
        'lblConvertMeters
        '
        Me.lblConvertMeters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertMeters.Location = New System.Drawing.Point(409, 262)
        Me.lblConvertMeters.Name = "lblConvertMeters"
        Me.lblConvertMeters.Size = New System.Drawing.Size(100, 23)
        Me.lblConvertMeters.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(406, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "In Meters:"
        '
        'lblConvertCentimeters
        '
        Me.lblConvertCentimeters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertCentimeters.Location = New System.Drawing.Point(409, 200)
        Me.lblConvertCentimeters.Name = "lblConvertCentimeters"
        Me.lblConvertCentimeters.Size = New System.Drawing.Size(100, 23)
        Me.lblConvertCentimeters.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(406, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "In Centimeters:"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(286, 337)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(94, 33)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(415, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 411)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblConvertMeters)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblConvertCentimeters)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblConvertFeet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblConvertInches)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCentimeters)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCentimeters As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblConvertInches As Label
    Friend WithEvents lblConvertFeet As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblConvertMeters As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblConvertCentimeters As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
End Class
