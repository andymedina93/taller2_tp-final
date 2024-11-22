Imports capa_datos.CD_VentasCabecera
Imports capa_entidad
Imports System.Data.SqlClient

Public Class CD_VentasCabecera
    ' Método para insertar una nueva venta en la tabla ventas_cabecera

    Public Function BuscarUsuarioPorDNI(dni As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim query As String = "
                SELECT 
                        vc.Id_cabecera AS Numero_Factura, 
                        vc.FechaVenta, 
                        p.Nombre AS NombreCliente, 
                        p.Apellido AS ApellidoCliente, 
                        p.N_Documento AS DNI_Cliente, 
                        u.Nombre AS NombreUsuario, 
                        u.Apellido AS ApellidoUsuario, 
                        u.N_Documento AS DNI_Usuario, 
                        vc.monto_Total
                FROM 
                    ventas_cabecera vc
                INNER JOIN 
                    personas p ON vc.cliente_id = p.id_persona
                INNER JOIN 
                    personas u ON vc.usuario_id = u.id_persona
                WHERE vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin " &
                          "AND
                    u.n_documento = @dni"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                command.Parameters.AddWithValue("@dni", dni)

                connection.Open()

                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function BuscarClientePorDNI(dni As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim query As String = "
                    SELECT 
                        vc.Id_cabecera AS Numero_Factura, 
                        vc.FechaVenta, 
                        p.Nombre AS NombreCliente, 
                        p.Apellido AS ApellidoCliente, 
                        p.N_Documento AS DNI_Cliente, 
                        u.Nombre AS NombreUsuario, 
                        u.Apellido AS ApellidoUsuario, 
                        u.N_Documento AS DNI_Usuario, 
                        vc.monto_Total
                    FROM 
                        ventas_cabecera vc
                    INNER JOIN 
                        personas p ON vc.cliente_id = p.id_persona
                    INNER JOIN 
                        personas u ON vc.usuario_id = u.id_persona
                    WHERE vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin " &
                          "AND
                         p.N_Documento = @dni"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                command.Parameters.AddWithValue("@dni", dni)

                connection.Open()

                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function
    Public Function ObtenerVentasPorFactura(idcabecera As Integer) As DataTable
        Dim query As String = "
    SELECT 
        vc.Id_cabecera AS Numero_Factura, 
        FORMAT(vc.FechaVenta, 'dd/MM/yyyy') AS FechaVenta, 
        cliente.Nombre AS NombreCliente, 
        cliente.Apellido AS ApellidoCliente, 
        cliente.N_Documento AS DNI_Cliente, 
        usuarioPersona.Nombre AS NombreUsuario, 
        usuarioPersona.Apellido AS ApellidoUsuario, 
        usuarioPersona.N_Documento AS DNI_Usuario, 
        vc.Monto_Total
    FROM 
        ventas_cabecera vc
    INNER JOIN 
        personas cliente ON vc.cliente_id = cliente.id_persona
    INNER JOIN 
        usuarios usuario ON vc.usuario_id = usuario.id_usuario
    INNER JOIN 
        personas usuarioPersona ON usuario.persona_id = usuarioPersona.id_persona
    WHERE 
        vc.id_cabecera = @idcabecera"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@idcabecera", idcabecera)

                connection.Open()

                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function



    Public Function ObtenerVentasPorFechaYUsuario(idUsuario As Integer, fechaInicio As Date, fechaFin As Date) As DataTable
        Dim query As String = "SELECT vc.id_cabecera as Numero_Factura, FORMAT(vc.FechaVenta, 'dd/MM/yyyy') AS FechaVenta, p.Nombre AS Cliente, vc.Monto_Total " &
                          "FROM ventas_cabecera vc " &
                          "INNER JOIN personas p ON vc.cliente_id = p.id_persona " &
                          "WHERE vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin " &
                          "AND vc.usuario_id = @idUsuario"

        Dim dt As New DataTable()
        Using connection As New SqlConnection(Conexion.cadena) ' Cambiar 'Conexion.cadena' por tu cadena de conexión
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)

                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function
    Public Function insertarventacabecera(ByVal cabecera As CE_VentaCabecera) As Integer
        Try
            Using connection As New SqlConnection(Conexion.cadena)
                connection.Open()

                Dim query As String = "insert into ventas_cabecera (usuario_id, cliente_id, monto_total,fechaventa) " &
                                          "output inserted.id_cabecera " &
                                          "values (@usuarioid, @clienteid, @montototal,@fechaventa)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuarioid", cabecera.UsuarioId)
                    command.Parameters.AddWithValue("@clienteid", cabecera.ClienteId)
                    command.Parameters.AddWithValue("@montototal", cabecera.MontoTotal)
                    command.Parameters.AddWithValue("@fechaventa", cabecera.fechaVenta)

                    'obtener el id de la cabecera recién insertada
                    Dim idcabecera As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return idcabecera
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("error al insertar cabecera de venta: " & ex.Message)
        End Try
    End Function
    'public function insertarventacabecera(byval cabecera as ce_ventacabecera) as integer
    '    try
    '        using connection as new sqlconnection(conexion.cadena)
    '            connection.open()

    '            dim query as string = "insert into ventas_cabecera (usuario_id, cliente_id, monto_total,fechaventa) " &
    '                                      "output inserted.id_cabecera " &
    '                                      "values (@usuarioid, @clienteid, @montototal,@fechaventa)"

    '            using command as new sqlcommand(query, connection)
    '                command.parameters.addwithvalue("@usuarioid", cabecera.usuarioid)
    '                command.parameters.addwithvalue("@clienteid", cabecera.clienteid)
    '                command.parameters.addwithvalue("@montototal", cabecera.montototal)
    '                command.parameters.addwithvalue("@fechaventa", cabecera.fechaventa)

    '                obtener el id de la cabecera recién insertada
    '                dim idcabecera as integer = convert.toint32(command.executescalar())
    '                return idcabecera
    '            end using
    '        end using
    '    catch ex as exception
    '        throw new exception("error al insertar cabecera de venta: " & ex.message)
    '    end try
    'end function



    Public Function ObtenerVentasCabecera(ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim dt As New DataTable()

        Try
            ' Crear una nueva conexión a la base de datos
            Using connection As New SqlConnection(Conexion.cadena)
                connection.Open()

                ' Definir la consulta SQL para obtener las ventas en el rango de fechas
                Dim query As String = "
                    SELECT 
                        vc.Id_cabecera AS Numero_Factura, 
                        vc.FechaVenta, 
                        p.Nombre AS NombreCliente, 
                        p.Apellido AS ApellidoCliente, 
                        p.N_Documento AS DNI_Cliente, 
                        u.Nombre AS NombreUsuario, 
                        u.Apellido AS ApellidoUsuario, 
                        u.N_Documento AS DNI_Usuario, 
                        vc.monto_Total
                    FROM 
                        ventas_cabecera vc
                    INNER JOIN 
                        personas p ON vc.cliente_id = p.id_persona
                    INNER JOIN 
                        personas u ON vc.usuario_id = u.id_persona
                    WHERE 
                        vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin"


                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                    command.Parameters.AddWithValue("@fechaFin", fechaFin)

                    ' Crear un adaptador para llenar el DataTable
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dt) ' Llenar el DataTable con los resultados de la consulta
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Lanzar una excepción si hay un error
            Throw New Exception("Error al obtener las ventas: " & ex.Message)
        End Try

        ' Devolver el DataTable con los resultados
        Return dt
    End Function

    Public Function ObtenerVentasPorUsuario(ByVal idUsuario As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim query As String = "
            SELECT vc.FechaVenta, p.Nombre AS Cliente, vc.montoTotal, 
            FROM ventas_cabecera vc
            INNER JOIN personas p ON vc.usuario_id = p.id_persona
            WHERE vc.usuario_id = @idUsuario AND vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin"

        Dim ventas As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(ventas)
                End Using
            End Using
        End Using

        Return ventas
    End Function

    Public Function BuscarPorFactura(ByVal factura As Integer, fechaInicio As Date, fechaFin As Date) As DataTable
        Dim query As String =
       "SELECT vc.id_cabecera as Numero_Factura, FORMAT(vc.FechaVenta, 'dd/MM/yyyy') AS FechaVenta, p.Nombre AS Cliente, vc.Monto_Total " &
                          "FROM ventas_cabecera vc " &
                          "INNER JOIN personas p ON vc.cliente_id = p.id_persona " &
                          "WHERE 
vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin " &
                          "AND vc.id_cabecera = @factura"
        Dim ventas As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                ' Agregar el parámetro con el valor correspondiente
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                command.Parameters.AddWithValue("@factura", factura)

                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(ventas)
                End Using
            End Using
        End Using

        Return ventas
    End Function

End Class

