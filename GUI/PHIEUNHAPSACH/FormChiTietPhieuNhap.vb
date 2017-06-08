Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports DTO
Imports BUS

Public Partial Class FormChiTietPhieuNhap
	Inherits Form
	Private _parentForm As FormLapPhieuNhapSach
	Public Sub New(parentForm As FormLapPhieuNhapSach)
		InitializeComponent()
		_parentForm = parentForm
	End Sub

	Private Sub TenSach_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim sach = DirectCast(TenSach.SelectedItem, SachDTO)

		MaSach.Text = sach.MaSach
		TheLoai.Text = sach.TheLoai
		TacGia.Text = sach.TacGia
		DonGia.Text = sach.DonGia.ToString()
		SoLuongTon.Text = sach.SoLuongTon.ToString()
	End Sub

	Private Sub FormLapChiTietPhieuNhap_Load(sender As Object, e As EventArgs)
		TenSach.DataSource = SachBUS.SelectSachAll()
	End Sub

	Private Sub Them_Click(sender As Object, e As EventArgs)
		If TenSach.SelectedItem Is Nothing Then
			MessageBox.Show("Chưa chọn sách", "Lỗi")
		ElseIf SoLuongNhap.Value <= 0 Then
			MessageBox.Show("Số lượng nhập không hợp lệ", "Lỗi")
		Else
			_parentForm.ThemChiTietPhieuNhap(DirectCast(TenSach.SelectedItem, SachDTO), CInt(Math.Truncate(SoLuongNhap.Value)))
		End If
	End Sub

	Private Sub SoLuongNhap_ValueChanged(sender As Object, e As EventArgs)

	End Sub
End Class
