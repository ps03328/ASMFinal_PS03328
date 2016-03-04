Public Class frmMain
    Private Sub bnt_CapNhatKH_Click(sender As Object, e As EventArgs) Handles bnt_CapNhatKH.Click
        frmQLKH.Show()
    End Sub

    Private Sub bnt_TimKiemKH_Click(sender As Object, e As EventArgs) Handles bnt_TimKiemKH.Click
        frmTimKiemKH.Show()
    End Sub

    Private Sub bnt_QlySP_Click(sender As Object, e As EventArgs) Handles bnt_QlySP.Click
        frmSanPhamQuanly.Show()
    End Sub
    Private Sub bnt_GioiThieu_Click(sender As Object, e As EventArgs)
        frmGioiThieu.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmXemSP.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmGioiThieu.Show()
    End Sub
End Class