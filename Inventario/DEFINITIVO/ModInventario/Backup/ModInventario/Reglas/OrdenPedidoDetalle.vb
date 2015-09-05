Public Class OrdenPedidoDetalle
    Private _numero As Integer
    Private _bodega As Integer
    Private _linea As Integer
    Private _producto As Integer
    Private _cantidad As Integer
    Private _estado As Boolean

    Sub New()
        Me.numero = 0
        Me.bodega = 0
        Me.linea = 0
        Me.producto = 0
        Me.cantidad = 0
        Me.estado = 0
    End Sub
    Sub New(ByVal numero As Integer, ByVal bodega As Integer, _
    ByVal linea As Integer, ByVal producto As Integer, ByVal cantidad As Integer, ByVal estado As Boolean)
        Me.numero = numero
        Me.bodega = bodega
        Me.linea = linea
        Me.producto = producto
        Me.cantidad = cantidad
        Me.estado = estado
    End Sub
    Sub imprimir()
        Console.WriteLine(Me.numero)
        Console.WriteLine(Me.bodega)
        Console.WriteLine(Me.linea)
        Console.WriteLine(Me.producto)
        Console.WriteLine(Me.cantidad)
    End Sub
    Sub Ingresar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oOrdenDetalleDatos As New OrdenDatosDetalle
        oOrdenDetalleDatos.Grabar(Me.numero, Me.bodega, Me.linea, Me.producto, Me.cantidad, Me.estado)
        oOrdenDetalleDatos.Desconectar()
    End Sub
    Property estado()
        Get
            Return Me._estado
        End Get
        Set(ByVal value)
            Me._estado = value
        End Set
    End Property
    Property numero()
        Get
            Return Me._numero
        End Get
        Set(ByVal value)
            Me._numero = value
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
    Property producto()
        Get
            Return Me._producto
        End Get
        Set(ByVal value)
            Me._producto = value
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
End Class

