Imports System.Data.OleDb

Public Class frm_cons_kardex
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Private Sub frm_cons_kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_producto.Click
        
        Frm_BuscarCodigoProducto.ShowDialog()
        txt_codigo.Text = Frm_BuscarCodigoProducto.dgv_producto.Item(0, Frm_BuscarCodigoProducto.dgv_producto.CurrentCell.RowIndex).Value.ToString
        Try
            conectarse()
            With cmd
                .Connection = conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_CodiProducto"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txt_codigo.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                txt_producto.Text = dr("nombre")
            End If
            dr.Close()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message & "Que paso??? ")
        End Try

    End Sub

    Private Sub btn_bodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bodega.Click
        If txt_producto.Text = String.Empty Then
            MsgBox("Debe elegir un producto", MsgBoxStyle.OkOnly, "Mensaje")
            btn_producto.Focus()
        Else
            Frm_BuscarBodega.ShowDialog()
            Me.txt_bodega.Text = Frm_BuscarBodega.codigo
            Me.txt_descripcion.Text = Frm_BuscarBodega.nombre
            Dim cmd As New OleDbCommand
            Dim dr As OleDbDataReader
            '  DgvDetalle.Columns.Clear()
            Try

                conectarse()
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_Cons_CabKardex"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("bodega", txt_bodega.Text))
                    .Parameters.Add(New OleDbParameter("producto", txt_codigo.Text))
                End With
                dr = cmd.ExecuteReader
                dr.Close()
            Catch ex As Exception
            End Try
        End If
        Desconectar()

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        If CheckBox2.Checked = True Then
            If txt_bodega.Text <> "" And txt_codigo.Text <> "" Then
                Dim daKardex As OleDbDataAdapter
                Dim dtKardex As New System.Data.DataTable
                If CheckBox1.Checked = True Then
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "RPT_INV_KARDEX"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("producto", txt_codigo.Text))
                            .Parameters.Add(New OleDbParameter("bodega", txt_bodega.Text))
                            .Parameters.Add(New OleDbParameter("fecha1", dtp_desde.Text))
                            .Parameters.Add(New OleDbParameter("fecha2", dtp_hasta.Text))
                            daKardex = New OleDbDataAdapter(cmd)
                            daKardex.Fill(dtKardex)
                            'Dim cr As New crKardex
                            'cr.SetDataSource(dtKardex)
                            'Dim frm As New frmContenedorReporte
                            'frm.crv_VisorReporte.ReportSource = cr
                            'frm.ShowDialog()
                        End With
                    Catch ex As Exception
                        MsgBox("Error" & ex.Message)
                    End Try
                Else
                    Try
                        With cmd
                            .Connection = conexion
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "RPT_INV_KARDEX_2"
                            .Parameters.Clear()
                            .Parameters.Add(New OleDbParameter("producto", txt_codigo.Text))
                            .Parameters.Add(New OleDbParameter("bodega", txt_bodega.Text))
                            daKardex = New OleDbDataAdapter(cmd)
                            daKardex.Fill(dtKardex)
                            'Dim cr As New crKardex
                            'cr.SetDataSource(dtKardex)
                            'Dim frm As New frmContenedorReporte
                            'frm.crv_VisorReporte.ReportSource = cr
                            'frm.ShowDialog()
                        End With
                    Catch ex As Exception
                        MsgBox("Error" & ex.Message)
                    End Try
                End If
            End If
        End If
        If CheckBox3.Checked = True Then
            Dim daMonto As OleDbDataAdapter
            Dim dtMonto As New System.Data.DataTable
            Try
                With cmd
                    .Connection = conexion
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "COSTO_INVENTARIO"
                    .Parameters.Clear()
                    .Parameters.Add(New OleDbParameter("bodega", TextBox2.Text))
                    daMonto = New OleDbDataAdapter(cmd)
                    daMonto.Fill(dtMonto)
                    'Dim cr As New crMonto
                    'cr.SetDataSource(dtMonto)
                    'Dim frm As New frmContenedorReporte
                    'frm.crv_VisorReporte.ReportSource = cr
                    'frm.ShowDialog()
                End With
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            grpfecha.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If txt_producto.Text = String.Empty Then
        '    MsgBox("Debe elegir un producto", MsgBoxStyle.OkOnly, "Mensaje")
        '    btn_producto.Focus()
        'Else
        Frm_BuscarBodega.ShowDialog()
        Me.TextBox2.Text = Frm_BuscarBodega.codigo
        Me.TextBox1.Text = Frm_BuscarBodega.nombre
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        '  DgvDetalle.Columns.Clear()
        Try

            conectarse()
            With cmd
                .Connection = conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_CabKardex"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("bodega", txt_bodega.Text))
                .Parameters.Add(New OleDbParameter("producto", txt_codigo.Text))
            End With
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
        End Try
        Desconectar()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            inventario.Enabled = True
            costo.Enabled = False
            CheckBox3.Checked = False
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txt_bodega.Text = ""
            txt_codigo.Text = ""
            txt_descripcion.Text = ""
            txt_producto.Text = ""
            inventario.Enabled = False
            costo.Enabled = True
            CheckBox2.Checked = False
        End If
    End Sub
End Class