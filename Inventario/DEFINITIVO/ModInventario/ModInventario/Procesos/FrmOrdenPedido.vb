Imports System.Data.OleDb
Public Class FrmOrdenPedido
    Sub Nuevo()
        Dim cmd As New OleDbCommand
        Try
            conectarse()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select isnull(max(numero),0)+1 as maximo from TBL_INV_CAB_ORDEN_PEDIDO"
            Lblorden.Text = cmd.ExecuteScalar.ToString
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtbodega.Text = 0
        TxtNBodega.Text = String.Empty
        txtusuario.Text = "usuario"
        DgvOrden.Rows.Clear()
        txtobservación.Text = String.Empty
        LblFecha.Text = Date.Now.ToString("dd/MM/yyyy")
        DtpFechaRequerida.Text = Now
        BtnBuscarBodega.Enabled = True
        DtpFechaRequerida.Enabled = True
        DgvOrden.Enabled = True
        txtobservación.Enabled = True
        BtnEnviar.Enabled = True
        BtnCancelar.Enabled = True
        Btnnuevo.Enabled = False
    End Sub
    Private Sub FrmOrdenPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        LblFecha.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub Btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        Nuevo()
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        Desconectar()
    End Sub
    Private Sub BtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviar.Click
        Dim flag As Boolean = True
        If String.IsNullOrEmpty(txtbodega.Text) Or txtbodega.Text = 0 Then
            flag = False
            MsgBox("Debe asignar una bodega a la orden", MsgBoxStyle.OkOnly, "Sistema")
            BtnBuscarBodega.Focus()
        ElseIf DtpFechaRequerida.Text < Date.Now.ToString("dd/MM/yyyy") Then
            flag = False
            MsgBox("Debe ingresar una fecha valida", MsgBoxStyle.OkOnly, "Sistema")
            DtpFechaRequerida.Focus()
        ElseIf DgvOrden.Rows.Count <= 1 Then
            flag = False
            MsgBox("Debe ingresar productos a la orden ", MsgBoxStyle.OkOnly, "Sistema")
            DgvOrden.Focus()
        End If
        If flag = True Then
            Dim oOrdenCabecera As New OrdenPedidoCabecera(Lblorden.Text, Me.txtbodega.Text, 1, Date.Now.ToString("dd/MM/yyyy"), Me.DtpFechaRequerida.Text, Me.txtobservación.Text)
            oOrdenCabecera.imprimir()
            oOrdenCabecera.Ingresar()
            For i As Integer = 0 To DgvOrden.Rows.Count - 2
                Dim oOrdenDetalle As New OrdenPedidoDetalle((CInt(Lblorden.Text)), Me.txtbodega.Text, i + 1, 5, DgvOrden.Rows(i).Cells(2).Value, False)
                oOrdenDetalle.imprimir()
                oOrdenDetalle.Ingresar()
            Next
            MsgBox("Registro enviado correctamente", MsgBoxStyle.OkOnly, "Sistema")
            Nuevo()
            Btnnuevo.Enabled = True
            txtbodega.Text = String.Empty
            txtusuario.Text = String.Empty
            BtnEnviar.Enabled = False
            BtnCancelar.Enabled = False
            BtnBuscarBodega.Enabled = False
            DtpFechaRequerida.Enabled = False
            DgvOrden.Enabled = False
            txtobservación.Enabled = False
            Lblorden.Text = String.Empty
        End If
    End Sub
    Private Sub BtnBuscarBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarBodega.Click
        Frm_BuscarBodega.ShowDialog()
        Me.txtbodega.Text = Frm_BuscarBodega.codigo
        Me.TxtNBodega.Text = Frm_BuscarBodega.nombre
    End Sub
    Private Sub DgvOrden_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvOrden.CellContentClick
        If txtbodega.Text = 0 Then
            MsgBox("Debe ingresar una bodega")
        Else
            FrmInvBuscarProductoOrden.ShowDialog()
            DgvOrden.CurrentRow.Cells(1).Value = FrmInvBuscarProductoOrden.nombre
        End If
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim res As Boolean
        res = MsgBox("Está seguro que desea cancelar la emisión de la orden?", MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes
        If res = True Then
            Nuevo()
            BtnCancelar.Enabled = False
            BtnEnviar.Enabled = False
            Btnnuevo.Enabled = True
            txtbodega.Text = String.Empty
            BtnBuscarBodega.Enabled = False
            DtpFechaRequerida.Enabled = False
            DgvOrden.Enabled = False
            txtobservación.Enabled = False
            Lblorden.Text = String.Empty
        End If
    End Sub
    Dim WithEvents valid As TextBox

    Private Sub DgvOrden_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvOrden.CellEndEdit
        Dim actual As String
        actual = DgvOrden.CurrentRow.Cells(1).Value
        For i As Integer = 0 To DgvOrden.Rows.Count - 2
            If DgvOrden.Rows(i).Cells(1).Value = actual And i <> DgvOrden.Rows.Count - 2 Then
                MsgBox("No puede ingresar 2 veces el mismo producto", MsgBoxStyle.OkOnly, "Sistema")
                DgvOrden.CurrentRow.Cells(1).Value = ""
                DgvOrden.CurrentRow.Cells(2).Value = ""
                SendKeys.Send("{UP}")
                Exit Sub
            End If
        Next
    End Sub
    Private Sub DgvOrden_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DgvOrden.CellValidating
        If DgvOrden.CurrentCell.ColumnIndex = 1 Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                MsgBox("Debe elegir un producto...", MsgBoxStyle.OkOnly, "Sistema")
                If sender.CurrentCell.ColumnIndex = 1 Then Exit Sub
                FrmInvBuscarProductoOrden.ShowDialog()
                DgvOrden.CurrentRow.Cells(1).Value = FrmInvBuscarProductoOrden.nombre
                e.Cancel = True
            End If
        ElseIf DgvOrden.CurrentCell.ColumnIndex = 2 Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) And Not String.IsNullOrEmpty(DgvOrden.CurrentRow.Cells(1).Value) Then
                MsgBox("La celda de cantidad no debe estar vacía", MsgBoxStyle.OkOnly, "Sistema")
                DgvCantidad.Selected = True
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub DgvOrden_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvOrden.EditingControlShowing
        If DgvOrden.CurrentCell.ColumnIndex = 2 Then
            If TypeOf e.Control Is TextBox Then
                valid = e.Control
            End If
        End If
    End Sub
    Private Sub valid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles valid.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
