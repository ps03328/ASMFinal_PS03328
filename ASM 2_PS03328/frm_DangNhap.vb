Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frm_DangNhap
    Private Sub frm_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Tài khoản quản trị mặc định : Tài khoản : admin , Mật khẩu: admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lb_DN.Click

    End Sub
    Private Sub bnt_DangNhap_Click(sender As Object, e As EventArgs) Handles bnt_DangNhap.Click
        Dim conn As New SqlConnection("workstation id=qlbhps03328.mssql.somee.com;packet size=4096;user id=anhptps03328_SQLLogin_1;pwd=ks35mtuyie;data source=qlbhps03328.mssql.somee.com;persist security info=False;initial catalog=qlbhps03328")
        Dim login = New SqlDataAdapter("select TaiKhoan as 'Tài khoản',MatKhau as 'Mật khẩu' from TaiKhoan where TaiKhoan='" & txt_User.Text & "' and MatKhau='" & txt_PW.Text & "'", conn)
        Dim tk As New DataTable()
        Try
            conn.Open()
            login.Fill(tk)

        Catch ex As Exception

        End Try
        If (tk.Rows.Count > 0) Then
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK)
            Dim f As New frmMain()
            f.Show()
        Else
            MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txt_User_TextChanged(sender As Object, e As EventArgs) Handles txt_User.TextChanged
    End Sub

    Private Sub lb_PW_Click(sender As Object, e As EventArgs) Handles lb_PW.Click

    End Sub

    Private Sub bntDangKy_Click(sender As Object, e As EventArgs) Handles bntDangKy.Click
        frmDangKy.Show()
    End Sub
End Class
