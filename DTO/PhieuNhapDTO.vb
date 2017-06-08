Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class PhieuNhapDTO
	#Region "Properties"

	Public Property MaPhieuNhap() As String
		Get
			Return m_MaPhieuNhap
		End Get
		Set
			m_MaPhieuNhap = Value
		End Set
	End Property
	Private m_MaPhieuNhap As String

	Public Property NgayNhap() As DateTime
		Get
			Return m_NgayNhap
		End Get
		Set
			m_NgayNhap = Value
		End Set
	End Property
	Private m_NgayNhap As DateTime

	#End Region

	#Region "Constructor"

	Public Sub New()
		MaPhieuNhap = ""
		NgayNhap = New DateTime()
	End Sub

	#End Region


End Class
