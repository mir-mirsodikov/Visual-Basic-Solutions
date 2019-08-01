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
        Me.txtFailing = New System.Windows.Forms.TextBox()
        Me.txtPassing = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPercentPassing = New System.Windows.Forms.Label()
        Me.lblPercentFailing = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFailing
        '
        Me.txtFailing.Location = New System.Drawing.Point(12, 182)
        Me.txtFailing.Name = "txtFailing"
        Me.txtFailing.Size = New System.Drawing.Size(100, 23)
        Me.txtFailing.TabIndex = 3
        '
        'txtPassing
        '
        Me.txtPassing.Location = New System.Drawing.Point(12, 108)
        Me.txtPassing.Name = "txtPassing"
        Me.txtPassing.Size = New System.Drawing.Size(100, 23)
        Me.txtPassing.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Students &Passing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Students &Failing:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 50)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Percentage of Students Passing:"
        '
        'lblPercentPassing
        '
        Me.lblPercentPassing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentPassing.Location = New System.Drawing.Point(268, 108)
        Me.lblPercentPassing.Name = "lblPercentPassing"
        Me.lblPercentPassing.Size = New System.Drawing.Size(100, 23)
        Me.lblPercentPassing.TabIndex = 6
        '
        'lblPercentFailing
        '
        Me.lblPercentFailing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentFailing.Location = New System.Drawing.Point(268, 182)
        Me.lblPercentFailing.Name = "lblPercentFailing"
        Me.lblPercentFailing.Size = New System.Drawing.Size(100, 23)
        Me.lblPercentFailing.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Percentage of Students Failing:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(268, 281)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 318)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPercentFailing)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPercentPassing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassing)
        Me.Controls.Add(Me.txtFailing)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFailing As TextBox
    Friend WithEvents txtPassing As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPercentPassing As Label
    Friend WithEvents lblPercentFailing As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
End Class
