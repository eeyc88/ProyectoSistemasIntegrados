Imports System.Data.OleDb
Imports Clases


Public Class frm_Parametros
    Dim obj_cls_marca As Cls_Marca
    Dim obj_cls_grupo As Cls_Grupo
    Dim obj_cls_Subgrupo As Cls_Subgrupo
    Dim obj_cls_ciudad As Cls_Ciudad
    Dim con As OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Public codigo As Integer
    Public dato_eliminar As String = ""
    Public dato_eliminar_zona As String = ""
    Public dato_eliminar_base As String = ""
    Public ultimo_codigo_sub As Integer
    Public bandera_marca As Integer = 0
    Public bandera_grupo As Integer = 0
    Public bandera_zona As Integer = 0

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

    Private Sub btn_buscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarCodigo.Click
        limpiar()
        frmBuscaCodigoMarca.ShowDialog()
        txt_nombre.Enabled = False
        btn_grabarM.Enabled = False
        btn_modificarM.Enabled = True
        btn_eliminarM.Enabled = True
        txt_descripcion.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salirM.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarG.Click
        limpiar()
        Nuevo()
        Me.dgv_subgrupo.DataSource = Nothing
        frm_BuscarCodigoGrupo.ShowDialog()
        SUBGRUPODataSet.Tables("TBL_INV_SUBGRUPO").DefaultView.RowFilter = "(CONVERT(grupo,System.String)) like '" & Me.txt_codigoG.Text & "'"
        dgv_subgrupo.DataSource = SUBGRUPODataSet.Tables("TBL_INV_SUBGRUPO").DefaultView
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "select MAXIMO=ISNULL(MAX(codigo),0)+1 from TBL_INV_SUBGRUPO"
            .Connection = con
        End With
        codigo = cmd.ExecuteScalar
        Me.TBL_INV_SUBGRUPOTableAdapter.Fill(Me.SUBGRUPODataSet.TBL_INV_SUBGRUPO)
        btn_grabar.Enabled = False
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
        dgv_subgrupo.Enabled = False
    End Sub

    Public Sub valida_fila()
        Try
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Consulta_Subgrupo"
                .Parameters.Clear()
                .Parameters.AddWithValue("descripcion", Me.dgv_subgrupo.Item(3, dgv_subgrupo.CurrentCell.RowIndex).Value.ToString)
            End With
            cmd.ExecuteNonQuery()
            Try
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MessageBox.Show("Subgrupo ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
            dr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_subgrupo_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_subgrupo.RowEnter
        SUBGRUPODataSet.Tables("TBL_INV_SUBGRUPO").Columns("codigo").DefaultValue = codigo + ultimo_codigo_sub
        SUBGRUPODataSet.Tables("TBL_INV_SUBGRUPO").Columns("grupo").DefaultValue = txt_codigoG.Text.ToString
        ultimo_codigo_sub = ultimo_codigo_sub + 2
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Public Sub Bloquear()
        txt_descripcion.Enabled = False
        'txt_codigo.Text = ""
        'txt_codigoG.Text = ""
        txt_nombre.Enabled = False
        'txt_codigoC.Text = ""
        txt_nombreC.Enabled = False
        dgv_subgrupo.Enabled = False
        dgv_zona.Enabled = False
    End Sub

    Public Sub Desbloquear()
        txt_descripcion.Enabled = True
        'txt_codigo.Text = ""
        'txt_codigoG.Text = ""
        txt_nombre.Enabled = True
        'txt_codigoC.Text = ""
        txt_nombreC.Enabled = True
        dgv_subgrupo.Enabled = True
        dgv_zona.Enabled = True
    End Sub
    Public Sub limpiar()
        txt_descripcion.Text = ""
        txt_codigo.Text = ""
        txt_codigoG.Text = ""
        txt_nombre.Text = ""
        txt_codigoC.Text = ""
        txt_nombreC.Text = ""
    End Sub

    Public Sub Actualizar_Grid_Zona()
        Try
            Dim DTable As New ZONADataSet.TBL_INV_ZONADataTable
            DTable = CType(ZONADataSet.Tables("TBL_INV_ZONA"),  _
            ZONADataSet.TBL_INV_ZONADataTable)
            Me.TBL_INV_ZONATableAdapter.Update(DTable)
            'MessageBox.Show("Se han actializado los datos")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Grid()
        Try
            Dim DTable As New SUBGRUPODataSet.TBL_INV_SUBGRUPODataTable
            DTable = CType(SUBGRUPODataSet.Tables("TBL_INV_SUBGRUPO"),  _
            SUBGRUPODataSet.TBL_INV_SUBGRUPODataTable)
            Me.TBL_INV_SUBGRUPOTableAdapter.Update(DTable)
            'MessageBox.Show("Se han actializado los datos")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevoM.Click
        limpiar()
        txt_descripcion.Enabled = True
        obj_cls_marca = New Cls_Marca
        If obj_cls_marca._capturaCodigo Then
            txt_codigo.Text = obj_cls_marca.p_codigo
        Else
            MsgBox("Error al consultar código siguiente")
        End If
        btn_grabarM.Enabled = True
        btn_modificarM.Enabled = False
        btn_eliminarM.Enabled = False
    End Sub

    Private Sub btn_grabarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabarM.Click
        If txt_descripcion.Text = "" Then
            MsgBox("Debe ingresar descripción")
            txt_descripcion.Focus()
            Exit Sub
        End If
        Dim res As Integer
        res = MsgBox("¿Está seguro de querer grabar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            If bandera_marca = 0 Then
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_IngMarca"
                        .Parameters.Clear()
                        ' .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                        .Parameters.Add(New OleDbParameter("descripcion", txt_descripcion.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Marca registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar marca" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
            If bandera_marca = 1 Then
                bandera_marca = 0
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_ModMarca"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                        .Parameters.Add(New OleDbParameter("descripcion", txt_descripcion.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Marca modificada con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                Catch ex As Exception
                    MsgBox("Error al tratar de modificar Marca" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
        btn_grabarM.Enabled = False
        txt_descripcion.Enabled = False
    End Sub

    Private Sub frm_Parametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        Nuevo()
        With dgv_subgrupo
            ' alternar color de filas   
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = TBLINVSUBGRUPOBindingSource
        End With
        With dgv_zona
            ' alternar color de filas   
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = TBLINVZONABindingSource
        End With
    End Sub

    Private Sub btn_modificarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificarM.Click
        btn_modificarM.Enabled = False
        btn_eliminarM.Enabled = False
        btn_grabarM.Enabled = True
        txt_descripcion.Enabled = True
        bandera_marca = 1
    End Sub

    Private Sub btn_eliminarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminarM.Click
        Dim res As Integer
        Try
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_MarcaxProducto"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Error no puede eliminar marca porque esta asignada a un producto", MsgBoxStyle.Critical, "Error")
                dr.Close()
            Else
                dr.Close()
                res = MsgBox("¿Esta seguro de querer eliminar Marca?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                If res = vbYes Then
                    Try
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_MARCA WHERE codigo=" & txt_codigo.Text
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Marca eliminada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                        txt_codigo.Text = ""
                    Catch ex As Exception
                        MsgBox("Error al tratar de eliminar marca " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al leer el dr" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_nuevoG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevoG.Click
        limpiar()
        obj_cls_grupo = New Cls_Grupo
        If obj_cls_grupo._capturaCodigo Then
            txt_codigoG.Text = obj_cls_grupo.p_codigo
        Else
            MsgBox("Error al consultar código siguiente")
        End If
        btn_grabar.Enabled = True
        txt_nombre.Enabled = True
        txt_nombre.Text = ""
        Me.dgv_subgrupo.DataSource = Nothing
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub dgv_subgrupo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_subgrupo.CellContentClick
        Dim DTable1 As New SUBGRUPODataSet.TBL_INV_SUBGRUPODataTable
        If dgv_subgrupo.Columns(e.ColumnIndex).Name = "EliminarSubgrupo" Then
            dato_eliminar = Me.dgv_subgrupo.Rows(Me.dgv_subgrupo.CurrentRow.Index).Cells(0).Value.ToString
            Try
                With cmd
                    .Connection = con
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Cons_SubgrupoxProducto"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", dato_eliminar))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("Error no puede eliminar subgrupo porque esta asignado a un producto", MsgBoxStyle.Critical, "Error")
                    dr.Close()
                Else
                    dr.Close()
                    Dim res As Integer
                    res = MsgBox("¿Esta seguro de querer eliminar SubGrupo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If res = vbYes Then
                        dgv_subgrupo.Rows.RemoveAt(e.RowIndex)
                        Try
                            With cmd
                                .Connection = con
                                .CommandType = CommandType.Text
                                .CommandText = "DELETE FROM TBL_INV_SUBGRUPO WHERE codigo=" & dato_eliminar.ToString
                            End With
                            cmd.ExecuteNonQuery()
                            limpiar()
                            MsgBox("Subgrupo eliminado con éxito", MsgBoxStyle.Information, "Mensaje")
                            Me.dgv_subgrupo.DataSource = Nothing
                        Catch ex As Exception
                            MsgBox("Error al tratar de eliminar Subgrupo " & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error al leer el dr" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        If txt_nombre.Text = "" Then
            MsgBox("Debe ingresar nombre")
            txt_nombre.Focus()
            Exit Sub
        End If
        valida_fila()
        Dim res As Integer
        res = MsgBox("¿Está seguro de querer grabar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            If bandera_grupo = 0 Then
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_IngGrupo"
                        .Parameters.Clear()
                        '.Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
                        .Parameters.Add(New OleDbParameter("descripcion", txt_nombre.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Grupo registrado con éxito", MsgBoxStyle.Information, "Mensaje")
                    Actualizar_Grid()
                    limpiar()
                    Me.dgv_subgrupo.DataSource = Nothing
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar grupo" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                bandera_grupo = 0
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_ModGrupo"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("codigo", txt_codigoG.Text))
                        .Parameters.Add(New OleDbParameter("descripcion", txt_nombre.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    Actualizar_Grid()
                    MsgBox("Grupo modificado con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                    Me.dgv_subgrupo.DataSource = Nothing
                Catch ex As Exception
                    MsgBox("Error al tratar de modificar Grupo" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                Try
                    Me.Validate()
                    Me.TBLINVSUBGRUPOBindingSource.EndEdit()
                    Me.TBL_INV_SUBGRUPOTableAdapter.Update(Me.SUBGRUPODataSet.TBL_INV_SUBGRUPO)
                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        End If
        dgv_subgrupo.Enabled = False
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_subgrupo.Text <> "" Then
            Me.dgv_subgrupo.Rows.Add(Me.txt_subgrupo.Text)
        Else
            MsgBox("Ingrese SubGrupo", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        btn_eliminar.Enabled = False
        btn_grabar.Enabled = True
        dgv_subgrupo.Enabled = True
        btn_modificar.Enabled = False
        txt_nombre.Enabled = True
        bandera_grupo = 1
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim res As Integer
        Try
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_GrupoxProducto"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txt_codigoG.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Error no puede eliminar grupo porque esta asignado a un producto", MsgBoxStyle.Critical, "Error")
                dr.Close()
            Else
                dr.Close()
                res = MsgBox("¿Está seguro de querer eliminar grupo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                If res = vbYes Then
                    Try
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_SUBGRUPO WHERE grupo=" & txt_codigoG.Text
                        End With
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                    Try
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_GRUPO WHERE codigo=" & txt_codigoG.Text
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Grupo eliminado con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                        Me.dgv_subgrupo.DataSource = Nothing
                    Catch ex As Exception
                        MsgBox("Error al tratar de eliminar grupo " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al leer el dr" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_buscarCiudad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarCiudad.Click
        limpiar()
        Me.dgv_zona.DataSource = Nothing
        frm_BuscarCodigoCiudad.ShowDialog()
        ZONADataSet.Tables("TBL_INV_ZONA").DefaultView.RowFilter = "(CONVERT(ciudad,System.String)) like '" & Me.txt_codigoC.Text & "'"
        dgv_zona.DataSource = ZONADataSet.Tables("TBL_INV_ZONA").DefaultView
        ZONADataSet.Tables("TBL_INV_ZONA").Columns("ciudad").DefaultValue = txt_codigoC.Text.ToString
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Inv_Zona' Puede moverla o quitarla según sea necesario.
        Me.TBL_INV_ZONATableAdapter.Fill(Me.ZONADataSet.TBL_INV_ZONA)
        txt_nombreC.Enabled = False
        dgv_zona.Enabled = False
        btn_grabarC.Enabled = False
        btn_modificarC.Enabled = True
        btn_eliminarC.Enabled = True
    End Sub

    Private Sub btn_nuevoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevoC.Click
        btn_grabarC.Enabled = True
        obj_cls_ciudad = New Cls_Ciudad
        If obj_cls_ciudad._capturaCodigo Then
            txt_codigoC.Text = obj_cls_ciudad.p_codigo
        Else
            MsgBox("Error al consultar código siguiente")
        End If
        txt_nombreC.Text = ""
        txt_nombreC.Enabled = True
        'para liberar datos o recursos
        Me.dgv_zona.DataSource = Nothing
        btn_grabarC.Enabled = True
        btn_modificarC.Enabled = False
        btn_eliminarC.Enabled = False
    End Sub

    Private Sub btn_salirC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salirC.Click
        Me.Close()
    End Sub

    Private Sub btn_grabarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabarC.Click
        If txt_nombreC.Text = "" Then
            MsgBox("Debe ingresar nombre")
            txt_nombreC.Focus()
            Exit Sub
        End If
        Dim res As Integer
        res = MsgBox("¿Está seguro de querer grabar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            If bandera_zona = 0 Then
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_IngCiudad"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("nombre", txt_nombreC.Text))
                    End With
                    Actualizar_Grid_Zona()
                    cmd.ExecuteNonQuery()
                    MsgBox("Ciudad registrada con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                    'para liberar datos o recursos
                    Me.dgv_zona.DataSource = Nothing
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar ciudad" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                bandera_zona = 0
                Try
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_ModCiudad"
                        .Parameters.Clear()
                        .Parameters.Add(New OleDbParameter("codigo", txt_codigoC.Text))
                        .Parameters.Add(New OleDbParameter("nombre", txt_nombreC.Text))
                    End With
                    Actualizar_Grid_Zona()
                    cmd.ExecuteNonQuery()
                    MsgBox("Ciudad modificada con éxito", MsgBoxStyle.Information, "Mensaje")
                    limpiar()
                    Me.dgv_zona.DataSource = Nothing
                Catch ex As Exception
                    MsgBox("Error al tratar de modificar Grupo" & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                Try
                    Me.Validate()
                    Me.TBLINVZONABindingSource.EndEdit()
                    Me.TBL_INV_ZONATableAdapter.Update(Me.ZONADataSet.TBL_INV_ZONA)
                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        End If
        btn_grabarC.Enabled = False
    End Sub

    Private Sub dgv_zona_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_zona.CellContentClick
        Dim DTable2 As New InventarioDataSet.Inv_ZonaDataTable
        If dgv_zona.Columns(e.ColumnIndex).Name = "EliminarZona" Then
            dato_eliminar_zona = Me.dgv_zona.Rows(Me.dgv_zona.CurrentRow.Index).Cells(0).Value.ToString
            Try
                With cmd
                    .Connection = con
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Cons_ZonaCiudadxDireccion"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("codigo", dato_eliminar_zona))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("Error no puede eliminar zona porque esta asignada a una dirección", MsgBoxStyle.Critical, "Error")
                    dr.Close()
                Else
                    dr.Close()
                    Dim res As Integer
                    res = MsgBox("¿Está seguro de querer eliminar zona?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If res = vbYes Then
                        dgv_zona.Rows.RemoveAt(e.RowIndex)
                        Try
                            With cmd
                                .Connection = con
                                .CommandType = CommandType.Text
                                .CommandText = "DELETE FROM TBL_INV_ZONA WHERE codigo=" & dato_eliminar_zona
                            End With
                            cmd.ExecuteNonQuery()
                            MsgBox("Zona eliminada con éxito", MsgBoxStyle.Information, "Mensaje")
                        Catch ex As Exception
                            MsgBox("Error al tratar de eliminar Zona" & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error al leer dr" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_modificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificarC.Click
        bandera_zona = 1
        txt_nombreC.Enabled = True
        dgv_zona.Enabled = True
        btn_grabarC.Enabled = True
        btn_modificarC.Enabled = False
        btn_eliminarC.Enabled = False
    End Sub

    Private Sub btn_eliminarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminarC.Click
        Try
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_CiudadxZona"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txt_codigoC.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Error no puede eliminar ciudad porque tiene zonas asignadas", MsgBoxStyle.Critical, "Error")
                dr.Close()
            Else
                dr.Close()
                Dim res As Integer
                res = MsgBox("¿Está seguro de querer eliminar ciudad?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                If res = vbYes Then
                    Try
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_ZONA WHERE ciudad=" & txt_codigoC.Text
                        End With
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                    Try
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM TBL_INV_CIUDAD WHERE codigo=" & txt_codigoC.Text
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Ciudad eliminada con éxito", MsgBoxStyle.Information, "Mensaje")
                        limpiar()
                        Me.dgv_zona.DataSource = Nothing
                        txt_codigo.Text = ""
                    Catch ex As Exception
                        MsgBox("Error al tratar de eliminar ciudad " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al leer dr" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class