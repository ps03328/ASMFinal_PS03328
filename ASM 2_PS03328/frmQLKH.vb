Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmQLKH
    Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    'Bien lay du lieu tu Ham
    Dim hienthi As New Class1
    Public Class Class1 'Ham lay du lieu
        Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu() As DataSet
            'Truy van du lieu
            Dim load As New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,HoTen as 'Họ Tên' , Dia_Chi as 'Địa Chỉ',Email as 'Hòm Thư',GioiTinh as 'Giới Tính' from KhachHang", conn)
            Dim db As New DataSet
            conn.Open() 'Mo ket noi CSDL
            load.Fill(db)
            conn.Close() 'Dong ket noi CSDL
            Return db 'Tra ket qua
        End Function
    End Class
    Private Sub dgvShow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShow.CellContentClick
        'Thanh phan hien thi tren DataGridView
        Dim Dobble As Integer = dgvShow.CurrentCell.RowIndex
        txtMaKH.Text = dgvShow.Item(0, Dobble).Value
        txtTenKH.Text = dgvShow.Item(1, Dobble).Value
        txtDiaChi.Text = dgvShow.Item(2, Dobble).Value
        txtHomThu.Text = dgvShow.Item(3, Dobble).Value
        txtGioiTinh.Text = dgvShow.Item(4, Dobble).Value

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE KhachHang WHERE Ma_KH = @Ma_KH") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@Ma_KH", txtMaKH.Text)
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
        dgvShow.DataSource = db
        dgvShow.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,HoTen as 'Họ Tên' , Dia_Chi as 'Địa Chỉ',Email as 'Hòm Thư',GioiTinh as 'Giới Tính' from KhachHang", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvShow.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thuc thi thêm
        Dim InsertData As String = "INSERT INTO KhachHang VALUES(@Ma_KH,@HoTen,@Dia_Chi,@Email,@GioiTinh)"
        'Bien luu du lieu 
        Dim Save As SqlCommand = New SqlCommand(InsertData, conn)
        conn.Open() 'Mo ket noi CSDL
        Try

            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtDiaChi.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtHomThu.Focus()
                        If txtHomThu.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập hòm thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtGioiTinh.Focus()
                            If txtGioiTinh.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                'Thuc thi chen du lieu
                                Save.Parameters.AddWithValue("@Ma_KH", txtMaKH.Text)
                                Save.Parameters.AddWithValue("@HoTen", txtTenKH.Text)
                                Save.Parameters.AddWithValue("@Dia_chi", txtDiaChi.Text)
                                Save.Parameters.AddWithValue("@Email", txtHomThu.Text)
                                Save.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
                                Save.ExecuteNonQuery()
                                conn.Close() 'Dong ket noi CSDL
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao du lieu trung
            MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        Dim Refresh As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,HoTen as 'Họ Tên' , Dia_Chi as 'Địa Chỉ',Email as 'Hòm Thư',GioiTinh as 'Giới Tính' from KhachHang", conn)
        db.Clear()
        Refresh.Fill(db)
        dgvShow.DataSource = db.DefaultView
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Lay du lieu tu Ham da khai bao
        dgvShow.DataSource = hienthi.dulieu.Tables(0)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thu thi cap nhat
        Dim CAPNHAT As String = "UPDATE KhachHang SET Ma_KH=@Ma_KH ,HoTen=@HoTen , Dia_Chi=@Dia_Chi,Email=@Email,GioiTinh =@GioiTinh WHERE Ma_KH=@Ma_KH"
        'Bien luu du lieu
        Dim ADDDATA As SqlCommand = New SqlCommand(CAPNHAT, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtDiaChi.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtHomThu.Focus()
                        If txtHomThu.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập hòm thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtGioiTinh.Focus()
                            If txtGioiTinh.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                'Thuc thi chen du lieu
                                ADDDATA.Parameters.AddWithValue("@Ma_KH", txtMaKH.Text)
                                ADDDATA.Parameters.AddWithValue("@HoTen", txtTenKH.Text)
                                ADDDATA.Parameters.AddWithValue("@Dia_Chi", txtDiaChi.Text)
                                ADDDATA.Parameters.AddWithValue("@Email", txtHomThu.Text)
                                ADDDATA.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
                                ADDDATA.ExecuteNonQuery()
                                conn.Close() 'Dong ket noi CSDL
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        db.Clear()
        dgvShow.DataSource = db
        dgvShow.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub frmQLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



