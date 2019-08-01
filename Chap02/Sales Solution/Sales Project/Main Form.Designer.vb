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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKaren = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMartin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblJimPercentage = New System.Windows.Forms.Label()
        Me.lblKarenPercentage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMartinPercentage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(21, 108)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Total Sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Jim's Sales:"
        '
        'txtJim
        '
        Me.txtJim.Location = New System.Drawing.Point(21, 172)
        Me.txtJim.Name = "txtJim"
        Me.txtJim.Size = New System.Drawing.Size(100, 23)
        Me.txtJim.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Karen's Sales:"
        '
        'txtKaren
        '
        Me.txtKaren.Location = New System.Drawing.Point(21, 236)
        Me.txtKaren.Name = "txtKaren"
        Me.txtKaren.Size = New System.Drawing.Size(100, 23)
        Me.txtKaren.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&Martin's Sales:"
        '
        'txtMartin
        '
        Me.txtMartin.Location = New System.Drawing.Point(21, 300)
        Me.txtMartin.Name = "txtMartin"
        Me.txtMartin.Size = New System.Drawing.Size(100, 23)
        Me.txtMartin.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jim's Sales Percentage:"
        '
        'lblJimPercentage
        '
        Me.lblJimPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJimPercentage.Location = New System.Drawing.Point(223, 172)
        Me.lblJimPercentage.Name = "lblJimPercentage"
        Me.lblJimPercentage.Size = New System.Drawing.Size(100, 23)
        Me.lblJimPercentage.TabIndex = 10
        '
        'lblKarenPercentage
        '
        Me.lblKarenPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKarenPercentage.Location = New System.Drawing.Point(223, 236)
        Me.lblKarenPercentage.Name = "lblKarenPercentage"
        Me.lblKarenPercentage.Size = New System.Drawing.Size(100, 23)
        Me.lblKarenPercentage.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(220, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Karen's Sales Percantage:"
        '
        'lblMartinPercentage
        '
        Me.lblMartinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMartinPercentage.Location = New System.Drawing.Point(223, 300)
        Me.lblMartinPercentage.Name = "lblMartinPercentage"
        Me.lblMartinPercentage.Size = New System.Drawing.Size(100, 23)
        Me.lblMartinPercentage.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Martin's Sales Percentage:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(171, 389)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(289, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 455)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMartinPercentage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblKarenPercentage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblJimPercentage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMartin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKaren)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKaren As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMartin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblJimPercentage As Label
    Friend WithEvents lblKarenPercentage As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMartinPercentage As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
