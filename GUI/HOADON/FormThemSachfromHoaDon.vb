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

Public Partial Class FormThemSachfromHoaDon
	Inherits Form
	Private _parentForm As FormLapHoaDon
	Public Sub New(parentForm As FormLapHoaDon)
		InitializeComponent()
		_parentForm = parentForm
	End Sub

	Private Sub TenSach_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim sach = DirectCast(TenSach.SelectedItem, SachDTO)

		MaSach.Text = sach.MaSach
		TheLoai.Text = sach.TheLoai
		TacGia.Text = sach.TacGia
		soluongton_tb.Text = sach.SoLuongTon.ToString()
		dongia_tb.Text = sach.DonGia.ToString()
	End Sub

	Private Sub FormLapChiTietPhieuNhap_Load(sender As Object, e As EventArgs)
		TenSach.DataSource = SachBUS.SelectSachAll()
	End Sub

	Private Sub Them_Click(sender As Object, e As EventArgs)
		If TenSach.SelectedItem Is Nothing Then
			MessageBox.Show("Chưa chọn sách", "Lỗi")
		ElseIf soluongban.Value <= 0 Then
			MessageBox.Show("Số lượng nhập không hợp lệ", "Lỗi")
		Else
			_parentForm.ThemChiTietHoaDon(DirectCast(TenSach.SelectedItem, SachDTO), CInt(Math.Truncate(soluongban.Value)), Decimal.Parse(thanhtien_tb.Text), Decimal.Parse(dongiaban_tb.Text))
		End If
	End Sub

	Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub label8_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub dongiaban_tb_TextChanged(sender As Object, e As EventArgs)
		If dongiaban_tb.Text = "" Then
			thanhtien_tb.Text = "0"
			Return
		End If

		If (soluongban.Value <> 0) AndAlso (Decimal.Parse(dongiaban_tb.Text) <> 0) Then
			Dim temp As Decimal = Integer.Parse(dongiaban_tb.Text) * soluongban.Value
			thanhtien_tb.Text = temp.ToString()
		End If
	End Sub

	Private Sub soluongban_ValueChanged(sender As Object, e As EventArgs)
		If dongiaban_tb.Text = "" Then
			thanhtien_tb.Text = "0"
			Return
		End If

		If (soluongban.Value <> 0) AndAlso (Decimal.Parse(dongiaban_tb.Text) <> 0) Then
			Dim temp As Decimal = Integer.Parse(dongiaban_tb.Text) * soluongban.Value
			thanhtien_tb.Text = temp.ToString()
		End If
	End Sub
End Class
