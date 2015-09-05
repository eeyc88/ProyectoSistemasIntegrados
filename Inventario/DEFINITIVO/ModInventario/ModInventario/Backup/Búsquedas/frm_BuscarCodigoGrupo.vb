Public Class frm_BuscarCodigoGrupo
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
    Dim GRUPODataSet As New DataSet
    Private Sub frm_BuscarCodigoGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For i As Integer = 0 To Me.dgv_grupo.RowCount - 2
        '    Me.dgv_grupo.Rows.Remove(Me.dgv_grupo.CurrentRow)
        'Next
        If dgv_grupo.RowCount = 0 Then
            Dim TBL_INV_GRUPOTableAdapter As New OleDb.OleDbDataAdapter("select codigo, descripcion from TBL_INV_GRUPO", cs)
            TBL_INV_GRUPOTableAdapter.Fill(GRUPODataSet, "TBL_INV_GRUPO")
            Me.dgv_grupo.DataSource = GRUPODataSet
            Me.dgv_grupo.DataMember = "TBL_INV_GRUPO"
        End If

    End Sub

    Private Sub dgv_grupo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_grupo.CellContentClick
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_grupo.Item(0, e.RowIndex).Value
            Me.nombre = Me.dgv_grupo.Item(1, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
            Me.Close()
        End If
        frm_Parametros.txt_codigoG.Text = Me.dgv_grupo.Item(0, dgv_grupo.CurrentCell.RowIndex).Value
        frm_Parametros.txt_nombre.Text = Me.dgv_grupo.Item(1, dgv_grupo.CurrentCell.RowIndex).Value

        frm_Producto.txt_codigogrupo.Text = Me.dgv_grupo.Item(0, dgv_grupo.CurrentCell.RowIndex).Value
        frm_Producto.txt_nombregrupo.Text = Me.dgv_grupo.Item(1, dgv_grupo.CurrentCell.RowIndex).Value

        frm_reporte.txt_codigogrupo.Text = Me.dgv_grupo.Item(0, dgv_grupo.CurrentCell.RowIndex).Value
        frm_reporte.txt_nombregrupo.Text = Me.dgv_grupo.Item(1, dgv_grupo.CurrentCell.RowIndex).Value
        Me.Close()
    End Sub

    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "Código" Then
            GRUPODataSet.Tables("TBL_INV_GRUPO").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_grupo.DataSource = GRUPODataSet.Tables("TBL_INV_GRUPO").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                GRUPODataSet.Tables("TBL_INV_GRUPO").DefaultView.RowFilter = "descripcion like '%" & Me.txt_filtro.Text & "%'"
                dgv_grupo.DataSource = GRUPODataSet.Tables("TBL_INV_GRUPO").DefaultView
            End If
        End If
    End Sub

    Private Sub cmbfiltro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txt_filtro.Enabled = True
    End Sub

    Private Sub cmbfiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfiltro.SelectedIndexChanged
        txt_filtro.Text = ""
    End Sub
End Class