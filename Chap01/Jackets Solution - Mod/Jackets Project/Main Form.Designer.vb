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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSize = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnBrown = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.picChart = New System.Windows.Forms.PictureBox()
        Me.picJacket = New System.Windows.Forms.PictureBox()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnBlack
        '
        Me.btnBlack.Location = New System.Drawing.Point(65, 496)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(110, 39)
        Me.btnBlack.TabIndex = 4
        Me.btnBlack.Text = "&Black"
        Me.btnBlack.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(275, 496)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(110, 39)
        Me.btnBlue.TabIndex = 5
        Me.btnBlue.Text = "B&lue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnBrown
        '
        Me.btnBrown.Location = New System.Drawing.Point(512, 496)
        Me.btnBrown.Name = "btnBrown"
        Me.btnBrown.Size = New System.Drawing.Size(110, 39)
        Me.btnBrown.TabIndex = 6
        Me.btnBrown.Text = "Bro&wn"
        Me.btnBrown.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(730, 496)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(110, 39)
        Me.btnRed.TabIndex = 7
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
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
        Me.picJacket.Size = New System.Drawing.Size(433, 417)
        Me.picJacket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJacket.TabIndex = 11
        Me.picJacket.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 555)
        Me.Controls.Add(Me.picJacket)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnBrown)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnBlack)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picChart)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jackets and More"
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picChart As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSize As Button
    Friend WithEvents btnBlack As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnBrown As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents picJacket As PictureBox
End Class
