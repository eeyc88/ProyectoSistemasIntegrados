<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kardex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kardex))
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grpdetalle = New System.Windows.Forms.GroupBox
        Me.DgvDetalle = New System.Windows.Forms.DataGridView
        Me.BtnMenos = New System.Windows.Forms.Button
        Me.BtnMas = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.Btnnuevo = New System.Windows.Forms.Button
        Me.txtbodega = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtresponsable = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtmaxima = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnBuscarProducto = New System.Windows.Forms.Button
        Me.txtminima = New System.Windows.Forms.TextBox
        Me.txtproducto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtgrupo = New System.Windows.Forms.TextBox
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtsubgrupo = New System.Windows.Forms.TextBox
        Me.BtnBuscarBodega = New System.Windows.Forms.Button
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtactual = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtmetodo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.fechak = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.detalle = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cantm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totalm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpdetalle.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpdetalle
        '
        Me.grpdetalle.Controls.Add(Me.DgvDetalle)
        Me.grpdetalle.Controls.Add(Me.BtnMenos)
        Me.grpdetalle.Controls.Add(Me.BtnMas)
        Me.grpdetalle.Location = New System.Drawing.Point(6, 265)
        Me.grpdetalle.Name = "grpdetalle"
        Me.grpdetalle.Size = New System.Drawing.Size(589, 207)
        Me.grpdetalle.TabIndex = 14
        Me.grpdetalle.TabStop = False
        Me.grpdetalle.Text = "Detalle de Kardex"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechak, Me.detalle, Me.cantm, Me.unitm, Me.totalm, Me.cante, Me.unite, Me.totale})
        Me.DgvDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DgvDetalle.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvDetalle.Location = New System.Drawing.Point(8, 17)
        Me.DgvDetalle.Margin = New System.Windows.Forms.Padding(1)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.RowHeadersWidth = 4
        Me.DgvDetalle.Size = New System.Drawing.Size(538, 186)
        Me.DgvDetalle.TabIndex = 0
        '
        'BtnMenos
        '
        Me.BtnMenos.Enabled = False
        Me.BtnMenos.Image = CType(resources.GetObject("BtnMenos.Image"), System.Drawing.Image)
        Me.BtnMenos.Location = New System.Drawing.Point(548, 61)
        Me.BtnMenos.Name = "BtnMenos"
        Me.BtnMenos.Size = New System.Drawing.Size(37, 36)
        Me.BtnMenos.TabIndex = 1
        Me.BtnMenos.UseVisualStyleBackColor = True
        '
        'BtnMas
        '
        Me.BtnMas.Enabled = False
        Me.BtnMas.Image = CType(resources.GetObject("BtnMas.Image"), System.Drawing.Image)
        Me.BtnMas.Location = New System.Drawing.Point(548, 19)
        Me.BtnMas.Name = "BtnMas"
        Me.BtnMas.Size = New System.Drawing.Size(37, 36)
        Me.BtnMas.TabIndex = 0
        Me.BtnMas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.btn_grabar)
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.Btnnuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(507, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(80, 221)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(6, 113)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(68, 50)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Enabled = False
        Me.btn_grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(5, 63)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(68, 50)
        Me.btn_grabar.TabIndex = 1
        Me.btn_grabar.Text = "&Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(5, 166)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(68, 50)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Btnnuevo
        '
        Me.Btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnuevo.Image = CType(resources.GetObject("Btnnuevo.Image"), System.Drawing.Image)
        Me.Btnnuevo.Location = New System.Drawing.Point(6, 11)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btnnuevo.Size = New System.Drawing.Size(68, 50)
        Me.Btnnuevo.TabIndex = 0
        Me.Btnnuevo.Text = "Consultar"
        Me.Btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'txtbodega
        '
        Me.txtbodega.Enabled = False
        Me.txtbodega.Location = New System.Drawing.Point(104, 70)
        Me.txtbodega.Name = "txtbodega"
        Me.txtbodega.Size = New System.Drawing.Size(76, 20)
        Me.txtbodega.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 35)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Existencia Máxima:"
        '
        'txtresponsable
        '
        Me.txtresponsable.Enabled = False
        Me.txtresponsable.Location = New System.Drawing.Point(106, 15)
        Me.txtresponsable.Name = "txtresponsable"
        Me.txtresponsable.Size = New System.Drawing.Size(305, 20)
        Me.txtresponsable.TabIndex = 8
        Me.txtresponsable.Text = " usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Responsable:"
        '
        'txtmaxima
        '
        Me.txtmaxima.Enabled = False
        Me.txtmaxima.Location = New System.Drawing.Point(105, 127)
        Me.txtmaxima.Name = "txtmaxima"
        Me.txtmaxima.Size = New System.Drawing.Size(76, 20)
        Me.txtmaxima.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bodega:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label7.Location = New System.Drawing.Point(37, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Existencia Mínima:"
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.Enabled = False
        Me.BtnBuscarProducto.Image = CType(resources.GetObject("BtnBuscarProducto.Image"), System.Drawing.Image)
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(182, 40)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(30, 25)
        Me.BtnBuscarProducto.TabIndex = 0
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtminima
        '
        Me.txtminima.Enabled = False
        Me.txtminima.Location = New System.Drawing.Point(104, 163)
        Me.txtminima.Name = "txtminima"
        Me.txtminima.Size = New System.Drawing.Size(76, 20)
        Me.txtminima.TabIndex = 3
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Location = New System.Drawing.Point(217, 44)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(194, 20)
        Me.txtproducto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Grupo:"
        '
        'txtgrupo
        '
        Me.txtgrupo.Enabled = False
        Me.txtgrupo.Location = New System.Drawing.Point(106, 97)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(76, 20)
        Me.txtgrupo.TabIndex = 17
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(104, 44)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtcodigo.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(220, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Sub-Grupo:"
        '
        'txtsubgrupo
        '
        Me.txtsubgrupo.Enabled = False
        Me.txtsubgrupo.Location = New System.Drawing.Point(311, 96)
        Me.txtsubgrupo.Name = "txtsubgrupo"
        Me.txtsubgrupo.Size = New System.Drawing.Size(96, 20)
        Me.txtsubgrupo.TabIndex = 23
        '
        'BtnBuscarBodega
        '
        Me.BtnBuscarBodega.Enabled = False
        Me.BtnBuscarBodega.Image = CType(resources.GetObject("BtnBuscarBodega.Image"), System.Drawing.Image)
        Me.BtnBuscarBodega.Location = New System.Drawing.Point(182, 66)
        Me.BtnBuscarBodega.Name = "BtnBuscarBodega"
        Me.BtnBuscarBodega.Size = New System.Drawing.Size(30, 25)
        Me.BtnBuscarBodega.TabIndex = 1
        Me.BtnBuscarBodega.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(217, 69)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(194, 20)
        Me.txtdescripcion.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(220, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 31)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Existencia Actual:"
        '
        'txtactual
        '
        Me.txtactual.Enabled = False
        Me.txtactual.Location = New System.Drawing.Point(311, 127)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.Size = New System.Drawing.Size(96, 20)
        Me.txtactual.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtactual)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtmetodo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarBodega)
        Me.GroupBox1.Controls.Add(Me.txtsubgrupo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtgrupo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtresponsable)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtproducto)
        Me.GroupBox1.Controls.Add(Me.txtminima)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmaxima)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtbodega)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 197)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtmetodo
        '
        Me.txtmetodo.Enabled = False
        Me.txtmetodo.Location = New System.Drawing.Point(311, 159)
        Me.txtmetodo.Name = "txtmetodo"
        Me.txtmetodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmetodo.Size = New System.Drawing.Size(96, 20)
        Me.txtmetodo.TabIndex = 19
        Me.txtmetodo.Text = "PROMEDIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Método:"
        '
        'lblfecha
        '
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblfecha.Location = New System.Drawing.Point(116, 24)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(128, 25)
        Me.lblfecha.TabIndex = 25
        '
        'fechak
        '
        DataGridViewCellStyle36.Format = "d"
        DataGridViewCellStyle36.NullValue = Nothing
        Me.fechak.DefaultCellStyle = DataGridViewCellStyle36
        Me.fechak.FillWeight = 50.0!
        Me.fechak.HeaderText = "Fecha"
        Me.fechak.Name = "fechak"
        Me.fechak.Width = 60
        '
        'detalle
        '
        Me.detalle.HeaderText = "Detalle"
        Me.detalle.Items.AddRange(New Object() {"INGRESO", "EGRESO"})
        Me.detalle.Name = "detalle"
        Me.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cantm
        '
        DataGridViewCellStyle37.Format = "N0"
        DataGridViewCellStyle37.NullValue = "0"
        Me.cantm.DefaultCellStyle = DataGridViewCellStyle37
        Me.cantm.FillWeight = 25.0!
        Me.cantm.HeaderText = "Cant.M"
        Me.cantm.Name = "cantm"
        Me.cantm.Width = 60
        '
        'unitm
        '
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = "0"
        Me.unitm.DefaultCellStyle = DataGridViewCellStyle38
        Me.unitm.FillWeight = 50.0!
        Me.unitm.HeaderText = "V.Unit"
        Me.unitm.Name = "unitm"
        Me.unitm.Width = 60
        '
        'totalm
        '
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle39.Format = "N2"
        DataGridViewCellStyle39.NullValue = "0"
        Me.totalm.DefaultCellStyle = DataGridViewCellStyle39
        Me.totalm.FillWeight = 50.0!
        Me.totalm.HeaderText = "V.Total"
        Me.totalm.Name = "totalm"
        Me.totalm.ReadOnly = True
        Me.totalm.Width = 60
        '
        'cante
        '
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle40.Format = "N0"
        DataGridViewCellStyle40.NullValue = "0"
        Me.cante.DefaultCellStyle = DataGridViewCellStyle40
        Me.cante.FillWeight = 50.0!
        Me.cante.HeaderText = "Existencias"
        Me.cante.Name = "cante"
        Me.cante.ReadOnly = True
        Me.cante.Width = 70
        '
        'unite
        '
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle41.Format = "N2"
        DataGridViewCellStyle41.NullValue = "0"
        Me.unite.DefaultCellStyle = DataGridViewCellStyle41
        Me.unite.FillWeight = 50.0!
        Me.unite.HeaderText = "Valor Existencia"
        Me.unite.Name = "unite"
        Me.unite.ReadOnly = True
        Me.unite.Width = 60
        '
        'totale
        '
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle42.Format = "N2"
        DataGridViewCellStyle42.NullValue = "0"
        Me.totale.DefaultCellStyle = DataGridViewCellStyle42
        Me.totale.FillWeight = 50.0!
        Me.totale.HeaderText = "Total Existencia"
        Me.totale.Name = "totale"
        Me.totale.ReadOnly = True
        Me.totale.Width = 60
        '
        'frm_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 481)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpdetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Kardex"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARDEX"
        Me.TopMost = True
        Me.grpdetalle.ResumeLayout(False)
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtbodega As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtresponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmaxima As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents txtminima As System.Windows.Forms.TextBox
    Friend WithEvents txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsubgrupo As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarBodega As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtactual As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmetodo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents BtnMas As System.Windows.Forms.Button
    Friend WithEvents BtnMenos As System.Windows.Forms.Button
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents fechak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cantm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totale As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
