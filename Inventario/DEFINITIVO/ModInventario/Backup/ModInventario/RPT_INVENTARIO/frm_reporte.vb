Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_reporte
    Public estado As Integer = 0
    Public cmd As New OleDbCommand
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
    Private Sub btn_buscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_BuscarBodega.ShowDialog()
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frm_reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        Nuevo()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
        Desconectar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_BuscarCodigoGrupo.ShowDialog()
    End Sub

    Private Sub btnBuscarSubgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_buscacodigosubgrupo.ShowDialog()
    End Sub

    Private Sub ckb_general_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_general.CheckedChanged
        If ckb_general.Checked = True Then
            rdbBodega.Checked = False
            rdbClasificacion.Checked = False
            rdbEstado.Checked = False
            ckb_filtrar.Checked = False
            gpb_general.Enabled = True
            gpb_clasificacion.Enabled = False
        End If
    End Sub

    Private Sub ckb_filtrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_filtrar.CheckedChanged
        If ckb_filtrar.Checked = True Then
            ckb_general.Checked = False
            rdbMovimientos.Checked = False
            rdbProducto.Checked = False
            gpb_general.Enabled = False
            gpb_estado.Enabled = True
            gpb_clasificacion.Enabled = True
            gpbBodega.Enabled = True
        End If
    End Sub

    Private Sub ListasAgregar(ByVal texto As String, ByVal lista As ListBox, ByVal criterio As String)
        Dim contador As Integer
        Dim Repetido As Boolean
        With lista
            If Lstbodega.Items.Count = 0 Then
                Lstbodega.Items.Add(texto)
            Else
                contador = 0
                Repetido = False
                Do While (contador < Lstbodega.Items.Count And Not Repetido)
                    If Lstbodega.Items(contador) = texto Then
                        MsgBox("Ya ingreso esta bodega" & criterio, MsgBoxStyle.OkOnly, "Sistema")
                        Repetido = True
                    End If
                    contador = contador + 1
                Loop
                If Not Repetido Then
                    Lstbodega.Items.Add(texto)
                End If
            End If
            .Enabled = True
        End With
    End Sub

    Private Sub ListasAgregarSubgrupo(ByVal texto As String, ByVal lista As ListBox, ByVal criterio As String)
        Dim contador As Integer
        Dim Repetido As Boolean
        With lista
            If lstSubgrupo.Items.Count = 0 Then
                lstSubgrupo.Items.Add(texto)
            Else
                contador = 0
                Repetido = False
                Do While (contador < lstSubgrupo.Items.Count And Not Repetido)
                    If lstSubgrupo.Items(contador) = texto Then
                        MsgBox("Ya ingreso esta Subgrupo" & criterio, MsgBoxStyle.OkOnly, "Sistema")
                        Repetido = True
                    End If
                    contador = contador + 1
                Loop
                If Not Repetido Then
                    lstSubgrupo.Items.Add(texto)
                End If
            End If
            .Enabled = True
        End With
    End Sub

    Private Sub BtnAddBod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddBod.Click
        Frm_BuscarBodega.ShowDialog()
        ListasAgregar(Frm_BuscarBodega.nombre, Lstbodega, "a bodega")
        BtnQuitBod.Enabled = True
    End Sub

    Private Sub BtnQuitBod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitBod.Click
        If Not Lstbodega.SelectedIndex <= -1 Then
            Lstbodega.Items.RemoveAt(Lstbodega.SelectedIndex)
        End If
    End Sub

    Private Sub rdbClasificacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbClasificacion.CheckedChanged
        If rdbClasificacion.Checked = True Then
            btn_BuscarGrupo.Enabled = True
            gpb_clasificacion.Enabled = True
            gpb_estado.Enabled = False
            gpbBodega.Enabled = False
        End If
    End Sub

    Private Sub rdbEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEstado.CheckedChanged
        If rdbEstado.Checked = True Then
            chbActivo.Enabled = True
            gpb_clasificacion.Enabled = False
            gpb_estado.Enabled = True
            gpbBodega.Enabled = False
        End If
    End Sub

    Private Sub rdbBodega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBodega.CheckedChanged
        If rdbBodega.Checked = True Then
            BtnAddBod.Enabled = True
            gpbBodega.Enabled = True
            gpb_clasificacion.Enabled = False
            gpb_estado.Enabled = False
        End If
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        If rdbProducto.Checked = True Then
            Try
                Using DS_ProductoGeneral As New DS_ProductoGeneral()
                    Using daProductoGeneral As New OleDb.OleDbDataAdapter("INV_RPT_PRODUCTOS", cs)
                        conectarse()
                        daProductoGeneral.Fill(DS_ProductoGeneral, "dt_ProductoGeneral")
                        Using rptProductoGeneral As New crProductoGeneral()
                            rptProductoGeneral.SetDataSource(DS_ProductoGeneral)
                            Using frmContenedorReporte As New frmContenedorReporte()
                                frmContenedorReporte.crv_VisorReporte.ReportSource = rptProductoGeneral
                                frmContenedorReporte.ShowDialog()
                            End Using
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If

        If rdbMovimientos.Checked = True Then
            Dim daMovimientos As OleDbDataAdapter
            Dim dtMovimientos As New System.Data.DataTable
            Dim objMovimiento As New ReportDocument
            Try
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.Text
                    .CommandText = "select * from vst_MOVIMIENTOS"
                    daMovimientos = New OleDbDataAdapter(cmd)
                    daMovimientos.Fill(dtMovimientos)
                    Dim cr As New crMovientos
                    cr.SetDataSource(dtMovimientos)
                    Dim frm As New frmContenedorReporte
                    frm.crv_VisorReporte.ReportSource = cr
                    frm.ShowDialog()
                End With
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If

        If rdbBodega.Checked = True Then
            Dim daBodega As OleDbDataAdapter
            Dim dtBodega As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                For i As Integer = 0 To Lstbodega.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "RPT_INV_PRODUCTOXBODEGA"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("nombre", Lstbodega.Items(cuenta))
                    End With
                    daBodega = New OleDbDataAdapter(cmd)
                    daBodega.Fill(dtBodega)
                    cuenta = cuenta + 1
                Next
                Dim cr As New crProductoxBodega
                cr.SetDataSource(dtBodega)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If
        If rdbEstado.Checked = True Then
            Dim daProductoActivo As OleDbDataAdapter
            Dim dtProductoActivo As New System.Data.DataTable
            If chbActivo.Checked = True Then
                Try
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "RPT_INV_PRODUCTOSACTIVOS"
                        daProductoActivo = New OleDbDataAdapter(cmd)
                        daProductoActivo.Fill(dtProductoActivo)
                        Dim cr As New crProductoActivo
                        cr.SetDataSource(dtProductoActivo)
                        Dim frm As New frmContenedorReporte
                        frm.crv_VisorReporte.ReportSource = cr
                        frm.ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Error" & ex.Message)
                End Try
            Else
                Try
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "RPT_INV_PRODUCTOSINACTIVOS"
                        daProductoActivo = New OleDbDataAdapter(cmd)
                        daProductoActivo.Fill(dtProductoActivo)
                        Dim cr As New crProductosInactivos
                        cr.SetDataSource(dtProductoActivo)
                        Dim frm As New frmContenedorReporte
                        frm.crv_VisorReporte.ReportSource = cr
                        frm.ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Error" & ex.Message)
                End Try
            End If
        End If
        If rdbClasificacion.Checked = True Then
            Dim daClasificacion As OleDbDataAdapter
            Dim dtClasificacion As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                For i As Integer = 0 To lstSubgrupo.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "RPT_INV_PRODUCTOSXGRUPO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("grupo", txt_nombregrupo.Text)
                        .Parameters.AddWithValue("subgrupo", lstSubgrupo.Items(cuenta))
                    End With
                    daClasificacion = New OleDbDataAdapter(cmd)
                    daClasificacion.Fill(dtClasificacion)
                    cuenta = cuenta + 1
                Next
                Dim cr As New crGrupoSubgrupo
                cr.SetDataSource(dtClasificacion)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If
        Lstbodega.Items.Clear()
        lstSubgrupo.Items.Clear()
        txt_codigogrupo.Text = ""
        txt_nombregrupo.Text = ""
    End Sub

    Private Sub btn_BuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarGrupo.Click
        frm_BuscarCodigoGrupo.ShowDialog()
        btnAddSubgrupo.Enabled = True
    End Sub

    Private Sub btnAddSubgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubgrupo.Click
        frm_buscacodigosubgrupo.ShowDialog()
        ListasAgregarSubgrupo(frm_buscacodigosubgrupo.nombre, lstSubgrupo, "a la lista")
        btnQuitSubgrupo.Enabled = True
    End Sub

    Private Sub btnQuitSubgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitSubgrupo.Click
        If Not lstSubgrupo.SelectedIndex <= -1 Then
            lstSubgrupo.Items.RemoveAt(lstSubgrupo.SelectedIndex)
        End If
    End Sub
End Class