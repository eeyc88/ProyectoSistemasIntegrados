<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaCodigoMarca
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
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv_marca = New System.Windows.Forms.DataGridView
        CType(Me.dgv_marca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbfiltro
        '
        Me.cmbfiltro.FormattingEnabled = True
        Me.cmbfiltro.Items.AddRange(New Object() {"Código", "Nombre"})
        Me.cmbfiltro.Location = New System.Drawing.Point(81, 43)
        Me.cmbfiltro.Name = "cmbfiltro"
        Me.cmbfiltro.Size = New System.Drawing.Size(111, 21)
        Me.cmbfiltro.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Filtrar por :"
        '
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_filtro.Location = New System.Drawing.Point(202, 44)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(154, 20)
        Me.txt_filtro.TabIndex = 47
        Me.txt_filtro.Text = "( ingrese texto aquí  )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Buscar  Marca"
        '
        'dgv_marca
        '
        Me.dgv_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_marca.Location = New System.Drawing.Point(9, 76)
        Me.dgv_marca.Name = "dgv_marca"
        Me.dgv_marca.Size = New System.Drawing.Size(347, 178)
        Me.dgv_marca.TabIndex = 44
        '
        'frmBuscaCodigoMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 262)
        Me.Controls.Add(Me.cmbfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_marca)
        Me.Name = "frmBuscaCodigoMarca"
        Me.Text = "Busqueda"
        CType(Me.dgv_marca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_marca As System.Windows.Forms.DataGridView
End Class
