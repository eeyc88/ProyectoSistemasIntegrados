Public Class Frm_BuscarBodega
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
    Dim DataSetBodega As New DataSet
    Private Sub Frm_BuscarBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Me.DgvBusqueda.RowCount - 1
            Me.DgvBusqueda.Rows.Remove(Me.DgvBusqueda.CurrentRow)
        Next
        Dim AdaptadorBodega As New OleDb.OleDbDataAdapter("select codigo, nombre from TBL_INV_BODEGA", cs)
        AdaptadorBodega.Fill(DataSetBodega, "TBL_INV_BODEGA")
        Me.DgvBusqueda.DataSource = DataSetBodega
        Me.DgvBusqueda.DataMember = "TBL_INV_BODEGA"
    End Sub
    Private Sub DgvBusqueda_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvBusqueda.CellClick
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.DgvBusqueda.Item(0, e.RowIndex).Value
            Me.nombre = Me.DgvBusqueda.Item(1, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
            Me.Close()
        End If
    End Sub
    Private Sub TxtFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If CmbFiltro.Text = "Código" Then
            DataSetBodega.Tables("TBL_INV_BODEGA").DefaultView.RowFilter = "Convert(codigo, System.String) like '%" & Me.TxtFiltro.Text & "%'"
            DgvBusqueda.DataSource = DataSetBodega.Tables("TBL_INV_BODEGA").DefaultView
        Else
            If CmbFiltro.Text = "Nombre" Then
                DataSetBodega.Tables("TBL_INV_BODEGA").DefaultView.RowFilter = "nombre like '%" & Me.TxtFiltro.Text & "%'"
                DgvBusqueda.DataSource = DataSetBodega.Tables("TBL_INV_BODEGA").DefaultView
            End If
        End If
    End Sub
    Private Sub CmbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfiltro.SelectedIndexChanged
        TxtFiltro.Text = ""
    End Sub
End Class