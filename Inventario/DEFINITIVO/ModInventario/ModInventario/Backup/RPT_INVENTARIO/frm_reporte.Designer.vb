<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reporte))
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpb_clasificacion = New System.Windows.Forms.GroupBox
        Me.txt_nombregrupo = New System.Windows.Forms.TextBox
        Me.btn_BuscarGrupo = New System.Windows.Forms.Button
        Me.txt_codigogrupo = New System.Windows.Forms.TextBox
        Me.btnQuitSubgrupo = New System.Windows.Forms.Button
        Me.lstSubgrupo = New System.Windows.Forms.ListBox
        Me.btnAddSubgrupo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.gpb_general = New System.Windows.Forms.GroupBox
        Me.rdbMovimientos = New System.Windows.Forms.RadioButton
        Me.rdbProducto = New System.Windows.Forms.RadioButton
        Me.gpb_estado = New System.Windows.Forms.GroupBox
        Me.chbActivo = New System.Windows.Forms.CheckBox
        Me.btn_mostrar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.ckb_general = New System.Windows.Forms.CheckBox
        Me.ckb_filtrar = New System.Windows.Forms.CheckBox
        Me.BtnQuitBod = New System.Windows.Forms.Button
        Me.BtnAddBod = New System.Windows.Forms.Button
        Me.Lstbodega = New System.Windows.Forms.ListBox
        Me.gpbBodega = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.rdbClasificacion = New System.Windows.Forms.RadioButton
        Me.rdbEstado = New System.Windows.Forms.RadioButton
        Me.rdbBodega = New System.Windows.Forms.RadioButton
        Me.gpb_clasificacion.SuspendLayout()
        Me.gpb_general.SuspendLayout()
        Me.gpb_estado.SuspendLayout()
        Me.gpbBodega.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FILTRAR PRODUCTO POR..."
        '
        'gpb_clasificacion
        '
        Me.gpb_clasificacion.Controls.Add(Me.txt_nombregrupo)
        Me.gpb_clasificacion.Controls.Add(Me.btn_BuscarGrupo)
        Me.gpb_clasificacion.Controls.Add(Me.txt_codigogrupo)
        Me.gpb_clasificacion.Controls.Add(Me.btnQuitSubgrupo)
        Me.gpb_clasificacion.Controls.Add(Me.lstSubgrupo)
        Me.gpb_clasificacion.Controls.Add(Me.btnAddSubgrupo)
        Me.gpb_clasificacion.Controls.Add(Me.Label3)
        Me.gpb_clasificacion.Controls.Add(Me.Label4)
        Me.gpb_clasificacion.Enabled = False
        Me.gpb_clasificacion.Location = New System.Drawing.Point(12, 137)
        Me.gpb_clasificacion.Name = "gpb_clasificacion"
        Me.gpb_clasificacion.Size = New System.Drawing.Size(263, 136)
        Me.gpb_clasificacion.TabIndex = 6
        Me.gpb_clasificacion.TabStop = False
        Me.gpb_clasificacion.Text = "Clasificación"
        '
        'txt_nombregrupo
        '
        Me.txt_nombregrupo.Enabled = False
        Me.txt_nombregrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombregrupo.Location = New System.Drawing.Point(154, 19)
        Me.txt_nombregrupo.Name = "txt_nombregrupo"
        Me.txt_nombregrupo.Size = New System.Drawing.Size(96, 20)
        Me.txt_nombregrupo.TabIndex = 60
        '
        'btn_BuscarGrupo
        '
        Me.btn_BuscarGrupo.Enabled = False
        Me.btn_BuscarGrupo.Image = CType(resources.GetObject("btn_BuscarGrupo.Image"), System.Drawing.Image)
        Me.btn_BuscarGrupo.Location = New System.Drawing.Point(120, 14)
        Me.btn_BuscarGrupo.Name = "btn_BuscarGrupo"
        Me.btn_BuscarGrupo.Size = New System.Drawing.Size(30, 25)
        Me.btn_BuscarGrupo.TabIndex = 59
        Me.btn_BuscarGrupo.UseVisualStyleBackColor = True
        '
        'txt_codigogrupo
        '
        Me.txt_codigogrupo.Enabled = False
        Me.txt_codigogrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigogrupo.Location = New System.Drawing.Point(72, 19)
        Me.txt_codigogrupo.Name = "txt_codigogrupo"
        Me.txt_codigogrupo.Size = New System.Drawing.Size(45, 20)
        Me.txt_codigogrupo.TabIndex = 58
        '
        'btnQuitSubgrupo
        '
        Me.btnQuitSubgrupo.Enabled = False
        Me.btnQuitSubgrupo.Image = CType(resources.GetObject("btnQuitSubgrupo.Image"), System.Drawing.Image)
        Me.btnQuitSubgrupo.Location = New System.Drawing.Point(216, 88)
        Me.btnQuitSubgrupo.Name = "btnQuitSubgrupo"
        Me.btnQuitSubgrupo.Size = New System.Drawing.Size(34, 32)
        Me.btnQuitSubgrupo.TabIndex = 57
        Me.btnQuitSubgrupo.UseVisualStyleBackColor = True
        '
        'lstSubgrupo
        '
        Me.lstSubgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubgrupo.FormattingEnabled = True
        Me.lstSubgrupo.Location = New System.Drawing.Point(72, 51)
        Me.lstSubgrupo.Name = "lstSubgrupo"
        Me.lstSubgrupo.Size = New System.Drawing.Size(132, 69)
        Me.lstSubgrupo.TabIndex = 55
        '
        'btnAddSubgrupo
        '
        Me.btnAddSubgrupo.Enabled = False
        Me.btnAddSubgrupo.Image = CType(resources.GetObject("btnAddSubgrupo.Image"), System.Drawing.Image)
        Me.btnAddSubgrupo.Location = New System.Drawing.Point(216, 50)
        Me.btnAddSubgrupo.Name = "btnAddSubgrupo"
        Me.btnAddSubgrupo.Size = New System.Drawing.Size(34, 32)
        Me.btnAddSubgrupo.TabIndex = 56
        Me.btnAddSubgrupo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Subgrupo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Grupo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "LISTADO GENERAL"
        '
        'gpb_general
        '
        Me.gpb_general.Controls.Add(Me.rdbMovimientos)
        Me.gpb_general.Controls.Add(Me.rdbProducto)
        Me.gpb_general.Enabled = False
        Me.gpb_general.Location = New System.Drawing.Point(9, 32)
        Me.gpb_general.Name = "gpb_general"
        Me.gpb_general.Size = New System.Drawing.Size(282, 40)
        Me.gpb_general.TabIndex = 8
        Me.gpb_general.TabStop = False
        '
        'rdbMovimientos
        '
        Me.rdbMovimientos.AutoSize = True
        Me.rdbMovimientos.Location = New System.Drawing.Point(174, 14)
        Me.rdbMovimientos.Name = "rdbMovimientos"
        Me.rdbMovimientos.Size = New System.Drawing.Size(84, 17)
        Me.rdbMovimientos.TabIndex = 1
        Me.rdbMovimientos.TabStop = True
        Me.rdbMovimientos.Text = "Movimientos"
        Me.rdbMovimientos.UseVisualStyleBackColor = True
        '
        'rdbProducto
        '
        Me.rdbProducto.AutoSize = True
        Me.rdbProducto.Location = New System.Drawing.Point(18, 14)
        Me.rdbProducto.Name = "rdbProducto"
        Me.rdbProducto.Size = New System.Drawing.Size(73, 17)
        Me.rdbProducto.TabIndex = 0
        Me.rdbProducto.TabStop = True
        Me.rdbProducto.Text = "Productos"
        Me.rdbProducto.UseVisualStyleBackColor = True
        '
        'gpb_estado
        '
        Me.gpb_estado.Controls.Add(Me.chbActivo)
        Me.gpb_estado.Enabled = False
        Me.gpb_estado.Location = New System.Drawing.Point(283, 102)
        Me.gpb_estado.Name = "gpb_estado"
        Me.gpb_estado.Size = New System.Drawing.Size(206, 34)
        Me.gpb_estado.TabIndex = 10
        Me.gpb_estado.TabStop = False
        Me.gpb_estado.Text = "Estado"
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Checked = True
        Me.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbActivo.Enabled = False
        Me.chbActivo.Location = New System.Drawing.Point(91, 11)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 2
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar.Image = CType(resources.GetObject("btn_mostrar.Image"), System.Drawing.Image)
        Me.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_mostrar.Location = New System.Drawing.Point(329, 32)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(61, 54)
        Me.btn_mostrar.TabIndex = 25
        Me.btn_mostrar.Text = "Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.btn_mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(400, 32)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(61, 54)
        Me.btn_salir.TabIndex = 24
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'ckb_general
        '
        Me.ckb_general.AutoSize = True
        Me.ckb_general.Location = New System.Drawing.Point(9, 12)
        Me.ckb_general.Name = "ckb_general"
        Me.ckb_general.Size = New System.Drawing.Size(15, 14)
        Me.ckb_general.TabIndex = 26
        Me.ckb_general.UseVisualStyleBackColor = True
        '
        'ckb_filtrar
        '
        Me.ckb_filtrar.AutoSize = True
        Me.ckb_filtrar.Location = New System.Drawing.Point(6, 101)
        Me.ckb_filtrar.Name = "ckb_filtrar"
        Me.ckb_filtrar.Size = New System.Drawing.Size(15, 14)
        Me.ckb_filtrar.TabIndex = 27
        Me.ckb_filtrar.UseVisualStyleBackColor = True
        '
        'BtnQuitBod
        '
        Me.BtnQuitBod.Enabled = False
        Me.BtnQuitBod.Image = CType(resources.GetObject("BtnQuitBod.Image"), System.Drawing.Image)
        Me.BtnQuitBod.Location = New System.Drawing.Point(166, 83)
        Me.BtnQuitBod.Name = "BtnQuitBod"
        Me.BtnQuitBod.Size = New System.Drawing.Size(34, 32)
        Me.BtnQuitBod.TabIndex = 51
        Me.BtnQuitBod.UseVisualStyleBackColor = True
        '
        'BtnAddBod
        '
        Me.BtnAddBod.Enabled = False
        Me.BtnAddBod.Image = CType(resources.GetObject("BtnAddBod.Image"), System.Drawing.Image)
        Me.BtnAddBod.Location = New System.Drawing.Point(166, 46)
        Me.BtnAddBod.Name = "BtnAddBod"
        Me.BtnAddBod.Size = New System.Drawing.Size(34, 32)
        Me.BtnAddBod.TabIndex = 50
        Me.BtnAddBod.UseVisualStyleBackColor = True
        '
        'Lstbodega
        '
        Me.Lstbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstbodega.FormattingEnabled = True
        Me.Lstbodega.Location = New System.Drawing.Point(12, 46)
        Me.Lstbodega.Name = "Lstbodega"
        Me.Lstbodega.Size = New System.Drawing.Size(150, 69)
        Me.Lstbodega.TabIndex = 49
        '
        'gpbBodega
        '
        Me.gpbBodega.Controls.Add(Me.Label6)
        Me.gpbBodega.Controls.Add(Me.BtnQuitBod)
        Me.gpbBodega.Controls.Add(Me.Lstbodega)
        Me.gpbBodega.Controls.Add(Me.BtnAddBod)
        Me.gpbBodega.Enabled = False
        Me.gpbBodega.Location = New System.Drawing.Point(283, 142)
        Me.gpbBodega.Name = "gpbBodega"
        Me.gpbBodega.Size = New System.Drawing.Size(206, 131)
        Me.gpbBodega.TabIndex = 52
        Me.gpbBodega.TabStop = False
        Me.gpbBodega.Text = "Productos por Bodega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Especifique bodegas a filtrar"
        '
        'rdbClasificacion
        '
        Me.rdbClasificacion.AutoSize = True
        Me.rdbClasificacion.Location = New System.Drawing.Point(7, 137)
        Me.rdbClasificacion.Name = "rdbClasificacion"
        Me.rdbClasificacion.Size = New System.Drawing.Size(14, 13)
        Me.rdbClasificacion.TabIndex = 53
        Me.rdbClasificacion.TabStop = True
        Me.rdbClasificacion.UseVisualStyleBackColor = True
        '
        'rdbEstado
        '
        Me.rdbEstado.AutoSize = True
        Me.rdbEstado.Location = New System.Drawing.Point(276, 101)
        Me.rdbEstado.Name = "rdbEstado"
        Me.rdbEstado.Size = New System.Drawing.Size(14, 13)
        Me.rdbEstado.TabIndex = 54
        Me.rdbEstado.TabStop = True
        Me.rdbEstado.UseVisualStyleBackColor = True
        '
        'rdbBodega
        '
        Me.rdbBodega.AutoSize = True
        Me.rdbBodega.Location = New System.Drawing.Point(276, 142)
        Me.rdbBodega.Name = "rdbBodega"
        Me.rdbBodega.Size = New System.Drawing.Size(14, 13)
        Me.rdbBodega.TabIndex = 55
        Me.rdbBodega.TabStop = True
        Me.rdbBodega.UseVisualStyleBackColor = True
        '
        'frm_reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 279)
        Me.Controls.Add(Me.rdbBodega)
        Me.Controls.Add(Me.rdbEstado)
        Me.Controls.Add(Me.rdbClasificacion)
        Me.Controls.Add(Me.gpbBodega)
        Me.Controls.Add(Me.ckb_filtrar)
        Me.Controls.Add(Me.gpb_estado)
        Me.Controls.Add(Me.ckb_general)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.gpb_general)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpb_clasificacion)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos"
        Me.gpb_clasificacion.ResumeLayout(False)
        Me.gpb_clasificacion.PerformLayout()
        Me.gpb_general.ResumeLayout(False)
        Me.gpb_general.PerformLayout()
        Me.gpb_estado.ResumeLayout(False)
        Me.gpb_estado.PerformLayout()
        Me.gpbBodega.ResumeLayout(False)
        Me.gpbBodega.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpb_clasificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpb_general As System.Windows.Forms.GroupBox
    Friend WithEvents rdbProducto As System.Windows.Forms.RadioButton
    Friend WithEvents gpb_estado As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents chbActivo As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_general As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_filtrar As System.Windows.Forms.CheckBox
    Friend WithEvents BtnQuitBod As System.Windows.Forms.Button
    Friend WithEvents BtnAddBod As System.Windows.Forms.Button
    Friend WithEvents Lstbodega As System.Windows.Forms.ListBox
    Friend WithEvents gpbBodega As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMovimientos As System.Windows.Forms.RadioButton
    Friend WithEvents btnQuitSubgrupo As System.Windows.Forms.Button
    Friend WithEvents lstSubgrupo As System.Windows.Forms.ListBox
    Friend WithEvents btnAddSubgrupo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdbClasificacion As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEstado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBodega As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nombregrupo As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents txt_codigogrupo As System.Windows.Forms.TextBox
End Class
