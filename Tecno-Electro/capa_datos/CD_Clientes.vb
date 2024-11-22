Imports System.Data.SqlClient
Imports capa_entidad
Public Class CD_Clientes
    ' Método para insertar un nuevo cliente en la base de datos
    Public Sub InsertarCliente(ByVal cliente As CE_Personas)
        ' Conexión a la base de datos
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Personas (nombre, apellido, N_Documento, celular, direccion, Fecha_Resgistro,estado) " &
                                      "VALUES (@Nombre, @Apellido, @NDocumento, @Celular, @Direccion, @Fecha_Resgistro, @estado)"

                ' Crear el comando SQL con los parámetros
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido)
                    command.Parameters.AddWithValue("@NDocumento", cliente.NDocumento)
                    command.Parameters.AddWithValue("@Celular", cliente.Celular)
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion)
                    command.Parameters.AddWithValue("@Fecha_Resgistro", cliente.FechaRegistro)
                    command.Parameters.AddWithValue("@estado", cliente.estado)
                    ' Ejecutar la consulta de inserción
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al insertar el cliente: " & ex.Message)
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

    Public Function ObtenerClientesActivos() As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                      "FROM personas p " &
                      "LEFT JOIN usuarios u ON p.id_persona = u.persona_id " &
                      "LEFT JOIN proveedores pr ON p.id_persona = pr.persona_id " &
                      "WHERE p.estado = 'Activo' AND u.id_usuario IS NULL AND pr.id_proveedor IS NULL"


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

    Public Function ObtenerClientesInactivos() As DataTable
        Dim query As String = "SELECT p.id_persona, p.nombre, p.apellido, p.N_Documento, p.celular, p.direccion, p.fecha_resgistro " &
                      "FROM personas p " &
                      "LEFT JOIN usuarios u ON p.id_persona = u.persona_id " &
                      "LEFT JOIN proveedores pr ON p.id_persona = pr.persona_id " &
                      "WHERE p.estado = 'inactivo' AND u.id_usuario IS NULL AND pr.id_proveedor IS NULL"


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

    Public Sub ModificarPersona(ByVal persona As CE_Personas)
        Dim query As String = "UPDATE Personas SET nombre = @Nombre, apellido = @Apellido, N_Documento = @NDocumento, celular = @Celular, direccion = @Direccion WHERE id_persona = @IdPersona"

        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                oconexion.Open()
                Using cmd As New SqlCommand(query, oconexion)
                    cmd.Parameters.AddWithValue("@IdPersona", persona.IdPersona)
                    cmd.Parameters.AddWithValue("@Nombre", persona.Nombre)
                    cmd.Parameters.AddWithValue("@Apellido", persona.Apellido)
                    cmd.Parameters.AddWithValue("@NDocumento", persona.NDocumento)
                    cmd.Parameters.AddWithValue("@Celular", persona.Celular)
                    cmd.Parameters.AddWithValue("@Direccion", persona.Direccion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al modificar la persona: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para eliminar (cambiar el estado a inactivo) una persona
    ' Método para eliminar (cambiar el estado a inactivo) una persona
    Public Sub EliminarPersona(ByVal idPersona As Integer)
        Dim query As String = "UPDATE Personas SET estado = 'Inactivo' WHERE id_persona = @IdPersona"

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

    Public Sub ActivarPersona(ByVal idPersona As Integer)
        Dim query As String = "UPDATE Personas SET estado = 'Activo' WHERE id_persona = @IdPersona "

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

    Public Function BuscarClientesPorNombre(ByVal nombre As String) As DataTable
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

    Public Function BuscarClientesPorApellido(ByVal apellido As String) As DataTable
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

    Public Function BuscarClientesPorDNI(ByVal dni As String) As DataTable
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


    Public Function ObtenerMejoresClientes(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        Dim query As String = "
            SELECT TOP (@Top) c.Nombre AS Cliente, COUNT(vc.id_cabecera) AS CantidadCompras, SUM(vc.Monto_Total) AS TotalComprado
            FROM ventas_cabecera vc
            INNER JOIN personas c ON vc.cliente_id= c.id_persona
            WHERE vc.FechaVenta BETWEEN @FechaInicio AND @FechaFin
            GROUP BY c.Nombre
            ORDER BY TotalComprado DESC
        "

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


End Class
