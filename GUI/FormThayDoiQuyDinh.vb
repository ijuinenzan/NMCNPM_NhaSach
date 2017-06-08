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

Public Partial Class FormThayDoiQuyDinh
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub FormThayDoiQuyDinh_Load(sender As Object, e As EventArgs)
		Dim thamso = New ThamSoDTO()
		thamso = ThamSoBUS.SelectThamSoAll()
		slNhap_tb.Text = thamso.SoLuongNhapItNhat.ToString()
		slTonTruocNhap_tb.Text = thamso.SoLuongTonToiDaTruocNhap.ToString()
		slTonSauBan_tb.Text = thamso.SoLuongTonToiThieuSauBan.ToString()
		tienNo_tb.Text = thamso.SoTienNoToiDa.ToString()
		sudungquidinh.Checked = thamso.SuDungQuiDinh4
	End Sub

	Private Sub capnhat_bt_Click(sender As Object, e As EventArgs)
		Dim thamso = New ThamSoDTO()
		thamso.SoLuongNhapItNhat = Integer.Parse(slNhap_tb.Text)
		thamso.SoLuongTonToiDaTruocNhap = Integer.Parse(slTonTruocNhap_tb.Text)
		thamso.SoLuongTonToiThieuSauBan = Integer.Parse(slTonSauBan_tb.Text)
		thamso.SoTienNoToiDa = Integer.Parse(tienNo_tb.Text)
		thamso.SuDungQuiDinh4 = sudungquidinh.Checked

		If ThamSoBUS.UpdateThamSo(thamso) Then
			MessageBox.Show("Thành công!")
		Else
			MessageBox.Show("Thất bại!")
		End If
		

	End Sub
End Class
