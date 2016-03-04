Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmSanPhamQuanly
    Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    'Bien lay du lieu tu Ham
    Dim hienthiSP As New Class2
    Public Class Class2 'Ham lay du lieu
        Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu() As DataSet
            'Truy van du lieu
            Dim loadSP As New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm' ,Ten_SP as 'Tên sản phẩm' , Ma_LSP as 'Mã loại',Gia_SP as 'Giá sản phẩm' from SanPham", conn)
            Dim db As New DataSet
            conn.Open() 'Mo ket noi CSDL
            loadSP.Fill(db)
            conn.Close() 'Dong ket noi CSDL
            Return db 'Tra ket qua
        End Function
    End Class

    Private Sub bntXem_Click(sender As Object, e As EventArgs) Handles bntXem.Click
        'Lay du lieu tu Ham da khai bao
        dgvSanpham.DataSource = hienthiSP.dulieu.Tables(0)
    End Sub

    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        'Thanh phan hien thi tren DataGridView
        Dim Dobble As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMASP.Text = dgvSanpham.Item(0, Dobble).Value
        txtTENSP.Text = dgvSanpham.Item(1, Dobble).Value
        txtMALOAI.Text = dgvSanpham.Item(2, Dobble).Value
        txtGia.Text = dgvSanpham.Item(3, Dobble).Value
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm', Ten_SP as 'Tên Sản Phẩm', Ma_LSP as 'Mã Loại', Gia_SP as 'Giá sản phẩm' from SanPham where Ma_SP='" & txtMASP.Text & "'", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thuc thi thêm
        Dim InsertData As String = "INSERT INTO SanPham VALUES(@Ma_SP,@Ten_SP,@Ma_LSP,@Gia_SP)"
        'Bien luu du lieu 
        Dim Save As SqlCommand = New SqlCommand(InsertData, conn)
        conn.Open() 'Mo ket noi CSDL
        Try

            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtTENSP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtMALOAI.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtGia.Focus()
                        If txtGia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Thuc thi chen du lieu
                            Save.Parameters.AddWithValue("@Ma_SP", txtMASP.Text)
                            Save.Parameters.AddWithValue("@Ten_SP", txtTENSP.Text)
                            Save.Parameters.AddWithValue("@Ma_LSP", txtMALOAI.Text)
                            Save.Parameters.AddWithValue("@Gia_SP", txtGia.Text)
                            Save.ExecuteNonQuery()
                            conn.Close() 'Dong ket noi CSDL
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao du lieu trung
            MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        Dim Refresh As SqlDataAdapter = New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm' ,Ten_SP as 'Tên sản phẩm' , Ma_LSP as 'Mã loại',Gia_SP as 'Giá sản phẩm' from SanPham", conn)
        db.Clear()
        Refresh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thu thi cap nhat
        Dim CAPNHAT As String = "UPDATE SanPham SET Ma_SP=@Ma_SP ,Ten_SP=@Ten_SP , Ma_LSP=@Ma_LSP,Gia_SP =@Gia_SP WHERE Ma_SP=@Ma_SP"
        'Bien luu du lieu
        Dim ADDDATA As SqlCommand = New SqlCommand(CAPNHAT, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtTENSP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtMALOAI.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtGia.Focus()
                        If txtGia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập hòm thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Thuc thi chen du lieu
                            ADDDATA.Parameters.AddWithValue("@Ma_SP", txtMASP.Text)
                            ADDDATA.Parameters.AddWithValue("@Ten_SP", txtTENSP.Text)
                            ADDDATA.Parameters.AddWithValue("@Ma_LSP", txtMALOAI.Text)
                            ADDDATA.Parameters.AddWithValue("@Gia_SP", txtGia.Text)
                            ADDDATA.ExecuteNonQuery()
                            conn.Close() 'Dong ket noi CSDL
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm' ,Ten_SP as 'Tên sản phẩm' , Ma_LSP as 'Mã loại',Gia_SP as 'Giá sản phẩm' from SanPham", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvSanpham.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE SanPham WHERE Ma_SP = @Ma_SP") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                CONNECT.Parameters.AddWithValue("@Ma_SP", txtMASP.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
            'Thong bao xoa that bai
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub frmSanPhamQuanly_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class