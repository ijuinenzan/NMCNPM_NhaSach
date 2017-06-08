Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class KhachHangBUS
	#Region "1. Inserting"
	Public Shared Function InsertKhachHang(listKhachHang As List(Of KhachHangDTO)) As Boolean
		For Each khachhang As KhachHangDTO In listKhachHang
			khachhang.MaKhachHang = KhachHangDAO.GenerateNewMaKhachHang()
			khachhang.SoTienNo = 0
			If Not KhachHangDAO.InsertKhachHang(khachhang) Then
				Return False
			End If
		Next

		Return True
	End Function
	#End Region

	#Region "4. Retrieving"
	Public Shared Function SelectKhachHangByMaKhachHang(maKhachHang As String) As KhachHangDTO
		Return KhachHangDAO.SelectKhachHangByMaKhachHang(maKhachHang)
	End Function


	Public Shared Function CheckKhachHangByMaKhachHang(maKhachHang As String) As Boolean
		Return KhachHangDAO.CheckKhachHangByMaKhachHang(maKhachHang)
	End Function
	#End Region

	Public Shared Function GenerateNewMaKhachHang() As String
		Return KhachHangDAO.GenerateNewMaKhachHang()
	End Function
End Class
