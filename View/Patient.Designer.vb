<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.ButtonMin = New System.Windows.Forms.Button()
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
        Me.PanelTop.Size = New System.Drawing.Size(520, 52)
        Me.PanelTop.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(481, 12)
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
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SET PATIENT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(18, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "ID PATIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TIME TREATMENT"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(174, 82)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 30)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(174, 140)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 30)
        Me.TextBox2.TabIndex = 18
        '
        'TextBoxTime
        '
        Me.TextBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTime.Location = New System.Drawing.Point(215, 200)
        Me.TextBoxTime.Multiline = True
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBoxTime.Size = New System.Drawing.Size(81, 30)
        Me.TextBoxTime.TabIndex = 19
        Me.TextBoxTime.Text = "60"
        Me.TextBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(174, 267)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(99, 41)
        Me.ButtonStart.TabIndex = 20
        Me.ButtonStart.Text = "START"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(379, 267)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(99, 41)
        Me.ButtonClose.TabIndex = 21
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(358, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "MINUTE"
        '
        'ButtonPlus
        '
        Me.ButtonPlus.Location = New System.Drawing.Point(304, 198)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(32, 32)
        Me.ButtonPlus.TabIndex = 23
        Me.ButtonPlus.Text = "+"
        Me.ButtonPlus.UseVisualStyleBackColor = True
        '
        'ButtonMin
        '
        Me.ButtonMin.Location = New System.Drawing.Point(174, 198)
        Me.ButtonMin.Name = "ButtonMin"
        Me.ButtonMin.Size = New System.Drawing.Size(32, 32)
        Me.ButtonMin.TabIndex = 24
        Me.ButtonMin.Text = "-"
        Me.ButtonMin.UseVisualStyleBackColor = True
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 346)
        Me.Controls.Add(Me.ButtonMin)
        Me.Controls.Add(Me.ButtonPlus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonPlus As Button
    Friend WithEvents ButtonMin As Button
End Class
