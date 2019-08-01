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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFlorist = New System.Windows.Forms.PictureBox()
        Me.picHours = New System.Windows.Forms.PictureBox()
        Me.picSign = New System.Windows.Forms.PictureBox()
        CType(Me.picFlorist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(846, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFlorist
        '
        Me.picFlorist.Image = CType(resources.GetObject("picFlorist.Image"), System.Drawing.Image)
        Me.picFlorist.Location = New System.Drawing.Point(12, -1)
        Me.picFlorist.Name = "picFlorist"
        Me.picFlorist.Size = New System.Drawing.Size(376, 526)
        Me.picFlorist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlorist.TabIndex = 1
        Me.picFlorist.TabStop = False
        '
        'picHours
        '
        Me.picHours.Image = Global.Florist.My.Resources.Resources.Hours
        Me.picHours.Location = New System.Drawing.Point(427, 154)
        Me.picHours.Name = "picHours"
        Me.picHours.Size = New System.Drawing.Size(479, 199)
        Me.picHours.TabIndex = 2
        Me.picHours.TabStop = False
        '
        'picSign
        '
        Me.picSign.Image = CType(resources.GetObject("picSign.Image"), System.Drawing.Image)
        Me.picSign.Location = New System.Drawing.Point(427, 21)
        Me.picSign.Name = "picSign"
        Me.picSign.Size = New System.Drawing.Size(448, 111)
        Me.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSign.TabIndex = 3
        Me.picSign.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.picSign)
        Me.Controls.Add(Me.picHours)
        Me.Controls.Add(Me.picFlorist)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Florist Haven"
        CType(Me.picFlorist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picFlorist As PictureBox
    Friend WithEvents picHours As PictureBox
    Friend WithEvents picSign As PictureBox
End Class
