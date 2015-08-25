<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Parametros
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Parametros))
        Me.tbc_parametros = New System.Windows.Forms.TabControl
        Me.tbp_marca = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btn_salirM = New System.Windows.Forms.Button
        Me.btn_nuevoM = New System.Windows.Forms.Button
        Me.btn_eliminarM = New System.Windows.Forms.Button
        Me.btn_grabarM = New System.Windows.Forms.Button
        Me.btn_modificarM = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_buscarCodigo = New System.Windows.Forms.Button
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbp_grupo = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_nuevoG = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.gpb_datosgrupo = New System.Windows.Forms.GroupBox
        Me.gpb_subgrupo = New System.Windows.Forms.GroupBox
        Me.dgv_subgrupo = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EliminarSubgrupo = New System.Windows.Forms.DataGridViewButtonColumn
        Me.TBLINVSUBGRUPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBGRUPODataSet = New OrdenPedido.SUBGRUPODataSet
        Me.txt_subgrupo = New System.Windows.Forms.TextBox
        Me.btn_quitar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_buscarG = New System.Windows.Forms.Button
        Me.txt_codigoG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbp_ciudad = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btn_salirC = New System.Windows.Forms.Button
        Me.btn_nuevoC = New System.Windows.Forms.Button
        Me.btn_eliminarC = New System.Windows.Forms.Button
        Me.btn_grabarC = New System.Windows.Forms.Button
        Me.btn_modificarC = New System.Windows.Forms.Button
        Me.gpb_ciudad = New System.Windows.Forms.GroupBox
        Me.gpb_zona = New System.Windows.Forms.GroupBox
        Me.dgv_zona = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EliminarZona = New System.Windows.Forms.DataGridViewButtonColumn
        Me.TBLINVZONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZONADataSet = New OrdenPedido.ZONADataSet
        Me.txt_nombreC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_buscarCiudad = New System.Windows.Forms.Button
        Me.txt_codigoC = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TBL_INV_SUBGRUPOTableAdapter = New OrdenPedido.SUBGRUPODataSetTableAdapters.TBL_INV_SUBGRUPOTableAdapter
        Me.TBL_INV_ZONATableAdapter = New OrdenPedido.ZONADataSetTableAdapters.TBL_INV_ZONATableAdapter
        Me.tbc_parametros.SuspendLayout()
        Me.tbp_marca.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbp_grupo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gpb_datosgrupo.SuspendLayout()
        Me.gpb_subgrupo.SuspendLayout()
        CType(Me.dgv_subgrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLINVSUBGRUPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBGRUPODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_ciudad.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gpb_ciudad.SuspendLayout()
        Me.gpb_zona.SuspendLayout()
        CType(Me.dgv_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLINVZONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZONADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc_parametros
        '
        Me.tbc_parametros.Controls.Add(Me.tbp_marca)
        Me.tbc_parametros.Controls.Add(Me.tbp_grupo)
        Me.tbc_parametros.Controls.Add(Me.tbp_ciudad)
        Me.tbc_parametros.Location = New System.Drawing.Point(5, 9)
        Me.tbc_parametros.Name = "tbc_parametros"
        Me.tbc_parametros.SelectedIndex = 0
        Me.tbc_parametros.Size = New System.Drawing.Size(455, 317)
        Me.tbc_parametros.TabIndex = 0
        '
        'tbp_marca
        '
        Me.tbp_marca.Controls.Add(Me.GroupBox5)
        Me.tbp_marca.Controls.Add(Me.GroupBox1)
        Me.tbp_marca.Location = New System.Drawing.Point(4, 22)
        Me.tbp_marca.Name = "tbp_marca"
        Me.tbp_marca.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_marca.Size = New System.Drawing.Size(447, 291)
        Me.tbp_marca.TabIndex = 0
        Me.tbp_marca.Text = "Marca"
        Me.tbp_marca.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_salirM)
        Me.GroupBox5.Controls.Add(Me.btn_nuevoM)
        Me.GroupBox5.Controls.Add(Me.btn_eliminarM)
        Me.GroupBox5.Controls.Add(Me.btn_grabarM)
        Me.GroupBox5.Controls.Add(Me.btn_modificarM)
        Me.GroupBox5.Location = New System.Drawing.Point(365, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 291)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        '
        'btn_salirM
        '
        Me.btn_salirM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salirM.Image = CType(resources.GetObject("btn_salirM.Image"), System.Drawing.Image)
        Me.btn_salirM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salirM.Location = New System.Drawing.Point(5, 227)
        Me.btn_salirM.Name = "btn_salirM"
        Me.btn_salirM.Size = New System.Drawing.Size(61, 54)
        Me.btn_salirM.TabIndex = 19
        Me.btn_salirM.Text = "&Salir"
        Me.btn_salirM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salirM.UseVisualStyleBackColor = True
        '
        'btn_nuevoM
        '
        Me.btn_nuevoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevoM.Image = CType(resources.GetObject("btn_nuevoM.Image"), System.Drawing.Image)
        Me.btn_nuevoM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevoM.Location = New System.Drawing.Point(6, 10)
        Me.btn_nuevoM.Name = "btn_nuevoM"
        Me.btn_nuevoM.Size = New System.Drawing.Size(61, 54)
        Me.btn_nuevoM.TabIndex = 15
        Me.btn_nuevoM.Text = "&Nuevo"
        Me.btn_nuevoM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevoM.UseVisualStyleBackColor = True
        '
        'btn_eliminarM
        '
        Me.btn_eliminarM.Enabled = False
        Me.btn_eliminarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarM.Image = CType(resources.GetObject("btn_eliminarM.Image"), System.Drawing.Image)
        Me.btn_eliminarM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminarM.Location = New System.Drawing.Point(6, 171)
        Me.btn_eliminarM.Name = "btn_eliminarM"
        Me.btn_eliminarM.Size = New System.Drawing.Size(61, 54)
        Me.btn_eliminarM.TabIndex = 18
        Me.btn_eliminarM.Text = "&Eliminar"
        Me.btn_eliminarM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminarM.UseVisualStyleBackColor = True
        '
        'btn_grabarM
        '
        Me.btn_grabarM.Enabled = False
        Me.btn_grabarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabarM.Image = CType(resources.GetObject("btn_grabarM.Image"), System.Drawing.Image)
        Me.btn_grabarM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabarM.Location = New System.Drawing.Point(6, 64)
        Me.btn_grabarM.Name = "btn_grabarM"
        Me.btn_grabarM.Size = New System.Drawing.Size(61, 54)
        Me.btn_grabarM.TabIndex = 16
        Me.btn_grabarM.Text = "&Grabar"
        Me.btn_grabarM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabarM.UseVisualStyleBackColor = True
        '
        'btn_modificarM
        '
        Me.btn_modificarM.Enabled = False
        Me.btn_modificarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificarM.Image = CType(resources.GetObject("btn_modificarM.Image"), System.Drawing.Image)
        Me.btn_modificarM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_modificarM.Location = New System.Drawing.Point(6, 118)
        Me.btn_modificarM.Name = "btn_modificarM"
        Me.btn_modificarM.Size = New System.Drawing.Size(61, 54)
        Me.btn_modificarM.TabIndex = 17
        Me.btn_modificarM.Text = "&Modificar"
        Me.btn_modificarM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificarM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_buscarCodigo)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(107, 72)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(200, 20)
        Me.txt_descripcion.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Descripción :"
        '
        'btn_buscarCodigo
        '
        Me.btn_buscarCodigo.Image = CType(resources.GetObject("btn_buscarCodigo.Image"), System.Drawing.Image)
        Me.btn_buscarCodigo.Location = New System.Drawing.Point(170, 20)
        Me.btn_buscarCodigo.Name = "btn_buscarCodigo"
        Me.btn_buscarCodigo.Size = New System.Drawing.Size(30, 30)
        Me.btn_buscarCodigo.TabIndex = 18
        Me.btn_buscarCodigo.UseVisualStyleBackColor = True
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(107, 30)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(57, 20)
        Me.txt_codigo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código :"
        '
        'tbp_grupo
        '
        Me.tbp_grupo.Controls.Add(Me.GroupBox3)
        Me.tbp_grupo.Controls.Add(Me.gpb_datosgrupo)
        Me.tbp_grupo.Location = New System.Drawing.Point(4, 22)
        Me.tbp_grupo.Name = "tbp_grupo"
        Me.tbp_grupo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_grupo.Size = New System.Drawing.Size(447, 291)
        Me.tbp_grupo.TabIndex = 1
        Me.tbp_grupo.Text = "Grupo - SubGrupo"
        Me.tbp_grupo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_salir)
        Me.GroupBox3.Controls.Add(Me.btn_nuevoG)
        Me.GroupBox3.Controls.Add(Me.btn_eliminar)
        Me.GroupBox3.Controls.Add(Me.btn_grabar)
        Me.GroupBox3.Controls.Add(Me.btn_modificar)
        Me.GroupBox3.Location = New System.Drawing.Point(373, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(70, 284)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(5, 227)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(61, 54)
        Me.btn_salir.TabIndex = 19
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevoG
        '
        Me.btn_nuevoG.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevoG.Image = CType(resources.GetObject("btn_nuevoG.Image"), System.Drawing.Image)
        Me.btn_nuevoG.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevoG.Location = New System.Drawing.Point(5, 9)
        Me.btn_nuevoG.Name = "btn_nuevoG"
        Me.btn_nuevoG.Size = New System.Drawing.Size(61, 54)
        Me.btn_nuevoG.TabIndex = 15
        Me.btn_nuevoG.Text = "&Nuevo"
        Me.btn_nuevoG.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevoG.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(6, 171)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(61, 54)
        Me.btn_eliminar.TabIndex = 18
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Enabled = False
        Me.btn_grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(6, 64)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(61, 54)
        Me.btn_grabar.TabIndex = 16
        Me.btn_grabar.Text = "&Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_modificar.Location = New System.Drawing.Point(6, 118)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(61, 54)
        Me.btn_modificar.TabIndex = 17
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'gpb_datosgrupo
        '
        Me.gpb_datosgrupo.Controls.Add(Me.gpb_subgrupo)
        Me.gpb_datosgrupo.Controls.Add(Me.txt_nombre)
        Me.gpb_datosgrupo.Controls.Add(Me.Label2)
        Me.gpb_datosgrupo.Controls.Add(Me.btn_buscarG)
        Me.gpb_datosgrupo.Controls.Add(Me.txt_codigoG)
        Me.gpb_datosgrupo.Controls.Add(Me.Label3)
        Me.gpb_datosgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpb_datosgrupo.Location = New System.Drawing.Point(7, 8)
        Me.gpb_datosgrupo.Name = "gpb_datosgrupo"
        Me.gpb_datosgrupo.Size = New System.Drawing.Size(362, 273)
        Me.gpb_datosgrupo.TabIndex = 1
        Me.gpb_datosgrupo.TabStop = False
        Me.gpb_datosgrupo.Text = "Datos Grupo"
        '
        'gpb_subgrupo
        '
        Me.gpb_subgrupo.Controls.Add(Me.dgv_subgrupo)
        Me.gpb_subgrupo.Controls.Add(Me.txt_subgrupo)
        Me.gpb_subgrupo.Controls.Add(Me.btn_quitar)
        Me.gpb_subgrupo.Controls.Add(Me.btn_agregar)
        Me.gpb_subgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpb_subgrupo.Location = New System.Drawing.Point(4, 74)
        Me.gpb_subgrupo.Name = "gpb_subgrupo"
        Me.gpb_subgrupo.Size = New System.Drawing.Size(352, 193)
        Me.gpb_subgrupo.TabIndex = 3
        Me.gpb_subgrupo.TabStop = False
        Me.gpb_subgrupo.Text = "Sub-Grupo"
        '
        'dgv_subgrupo
        '
        Me.dgv_subgrupo.AutoGenerateColumns = False
        Me.dgv_subgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subgrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EliminarSubgrupo})
        Me.dgv_subgrupo.DataSource = Me.TBLINVSUBGRUPOBindingSource
        Me.dgv_subgrupo.Enabled = False
        Me.dgv_subgrupo.Location = New System.Drawing.Point(6, 20)
        Me.dgv_subgrupo.Name = "dgv_subgrupo"
        Me.dgv_subgrupo.Size = New System.Drawing.Size(362, 167)
        Me.dgv_subgrupo.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 60
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'EliminarSubgrupo
        '
        Me.EliminarSubgrupo.HeaderText = "Eliminar"
        Me.EliminarSubgrupo.Name = "EliminarSubgrupo"
        Me.EliminarSubgrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EliminarSubgrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EliminarSubgrupo.Text = "Eliminar"
        Me.EliminarSubgrupo.UseColumnTextForButtonValue = True
        Me.EliminarSubgrupo.Width = 80
        '
        'TBLINVSUBGRUPOBindingSource
        '
        Me.TBLINVSUBGRUPOBindingSource.DataMember = "TBL_INV_SUBGRUPO"
        Me.TBLINVSUBGRUPOBindingSource.DataSource = Me.SUBGRUPODataSet
        '
        'SUBGRUPODataSet
        '
        Me.SUBGRUPODataSet.DataSetName = "SUBGRUPODataSet"
        Me.SUBGRUPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_subgrupo
        '
        Me.txt_subgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subgrupo.Location = New System.Drawing.Point(33, 24)
        Me.txt_subgrupo.Name = "txt_subgrupo"
        Me.txt_subgrupo.Size = New System.Drawing.Size(129, 20)
        Me.txt_subgrupo.TabIndex = 31
        '
        'btn_quitar
        '
        Me.btn_quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar.Image = CType(resources.GetObject("btn_quitar.Image"), System.Drawing.Image)
        Me.btn_quitar.Location = New System.Drawing.Point(220, 20)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(34, 32)
        Me.btn_quitar.TabIndex = 19
        Me.btn_quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(168, 20)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(34, 32)
        Me.btn_agregar.TabIndex = 18
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(149, 51)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(134, 20)
        Me.txt_nombre.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nombre :"
        '
        'btn_buscarG
        '
        Me.btn_buscarG.Image = CType(resources.GetObject("btn_buscarG.Image"), System.Drawing.Image)
        Me.btn_buscarG.Location = New System.Drawing.Point(217, 13)
        Me.btn_buscarG.Name = "btn_buscarG"
        Me.btn_buscarG.Size = New System.Drawing.Size(30, 30)
        Me.btn_buscarG.TabIndex = 18
        Me.btn_buscarG.UseVisualStyleBackColor = True
        '
        'txt_codigoG
        '
        Me.txt_codigoG.Enabled = False
        Me.txt_codigoG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigoG.Location = New System.Drawing.Point(149, 23)
        Me.txt_codigoG.Name = "txt_codigoG"
        Me.txt_codigoG.Size = New System.Drawing.Size(62, 20)
        Me.txt_codigoG.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Código :"
        '
        'tbp_ciudad
        '
        Me.tbp_ciudad.Controls.Add(Me.GroupBox6)
        Me.tbp_ciudad.Controls.Add(Me.gpb_ciudad)
        Me.tbp_ciudad.Location = New System.Drawing.Point(4, 22)
        Me.tbp_ciudad.Name = "tbp_ciudad"
        Me.tbp_ciudad.Size = New System.Drawing.Size(447, 291)
        Me.tbp_ciudad.TabIndex = 2
        Me.tbp_ciudad.Text = "Ciudad - Zona"
        Me.tbp_ciudad.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_salirC)
        Me.GroupBox6.Controls.Add(Me.btn_nuevoC)
        Me.GroupBox6.Controls.Add(Me.btn_eliminarC)
        Me.GroupBox6.Controls.Add(Me.btn_grabarC)
        Me.GroupBox6.Controls.Add(Me.btn_modificarC)
        Me.GroupBox6.Location = New System.Drawing.Point(370, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(70, 284)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'btn_salirC
        '
        Me.btn_salirC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salirC.Image = CType(resources.GetObject("btn_salirC.Image"), System.Drawing.Image)
        Me.btn_salirC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salirC.Location = New System.Drawing.Point(5, 227)
        Me.btn_salirC.Name = "btn_salirC"
        Me.btn_salirC.Size = New System.Drawing.Size(61, 54)
        Me.btn_salirC.TabIndex = 19
        Me.btn_salirC.Text = "&Salir"
        Me.btn_salirC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salirC.UseVisualStyleBackColor = True
        '
        'btn_nuevoC
        '
        Me.btn_nuevoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevoC.Image = CType(resources.GetObject("btn_nuevoC.Image"), System.Drawing.Image)
        Me.btn_nuevoC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevoC.Location = New System.Drawing.Point(5, 9)
        Me.btn_nuevoC.Name = "btn_nuevoC"
        Me.btn_nuevoC.Size = New System.Drawing.Size(61, 54)
        Me.btn_nuevoC.TabIndex = 15
        Me.btn_nuevoC.Text = "&Nuevo"
        Me.btn_nuevoC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevoC.UseVisualStyleBackColor = True
        '
        'btn_eliminarC
        '
        Me.btn_eliminarC.Enabled = False
        Me.btn_eliminarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarC.Image = CType(resources.GetObject("btn_eliminarC.Image"), System.Drawing.Image)
        Me.btn_eliminarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminarC.Location = New System.Drawing.Point(6, 171)
        Me.btn_eliminarC.Name = "btn_eliminarC"
        Me.btn_eliminarC.Size = New System.Drawing.Size(61, 54)
        Me.btn_eliminarC.TabIndex = 18
        Me.btn_eliminarC.Text = "&Eliminar"
        Me.btn_eliminarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminarC.UseVisualStyleBackColor = True
        '
        'btn_grabarC
        '
        Me.btn_grabarC.Enabled = False
        Me.btn_grabarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabarC.Image = CType(resources.GetObject("btn_grabarC.Image"), System.Drawing.Image)
        Me.btn_grabarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabarC.Location = New System.Drawing.Point(6, 64)
        Me.btn_grabarC.Name = "btn_grabarC"
        Me.btn_grabarC.Size = New System.Drawing.Size(61, 54)
        Me.btn_grabarC.TabIndex = 16
        Me.btn_grabarC.Text = "&Grabar"
        Me.btn_grabarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabarC.UseVisualStyleBackColor = True
        '
        'btn_modificarC
        '
        Me.btn_modificarC.Enabled = False
        Me.btn_modificarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificarC.Image = CType(resources.GetObject("btn_modificarC.Image"), System.Drawing.Image)
        Me.btn_modificarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_modificarC.Location = New System.Drawing.Point(6, 118)
        Me.btn_modificarC.Name = "btn_modificarC"
        Me.btn_modificarC.Size = New System.Drawing.Size(61, 54)
        Me.btn_modificarC.TabIndex = 17
        Me.btn_modificarC.Text = "&Modificar"
        Me.btn_modificarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificarC.UseVisualStyleBackColor = True
        '
        'gpb_ciudad
        '
        Me.gpb_ciudad.Controls.Add(Me.gpb_zona)
        Me.gpb_ciudad.Controls.Add(Me.txt_nombreC)
        Me.gpb_ciudad.Controls.Add(Me.Label5)
        Me.gpb_ciudad.Controls.Add(Me.btn_buscarCiudad)
        Me.gpb_ciudad.Controls.Add(Me.txt_codigoC)
        Me.gpb_ciudad.Controls.Add(Me.Label6)
        Me.gpb_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpb_ciudad.Location = New System.Drawing.Point(4, 8)
        Me.gpb_ciudad.Name = "gpb_ciudad"
        Me.gpb_ciudad.Size = New System.Drawing.Size(362, 273)
        Me.gpb_ciudad.TabIndex = 2
        Me.gpb_ciudad.TabStop = False
        Me.gpb_ciudad.Text = "Datos Ciudad"
        '
        'gpb_zona
        '
        Me.gpb_zona.Controls.Add(Me.dgv_zona)
        Me.gpb_zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpb_zona.Location = New System.Drawing.Point(4, 68)
        Me.gpb_zona.Name = "gpb_zona"
        Me.gpb_zona.Size = New System.Drawing.Size(353, 193)
        Me.gpb_zona.TabIndex = 3
        Me.gpb_zona.TabStop = False
        Me.gpb_zona.Text = "Zona"
        '
        'dgv_zona
        '
        Me.dgv_zona.AutoGenerateColumns = False
        Me.dgv_zona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_zona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn1, Me.CiudadDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.EliminarZona})
        Me.dgv_zona.DataSource = Me.TBLINVZONABindingSource
        Me.dgv_zona.Enabled = False
        Me.dgv_zona.Location = New System.Drawing.Point(6, 20)
        Me.dgv_zona.Name = "dgv_zona"
        Me.dgv_zona.Size = New System.Drawing.Size(344, 167)
        Me.dgv_zona.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn1.Width = 60
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CiudadDataGridViewTextBoxColumn.Width = 60
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'EliminarZona
        '
        Me.EliminarZona.HeaderText = "Eliminar"
        Me.EliminarZona.Name = "EliminarZona"
        Me.EliminarZona.Text = "Eliminar"
        Me.EliminarZona.UseColumnTextForButtonValue = True
        Me.EliminarZona.Width = 80
        '
        'TBLINVZONABindingSource
        '
        Me.TBLINVZONABindingSource.DataMember = "TBL_INV_ZONA"
        Me.TBLINVZONABindingSource.DataSource = Me.ZONADataSet
        '
        'ZONADataSet
        '
        Me.ZONADataSet.DataSetName = "ZONADataSet"
        Me.ZONADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_nombreC
        '
        Me.txt_nombreC.Enabled = False
        Me.txt_nombreC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreC.Location = New System.Drawing.Point(108, 51)
        Me.txt_nombreC.Name = "txt_nombreC"
        Me.txt_nombreC.Size = New System.Drawing.Size(134, 20)
        Me.txt_nombreC.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Nombre :"
        '
        'btn_buscarCiudad
        '
        Me.btn_buscarCiudad.Image = CType(resources.GetObject("btn_buscarCiudad.Image"), System.Drawing.Image)
        Me.btn_buscarCiudad.Location = New System.Drawing.Point(167, 19)
        Me.btn_buscarCiudad.Name = "btn_buscarCiudad"
        Me.btn_buscarCiudad.Size = New System.Drawing.Size(30, 30)
        Me.btn_buscarCiudad.TabIndex = 18
        Me.btn_buscarCiudad.UseVisualStyleBackColor = True
        '
        'txt_codigoC
        '
        Me.txt_codigoC.Enabled = False
        Me.txt_codigoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigoC.Location = New System.Drawing.Point(108, 26)
        Me.txt_codigoC.Name = "txt_codigoC"
        Me.txt_codigoC.Size = New System.Drawing.Size(55, 20)
        Me.txt_codigoC.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Código :"
        '
        'TBL_INV_SUBGRUPOTableAdapter
        '
        Me.TBL_INV_SUBGRUPOTableAdapter.ClearBeforeFill = True
        '
        'TBL_INV_ZONATableAdapter
        '
        Me.TBL_INV_ZONATableAdapter.ClearBeforeFill = True
        '
        'frm_Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 328)
        Me.Controls.Add(Me.tbc_parametros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Parametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros Generales"
        Me.tbc_parametros.ResumeLayout(False)
        Me.tbp_marca.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbp_grupo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gpb_datosgrupo.ResumeLayout(False)
        Me.gpb_datosgrupo.PerformLayout()
        Me.gpb_subgrupo.ResumeLayout(False)
        Me.gpb_subgrupo.PerformLayout()
        CType(Me.dgv_subgrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLINVSUBGRUPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBGRUPODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_ciudad.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.gpb_ciudad.ResumeLayout(False)
        Me.gpb_ciudad.PerformLayout()
        Me.gpb_zona.ResumeLayout(False)
        CType(Me.dgv_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLINVZONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZONADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbc_parametros As System.Windows.Forms.TabControl
    Friend WithEvents tbp_marca As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbp_grupo As System.Windows.Forms.TabPage
    Friend WithEvents btn_buscarCodigo As System.Windows.Forms.Button
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gpb_datosgrupo As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarG As System.Windows.Forms.Button
    Friend WithEvents txt_codigoG As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpb_subgrupo As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_subgrupo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoG As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salirM As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoM As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarM As System.Windows.Forms.Button
    Friend WithEvents btn_grabarM As System.Windows.Forms.Button
    Friend WithEvents btn_modificarM As System.Windows.Forms.Button
    Friend WithEvents txt_subgrupo As System.Windows.Forms.TextBox
    Friend WithEvents tbp_ciudad As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salirC As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoC As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarC As System.Windows.Forms.Button
    Friend WithEvents btn_grabarC As System.Windows.Forms.Button
    Friend WithEvents btn_modificarC As System.Windows.Forms.Button
    Friend WithEvents gpb_ciudad As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_zona As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombreC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarCiudad As System.Windows.Forms.Button
    Friend WithEvents txt_codigoC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_zona As System.Windows.Forms.DataGridView
    Friend WithEvents SUBGRUPODataSet As OrdenPedido.SUBGRUPODataSet
    Friend WithEvents TBLINVSUBGRUPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_INV_SUBGRUPOTableAdapter As OrdenPedido.SUBGRUPODataSetTableAdapters.TBL_INV_SUBGRUPOTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarSubgrupo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ZONADataSet As OrdenPedido.ZONADataSet
    Friend WithEvents TBLINVZONABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_INV_ZONATableAdapter As OrdenPedido.ZONADataSetTableAdapters.TBL_INV_ZONATableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarZona As System.Windows.Forms.DataGridViewButtonColumn
End Class
