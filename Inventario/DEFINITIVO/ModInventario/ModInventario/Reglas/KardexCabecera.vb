Public Class KardexCabecera
    Private _bodega As Integer
    Private _producto As Integer
    Private _fecha As Date
    Private _existencia_actual As Integer
    Private _existencia_minima As Integer
    Private _existencia_maxima As Integer
    Private _responsable As Integer
    Sub New()
        Me.Bodega = 0
        Me.producto = 0
        Me.fecha = Date.Now.ToString("dd mm yyyy")
        Me.existencia_actual = 0
        Me.existencia_minima = 0
        Me.existencia_maxima = 0
        Me.Responsable = 0
    
    End Sub
    Sub New(ByVal Bodega As Integer, ByVal producto As Integer, ByVal fecha As Date, ByVal existencia_actual As Integer, _
    ByVal existencia_minima As Integer, ByVal existencia_maxima As Integer, ByVal responsable As Integer)
        Me.Bodega = Bodega
        Me.producto = producto
        Me.fecha = Date.Now.ToString("dd/MM/yyyy")
        Me.existencia_actual = existencia_actual
        Me.existencia_minima = existencia_minima
        Me.existencia_maxima = existencia_maxima
        Me.Responsable = responsable
    End Sub
    Sub imprimir()
        Console.WriteLine(Me.Bodega)
        Console.WriteLine(Me.producto)
        Console.WriteLine(Me.fecha)
        Console.WriteLine(Me.existencia_actual)
        Console.WriteLine(Me.existencia_minima)
        Console.WriteLine(Me.existencia_maxima)
        Console.WriteLine(Me.Responsable)
    End Sub
    Sub Ingresar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oKardexCabDatos As New KardexDatosCabecera
        oKardexCabDatos.Grabar(Me.Bodega, Me.producto, Me.fecha, Me.existencia_actual, Me.existencia_minima, Me.existencia_maxima, Me.Responsable)
    End Sub
    Property Bodega()
        Get
            Return Me._bodega
        End Get
        Set(ByVal value)
            Me._bodega = value
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
    Property fecha()
        Get
            Return Me._fecha
        End Get
        Set(ByVal value)
            Me._fecha = value
        End Set
    End Property
    Property existencia_actual()
        Get
            Return Me._existencia_actual
        End Get
        Set(ByVal value)
            Me._existencia_actual = value
        End Set
    End Property
    Property existencia_minima()
        Get
            Return Me._existencia_minima
        End Get
        Set(ByVal value)
            Me._existencia_minima = value
        End Set
    End Property
    Property existencia_maxima()
        Get
            Return Me._existencia_maxima
        End Get
        Set(ByVal value)
            Me._existencia_maxima = value
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
End Class

