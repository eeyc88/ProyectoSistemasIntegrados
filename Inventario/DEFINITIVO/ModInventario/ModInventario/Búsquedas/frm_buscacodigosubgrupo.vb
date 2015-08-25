Public Class frm_buscacodigosubgrupo
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
    Dim SubGruDataSet As New DataSet
    Private Sub frm_buscacodigosubgrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Me.dgv_subgrupo.RowCount - 2
            Me.dgv_subgrupo.Rows.Remove(Me.dgv_subgrupo.CurrentRow)
        Next
        Dim TBL_INV_SUBGRUPOTableAdapter As New OleDb.OleDbDataAdapter("select codigo, grupo, descripcion from TBL_INV_SUBGRUPO where grupo=" + frm_Producto.txt_codigogrupo.Text + "", cs)
        'SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView.RowFilter = "(CONVERT(grupo,System.String)) like '" & frm_Producto.txt_codigogrupo.Text & "'"
        TBL_INV_SUBGRUPOTableAdapter.Fill(SubGruDataSet, "TBL_INV_SUBGRUPO")
        Me.dgv_subgrupo.DataSource = SubGruDataSet
        Me.dgv_subgrupo.DataMember = "TBL_INV_SUBGRUPO"
    End Sub

    Private Sub dgv_subgrupo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_subgrupo.CellContentClick
        frm_Producto.txt_codigosubgrupo.Text = Me.dgv_subgrupo.Item(0, dgv_subgrupo.CurrentCell.RowIndex).Value
        frm_Producto.txt_nombresubgrupo.Text = Me.dgv_subgrupo.Item(2, dgv_subgrupo.CurrentCell.RowIndex).Value
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_subgrupo.Item(0, e.RowIndex).Value
            Me.nombre = Me.dgv_subgrupo.Item(2, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
        End If
        Me.Close()
    End Sub

    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "Código" Then
            SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_subgrupo.DataSource = SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView.RowFilter = "descripcion like '%" & Me.txt_filtro.Text & "%'"
                dgv_subgrupo.DataSource = SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView
            End If
        End If
    End Sub
End Class