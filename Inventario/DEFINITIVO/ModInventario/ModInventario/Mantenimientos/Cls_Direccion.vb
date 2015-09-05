Public Class Cls_Direccion
    Dim obj_cls_conexion As Cls_Coneccion 'referenciar a cls_conexion
    Private codigo As Integer
    Dim obj_cn As OleDb.OleDbConnection
    Dim obj_cmd As OleDb.OleDbCommand

#Region "Propiedades de la clase"
    Public Property p_codigo()
        Get
            Return codigo
        End Get
        Set(ByVal value)
            codigo = value
        End Set
    End Property
#End Region

#Region "Mantenimientos"
    Public Function _capturaCodigo() As Boolean
        Dim cod As Integer
        Try
            obj_cls_conexion = New Cls_Coneccion 'creo mi objeto del tipo cls_conexion
            obj_cn = obj_cls_conexion._conexion()
            If IsNothing(obj_cn) Then
                Return False
            End If
            obj_cn.Open()
            obj_cmd = New OleDb.OleDbCommand
            With obj_cmd
                .CommandType = CommandType.Text
                .CommandText = "select MAXIMO=ISNULL(MAX(numero),0)+1 from TBL_INV_DIRECCION"
                .Connection = obj_cn
            End With
            cod = obj_cmd.ExecuteScalar
            p_codigo = cod
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
