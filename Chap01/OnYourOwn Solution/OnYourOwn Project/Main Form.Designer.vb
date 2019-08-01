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
        Me.picLose = New System.Windows.Forms.PictureBox()
        Me.picWin = New System.Windows.Forms.PictureBox()
        Me.picAfrica = New System.Windows.Forms.PictureBox()
        Me.picBrazil = New System.Windows.Forms.PictureBox()
        Me.picRussia = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picChampions = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.picLose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAfrica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRussia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChampions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(939, 634)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 50)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLose
        '
        Me.picLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLose.Location = New System.Drawing.Point(938, 437)
        Me.picLose.Name = "picLose"
        Me.picLose.Size = New System.Drawing.Size(136, 115)
        Me.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLose.TabIndex = 6
        Me.picLose.TabStop = False
        '
        'picWin
        '
        Me.picWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWin.Location = New System.Drawing.Point(12, 437)
        Me.picWin.Name = "picWin"
        Me.picWin.Size = New System.Drawing.Size(136, 115)
        Me.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWin.TabIndex = 5
        Me.picWin.TabStop = False
        '
        'picAfrica
        '
        Me.picAfrica.Image = Global.OnYourOwn_Project.My.Resources.Resources.WC2010
        Me.picAfrica.Location = New System.Drawing.Point(767, 34)
        Me.picAfrica.Name = "picAfrica"
        Me.picAfrica.Size = New System.Drawing.Size(214, 236)
        Me.picAfrica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAfrica.TabIndex = 4
        Me.picAfrica.TabStop = False
        '
        'picBrazil
        '
        Me.picBrazil.Image = Global.OnYourOwn_Project.My.Resources.Resources.WC2014
        Me.picBrazil.Location = New System.Drawing.Point(399, 34)
        Me.picBrazil.Name = "picBrazil"
        Me.picBrazil.Size = New System.Drawing.Size(214, 236)
        Me.picBrazil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrazil.TabIndex = 3
        Me.picBrazil.TabStop = False
        '
        'picRussia
        '
        Me.picRussia.Image = Global.OnYourOwn_Project.My.Resources.Resources.WC2018
        Me.picRussia.Location = New System.Drawing.Point(64, 34)
        Me.picRussia.Name = "picRussia"
        Me.picRussia.Size = New System.Drawing.Size(214, 236)
        Me.picRussia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRussia.TabIndex = 2
        Me.picRussia.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(227, 611)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(608, 73)
        Me.lblScore.TabIndex = 7
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picChampions
        '
        Me.picChampions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChampions.Location = New System.Drawing.Point(270, 437)
        Me.picChampions.Name = "picChampions"
        Me.picChampions.Size = New System.Drawing.Size(527, 115)
        Me.picChampions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picChampions.TabIndex = 8
        Me.picChampions.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 327)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(1062, 65)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "Click On World Cup Symbol"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 706)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.picChampions)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picLose)
        Me.Controls.Add(Me.picWin)
        Me.Controls.Add(Me.picAfrica)
        Me.Controls.Add(Me.picBrazil)
        Me.Controls.Add(Me.picRussia)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World Cup"
        CType(Me.picLose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAfrica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRussia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChampions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picRussia As PictureBox
    Friend WithEvents picBrazil As PictureBox
    Friend WithEvents picAfrica As PictureBox
    Friend WithEvents picWin As PictureBox
    Friend WithEvents picLose As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents picChampions As PictureBox
    Friend WithEvents lblInfo As Label
End Class
