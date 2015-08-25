Imports System.Data.OleDb
Public Class OrdenDatosDetalle
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
    Sub Grabar(ByVal numero As Integer, ByVal bodega As Integer, ByVal linea As Integer, _
                ByVal producto As Integer, ByVal cantidad As Integer, ByVal estado As Boolean)
        Dim cmd As New OleDbCommand
        cmd.Connection = Conectar.conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try

            cmd.CommandText = "INV_ING_DET_ORDEN"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numero", numero)
            cmd.Parameters.AddWithValue("@bodega", bodega)
            cmd.Parameters.AddWithValue("@linea", linea)
            cmd.Parameters.AddWithValue("@producto", producto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@estado", estado)
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

