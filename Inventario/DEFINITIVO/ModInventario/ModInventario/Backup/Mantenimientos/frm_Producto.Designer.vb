<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Producto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckb_iva = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.ckb_estado = New System.Windows.Forms.CheckBox
        Me.btn_buscarCodigo = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_nombresubgrupo = New System.Windows.Forms.TextBox
        Me.btn_buscasubgrupo = New System.Windows.Forms.Button
        Me.txt_codigosubgrupo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_nombregrupo = New System.Windows.Forms.TextBox
        Me.btn_BuscarGrupo = New System.Windows.Forms.Button
        Me.txt_codigogrupo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_presentacion = New System.Windows.Forms.TextBox
        Me.txt_observacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_nombremarca = New System.Windows.Forms.TextBox
        Me.btn_BuscarMarca = New System.Windows.Forms.Button
        Me.txt_codigomarca = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckb_iva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.ckb_estado)
        Me.GroupBox1.Controls.Add(Me.btn_buscarCodigo)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txt_presentacion)
        Me.GroupBox1.Controls.Add(Me.txt_observacion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_nombremarca)
        Me.GroupBox1.Controls.Add(Me.btn_BuscarMarca)
        Me.GroupBox1.Controls.Add(Me.txt_codigomarca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'ckb_iva
        '
        Me.ckb_iva.AutoSize = True
        Me.ckb_iva.Enabled = False
        Me.ckb_iva.Location = New System.Drawing.Point(70, 318)
        Me.ckb_iva.Name = "ckb_iva"
        Me.ckb_iva.Size = New System.Drawing.Size(37, 17)
        Me.ckb_iva.TabIndex = 30
        Me.ckb_iva.Text = "Si"
        Me.ckb_iva.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "I.V.A. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Estado :"
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(105, 24)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(111, 20)
        Me.txt_codigo.TabIndex = 1
        '
        'ckb_estado
        '
        Me.ckb_estado.AutoSize = True
        Me.ckb_estado.Enabled = False
        Me.ckb_estado.Location = New System.Drawing.Point(215, 318)
        Me.ckb_estado.Name = "ckb_estado"
        Me.ckb_estado.Size = New System.Drawing.Size(62, 17)
        Me.ckb_estado.TabIndex = 1
        Me.ckb_estado.Text = "Activo"
        Me.ckb_estado.UseVisualStyleBackColor = True
        '
        'btn_buscarCodigo
        '
        Me.btn_buscarCodigo.Image = CType(resources.GetObject("btn_buscarCodigo.Image"), System.Drawing.Image)
        Me.btn_buscarCodigo.Location = New System.Drawing.Point(222, 19)
        Me.btn_buscarCodigo.Name = "btn_buscarCodigo"
        Me.btn_buscarCodigo.Size = New System.Drawing.Size(30, 25)
        Me.btn_buscarCodigo.TabIndex = 15
        Me.btn_buscarCodigo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_nombresubgrupo)
        Me.GroupBox3.Controls.Add(Me.btn_buscasubgrupo)
        Me.GroupBox3.Controls.Add(Me.txt_codigosubgrupo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_nombregrupo)
        Me.GroupBox3.Controls.Add(Me.btn_BuscarGrupo)
        Me.GroupBox3.Controls.Add(Me.txt_codigogrupo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 92)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clasificación"
        '
        'txt_nombresubgrupo
        '
        Me.txt_nombresubgrupo.Enabled = False
        Me.txt_nombresubgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombresubgrupo.Location = New System.Drawing.Point(183, 54)
        Me.txt_nombresubgrupo.Name = "txt_nombresubgrupo"
        Me.txt_nombresubgrupo.Size = New System.Drawing.Size(96, 20)
        Me.txt_nombresubgrupo.TabIndex = 33
        '
        'btn_buscasubgrupo
        '
        Me.btn_buscasubgrupo.Image = CType(resources.GetObject("btn_buscasubgrupo.Image"), System.Drawing.Image)
        Me.btn_buscasubgrupo.Location = New System.Drawing.Point(150, 51)
        Me.btn_buscasubgrupo.Name = "btn_buscasubgrupo"
        Me.btn_buscasubgrupo.Size = New System.Drawing.Size(30, 25)
        Me.btn_buscasubgrupo.TabIndex = 32
        Me.btn_buscasubgrupo.UseVisualStyleBackColor = True
        '
        'txt_codigosubgrupo
        '
        Me.txt_codigosubgrupo.Enabled = False
        Me.txt_codigosubgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigosubgrupo.Location = New System.Drawing.Point(99, 57)
        Me.txt_codigosubgrupo.Name = "txt_codigosubgrupo"
        Me.txt_codigosubgrupo.Size = New System.Drawing.Size(45, 20)
        Me.txt_codigosubgrupo.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Sub - Grupo :"
        '
        'txt_nombregrupo
        '
        Me.txt_nombregrupo.Enabled = False
        Me.txt_nombregrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombregrupo.Location = New System.Drawing.Point(183, 23)
        Me.txt_nombregrupo.Name = "txt_nombregrupo"
        Me.txt_nombregrupo.Size = New System.Drawing.Size(96, 20)
        Me.txt_nombregrupo.TabIndex = 29
        '
        'btn_BuscarGrupo
        '
        Me.btn_BuscarGrupo.Image = CType(resources.GetObject("btn_BuscarGrupo.Image"), System.Drawing.Image)
        Me.btn_BuscarGrupo.Location = New System.Drawing.Point(149, 20)
        Me.btn_BuscarGrupo.Name = "btn_BuscarGrupo"
        Me.btn_BuscarGrupo.Size = New System.Drawing.Size(30, 25)
        Me.btn_BuscarGrupo.TabIndex = 28
        Me.btn_BuscarGrupo.UseVisualStyleBackColor = True
        '
        'txt_codigogrupo
        '
        Me.txt_codigogrupo.Enabled = False
        Me.txt_codigogrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigogrupo.Location = New System.Drawing.Point(99, 26)
        Me.txt_codigogrupo.Name = "txt_codigogrupo"
        Me.txt_codigogrupo.Size = New System.Drawing.Size(45, 20)
        Me.txt_codigogrupo.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Grupo :"
        '
        'txt_presentacion
        '
        Me.txt_presentacion.Enabled = False
        Me.txt_presentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_presentacion.Location = New System.Drawing.Point(104, 80)
        Me.txt_presentacion.Name = "txt_presentacion"
        Me.txt_presentacion.Size = New System.Drawing.Size(180, 20)
        Me.txt_presentacion.TabIndex = 28
        '
        'txt_observacion
        '
        Me.txt_observacion.Enabled = False
        Me.txt_observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observacion.Location = New System.Drawing.Point(100, 243)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observacion.Size = New System.Drawing.Size(179, 58)
        Me.txt_observacion.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Observación :"
        '
        'txt_nombremarca
        '
        Me.txt_nombremarca.Enabled = False
        Me.txt_nombremarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombremarca.Location = New System.Drawing.Point(195, 107)
        Me.txt_nombremarca.Name = "txt_nombremarca"
        Me.txt_nombremarca.Size = New System.Drawing.Size(87, 20)
        Me.txt_nombremarca.TabIndex = 25
        '
        'btn_BuscarMarca
        '
        Me.btn_BuscarMarca.Image = CType(resources.GetObject("btn_BuscarMarca.Image"), System.Drawing.Image)
        Me.btn_BuscarMarca.Location = New System.Drawing.Point(159, 107)
        Me.btn_BuscarMarca.Name = "btn_BuscarMarca"
        Me.btn_BuscarMarca.Size = New System.Drawing.Size(30, 25)
        Me.btn_BuscarMarca.TabIndex = 24
        Me.btn_BuscarMarca.UseVisualStyleBackColor = True
        '
        'txt_codigomarca
        '
        Me.txt_codigomarca.Enabled = False
        Me.txt_codigomarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigomarca.Location = New System.Drawing.Point(105, 110)
        Me.txt_codigomarca.Name = "txt_codigomarca"
        Me.txt_codigomarca.Size = New System.Drawing.Size(48, 20)
        Me.txt_codigomarca.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Marca :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Presentación :"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(103, 52)
        Me.txt_nombre.Multiline = True
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(179, 20)
        Me.txt_nombre.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre  :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_modificar)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(71, 280)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(6, 220)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(61, 54)
        Me.btn_salir.TabIndex = 19
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(6, 8)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 54)
        Me.btn_nuevo.TabIndex = 15
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(6, 167)
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
        Me.btn_grabar.Location = New System.Drawing.Point(6, 61)
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
        Me.btn_modificar.Location = New System.Drawing.Point(6, 114)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(61, 54)
        Me.btn_modificar.TabIndex = 17
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'frm_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 358)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarCodigo As System.Windows.Forms.Button
    Friend WithEvents txt_presentacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombremarca As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarMarca As System.Windows.Forms.Button
    Friend WithEvents txt_codigomarca As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_nombregrupo As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents txt_codigogrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ckb_estado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents ckb_iva As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombresubgrupo As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscasubgrupo As System.Windows.Forms.Button
    Friend WithEvents txt_codigosubgrupo As System.Windows.Forms.TextBox
End Class
