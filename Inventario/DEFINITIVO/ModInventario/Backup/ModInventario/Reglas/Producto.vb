Public Class Producto
    Private _nombre As String
    Private _grupo As Integer
    Private _subgrupo As Integer
    Private _marca As Integer
    Private _prsentacion As String
    Private _observacion As String
    Private _iva As String
    Private _estado As Integer
    Sub New()
        Me.nombre = String.Empty
        Me.grupo = 0
        Me.subgrupo = 0
        Me.marca = 0
        Me.presentacion = String.Empty
        Me.observacion = String.Empty
        Me.iva = String.Empty
        Me.estado = 0
    End Sub
    Sub New(ByVal nombre As String, ByVal grupo As Integer, ByVal subgrupo As Integer, ByVal marca As Integer, _
             ByVal presentacion As String, ByVal observacion As String, ByVal iva As String, ByVal estado As Integer)

        Me.nombre = nombre
        Me.grupo = grupo
        Me.subgrupo = subgrupo
        Me.marca = marca
        Me.presentacion = presentacion
        Me.observacion = observacion
        Me.iva = iva
        Me.estado = estado
    End Sub
    Sub imprimir()
        Console.WriteLine(Me.nombre)
        Console.WriteLine(Me.grupo)
        Console.WriteLine(Me.subgrupo)
        Console.WriteLine(Me.marca)
        Console.WriteLine(Me.presentacion)
        Console.WriteLine(Me.observacion)
        Console.WriteLine(Me.iva)
        Console.WriteLine(Me.estado)
    End Sub
    Sub Ingresar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oProductoDatos As New ProductoDatos
        oProductoDatos.Grabar(Me.nombre, Me.grupo, Me.subgrupo, Me.marca, Me.presentacion, Me.observacion, Me.iva, Me.estado)
        oProductoDatos.Desconectar()
    End Sub
    Sub Modificar() ' si no está este metodo las capas están programadas de manera independientes, es decir, no se relacionan... :(
        Dim oProductoDatos As New ProductoDatos
        oProductoDatos.Modificar(Me.nombre, Me.grupo, Me.subgrupo, Me.marca, Me.presentacion, Me.observacion, Me.iva, Me.estado)
        oProductoDatos.Desconectar()
    End Sub
    Property nombre()
        Get
            Return Me._nombre
        End Get
        Set(ByVal value)
            Me._nombre = value
        End Set
    End Property
    Property grupo()
        Get
            Return Me._grupo
        End Get
        Set(ByVal value)
            Me._grupo = value
        End Set
    End Property
    Property subgrupo()
        Get
            Return Me._subgrupo
        End Get
        Set(ByVal value)
            Me._subgrupo = value
        End Set
    End Property
    Property marca()
        Get
            Return Me._marca
        End Get
        Set(ByVal value)
            Me._marca = value
        End Set
    End Property
    Property presentacion()
        Get
            Return Me._prsentacion
        End Get
        Set(ByVal value)
            Me._prsentacion = value
        End Set
    End Property
    Property observacion()
        Get
            Return Me._observacion
        End Get
        Set(ByVal value)
            Me._observacion = value
        End Set
    End Property
    Property iva()
        Get
            Return Me._iva
        End Get
        Set(ByVal value)
            Me._iva = value
        End Set
    End Property
    Property estado()
        Get
            Return Me._estado
        End Get
        Set(ByVal value)
            Me._estado = value
        End Set
    End Property
End Class
