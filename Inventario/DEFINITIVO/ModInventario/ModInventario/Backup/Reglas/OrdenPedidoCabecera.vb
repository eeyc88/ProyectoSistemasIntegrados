Public Class OrdenPedidoCabecera
    Private _numero As Integer
    Private _bodega As Integer
    Private _responsable As Integer
    Private _fecha_pedido As Date
    Private _fecha_entrega As Date
    Private _observacion As String
    Sub New()
        Me.numero = 0
        Me.Bodega = 0
        Me.Responsable = 0
        Me.Fecha_Pedido = Date.Now.ToString("dd mm yyyy")
        Me.Fecha_Entrega = Date.Now.ToString("dd mm yyyy")
        Me.Observacion = String.Empty
    End Sub
    Sub New(ByVal Numero As Integer, ByVal Bodega As Integer, ByVal Responsable As Integer, _
    ByVal Fecha_Pedido As Date, ByVal FechaEntrega As Date, ByVal Observacion As String)
        Me.numero = Numero
        Me.Bodega = Bodega
        Me.Responsable = Responsable
        Me.Fecha_Pedido = Fecha_Pedido
        Me.Fecha_Entrega = FechaEntrega
        Me.Observacion = Observacion
    End Sub
    Sub imprimir()
        Console.WriteLine(Me.numero)
        Console.WriteLine(Me.Bodega)
        Console.WriteLine(Me.Responsable)
        Console.WriteLine(Me.Fecha_Pedido)
        Console.WriteLine(Me.Fecha_Entrega)
        Console.WriteLine(Me.Observacion)
    End Sub
    Sub Ingresar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oOrdenCabDatos As New OrdenDatosCabecera
        oOrdenCabDatos.Grabar(Me.numero, Me.Bodega, Me.Responsable, Me.Fecha_Pedido, Me.Fecha_Entrega, Me.Observacion)
    End Sub
    Property numero()
        Get
            Return Me._numero
        End Get
        Set(ByVal value)
            Me._numero = value
        End Set
    End Property
    Property Bodega()
        Get
            Return Me._bodega
        End Get
        Set(ByVal value)
            Me._bodega = value
        End Set
    End Property
    Property Responsable()
        Get
            Return Me._responsable
        End Get
        Set(ByVal value)
            Me._responsable = value
        End Set
    End Property
    Property Fecha_Pedido()
        Get
            Return Me._fecha_pedido
        End Get
        Set(ByVal value)
            Me._fecha_pedido = value
        End Set
    End Property
    Property Fecha_Entrega()
        Get
            Return Me._fecha_entrega
        End Get
        Set(ByVal value)
            Me._fecha_entrega = value
        End Set
    End Property
    Property Observacion()
        Get
            Return Me._observacion
        End Get
        Set(ByVal value)
            Me._observacion = value
        End Set
    End Property
End Class

