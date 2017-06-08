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


Namespace SACH
	Public Partial Class FormImportSach
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
			'''dgvr.Cells[0].Value = String.Format("KH{0:0000}", temp);
			'dgvr.Cells[0].Value = $"KH{temp:0000}";
			'dataGridView1.Rows.Add(dgvr);

			Dim listSach As New List(Of SachDTO)()

			For Each row As DataGridViewRow In dataGridView1.Rows
				If Not row.IsNewRow Then
					Dim temp As New SachDTO() With { 
						.TenSach = row.Cells("tensach").Value.ToString(), 
						.TheLoai = If(row.Cells("theloai").Value Is Nothing, "", row.Cells("theloai").Value.ToString()), 
						.TacGia = If(row.Cells("tacgia").Value Is Nothing, "", row.Cells("tacgia").Value.ToString()), 
						.DonGia = Single.Parse(If(row.Cells("dongia").Value Is Nothing, "", row.Cells("dongia").Value.ToString())) 
					}

					listSach.Add(temp)
				End If
			Next

			If SachBUS.InsertSach(listSach) Then
				MessageBox.Show("Thêm sách thành công", "Thành công")
			Else
				MessageBox.Show("Thêm sách thất bại", "Thất bại")
			End If

		End Sub
	End Class
End Namespace
