<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvExistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvExistencia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnMostrar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnQuitProd = New System.Windows.Forms.Button
        Me.BtnAddProd = New System.Windows.Forms.Button
        Me.Lstproducto = New System.Windows.Forms.ListBox
        Me.RdbProdEspe = New System.Windows.Forms.RadioButton
        Me.rdbProdGen = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RdbTodos = New System.Windows.Forms.RadioButton
        Me.RdbMax = New System.Windows.Forms.RadioButton
        Me.RdbMin = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnQuitBod = New System.Windows.Forms.Button
        Me.BtnAddBod = New System.Windows.Forms.Button
        Me.Lstbodega = New System.Windows.Forms.ListBox
        Me.RdbBodEspe = New System.Windows.Forms.RadioButton
        Me.RdbbodGen = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnQuitGrupo = New System.Windows.Forms.Button
        Me.BtnAddGrupo = New System.Windows.Forms.Button
        Me.LstGrupo = New System.Windows.Forms.ListBox
        Me.RdbGrupEspe = New System.Windows.Forms.RadioButton
        Me.RdbGrupGen = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Image = CType(resources.GetObject("BtnMostrar.Image"), System.Drawing.Image)
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMostrar.Location = New System.Drawing.Point(5, 15)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(61, 61)
        Me.BtnMostrar.TabIndex = 24
        Me.BtnMostrar.Text = "Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(72, 19)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(61, 54)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnQuitProd)
        Me.GroupBox3.Controls.Add(Me.BtnAddProd)
        Me.GroupBox3.Controls.Add(Me.Lstproducto)
        Me.GroupBox3.Controls.Add(Me.RdbProdEspe)
        Me.GroupBox3.Controls.Add(Me.rdbProdGen)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 104)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criterio: Producto"
        '
        'BtnQuitProd
        '
        Me.BtnQuitProd.Image = CType(resources.GetObject("BtnQuitProd.Image"), System.Drawing.Image)
        Me.BtnQuitProd.Location = New System.Drawing.Point(286, 52)
        Me.BtnQuitProd.Name = "BtnQuitProd"
        Me.BtnQuitProd.Size = New System.Drawing.Size(34, 32)
        Me.BtnQuitProd.TabIndex = 48
        Me.BtnQuitProd.UseVisualStyleBackColor = True
        '
        'BtnAddProd
        '
        Me.BtnAddProd.Image = CType(resources.GetObject("BtnAddProd.Image"), System.Drawing.Image)
        Me.BtnAddProd.Location = New System.Drawing.Point(286, 20)
        Me.BtnAddProd.Name = "BtnAddProd"
        Me.BtnAddProd.Size = New System.Drawing.Size(34, 32)
        Me.BtnAddProd.TabIndex = 47
        Me.BtnAddProd.UseVisualStyleBackColor = True
        '
        'Lstproducto
        '
        Me.Lstproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstproducto.FormattingEnabled = True
        Me.Lstproducto.Location = New System.Drawing.Point(124, 14)
        Me.Lstproducto.Name = "Lstproducto"
        Me.Lstproducto.Size = New System.Drawing.Size(156, 82)
        Me.Lstproducto.TabIndex = 46
        '
        'RdbProdEspe
        '
        Me.RdbProdEspe.AutoSize = True
        Me.RdbProdEspe.Location = New System.Drawing.Point(16, 56)
        Me.RdbProdEspe.Name = "RdbProdEspe"
        Me.RdbProdEspe.Size = New System.Drawing.Size(77, 17)
        Me.RdbProdEspe.TabIndex = 26
        Me.RdbProdEspe.Text = "Especificar"
        Me.RdbProdEspe.UseVisualStyleBackColor = True
        '
        'rdbProdGen
        '
        Me.rdbProdGen.AutoSize = True
        Me.rdbProdGen.Checked = True
        Me.rdbProdGen.Location = New System.Drawing.Point(17, 24)
        Me.rdbProdGen.Name = "rdbProdGen"
        Me.rdbProdGen.Size = New System.Drawing.Size(55, 17)
        Me.rdbProdGen.TabIndex = 25
        Me.rdbProdGen.TabStop = True
        Me.rdbProdGen.Text = "Todos"
        Me.rdbProdGen.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RdbTodos)
        Me.GroupBox4.Controls.Add(Me.RdbMax)
        Me.GroupBox4.Controls.Add(Me.RdbMin)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 81)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Presentar:"
        '
        'RdbTodos
        '
        Me.RdbTodos.AutoSize = True
        Me.RdbTodos.Checked = True
        Me.RdbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbTodos.Location = New System.Drawing.Point(6, 13)
        Me.RdbTodos.Name = "RdbTodos"
        Me.RdbTodos.Size = New System.Drawing.Size(64, 19)
        Me.RdbTodos.TabIndex = 23
        Me.RdbTodos.TabStop = True
        Me.RdbTodos.Text = "Todos"
        Me.RdbTodos.UseVisualStyleBackColor = True
        '
        'RdbMax
        '
        Me.RdbMax.AutoSize = True
        Me.RdbMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMax.Location = New System.Drawing.Point(4, 57)
        Me.RdbMax.Name = "RdbMax"
        Me.RdbMax.Size = New System.Drawing.Size(179, 17)
        Me.RdbMax.TabIndex = 22
        Me.RdbMax.Text = "Productos Sobre el Máximo"
        Me.RdbMax.UseVisualStyleBackColor = True
        '
        'RdbMin
        '
        Me.RdbMin.AutoSize = True
        Me.RdbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMin.Location = New System.Drawing.Point(6, 34)
        Me.RdbMin.Name = "RdbMin"
        Me.RdbMin.Size = New System.Drawing.Size(170, 17)
        Me.RdbMin.TabIndex = 21
        Me.RdbMin.Text = "Productos Bajo el Mínimo"
        Me.RdbMin.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnQuitBod)
        Me.GroupBox2.Controls.Add(Me.BtnAddBod)
        Me.GroupBox2.Controls.Add(Me.Lstbodega)
        Me.GroupBox2.Controls.Add(Me.RdbBodEspe)
        Me.GroupBox2.Controls.Add(Me.RdbbodGen)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 104)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterio: Bodega"
        '
        'BtnQuitBod
        '
        Me.BtnQuitBod.Image = CType(resources.GetObject("BtnQuitBod.Image"), System.Drawing.Image)
        Me.BtnQuitBod.Location = New System.Drawing.Point(286, 52)
        Me.BtnQuitBod.Name = "BtnQuitBod"
        Me.BtnQuitBod.Size = New System.Drawing.Size(34, 32)
        Me.BtnQuitBod.TabIndex = 48
        Me.BtnQuitBod.UseVisualStyleBackColor = True
        '
        'BtnAddBod
        '
        Me.BtnAddBod.Image = CType(resources.GetObject("BtnAddBod.Image"), System.Drawing.Image)
        Me.BtnAddBod.Location = New System.Drawing.Point(286, 20)
        Me.BtnAddBod.Name = "BtnAddBod"
        Me.BtnAddBod.Size = New System.Drawing.Size(34, 32)
        Me.BtnAddBod.TabIndex = 47
        Me.BtnAddBod.UseVisualStyleBackColor = True
        '
        'Lstbodega
        '
        Me.Lstbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstbodega.FormattingEnabled = True
        Me.Lstbodega.Location = New System.Drawing.Point(124, 14)
        Me.Lstbodega.Name = "Lstbodega"
        Me.Lstbodega.Size = New System.Drawing.Size(156, 82)
        Me.Lstbodega.TabIndex = 46
        '
        'RdbBodEspe
        '
        Me.RdbBodEspe.AutoSize = True
        Me.RdbBodEspe.Location = New System.Drawing.Point(16, 56)
        Me.RdbBodEspe.Name = "RdbBodEspe"
        Me.RdbBodEspe.Size = New System.Drawing.Size(77, 17)
        Me.RdbBodEspe.TabIndex = 26
        Me.RdbBodEspe.Text = "Especificar"
        Me.RdbBodEspe.UseVisualStyleBackColor = True
        '
        'RdbbodGen
        '
        Me.RdbbodGen.AutoSize = True
        Me.RdbbodGen.Checked = True
        Me.RdbbodGen.Location = New System.Drawing.Point(17, 24)
        Me.RdbbodGen.Name = "RdbbodGen"
        Me.RdbbodGen.Size = New System.Drawing.Size(55, 17)
        Me.RdbbodGen.TabIndex = 25
        Me.RdbbodGen.TabStop = True
        Me.RdbbodGen.Text = "Todos"
        Me.RdbbodGen.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnQuitGrupo)
        Me.GroupBox5.Controls.Add(Me.BtnAddGrupo)
        Me.GroupBox5.Controls.Add(Me.LstGrupo)
        Me.GroupBox5.Controls.Add(Me.RdbGrupEspe)
        Me.GroupBox5.Controls.Add(Me.RdbGrupGen)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(326, 104)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Criterio: Grupo"
        '
        'BtnQuitGrupo
        '
        Me.BtnQuitGrupo.Image = CType(resources.GetObject("BtnQuitGrupo.Image"), System.Drawing.Image)
        Me.BtnQuitGrupo.Location = New System.Drawing.Point(287, 52)
        Me.BtnQuitGrupo.Name = "BtnQuitGrupo"
        Me.BtnQuitGrupo.Size = New System.Drawing.Size(34, 32)
        Me.BtnQuitGrupo.TabIndex = 48
        Me.BtnQuitGrupo.UseVisualStyleBackColor = True
        '
        'BtnAddGrupo
        '
        Me.BtnAddGrupo.Image = CType(resources.GetObject("BtnAddGrupo.Image"), System.Drawing.Image)
        Me.BtnAddGrupo.Location = New System.Drawing.Point(287, 20)
        Me.BtnAddGrupo.Name = "BtnAddGrupo"
        Me.BtnAddGrupo.Size = New System.Drawing.Size(34, 32)
        Me.BtnAddGrupo.TabIndex = 47
        Me.BtnAddGrupo.UseVisualStyleBackColor = True
        '
        'LstGrupo
        '
        Me.LstGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstGrupo.FormattingEnabled = True
        Me.LstGrupo.Location = New System.Drawing.Point(125, 14)
        Me.LstGrupo.Name = "LstGrupo"
        Me.LstGrupo.Size = New System.Drawing.Size(156, 82)
        Me.LstGrupo.TabIndex = 46
        '
        'RdbGrupEspe
        '
        Me.RdbGrupEspe.AutoSize = True
        Me.RdbGrupEspe.Location = New System.Drawing.Point(17, 56)
        Me.RdbGrupEspe.Name = "RdbGrupEspe"
        Me.RdbGrupEspe.Size = New System.Drawing.Size(77, 17)
        Me.RdbGrupEspe.TabIndex = 26
        Me.RdbGrupEspe.Text = "Especificar"
        Me.RdbGrupEspe.UseVisualStyleBackColor = True
        '
        'RdbGrupGen
        '
        Me.RdbGrupGen.AutoSize = True
        Me.RdbGrupGen.Checked = True
        Me.RdbGrupGen.Location = New System.Drawing.Point(18, 24)
        Me.RdbGrupGen.Name = "RdbGrupGen"
        Me.RdbGrupGen.Size = New System.Drawing.Size(55, 17)
        Me.RdbGrupGen.TabIndex = 25
        Me.RdbGrupGen.TabStop = True
        Me.RdbGrupGen.Text = "Todos"
        Me.RdbGrupGen.UseVisualStyleBackColor = True
        '
        'FrmInvExistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 415)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInvExistencia"
        Me.Text = "Reporte de Existencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbMax As System.Windows.Forms.RadioButton
    Friend WithEvents RdbMin As System.Windows.Forms.RadioButton
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents RdbProdEspe As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProdGen As System.Windows.Forms.RadioButton
    Friend WithEvents BtnQuitProd As System.Windows.Forms.Button
    Friend WithEvents BtnAddProd As System.Windows.Forms.Button
    Friend WithEvents Lstproducto As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitBod As System.Windows.Forms.Button
    Friend WithEvents BtnAddBod As System.Windows.Forms.Button
    Friend WithEvents Lstbodega As System.Windows.Forms.ListBox
    Friend WithEvents RdbBodEspe As System.Windows.Forms.RadioButton
    Friend WithEvents RdbbodGen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitGrupo As System.Windows.Forms.Button
    Friend WithEvents BtnAddGrupo As System.Windows.Forms.Button
    Friend WithEvents LstGrupo As System.Windows.Forms.ListBox
    Friend WithEvents RdbGrupEspe As System.Windows.Forms.RadioButton
    Friend WithEvents RdbGrupGen As System.Windows.Forms.RadioButton
    Friend WithEvents RdbTodos As System.Windows.Forms.RadioButton
End Class
