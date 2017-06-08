Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ChiTietHoaDonDTO
	#Region "Properties"
	Public Property MaChiTietHoaDon() As String
		Get
			Return m_MaChiTietHoaDon
		End Get
		Set
			m_MaChiTietHoaDon = Value
		End Set
	End Property
	Private m_MaChiTietHoaDon As String

	Public Property MaSach() As String
		Get
			Return m_MaSach
		End Get
		Set
			m_MaSach = Value
		End Set
	End Property
	Private m_MaSach As String

	Public Property MaHoaDon() As String
		Get
			Return m_MaHoaDon
		End Get
		Set
			m_MaHoaDon = Value
		End Set
	End Property
	Private m_MaHoaDon As String

	Public Property SoLuongBan() As Integer
		Get
			Return m_SoLuongBan
		End Get
		Set
			m_SoLuongBan = Value
		End Set
	End Property
	Private m_SoLuongBan As Integer

	Public Property DonGiaBan() As Decimal
		Get
			Return m_DonGiaBan
		End Get
		Set
			m_DonGiaBan = Value
		End Set
	End Property
	Private m_DonGiaBan As Decimal

	Public Property ThanhTien() As Decimal
		Get
			Return m_ThanhTien
		End Get
		Set
			m_ThanhTien = Value
		End Set
	End Property
	Private m_ThanhTien As Decimal

	#End Region

	#Region "Constructor"
	Public Sub New()
		MaChiTietHoaDon = ""
		MaHoaDon = ""
		MaSach = ""
		SoLuongBan = 0
		DonGiaBan = 0
		ThanhTien = 0
	End Sub
	#End Region
End Class
