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
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.btnSelected = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 15
        Me.lstStates.Items.AddRange(New Object() {"KY", "SC", "SD", "TN"})
        Me.lstStates.Location = New System.Drawing.Point(21, 31)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(52, 94)
        Me.lstStates.Sorted = True
        Me.lstStates.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State &IDs:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item:"
        '
        'lblItem
        '
        Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItem.Location = New System.Drawing.Point(114, 29)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(39, 22)
        Me.lblItem.TabIndex = 4
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Index:"
        '
        'lblIndex
        '
        Me.lblIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndex.Location = New System.Drawing.Point(114, 88)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(39, 22)
        Me.lblIndex.TabIndex = 6
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelected
        '
        Me.btnSelected.Location = New System.Drawing.Point(179, 14)
        Me.btnSelected.Name = "btnSelected"
        Me.btnSelected.Size = New System.Drawing.Size(78, 23)
        Me.btnSelected.TabIndex = 7
        Me.btnSelected.Text = "&Selected"
        Me.btnSelected.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 148)
        Me.Controls.Add(Me.btnSelected)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStates)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListBox Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStates As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIndex As Label
    Friend WithEvents btnSelected As Button
End Class
