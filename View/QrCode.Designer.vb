<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QrCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.LabelHost = New System.Windows.Forms.Label()
        Me.LabelIp = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(206, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(8, 152)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(190, 46)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'LabelHost
        '
        Me.LabelHost.AutoSize = True
        Me.LabelHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHost.Location = New System.Drawing.Point(8, 12)
        Me.LabelHost.Name = "LabelHost"
        Me.LabelHost.Size = New System.Drawing.Size(63, 24)
        Me.LabelHost.TabIndex = 2
        Me.LabelHost.Text = "HOST"
        '
        'LabelIp
        '
        Me.LabelIp.AutoSize = True
        Me.LabelIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIp.Location = New System.Drawing.Point(8, 84)
        Me.LabelIp.Name = "LabelIp"
        Me.LabelIp.Size = New System.Drawing.Size(26, 24)
        Me.LabelIp.TabIndex = 3
        Me.LabelIp.Text = "IP"
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(204, 151)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(120, 46)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'QrCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(337, 209)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.LabelIp)
        Me.Controls.Add(Me.LabelHost)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QrCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QrCode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents LabelHost As Label
    Friend WithEvents LabelIp As Label
    Friend WithEvents ButtonExit As Button
End Class
