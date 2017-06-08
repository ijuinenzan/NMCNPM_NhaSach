Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class BaoCaoCongNoBUS
	#Region "1. Inserting"
	Public Shared Sub InsertBaoCaoCongNo()

	End Sub

	Public Shared Sub UpdateBaoCaoCongNo(baocaocongno As BaoCaoCongNoDTO)
		If BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(baocaocongno.MaKhachHang, baocaocongno.Thang) Then

			BaoCaoCongNoDAO.UpdateBaoCaoCongNo(baocaocongno)
		Else
			BaoCaoCongNoDAO.InsertBaoCaoCongNo(baocaocongno)
		End If
	End Sub

	Public Shared Function SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As BaoCaoCongNoDTO
		Return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang)
	End Function

	Public Shared Function SelectBaoCaoCongNoByMaKhachHangvaThangTruoc(maKhachHang As String, thang As DateTime) As BaoCaoCongNoDTO

		Return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang)
	End Function


	Public Shared Function CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As Boolean
		Return BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang)
	End Function

	#End Region
End Class
