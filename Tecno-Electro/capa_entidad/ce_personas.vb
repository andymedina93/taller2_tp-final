Public Class CE_Personas
    Public Property IdPersona As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property NDocumento As Integer
    Public Property Celular As String
    Public Property Direccion As String
    Public Property FechaRegistro As Date
    Public Property RazonSocial As String
    Public Property estado As String
    Public Property esProveedor As String


    Public Property GetNombre() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property GetApellido() As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    Public Property GetNDocumento() As Integer
        Get
            Return NDocumento
        End Get
        Set(value As Integer)
            NDocumento = value
        End Set
    End Property

    Public Property GetCelular() As Integer
        Get
            Return Celular
        End Get
        Set(value As Integer)
            Celular = value
        End Set
    End Property

    Public Property GetDireccion() As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property GetFechaRegistro() As Date
        Get
            Return FechaRegistro
        End Get
        Set(value As Date)
            FechaRegistro = value
        End Set
    End Property

    Public Property GetRazonSocial() As Integer
        Get
            Return RazonSocial
        End Get
        Set(value As Integer)
            RazonSocial = value
        End Set
    End Property

End Class
