<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmXemSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemSP))
        Me.bntXem = New System.Windows.Forms.Button()
        Me.dgvHD = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtNgayNhap = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntXem
        '
        Me.bntXem.BackgroundImage = CType(resources.GetObject("bntXem.BackgroundImage"), System.Drawing.Image)
        Me.bntXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntXem.Location = New System.Drawing.Point(197, 163)
        Me.bntXem.Name = "bntXem"
        Me.bntXem.Size = New System.Drawing.Size(110, 79)
        Me.bntXem.TabIndex = 36
        Me.bntXem.UseVisualStyleBackColor = True
        '
        'dgvHD
        '
        Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHD.Location = New System.Drawing.Point(12, 257)
        Me.dgvHD.Name = "dgvHD"
        Me.dgvHD.Size = New System.Drawing.Size(513, 172)
        Me.dgvHD.TabIndex = 35
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(342, 197)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(62, 45)
        Me.btnXoa.TabIndex = 34
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.BackgroundImage = CType(resources.GetObject("btnCapnhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapnhat.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapnhat.ForeColor = System.Drawing.Color.Red
        Me.btnCapnhat.Location = New System.Drawing.Point(340, 139)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(64, 45)
        Me.btnCapnhat.TabIndex = 33
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.Red
        Me.btnThem.Location = New System.Drawing.Point(93, 197)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(61, 45)
        Me.btnThem.TabIndex = 32
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTimKiem.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Red
        Me.btnTimKiem.Location = New System.Drawing.Point(92, 139)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(62, 45)
        Me.btnTimKiem.TabIndex = 31
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtNgayNhap
        '
        Me.txtNgayNhap.Location = New System.Drawing.Point(206, 109)
        Me.txtNgayNhap.Name = "txtNgayNhap"
        Me.txtNgayNhap.Size = New System.Drawing.Size(198, 20)
        Me.txtNgayNhap.TabIndex = 29
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(207, 82)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(198, 20)
        Me.txtMaSP.TabIndex = 30
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(207, 57)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(198, 20)
        Me.txtMaKH.TabIndex = 28
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(207, 31)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(198, 20)
        Me.txtMaHD.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Ngày nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Mã khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Mã Sản Phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Mã hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 37
        '
        'frmXemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(538, 436)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bntXem)
        Me.Controls.Add(Me.dgvHD)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtNgayNhap)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmXemSP"
        Me.Text = "Hóa Đơn"
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntXem As Button
    Friend WithEvents dgvHD As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtNgayNhap As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
