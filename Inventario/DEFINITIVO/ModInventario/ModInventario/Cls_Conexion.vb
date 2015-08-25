Imports System.Data.OleDb

Module Cls_Conexion
    Public con As New OleDbConnection
    'Public cs As String = "Provider=SQLOLEDB;Data Source=INGRID-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Inventario"
    Public cs As String = "Provider=SQLOLEDB;Data Source=.;Integrated Security=SSPI;Initial Catalog=Inventario"
End Module