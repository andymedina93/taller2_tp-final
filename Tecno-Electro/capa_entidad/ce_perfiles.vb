
Imports System.Configuration
Public Class ce_perfiles
    ' Campos privados
    Public Property idPerfil As Integer
    Public Property descripcion As String

    ' Getters y Setters

    Public Property GetIdPerfil() As Integer
        Get
            Return idPerfil
        End Get
        Set(value As Integer)
            idPerfil = value
        End Set
    End Property

    Public Property GetDescripcion() As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
End Class

