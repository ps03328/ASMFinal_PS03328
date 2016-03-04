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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.bnt_TimKiemKH = New System.Windows.Forms.Button()
        Me.bnt_CapNhatKH = New System.Windows.Forms.Button()
        Me.grb_Khachhang = New System.Windows.Forms.GroupBox()
        Me.bnt_QlySP = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_Khachhang.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnt_TimKiemKH
        '
        Me.bnt_TimKiemKH.BackColor = System.Drawing.Color.White
        Me.bnt_TimKiemKH.BackgroundImage = CType(resources.GetObject("bnt_TimKiemKH.BackgroundImage"), System.Drawing.Image)
        Me.bnt_TimKiemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnt_TimKiemKH.Location = New System.Drawing.Point(138, 33)
        Me.bnt_TimKiemKH.Name = "bnt_TimKiemKH"
        Me.bnt_TimKiemKH.Size = New System.Drawing.Size(103, 98)
        Me.bnt_TimKiemKH.TabIndex = 9
        Me.bnt_TimKiemKH.UseVisualStyleBackColor = False
        '
        'bnt_CapNhatKH
        '
        Me.bnt_CapNhatKH.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bnt_CapNhatKH.BackgroundImage = CType(resources.GetObject("bnt_CapNhatKH.BackgroundImage"), System.Drawing.Image)
        Me.bnt_CapNhatKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnt_CapNhatKH.Location = New System.Drawing.Point(9, 33)
        Me.bnt_CapNhatKH.Name = "bnt_CapNhatKH"
        Me.bnt_CapNhatKH.Size = New System.Drawing.Size(103, 98)
        Me.bnt_CapNhatKH.TabIndex = 8
        Me.bnt_CapNhatKH.UseVisualStyleBackColor = False
        '
        'grb_Khachhang
        '
        Me.grb_Khachhang.BackgroundImage = CType(resources.GetObject("grb_Khachhang.BackgroundImage"), System.Drawing.Image)
        Me.grb_Khachhang.Controls.Add(Me.bnt_TimKiemKH)
        Me.grb_Khachhang.Controls.Add(Me.bnt_CapNhatKH)
        Me.grb_Khachhang.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Khachhang.ForeColor = System.Drawing.Color.Red
        Me.grb_Khachhang.Location = New System.Drawing.Point(12, 36)
        Me.grb_Khachhang.Name = "grb_Khachhang"
        Me.grb_Khachhang.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grb_Khachhang.Size = New System.Drawing.Size(252, 142)
        Me.grb_Khachhang.TabIndex = 10
        Me.grb_Khachhang.TabStop = False
        Me.grb_Khachhang.Text = "Khách hàng"
        '
        'bnt_QlySP
        '
        Me.bnt_QlySP.BackColor = System.Drawing.Color.White
        Me.bnt_QlySP.BackgroundImage = CType(resources.GetObject("bnt_QlySP.BackgroundImage"), System.Drawing.Image)
        Me.bnt_QlySP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnt_QlySP.Location = New System.Drawing.Point(9, 33)
        Me.bnt_QlySP.Name = "bnt_QlySP"
        Me.bnt_QlySP.Size = New System.Drawing.Size(101, 89)
        Me.bnt_QlySP.TabIndex = 8
        Me.bnt_QlySP.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.bnt_QlySP)
        Me.GroupBox1.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(284, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(228, 142)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sản Phẩm"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(121, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 89)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Infomation"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 202)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grb_Khachhang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.grb_Khachhang.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_TimKiemKH As Button
    Friend WithEvents bnt_CapNhatKH As Button
    Friend WithEvents grb_Khachhang As GroupBox
    Friend WithEvents bnt_QlySP As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
