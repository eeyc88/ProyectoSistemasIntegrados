Imports System.Data.OleDb
Public Class OrdenDatosCabecera
    Sub Grabar(ByVal numero As Integer, ByVal bodega As Integer, ByVal responsable As Integer, _
                ByVal fecha_pedido As Date, ByVal fecha_entrega As Date, ByVal observacion As String)
        conectarse()
        Dim cmd As New OleDbCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.StoredProcedure
        Try

            cmd.CommandText = "INV_ING_CAB_ORDEN"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numero", numero)
            cmd.Parameters.AddWithValue("@bodega", bodega)
            cmd.Parameters.AddWithValue("@responsable", responsable)
            cmd.Parameters.AddWithValue("@fecha_pedido", fecha_pedido)
            cmd.Parameters.AddWithValue("@recha_entrega", fecha_entrega)
            cmd.Parameters.AddWithValue("@observacion", observacion)
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
