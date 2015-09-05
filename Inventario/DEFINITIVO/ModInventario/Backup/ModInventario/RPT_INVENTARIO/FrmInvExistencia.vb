Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmInvExistencia
    Public cmd As New OleDbCommand
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        Desconectar()
    End Sub
    Private Sub FrmInvExistencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = FrmPrincipal
    End Sub
    Private Sub ListasAgregar(ByVal texto As String, ByVal lista As ListBox, ByVal criterio As String)
        Dim contador As Integer
        Dim Repetido As Boolean
        With lista
            If .Items.Count = 0 Then
                .Items.Add(texto)
            Else
                contador = 0
                Repetido = False
                Do While (contador < .Items.Count And Not Repetido)
                    If .Items(contador) = texto Then
                        MsgBox("Ya ingreso est" & criterio, MsgBoxStyle.OkOnly, "Sistema")
                        Repetido = True
                    End If
                    contador = contador + 1
                Loop
                If Not Repetido Then
                    .Items.Add(texto)
                End If
            End If
            .Enabled = True
        End With
    End Sub
    Private Sub BtnAddBod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddBod.Click
        Frm_BuscarBodega.ShowDialog()
        ListasAgregar(Frm_BuscarBodega.nombre, Lstbodega, "a bodega")
    End Sub
    Private Sub BtnQuitBod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitBod.Click
        If Not Lstbodega.SelectedIndex <= -1 Then
            Lstbodega.Items.RemoveAt(Lstbodega.SelectedIndex)
        End If
    End Sub
    Private Sub BtnAddProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProd.Click
        Frm_BuscarCodigoProducto.ShowDialog()
        ListasAgregar(Frm_BuscarCodigoProducto.descipcion, Lstproducto, "e producto")
    End Sub
    Private Sub BtnAddGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddGrupo.Click
        frm_BuscarCodigoGrupo.ShowDialog()
        ListasAgregar(frm_BuscarCodigoGrupo.nombre, LstGrupo, "e grupo")
    End Sub
    Private Sub BtnQuitProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitProd.Click
        If Not Lstproducto.SelectedIndex <= -1 Then
            Lstproducto.Items.RemoveAt(Lstproducto.SelectedIndex)
        End If
    End Sub
    Private Sub BtnQuitGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitGrupo.Click
        If Not LstGrupo.SelectedIndex <= -1 Then
            LstGrupo.Items.RemoveAt(LstGrupo.SelectedIndex)
        End If
    End Sub
    Private Sub rdbProdGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbProdGen.CheckedChanged
        Lstproducto.Items.Clear()
        RdbGrupEspe.Enabled = True
        RdbBodEspe.Enabled = True
        BtnAddProd.Enabled = False
        BtnQuitProd.Enabled = False
    End Sub
    Private Sub RdbbodGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbbodGen.CheckedChanged
        Lstbodega.Items.Clear()
        RdbGrupEspe.Enabled = True
        RdbProdEspe.Enabled = True
        BtnAddBod.Enabled = False
        BtnQuitBod.Enabled = False
    End Sub
    Private Sub RdbGrupGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbGrupGen.CheckedChanged
        LstGrupo.Items.Clear()
        RdbProdEspe.Enabled = True
        RdbBodEspe.Enabled = True
        BtnAddGrupo.Enabled = False
        BtnQuitGrupo.Enabled = False
    End Sub
    Private Sub RdbProdEspe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbProdEspe.CheckedChanged
        RdbGrupEspe.Enabled = False
        RdbBodEspe.Enabled = False
        BtnAddProd.Enabled = True
        BtnQuitProd.Enabled = True
    End Sub
    Private Sub RdbBodEspe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbBodEspe.CheckedChanged
        RdbGrupEspe.Enabled = False
        RdbProdEspe.Enabled = False
        BtnAddBod.Enabled = True
        BtnQuitBod.Enabled = True
    End Sub
    Private Sub RdbGrupEspe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbGrupEspe.CheckedChanged
        RdbProdEspe.Enabled = False
        RdbBodEspe.Enabled = False
        BtnAddGrupo.Enabled = True
        BtnQuitGrupo.Enabled = True
    End Sub
    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click
        If RdbBodEspe.Checked And Lstbodega.Items.Count = 0 Then
            MsgBox("Debe Especificar Bodegas", MsgBoxStyle.OkOnly, "Sistema")
        ElseIf RdbGrupEspe.Checked And LstGrupo.Items.Count = 0 Then
            MsgBox("Debe Especificar Los Grupos que desea visualizar", MsgBoxStyle.OkOnly, "Sistema")
        ElseIf RdbProdEspe.Checked And Lstproducto.Items.Count = 0 Then
            MsgBox("Debe Especificar Los Productos que desea visualizar", MsgBoxStyle.OkOnly, "Sistema")
        ElseIf RdbTodos.Checked And RdbbodGen.Checked And RdbGrupGen.Checked And rdbProdGen.Checked Then
            Try
                conectarse()
                Using DataSetReporte As New DataSetReporte()
                    Using DATodos As New OleDb.OleDbDataAdapter("INV_RPT_EXISTENCIAS", cs)
                        DATodos.Fill(DataSetReporte, "vst_existencia")
                        Using RptExistencia As New RptExistencia()
                            RptExistencia.SetDataSource(DataSetReporte)
                            Using frmContenedorReporte As New frmContenedorReporte()
                                frmContenedorReporte.crv_VisorReporte.ReportSource = RptExistencia
                                frmContenedorReporte.ShowDialog()
                            End Using
                        End Using
                    End Using
                End Using
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMin.Checked And RdbbodGen.Checked And RdbGrupGen.Checked And rdbProdGen.Checked Then
            Try
                conectarse()
                Using DataSetReporte As New DataSetReporte()
                    Using DAMinimo As New OleDb.OleDbDataAdapter("INV_RPT_BAJOMINIMO", cs)
                        DAMinimo.Fill(DataSetReporte, "vst_existencia")
                        Using Rptminimo As New RptMinimo()
                            Rptminimo.SetDataSource(DataSetReporte)
                            Using frmContenedorReporte As New frmContenedorReporte()
                                frmContenedorReporte.crv_VisorReporte.ReportSource = Rptminimo
                                frmContenedorReporte.ShowDialog()
                            End Using
                        End Using
                    End Using
                End Using
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMax.Checked And RdbbodGen.Checked And RdbGrupGen.Checked And rdbProdGen.Checked Then
            Try
                conectarse()
                Using DataSetReporte As New DataSetReporte()
                    Using DAMaximo As New OleDb.OleDbDataAdapter("INV_RPT_SOBREMAXIMO", cs)
                        DAMaximo.Fill(DataSetReporte, "vst_existencia")
                        Using RptMaXimo As New RptMaXimo()
                            RptMaXimo.SetDataSource(DataSetReporte)
                            Using frmContenedorReporte As New frmContenedorReporte()
                                frmContenedorReporte.crv_VisorReporte.ReportSource = RptMaXimo
                                frmContenedorReporte.ShowDialog()
                            End Using
                        End Using
                    End Using
                End Using
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbTodos.Checked And RdbProdEspe.Checked Then
            Dim DAProducto As OleDbDataAdapter
            Dim DtProducto As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                conectarse()
                For i As Integer = 0 To Lstproducto.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_EXISTENCIAS_PRODUCTO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("producto", Lstproducto.Items(cuenta))
                    End With
                    DAProducto = New OleDbDataAdapter(cmd)
                    DAProducto.Fill(DtProducto)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptExistenciaProducto
                cr.SetDataSource(DtProducto)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbTodos.Checked And RdbBodEspe.Checked Then
            Dim DABodega As OleDbDataAdapter
            Dim DtBodega As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                conectarse()
                For i As Integer = 0 To Lstbodega.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_EXISTENCIAS_BODEGA"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("bodega", Lstbodega.Items(cuenta))
                    End With
                    DABodega = New OleDbDataAdapter(cmd)
                    DABodega.Fill(DtBodega)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptExistenciaBodega
                cr.SetDataSource(DtBodega)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbTodos.Checked And RdbGrupEspe.Checked Then
            Dim DAGrupo As OleDbDataAdapter
            Dim DtGrupo As New System.Data.DataTable
            Try
                conectarse()
                Dim cuenta As Integer = 0
                For i As Integer = 0 To LstGrupo.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_EXISTENCIAS_GRUPO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("grupo", LstGrupo.Items(i).ToString)
                    End With
                    DAGrupo = New OleDbDataAdapter(cmd)
                    DAGrupo.Fill(DtGrupo)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptExistenciasGrupo
                cr.SetDataSource(DtGrupo)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMin.Checked And RdbBodEspe.Checked Then
            Dim DABodega As OleDbDataAdapter
            Dim DtBodega As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                conectarse()
                For i As Integer = 0 To Lstbodega.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_BAJOMINIMO_BODEGA"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("bodega", Lstbodega.Items(cuenta))
                    End With
                    DABodega = New OleDbDataAdapter(cmd)
                    DABodega.Fill(DtBodega)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptMinimoBodega
                cr.SetDataSource(DtBodega)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMin.Checked And RdbGrupEspe.Checked Then
            Dim DAGrupo As OleDbDataAdapter
            Dim DtGrupo As New System.Data.DataTable
            Try
                conectarse()
                Dim cuenta As Integer = 0
                For i As Integer = 0 To LstGrupo.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_BAJOMINIMO_GRUPO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("grupo", LstGrupo.Items(i).ToString)
                    End With
                    DAGrupo = New OleDbDataAdapter(cmd)
                    DAGrupo.Fill(DtGrupo)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptMinimoGrupo
                cr.SetDataSource(DtGrupo)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMin.Checked And RdbProdEspe.Checked Then
            Dim DAProducto As OleDbDataAdapter
            Dim DtProducto As New System.Data.DataTable
            Try
                conectarse()
                Dim i As Integer = 0
                While i < Lstproducto.Items.Count
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_BAJOMINIMO_PRODUCTO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("producto", Lstproducto.Items(i).ToString)
                    End With
                    DAProducto = New OleDbDataAdapter(cmd)
                    DAProducto.Fill(DtProducto)
                    i = i + 1
                End While
                Dim cr As New RptMinimoProducto
                cr.SetDataSource(DtProducto)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMax.Checked And RdbProdEspe.Checked Then
            Dim DAProducto As OleDbDataAdapter
            Dim DtProducto As New System.Data.DataTable
            Try
                conectarse()
                Dim i As Integer = 0
                While i < Lstproducto.Items.Count
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_SOBREMAXIMO_PRODUCTO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("producto", Lstproducto.Items(i).ToString)
                    End With
                    DAProducto = New OleDbDataAdapter(cmd)
                    DAProducto.Fill(DtProducto)
                    i = i + 1
                End While
                Dim cr As New RptMaximoProducto
                cr.SetDataSource(DtProducto)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMax.Checked And RdbGrupEspe.Checked Then
            Dim DAGrupo As OleDbDataAdapter
            Dim DtGrupo As New System.Data.DataTable
            Try
                conectarse()
                Dim cuenta As Integer = 0
                For i As Integer = 0 To LstGrupo.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_SOBREMAXIMO_GRUPO"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("grupo", LstGrupo.Items(i).ToString)
                    End With
                    DAGrupo = New OleDbDataAdapter(cmd)
                    DAGrupo.Fill(DtGrupo)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptMaximoGrupo
                cr.SetDataSource(DtGrupo)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        ElseIf RdbMax.Checked And RdbBodEspe.Checked Then
            Dim DABodega As OleDbDataAdapter
            Dim DtBodega As New System.Data.DataTable
            Dim cuenta As Integer = 0
            Try
                conectarse()
                For i As Integer = 0 To Lstbodega.Items.Count - 1
                    With cmd
                        .Connection = conexion
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INV_RPT_SOBREMAXIMO_BODEGA"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("bodega", Lstbodega.Items(cuenta))
                    End With
                    DABodega = New OleDbDataAdapter(cmd)
                    DABodega.Fill(DtBodega)
                    cuenta = cuenta + 1
                Next
                Dim cr As New RptMAXimoBodega
                cr.SetDataSource(DtBodega)
                Dim frm As New frmContenedorReporte
                frm.crv_VisorReporte.ReportSource = cr
                frm.ShowDialog()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If
    End Sub

End Class