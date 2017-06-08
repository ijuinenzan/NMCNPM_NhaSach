Imports DTO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class BaoCaoCongNoDAO

	#Region "1. Inserting"

	Public Shared Function InsertBaoCaoCongNo(BaoCaoCongNo As BaoCaoCongNoDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo))
			parameters.Add(New MySqlParameter("@NgayNhap", BaoCaoCongNo.Thang))
			parameters.Add(New MySqlParameter("@MaKhachHang", BaoCaoCongNo.MaKhachHang))
			parameters.Add(New MySqlParameter("@NoDau", BaoCaoCongNo.NoDau))
			parameters.Add(New MySqlParameter("@NoCuoi", BaoCaoCongNo.NoCuoi))
			parameters.Add(New MySqlParameter("@NoPhatSinh", BaoCaoCongNo.NoPhatSinh))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Insert into BaoCaoCongNo values('{BaoCaoCongNo.MaBaoCaoCongNo}', '{BaoCaoCongNo.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
			Dim n = DataAccessHelper.ExecuteNonQuery("InsertBaoCaoCongNo", parameters)
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

	Public Shared Function UpdateBaoCaoCongNo(BaoCaoCongNo As BaoCaoCongNoDTO) As Boolean
		Dim result = False
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo))
			parameters.Add(New MySqlParameter("@NgayNhap", BaoCaoCongNo.Thang))
			parameters.Add(New MySqlParameter("@MaKhachHang", BaoCaoCongNo.MaKhachHang))
			parameters.Add(New MySqlParameter("@NoDau", BaoCaoCongNo.NoDau))
			parameters.Add(New MySqlParameter("@NoCuoi", BaoCaoCongNo.NoCuoi))
			parameters.Add(New MySqlParameter("@NoPhatSinh", BaoCaoCongNo.NoPhatSinh))
			'var n = DataAccessHelper.ExecuteNonQuery(
			'    $"Update BaoCaoCongNo Set NgayNhap = '{BaoCaoCongNo.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaBaoCaoCongNo = '{BaoCaoCongNo.MaBaoCaoCongNo}'");
			Dim n = DataAccessHelper.ExecuteNonQuery("UpdateBaoCaoCongNo", parameters)
			If n = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	#End Region

	Public Shared Function SelectBaoCaoCongNoAll() As List(Of BaoCaoCongNoDTO)
		Dim list = New List(Of BaoCaoCongNoDTO)()
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoAll")
			'    var dt = DataAccessHelper.ExecuteQuery(
			'        "Select MaBaoCaoCongNo, NgayNhap From BaoCaoCongNo");
			list.AddRange(From dr In dt.Rows Select New BaoCaoCongNoDTO() With { 
				.MaChiTietCongNo = dr("MaChiTietCongNo").ToString(), 
				.Thang = DateTime.Parse(dr("Thang").ToString()), 
				.MaKhachHang = dr("MaKhachHang").ToString(), 
				.NoCuoi = Decimal.Parse(dr("NoCuoi").ToString()), 
				.NoDau = Decimal.Parse(dr("NoDau").ToString()), 
				.NoPhatSinh = Decimal.Parse(dr("NoPhatSinh").ToString()) 
			})
		Catch ex As Exception
			Throw ex
		End Try

		Return list
	End Function

	Public Shared Function SelectBaoCaoCongNoByMaBaoCaoCongNo(maChiTietCongNo As String) As BaoCaoCongNoDTO
		Dim BaoCaoCongNo = New BaoCaoCongNoDTO()
		Try
			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaChiTietCongNo", maChiTietCongNo))
			Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoByMaBaoCaoCongNo", parameters)
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaBaoCaoCongNo, NgayNhap From BaoCaoCongNo Where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
			Dim dr = dt.Rows(0)
			BaoCaoCongNo.MaChiTietCongNo = dr("MaChiTietCongNo").ToString()
			BaoCaoCongNo.Thang = DateTime.Parse(dr("Thang").ToString())
		Catch ex As Exception
			Throw ex
		End Try

		Return BaoCaoCongNo
	End Function

	Public Shared Function SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As BaoCaoCongNoDTO
		Dim baocaocongno = New BaoCaoCongNoDTO()
		Try

			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaKhachHang", maKhachHang))
			parameters.Add(New MySqlParameter("@Thang", thang))
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaBaoCaoCongNo From BaoCaoCongNo where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
			Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoByMaKhachHangvaThang", parameters)
			Dim dr = dt.Rows(0)
			baocaocongno.MaChiTietCongNo = dr("MaChiTietCongNo").ToString()
			baocaocongno.Thang = DateTime.Parse(dr("Thang").ToString())
			baocaocongno.MaKhachHang = dr("MaKhachHang").ToString()
			baocaocongno.NoCuoi = Decimal.Parse(dr("NoCuoi").ToString())
			baocaocongno.NoDau = Decimal.Parse(dr("NoDau").ToString())

			baocaocongno.NoPhatSinh = Decimal.Parse(dr("NoPhatSinh").ToString())
		Catch ex As Exception
			Throw ex
		End Try

		Return baocaocongno
	End Function

	Public Shared Function CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As Boolean
		Dim result = False
		Try

			Dim parameters As New List(Of MySqlParameter)()
			parameters.Add(New MySqlParameter("@MaKhachHang", maKhachHang))
			parameters.Add(New MySqlParameter("@Thang", thang))
			'var dt = DataAccessHelper.ExecuteQuery(
			'    $"Select MaBaoCaoCongNo From BaoCaoCongNo where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
			Dim dt = DataAccessHelper.ExecuteQuery("CheckBaoCaoCongNoByMaKhachHangvaThang", parameters)
			If dt.Rows.Count = 1 Then
				result = True
			End If
		Catch ex As Exception
			Throw ex
		End Try

		Return result
	End Function

	Public Shared Function GenerateNewMaBaoCaoCongNo() As String
		Dim newMaBaoCaoCongNo As String = ""
		Try

			Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaBaoCaoCongNo")
			'var dt = DataAccessHelper.ExecuteQuery(
			'    "Select MAX(CAST(REPLACE(REPLACE(MaBaoCaoCongNo , 'PHNH', ''), '', '') as int)) + 1 as NewMaBaoCaoCongNo from BaoCaoCongNo");
			Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaBaoCaoCongNo").ToString())
			newMaBaoCaoCongNo = $"BCCN{temp:0000}"

			Return newMaBaoCaoCongNo
		Catch ex As Exception
			Throw ex
		End Try
	End Function
End Class
