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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTwelve = New System.Windows.Forms.TextBox()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.lblTotalPacks = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&12 pack:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&5 pack:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&2 pack:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'txtTwelve
        '
        Me.txtTwelve.Location = New System.Drawing.Point(109, 46)
        Me.txtTwelve.Name = "txtTwelve"
        Me.txtTwelve.Size = New System.Drawing.Size(52, 23)
        Me.txtTwelve.TabIndex = 1
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(109, 95)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(52, 23)
        Me.txtFive.TabIndex = 3
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(109, 144)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(52, 23)
        Me.txtTwo.TabIndex = 5
        '
        'lblTotalPacks
        '
        Me.lblTotalPacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPacks.Location = New System.Drawing.Point(109, 193)
        Me.lblTotalPacks.Name = "lblTotalPacks"
        Me.lblTotalPacks.Size = New System.Drawing.Size(52, 23)
        Me.lblTotalPacks.TabIndex = 7
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(184, 193)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(95, 23)
        Me.lblTotalPrice.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(50, 279)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(204, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 348)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotalPacks)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.txtTwelve)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTwelve As TextBox
    Friend WithEvents txtFive As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents lblTotalPacks As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
