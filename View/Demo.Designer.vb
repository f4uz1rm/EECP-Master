<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Demo
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.Button1)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(399, 52)
        Me.PanelTop.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEMO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(129, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "ENTER PASSWORD"
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(248, 222)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(99, 41)
        Me.ButtonClose.TabIndex = 30
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(43, 222)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(99, 41)
        Me.ButtonStart.TabIndex = 29
        Me.ButtonStart.Text = "START"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(43, 156)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(304, 30)
        Me.TextBoxPassword.TabIndex = 26
        '
        'Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 319)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Demo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents TextBoxPassword As TextBox
End Class
