<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemKH))
        Me.dgvHienThi = New System.Windows.Forms.DataGridView()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHienThi
        '
        Me.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHienThi.Location = New System.Drawing.Point(12, 163)
        Me.dgvHienThi.Name = "dgvHienThi"
        Me.dgvHienThi.Size = New System.Drawing.Size(473, 225)
        Me.dgvHienThi.TabIndex = 10
        '
        'btnDong
        '
        Me.btnDong.BackgroundImage = CType(resources.GetObject("btnDong.BackgroundImage"), System.Drawing.Image)
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDong.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.Location = New System.Drawing.Point(417, 93)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(68, 51)
        Me.btnDong.TabIndex = 9
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemall
        '
        Me.btnXemall.BackgroundImage = CType(resources.GetObject("btnXemall.BackgroundImage"), System.Drawing.Image)
        Me.btnXemall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXemall.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXemall.Location = New System.Drawing.Point(202, 93)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(64, 51)
        Me.btnXemall.TabIndex = 7
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(12, 93)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(69, 51)
        Me.btnTimKiem.TabIndex = 8
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(217, 23)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(150, 20)
        Me.txtMAKH.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã KH"
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbTen.Location = New System.Drawing.Point(150, 50)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(54, 19)
        Me.lbTen.TabIndex = 13
        Me.lbTen.Text = "Họ tên"
        '
        'lbHoTen
        '
        Me.lbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHoTen.Enabled = False
        Me.lbHoTen.Location = New System.Drawing.Point(217, 46)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(150, 23)
        Me.lbHoTen.TabIndex = 15
        '
        'frmTimKiemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(497, 410)
        Me.Controls.Add(Me.lbHoTen)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.dgvHienThi)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimKiemKH"
        Me.Text = "Tìm kiếm khách hàng"
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHienThi As DataGridView
    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtMAKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTen As Label
    Friend WithEvents lbHoTen As Label
End Class
