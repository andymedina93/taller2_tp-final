Imports capa_entidad
Imports System.Data.SqlClient

Public Class CD_Proveedores
    'Public Sub insertarproveedor(ByVal persona As CE_Personas)
    '    Using connection As New SqlConnection(Conexion.cadena)
    '        Try
    '            connection.Open()
    '            Dim query As String = "insert into personas (nombre, apellido, n_documento, celular, direccion, fecha_resgistro, razon_social, estado, esproveedor) " &
    '                              "values (@nombre, @apellido, @ndocumento, @celular, @direccion, @fecharegistro, @razonsocial, @estado, @esproveedor)"
    '            Using command As New SqlCommand(query, connection)
    '                command.Parameters.AddWithValue("@nombre", If(String.IsNullOrEmpty(persona.Nombre), DBNull.Value, persona.Nombre))
    '                command.Parameters.AddWithValue("@apellido", If(String.IsNullOrEmpty(persona.Apellido), DBNull.Value, persona.Apellido))
    '                command.Parameters.AddWithValue("@ndocumento", persona.NDocumento)
    '                command.Parameters.AddWithValue("@celular", persona.Celular)
    '                command.Parameters.AddWithValue("@direccion", persona.Direccion)
    '                command.Parameters.AddWithValue("@fecharegistro", persona.FechaRegistro)
    '                command.Parameters.AddWithValue("@estado", persona.estado)
    '                command.Parameters.AddWithValue("@esproveedor", persona.esProveedor)
    '                command.Parameters.AddWithValue("@razonsocial", If(String.IsNullOrEmpty(persona.RazonSocial), DBNull.Value, persona.RazonSocial))

    '                command.ExecuteNonQuery()
    '            End Using
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Using
    'End Sub

    Public Sub InsertarProveedor(ByVal persona As CE_Personas, ByVal proveedor As CE_Proveedores)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Iniciar una transacción para asegurar que ambas inserciones se realicen correctamente
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    ' Insertar en la tabla Personas
                    Dim queryPersona As String = "INSERT INTO Personas (nombre, apellido, N_Documento, celular, direccion, fecha_resgistro, estado) " &
                                             "VALUES (@Nombre, @Apellido, @NDocumento, @Celular, @Direccion, @FechaRegistro, @Estado); " &
                                             "SELECT SCOPE_IDENTITY();" ' Obtener el ID generado de la persona

                    Dim cmdPersona As New SqlCommand(queryPersona, connection, transaction)
                    cmdPersona.Parameters.AddWithValue("@Nombre", If(String.IsNullOrEmpty(persona.Nombre), DBNull.Value, persona.Nombre))
                    cmdPersona.Parameters.AddWithValue("@Apellido", If(String.IsNullOrEmpty(persona.Apellido), DBNull.Value, persona.Apellido))
                    cmdPersona.Parameters.AddWithValue("@NDocumento", persona.NDocumento)
                    cmdPersona.Parameters.AddWithValue("@Celular", persona.Celular)
                    cmdPersona.Parameters.AddWithValue("@Direccion", persona.Direccion)
                    cmdPersona.Parameters.AddWithValue("@FechaRegistro", persona.FechaRegistro)
                    cmdPersona.Parameters.AddWithValue("@Estado", persona.estado)

                    ' Ejecutar y obtener el ID de la persona recién insertada
                    Dim personaId As Integer = Convert.ToInt32(cmdPersona.ExecuteScalar())

                    ' Insertar en la tabla Proveedores usando el id_persona obtenido
                    Dim queryProveedor As String = "INSERT INTO Proveedores (Razon_Social, persona_id) VALUES (@RazonSocial, @PersonaId)"
                    Dim cmdProveedor As New SqlCommand(queryProveedor, connection, transaction)
                    cmdProveedor.Parameters.AddWithValue("@RazonSocial", If(String.IsNullOrEmpty(proveedor.RazonSocial), DBNull.Value, proveedor.RazonSocial))
                    cmdProveedor.Parameters.AddWithValue("@PersonaId", personaId)

                    ' Ejecutar la inserción en la tabla Proveedores
                    cmdProveedor.ExecuteNonQuery()

                    ' Confirmar la transacción
                    transaction.Commit()

                Catch ex As Exception
                    ' Revertir la transacción en caso de error
                    transaction.Rollback()
                    Throw ex
                End Try

            Catch ex As Exception
                ' Manejar cualquier excepción
                Throw ex
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

    Public Sub ActivarProveedor(ByVal idPersona As Integer)
        Dim query As String = "UPDATE Personas SET estado = 'Activo' WHERE id_persona = @IdPersona"

        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                oconexion.Open()
                Using cmd As New SqlCommand(query, oconexion)
                    cmd.Parameters.AddWithValue("@IdPersona", idPersona)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar la persona: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ObtenerProveedorActivos() As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro, pr.razon_social
                                FROM Personas p
                                INNER JOIN Proveedores pr ON p.id_persona = pr.persona_id
                                LEFT JOIN Usuarios u ON p.id_persona = u.persona_id
                                WHERE u.persona_id IS NULL AND p.estado = 'Activo' "

        Using conn As New SqlConnection(Conexion.cadena)
            Using cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                conn.Open()
                da.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function ObtenerProveedorInactivos() As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro, pr.razon_social
                                FROM Personas p
                                INNER JOIN Proveedores pr ON p.id_persona = pr.persona_id
                                LEFT JOIN Usuarios u ON p.id_persona = u.persona_id
                                WHERE u.persona_id IS NULL AND p.estado = 'Inactivo'"




        Using conn As New SqlConnection(Conexion.cadena)
            Using cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                conn.Open()
                da.Fill(dt)
                Return dt
            End Using
        End Using
    End Function



    Public Sub ModificarProveedor(ByVal persona As CE_Personas, ByVal proveedor As CE_Proveedores)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Iniciar transacción para asegurarse de que ambas actualizaciones se realicen correctamente
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                ' Actualizar la tabla Personas
                Dim queryPersonas As String = "UPDATE Personas SET nombre = @Nombre, apellido = @Apellido, N_Documento = @NDocumento, celular = @Celular, direccion = @Direccion " &
                                          "WHERE id_persona = @IdPersona AND estado = 'Activo'"
                Using commandPersonas As New SqlCommand(queryPersonas, connection, transaction)
                    commandPersonas.Parameters.AddWithValue("@IdPersona", persona.IdPersona)
                    commandPersonas.Parameters.AddWithValue("@Nombre", If(String.IsNullOrEmpty(persona.Nombre), DBNull.Value, persona.Nombre))
                    commandPersonas.Parameters.AddWithValue("@Apellido", If(String.IsNullOrEmpty(persona.Apellido), DBNull.Value, persona.Apellido))
                    commandPersonas.Parameters.AddWithValue("@NDocumento", persona.NDocumento)
                    commandPersonas.Parameters.AddWithValue("@Celular", persona.Celular)
                    commandPersonas.Parameters.AddWithValue("@Direccion", persona.Direccion)

                    commandPersonas.ExecuteNonQuery()
                End Using

                ' Actualizar la tabla Proveedores
                Dim queryProveedores As String = "UPDATE Proveedores SET razon_social = @RazonSocial WHERE persona_id = @IdPersona"
                Using commandProveedores As New SqlCommand(queryProveedores, connection, transaction)
                    commandProveedores.Parameters.AddWithValue("@IdPersona", persona.IdPersona)
                    commandProveedores.Parameters.AddWithValue("@RazonSocial", If(String.IsNullOrEmpty(proveedor.RazonSocial), DBNull.Value, proveedor.RazonSocial))

                    commandProveedores.ExecuteNonQuery()
                End Using

                ' Confirmar transacción
                transaction.Commit()

            Catch ex As Exception
                Debug.WriteLine("Error: " & ex.Message) ' Para ayudar a identificar el error
                Throw
                Throw ex
            End Try
        End Using
    End Sub


    Public Sub EliminarProveedor(ByVal idPersona As Integer)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "UPDATE Personas SET estado = 'Inactivo' WHERE id_persona = @IdPersona"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdPersona", idPersona)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

    Public Function BuscarProveedorPorNombre(ByVal nombre As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                             "FROM Personas p " &
                             "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id  " &
                              "WHERE u.persona_id Is NULL And LOWER(p.nombre) Like '%' + @nombre + '%' " &
                              "AND p.estado = 'Activo'"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", nombre.ToLower())
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()

                connection.Open()
                adapter.Fill(dt)

                Return dt
            End Using
        End Using
    End Function

    Public Function BuscarProveedorPorApellido(ByVal apellido As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                               "FROM Personas p " &
                              "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id  " &
                              "WHERE u.persona_id IS NULL AND LOWER(p.apellido) LIKE '%' + @apellido + '%' " &
                              "AND p.estado = 'Activo'"

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@apellido", apellido.ToLower())
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()

                connection.Open()
                adapter.Fill(dt)

                Return dt
            End Using
        End Using
    End Function

    Public Function BuscarProveedorPorDNI(ByVal dni As String) As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                             "FROM Personas p " &
                                "LEFT JOIN Usuarios u ON p.id_persona = u.persona_id  " &
                              "WHERE u.persona_id IS NULL AND CAST(p.N_Documento AS VARCHAR) LIKE '%' + @dni + '%' " &
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

End Class
