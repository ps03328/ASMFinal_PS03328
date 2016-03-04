<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPhamQuanly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanPhamQuanly))
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntXem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(12, 220)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(525, 172)
        Me.dgvSanpham.TabIndex = 20
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(448, 169)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 45)
        Me.btnXoa.TabIndex = 19
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapnhat.ForeColor = System.Drawing.Color.Red
        Me.btnCapnhat.Location = New System.Drawing.Point(297, 170)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(100, 45)
        Me.btnCapnhat.TabIndex = 18
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.Red
        Me.btnThem.Location = New System.Drawing.Point(159, 169)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(108, 45)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Red
        Me.btnTimKiem.Location = New System.Drawing.Point(12, 169)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(109, 45)
        Me.btnTimKiem.TabIndex = 16
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(95, 110)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(198, 20)
        Me.txtGia.TabIndex = 14
        '
        'txtMALOAI
        '
        Me.txtMALOAI.Location = New System.Drawing.Point(96, 83)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(198, 20)
        Me.txtMALOAI.TabIndex = 15
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(96, 58)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(198, 20)
        Me.txtTENSP.TabIndex = 12
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(96, 32)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(198, 20)
        Me.txtMASP.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Giá Tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tên SP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã Loại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã SP"
        '
        'bntXem
        '
        Me.bntXem.BackgroundImage = CType(resources.GetObject("bntXem.BackgroundImage"), System.Drawing.Image)
        Me.bntXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntXem.Location = New System.Drawing.Point(341, 49)
        Me.bntXem.Name = "bntXem"
        Me.bntXem.Size = New System.Drawing.Size(134, 94)
        Me.bntXem.TabIndex = 21
        Me.bntXem.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(300, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 31)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hiển thị danh sách"
        '
        'frmSanPhamQuanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(547, 400)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bntXem)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanPhamQuanly"
        Me.Text = "Quản lý sản phẩm"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSanpham As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtGia As TextBox
    Friend WithEvents txtMALOAI As TextBox
    Friend WithEvents txtTENSP As TextBox
    Friend WithEvents txtMASP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bntXem As Button
    Friend WithEvents Label6 As Label
End Class
