Imports System.Data.OleDb
Public Class Frm_BuscarCodigoProducto
    Private _codigo As Integer
    Private _descipcion As String
    Property codigo()
        Get
            Return Me._codigo
        End Get
        Set(ByVal value)
            Me._codigo = value
        End Set
    End Property
    Property descipcion()
        Get
            Return Me._descipcion
        End Get
        Set(ByVal value)
            Me._descipcion = value
        End Set
    End Property
    Dim DatasetProducto As New DataSet
    Private Sub Frm_BuscarCodigoProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Me.dgv_producto.RowCount - 1
            Me.dgv_producto.Rows.Remove(Me.dgv_producto.CurrentRow)
        Next
        Dim AdaptadorProducto As New OleDb.OleDbDataAdapter("select codigo, nombre, grupo, presentacion, observacion, iva, estado from TBL_INV_PRODUCTO", cs)
        AdaptadorProducto.Fill(DatasetProducto, "TBL_INV_PRODUCTO")
        Me.dgv_producto.DataSource = DatasetProducto
        Me.dgv_producto.DataMember = "TBL_INV_PRODUCTO"
    End Sub
    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "Código" Then
            DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_producto.DataSource = DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView.RowFilter = "nombre like '%" & Me.txt_filtro.Text & "%'"
                dgv_producto.DataSource = DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView
            End If
        End If
        If cmbfiltro.Text = "Presentación" Then
            DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView.RowFilter = "presentacion like '%" & Me.txt_filtro.Text & "%'"
            dgv_producto.DataSource = DatasetProducto.Tables("TBL_INV_PRODUCTO").DefaultView
        End If
    End Sub

    Private Sub dgv_producto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_producto.CellClick
        Dim iva_p As String
        Dim est_p As Integer
        frm_Producto.txt_codigo.Text = Me.dgv_producto.Item(0, dgv_producto.CurrentCell.RowIndex).Value
        frm_Producto.txt_nombre.Text = Me.dgv_producto.Item(1, dgv_producto.CurrentCell.RowIndex).Value
        '   frm_Producto.txt_codigogrupo.Text = Me.dgv_producto.Item(2, dgv_producto.CurrentCell.RowIndex).Value
        '   frm_Producto.txt_codigosubgrupo.Text = Me.dgv_producto.Item(3, dgv_producto.CurrentCell.RowIndex).Value
        '   frm_Producto.txt_codigomarca.Text = Me.dgv_producto.Item(4, dgv_producto.CurrentCell.RowIndex).Value
        frm_Producto.txt_presentacion.Text = Me.dgv_producto.Item(3, dgv_producto.CurrentCell.RowIndex).Value
        frm_Producto.txt_observacion.Text = Me.dgv_producto.Item(4, dgv_producto.CurrentCell.RowIndex).Value
        iva_p = Me.dgv_producto.Item(5, dgv_producto.CurrentCell.RowIndex).Value
        est_p = Me.dgv_producto.Item(6, dgv_producto.CurrentCell.RowIndex).Value
        If iva_p = "si" Then
            frm_Producto.ckb_iva.Checked = True
        Else
            frm_Producto.ckb_iva.Checked = False
        End If
        If est_p = 1 Then
            frm_Producto.ckb_estado.Checked = True
        Else
            frm_Producto.ckb_estado.Checked = False
        End If
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_producto.Item(0, e.RowIndex).Value
            Me.descipcion = Me.dgv_producto.Item(1, e.RowIndex).Value
            Me.Close()
        End If
    End Sub
End Class