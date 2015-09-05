<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoxBodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeKardeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MantenimientosToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ConsultasReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(799, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SalirToolStripMenuItem.Text = "Cerra Módulo"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.BodegaToolStripMenuItem1})
        Me.MantenimientosToolStripMenuItem.Image = CType(resources.GetObject("MantenimientosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.MarcaToolStripMenuItem.Text = "Parametros"
        '
        'BodegaToolStripMenuItem1
        '
        Me.BodegaToolStripMenuItem1.Name = "BodegaToolStripMenuItem1"
        Me.BodegaToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.BodegaToolStripMenuItem1.Text = "Bodega"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoxBodegaToolStripMenuItem, Me.OrdenPedidoToolStripMenuItem, Me.KardexToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Image = CType(resources.GetObject("ProcesosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'ProductoxBodegaToolStripMenuItem
        '
        Me.ProductoxBodegaToolStripMenuItem.Name = "ProductoxBodegaToolStripMenuItem"
        Me.ProductoxBodegaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ProductoxBodegaToolStripMenuItem.Text = "Producto por Bodega"
        '
        'OrdenPedidoToolStripMenuItem
        '
        Me.OrdenPedidoToolStripMenuItem.Name = "OrdenPedidoToolStripMenuItem"
        Me.OrdenPedidoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.OrdenPedidoToolStripMenuItem.Text = "Orden de Pedido"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'ConsultasReportesToolStripMenuItem
        '
        Me.ConsultasReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeExistenciasToolStripMenuItem, Me.ReporteDeProductosToolStripMenuItem, Me.ReporteDeKardeToolStripMenuItem})
        Me.ConsultasReportesToolStripMenuItem.Image = CType(resources.GetObject("ConsultasReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasReportesToolStripMenuItem.Name = "ConsultasReportesToolStripMenuItem"
        Me.ConsultasReportesToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.ConsultasReportesToolStripMenuItem.Text = "Consultas/Reportes"
        Me.ConsultasReportesToolStripMenuItem.Visible = False
        '
        'ReporteDeExistenciasToolStripMenuItem
        '
        Me.ReporteDeExistenciasToolStripMenuItem.Name = "ReporteDeExistenciasToolStripMenuItem"
        Me.ReporteDeExistenciasToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ReporteDeExistenciasToolStripMenuItem.Text = "Reporte de Existencias"
        '
        'ReporteDeProductosToolStripMenuItem
        '
        Me.ReporteDeProductosToolStripMenuItem.Name = "ReporteDeProductosToolStripMenuItem"
        Me.ReporteDeProductosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ReporteDeProductosToolStripMenuItem.Text = "Reporte de Productos"
        '
        'ReporteDeKardeToolStripMenuItem
        '
        Me.ReporteDeKardeToolStripMenuItem.Name = "ReporteDeKardeToolStripMenuItem"
        Me.ReporteDeKardeToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ReporteDeKardeToolStripMenuItem.Text = "Reporte de Kardex"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 482)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Módulo Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoxBodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeExistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeKardeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodegaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
