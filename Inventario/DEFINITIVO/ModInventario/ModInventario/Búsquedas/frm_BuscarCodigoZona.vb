Public Class frm_BuscarCodigoZona
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

    Dim DataSet1 As New DataSet
    Private Sub frm_BuscarCodigoZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Me.dgv_zona.RowCount - 2
            Me.dgv_zona.Rows.Remove(Me.dgv_zona.CurrentRow)
        Next
        Dim TBL_INV_ZONATableAdapter As New OleDb.OleDbDataAdapter("select codigo, ciudad, nombre from TBL_INV_ZONA where ciudad=" + frm_Bodega.txt_codigociudad.Text + "", cs)
        'SubGruDataSet.Tables("TBL_INV_SUBGRUPO").DefaultView.RowFilter = "(CONVERT(grupo,System.String)) like '" & frm_Producto.txt_codigogrupo.Text & "'"
        TBL_INV_ZONATableAdapter.Fill(DataSet1, "TBL_INV_ZONA")
        Me.dgv_zona.DataSource = DataSet1
        Me.dgv_zona.DataMember = "TBL_INV_ZONA"
    End Sub

    Private Sub dgv_zona_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_zona.CellContentClick
        frm_Bodega.txt_codigozona.Text = Me.dgv_zona.Item(0, dgv_zona.CurrentCell.RowIndex).Value
        frm_Bodega.txt_nombrezona.Text = Me.dgv_zona.Item(2, dgv_zona.CurrentCell.RowIndex).Value
        Me.Close()
        If e.RowIndex >= 0 Then ' lo pongo >=0.. por que sino devuelve menos uno.
            Me.codigo = Me.dgv_zona.Item(0, e.RowIndex).Value
            'el objeto "e"  me dice cual es la columna y fila actual...!!!
        End If
    End Sub

    Private Sub txt_filtro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_filtro.MouseClick
        txt_filtro.Text = ""
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        If cmbfiltro.Text = "Código" Then
            DataSet1.Tables("TBL_INV_ZONA").DefaultView.RowFilter = "(CONVERT(codigo,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_zona.DataSource = DataSet1.Tables("TBL_INV_ZONA").DefaultView
        Else
            If cmbfiltro.Text = "Nombre" Then
                DataSet1.Tables("TBL_INV_ZONA").DefaultView.RowFilter = "nombre like '%" & Me.txt_filtro.Text & "%'"
                dgv_zona.DataSource = DataSet1.Tables("TBL_INV_ZONA").DefaultView
            End If
        End If
        If cmbfiltro.Text = "Ciudad" Then
            DataSet1.Tables("TBL_INV_ZONA").DefaultView.RowFilter = "(CONVERT(ciudad,System.String)) like '%" & Me.txt_filtro.Text & "%'"
            dgv_zona.DataSource = DataSet1.Tables("TBL_INV_ZONA").DefaultView
        End If
    End Sub
End Class