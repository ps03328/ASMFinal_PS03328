Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmXemSP
    Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    'Bien lay du lieu tu Ham
    Dim hienthiSP As New Class3
    Public Class Class3 'Ham lay du lieu
        Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu2() As DataSet
            'Truy van du lieu
            Dim loadHD As New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,Ma_HD as 'Mã hóa đơn' , Ma_SP as 'Mã sản phẩm',NgayNhap_HD as 'Ngày nhập hóa đơn' from HoaDon", conn)
            Dim db As New DataSet
            conn.Open() 'Mo ket noi CSDL
            loadHD.Fill(db)
            conn.Close() 'Dong ket noi CSDL
            Return db 'Tra ket qua
        End Function
    End Class
    Private Sub dgvHD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHD.CellContentClick
        'Thanh phan hien thi tren DataGridView lên textbox
        Dim Dobble As Integer = dgvHD.CurrentCell.RowIndex
        txtMaKH.Text = dgvHD(0, Dobble).Value
        txtMaHD.Text = dgvHD(1, Dobble).Value
        txtMaSP.Text = dgvHD.Item(2, Dobble).Value
        txtNgayNhap.Text = dgvHD.Item(3, Dobble).Value
    End Sub
    Private Sub bntXem_Click(sender As Object, e As EventArgs) Handles bntXem.Click
        'Lay du lieu tu Ham da khai bao
        dgvHD.DataSource = hienthiSP.dulieu2.Tables(0)
    End Sub
    Private Sub frmXemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,Ma_HD as 'Mã hóa đơn' , Ma_SP as 'Mã sản phẩm',NgayNhap_HD as 'Ngày nhập hóa đơn' from HoaDon where Ma_HD='" & txtMaHD.Text & "'", connect)
        Try
            If txtMaHD.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvHD.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvHD.DataSource = db.DefaultView
                    txtMaHD.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMaHD.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thuc thi thêm
        Dim InsertData As String = "INSERT INTO HoaDon VALUES(@Ma_KH,@Ma_HD,@Ma_SP,@NgayNhap_HD)"
        'Bien luu du lieu 
        Dim Save As SqlCommand = New SqlCommand(InsertData, conn)
        conn.Open() 'Mo ket noi CSDL
        Try

            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtMaHD.Focus()
                If txtMaHD.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtMaSP.Focus()
                    If txtMaSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã  sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtNgayNhap.Focus()
                        If txtNgayNhap.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ngày tháng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Thuc thi chen du lieu
                            Save.Parameters.AddWithValue("@Ma_KH", txtMaKH.Text)
                            Save.Parameters.AddWithValue("@Ma_HD", txtMaHD.Text)
                            Save.Parameters.AddWithValue("@Ma_SP", txtMaSP.Text)
                            Save.Parameters.AddWithValue("@NgayNhap_HD", txtNgayNhap.Text)
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
        Dim Refresh As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,Ma_HD as 'Mã hóa đơn' , Ma_SP as 'Mã sản phẩm',NgayNhap_HD as 'Ngày nhập hóa đơn' from HoaDon", conn)
        db.Clear()
        Refresh.Fill(db)
        dgvHD.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thu thi cap nhat
        Dim CAPNHAT As String = "UPDATE HoaDon SET Ma_KH=@Ma_KH ,Ma_HD=@Ma_HD , Ma_SP=@Ma_SP,NgayNhap_HD =@NgayNhap_HD WHERE Ma_HD=@Ma_HD"
        'Bien luu du lieu
        Dim ADDDATA As SqlCommand = New SqlCommand(CAPNHAT, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtMaHD.Focus()
                If txtMaHD.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtMaSP.Focus()
                    If txtMaSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã  sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtNgayNhap.Focus()
                        If txtNgayNhap.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ngày tháng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Thuc thi chen du lieu
                            ADDDATA.Parameters.AddWithValue("@Ma_KH", txtMaKH.Text)
                            ADDDATA.Parameters.AddWithValue("@Ma_HD", txtMaHD.Text)
                            ADDDATA.Parameters.AddWithValue("@Ma_SP", txtMaSP.Text)
                            ADDDATA.Parameters.AddWithValue("@NgayNhap_HD", txtNgayNhap.Text)
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
        dgvHD.DataSource = db
        dgvHD.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã khách hàng' ,Ma_HD as 'Mã hóa đơn' , Ma_SP as 'Mã sản phẩm',NgayNhap_HD as 'Ngày nhập hóa đơn' from HoaDon", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvHD.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE HoaDon WHERE Ma_HD = @Ma_HD") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                CONNECT.Parameters.AddWithValue("@Ma_HD", txtMaKH.Text)
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
        dgvHD.DataSource = db
        dgvHD.DataSource = Nothing
        LoadData()
    End Sub


End Class