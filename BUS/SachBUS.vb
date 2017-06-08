Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports DAO

Imports DTO

Public Class SachBUS
	#Region "1. Inserting"
	Public Shared Function InsertSach(listSach As List(Of SachDTO)) As Boolean
		For Each sach As SachDTO In listSach
			sach.MaSach = SachDAO.GenerateNewMaSach()
			sach.SoLuongTon = 0
			If Not SachDAO.InsertSach(sach) Then
				Return False
			End If
		Next

		Return True
	End Function
	#End Region

	#Region "4. Retrieving"

	Public Shared Function SelectSachAll() As List(Of SachDTO)
		Return SachDAO.SelectSachAll()
	End Function

	Public Shared Function SelectSachByMaSach(maSach As String) As SachDTO
		Return SachDAO.SelectSachByMaSach(maSach)
	End Function

	#End Region

	#Region "5.Finding"
	Public Shared Function FindSachByTenSach(tensach As String) As List(Of SachDTO)
		Dim listSach As New List(Of SachDTO)()
		Dim listResult As New List(Of SachDTO)()

				'if(sach.TenSach )
		For Each sach As SachDTO In listSach
		Next

		Return listResult
	End Function
	#End Region
End Class
