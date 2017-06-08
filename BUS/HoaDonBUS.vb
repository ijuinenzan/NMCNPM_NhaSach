Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO

Public Class HoaDonBUS
	Public Shared Function GenerateNewMaHoaDon() As String
		Return HoaDonDAO.GenerateNewMaHoaDon()
	End Function
End Class
