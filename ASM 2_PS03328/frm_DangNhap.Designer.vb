<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DangNhap))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntDangKy = New System.Windows.Forms.Button()
        Me.bnt_DangNhap = New System.Windows.Forms.Button()
        Me.ckb_Nho = New System.Windows.Forms.CheckBox()
        Me.lb_PW = New System.Windows.Forms.Label()
        Me.lb_User = New System.Windows.Forms.Label()
        Me.txt_PW = New System.Windows.Forms.TextBox()
        Me.txt_User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_DN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.bntDangKy)
        Me.Panel1.Controls.Add(Me.bnt_DangNhap)
        Me.Panel1.Controls.Add(Me.ckb_Nho)
        Me.Panel1.Controls.Add(Me.lb_PW)
        Me.Panel1.Controls.Add(Me.lb_User)
        Me.Panel1.Controls.Add(Me.txt_PW)
        Me.Panel1.Controls.Add(Me.txt_User)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(104, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 184)
        Me.Panel1.TabIndex = 0
        '
        'bntDangKy
        '
        Me.bntDangKy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bntDangKy.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bntDangKy.Location = New System.Drawing.Point(220, 141)
        Me.bntDangKy.Name = "bntDangKy"
        Me.bntDangKy.Size = New System.Drawing.Size(123, 36)
        Me.bntDangKy.TabIndex = 7
        Me.bntDangKy.Text = "Đăng Ký"
        Me.bntDangKy.UseVisualStyleBackColor = False
        '
        'bnt_DangNhap
        '
        Me.bnt_DangNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bnt_DangNhap.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bnt_DangNhap.Location = New System.Drawing.Point(47, 141)
        Me.bnt_DangNhap.Name = "bnt_DangNhap"
        Me.bnt_DangNhap.Size = New System.Drawing.Size(123, 36)
        Me.bnt_DangNhap.TabIndex = 6
        Me.bnt_DangNhap.Text = "Đăng Nhập"
        Me.bnt_DangNhap.UseVisualStyleBackColor = False
        '
        'ckb_Nho
        '
        Me.ckb_Nho.AutoSize = True
        Me.ckb_Nho.Font = New System.Drawing.Font("Harlow Solid Italic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_Nho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ckb_Nho.Location = New System.Drawing.Point(146, 115)
        Me.ckb_Nho.Name = "ckb_Nho"
        Me.ckb_Nho.Size = New System.Drawing.Size(118, 20)
        Me.ckb_Nho.TabIndex = 5
        Me.ckb_Nho.Text = "Ghi nhớ mật khẩu"
        Me.ckb_Nho.UseVisualStyleBackColor = True
        '
        'lb_PW
        '
        Me.lb_PW.AutoSize = True
        Me.lb_PW.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_PW.Location = New System.Drawing.Point(9, 84)
        Me.lb_PW.Name = "lb_PW"
        Me.lb_PW.Size = New System.Drawing.Size(92, 24)
        Me.lb_PW.TabIndex = 4
        Me.lb_PW.Text = "Mật Khẩu"
        '
        'lb_User
        '
        Me.lb_User.AutoSize = True
        Me.lb_User.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_User.Location = New System.Drawing.Point(9, 44)
        Me.lb_User.Name = "lb_User"
        Me.lb_User.Size = New System.Drawing.Size(94, 24)
        Me.lb_User.TabIndex = 3
        Me.lb_User.Text = "Tài Khoản"
        '
        'txt_PW
        '
        Me.txt_PW.Location = New System.Drawing.Point(105, 83)
        Me.txt_PW.Multiline = True
        Me.txt_PW.Name = "txt_PW"
        Me.txt_PW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_PW.Size = New System.Drawing.Size(215, 25)
        Me.txt_PW.TabIndex = 2
        '
        'txt_User
        '
        Me.txt_User.Location = New System.Drawing.Point(105, 44)
        Me.txt_User.Multiline = True
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Size = New System.Drawing.Size(215, 25)
        Me.txt_User.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(117, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập"
        '
        'lb_DN
        '
        Me.lb_DN.AutoSize = True
        Me.lb_DN.BackColor = System.Drawing.SystemColors.Menu
        Me.lb_DN.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_DN.ForeColor = System.Drawing.Color.Red
        Me.lb_DN.Location = New System.Drawing.Point(12, 9)
        Me.lb_DN.Name = "lb_DN"
        Me.lb_DN.Size = New System.Drawing.Size(571, 43)
        Me.lb_DN.TabIndex = 2
        Me.lb_DN.Text = "Welcome to Gear-Gaming"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(248, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MSSV: PS03328"
        '
        'frm_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(601, 309)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_DN)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_DangNhap"
        Me.Text = "Đăng Nhập"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_User As Label
    Friend WithEvents txt_PW As TextBox
    Friend WithEvents txt_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ckb_Nho As CheckBox
    Friend WithEvents lb_PW As Label
    Friend WithEvents bnt_DangNhap As Button
    Friend WithEvents bntDangKy As Button
    Friend WithEvents lb_DN As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
