Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmTimKiemKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
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

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select Ma_KH as 'Mã KH', HoTen as 'Tên KH', Dia_Chi as 'Địa Chỉ', Email as 'Email',GioiTinh as 'Giới Tính' from KhachHang where Ma_KH='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvHienThi.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvHienThi.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvHienThi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHienThi.CellContentClick
        Dim click As Integer = dgvHienThi.CurrentCell.RowIndex
        txtMAKH.Text = dgvHienThi.Item(0, click).Value
        lbHoTen.Text = dgvHienThi.Item(1, click).Value
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        dgvHienThi.DataSource = hienthi.dulieu.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class