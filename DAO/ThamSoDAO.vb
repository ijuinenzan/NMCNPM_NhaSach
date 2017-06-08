Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports DTO

Public Class ThamSoDAO
	#Region "2. Updating"

	Public Shared Function UpdateSoLuongNhapItNhat(soLuongNhapItNhat As Integer) As Boolean
		Dim result = False
		Try

			Dim n = DataAccessHelper.ExecuteNonQuery($"Update ThamSo Set SoLuongNhapItNhat = {soLuongNhapItNhat}")
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function UpdateThamSo(thamso As ThamSoDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("p_SoLuongNhapToiThieu", thamso.SoLuongNhapItNhat))
			parameters.Add(New MySqlParameter("p_SoLuongTonToiDaTruocNhap", thamso.SoLuongTonToiDaTruocNhap))
			parameters.Add(New MySqlParameter("p_SoLuongTonToiThieuSauBan", thamso.SoLuongTonToiThieuSauBan))
			parameters.Add(New MySqlParameter("p_SoTienNoToiDa", thamso.SoTienNoToiDa))
			parameters.Add(New MySqlParameter("p_SuDungQuiDinh4", thamso.SuDungQuiDinh4))

			Dim n = DataAccessHelper.ExecuteNonQuery("UpdateThamSo", parameters)
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function UpdateSoLuongTonToiDaTruocNhap(soLuongTonToiDaTruocNhap As Integer) As Boolean
		Dim result = False
		Try
			Dim n = DataAccessHelper.ExecuteNonQuery($"Update ThamSo Set SoLuongTonToiDaTruocNhap = {soLuongTonToiDaTruocNhap}")
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

	Public Shared Function SelectThamSoAll() As ThamSoDTO

		Dim thamso = New ThamSoDTO()
		Dim dt = DataAccessHelper.ExecuteQuery("SelectThamSoAll")
		Dim dr = dt.Rows(0)

		thamso.SoLuongNhapItNhat = Integer.Parse(dr("SoLuongNhapToiThieu").ToString())
		thamso.SoLuongTonToiDaTruocNhap = Integer.Parse(dr("SoLuongTonToiDaTruocNhap").ToString())
		thamso.SoLuongTonToiThieuSauBan = Integer.Parse(dr("SoLuongTonToiThieuSauBan").ToString())
		thamso.SoTienNoToiDa = Integer.Parse(dr("SoTienNoToiDa").ToString())
		thamso.SuDungQuiDinh4 = [Boolean].Parse(dr("SuDungQuyDinh4").ToString())

		Return thamso
	End Function

	'public static int SelectSoLuongNhapItNhat()
	'{
	'    var soLuongNhapItNhat = 0;
	'    try
	'    {

	'    //    var dt = DataAccessHelper.ExecuteQuery(
	'    //        "Select SoLuongNhapItNhat from ThamSo");
	'     var dr = dt.Rows[0];
	'         = int.Parse(dt.Rows.ToString());
	'    }
	'    catch (Exception ex)
	'    {
	'        throw ex;
	'    }

	'    return soLuongNhapItNhat;
	'}

	Public Shared Function SelectSoLuongTonToiDaTruocNhap() As Integer
		Dim soLuongTonToiDaTruocNhap = 0
		Try
			Dim dt = DataAccessHelper.ExecuteQuery("Select SoLuongTonToiDaTruocNhap from ThamSo")
			Dim dr = dt.Rows(0)
			soLuongTonToiDaTruocNhap = Integer.Parse(dr("SoLuongTonToiDaTruocNhap").ToString())
		Catch ex As Exception
			Throw ex
		End Try

		Return soLuongTonToiDaTruocNhap
	End Function

	#End Region
End Class
