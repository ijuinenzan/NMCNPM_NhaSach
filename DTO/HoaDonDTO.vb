Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class HoaDonDTO
	#Region "Properties"
	Public Property MaHoaDon() As String
		Get
			Return m_MaHoaDon
		End Get
		Set
			m_MaHoaDon = Value
		End Set
	End Property
	Private m_MaHoaDon As String

	Public Property MaKhachHang() As String
		Get
			Return m_MaKhachHang
		End Get
		Set
			m_MaKhachHang = Value
		End Set
	End Property
	Private m_MaKhachHang As String

	Public Property NgayLapHoaDon() As String
		Get
			Return m_NgayLapHoaDon
		End Get
		Set
			m_NgayLapHoaDon = Value
		End Set
	End Property
	Private m_NgayLapHoaDon As String

	Public Property TongThanhTien() As Integer
		Get
			Return m_TongThanhTien
		End Get
		Set
			m_TongThanhTien = Value
		End Set
	End Property
	Private m_TongThanhTien As Integer
	#End Region

	#Region "Constructor"
	Public Sub New()
		MaHoaDon = ""
		MaKhachHang = ""
		NgayLapHoaDon = ""
		TongThanhTien = 0
	End Sub
	#End Region
End Class
