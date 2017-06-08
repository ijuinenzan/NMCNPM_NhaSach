Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class BaoCaoCongNoDTO
	#Region "Properties"

	Public Property MaChiTietCongNo() As String
		Get
			Return m_MaChiTietCongNo
		End Get
		Set
			m_MaChiTietCongNo = Value
		End Set
	End Property
	Private m_MaChiTietCongNo As String

	Public Property Thang() As DateTime
		Get
			Return m_Thang
		End Get
		Set
			m_Thang = Value
		End Set
	End Property
	Private m_Thang As DateTime

	Public Property MaKhachHang() As String
		Get
			Return m_MaKhachHang
		End Get
		Set
			m_MaKhachHang = Value
		End Set
	End Property
	Private m_MaKhachHang As String

	Public Property NoDau() As Decimal
		Get
			Return m_NoDau
		End Get
		Set
			m_NoDau = Value
		End Set
	End Property
	Private m_NoDau As Decimal

	Public Property NoPhatSinh() As Decimal
		Get
			Return m_NoPhatSinh
		End Get
		Set
			m_NoPhatSinh = Value
		End Set
	End Property
	Private m_NoPhatSinh As Decimal

	Public Property NoCuoi() As Decimal
		Get
			Return m_NoCuoi
		End Get
		Set
			m_NoCuoi = Value
		End Set
	End Property
	Private m_NoCuoi As Decimal



	#End Region

	#Region "Constructor"

	Public Sub New()
		MaChiTietCongNo = ""
		MaKhachHang = ""
		Thang = DateTime.Now
		NoDau = 0
		NoCuoi = 0
		NoPhatSinh = 0
	End Sub
	#End Region
End Class
