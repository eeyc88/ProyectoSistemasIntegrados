Imports System.Data.OleDb

Public Class Cls_Coneccion
#Region "Atributos de la clase"
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim obj_cn As New OleDbConnection 'declaro mi objeto conexion
#End Region


#Region "Metodos de la clase"
    Public Function _conexion() As OleDbConnection
        Try
            obj_cn.ConnectionString = "Provider=SQLOLEDB;Data Source=INGRID-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Inventario"
            Return obj_cn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
End Class
