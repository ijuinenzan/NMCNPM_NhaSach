Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class KhachHangDTO
	#Region "Properties"

	Public Property MaKhachHang() As String
		Get
			Return m_MaKhachHang
		End Get
		Set
			m_MaKhachHang = Value
		End Set
	End Property
	Private m_MaKhachHang As String

	Public Property HoTenKhachHang() As String
		Get
			Return m_HoTenKhachHang
		End Get
		Set
			m_HoTenKhachHang = Value
		End Set
	End Property
	Private m_HoTenKhachHang As String

	Public Property DiaChi() As String
		Get
			Return m_DiaChi
		End Get
		Set
			m_DiaChi = Value
		End Set
	End Property
	Private m_DiaChi As String

	Public Property SoDienThoai() As String
		Get
			Return m_SoDienThoai
		End Get
		Set
			m_SoDienThoai = Value
		End Set
	End Property
	Private m_SoDienThoai As String

	Public Property Email() As String
		Get
			Return m_Email
		End Get
		Set
			m_Email = Value
		End Set
	End Property
	Private m_Email As String

	Public Property SoTienNo() As Decimal
		Get
			Return m_SoTienNo
		End Get
		Set
			m_SoTienNo = Value
		End Set
	End Property
	Private m_SoTienNo As Decimal

	Public Property TinhTrang() As Boolean
		Get
			Return m_TinhTrang
		End Get
		Set
			m_TinhTrang = Value
		End Set
	End Property
	Private m_TinhTrang As Boolean
	#End Region

	#Region "Constructor"
	Public Sub New()
		MaKhachHang = ""
		HoTenKhachHang = ""
		DiaChi = ""
		SoDienThoai = ""
		Email = ""
		SoTienNo = 0
		TinhTrang = True
	End Sub
	#End Region
End Class
