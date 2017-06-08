Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports DTO

Public Class HoaDonDAO
	#Region "1. Inserting"

	Public Shared Function InsertHoaDon(hoaDon As HoaDonDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaHoaDon", hoaDon.MaHoaDon))
			parameters.Add(New MySqlParameter("@NgayLapHoaDon", hoaDon.NgayLapHoaDon))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into hoaDon values('{hoaDon.MaHoaDon}', '{hoaDon.NgayLapHoaDon.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
			Dim n = DataAccessHelper.ExecuteNonQuery("InsertHoaDon", parameters)
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

	Public Shared Function UpdateHoaDon(hoaDon As HoaDonDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_MaHoaDon", hoaDon.MaHoaDon))
			parameters.Add(New MySqlParameter("p_NgayLapHoaDon", hoaDon.NgayLapHoaDon))
			parameters.Add(New MySqlParameter("p_MaKhachHang", hoaDon.MaKhachHang))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Update hoaDon Set NgayLapHoaDon = '{hoaDon.NgayLapHoaDon.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaHoaDon = '{hoaDon.MaHoaDon}'");
			Dim n = DataAccessHelper.ExecuteNonQuery("UpdateHoaDon", parameters)
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

	Public Shared Function DeletehoaDonByMaHoaDon(MaHoaDon As String) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaHoaDon", MaHoaDon))
			'parameters.Add(new MySqlParameter("@NgayLapHoaDon", hoaDon.NgayLapHoaDon));
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Delete From hoaDon Where MaHoaDon = '{MaHoaDon}'");
			Dim n = DataAccessHelper.ExecuteNonQuery("DeleteHoaDonByMaHoaDon", parameters)
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

	Public Shared Function SelecthoaDonAll() As List(Of HoaDonDTO)
		Dim list = New List(Of HoaDonDTO)()
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("SelecthoaDonAll")
			'    var dt = DataAccessHelper.ExecuteQuery(
			'        "Select MaHoaDon, NgayLapHoaDon From hoaDon");
			list.AddRange(From dr In dt.Rows Select New HoaDonDTO() With { 
				.MaHoaDon = dr("MaHoaDon").ToString(), 
				.NgayLapHoaDon = dr("NgayLapHoaDon").ToString() 
			})
		Catch ex As Exception
			Throw ex
		End Try

		Return list
	End Function

	Public Shared Function SelecthoaDonByMaHoaDon(MaHoaDon As String) As HoaDonDTO
		Dim hoaDon = New HoaDonDTO()
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaHoaDon", MaHoaDon))
			Dim dt = DataAccessHelper.ExecuteQuery("SelecthoaDonByMaHoaDon", parameters)
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaHoaDon, NgayLapHoaDon From hoaDon Where MaHoaDon = '{MaHoaDon}'");
			Dim dr = dt.Rows(0)
			hoaDon.MaHoaDon = dr("MaHoaDon").ToString()
			hoaDon.NgayLapHoaDon = dr("NgayLapHoaDon").ToString()
		Catch ex As Exception
			Throw ex
		End Try

		Return hoaDon
	End Function

	Public Shared Function CheckhoaDonByMaHoaDon(MaHoaDon As String) As Boolean
		Dim result = False
		Try

			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaHoaDon", MaHoaDon))
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaHoaDon From hoaDon where MaHoaDon = '{MaHoaDon}'");
			Dim dt = DataAccessHelper.ExecuteQuery("CheckhoaDonByMaHoaDon", parameters)
			If dt.Rows.Count = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaHoaDon() As String
		Dim newMaHoaDon As String = ""
		Try
			Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaHoaDon")
			'    "Select MAX(CAST(REPLACE(REPLACE(MaHoaDon , 'PHNH', ''), '', '') as int)) + 1 as NewMaHoaDon from hoaDon");
			'newMaHoaDon = dt.Rows[0]["NewMaHoaDon"].ToString() == "" ?
			'    1 :
			'    int.Parse(dt.Rows[0]["NewMaHoaDon"].ToString());
			Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaHoaDon").ToString())
			newMaHoaDon = $"HD{temp:0000}"
			Return newMaHoaDon
			

		Catch ex As Exception
			Throw ex
		End Try
	End Function

	#End Region
End Class
