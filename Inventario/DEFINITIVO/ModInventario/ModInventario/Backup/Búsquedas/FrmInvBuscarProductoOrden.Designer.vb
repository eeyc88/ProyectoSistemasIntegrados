<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvBuscarProductoOrden
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
        Me.cmbfiltro = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtFiltro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbfiltro
        '
        Me.cmbfiltro.FormattingEnabled = True
        Me.cmbfiltro.Items.AddRange(New Object() {"Código", "Nombre"})
        Me.cmbfiltro.Location = New System.Drawing.Point(80, 46)
        Me.cmbfiltro.Name = "cmbfiltro"
        Me.cmbfiltro.Size = New System.Drawing.Size(111, 21)
        Me.cmbfiltro.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Filtrar por :"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFiltro.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TxtFiltro.Location = New System.Drawing.Point(197, 47)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(154, 20)
        Me.TxtFiltro.TabIndex = 46
        Me.TxtFiltro.Text = "( ingrese texto aquí  )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Buscar  Producto"
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Location = New System.Drawing.Point(8, 83)
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.Size = New System.Drawing.Size(343, 197)
        Me.DgvBusqueda.TabIndex = 48
        '
        'FrmInvBuscarProductoOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 303)
        Me.Controls.Add(Me.DgvBusqueda)
        Me.Controls.Add(Me.cmbfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInvBuscarProductoOrden"
        Me.Text = "Búsqueda"
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvBusqueda As System.Windows.Forms.DataGridView
End Class
