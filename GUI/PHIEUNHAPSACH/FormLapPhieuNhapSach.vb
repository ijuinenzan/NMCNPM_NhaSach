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

Public Partial Class FormLapPhieuNhapSach
	Inherits Form
	Private _bindingSource As BindingSource
	Private _dataTable As DataTable
	Private _childForm As FormChiTietPhieuNhap

	Public Sub New()
		InitializeComponent()

		_dataTable = New DataTable()
		_dataTable.Columns.Add("Mã sách")
		_dataTable.Columns.Add("Tên sách")
		_dataTable.Columns.Add("Thể loại")
		_dataTable.Columns.Add("Tác giả")
		_dataTable.Columns.Add("Đơn giá")
		_dataTable.Columns.Add("Số lượng tồn")
		_dataTable.Columns.Add("Số lượng nhập")

		_bindingSource = New BindingSource() With { 
			.DataSource = _dataTable 
		}
	End Sub

	Private Sub FormLapPhieuNhapSach_Load(sender As Object, e As EventArgs)
		RefreshForm()
		DataGridChiTietPhieuNhap.DataSource = _bindingSource
	End Sub

	Private Sub RefreshForm()
		MaPhieuNhap.Text = PhieuNhapBUS.GenerateNewMaPhieuNhap()
		NgayNhap.Value = DateTime.Now
		SoLuongNhapItNhat.Text = ThamSoBUS.SelectSoLuongNhapItNhat().ToString()
		SoLuongTonToiDaTruocNhap.Text = ThamSoBUS.SelectSoLuongTonToiDaTruocNhap().ToString()
	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs)
		Dim phieuNhap = New PhieuNhapDTO() With { 
			.MaPhieuNhap = MaPhieuNhap.Text, 
			.NgayNhap = NgayNhap.Value 
		}

		Dim listChiTietPhieuNhap = New List(Of ChiTietPhieuNhapDTO)()
		For Each row As DataGridViewRow In DataGridChiTietPhieuNhap.Rows
			If row.Cells("Số lượng nhập").Value Is Nothing OrElse Integer.Parse(row.Cells("Số lượng nhập").Value.ToString()) = 0 Then
				Continue For
			End If
			Dim chiTietPhieuNhap = New ChiTietPhieuNhapDTO() With { 
				.MaPhieuNhap = MaPhieuNhap.Text, 
				.MaSach = row.Cells("Mã sách").Value.ToString(), 
				.SoLuongNhap = Integer.Parse(row.Cells("Số lượng nhập").Value.ToString()) 
			}

			listChiTietPhieuNhap.Add(chiTietPhieuNhap)
		Next

		If listChiTietPhieuNhap.Count = 0 Then
			MessageBox.Show("Phiếu nhập rỗng", "Lỗi")
		End If

		Try
			PhieuNhapBUS.InsertPhieuNhap(phieuNhap, listChiTietPhieuNhap)
		Catch exception As Exception
			MessageBox.Show(exception.Message, "Lỗi")
		End Try

		RefreshForm()
	End Sub

	Private Sub ThemSach_Click(sender As Object, e As EventArgs)
		If _childForm Is Nothing OrElse _childForm.IsDisposed Then
			_childForm = New FormChiTietPhieuNhap(Me)
			_childForm.Show()
		End If
	End Sub

	Public Sub ThemChiTietPhieuNhap(sach As SachDTO, soLuongNhap As Integer)
		For Each dataRow As DataRow In _dataTable.Rows
			If sach.MaSach <> dataRow("Mã sách").ToString() Then
				Continue For
			End If

			dataRow("Số lượng nhập") = Integer.Parse(dataRow("Số lượng nhập").ToString()) + soLuongNhap

			Return
		Next

		Dim row = _dataTable.NewRow()
		row("Mã sách") = sach.MaSach
		row("Tên sách") = sach.TenSach
		row("Thể loại") = sach.TheLoai
		row("Tác giả") = sach.TacGia
		row("Đơn giá") = sach.DonGia
		row("Số lượng tồn") = sach.SoLuongTon
		row("Số lượng nhập") = soLuongNhap
		_dataTable.Rows.Add(row)
	End Sub

	Private Sub XoaSach_Click(sender As Object, e As EventArgs)
		For Each row As DataGridViewRow In DataGridChiTietPhieuNhap.SelectedRows
			Dim tmp = _dataTable.Rows.Cast(Of DataRow)().Where(Function(r) r("Mã sách") Is row.Cells("Mã sách").Value).ToList()

		    For Each tmpObj In tmp
		        tmpObj.Delete()
		    Next
		Next
	End Sub
End Class
