Imports capa_entidad
Imports capa_datos
Imports System.Data
Imports System.Data.SqlClient

Public Class CN_Personas
    ' Instancia de la capa de datos
    Private dataPersonas As New CD_Clientes()

    ' Método para registrar una nueva persona
    Public Sub RegistrarCliente(ByVal cliente As CE_Personas)
        ' Validaciones previas a la inserción
        If String.IsNullOrWhiteSpace(cliente.Nombre) Then
            Throw New Exception("El nombre no puede estar vacío.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Apellido) Then
            Throw New Exception("El apellido no puede estar vacío.")
        End If

        If cliente.NDocumento <= 0 Then
            Throw New Exception("El documento no es válido.")
        End If

        ' Verificar si el documento ya existe
        If ExisteDocumento(cliente.NDocumento) Then
            Throw New Exception("El número de documento ya está registrado.")
        End If

        ' Si todo está bien, llamar a la capa de datos para insertar el cliente
        dataPersonas.InsertarCliente(cliente)
    End Sub

    ' Método para verificar si el número de documento ya existe
    Private Function ExisteDocumento(ByVal NDocumento As Long) As Boolean
        Return dataPersonas.VerificarDocumento(NDocumento)
    End Function

    Public Function ListarClientesActivos() As DataTable

        Return dataPersonas.ObtenerClientesActivos()
    End Function

    Public Function ListarClientesInactivos() As DataTable

        Return dataPersonas.ObtenerClientesInactivos()
    End Function

    Public Sub ModificarCliente(ByVal persona As CE_Personas)

        dataPersonas.ModificarPersona(persona)
    End Sub

    ' Método para eliminar (inactivar) una persona
    Public Sub EliminarPersona(ByVal idPersona As Integer)

        dataPersonas.EliminarPersona(idPersona)
    End Sub
    Public Sub ActivarCliente(ByVal idPersona As Integer)
        dataPersonas.ActivarPersona(idPersona)
    End Sub

    Public Function BuscarClientesPorNombre(ByVal nombre As String) As DataTable
        ' Implementar la lógica para buscar por Nombre
        Return dataPersonas.BuscarClientesPorNombre(nombre)
    End Function

    Public Function BuscarClientesPorApellido(ByVal apellido As String) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Return dataPersonas.BuscarClientesPorApellido(apellido)
    End Function

    Public Function BuscarClientesPorDNI(ByVal dni As String) As DataTable
        ' Implementar la lógica para buscar por DNI
        Return dataPersonas.BuscarClientesPorDNI(dni)
    End Function

    Public Function obtenerClientes(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        Return dataPersonas.ObtenerMejoresClientes(fechaInicio, fechaFin, top)
    End Function

End Class
