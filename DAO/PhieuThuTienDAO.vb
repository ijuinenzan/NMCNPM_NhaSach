Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DTO

Public Class PhieuThuTienDAO
	#Region "1. Inserting"

	Public Shared Function InsertPhieuThu(phieuThu As PhieuThuTienDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaPhieuThu", phieuThu.MaPhieuThu))
			parameters.Add(New MySqlParameter("@NgayLap", phieuThu.NgayThu))
			parameters.Add(New MySqlParameter("@MaKhachHang", phieuThu.MaKhachHang))
			parameters.Add(New MySqlParameter("@SoTienThu", phieuThu.SoTienThu))

			Dim n = DataAccessHelper.ExecuteNonQuery("InsertPhieuThu", parameters)
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into phieuThu values('{phieuThu.MaphieuThu}', '{phieuThu.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");

			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaPhieuThu() As String
		Dim newMaPhieuThu As String = ""
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuThu")
			'var dt = DataAccessHelper.ExecuteQuery(
			'    "Select MAX(CAST(REPLACE(REPLACE(MaPhieuThu , 'PHNH', ''), '', '') as int)) + 1 as NewMaPhieuThu from PhieuThu");
			Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaPhieuThu").ToString())
			newMaPhieuThu = $"PHTH{temp:0000}"

			Return newMaPhieuThu
		Catch ex As Exception
			Throw ex
		End Try
	End Function


	#End Region
End Class
