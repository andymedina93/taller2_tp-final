Imports capa_entidad
Imports System.Data.SqlClient

Public Class CD_VentasDetalles
    ' En la capa de datos (cd_ventasdetalle)
    Public Function ObtenerVentasPorCategoria() As DataTable
        Dim query As String = "
            SELECT c.c_descripcion AS Categoria, SUM(vd.Cantidad) AS TotalVendidos
            FROM ventas_detalles vd
            INNER JOIN productos p ON vd.Producto_id = p.id_producto
            INNER JOIN categorias c ON p.Categoria_id = c.Id_categoria
            GROUP BY c.c_descripcion"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerDetallesPorVentaId(idVentaCabecera As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT  p.Nombre AS Producto,p.Descripcion AS Descripcion, vd.Cantidad, vd.Precio, (vd.Cantidad * vd.Precio) AS Subtotal " &
                                  "FROM ventas_detalles vd " &
                                  "INNER JOIN productos p ON vd.Producto_Id = p.Id_producto " &
                                  "WHERE vd.cabecera_id = @idVentaCabecera"

            Using connection As New SqlConnection(Conexion.cadena)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idVentaCabecera", idVentaCabecera)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los detalles de la venta: " & ex.Message)
        End Try

        Return dt
    End Function
    Public Sub InsertarVentaDetalle(ByVal detalle As CE_VentaDetalle)
        Try
            Using connection As New SqlConnection(Conexion.cadena)
                connection.Open()

                Dim query As String = "INSERT INTO ventas_detalles (producto_id, cantidad, precio, cabecera_id) " &
                                      "VALUES (@ProductoId, @Cantidad, @Precio, @cabeceraId)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductoId", detalle.ProductoId)
                    command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad)
                    command.Parameters.AddWithValue("@Precio", detalle.Precio)
                    command.Parameters.AddWithValue("@CabeceraId", detalle.IdDetalle)

                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using

        Catch ex As Exception
            Throw New Exception("Error al insertar detalle de venta: " & ex.Message)
        Finally

        End Try
    End Sub

    Public Function ObtenerVentasDetalles() As DataTable
        Dim dt As New DataTable()

        Try
            ' Crear una nueva conexión a la base de datos
            Using connection As New SqlConnection(Conexion.cadena)
                connection.Open()

                ' Definir la consulta SQL para obtener los detalles de las ventas
                Dim query As String = "SELECT vd.Id_detalle, p.Nombre AS Producto,vd.cabecera_id, vd.Cantidad, vd.Precio " &
                              "FROM ventas_detalles vd " &
                              "INNER JOIN productos p ON vd.producto_id = p.id_producto"

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Crear un adaptador para llenar el DataTable
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dt) ' Llenar el DataTable con los resultados de la consulta
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Lanzar una excepción si hay un error
            Throw New Exception("Error al obtener los detalles de las ventas: " & ex.Message)
        End Try

        ' Devolver el DataTable con los resultados
        Return dt
    End Function

    Public Function ObtenerVentasDelUsuario(idUsuario As Integer, fechaInicio As DateTime, fechaFin As DateTime) As DataTable
        Dim query As String = "
         SELECT 
            vc.id_cabecera, 
            vc.FechaVenta, 
            vc.Monto_Total, 
            p.nombre AS Producto, 
            vd.Cantidad, 
            vd.Precio,
            (vd.Cantidad * vd.Precio) AS TotalPorProducto
        FROM ventas_cabecera vc
        INNER JOIN ventas_detalles vd ON vc.id_cabecera = vd.id_cabecera
        INNER JOIN productos p ON vd.producto_id = p.id_producto
        WHERE vc.usuario_id = @idUsuario AND vc.FechaVenta BETWEEN @fechaInicio AND @fechaFin
    "

        Dim dt As New DataTable()
        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


End Class

