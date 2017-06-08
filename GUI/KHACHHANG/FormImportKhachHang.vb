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

Namespace KHACHHANG
	Public Partial Class FormImportKhachHang
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub FormImportKhachHang_Load(sender As Object, e As EventArgs)
			RefreshBase()
		End Sub

		Private Sub RefreshBase()
		End Sub


		Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			'dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Mã khách hàng"].Value = KhachHangBUS.GenerateNewMaKhachHang();
		End Sub
		Private Sub dataGridView1_DefaultValuesNeeded(sender As Object, e As System.Windows.Forms.DataGridViewRowEventArgs)
			'e.Row.Cells["Mã khách hàng"].Value = KhachHangBUS.GenerateNewMaKhachHang();
		End Sub

		Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			'dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["maKH_col"].Value = KhachHangBUS.GenerateNewMaKhachHang();
		End Sub

		Private Sub import_button_Click(sender As Object, e As EventArgs)
			'int temp = int.Parse(_baseMaKhachHang.Substring(2)) + (_index++);
			'DataGridViewRow dgvr = new System.Windows.Forms.DataGridViewRow();
			'dgvr.CreateCells(dataGridView1);
			'''/dgvr.Cells[0].Value = String.Format("KH{0:0000}", temp);
			'dgvr.Cells[0].Value = $"KH{temp:0000}";
			'dataGridView1.Rows.Add(dgvr);

			Dim listKhachHang As New List(Of KhachHangDTO)()

			For Each row As DataGridViewRow In dataGridView1.Rows
				If Not row.IsNewRow Then
					Dim temp As New KhachHangDTO() With { 
						.HoTenKhachHang = row.Cells("hoten_col").Value.ToString(), 
						.DiaChi = If(row.Cells("diachi_col").Value Is Nothing, "", row.Cells("diachi_col").Value.ToString()), 
						.SoDienThoai = If(row.Cells("sdt_col").Value Is Nothing, "", row.Cells("sdt_col").Value.ToString()), 
						.Email = If(row.Cells("email_col").Value Is Nothing, "", row.Cells("email_col").Value.ToString()) 
					}

					listKhachHang.Add(temp)
				End If
			Next

			If KhachHangBUS.InsertKhachHang(listKhachHang) Then
				MessageBox.Show("Nhập khách hàng thành công!", "Thành công")
			End If


		End Sub
	End Class
End Namespace
