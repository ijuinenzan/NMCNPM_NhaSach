Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class PhieuThuTienDTO
	#Region "Properties"

	Public Property MaPhieuThu() As String
		Get
			Return m_MaPhieuThu
		End Get
		Set
			m_MaPhieuThu = Value
		End Set
	End Property
	Private m_MaPhieuThu As String

	Public Property NgayThu() As DateTime
		Get
			Return m_NgayThu
		End Get
		Set
			m_NgayThu = Value
		End Set
	End Property
	Private m_NgayThu As DateTime

	Public Property MaKhachHang() As String
		Get
			Return m_MaKhachHang
		End Get
		Set
			m_MaKhachHang = Value
		End Set
	End Property
	Private m_MaKhachHang As String

	Public Property SoTienThu() As Decimal
		Get
			Return m_SoTienThu
		End Get
		Set
			m_SoTienThu = Value
		End Set
	End Property
	Private m_SoTienThu As Decimal


	#End Region

	#Region "Constructor"

	Public Sub New()
		MaPhieuThu = ""
		MaKhachHang = ""
		NgayThu = DateTime.Now
		SoTienThu = 0
	End Sub
	#End Region
End Class
