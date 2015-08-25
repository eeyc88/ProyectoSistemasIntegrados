<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cons_kardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cons_kardex))
        Me.inventario = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.grpfecha = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.btn_bodega = New System.Windows.Forms.Button
        Me.btn_producto = New System.Windows.Forms.Button
        Me.txt_bodega = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_producto = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_mostrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.costo = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.inventario.SuspendLayout()
        Me.grpfecha.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.costo.SuspendLayout()
        Me.SuspendLayout()
        '
        'inventario
        '
        Me.inventario.Controls.Add(Me.CheckBox1)
        Me.inventario.Controls.Add(Me.grpfecha)
        Me.inventario.Controls.Add(Me.txt_descripcion)
        Me.inventario.Controls.Add(Me.btn_bodega)
        Me.inventario.Controls.Add(Me.btn_producto)
        Me.inventario.Controls.Add(Me.txt_bodega)
        Me.inventario.Controls.Add(Me.Label4)
        Me.inventario.Controls.Add(Me.txt_producto)
        Me.inventario.Controls.Add(Me.txt_codigo)
        Me.inventario.Controls.Add(Me.Label2)
        Me.inventario.Enabled = False
        Me.inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventario.ForeColor = System.Drawing.Color.OliveDrab
        Me.inventario.Location = New System.Drawing.Point(8, 23)
        Me.inventario.Name = "inventario"
        Me.inventario.Size = New System.Drawing.Size(327, 176)
        Me.inventario.TabIndex = 3
        Me.inventario.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 87)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(221, 17)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "FILTRAR POR RANGO DE FECHA"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpfecha
        '
        Me.grpfecha.Controls.Add(Me.Label7)
        Me.grpfecha.Controls.Add(Me.dtp_desde)
        Me.grpfecha.Controls.Add(Me.Label1)
        Me.grpfecha.Controls.Add(Me.dtp_hasta)
        Me.grpfecha.Enabled = False
        Me.grpfecha.ForeColor = System.Drawing.Color.OliveDrab
        Me.grpfecha.Location = New System.Drawing.Point(10, 103)
        Me.grpfecha.Name = "grpfecha"
        Me.grpfecha.Size = New System.Drawing.Size(310, 64)
        Me.grpfecha.TabIndex = 35
        Me.grpfecha.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Desde :"
        '
        'dtp_desde
        '
        Me.dtp_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(15, 35)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(112, 20)
        Me.dtp_desde.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta :"
        '
        'dtp_hasta
        '
        Me.dtp_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_hasta.Location = New System.Drawing.Point(187, 38)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(102, 20)
        Me.dtp_hasta.TabIndex = 33
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(181, 56)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(103, 20)
        Me.txt_descripcion.TabIndex = 24
        '
        'btn_bodega
        '
        Me.btn_bodega.Image = CType(resources.GetObject("btn_bodega.Image"), System.Drawing.Image)
        Me.btn_bodega.Location = New System.Drawing.Point(147, 55)
        Me.btn_bodega.Name = "btn_bodega"
        Me.btn_bodega.Size = New System.Drawing.Size(25, 25)
        Me.btn_bodega.TabIndex = 23
        Me.btn_bodega.UseVisualStyleBackColor = True
        '
        'btn_producto
        '
        Me.btn_producto.Image = CType(resources.GetObject("btn_producto.Image"), System.Drawing.Image)
        Me.btn_producto.Location = New System.Drawing.Point(147, 24)
        Me.btn_producto.Name = "btn_producto"
        Me.btn_producto.Size = New System.Drawing.Size(25, 25)
        Me.btn_producto.TabIndex = 22
        Me.btn_producto.UseVisualStyleBackColor = True
        '
        'txt_bodega
        '
        Me.txt_bodega.Enabled = False
        Me.txt_bodega.Location = New System.Drawing.Point(83, 60)
        Me.txt_bodega.Name = "txt_bodega"
        Me.txt_bodega.Size = New System.Drawing.Size(57, 20)
        Me.txt_bodega.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bodega:"
        '
        'txt_producto
        '
        Me.txt_producto.Enabled = False
        Me.txt_producto.Location = New System.Drawing.Point(179, 30)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(103, 20)
        Me.txt_producto.TabIndex = 13
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Location = New System.Drawing.Point(84, 28)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(56, 20)
        Me.txt_codigo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Producto:"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(8, 77)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(61, 54)
        Me.btn_salir.TabIndex = 27
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar.Image = CType(resources.GetObject("btn_mostrar.Image"), System.Drawing.Image)
        Me.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_mostrar.Location = New System.Drawing.Point(6, 17)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(61, 54)
        Me.btn_mostrar.TabIndex = 26
        Me.btn_mostrar.Text = "Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.btn_mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_mostrar)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(72, 143)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'costo
        '
        Me.costo.Controls.Add(Me.TextBox1)
        Me.costo.Controls.Add(Me.Button1)
        Me.costo.Controls.Add(Me.TextBox2)
        Me.costo.Controls.Add(Me.Label3)
        Me.costo.Enabled = False
        Me.costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costo.ForeColor = System.Drawing.Color.OliveDrab
        Me.costo.Location = New System.Drawing.Point(8, 229)
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(327, 50)
        Me.costo.TabIndex = 29
        Me.costo.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.OliveDrab
        Me.CheckBox2.Location = New System.Drawing.Point(25, 12)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(194, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "REPORTE DE INVENTARIOS"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.OliveDrab
        Me.CheckBox3.Location = New System.Drawing.Point(25, 206)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(213, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "COSTO TOTAL DE INVENTARIO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(168, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(134, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(70, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(57, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Bodega:"
        '
        'frm_cons_kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(434, 289)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.inventario)
        Me.Controls.Add(Me.CheckBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cons_kardex"
        Me.Text = "Consulta_Kardex"
        Me.inventario.ResumeLayout(False)
        Me.inventario.PerformLayout()
        Me.grpfecha.ResumeLayout(False)
        Me.grpfecha.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.costo.ResumeLayout(False)
        Me.costo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inventario As System.Windows.Forms.GroupBox
    Friend WithEvents txt_bodega As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_producto As System.Windows.Forms.Button
    Friend WithEvents btn_bodega As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpfecha As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents costo As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
