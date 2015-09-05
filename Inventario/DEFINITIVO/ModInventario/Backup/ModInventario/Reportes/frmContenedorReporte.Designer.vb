<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContenedorReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crv_VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv_VisorReporte
        '
        Me.crv_VisorReporte.ActiveViewIndex = -1
        Me.crv_VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_VisorReporte.DisplayGroupTree = False
        Me.crv_VisorReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_VisorReporte.Location = New System.Drawing.Point(0, 0)
        Me.crv_VisorReporte.Name = "crv_VisorReporte"
        Me.crv_VisorReporte.SelectionFormula = ""
        Me.crv_VisorReporte.Size = New System.Drawing.Size(958, 698)
        Me.crv_VisorReporte.TabIndex = 0
        Me.crv_VisorReporte.ViewTimeSelectionFormula = ""
        '
        'frmContenedorReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 698)
        Me.Controls.Add(Me.crv_VisorReporte)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContenedorReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
