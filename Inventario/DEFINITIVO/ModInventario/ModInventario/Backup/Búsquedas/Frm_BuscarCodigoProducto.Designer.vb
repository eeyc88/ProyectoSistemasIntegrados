<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BuscarCodigoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BuscarCodigoProducto))
        Me.dgv_producto = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbfiltro = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_filtro = New System.Windows.Forms.TextBox
        CType(Me.dgv_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_producto
        '
        Me.dgv_producto.AllowUserToAddRows = False
        Me.dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_producto.Location = New System.Drawing.Point(5, 75)
        Me.dgv_producto.Name = "dgv_producto"
        Me.dgv_producto.ReadOnly = True
        Me.dgv_producto.Size = New System.Drawing.Size(763, 223)
        Me.dgv_producto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar  Producto"
        '
        'cmbfiltro
        '
        Me.cmbfiltro.FormattingEnabled = True
        Me.cmbfiltro.Items.AddRange(New Object() {"Código", "Descripción", "Presentación"})
        Me.cmbfiltro.Location = New System.Drawing.Point(77, 41)
        Me.cmbfiltro.Name = "cmbfiltro"
        Me.cmbfiltro.Size = New System.Drawing.Size(123, 21)
        Me.cmbfiltro.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Filtrar por :"
        '
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_filtro.Location = New System.Drawing.Point(206, 41)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(188, 20)
        Me.txt_filtro.TabIndex = 45
        Me.txt_filtro.Text = "( ingrese texto aquí  )"
        '
        'Frm_BuscarCodigoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 310)
        Me.Controls.Add(Me.cmbfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_producto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BuscarCodigoProducto"
        Me.Text = "Búsqueda"
        CType(Me.dgv_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_producto As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
End Class
