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
        Me.picBff = New System.Windows.Forms.PictureBox()
        Me.picXo = New System.Windows.Forms.PictureBox()
        Me.picSry = New System.Windows.Forms.PictureBox()
        Me.picLol = New System.Windows.Forms.PictureBox()
        Me.picIdk = New System.Windows.Forms.PictureBox()
        Me.picBrb = New System.Windows.Forms.PictureBox()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIdk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBff
        '
        Me.picBff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBff.Image = Global.Texting_Project.My.Resources.Resources.BFF
        Me.picBff.Location = New System.Drawing.Point(35, 160)
        Me.picBff.Name = "picBff"
        Me.picBff.Size = New System.Drawing.Size(100, 50)
        Me.picBff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBff.TabIndex = 0
        Me.picBff.TabStop = False
        '
        'picXo
        '
        Me.picXo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picXo.Image = Global.Texting_Project.My.Resources.Resources.XO
        Me.picXo.Location = New System.Drawing.Point(640, 160)
        Me.picXo.Name = "picXo"
        Me.picXo.Size = New System.Drawing.Size(100, 50)
        Me.picXo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXo.TabIndex = 1
        Me.picXo.TabStop = False
        '
        'picSry
        '
        Me.picSry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSry.Image = Global.Texting_Project.My.Resources.Resources.SRY
        Me.picSry.Location = New System.Drawing.Point(519, 160)
        Me.picSry.Name = "picSry"
        Me.picSry.Size = New System.Drawing.Size(100, 50)
        Me.picSry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSry.TabIndex = 2
        Me.picSry.TabStop = False
        '
        'picLol
        '
        Me.picLol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLol.Image = Global.Texting_Project.My.Resources.Resources.LOL
        Me.picLol.Location = New System.Drawing.Point(398, 160)
        Me.picLol.Name = "picLol"
        Me.picLol.Size = New System.Drawing.Size(100, 50)
        Me.picLol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLol.TabIndex = 3
        Me.picLol.TabStop = False
        '
        'picIdk
        '
        Me.picIdk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIdk.Image = Global.Texting_Project.My.Resources.Resources.IDK
        Me.picIdk.Location = New System.Drawing.Point(277, 160)
        Me.picIdk.Name = "picIdk"
        Me.picIdk.Size = New System.Drawing.Size(100, 50)
        Me.picIdk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIdk.TabIndex = 4
        Me.picIdk.TabStop = False
        '
        'picBrb
        '
        Me.picBrb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrb.Image = Global.Texting_Project.My.Resources.Resources.BRB
        Me.picBrb.Location = New System.Drawing.Point(156, 160)
        Me.picBrb.Name = "picBrb"
        Me.picBrb.Size = New System.Drawing.Size(100, 50)
        Me.picBrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrb.TabIndex = 5
        Me.picBrb.TabStop = False
        '
        'lblMeaning
        '
        Me.lblMeaning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMeaning.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.Location = New System.Drawing.Point(35, 281)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(705, 154)
        Me.lblMeaning.TabIndex = 6
        Me.lblMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(785, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.picBrb)
        Me.Controls.Add(Me.picIdk)
        Me.Controls.Add(Me.picLol)
        Me.Controls.Add(Me.picSry)
        Me.Controls.Add(Me.picXo)
        Me.Controls.Add(Me.picBff)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Message Symbols"
        CType(Me.picBff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIdk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBff As PictureBox
    Friend WithEvents picXo As PictureBox
    Friend WithEvents picSry As PictureBox
    Friend WithEvents picLol As PictureBox
    Friend WithEvents picIdk As PictureBox
    Friend WithEvents picBrb As PictureBox
    Friend WithEvents lblMeaning As Label
    Friend WithEvents btnExit As Button
End Class
