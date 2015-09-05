Public Class frmBuscaCodigoMarca
    Private _codigo As Integer
    Private _descripcion As Integer
    Property codigo()
        Get
            Return Me._codigo
        End Get
        Set(ByVal value)
            Me._codigo = value
        End Set
    End Property
    Property descripcion()
        Get
            Return Me._descripcion
        End Get
        Set(ByVal value)
            Me._descripcion = value
        End Set
    End Property

    Dim MARCADataSet As New DataSet
    Private Sub frmBuscaCodigoMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For i As Integer = 0 To Me.dgv_marca.RowCount - 2
        '    Me.dgv_marca.Rows.Remove(Me.dgv_marca.CurrentRow)
        'Next
        If dgv_marca.RowCount = 0 Then
            Dim TBL_INV_ZONATableAdapter As New OleDb.OleDbDataAdapter("select codigo, descripcion from TBL_INV_MARCA", cs)
            TBL_INV_ZONATableAdapter.Fill(MARCADataSet, "TBL_INV_MARCA")
            Me.dgv_marca.DataSource = MARCADataSet
            Me.dgv_marca.DataMember = "TBL_INV_MARCA"
        End If
    End Sub

    Private Sub dgv_marca_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_marca.CellContentClick
        frm_Parametros.txt_codigo.Text = Me.dgv_marca.Item(0, dgv_marca.CurrentCell.RowIndex).Value
        frm_Parametros.txt_descripcion.Text = Me.dgv_marca.Item(1, dgv_marca.CurrentCell.RowIndex).Value

        frm_Producto.txt_codigomarca.Text = Me.dgv_marca.Item(0, dgv_marca.CurrentCell.RowIndex).Value
        frm_Producto.txt_nombremarca.Text = Me.dgv_marca.Item(1, dgv_marca.CurrentCell.RowIndex).Value
        Me.Close()
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_marca.Item(0, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
        End If
    End Sub
    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "Código" Then
            MARCADataSet.Tables("TBL_INV_MARCA").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_marca.DataSource = MARCADataSet.Tables("TBL_INV_MARCA").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                MARCADataSet.Tables("TBL_INV_MARCA").DefaultView.RowFilter = "descripcion like '%" & Me.txt_filtro.Text & "%'"
                dgv_marca.DataSource = MARCADataSet.Tables("TBL_INV_MARCA").DefaultView
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