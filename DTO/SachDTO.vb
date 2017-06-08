Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class SachDTO
	#Region "Properties"

	Public Property MaSach() As String
		Get
			Return m_MaSach
		End Get
		Set
			m_MaSach = Value
		End Set
	End Property
	Private m_MaSach As String

	Public Property TenSach() As String
		Get
			Return m_TenSach
		End Get
		Set
			m_TenSach = Value
		End Set
	End Property
	Private m_TenSach As String

	Public Property TheLoai() As String
		Get
			Return m_TheLoai
		End Get
		Set
			m_TheLoai = Value
		End Set
	End Property
	Private m_TheLoai As String

	Public Property TacGia() As String
		Get
			Return m_TacGia
		End Get
		Set
			m_TacGia = Value
		End Set
	End Property
	Private m_TacGia As String

	Public Property DonGia() As Single
		Get
			Return m_DonGia
		End Get
		Set
			m_DonGia = Value
		End Set
	End Property
	Private m_DonGia As Single

	Public Property SoLuongTon() As Integer
		Get
			Return m_SoLuongTon
		End Get
		Set
			m_SoLuongTon = Value
		End Set
	End Property
	Private m_SoLuongTon As Integer

	Public Property TinhTrang() As Integer
		Get
			Return m_TinhTrang
		End Get
		Set
			m_TinhTrang = Value
		End Set
	End Property
	Private m_TinhTrang As Integer

	#End Region

	#Region "Constructor"

	Public Sub New()
		MaSach = ""
		TenSach = ""
		TacGia = ""
		SoLuongTon = 0
		DonGia = 0
		TheLoai = ""
		TinhTrang = 0
	End Sub

	#End Region
End Class
