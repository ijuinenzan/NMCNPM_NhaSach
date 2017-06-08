Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ChiTietPhieuNhapDTO
	#Region "Properties"

	Public Property MaChiTietPhieuNhap() As String
		Get
			Return m_MaChiTietPhieuNhap
		End Get
		Set
			m_MaChiTietPhieuNhap = Value
		End Set
	End Property
	Private m_MaChiTietPhieuNhap As String

	Public Property MaPhieuNhap() As String
		Get
			Return m_MaPhieuNhap
		End Get
		Set
			m_MaPhieuNhap = Value
		End Set
	End Property
	Private m_MaPhieuNhap As String

	Public Property MaSach() As String
		Get
			Return m_MaSach
		End Get
		Set
			m_MaSach = Value
		End Set
	End Property
	Private m_MaSach As String

	Public Property SoLuongNhap() As Integer
		Get
			Return m_SoLuongNhap
		End Get
		Set
			m_SoLuongNhap = Value
		End Set
	End Property
	Private m_SoLuongNhap As Integer

	#End Region

	#Region "Constructor"

	Public Sub New()
		MaChiTietPhieuNhap = ""
		MaPhieuNhap = ""
		MaSach = ""
		SoLuongNhap = 0
	End Sub

	#End Region
End Class
