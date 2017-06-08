Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports DTO

Public Class PhieuNhapDAO
	#Region "1. Inserting"

	Public Shared Function InsertPhieuNhap(phieuNhap As PhieuNhapDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuNhap", phieuNhap.MaPhieuNhap))
			parameters.Add(New MySqlParameter("@NgayNhap", phieuNhap.NgayNhap))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into PhieuNhap values('{phieuNhap.MaPhieuNhap}', '{phieuNhap.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
			Dim n = DataAccessHelper.ExecuteNonQuery("InsertPhieuNhap", parameters)
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

	Public Shared Function UpdatePhieuNhap(phieuNhap As PhieuNhapDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuNhap", phieuNhap.MaPhieuNhap))
			parameters.Add(New MySqlParameter("@NgayNhap", phieuNhap.NgayNhap))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Update PhieuNhap Set NgayNhap = '{phieuNhap.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaPhieuNhap = '{phieuNhap.MaPhieuNhap}'");
			Dim n = DataAccessHelper.ExecuteNonQuery("UpdatePhieuNhap", parameters)
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

	Public Shared Function DeletePhieuNhapByMaPhieuNhap(maPhieuNhap As String) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuNhap", maPhieuNhap))
			'parameters.Add(new MySqlParameter("@NgayNhap", phieuNhap.NgayNhap));
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Delete From PhieuNhap Where MaPhieuNhap = '{maPhieuNhap}'");
			Dim n = DataAccessHelper.ExecuteNonQuery("DeletePhieuNhapByMaPhieuNhap", parameters)
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

	Public Shared Function SelectPhieuNhapAll() As List(Of PhieuNhapDTO)
		Dim list = New List(Of PhieuNhapDTO)()
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapAll")
			'    var dt = DataAccessHelper.ExecuteQuery(
			'        "Select MaPhieuNhap, NgayNhap From PhieuNhap");
			list.AddRange(From dr In dt.Rows Select New PhieuNhapDTO() With { 
				.MaPhieuNhap = dr("MaPhieuNhap").ToString(), 
				.NgayNhap = DateTime.Parse(dr("NgayNhap").ToString()) 
			})
		Catch ex As Exception
			Throw ex
		End Try

		Return list
	End Function

	Public Shared Function SelectPhieuNhapByMaPhieuNhap(maPhieuNhap As String) As PhieuNhapDTO
		Dim phieuNhap = New PhieuNhapDTO()
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuNhap", maPhieuNhap))
			Dim dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapByMaPhieuNhap", parameters)
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaPhieuNhap, NgayNhap From PhieuNhap Where MaPhieuNhap = '{maPhieuNhap}'");
			Dim dr = dt.Rows(0)
			phieuNhap.MaPhieuNhap = dr("MaPhieuNhap").ToString()
			phieuNhap.NgayNhap = DateTime.Parse(dr("NgayNhap").ToString())
		Catch ex As Exception
			Throw ex
		End Try

		Return phieuNhap
	End Function

	Public Shared Function CheckPhieuNhapByMaPhieuNhap(maPhieuNhap As String) As Boolean
		Dim result = False
		Try

			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuNhap", maPhieuNhap))
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaPhieuNhap From PhieuNhap where MaPhieuNhap = '{maPhieuNhap}'");
			Dim dt = DataAccessHelper.ExecuteQuery("CheckPhieuNhapByMaPhieuNhap", parameters)
			If dt.Rows.Count = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaPhieuNhap() As String
		Dim newMaPhieuNhap As String = ""
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuNhap2")
			'var dt = DataAccessHelper.ExecuteQuery(
			'    "Select MAX(CAST(REPLACE(REPLACE(MaPhieuNhap , 'PHNH', ''), '', '') as int)) + 1 as NewMaPhieuNhap from PhieuNhap");
			Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaPhieuNhap").ToString())
			newMaPhieuNhap = $"PHNH{temp:0000}"

			Return newMaPhieuNhap
		Catch ex As Exception
			Throw ex
		End Try
	End Function

	#End Region
End Class
