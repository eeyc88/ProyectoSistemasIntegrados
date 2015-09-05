Imports System.Data.OleDb
Public Class frm_Kardex
    Public bandera As Integer = 1
    Dim grupo As Integer
    Dim subgrupo As Integer
    Private Sub CalculaKardex()
        Try
            With DgvDetalle
                Dim cant As Integer = 0, vunite As Decimal = 0, vtotal As Decimal = 0
                For Each dr As DataGridViewRow In .Rows
                    dr.Cells("totalm").Value = dr.Cells("unitm").Value * dr.Cells("cantm").Value
                    If dr.Cells("detalle").Value = "INGRESO" Then
                        If dr.Cells("cantm").Value > txtmaxima.Text Then
                            MsgBox("Cantidad no debe exceder a la máxima")
                        Else
                            cant += dr.Cells("cantm").Value
                            vtotal += dr.Cells("totalm").Value
                            dr.Cells("unitm").ReadOnly = False
                            vunite = dr.Cells("unite").Value
                        End If
                    Else
                        If dr.Cells("detalle").Value = "EGRESO" Then
                            If txtactual.Text = txtminima.Text Then
                                MsgBox("Ha llegado a su punto de reorden")
                            Else
                                If (dr.Cells("cantm").Value > txtactual.Text) Then
                                    MsgBox("Cantidad debe ser menor a la existencia actual")
                                    dr.Cells("cante").Value = 0
                                    dr.Cells("totale").Value = 0
                                    dr.Cells("unite").Value = 0
                                    Exit Sub
                                Else
                                    dr.Cells("unitm").Value = vunite
                                    dr.Cells("unitm").ReadOnly = True
                                    cant -= dr.Cells("cantm").Value
                                    vtotal -= dr.Cells("totalm").Value
                                End If
                            End If
                        End If
                        End If

                        dr.Cells("cante").Value = cant
                        dr.Cells("totale").Value = vtotal
                        dr.Cells("unite").Value = vtotal / cant

                        txtactual.Text = cant.ToString

                Next
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dvgdetalle_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles DgvDetalle.CellValidating
        ' Validate the CompanyName entry by disallowing empty strings.
        If DgvDetalle.Columns(e.ColumnIndex).Name = "Kardex" Then
            If e.FormattedValue IsNot Nothing AndAlso String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DgvDetalle.Rows(e.RowIndex).ErrorText = "Kardex esta vacio"
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        limpiar()
        txtresponsable.Text = "usuario"
        txtmaxima.Enabled = True
        txtminima.Enabled = True
        btn_grabar.Enabled = True
        BtnCancelar.Enabled = True
        Btnnuevo.Enabled = False
        BtnMas.Enabled = True
        BtnMenos.Enabled = True
        Btnnuevo.Enabled = False
        BtnBuscarBodega.Enabled = True
        BtnBuscarProducto.Enabled = True
    End Sub
    Public Sub limpiar()
        txtresponsable.Text = String.Empty
        txtcodigo.Text = String.Empty
        txtproducto.Text = String.Empty
        txtbodega.Text = String.Empty
        txtdescripcion.Text = String.Empty
        txtgrupo.Text = String.Empty
        txtsubgrupo.Text = String.Empty
        txtmaxima.Text = String.Empty
        txtminima.Text = String.Empty
        txtactual.Text = String.Empty
        DgvDetalle.Rows.Clear()
    End Sub
    Private Sub frm_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        Btnnuevo.Enabled = True
        btnsalir.Enabled = True
        btn_grabar.Enabled = False
        BtnCancelar.Enabled = False
        Me.KeyPreview = True
        lblfecha.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub btnsalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
        Desconectar()
    End Sub
    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Dim flag As Boolean = True
        If String.IsNullOrEmpty(txtresponsable.Text) Then
            MsgBox("Debe Asignar un responsable")
            txtresponsable.Focus()
            flag = False
        ElseIf String.IsNullOrEmpty(txtminima.Text) Or String.IsNullOrEmpty(txtmaxima.Text) Then
            MsgBox("Debe asignar las Cantidades mínimas y Máximas del Producto")
            txtminima.Focus()
            flag = False
        ElseIf String.IsNullOrEmpty(txtdescripcion.Text) Then
            MsgBox("Debe asignar un producto")
            BtnBuscarProducto.Focus()
            flag = False
        ElseIf String.IsNullOrEmpty(txtbodega.Text) Then
            MsgBox("Debe asignar una bodega")
            BtnBuscarBodega.Focus()
            flag = False
        ElseIf DgvDetalle.Rows.Count < 1 Then
            MsgBox("Debe Ingresar el detalle del Kardex")
            BtnMas.Focus()
            flag = False
        End If
        If flag = True Then
            Try
                Dim oKardexCabecera As New KardexCabecera(txtbodega.Text, txtcodigo.Text, Date.Now.ToString("dd/MM/yyyy"), txtactual.Text, txtminima.Text, txtmaxima.Text, 1)
                oKardexCabecera.imprimir()
                oKardexCabecera.Ingresar()
                Dim tipo As Integer = 0

                
                For i As Integer = 0 To DgvDetalle.Rows.Count - 1
                    If DgvDetalle.Rows(i).Cells(1).Value = "INGRESO" Then
                        tipo = 1
                    Else
                        tipo = 2
                    End If
                    Dim oKardexDetalle As New KardexDetalle(txtcodigo.Text, txtbodega.Text, i + 1, tipo, DgvDetalle.Rows(i).Cells("fechak").Value, DgvDetalle.Rows(i).Cells("cantm").Value, DgvDetalle.Rows(i).Cells("unitm").Value, DgvDetalle.Rows(i).Cells("totalm").Value)
                    oKardexDetalle.imprimir()
                    oKardexDetalle.Ingresar()
                Next
                MsgBox("Kardex registrado con Exito", MsgBoxStyle.Information, "Mensaje")
                limpiar()
                btn_grabar.Enabled = False
                BtnCancelar.Enabled = False
                Btnnuevo.Enabled = True
                BtnBuscarProducto.Enabled = False
                BtnBuscarBodega.Enabled = False
                txtminima.Enabled = False
                txtmaxima.Enabled = False
            Catch ex As Exception
                MsgBox("Error al tratar de registrar Producto " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub dvgdetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        'Dim tipo_detalle = DgvDetalle.Item(1, e.RowIndex).Value()
        'Dim cantidad_egreso = DgvDetalle.Item(2, e.RowIndex).Value()
        'If tipo_detalle = "EGRESO" Then

        'End If
        CalculaKardex()
    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label7.Text = Date.Today.Date
    End Sub
    Private Sub txtmaxima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaxima.KeyPress
        'Aqui verificamos si la tecla presionada es una letra si es asi entonces no se tomara o no se mostrara la letra.
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        Else
            'Aqui verifica si se ha presionado alguna tecla de control, puede ser backspace,tabulardor, si es asi lo dejara pasar normal pork puedes borrar.
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                'Aqui verifica si es un separador o espacio en blanco, si es asi no lo dejara pasar.
                If Char.IsSeparator(e.KeyChar) Then
                    e.Handled = True
                Else
                    'Aqui Verifica si la tecla presionada es un número, si es asi normal lo deja pasar.
                    If Char.IsDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtminima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtminima.KeyPress
        'Aqui verificamos si la tecla presionada es una letra si es asi entonces no se tomara o no se mostrara la letra.
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        Else
            'Aqui verifica si se ha presionado alguna tecla de control, puede ser backspace,tabulardor, si es asi lo dejara pasar normal pork puedes borrar.
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                'Aqui verifica si es un separador o espacio en blanco, si es asi no lo dejara pasar.
                If Char.IsSeparator(e.KeyChar) Then
                    e.Handled = True
                Else
                    'Aqui Verifica si la tecla presionada es un número, si es asi normal lo deja pasar.
                    If Char.IsDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim res As Integer
        res = MsgBox("¿Esta seguro que desea cancelar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
        If res = vbYes Then
            btn_grabar.Enabled = False
            BtnCancelar.Enabled = False
            Btnnuevo.Enabled = True
            BtnBuscarProducto.Enabled = False
            BtnBuscarBodega.Enabled = False
            txtminima.Enabled = False
            txtmaxima.Enabled = False
            limpiar()
        End If
    End Sub
    Private Sub BtnBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarProducto.Click
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Frm_BuscarCodigoProducto.ShowDialog()
        txtcodigo.Text = Frm_BuscarCodigoProducto.dgv_producto.Item(0, Frm_BuscarCodigoProducto.dgv_producto.CurrentCell.RowIndex).Value.ToString
        Try
            conectarse()
            With cmd
                .Connection = conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_Cons_CodiProducto"
                .Parameters.Clear()
                .Parameters.Add(New OleDbParameter("codigo", txtcodigo.Text))
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtproducto.Text = dr("nombre")
                grupo = dr("grupo")
                subgrupo = dr("subgrupo")
                txtgrupo.Text = dr("descripcionGrupo")
                txtsubgrupo.Text = dr("descripcionSubGrupo")
            End If
            dr.Close()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message & "Que paso??? ")
        End Try
        'End If
    End Sub
    Private Sub BtnBuscarBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarBodega.Click
        If txtcodigo.Text = String.Empty Then
            MsgBox("Debe elegir un producto", MsgBoxStyle.OkOnly, "Mensaje")
            BtnBuscarProducto.Focus()
        Else
            Frm_BuscarBodega.ShowDialog()
            Me.txtbodega.Text = Frm_BuscarBodega.codigo
            Me.txtdescripcion.Text = Frm_BuscarBodega.nombre
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
                    .Parameters.Add(New OleDbParameter("bodega", txtbodega.Text))
                    .Parameters.Add(New OleDbParameter("producto", txtcodigo.Text))
                End With
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtresponsable.Text = dr("responsable")
                    txtactual.Text = dr("existencia_actual")
                    txtminima.Text = dr("existencia_minima")
                    txtmaxima.Text = dr("existencia_maxima")
                    Dim i As Integer = 0
                    DgvDetalle.Rows.Add()
                    DgvDetalle.Rows(i).Cells("fechak").Value = dr("fecha_registro")
                    If dr("tipo_movimiento") = 1 Then
                        DgvDetalle.Rows(i).Cells("detalle").Value = "INGRESO"
                    Else
                        DgvDetalle.Rows(i).Cells("detalle").Value = "EGRESO"
                    End If
                    DgvDetalle.Rows(i).Cells("cantm").Value = dr("cantidad")
                    DgvDetalle.Rows(i).Cells("unitm").Value = dr("valor_unitario")
                    CalculaKardex()
                    While dr.Read
                        i = i + 1
                        DgvDetalle.Rows.Add()
                        DgvDetalle.Rows(i).Cells("fechak").Value = dr("fecha_registro")
                        If dr("tipo_movimiento") = 1 Then
                            DgvDetalle.Rows(i).Cells("detalle").Value = "INGRESO"
                        Else
                            DgvDetalle.Rows(i).Cells("detalle").Value = "EGRESO"
                        End If
                        DgvDetalle.Rows(i).Cells("cantm").Value = dr("cantidad")
                        DgvDetalle.Rows(i).Cells("unitm").Value = dr("valor_unitario")
                        CalculaKardex()
                    End While
                End If
                dr.Close()
                Desconectar()
            Catch ex As Exception
                MsgBox(ex.Message & "Que paso??? ")
            End Try
        End If
    End Sub
    Private Sub BtnMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMas.Click
        Try
            DgvDetalle.Rows.Add()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Private Sub BtnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenos.Click
        If DgvDetalle.RowCount > 0 And DgvDetalle.SelectedCells.Count > 0 Then
            DgvDetalle.Rows.RemoveAt(DgvDetalle.CurrentCell.RowIndex)
            CalculaKardex()
        End If
    End Sub

    Private Sub DgvDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalle.CellContentClick

    End Sub
End Class


