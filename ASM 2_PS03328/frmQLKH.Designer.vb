<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLKH))
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvShow = New System.Windows.Forms.DataGridView()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.LbEmail = New System.Windows.Forms.Label()
        Me.txtHomThu = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(557, 154)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 61)
        Me.btnThem.TabIndex = 17
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(557, 230)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 54)
        Me.btnSua.TabIndex = 16
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(560, 301)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 52)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(103, 37)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(89, 13)
        Me.lblTenKH.TabIndex = 14
        Me.lblTenKH.Text = "Tên Khách Hàng"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(194, 34)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(161, 20)
        Me.txtTenKH.TabIndex = 13
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(103, 9)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(85, 13)
        Me.lblMaKH.TabIndex = 12
        Me.lblMaKH.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(194, 7)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(161, 20)
        Me.txtMaKH.TabIndex = 11
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Location = New System.Drawing.Point(423, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(154, 116)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dgvShow
        '
        Me.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShow.Location = New System.Drawing.Point(15, 154)
        Me.dgvShow.Name = "dgvShow"
        Me.dgvShow.Size = New System.Drawing.Size(518, 199)
        Me.dgvShow.TabIndex = 9
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(194, 60)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(161, 20)
        Me.txtDiaChi.TabIndex = 18
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(103, 63)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(41, 13)
        Me.lbDiaChi.TabIndex = 19
        Me.lbDiaChi.Text = "Địa Chỉ"
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Location = New System.Drawing.Point(103, 89)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(51, 13)
        Me.LbEmail.TabIndex = 20
        Me.LbEmail.Text = "Hòm Thư"
        '
        'txtHomThu
        '
        Me.txtHomThu.Location = New System.Drawing.Point(194, 86)
        Me.txtHomThu.Name = "txtHomThu"
        Me.txtHomThu.Size = New System.Drawing.Size(161, 20)
        Me.txtHomThu.TabIndex = 21
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(194, 112)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(161, 20)
        Me.txtGioiTinh.TabIndex = 22
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(103, 115)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(51, 13)
        Me.lbGioiTinh.TabIndex = 23
        Me.lbGioiTinh.Text = "Giới Tính"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Hiển thị toàn bộ"
        '
        'frmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(644, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.txtHomThu)
        Me.Controls.Add(Me.LbEmail)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLKH"
        Me.Text = "Quản lý khách hàng"
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents lblTenKH As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents lblMaKH As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgvShow As DataGridView
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents LbEmail As Label
    Friend WithEvents txtHomThu As TextBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents Label1 As Label
End Class
