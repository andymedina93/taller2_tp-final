Imports capa_entidad
Imports capa_datos
Imports capa_negocio
Imports System.Data
Imports System.Data.SqlClient

Public Class CN_PersonasUsuarios
    Private obj_PersonasUsuarios As New CD_PersonasyUsuarios()
    Public Function CambiarContraseña(ByVal idUsuario As Integer, ByVal nuevaContraseña As Integer) As Boolean
        ' Validar que la nueva contraseña sea numérica y tenga al menos 6 dígitos
        If nuevaContraseña.ToString().Length < 6 Then
            Throw New Exception("La nueva contraseña debe tener al menos 6 dígitos.")
        End If

        ' Llamar a la capa de datos para realizar el cambio
        Return obj_PersonasUsuarios.CambiarContraseña(idUsuario, nuevaContraseña.ToString())
    End Function
    ' Ejemplo de encriptación de contraseña (puedes usar otros métodos más robustos)
    Private Function EncriptarContraseña(ByVal contraseña As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contraseña))
    End Function
    Public Function EsUsuarioUnico(ByVal usuario As String) As Boolean
        Try
            Return obj_PersonasUsuarios.EsUsuarioUnico(usuario)
        Catch ex As Exception
            Throw New Exception("Error en la verificación del usuario único: " & ex.Message)
        End Try
    End Function

    '  Private dataLayer As New CD_Usuario()

    ' Método para verificar el login y devolver los datos solicitados
    Public Function VerificarLogin(usuario As String, contrasena As String) As (Boolean, Integer, String, String, String)


        Dim dt As DataTable = obj_PersonasUsuarios.VerificarLogin(usuario, contrasena)

        ' Verificar si el DataTable tiene registros
        If dt.Rows.Count > 0 Then
            ' Si el usuario existe, devuelve los datos
            Dim idUsuario As Integer = Convert.ToInt32(dt.Rows(0)("id_usuario"))
            Dim nombre As String = dt.Rows(0)("nombre").ToString()
            Dim perfil As String = dt.Rows(0)("perfil").ToString()
            Dim apellido As String = dt.Rows(0)("apellido").ToString()

            ' Retorna True indicando que el login fue exitoso y los datos
            Return (True, idUsuario, nombre, perfil, apellido)
        Else
            ' Si no se encuentra el usuario o la contraseña, retorna False
            Return (False, 0, String.Empty, String.Empty, String.Empty)
        End If
    End Function
    Public Sub GuardarPersonaYUsuario(ByVal persona As CE_Personas, ByVal usuario As ce_Usuarios)
        Try
            ' Primero verificamos si el usuario es único
            If Not EsUsuarioUnico(usuario.usuario) Then
                Throw New Exception("El nombre de usuario ya está en uso.")
            End If
            If ExisteDocumento(persona.NDocumento) Then
                Throw New Exception("El número de documento ya está registrado.")
            End If

            ' Si el usuario es único, procedemos a guardar la persona y el usuario
            obj_PersonasUsuarios.InsertarPersonaYUsuario(persona, usuario)
        Catch ex As Exception
            Throw New Exception("Error al guardar la persona y el usuario: " & ex.Message)
        End Try
    End Sub
    ' Método de la capa de negocio que retorna el DataTable
    Public Function ObtenerPersonasYUsuariosActivos() As DataTable
        Return obj_PersonasUsuarios.ListarUsuariosActivos()
    End Function
    Public Function ObtenerPersonasYUsuariosInactivos() As DataTable
        Return obj_PersonasUsuarios.ListarUsuariosInactivos()
    End Function



    Public Sub ModificarPersonaYUsuario(ByVal persona As CE_Personas, ByVal usuario As ce_Usuarios)
        Try

            obj_PersonasUsuarios.ModificarPersonaYUsuario(persona, usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarPersona(ByVal idPersona As Integer)
        Try
            ' Llamada a la capa de datos para cambiar el estado de la persona a "Inactivo"

            obj_PersonasUsuarios.DarDeBajaPersona(idPersona)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a la persona: " & ex.Message)
        End Try
    End Sub
    Private Function ExisteDocumento(ByVal NDocumento As Long) As Boolean
        Return obj_PersonasUsuarios.VerificarDocumento(NDocumento)
    End Function
    Public Sub ActivarPersona(ByVal idPersona As Integer)
        Try

            obj_PersonasUsuarios.ActivarPersona(idPersona)
        Catch ex As Exception
            Throw New Exception("Error al activar a la persona: " & ex.Message)
        End Try
    End Sub

    Public Function BuscarClientesPorNombre(ByVal nombre As String) As DataTable
        ' Implementar la lógica para buscar por Nombre
        Return obj_PersonasUsuarios.BuscarPersonasnUsuarioPorNombre(nombre)
    End Function

    Public Function BuscarDNIcliente(ByVal dni As Integer) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Return obj_PersonasUsuarios.BuscarClientePorDNI(dni)
    End Function
    Public Function BuscardniUsuario(ByVal dni As Integer) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Return obj_PersonasUsuarios.BuscarUsuarioPorDNI(dni)
    End Function
    Public Function BuscarClientesPorApellido(ByVal apellido As String) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Return obj_PersonasUsuarios.BuscarPersonasUsuarioPorApellido(apellido)
    End Function

    Public Function BuscarClientesPorDNI(ByVal dni As String) As DataTable
        ' Implementar la lógica para buscar por DNI
        Return obj_PersonasUsuarios.BuscarPersonasUsuarioPorDNI(dni)
    End Function

    Public Function MejorVendedor(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        Return obj_PersonasUsuarios.ObtenerMejoresVendedores(fechaInicio, fechaFin, top)
    End Function


End Class

