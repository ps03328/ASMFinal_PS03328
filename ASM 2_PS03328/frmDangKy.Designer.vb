<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDangKy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangKy))
        Me.cb_GT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_User2 = New System.Windows.Forms.TextBox()
        Me.bnt_Dangky = New System.Windows.Forms.Button()
        Me.txt_SDT = New System.Windows.Forms.TextBox()
        Me.txt_Mail = New System.Windows.Forms.TextBox()
        Me.txt_PW2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMK = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cb_GT
        '
        Me.cb_GT.FormattingEnabled = True
        Me.cb_GT.Items.AddRange(New Object() {"Nam", "Nữ", "Không Xác Định"})
        Me.cb_GT.Location = New System.Drawing.Point(96, 151)
        Me.cb_GT.Name = "cb_GT"
        Me.cb_GT.Size = New System.Drawing.Size(152, 21)
        Me.cb_GT.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Giới Tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Sđt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "E-mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Mật Khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tài Khoản"
        '
        'txt_User2
        '
        Me.txt_User2.Location = New System.Drawing.Point(96, 38)
        Me.txt_User2.Multiline = True
        Me.txt_User2.Name = "txt_User2"
        Me.txt_User2.Size = New System.Drawing.Size(152, 23)
        Me.txt_User2.TabIndex = 20
        '
        'bnt_Dangky
        '
        Me.bnt_Dangky.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bnt_Dangky.Font = New System.Drawing.Font("Viner Hand ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_Dangky.ForeColor = System.Drawing.Color.White
        Me.bnt_Dangky.Location = New System.Drawing.Point(82, 178)
        Me.bnt_Dangky.Name = "bnt_Dangky"
        Me.bnt_Dangky.Size = New System.Drawing.Size(91, 30)
        Me.bnt_Dangky.TabIndex = 19
        Me.bnt_Dangky.Text = "Đăng Ký"
        Me.bnt_Dangky.UseVisualStyleBackColor = False
        '
        'txt_SDT
        '
        Me.txt_SDT.Location = New System.Drawing.Point(96, 123)
        Me.txt_SDT.Multiline = True
        Me.txt_SDT.Name = "txt_SDT"
        Me.txt_SDT.Size = New System.Drawing.Size(152, 23)
        Me.txt_SDT.TabIndex = 18
        '
        'txt_Mail
        '
        Me.txt_Mail.Location = New System.Drawing.Point(96, 94)
        Me.txt_Mail.Multiline = True
        Me.txt_Mail.Name = "txt_Mail"
        Me.txt_Mail.Size = New System.Drawing.Size(152, 23)
        Me.txt_Mail.TabIndex = 17
        '
        'txt_PW2
        '
        Me.txt_PW2.Location = New System.Drawing.Point(96, 67)
        Me.txt_PW2.Multiline = True
        Me.txt_PW2.Name = "txt_PW2"
        Me.txt_PW2.Size = New System.Drawing.Size(152, 23)
        Me.txt_PW2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(130, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Đăng Ký"
        '
        'chkMK
        '
        Me.chkMK.AutoSize = True
        Me.chkMK.Location = New System.Drawing.Point(254, 70)
        Me.chkMK.Name = "chkMK"
        Me.chkMK.Size = New System.Drawing.Size(86, 17)
        Me.chkMK.TabIndex = 27
        Me.chkMK.Text = "Ẩn mật khẩu"
        Me.chkMK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "(Dưới 15 ký tự)"
        '
        'frmDangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(342, 218)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMK)
        Me.Controls.Add(Me.cb_GT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_User2)
        Me.Controls.Add(Me.bnt_Dangky)
        Me.Controls.Add(Me.txt_SDT)
        Me.Controls.Add(Me.txt_Mail)
        Me.Controls.Add(Me.txt_PW2)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangKy"
        Me.Text = "Đăng Ký Tài Khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_GT As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_User2 As TextBox
    Friend WithEvents bnt_Dangky As Button
    Friend WithEvents txt_SDT As TextBox
    Friend WithEvents txt_Mail As TextBox
    Friend WithEvents txt_PW2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkMK As CheckBox
    Friend WithEvents Label1 As Label
End Class
