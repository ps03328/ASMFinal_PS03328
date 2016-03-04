Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmDangKy
    Dim chuoiketnoi As String = "workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    Private Sub bnt_Dangky_Click(sender As Object, e As EventArgs) Handles bnt_Dangky.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thuc thi thêm
        Dim InsertData As String = "INSERT INTO TaiKhoan VALUES(@TaiKhoan,@MatKhau)"
        'Bien luu du lieu 
        Dim Save As SqlCommand = New SqlCommand(InsertData, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            If txt_User2.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txt_PW2.Focus()
                If txt_PW2.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'Thuc thi chen du lieu
                    Save.Parameters.AddWithValue("@TaiKhoan", txt_User2.Text)
                    Save.Parameters.AddWithValue("@MatKhau", txt_PW2.Text)
                    Save.ExecuteNonQuery()
                    conn.Close() 'Dong ket noi CSDL
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch EX As Exception
            'Thong bao du lieu trung
            MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Close()
    End Sub

    Private Sub chkMK_CheckedChanged(sender As Object, e As EventArgs) Handles chkMK.CheckedChanged
        If chkMK.Checked = True Then
            txt_PW2.PasswordChar = "*"
        End If
    End Sub
    Private Sub frmDangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class