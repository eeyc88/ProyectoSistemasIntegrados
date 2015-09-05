Public Class KardexDetalle
    Private _producto As Integer
    Private _bodega As Integer
    Private _linea As Integer
    Private _tipo_movimiento As Integer
    Private _fecha_registro As Date
    Private _cantidad As Integer
    Private _valor_unitario As Double
    Private _valor_total As Integer
    Sub New()
        Me.producto = 0
        Me.bodega = 0
        Me.linea = 0
        Me.tipo_movimiento = 0
        Me.fecha_registro = Date.Now.ToString("dd/MM/yyyy")
        Me.cantidad = 0
        Me.valor_unitario = 0
        Me.valor_total = 0
    End Sub
    Sub New(ByVal producto As Integer, ByVal bodega As Integer, ByVal linea As Integer, ByVal tipo_movimiento As Integer, _
    ByVal fecha_registro As Date, ByVal cantidad As Integer, ByVal valor_unitario As Double, ByVal valor_total As Double)
        Me.producto = producto
        Me.bodega = bodega
        Me.linea = linea
        Me.tipo_movimiento = tipo_movimiento
        Me.fecha_registro = fecha_registro
        Me.cantidad = cantidad
        Me.valor_unitario = valor_unitario
        Me.valor_total = valor_total
    End Sub
    Sub imprimir()
        Console.WriteLine(Me.producto)
        Console.WriteLine(Me.bodega)
        Console.WriteLine(Me.linea)
        Console.WriteLine(Me.tipo_movimiento)
        Console.WriteLine(Me.fecha_registro)
        Console.WriteLine(Me.cantidad)
        Console.WriteLine(Me.valor_unitario)
        Console.WriteLine(Me.valor_total)
    End Sub
    Sub Ingresar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oKardexDetalleDatos As New KardexDatosDetalle
        oKardexDetalleDatos.Grabar(Me.producto, Me.bodega, Me.linea, Me.tipo_movimiento, Me.fecha_registro, Me.cantidad, Me.valor_unitario, Me.valor_total)
        oKardexDetalleDatos.Desconectar()
    End Sub
    Property producto()
        Get
            Return Me._producto
        End Get
        Set(ByVal value)
            Me._producto = value
        End Set
    End Property
    Property bodega()
        Get
            Return Me._bodega
        End Get
        Set(ByVal value)
            Me._bodega = value
        End Set
    End Property
    Property linea()
        Get
            Return Me._linea
        End Get
        Set(ByVal value)
            Me._linea = value
        End Set
    End Property
    Property tipo_movimiento()
        Get
            Return Me._tipo_movimiento
        End Get
        Set(ByVal value)
            Me._tipo_movimiento = value
        End Set
    End Property
    Property fecha_registro()
        Get
            Return Me._fecha_registro
        End Get
        Set(ByVal value)
            Me._fecha_registro = value
        End Set
    End Property
    Property cantidad()
        Get
            Return Me._cantidad
        End Get
        Set(ByVal value)
            Me._cantidad = value
        End Set
    End Property
    Property valor_unitario()
        Get
            Return Me._valor_unitario
        End Get
        Set(ByVal value)
            Me._valor_unitario = value
        End Set
    End Property
    Property valor_total()
        Get
            Return Me._valor_total
        End Get
        Set(ByVal value)
            Me._valor_total = value
        End Set
    End Property
End Class

