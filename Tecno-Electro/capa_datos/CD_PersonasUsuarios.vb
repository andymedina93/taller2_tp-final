Imports System.Data.SqlClient
Imports System.Reflection
Imports capa_entidad
Public Class CD_PersonasyUsuarios
    ' Método que devuelve una lista de personas con sus usuarios y perfiles
    Public Function ListarUsuariosActivos() As DataTable
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Consulta SQL para unir personas, usuarios y perfiles

                Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro, " &
                                  " u.usuario,u.id_usuario,u.contraseña, pf.descripcion AS perfil " &
                                  "FROM personas p " &
                                  "INNER JOIN usuarios u ON p.id_persona = u.persona_id " &
                                  "INNER JOIN perfiles pf ON u.perfil_id= pf.id_perfil " &
                                  "WHERE p.estado = 'activo'"

                Dim cmd As New SqlCommand(query, oconexion)
                oconexion.Open()

                ' Usar un DataAdapter para llenar un DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adaptador.Fill(dt)

                Return dt  ' Devuelve el DataTable con los datos obtenidos
            Catch ex As Exception
                Throw New Exception("Error al listar personas y usuarios: " & ex.Message)
            Finally
                oconexion.Close()
            End Try
        End Using
    End Function

    Public Function ListarUsuariosInactivos() As DataTable
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Consulta SQL para unir personas, usuarios y perfiles

                Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro, " &
                                  " u.usuario,u.id_usuario,u.contraseña, pf.descripcion AS perfil " &
                                  "FROM personas p " &
                                  "INNER JOIN usuarios u ON p.id_persona = u.persona_id " &
                                  "INNER JOIN perfiles pf ON u.perfil_id= pf.id_perfil " &
                                  "WHERE p.estado = 'inactivo'"

                Dim cmd As New SqlCommand(query, oconexion)
                oconexion.Open()

                ' Usar un DataAdapter para llenar un DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adaptador.Fill(dt)

                Return dt  ' Devuelve el DataTable con los datos obtenidos
            Catch ex As Exception
                Throw New Exception("Error al listar personas y usuarios: " & ex.Message)
            Finally
                oconexion.Close()
            End Try
        End Using
    End Function
    Public Sub InsertarPersonaYUsuario(ByVal persona As CE_Personas, ByVal usuario As ce_Usuarios)
        Try
            ' Validar que ningún campo esté vacío
            If String.IsNullOrWhiteSpace(persona.Nombre) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(persona.Apellido) Then
                Throw New Exception("El apellido no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(persona.NDocumento) Then
                Throw New Exception("El número de documento debe tener entre 7 y 8 dígitos.")
            End If
            If String.IsNullOrWhiteSpace(persona.Direccion) Then
                Throw New Exception("La dirección no puede estar vacía.")
            End If

            If String.IsNullOrWhiteSpace(usuario.usuario) Then
                Throw New Exception("El nombre de usuario no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(usuario.contraseña) Then
                Throw New Exception("La contraseña no puede estar vacía.")
            End If
            If usuario.idPerfil = 0 Then
                Throw New Exception("Debe seleccionarse un perfil válido.")
            End If

            ' Si todas las validaciones pasan, proceder con la inserción
            Using oconexion As New SqlConnection(Conexion.cadena)
                oconexion.Open()
                Dim transaccion As SqlTransaction = oconexion.BeginTransaction()

                Try
                    ' Insertar la persona
                    Dim queryPersona As String = "INSERT INTO Personas (nombre, apellido, N_Documento, direccion, celular, fecha_resgistro,estado) 
                                              VALUES (@nombre, @apellido, @N_Documento, @direccion, @celular, @fecha_resgistro, @estado);
                                              SELECT SCOPE_IDENTITY();" ' Obtener el id generado

                    Dim cmdPersona As New SqlCommand(queryPersona, oconexion, transaccion)
                    cmdPersona.Parameters.AddWithValue("@nombre", persona.Nombre)
                    cmdPersona.Parameters.AddWithValue("@apellido", persona.Apellido)
                    cmdPersona.Parameters.AddWithValue("@N_Documento", persona.NDocumento)
                    cmdPersona.Parameters.AddWithValue("@direccion", persona.Direccion)
                    cmdPersona.Parameters.AddWithValue("@celular", persona.Celular)
                    cmdPersona.Parameters.AddWithValue("@fecha_resgistro", persona.FechaRegistro)
                    cmdPersona.Parameters.AddWithValue("@estado", persona.estado)

                    ' Ejecutar y obtener el ID de la persona recién insertada
                    Dim personaId As Integer = Convert.ToInt32(cmdPersona.ExecuteScalar())

                    ' Insertar el usuario relacionado con la persona
                    Dim queryUsuario As String = "INSERT INTO Usuarios (usuario, contraseña, perfil_id, persona_id) 
                                              VALUES (@usuario, @contraseña, @perfil_id, @persona_id)"

                    Dim cmdUsuario As New SqlCommand(queryUsuario, oconexion, transaccion)
                    cmdUsuario.Parameters.AddWithValue("@usuario", usuario.usuario)
                    cmdUsuario.Parameters.AddWithValue("@contraseña", usuario.contraseña)
                    cmdUsuario.Parameters.AddWithValue("@perfil_id", usuario.idPerfil)
                    cmdUsuario.Parameters.AddWithValue("@persona_id", personaId)

                    cmdUsuario.ExecuteNonQuery()

                    ' Confirmar la transacción
                    transaccion.Commit()

                Catch ex As Exception
                    ' Revertir si hay un error
                    transaccion.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            ' Manejar la excepción y mostrar el mensaje
            Throw New Exception("Error al insertar persona y usuario: " & ex.Message)
        End Try
    End Sub


    Public Sub ModificarPersonaYUsuario(ByVal persona As CE_Personas, ByVal usuario As ce_Usuarios)
        ' Validar que ningún campo esté vacío
        If String.IsNullOrWhiteSpace(persona.Nombre) Then
            Throw New Exception("El campo 'Nombre' no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(persona.Apellido) Then
            Throw New Exception("El campo 'Apellido' no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(persona.NDocumento) Then
            Throw New Exception("El número de documento debe tener entre 7 y 8 dígitos.")
        End If
        If String.IsNullOrWhiteSpace(persona.Celular) Then
            Throw New Exception("El campo 'Celular' no puede estar vacío o debe contener al menos 7 dígitos.")
        End If
        If String.IsNullOrWhiteSpace(persona.Direccion) Then
            Throw New Exception("El campo 'Dirección' no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(usuario.usuario) Then
            Throw New Exception("El campo 'Usuario' no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(usuario.contraseña) Then
            Throw New Exception("El campo 'Contraseña' no puede estar vacío.")
        End If
        If usuario.idPerfil = 0 Then
            Throw New Exception("Debe seleccionarse un perfil válido.")
        End If

        ' Si todas las validaciones pasan, proceder con la modificación
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                oconexion.Open()

                ' Transacción para asegurar que ambas actualizaciones se completen correctamente
                Dim transaccion As SqlTransaction = oconexion.BeginTransaction()

                ' Modificar la tabla Personas
                Dim queryPersona As String = "UPDATE Personas SET nombre = @Nombre, apellido = @Apellido, N_Documento = @NDocumento, " &
                                      "celular = @Celular, direccion = @Direccion " &
                                      "WHERE id_persona = @IdPersona"
                Dim cmdPersona As New SqlCommand(queryPersona, oconexion, transaccion)
                cmdPersona.Parameters.AddWithValue("@Nombre", persona.Nombre)
                cmdPersona.Parameters.AddWithValue("@Apellido", persona.Apellido)
                cmdPersona.Parameters.AddWithValue("@NDocumento", persona.NDocumento)
                cmdPersona.Parameters.AddWithValue("@Celular", persona.Celular)
                cmdPersona.Parameters.AddWithValue("@Direccion", persona.Direccion)
                cmdPersona.Parameters.AddWithValue("@IdPersona", persona.IdPersona)

                cmdPersona.ExecuteNonQuery()

                ' Modificar la tabla Usuarios
                Dim queryUsuario As String = "UPDATE Usuarios SET usuario = @Usuario, contraseña = @Contraseña, perfil_id = @IdPerfil " &
                                      "WHERE id_usuario = @Id_usuario"
                Dim cmdUsuario As New SqlCommand(queryUsuario, oconexion, transaccion)
                cmdUsuario.Parameters.AddWithValue("@Usuario", usuario.usuario)
                cmdUsuario.Parameters.AddWithValue("@Contraseña", usuario.contraseña)
                cmdUsuario.Parameters.AddWithValue("@IdPerfil", usuario.idPerfil)
                cmdUsuario.Parameters.AddWithValue("@id_usuario", usuario.id_usuario)

                cmdUsuario.ExecuteNonQuery()

                ' Confirmar transacción
                transaccion.Commit()

            Catch ex As Exception
                Debug.WriteLine("Error: " & ex.Message) ' Para ayudar a identificar el error
                Throw
            End Try
        End Using
    End Sub


    Public Function VerificarDocumento(ByVal NDocumento As Long) As Boolean
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Personas WHERE N_Documento = @NDocumento"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NDocumento", NDocumento)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            Catch ex As Exception
                Throw New Exception("Error al verificar el documento: " & ex.Message)
            End Try
        End Using
    End Function
    Public Function EsUsuarioUnico(ByVal usuario As String) As Boolean
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @Usuario"

                Dim cmd As New SqlCommand(query, oconexion)
                cmd.Parameters.AddWithValue("@Usuario", usuario)

                oconexion.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())


                ' Si el resultado es 0, significa que el usuario no existe, por lo tanto es único
                Return count = 0
            Catch ex As Exception
                Throw New Exception("Error al verificar la unicidad del usuario: " & ex.Message)
            End Try
        End Using
    End Function

    Public Function BuscarPersonasnUsuarioPorNombre(ByVal nombre As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                         "FROM Personas p " &
                         "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id " &
                         "WHERE LOWER(p.nombre) LIKE '%' + @nombre + '%' " &
                         "AND p.estado = 'Activo'"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", nombre.ToLower()) ' Convertir el nombre a minúsculas para una comparación insensible a mayúsculas/minúsculas
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()

                connection.Open()
                adapter.Fill(dt)

                Return dt
            End Using
        End Using
    End Function


    Public Function BuscarPersonasUsuarioPorApellido(ByVal apellido As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                         "FROM Personas p " &
                         "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id " &
                         "WHERE LOWER(p.apellido) LIKE '%' + @apellido + '%' " &
                         "AND p.estado = 'Activo'"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@apellido", apellido.ToLower()) ' Convertir el apellido a minúsculas
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()

                connection.Open()
                adapter.Fill(dt)

                Return dt
            End Using
        End Using
    End Function

    Public Function BuscarPersonasUsuarioPorDNI(ByVal dni As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                         "FROM Personas p " &
                         "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id " &
                         "WHERE CAST(p.N_Documento AS VARCHAR) LIKE '%' + @dni + '%' " &
                         "AND p.estado = 'Activo'"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@dni", dni)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()

                connection.Open()
                adapter.Fill(dt)

                Return dt
            End Using
        End Using
    End Function

    Public Sub DarDeBajaPersona(ByVal idPersona As Integer)
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Actualizar el estado de la persona a "Inactivo"
                Dim query As String = "UPDATE Personas SET estado = 'Inactivo' WHERE id_persona = @IdPersona"
                Dim cmd As New SqlCommand(query, oconexion)
                cmd.Parameters.AddWithValue("@IdPersona", idPersona)

                oconexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al dar de baja a la persona: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub ActivarPersona(ByVal idPersona As Integer)
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Actualizar el estado de la persona a "Activo"
                Dim query As String = "UPDATE Personas SET estado = 'Activo' WHERE id_persona = @IdPersona"
                Dim cmd As New SqlCommand(query, oconexion)
                cmd.Parameters.AddWithValue("@IdPersona", idPersona)

                oconexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al activar a la persona: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ObtenerMejoresVendedores(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        Dim query As String = "
                    SELECT TOP (@Top) 
                p.nombre AS Nombre, 
                p.apellido AS Apellido,
                p.N_Documento AS Documento,
                p.direccion AS Direccion,
                SUM(vc.Monto_Total) AS TotalVendido
                FROM ventas_cabecera vc
                INNER JOIN Usuarios u ON vc.usuario_id = u.id_usuario
                INNER JOIN Personas p ON u.persona_id = p.id_persona
                INNER JOIN Perfiles pf ON u.perfil_id = pf.id_perfil
                WHERE pf.descripcion = 'Administrador' 
                  AND vc.FechaVenta BETWEEN @FechaInicio AND @FechaFin
                GROUP BY p.nombre, p.apellido, p.N_Documento, p.direccion
                ORDER BY TotalVendido DESC "

        Dim dt As New DataTable()
        Using connection As New SqlConnection(Conexion.cadena) ' Asegúrate de que tu clase `Conexion` tenga una cadena válida
            Using command As New SqlCommand(query, connection)
                ' Añadir los parámetros a la consulta
                command.Parameters.AddWithValue("@Top", top)
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@FechaFin", fechaFin)

                ' Ejecutar la consulta y llenar el DataTable
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function VerificarLogin(usuario As String, contrasena As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "
            SELECT u.id_usuario, p.nombre, p.apellido, pf.descripcion AS perfil
            FROM Usuarios u
            INNER JOIN Personas p ON u.persona_id = p.id_persona
            INNER JOIN Perfiles pf ON u.perfil_id = pf.id_perfil
            WHERE u.usuario = @usuario AND u.contraseña = @contrasena"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@contrasena", contrasena)

                ' Ejecutar la consulta y llenar el DataTable
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function CambiarContraseña(ByVal idUsuario As Integer, ByVal nuevaContraseña As Integer) As Boolean
        Dim query As String = "UPDATE usuarios SET contraseña = @nuevaContraseña WHERE id_usuario = @idUsuario"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)

                Try
                    connection.Open()
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    ' Si se actualizó al menos una fila, la operación fue exitosa
                    Return filasAfectadas > 0
                Catch ex As Exception
                    Throw New Exception("Error al cambiar la contraseña: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function BuscarUsuarioPorDNI(dni As Integer) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                      "FROM Personas p " &
                      "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id " &
                      "WHERE (CAST(p.N_Documento AS VARCHAR) LIKE '%' + @dni + '%' " &
                      "OR CAST(u.N_Documento AS VARCHAR) LIKE '%' + @dni + '%') " &
                      "AND p.estado = 'Activo'"


        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@dni", dni)

                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function BuscarClientePorDNI(dni As Integer) As DataTable
        Dim query As String = "
        SELECT 
            p.id_persona, 
            p.Nombre, 
            p.Apellido, 
            p.n_documento
        FROM 
            personas p
        WHERE 
            p.n_documento= @dni"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@dni", dni)

                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


End Class
