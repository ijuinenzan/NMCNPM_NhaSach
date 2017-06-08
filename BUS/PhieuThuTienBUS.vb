Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class PhieuThuTienBUS

	Public Shared Function InsertPhieuThuTien(phieuthu As PhieuThuTienDTO) As Boolean
		Dim baocaocongno_moi = New BaoCaoCongNoDTO()
		Dim baocaocongno_truoc = BaoCaoCongNoBUS.SelectBaoCaoCongNoByMaKhachHangvaThangTruoc(phieuthu.MaKhachHang, phieuthu.NgayThu)
		Dim khachhang = KhachHangDAO.SelectKhachHangByMaKhachHang(phieuthu.MaKhachHang)
		baocaocongno_moi.MaKhachHang = khachhang.MaKhachHang
		baocaocongno_moi.Thang = phieuthu.NgayThu
		If ThamSoBUS.CheckApDungQuiDinh4() Then
			phieuthu.SoTienThu = khachhang.SoTienNo
			If phieuthu.NgayThu.[Date].ToString() = "1" Then
				baocaocongno_moi.NoDau = baocaocongno_truoc.NoCuoi
			End If
			If baocaocongno_moi.NoDau = khachhang.SoTienNo Then
				baocaocongno_moi.NoPhatSinh = 0
				baocaocongno_moi.NoCuoi = khachhang.SoTienNo
			End If
			baocaocongno_moi.NoCuoi = InlineAssignHelper(baocaocongno_moi.NoCuoi, phieuthu.SoTienThu)
			baocaocongno_moi.NoPhatSinh = baocaocongno_moi.NoPhatSinh - phieuthu.SoTienThu
			khachhang.SoTienNo = khachhang.SoTienNo - phieuthu.SoTienThu
			If BaoCaoCongNoBUS.CheckBaoCaoCongNoByMaKhachHangvaThang(phieuthu.MaKhachHang, phieuthu.NgayThu) Then
				BaoCaoCongNoBUS.UpdateBaoCaoCongNo(baocaocongno_moi)
					'BaoCaoCongNoBUS.InsertBaoCaoCongNo(baocaocongno_moi);
			Else
			End If

		Else
		End If

		Return True
	End Function
	Public Shared Function GenerateNewMaPhieuThu() As String
		Return PhieuThuTienDAO.GenerateNewMaPhieuThu()
	End Function
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function


End Class
