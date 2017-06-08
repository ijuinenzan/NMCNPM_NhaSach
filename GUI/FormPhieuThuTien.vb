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

Public Partial Class FormPhieuThuTien
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub FormPhieuThuTien_Load(sender As Object, e As EventArgs)
		RefreshForm()
	End Sub

	Private Sub RefreshForm()
		maphieu_tb.Text = PhieuThuTienBUS.GenerateNewMaPhieuThu()
		makh_tb.Text = ""
		ten_tb.Text = ""
		diachi_tb.Text = ""
		sdt_tb.Text = ""
		email_tb.Text = ""
		sotienthu_tb.Text = "0"
		dateTimePicker1.Value = DateTime.Now
	End Sub

	Private Sub refresh_Click(sender As Object, e As EventArgs)
		RefreshForm()
	End Sub
End Class
