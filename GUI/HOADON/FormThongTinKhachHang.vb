Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports BUS
Imports DTO

Public Partial Class FormThongTinKhachHang
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub thoat_button_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Public Sub FormThongTinKhachHang_Load(sender As Object, e As EventArgs)

	End Sub

	Public Sub RefreshFormThongTin(maKhachHang As String)
		Dim khachhang = New KhachHangDTO()
		khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(maKhachHang)
		maKhachHang_tb.Text = khachhang.MaKhachHang
		hoTenKH_tb.Text = khachhang.HoTenKhachHang
		diachi_tb.Text = khachhang.DiaChi
		sdt_tb.Text = khachhang.SoDienThoai
		email_tb.Text = khachhang.Email
		tienno_tb.Text = khachhang.SoTienNo.ToString()
	End Sub

	'private void FormThongTinKhachHang_Load(object sender, EventArgs e)
	'{
	'    var khachhang = new KhachHangDTO();
	'    var hoadonForm = new FormLapHoaDon();
	'    khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(hoadonForm.GetTextfromTextBox(hoadonForm.maKah)
	'    maKhachHang_tb.Text = 
	'}
End Class
