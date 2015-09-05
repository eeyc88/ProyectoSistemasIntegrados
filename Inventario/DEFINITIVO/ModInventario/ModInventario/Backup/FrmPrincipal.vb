Public Class FrmPrincipal
    Private Sub OrdenDePedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoxBodegaToolStripMenuItem.Click
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub KardexdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenPedidoToolStripMenuItem.Click
        FrmOrdenPedido.Show()
    End Sub
    Private Sub ReporteDeKardeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeKardeToolStripMenuItem.Click
        frm_cons_kardex.Show()
    End Sub
    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        frm_Producto.Show()
    End Sub
    Private Sub KardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        frm_Kardex.Show()
    End Sub
    Private Sub BodegaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        frm_Parametros.Show()
    End Sub
    Private Sub ReporteDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeProductosToolStripMenuItem.Click
        frm_reporte.Show()
    End Sub

    Private Sub ReporteDeExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeExistenciasToolStripMenuItem.Click
        FrmInvExistencia.Show()
    End Sub

    Private Sub BodegaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BodegaToolStripMenuItem1.Click
        frm_Bodega.Show()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class