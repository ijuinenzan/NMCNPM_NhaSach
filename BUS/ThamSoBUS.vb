Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DTO

Imports DAO

Public Class ThamSoBUS
	#Region "4. Updating"

	Public Shared Function UpdateSoLuongNhapItNhat(soLuongNhapItNhat As Integer) As Boolean
		Return ThamSoDAO.UpdateSoLuongNhapItNhat(soLuongNhapItNhat)
	End Function

	Public Shared Function UpdateSoLuongTonToiDaTruocNhap(soLuongTonToiDaTruocNhap As Integer) As Boolean
		Return ThamSoDAO.UpdateSoLuongTonToiDaTruocNhap(soLuongTonToiDaTruocNhap)
	End Function

	Public Shared Function UpdateThamSo(thamso As ThamSoDTO) As Boolean
		Return ThamSoDAO.UpdateThamSo(thamso)
	End Function

	#End Region

	#Region "4. Retrieving"

	Public Shared Function SelectSoLuongNhapItNhat() As Integer
		Return ThamSoDAO.SelectThamSoAll().SoLuongNhapItNhat
	End Function

	Public Shared Function SelectSoLuongTonToiDaTruocNhap() As Integer
		Return ThamSoDAO.SelectThamSoAll().SoLuongTonToiDaTruocNhap
	End Function

	Public Shared Function CheckApDungQuiDinh4() As Boolean
		Dim thamso = ThamSoDAO.SelectThamSoAll()
		Return thamso.SuDungQuiDinh4
	End Function
	Public Shared Function SelectThamSoAll() As ThamSoDTO
		Return ThamSoDAO.SelectThamSoAll()
	End Function




	#End Region
End Class
