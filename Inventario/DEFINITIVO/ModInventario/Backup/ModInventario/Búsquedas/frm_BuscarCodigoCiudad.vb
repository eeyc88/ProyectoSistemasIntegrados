Public Class frm_BuscarCodigoCiudad
    Private _codigo As Integer
    Private _nombre As Integer
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
    Dim CIUDADataSet As New DataSet
    Private Sub frm_BuscarCodigoCiudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For i As Integer = 0 To Me.dgv_ciudad.RowCount - 2
            Me.dgv_ciudad.Rows.Remove(Me.dgv_ciudad.CurrentRow)
        Next
        'Me.dgv_ciudad.DataSource = Nothing
        Dim TBL_INV_CIUDADTableAdapter As New OleDb.OleDbDataAdapter("select codigo, nombre from TBL_INV_CIUDAD", cs)
        TBL_INV_CIUDADTableAdapter.Fill(CIUDADataSet, "TBL_INV_CIUDAD")
        Me.dgv_ciudad.DataSource = CIUDADataSet
        Me.dgv_ciudad.DataMember = "TBL_INV_CIUDAD"
    End Sub

    Private Sub dgv_ciudad_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ciudad.CellContentClick
        frm_Parametros.txt_codigoC.Text = Me.dgv_ciudad.Item(0, dgv_ciudad.CurrentCell.RowIndex).Value
        frm_Parametros.txt_nombreC.Text = Me.dgv_ciudad.Item(1, dgv_ciudad.CurrentCell.RowIndex).Value

        frm_Bodega.txt_codigociudad.Text = Me.dgv_ciudad.Item(0, dgv_ciudad.CurrentCell.RowIndex).Value
        frm_Bodega.txt_nombreciudad.Text = Me.dgv_ciudad.Item(1, dgv_ciudad.CurrentCell.RowIndex).Value
        Me.Close()
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_ciudad.Item(0, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
        End If
    End Sub

    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "codigo" Then
            CIUDADataSet.Tables("TBL_INV_CIUDAD").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_ciudad.DataSource = CIUDADataSet.Tables("TBL_INV_CIUDAD").DefaultView
        Else
            If cmbfiltro.Text = "nombre" Then
                CIUDADataSet.Tables("TBL_INV_CIUDAD").DefaultView.RowFilter = "nombre like '%" & Me.txt_filtro.Text & "%'"
                dgv_ciudad.DataSource = CIUDADataSet.Tables("TBL_INV_CIUDAD").DefaultView
            End If
        End If
    End Sub
End Class