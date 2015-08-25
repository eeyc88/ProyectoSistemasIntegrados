Imports System.Data.OleDb
Public Class KardexDatosCabecera
    Sub Grabar(ByVal bodega As Integer, ByVal producto As Integer, ByVal fecha As Date, _
               ByVal existencia_actual As Integer, ByVal existencia_minima As Integer, ByVal existencia_maxima As Integer, ByVal responsable As Integer)
        conectarse()
        Dim cmd As New OleDbCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cmd.CommandText = "SP_InCabKardex"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@bodega", bodega)
            cmd.Parameters.AddWithValue("@producto", producto)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@existencia_actual", existencia_actual)
            cmd.Parameters.AddWithValue("@existencia_minima", existencia_minima)
            cmd.Parameters.AddWithValue("@existencia_maxima ", existencia_maxima)
            cmd.Parameters.AddWithValue("@responsable", responsable)
            Try
                cmd.ExecuteNonQuery()
                Console.WriteLine("Registro Ingresado")
                Desconectar()
            Catch ex As Exception
                Console.WriteLine("Aquí????" & ex.Message)
            End Try
            cmd = Nothing
        Catch ex As Exception
            Console.WriteLine("Error datos" & ex.Message)
        End Try
    End Sub

End Class
