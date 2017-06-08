Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports DAO

Imports DTO

Public Class PhieuNhapBUS
	#Region "1. Inserting"

	Public Shared Function InsertPhieuNhap(phieuNhap As PhieuNhapDTO, listChiTietPhieuNhap As List(Of ChiTietPhieuNhapDTO)) As Boolean
		If PhieuNhapDAO.CheckPhieuNhapByMaPhieuNhap(phieuNhap.MaPhieuNhap) Then
			Throw New Exception("Mã phiếu nhập đã tồn tại")
		End If

		For Each chiTietPhieuNhap In listChiTietPhieuNhap
			If ChiTietPhieuNhapDAO.CheckChiTietPhieuNhapByMaChiTietPhieuNhap(chiTietPhieuNhap.MaChiTietPhieuNhap) Then
				Throw New Exception("Mã chi tiết phiếu nhập đã tồn tại")
			End If

			If chiTietPhieuNhap.SoLuongNhap < ThamSoDAO.SelectThamSoAll().SoLuongNhapItNhat Then
				Throw New Exception("Sách có mã {chiTietPhieuNhap.MaSach} có số lượng nhập ít hơn {ThamSoDAO.SelectThamSoAll( ).SoLuongNhapItNhat}")
			End If

			If SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach).SoLuongTon > ThamSoDAO.SelectSoLuongTonToiDaTruocNhap() Then
				Throw New Exception("Sách có mã {chiTietPhieuNhap.MaSach} có số lượng tồn nhiều hơn {ThamSoDAO.SelectSoLuongTonToiDaTruocNhap ( )}")
			End If
		Next

		PhieuNhapDAO.InsertPhieuNhap(phieuNhap)
		For Each chiTietPhieuNhap In listChiTietPhieuNhap
			chiTietPhieuNhap.MaChiTietPhieuNhap = ChiTietPhieuNhapDAO.GenerateNewMaChiTietPhieuNhap()

			ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap(chiTietPhieuNhap)

			Dim sach As SachDTO = SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach)
			sach.SoLuongTon += chiTietPhieuNhap.SoLuongNhap
			SachDAO.UpdateSach(sach)
		Next

		Return True
	End Function

	#End Region
	#Region "2. Update"

	#End Region
	#Region "4. Retrieving"

	Public Shared Function GenerateNewMaPhieuNhap() As String
		Return PhieuNhapDAO.GenerateNewMaPhieuNhap()
	End Function

	#End Region
End Class
