Imports System.Data
Imports System.Data.SqlClient

Namespace dbHelper
    Public Class dbConnection
        Dim Conn As New SqlConnection("Data Source=TOBYADNAN\SQLEXPRESS;Initial Catalog=dbQuiz;Integrated Security=True")
            Public Function Open() As SqlConnection
                Conn.Open()
                Return Conn
            End Function
            Public Sub Close()
                Conn.Close()
            End Sub
        End Class
    End Namespace
