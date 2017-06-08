Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ThamSoDTO
	#Region "Properties"

	Public Property SoLuongNhapItNhat() As Integer
		Get
			Return m_SoLuongNhapItNhat
		End Get
		Set
			m_SoLuongNhapItNhat = Value
		End Set
	End Property
	Private m_SoLuongNhapItNhat As Integer

	Public Property SoLuongTonToiDaTruocNhap() As Integer
		Get
			Return m_SoLuongTonToiDaTruocNhap
		End Get
		Set
			m_SoLuongTonToiDaTruocNhap = Value
		End Set
	End Property
	Private m_SoLuongTonToiDaTruocNhap As Integer

	Public Property SoLuongTonToiThieuSauBan() As Integer
		Get
			Return m_SoLuongTonToiThieuSauBan
		End Get
		Set
			m_SoLuongTonToiThieuSauBan = Value
		End Set
	End Property
	Private m_SoLuongTonToiThieuSauBan As Integer

	Public Property SoTienNoToiDa() As Integer
		Get
			Return m_SoTienNoToiDa
		End Get
		Set
			m_SoTienNoToiDa = Value
		End Set
	End Property
	Private m_SoTienNoToiDa As Integer

	Public Property SuDungQuiDinh4() As Boolean
		Get
			Return m_SuDungQuiDinh4
		End Get
		Set
			m_SuDungQuiDinh4 = Value
		End Set
	End Property
	Private m_SuDungQuiDinh4 As Boolean
	#End Region

	#Region "Constructor"

	Public Sub New()
		SoLuongNhapItNhat = 0
		SoLuongTonToiDaTruocNhap = 0
		SoLuongTonToiThieuSauBan = 0
		SoTienNoToiDa = 0
		SuDungQuiDinh4 = True
	End Sub

	#End Region
End Class
