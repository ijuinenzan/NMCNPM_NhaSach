Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DataAccessHelper
	#Region "ConnectionString"

	Public Shared ReadOnly Property ConnectionString() As String
		Get
			Return "Server=localhost;User Id=root;Password=3725141531;Database=quanlynhasach"
		End Get
	End Property


	#End Region
	#Region "ExecuteQuery"

	Public Shared Function ExecuteQuery(spName As String, Optional parameters As List(Of MySqlParameter) = Nothing) As DataTable
		Dim dt = New DataTable()
		Try
			Dim connect = New MySqlConnection(ConnectionString)
			connect.Open()
			Try
				Dim command As MySqlCommand = connect.CreateCommand()
				command.CommandType = CommandType.StoredProcedure
				command.CommandText = spName

				If parameters IsNot Nothing Then
					For Each parameter In parameters
						command.Parameters.Add(parameter)
					Next
				End If

				Dim adapter As New MySqlDataAdapter()
				adapter.SelectCommand = command
					'var ds = new DataSet();
					'ds.Reset();
					'var adapter = new SQLiteDataAdapter(query, connect);
					'adapter.Fill(ds);
					'dt = ds.Tables[0];
				adapter.Fill(dt)

			Catch ex As Exception
				Throw ex
			Finally
				connect.Close()
			End Try

		Catch ex As Exception
			Throw ex
		End Try

		Return dt
	End Function

	#End Region
	#Region "ExecuteNonQuery"

	Public Shared Function ExecuteNonQuery(spName As String, Optional parameters As List(Of MySqlParameter) = Nothing) As Integer
		Dim n As Integer
		Try
			Dim connect = New MySqlConnection(ConnectionString)
			connect.Open()
			Try
				Dim command As MySqlCommand = connect.CreateCommand()
				command.CommandType = CommandType.StoredProcedure
				command.CommandText = spName

				If parameters IsNot Nothing Then
					For Each parameter As MySqlParameter In parameters
						command.Parameters.Add(parameter)
					Next
				End If

				'var command = connect.CreateCommand();
				'command.CommandText = query;
				n = command.ExecuteNonQuery()

			Catch ex As SqlException
				Throw ex
			Finally
				connect.Close()
			End Try
		Catch ex As Exception
			Throw ex
		End Try

		Return n
	End Function

	#End Region
End Class
