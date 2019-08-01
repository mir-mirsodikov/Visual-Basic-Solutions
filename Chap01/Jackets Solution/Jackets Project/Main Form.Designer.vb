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
        Me.picChart = New System.Windows.Forms.PictureBox()
        Me.picJacket = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSize = New System.Windows.Forms.Button()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChart
        '
        Me.picChart.Image = Global.Jackets_Project.My.Resources.Resources.SizeChart
        Me.picChart.Location = New System.Drawing.Point(451, 112)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(470, 263)
        Me.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChart.TabIndex = 1
        Me.picChart.TabStop = False
        Me.picChart.Visible = False
        '
        'picJacket
        '
        Me.picJacket.Image = Global.Jackets_Project.My.Resources.Resources.BlackJacket
        Me.picJacket.Location = New System.Drawing.Point(12, 12)
        Me.picJacket.Name = "picJacket"
        Me.picJacket.Size = New System.Drawing.Size(433, 456)
        Me.picJacket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJacket.TabIndex = 0
        Me.picJacket.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(762, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 39)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSize
        '
        Me.btnSize.Location = New System.Drawing.Point(488, 40)
        Me.btnSize.Name = "btnSize"
        Me.btnSize.Size = New System.Drawing.Size(110, 39)
        Me.btnSize.TabIndex = 3
        Me.btnSize.Text = "&Size chart"
        Me.btnSize.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.picJacket)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jackets and More"
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picJacket As PictureBox
    Friend WithEvents picChart As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSize As Button
End Class
