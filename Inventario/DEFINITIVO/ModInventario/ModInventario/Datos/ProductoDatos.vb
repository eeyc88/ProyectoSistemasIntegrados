Imports System.Data.OleDb
Public Class ProductoDatos
    Sub New()
        Try
            Conectar.conexion.ConnectionString = cs
            Conectar.conexion.Open()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
    Sub Desconectar()
        Try
            Conectar.conexion.Close()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
    Sub Grabar(ByVal nombre As String, ByVal grupo As Integer, ByVal subgrupo As Integer, _
                ByVal marca As Integer, ByVal presentacion As String, ByVal observacion As String, _
                ByVal iva As Boolean, ByVal estado As Boolean)
        Dim cmd As New OleDbCommand
        cmd.Connection = Conectar.conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try

            cmd.CommandText = "SP_IngProducto"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@grupo", grupo)
            cmd.Parameters.AddWithValue("@subgrupo", subgrupo)
            cmd.Parameters.AddWithValue("@marca", marca)
            cmd.Parameters.AddWithValue("@presentacion", presentacion)
            cmd.Parameters.AddWithValue("@observacion", observacion)
            cmd.Parameters.AddWithValue("@iva", iva)
            cmd.Parameters.AddWithValue("@estado", estado)
            Try
                cmd.ExecuteNonQuery()
                Console.WriteLine("Producto ha sido ingresado")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd = Nothing

        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
    Sub Modificar(ByVal nombre As String, ByVal grupo As Integer, ByVal subgrupo As Integer, _
                ByVal marca As Integer, ByVal presentacion As String, ByVal observacion As String, _
                ByVal iva As Boolean, ByVal estado As Boolean)

        Dim cmd As New OleDbCommand
        cmd.Connection = Conectar.conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cmd.CommandText = "SP_ModProducto"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@grupo", grupo)
            cmd.Parameters.AddWithValue("@subgrupo", subgrupo)
            cmd.Parameters.AddWithValue("@marca", marca)
            cmd.Parameters.AddWithValue("@presentacion", presentacion)
            cmd.Parameters.AddWithValue("@observacion", observacion)
            cmd.Parameters.AddWithValue("@iva", iva)
            cmd.Parameters.AddWithValue("@estado", estado)
            Try
                cmd.ExecuteNonQuery()
                Console.WriteLine("Producto ha sido ingresado")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd = Nothing

        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
End Class
