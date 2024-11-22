Imports capa_entidad
Imports capa_datos

Public Class CN_Proveedores


    Private DataProveedores As New CD_Proveedores()

    ' Registrar nueva persona
    Public Sub RegistrarProveedor(ByVal persona As CE_Personas, ByVal proveedor As CE_Proveedores)
        ' Validaciones previas
        If String.IsNullOrWhiteSpace(persona.Nombre) Then
            Throw New Exception("El nombre no puede estar vacío.")
        End If

        If String.IsNullOrWhiteSpace(persona.Apellido) Then
            Throw New Exception("El apellido no puede estar vacío.")
        End If

        If persona.NDocumento <= 0 Then
            Throw New Exception("El documento no es válido.")
        End If

        ' Verificar si el documento ya existe
        If ExisteDocumento(persona.NDocumento) Then
            Throw New Exception("El número de documento ya está registrado.")
        End If

        ' Si todo está bien, llamar a la capa de datos para insertar el cliente
        DataProveedores.InsertarProveedor(persona, proveedor)
    End Sub

    ' Método para verificar si el número de documento ya existe
    Private Function ExisteDocumento(ByVal NDocumento As Long) As Boolean
        Return DataProveedores.VerificarDocumento(NDocumento)
    End Function

    Public Function ListarProveedorActivos() As DataTable

        Return DataProveedores.ObtenerProveedorActivos()
    End Function

    Public Function ListarProveedorInactivos() As DataTable

        Return DataProveedores.ObtenerProveedorInactivos()
    End Function

    Public Sub ModificarProveedor(ByVal persona As CE_Personas, ByVal proveedor As CE_Proveedores)

        DataProveedores.ModificarProveedor(persona, proveedor)
    End Sub

    ' Método para eliminar (inactivar) una persona
    Public Sub EliminarProveedor(ByVal idPersona As Integer)

        DataProveedores.EliminarProveedor(idPersona)
    End Sub
    Public Sub ActivarCliente(ByVal idPersona As Integer)
        DataProveedores.ActivarProveedor(idPersona)
    End Sub

    Public Function BuscarClientesPorNombre(ByVal nombre As String) As DataTable
        ' Implementar la lógica para buscar por Nombre
        Return DataProveedores.BuscarProveedorPorNombre(nombre)
    End Function

    Public Function BuscarProveedorPorApellido(ByVal apellido As String) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Return DataProveedores.BuscarProveedorPorApellido(apellido)
    End Function

    Public Function BuscarClientesPorDNI(ByVal dni As String) As DataTable
        ' Implementar la lógica para buscar por DNI
        Return DataProveedores.BuscarProveedorPorDNI(dni)
    End Function


End Class
