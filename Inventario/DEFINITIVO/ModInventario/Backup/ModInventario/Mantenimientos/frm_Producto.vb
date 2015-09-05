Imports System.Data.OleDb
Imports Clases

Public Class frm_Producto
    Dim obj_cls_producto As Cls_Producto
    ' Dim con As OleDbConnection
    Dim cmdmarca As OleDbCommand
    Dim cmd As New OleDbCommand
    Dim cmdgrupo As OleDbCommand
    Dim cmdsubgrupo As OleDbCommand
    'Dim cs As String = "Provider=SQLOLEDB;Data Source=INGRID-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Inventario"
    Public bandera As Integer = 1
    Dim dr As OleDbDataReader
    Dim drmarca As OleDbDataReader
    Dim drgrupo As OleDbDataReader
    Dim drsubgrupo As OleDbDataReader
    Public Sub limpiar()
        txt_codigo.Text = ""
        txt_codigogrupo.Text = ""
        txt_codigomarca.Text = ""
        txt_codigosubgrupo.Text = ""
        txt_nombre.Text = ""
        txt_nombregrupo.Text = ""
        txt_nombremarca.Text = ""
        txt_nombresubgrupo.Text = ""
        txt_observacion.Text = ""
        txt_presentacion.Text = ""
    End Sub
    Public Sub limpiar1()
        txt_codigogrupo.Text = ""
        txt_codigomarca.Text = ""
        txt_codigosubgrupo.Text = ""
        txt_nombre.Text = ""
        txt_nombregrupo.Text = ""
        txt_nombremarca.Text = ""
        txt_nombresubgrupo.Text = ""
        txt_observacion.Text = ""
        txt_presentacion.Text = ""
        ckb_estado.Checked = False
        ckb_iva.Checked = False
    End Sub
    Public Sub desbloquear()
        txt_nombre.Enabled = True
        txt_observacion.Enabled = True
        txt_presentacion.Enabled = True
        ckb_estado.Enabled = True
        ckb_iva.Enabled = True
        btn_BuscarMarca.Enabled = True
        btn_BuscarGrupo.Enabled = True
    End Sub
    Public Sub Bloquear()
        'txt_codigo.Enabled = False
        txt_codigogrupo.Enabled = False
        txt_codigomarca.Enabled = False
        txt_codigosubgrupo.Enabled = False
        txt_nombre.Enabled = False
        txt_nombregrupo.Enabled = False
        txt_nombremarca.Enabled = False
        txt_nombresubgrupo.Enabled = False
        txt_observacion.Enabled = False
        txt_presentacion.Enabled = False
        ckb_estado.Enabled = False
        ckb_iva.Enabled = False
        btn_BuscarMarca.Enabled = False
        btn_BuscarGrupo.Enabled = False
    End Sub
    Private Sub btn_buscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarCodigo.Click
        limpiar1()
        Frm_BuscarCodigoProducto.ShowDialog()
        bandera = 0
        If txt_codigo.Text <> "" Then
            Try
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Cons_Producto"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txt_codigogrupo.Text = dr("grupo")
                    txt_codigosubgrupo.Text = dr("subgrupo")
                    txt_codigomarca.Text = dr("marca")
                    txt_nombregrupo.Text = dr("descripcion")
                    dr.Close()
                End If
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Consulta_Subgrupo"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txt_nombresubgrupo.Text = dr("descripcion")
                    dr.Close()
                End If
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Consulta_Marca"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txt_nombremarca.Text = dr("descripcion")
                    dr.Close()
                End If
            Catch ex As Exception
                dr.Close()
            End Try
        End If
        Bloquear()
        btn_grabar.Enabled = False
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub
    Private Sub btn_BuscarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarMarca.Click
        frmBuscaCodigoMarca.ShowDialog()
    End Sub
    Private Sub btn_BuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarGrupo.Click
        frm_BuscarCodigoGrupo.ShowDialog()
        btn_buscasubgrupo.Enabled = True
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frm_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        conectarse()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Desconectar()
        Me.Close()
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Dim iva_producto As String
        Dim estado_producto As Integer
        btn_grabar.Enabled = False
        Dim res As Integer
        Dim respuesta As Integer
        If bandera = 2 Then
            With cmd
                .Connection = conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_NombreProducto"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("nombre", txt_nombre.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                dr.Close()
                respuesta = MsgBox("¿Producto ya éxiste, desea cambiar estado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                If respuesta = vbYes Then
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SP_ModEstadoProductoNombre"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("nombre", txt_nombre.Text))
                            .Parameters.Add(New OleDbParameter("estado", 1))
                        End With
                        cmd.ExecuteNonQuery()
                        limpiar()
                        Bloquear()
                    Catch ex As Exception
                        MsgBox("Error de Cambio de Estado" & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            Else
                bandera = 1
            End If
        End If

        If bandera = 1 Then
            dr.Close()
            res = MsgBox("¿Está seguro de querer grabar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
            If res = vbYes Then
                Try
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_IngProducto"
                        .Parameters.Clear()
                        '.Parameters.Add(New OleDbParameter("Código", txt_codigo.Text))
                        .Parameters.Add(New OleDbParameter("nombre", txt_nombre.Text))
                        .Parameters.Add(New OleDbParameter("grupo", txt_codigogrupo.Text))
                        .Parameters.Add(New OleDbParameter("subgrupo", txt_codigosubgrupo.Text))
                        .Parameters.Add(New OleDbParameter("marca", txt_codigomarca.Text))
                        .Parameters.Add(New OleDbParameter("presentancion", txt_presentacion.Text))
                        .Parameters.Add(New OleDbParameter("observacion", txt_observacion.Text))
                        If ckb_iva.Checked Then
                            iva_producto = "true"
                        Else
                            iva_producto = "false"
                        End If
                        If ckb_estado.Checked Then
                            estado_producto = 1
                        Else
                            estado_producto = 0
                        End If
                        .Parameters.Add(New OleDbParameter("iva", iva_producto))
                        .Parameters.Add(New OleDbParameter("estado", estado_producto))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto registrado con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                    Bloquear()
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar producto" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
        If bandera = 0 Then
            dr.Close()
            bandera = 1
            Try
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_ModProducto"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                    .Parameters.Add(New OleDbParameter("nombre", txt_nombre.Text))
                    .Parameters.Add(New OleDbParameter("grupo", txt_codigogrupo.Text))
                    .Parameters.Add(New OleDbParameter("subgrupo", txt_codigosubgrupo.Text))
                    .Parameters.Add(New OleDbParameter("marca", txt_codigomarca.Text))
                    .Parameters.Add(New OleDbParameter("presentancion", txt_presentacion.Text))
                    .Parameters.Add(New OleDbParameter("observacion", txt_observacion.Text))
                    If ckb_iva.Checked Then
                        iva_producto = "true"
                    Else
                        iva_producto = "false"
                    End If
                    If ckb_estado.Checked Then
                        estado_producto = 1
                    Else
                        estado_producto = 0
                    End If
                    .Parameters.Add(New OleDbParameter("iva", iva_producto))
                    .Parameters.Add(New OleDbParameter("estado", estado_producto))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Producto modificado con éxito", MsgBoxStyle.Information, "Mensaje")
                limpiar()
                Bloquear()
            Catch ex As Exception
                MsgBox("Error al tratar de modificar producto" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_grabar.Enabled = True
        bandera = 0
        desbloquear()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim res As Integer
        res = MsgBox("¿Está seguro de querer eliminar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            Try
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_ModEstadoProducto"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                    .Parameters.Add(New OleDbParameter("estado", 0))
                End With
                cmd.ExecuteNonQuery()
                limpiar()
                Bloquear()
            Catch ex As Exception
                MsgBox("Error de Cambio de Estado" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            MsgBox("Producto eliminado con éxito", MsgBoxStyle.Information, "Mensaje")
            'Try
            '    With cmd
            '        .Connection = con
            '        .CommandType = CommandType.Text
            '        .CommandText = "DELETE FROM TBL_INV_PRODUCTO WHERE codigo=" & txt_codigo.Text
            '    End With
            '    cmd.ExecuteNonQuery()
            '    MsgBox("Producto ELIMINADO con éxito", MsgBoxStyle.Information, "Mensaje")
            '    limpiar()
            '    Bloquear()
            '    txt_codigo.Text = ""
            'Catch ex As Exception
            '    MsgBox("Error al tratar de eliminar producto" & ex.Message, MsgBoxStyle.Critical, "Error")
            'End Try
        End If
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        limpiar1()
        bandera = 2
        'obj_cls_producto = New Cls_Producto
        'If obj_cls_producto._capturaCodigo Then
        '    txt_codigo.Text = obj_cls_producto.p_codigo
        'Else
        '    MsgBox("Error al consultar código siguiente")
        'End If
        desbloquear()
        btn_grabar.Enabled = True
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub btn_buscasubgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscasubgrupo.Click
        frm_buscacodigosubgrupo.ShowDialog()
    End Sub
End Class