Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Text
Imports System.Threading.Tasks
Imports MySql
Imports MySql.Data.MySqlClient
Imports DTO

Class ChiTietHoaDonDAO
	#Region "1. Inserting"

	Public Shared Function InsertChiTietHoaDon(chiTietHoaDon As ChiTietHoaDonDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_MaChiTietHoaDon", chiTietHoaDon.MaChiTietHoaDon))
			parameters.Add(New MySqlParameter("p_MaHoaDon", chiTietHoaDon.MaHoaDon))
			parameters.Add(New MySqlParameter("p_MaSach", chiTietHoaDon.MaSach))
			parameters.Add(New MySqlParameter("p_SoLuongBan", chiTietHoaDon.SoLuongBan))
			parameters.Add(New MySqlParameter("p_DonGiaBan", chiTietHoaDon.DonGiaBan))
			parameters.Add(New MySqlParameter("p_ThanhTien", chiTietHoaDon.ThanhTien))
			'    var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into ChiTietPhieuNhap values('{chiTietHoaDon.MaChiTietHoaDon}', '{chiTietHoaDon.MaHoaDon}', '{chiTietHoaDon.SoLuongNhap}', '{chiTietPhieuNhap.MaSach}')");
			Dim n = DataAccessHelper.ExecuteNonQuery("InsertChiTietHoaDon", parameters)
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

	Public Shared Function UpdateChiTietHoaDon(chiTietHoaDon As ChiTietHoaDonDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_MaChiTietHoaDon", chiTietHoaDon.MaChiTietHoaDon))
			parameters.Add(New MySqlParameter("p_MaHoaDon", chiTietHoaDon.MaHoaDon))
			parameters.Add(New MySqlParameter("p_MaSach", chiTietHoaDon.MaSach))
			parameters.Add(New MySqlParameter("p_SoLuongBan", chiTietHoaDon.SoLuongBan))
			parameters.Add(New MySqlParameter("p_DonGiaBan", chiTietHoaDon.DonGiaBan))
			parameters.Add(New MySqlParameter("p_ThanhTien", chiTietHoaDon.ThanhTien))

			Dim n = DataAccessHelper.ExecuteNonQuery("UpdateChiTietHoaDon", parameters)
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Update ChiTietPhieuNhap Set MaHoaDon = '{chiTietPhieuNhap.MaHoaDon}', SoLuongNhap = '{chiTietPhieuNhap.SoLuongNhap}', MaSach = '{chiTietPhieuNhap.MaSach}' where MaChiTietHoaDon = '{chiTietPhieuNhap.MaChiTietHoaDon}'");
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

	Public Shared Function DeleteChiTietHoaDonByMaChiTietHoaDon(MaChiTietHoaDon As String) As Boolean
		Dim result = False
		Try
			Dim n = DataAccessHelper.ExecuteNonQuery($"Delete From ChiTietPhieuNhap Where MaChiTietHoaDon = '{MaChiTietHoaDon}'")
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

	Public Shared Function SelectChiTietHoaDonAll() As List(Of ChiTietHoaDonDTO)
		Dim list = New List(Of ChiTietHoaDonDTO)()
		Try
			' var dt = DataAccessHelper.ExecuteQuery(
			'"Select MaChiTietHoaDon, MaHoaDon, SoLuongNhap, MaSach From ChiTietPhieuNhap");
			Dim dt = DataAccessHelper.ExecuteQuery("SelectChiTietPhieuNhapAll")
			list.AddRange(From dr In dt.Rows Select New ChiTietHoaDonDTO() With { 
				.MaChiTietHoaDon = dr("MaChiTietHoaDon").ToString(), 
				.MaHoaDon = dr("MaHoaDon").ToString(), 
				.SoLuongBan = Integer.Parse(dr("SoLuongNhap").ToString()), 
				.MaSach = dr("MaSach").ToString(), 
				.DonGiaBan = Decimal.Parse(dr("DonGiaBan").ToString()), 
				.ThanhTien = Decimal.Parse(dr("ThanhTien").ToString()) 
			})
		Catch ex As Exception
			Throw ex
		End Try

		Return list
	End Function

	Public Shared Function SelectChiTietHoaDonByMaChiTietHoaDon(MaChiTietHoaDon As String) As ChiTietHoaDonDTO
		Dim ChiTietHoaDon = New ChiTietHoaDonDTO()
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_MaChiTietHoaDon", MaChiTietHoaDon))
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaChiTietHoaDon, MaHoaDon, SoLuongNhap, MaSach From ChiTietPhieuNhap Where MaChiTietHoaDon = '{MaChiTietHoaDon}'");
			Dim dt = DataAccessHelper.ExecuteQuery("SelectChiTietHoaDonByMaChiTietHoaDon", parameters)
			Dim dr = dt.Rows(0)
			ChiTietHoaDon.MaChiTietHoaDon = dr("MaChiTietHoaDon").ToString()
			ChiTietHoaDon.MaHoaDon = dr("MaHoaDon").ToString()
			ChiTietHoaDon.SoLuongBan = Integer.Parse(dr("SoLuongNhap").ToString())
			ChiTietHoaDon.MaSach = dr("MaSach").ToString()
			ChiTietHoaDon.DonGiaBan = Decimal.Parse(dr("DonGiaBan").ToString())
			ChiTietHoaDon.ThanhTien = Decimal.Parse(dr("DonGiaBan").ToString())
		Catch ex As Exception
			Throw ex
		End Try

		Return ChiTietHoaDon
	End Function

	Public Shared Function CheckChiTietPhieuNhapByMaChiTietHoaDon(MaChiTietHoaDon As String) As Boolean
		Dim result = False
		Try
			Dim dt = DataAccessHelper.ExecuteQuery($"Select MaChiTietHoaDon From ChiTietPhieuNhap where MaChiTietHoaDon = '{MaChiTietHoaDon}'")
			If dt.Rows.Count = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaChiTietHoaDon() As String
		Dim newMaChiTietHoaDon = 0
		Try
			Dim dt = DataAccessHelper.ExecuteQuery("Select MAX(CAST(REPLACE(REPLACE(MaChiTietHoaDon , 'CTHD', ''), '', '') as int)) + 1 as NewMaChiTietHoaDon from ChiTietHoaDon")
			newMaChiTietHoaDon = If(dt.Rows(0)("NewMaChiTietHoaDon").ToString() = "", 1, Integer.Parse(dt.Rows(0)("NewMaChiTietHoaDon").ToString()))
		Catch ex As Exception
			Throw ex
		End Try

		Return $"CTHD{newMaChiTietHoaDon:0000}"
	End Function

	#End Region

End Class
