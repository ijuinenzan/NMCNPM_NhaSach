Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports DTO

Public Class ChiTietPhieuNhapDAO
	#Region "1. Inserting"

	Public Shared Function InsertChiTietPhieuNhap(chiTietPhieuNhap As ChiTietPhieuNhapDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_MaChiTietHoaDon", chiTietPhieuNhap.MaChiTietPhieuNhap))
			parameters.Add(New MySqlParameter("p_MaPhieuNhap", chiTietPhieuNhap.MaPhieuNhap))
			parameters.Add(New MySqlParameter("p_MaSach", chiTietPhieuNhap.MaSach))
			parameters.Add(New MySqlParameter("p_SoLuongNhap", chiTietPhieuNhap.SoLuongNhap))
			Dim n = DataAccessHelper.ExecuteNonQuery("InsertChiTietPhieuNhap", parameters)
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into ChiTietPhieuNhap values('{chiTietPhieuNhap.MaChiTietPhieuNhap}', '{chiTietPhieuNhap.MaPhieuNhap}', '{chiTietPhieuNhap.SoLuongNhap}', '{chiTietPhieuNhap.MaSach}')");
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	#End Region

	#Region "2. Updating"

	Public Shared Function UpdateChiTietPhieuNhap(chiTietPhieuNhap As ChiTietPhieuNhapDTO) As Boolean
		Dim result = False
		Try
			Dim n = DataAccessHelper.ExecuteNonQuery($"Update ChiTietPhieuNhap Set MaPhieuNhap = '{chiTietPhieuNhap.MaPhieuNhap}', SoLuongNhap = '{chiTietPhieuNhap.SoLuongNhap}', MaSach = '{chiTietPhieuNhap.MaSach}' where MaChiTietPhieuNhap = '{chiTietPhieuNhap.MaChiTietPhieuNhap}'")
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	#End Region

	#Region "3. Deleting"

	Public Shared Function DeleteChiTietPhieuNhapByMaChiTietPhieuNhap(maChiTietPhieuNhap As String) As Boolean
		Dim result = False
		Try
			Dim n = DataAccessHelper.ExecuteNonQuery($"Delete From ChiTietPhieuNhap Where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'")
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	#End Region

	#Region "4. Retrieving"

	Public Shared Function SelectChiTietPhieuNhapAll() As List(Of ChiTietPhieuNhapDTO)
		Dim list = New List(Of ChiTietPhieuNhapDTO)()
		Try
			Dim dt = DataAccessHelper.ExecuteQuery("Select MaChiTietPhieuNhap, MaPhieuNhap, SoLuongNhap, MaSach From ChiTietPhieuNhap")
			list.AddRange(From dr In dt.Rows Select New ChiTietPhieuNhapDTO() With { _
				.MaChiTietPhieuNhap = dr("MaChiTietPhieuNhap").ToString(), 
				.MaPhieuNhap = dr("MaPhieuNhap").ToString(), 
				.SoLuongNhap = Integer.Parse(dr("SoLuongNhap").ToString()), 
				.MaSach = dr("MaSach").ToString() 
			})
		Catch ex As Exception
			Throw ex
		End Try

		Return list
	End Function

	Public Shared Function SelectChiTietPhieuNhapByMaChiTietPhieuNhap(maChiTietPhieuNhap As String) As ChiTietPhieuNhapDTO
		Dim ChiTietPhieuNhap = New ChiTietPhieuNhapDTO()
		Try
			Dim dt = DataAccessHelper.ExecuteQuery($"Select MaChiTietPhieuNhap, MaPhieuNhap, SoLuongNhap, MaSach From ChiTietPhieuNhap Where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'")
			Dim dr = dt.Rows(0)
			ChiTietPhieuNhap.MaChiTietPhieuNhap = dr("MaChiTietPhieuNhap").ToString()
			ChiTietPhieuNhap.MaPhieuNhap = dr("MaPhieuNhap").ToString()
			ChiTietPhieuNhap.SoLuongNhap = Integer.Parse(dr("SoLuongNhap").ToString())
			ChiTietPhieuNhap.MaSach = dr("MaSach").ToString()
		Catch ex As Exception
			Throw ex
		End Try

		Return ChiTietPhieuNhap
	End Function

	Public Shared Function CheckChiTietPhieuNhapByMaChiTietPhieuNhap(maChiTietPhieuNhap As String) As Boolean
		Dim result = False
		Try
			Dim dt = DataAccessHelper.ExecuteQuery($"Select MaChiTietPhieuNhap From ChiTietPhieuNhap where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'")
			If dt.Rows.Count = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaChiTietPhieuNhap() As String
		Dim newMaChiTietPhieuNhap = 0
		Try
			Dim dt = DataAccessHelper.ExecuteQuery("Select MAX(CAST(REPLACE(REPLACE(MaChiTietPhieuNhap , 'CTPN', ''), '', '') as int)) + 1 as NewMaChiTietPhieuNhap from ChiTietPhieuNhap")
			newMaChiTietPhieuNhap = If(dt.Rows(0)("NewMaChiTietPhieuNhap").ToString() = "", 1, Integer.Parse(dt.Rows(0)("NewMaChiTietPhieuNhap").ToString()))
		Catch ex As Exception
			Throw ex
		End Try

		Return $"CTPN{newMaChiTietPhieuNhap:0000}"
	End Function

	#End Region
End Class
