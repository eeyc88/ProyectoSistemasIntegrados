<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrdenPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Lblorden = New System.Windows.Forms.Label
        Me.txtbodega = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Btnnuevo = New System.Windows.Forms.Button
        Me.BtnEnviar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.txtusuario = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DtpFechaRequerida = New System.Windows.Forms.DateTimePicker
        Me.BtnBuscarBodega = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtNBodega = New System.Windows.Forms.TextBox
        Me.LblFecha = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtobservación = New System.Windows.Forms.TextBox
        Me.DgvOrden = New System.Windows.Forms.DataGridView
        Me.dgvcodigo = New System.Windows.Forms.DataGridViewButtonColumn
        Me.dgvproducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblorden
        '
        Me.Lblorden.AutoSize = True
        Me.Lblorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblorden.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lblorden.Location = New System.Drawing.Point(333, 9)
        Me.Lblorden.Name = "Lblorden"
        Me.Lblorden.Size = New System.Drawing.Size(0, 39)
        Me.Lblorden.TabIndex = 0
        '
        'txtbodega
        '
        Me.txtbodega.Enabled = False
        Me.txtbodega.Location = New System.Drawing.Point(271, 15)
        Me.txtbodega.Name = "txtbodega"
        Me.txtbodega.Size = New System.Drawing.Size(30, 20)
        Me.txtbodega.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(-5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 39)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Orden de Pedido Nº"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.Btnnuevo)
        Me.GroupBox1.Controls.Add(Me.BtnEnviar)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(442, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 284)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(7, 147)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(61, 54)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Btnnuevo
        '
        Me.Btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnuevo.Image = CType(resources.GetObject("Btnnuevo.Image"), System.Drawing.Image)
        Me.Btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnnuevo.Location = New System.Drawing.Point(7, 12)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(61, 54)
        Me.Btnnuevo.TabIndex = 17
        Me.Btnnuevo.Text = "Nuevo"
        Me.Btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEnviar.Location = New System.Drawing.Point(7, 81)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(61, 54)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(7, 214)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(61, 54)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        Me.txtusuario.Enabled = False
        Me.txtusuario.Location = New System.Drawing.Point(102, 15)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Bodega:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Responsable :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Fecha Requerida :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Fecha :"
        '
        'DtpFechaRequerida
        '
        Me.DtpFechaRequerida.Enabled = False
        Me.DtpFechaRequerida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaRequerida.Location = New System.Drawing.Point(327, 48)
        Me.DtpFechaRequerida.Name = "DtpFechaRequerida"
        Me.DtpFechaRequerida.Size = New System.Drawing.Size(84, 20)
        Me.DtpFechaRequerida.TabIndex = 48
        '
        'BtnBuscarBodega
        '
        Me.BtnBuscarBodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarBodega.Enabled = False
        Me.BtnBuscarBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarBodega.Image = CType(resources.GetObject("BtnBuscarBodega.Image"), System.Drawing.Image)
        Me.BtnBuscarBodega.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscarBodega.Location = New System.Drawing.Point(307, 11)
        Me.BtnBuscarBodega.Name = "BtnBuscarBodega"
        Me.BtnBuscarBodega.Size = New System.Drawing.Size(29, 24)
        Me.BtnBuscarBodega.TabIndex = 49
        Me.BtnBuscarBodega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscarBodega.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNBodega)
        Me.GroupBox2.Controls.Add(Me.LblFecha)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarBodega)
        Me.GroupBox2.Controls.Add(Me.DtpFechaRequerida)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtusuario)
        Me.GroupBox2.Controls.Add(Me.txtbodega)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 83)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'TxtNBodega
        '
        Me.TxtNBodega.Enabled = False
        Me.TxtNBodega.Location = New System.Drawing.Point(342, 15)
        Me.TxtNBodega.Name = "TxtNBodega"
        Me.TxtNBodega.Size = New System.Drawing.Size(69, 20)
        Me.TxtNBodega.TabIndex = 51
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(99, 49)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(0, 13)
        Me.LblFecha.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Observaciones:"
        '
        'txtobservación
        '
        Me.txtobservación.Enabled = False
        Me.txtobservación.Location = New System.Drawing.Point(117, 302)
        Me.txtobservación.Multiline = True
        Me.txtobservación.Name = "txtobservación"
        Me.txtobservación.Size = New System.Drawing.Size(314, 60)
        Me.txtobservación.TabIndex = 52
        '
        'DgvOrden
        '
        Me.DgvOrden.AllowUserToOrderColumns = True
        Me.DgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcodigo, Me.dgvproducto, Me.DgvCantidad})
        Me.DgvOrden.Enabled = False
        Me.DgvOrden.Location = New System.Drawing.Point(4, 148)
        Me.DgvOrden.Name = "DgvOrden"
        Me.DgvOrden.Size = New System.Drawing.Size(427, 132)
        Me.DgvOrden.TabIndex = 53
        '
        'dgvcodigo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvcodigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcodigo.FillWeight = 20.0!
        Me.dgvcodigo.Frozen = True
        Me.dgvcodigo.HeaderText = "Código"
        Me.dgvcodigo.Name = "dgvcodigo"
        Me.dgvcodigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcodigo.Text = "..."
        Me.dgvcodigo.Width = 50
        '
        'dgvproducto
        '
        Me.dgvproducto.Frozen = True
        Me.dgvproducto.HeaderText = "Producto"
        Me.dgvproducto.Name = "dgvproducto"
        Me.dgvproducto.ReadOnly = True
        Me.dgvproducto.Width = 230
        '
        'DgvCantidad
        '
        Me.DgvCantidad.HeaderText = "Cantidad"
        Me.DgvCantidad.Name = "DgvCantidad"
        Me.DgvCantidad.Width = 70
        '
        'FrmOrdenPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 389)
        Me.Controls.Add(Me.DgvOrden)
        Me.Controls.Add(Me.txtobservación)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblorden)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOrdenPedido"
        Me.Text = "Orden de Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblorden As System.Windows.Forms.Label
    Friend WithEvents txtbodega As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnnuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEnviar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaRequerida As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBuscarBodega As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtobservación As System.Windows.Forms.TextBox
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents DgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNBodega As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvcodigo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvCantidad As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
