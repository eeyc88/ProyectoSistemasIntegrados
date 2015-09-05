Imports System.Data.OleDb
Module Conectar
    Public conexion As New OleDbConnection

    'Public cs As String = "Provider=SQLOLEDB;Data Source=.;Integrated Security=SSPI;Initial Catalog=Inventario"
    Public cs As String = "Provider=SQLOLEDB;Data Source=INGRID-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Inventario"

    Sub conectarse()
        Try
            conexion.ConnectionString = cs
            conexion.Open()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.Write("Error" & ex.Message)
        End Try
    End Sub
    Sub Desconectar()
        Try
            conexion.Close()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
End Module
