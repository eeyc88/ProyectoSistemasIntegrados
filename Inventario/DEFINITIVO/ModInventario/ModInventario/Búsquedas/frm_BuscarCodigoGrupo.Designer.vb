<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscarCodigoGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BuscarCodigoGrupo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv_grupo = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.cmbfiltro = New System.Windows.Forms.ComboBox
        CType(Me.dgv_grupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar  Grupo"
        '
        'dgv_grupo
        '
        Me.dgv_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_grupo.Location = New System.Drawing.Point(6, 80)
        Me.dgv_grupo.Name = "dgv_grupo"
        Me.dgv_grupo.Size = New System.Drawing.Size(347, 178)
        Me.dgv_grupo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Filtrar por :"
        '
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_filtro.Location = New System.Drawing.Point(196, 45)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(154, 20)
        Me.txt_filtro.TabIndex = 38
        Me.txt_filtro.Text = "( ingrese texto aquí  )"
        '
        'cmbfiltro
        '
        Me.cmbfiltro.FormattingEnabled = True
        Me.cmbfiltro.Items.AddRange(New Object() {"Código", "Nombre"})
        Me.cmbfiltro.Location = New System.Drawing.Point(79, 44)
        Me.cmbfiltro.Name = "cmbfiltro"
        Me.cmbfiltro.Size = New System.Drawing.Size(111, 21)
        Me.cmbfiltro.TabIndex = 43
        '
        'frm_BuscarCodigoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 268)
        Me.Controls.Add(Me.cmbfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_grupo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_BuscarCodigoGrupo"
        Me.Text = "Búsqueda"
        CType(Me.dgv_grupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_grupo As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents cmbfiltro As System.Windows.Forms.ComboBox
End Class
