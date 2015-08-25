Imports System.Data.OleDb
Imports Clases

Public Class frm_Bodega
    Dim obj_cls_bodega As Cls_Bodega
    Dim obj_cls_direccion As Cls_Direccion
    Dim cmd As New OleDbCommand
    Dim zon As New OleDbCommand
    Dim ciu As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim zn As OleDbDataReader
    Dim cd As OleDbDataReader
    Dim bandera As Integer = 0
    Dim grab_mod As Integer = 1
    Dim numero As Integer = 0
    Sub Nuevo()
        Dim cmd As New OleDbCommand
        Try
            conectarse()
            cmd.Connection = conexion
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ciudad.Click
        frm_BuscarCodigoCiudad.ShowDialog()
        gbx_zona.Enabled = True
        btn_zona.Enabled = True
    End Sub
    Public Sub limpiar()
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        'txt_numero.Text = ""
        txt_calle_principal.Text = ""
        txt_calle_transversal.Text = ""
        txt_codigociudad.Text = ""
        txt_descripcion_amplia.Text = ""
        txt_codigociudad.Text = ""
        txt_codigozona.Text = ""
        txt_nombreciudad.Text = ""
        txt_nombrezona.Text = ""
    End Sub
    Public Sub Bloquear()
        txt_nombre.Enabled = False
        txt_calle_principal.Enabled = False
        txt_calle_transversal.Enabled = False
        'txt_codigociudad.Enabled = False
        txt_descripcion_amplia.Enabled = False
        btn_ciudad.Enabled = False
        btn_zona.Enabled = False
    End Sub
    Public Sub Desbloquear()
        txt_nombre.Enabled = True
        txt_calle_principal.Enabled = True
        txt_calle_transversal.Enabled = True
        txt_descripcion_amplia.Enabled = True
        btn_ciudad.Enabled = True
        'btn_zona.Enabled = True
    End Sub
    Private Sub btn_buscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarCodigo.Click
        limpiar()
        Bloquear()
        Frm_BuscarBodega.ShowDialog()
        txt_codigo.Text = Frm_BuscarBodega.codigo
        txt_nombre.Text = Frm_BuscarBodega.nombre
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = True
        btn_modificar.Enabled = True
        If txt_codigo.Text <> "" Then
            Try
                With cmd
                    cmd.Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_ConDireccionBodega"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("bodega", txt_codigo.Text))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    numero = dr("numero")
                    txt_calle_principal.Text = dr("calle_principal")
                    txt_calle_transversal.Text = dr("calle_transversal")
                    txt_descripcion_amplia.Text = dr("descripcion_amplia")
                    txt_codigozona.Text = dr("zona")
                    Try
                        With zon
                            .Connection = conexion
                            .CommandType = CommandType.Text
                            .CommandText = "SELECT ciudad, nombre FROM TBL_INV_ZONA WHERE codigo =" & txt_codigozona.Text
                        End With
                        zn = zon.ExecuteReader
                        If zn.Read Then
                            txt_codigociudad.Text = zn("ciudad")
                            txt_nombrezona.Text = zn("nombre")
                        End If
                    Catch ex As Exception
                        Console.WriteLine("1" & ex.Message)
                    End Try
                    Try
                        With ciu
                            .Connection = conexion
                            .CommandType = CommandType.Text
                            .CommandText = "SELECT nombre FROM TBL_INV_CIUDAD WHERE codigo =" & txt_codigociudad.Text
                        End With
                        cd = ciu.ExecuteReader
                        If cd.Read Then
                            txt_nombreciudad.Text = cd("nombre")
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Else
                    MsgBox("Ubicación no existe")
                    bandera = 1
                End If
                dr.Close()
                zn.Close()
                cd.Close()
            Catch ex As Exception
                Console.WriteLine("Aqui" & ex.Message)
            End Try
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_zona.Click
        frm_BuscarCodigoZona.ShowDialog()
    End Sub
    Private Sub frm_Bodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        btn_buscarCodigo.Enabled = False
        limpiar()
        conectarse()
        If txt_nombreciudad.Text <> "" Then
            gbx_zona.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Desconectar()
        Me.Close()
    End Sub
    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        btn_buscarCodigo.Enabled = True
        btn_grabar.Enabled = True
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        limpiar()
        Desbloquear()
    End Sub
    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        If txt_nombre.Text = "" Then
            MsgBox("Debe ingresar nombre")
            txt_nombre.Focus()
            Exit Sub
        End If
        btn_grabar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        Dim res As Integer
        res = MsgBox("¿Está seguro de querer grabar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            If grab_mod = 1 Then
                'GRABO
                Try
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_IngBodega"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("descripcion", txt_nombre.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Bodega registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar bodega" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                If txt_calle_principal.Text <> "" Then
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SP_IngDireccion"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("bodega", txt_codigo.Text))
                            .Parameters.Add(New OleDbParameter("zona", txt_codigozona.Text))
                            .Parameters.Add(New OleDbParameter("calle_principal", txt_calle_principal.Text))
                            .Parameters.Add(New OleDbParameter("calle_transversal", txt_calle_transversal.Text))
                            .Parameters.Add(New OleDbParameter("descripcion_amplia", txt_descripcion_amplia.Text))
                        End With
                        cmd.ExecuteNonQuery()
                        'MsgBox("Ubicación registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                    Catch ex As Exception
                        MsgBox("Error al tratar de registrar ubicación" & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            Else
                'MODIFICO
                grab_mod = 1
                Try
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_ModBodega"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                        .Parameters.Add(New OleDbParameter("nombre", txt_nombre.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Bodega modificada con éxito", MsgBoxStyle.Information, "Mensaje")
                Catch ex As Exception
                    MsgBox("Error al tratar de modificar bodega" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                If bandera = 1 Then
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SP_IngDireccion"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("bodega", txt_codigo.Text))
                            .Parameters.Add(New OleDbParameter("zona", txt_codigozona.Text))
                            .Parameters.Add(New OleDbParameter("calle_principal", txt_calle_principal.Text))
                            .Parameters.Add(New OleDbParameter("calle_transversal", txt_calle_transversal.Text))
                            .Parameters.Add(New OleDbParameter("descripcion_amplia", txt_descripcion_amplia.Text))
                        End With
                        cmd.ExecuteNonQuery()
                        '   MsgBox("Ubicación registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                    Catch ex As Exception
                        MsgBox("Error al tratar de registrar ubicación" & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                Else
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SP_ModDireccion"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("numero", numero))
                            .Parameters.Add(New OleDbParameter("bodega", txt_codigo.Text))
                            .Parameters.Add(New OleDbParameter("zona", txt_codigozona.Text))
                            .Parameters.Add(New OleDbParameter("calle_principal", txt_calle_principal.Text))
                            .Parameters.Add(New OleDbParameter("calle_transversal", txt_calle_transversal.Text))
                            .Parameters.Add(New OleDbParameter("descripcion_amplia", txt_descripcion_amplia.Text))
                        End With
                        cmd.ExecuteNonQuery()
                        '  MsgBox("Ubicación registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                    Catch ex As Exception
                        MsgBox("Error al tratar de registrar ubicación" & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        End If
        Bloquear()
        btn_buscarCodigo.Enabled = False
    End Sub
    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        grab_mod = 0
        Desbloquear()
        btn_grabar.Enabled = True
        btn_modificar.Enabled = False
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim res As Integer
        Try
            With cmd
                .Connection = conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_BodegaxKardex"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Error no puede eliminar bodega porque tiene productos asignados", MsgBoxStyle.Critical, "Error")
                dr.Close()
                btn_modificar.Enabled = True
            Else
                dr.Close()
                res = MsgBox("¿Está seguro de querer eliminar bodega?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                If res = vbYes Then
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_DIRECCION WHERE bodega=" & txt_codigo.Text
                        End With
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al tratar de eliminar ubicación " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_BODEGA WHERE codigo=" & txt_codigo.Text
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Bodega eliminada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                        txt_codigo.Text = ""
                    Catch ex As Exception
                        MsgBox("Error al tratar de eliminar bodega " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al leer dr" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        btn_grabar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        limpiar()
    End Sub
End Class