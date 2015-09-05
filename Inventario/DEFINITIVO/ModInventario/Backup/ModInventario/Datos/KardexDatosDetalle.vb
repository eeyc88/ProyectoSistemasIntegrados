Imports System.Data.OleDb
Public Class KardexDatosDetalle
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
    Sub Grabar(ByVal producto As Integer, ByVal bodega As Integer, ByVal linea As Integer, ByVal tipo_movimiento As Integer, ByVal fecha_registro As Date, _
                ByVal cantidad As Integer, ByVal valor_unitario As Double, ByVal valor_total As Double)
        Dim cmd As New OleDbCommand
        cmd.Connection = Conectar.conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try

            cmd.CommandText = "SP_InDetKardex"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@producto", producto)
            cmd.Parameters.AddWithValue("@bodega", bodega)
            cmd.Parameters.AddWithValue("@linea", linea)
            cmd.Parameters.AddWithValue("@tipo_movimiento", tipo_movimiento)
            cmd.Parameters.AddWithValue("@fecha_registro", fecha_registro)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@valor_unitario", valor_unitario)
            cmd.Parameters.AddWithValue("@valor_total", valor_total)
            Try
                cmd.ExecuteNonQuery()
                Console.WriteLine("Detalle de laorden ha sido ingresada ")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd = Nothing

        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
End Class

