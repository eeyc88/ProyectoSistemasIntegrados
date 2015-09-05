Public Class FrmInvBuscarProductoOrden
    Private _codigo As Integer
    Private _nombre As String
    Property codigo()
        Get
            Return Me._codigo
        End Get
        Set(ByVal value)
            Me._codigo = value
        End Set
    End Property
    Property nombre()
        Get
            Return Me._nombre
        End Get
        Set(ByVal value)
            Me._nombre = value
        End Set
    End Property
    Dim DatSetProducto As New DataSet
    Private Sub FrmInvBuscarProductoOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DgvBusqueda.RowCount = 0 Then
            Dim AdaptadorProducto As New OleDb.OleDbDataAdapter( _
            "select TBL_INV_CAB_KARDEX.producto, nombre, existencia_actual, existencia_minima,existencia_maxima " & _
            "from TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX where bodega=" & FrmOrdenPedido.txtbodega.Text & _
            " AND TBL_INV_CAB_KARDEX.producto=TBL_INV_PRODUCTO.codigo and existencia_actual<existencia_minima", conexion)
            AdaptadorProducto.Fill(DatSetProducto, "TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX")
            Me.DgvBusqueda.DataSource = DatSetProducto
            Me.DgvBusqueda.DataMember = "TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX"
        End If
        'For i As Integer = 0 To Me.DgvBusqueda.RowCount - 2
        '    Me.DgvBusqueda.Rows.Remove(Me.DgvBusqueda.CurrentRow)
        'Next
        'Dim AdaptadorProducto As New OleDb.OleDbDataAdapter( _
        '"select TBL_INV_CAB_KARDEX.producto, nombre, existencia_actual, existencia_minima,existencia_maxima " & _
        '"from TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX where bodega=" & FrmOrdenPedido.txtbodega.Text & _
        '" AND TBL_INV_CAB_KARDEX.producto=TBL_INV_PRODUCTO.codigo and existencia_actual<existencia_minima", conexion)
        'AdaptadorProducto.Fill(DatSetProducto, "TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX")
        'Me.DgvBusqueda.DataSource = DatSetProducto
        'Me.DgvBusqueda.DataMember = "TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX"
    End Sub

    Private Sub DgvBusqueda_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvBusqueda.CellClick
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.DgvBusqueda.Item(0, e.RowIndex).Value
            Me.nombre = Me.DgvBusqueda.Item(1, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub TxtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If cmbfiltro.Text = "Código" Then
            DatSetProducto.Tables("TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX").DefaultView.RowFilter = "Convert(producto, System.String) like '%" & Me.TxtFiltro.Text & "%'"
            DgvBusqueda.DataSource = DatSetProducto.Tables("TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                DatSetProducto.Tables("TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX").DefaultView.RowFilter = "nombre like '%" & Me.TxtFiltro.Text & "%'"
                DgvBusqueda.DataSource = DatSetProducto.Tables("TBL_INV_PRODUCTO, TBL_INV_CAB_KARDEX").DefaultView
            End If
        End If
    End Sub

    Private Sub cmbfiltro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbfiltro.SelectedIndexChanged
        TxtFiltro.Text = ""
    End Sub

    Private Sub DgvBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvBusqueda.CellContentClick

    End Sub
End Class