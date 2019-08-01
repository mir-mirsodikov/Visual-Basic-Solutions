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
        Me.txtCar1MPG = New System.Windows.Forms.TextBox()
        Me.txtCar1CPG = New System.Windows.Forms.TextBox()
        Me.txtCar2MPG = New System.Windows.Forms.TextBox()
        Me.txtCar2CPG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalMiles = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCar1Total = New System.Windows.Forms.Label()
        Me.btnWhichCar = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCar2Total = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCarChoice = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCar1MPG
        '
        Me.txtCar1MPG.Location = New System.Drawing.Point(102, 61)
        Me.txtCar1MPG.Name = "txtCar1MPG"
        Me.txtCar1MPG.Size = New System.Drawing.Size(100, 23)
        Me.txtCar1MPG.TabIndex = 1
        '
        'txtCar1CPG
        '
        Me.txtCar1CPG.Location = New System.Drawing.Point(102, 111)
        Me.txtCar1CPG.Name = "txtCar1CPG"
        Me.txtCar1CPG.Size = New System.Drawing.Size(100, 23)
        Me.txtCar1CPG.TabIndex = 3
        '
        'txtCar2MPG
        '
        Me.txtCar2MPG.Location = New System.Drawing.Point(116, 55)
        Me.txtCar2MPG.Name = "txtCar2MPG"
        Me.txtCar2MPG.Size = New System.Drawing.Size(100, 23)
        Me.txtCar2MPG.TabIndex = 1
        '
        'txtCar2CPG
        '
        Me.txtCar2CPG.Location = New System.Drawing.Point(116, 102)
        Me.txtCar2CPG.Name = "txtCar2CPG"
        Me.txtCar2CPG.Size = New System.Drawing.Size(100, 23)
        Me.txtCar2CPG.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Car 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Miles Per Gallon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost Per Gallon:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cost Per Gallon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Car 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Miles Per Gallon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total miles to drive:"
        '
        'txtTotalMiles
        '
        Me.txtTotalMiles.Location = New System.Drawing.Point(128, 31)
        Me.txtTotalMiles.Name = "txtTotalMiles"
        Me.txtTotalMiles.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalMiles.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Car 1 Total Cost:"
        '
        'lblCar1Total
        '
        Me.lblCar1Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCar1Total.Location = New System.Drawing.Point(113, 258)
        Me.lblCar1Total.Name = "lblCar1Total"
        Me.lblCar1Total.Size = New System.Drawing.Size(100, 23)
        Me.lblCar1Total.TabIndex = 13
        '
        'btnWhichCar
        '
        Me.btnWhichCar.Location = New System.Drawing.Point(298, 352)
        Me.btnWhichCar.Name = "btnWhichCar"
        Me.btnWhichCar.Size = New System.Drawing.Size(75, 23)
        Me.btnWhichCar.TabIndex = 4
        Me.btnWhichCar.Text = "&Which Car?"
        Me.btnWhichCar.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(408, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCar2Total
        '
        Me.lblCar2Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCar2Total.Location = New System.Drawing.Point(383, 258)
        Me.lblCar2Total.Name = "lblCar2Total"
        Me.lblCar2Total.Size = New System.Drawing.Size(100, 23)
        Me.lblCar2Total.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Car 2 Total Cost:"
        '
        'lblCarChoice
        '
        Me.lblCarChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarChoice.Location = New System.Drawing.Point(113, 310)
        Me.lblCarChoice.Name = "lblCarChoice"
        Me.lblCarChoice.Size = New System.Drawing.Size(100, 23)
        Me.lblCarChoice.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Best car to use:"
        '
        'lblSavings
        '
        Me.lblSavings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSavings.Location = New System.Drawing.Point(383, 310)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(100, 23)
        Me.lblSavings.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(284, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Savings:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCar1CPG)
        Me.GroupBox1.Controls.Add(Me.txtCar1MPG)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 180)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Car 1 Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCar2CPG)
        Me.GroupBox2.Controls.Add(Me.txtCar2MPG)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 180)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Car 2 Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(91, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 30)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Car 2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 387)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCarChoice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCar2Total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWhichCar)
        Me.Controls.Add(Me.lblCar1Total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalMiles)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCar1MPG As TextBox
    Friend WithEvents txtCar1CPG As TextBox
    Friend WithEvents txtCar2MPG As TextBox
    Friend WithEvents txtCar2CPG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalMiles As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCar1Total As Label
    Friend WithEvents btnWhichCar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCar2Total As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCarChoice As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblSavings As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
End Class
