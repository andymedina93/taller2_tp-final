Imports System.Data.SqlClient
Imports capa_entidad

Public Class CD_Productos
    Public Sub InsertarProducto(ByVal producto As CE_Productos)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                Dim query As String = "INSERT INTO Productos (Nombre, Descripcion, Codigo, Precio_vta,precio_compra, stock, estado, Categoria_id) " &
                                      "VALUES (@Nombre, @Descripcion, @Codigo, @PrecioVta,@PrecioCompra, @Stock, @Estado, @CategoriaId)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
                    command.Parameters.AddWithValue("@Codigo", producto.Codigo)
                    command.Parameters.AddWithValue("@PrecioVta", producto.PrecioVta)
                    command.Parameters.AddWithValue("@Preciocompra", producto.PrecioCompra)
                    command.Parameters.AddWithValue("@Stock", producto.Stock)
                    command.Parameters.AddWithValue("@Estado", producto.Estado)
                    command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId)

                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al insertar el producto: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ListarProductosPorEstado(ByVal estado As String) As DataTable
        Dim dtProductos As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Primero, actualiza los estados de los productos con stock cero a "Inactivo"
                Dim actualizarEstadoQuery As String = "
                UPDATE Productos
                SET estado = 'Inactivo'
                WHERE stock = 0 "
                Using updateCommand As New SqlCommand(actualizarEstadoQuery, connection)
                    updateCommand.ExecuteNonQuery()
                End Using

                ' Luego, consulta los productos según el estado solicitado
                Dim query As String = "
                SELECT 
                    p.id_producto, 
                    p.Nombre, 
                    p.Descripcion, 
                    p.Codigo, 
                    p.Precio_vta, 
                    p.Precio_Compra, 
                    p.stock, 
                    c.c_descripcion 
                FROM 
                    Productos p
                INNER JOIN 
                    Categorias c ON p.Categoria_id = c.Id_categoria
                WHERE 
                    p.estado = @Estado"

                Using command As New SqlCommand(query, connection)
                    ' Agregar el parámetro para el estado
                    command.Parameters.AddWithValue("@Estado", estado)

                    ' Usar SqlDataAdapter para llenar el DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtProductos)
                End Using

            Catch ex As SqlException
                Throw New Exception("Error al listar productos: " & ex.Message)
            End Try
        End Using

        Return dtProductos
    End Function


    Public Sub ModificarProducto(ByVal producto As CE_Productos)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta SQL para actualizar un producto
                Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Codigo = @Codigo, Precio_vta = @PrecioVta, Precio_compra = @Precio_compra, stock = @Stock, Categoria_id = @CategoriaId " &
                                      "WHERE id_producto = @IdProducto"

                Using command As New SqlCommand(query, connection)
                    ' Asignar los parámetros de la consulta
                    command.Parameters.AddWithValue("@IdProducto", producto.IdProducto)
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
                    command.Parameters.AddWithValue("@Codigo", producto.Codigo)
                    command.Parameters.AddWithValue("@PrecioVta", producto.PrecioVta)
                    command.Parameters.AddWithValue("@Precio_compra", producto.PrecioCompra)
                    command.Parameters.AddWithValue("@Stock", producto.Stock)
                    command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId)

                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                Throw New Exception("Error al modificar el producto: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub DarDeBajaProducto(ByVal idPersona As Integer)
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Actualizar el estado de la persona a "Inactivo"
                Dim query As String = "UPDATE Productos SET estado = 'Inactivo' WHERE id_producto = @IdProducto"
                Dim cmd As New SqlCommand(query, oconexion)
                cmd.Parameters.AddWithValue("@IdProducto", idPersona)

                oconexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al dar de baja al producto: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub ActivarProducto(ByVal idProducto As Integer)
        Using oconexion As New SqlConnection(Conexion.cadena)
            Try
                ' Actualizar el estado de la persona a "Activo"
                Dim query As String = "UPDATE Productos SET estado = 'Activo' WHERE id_producto = @IdProducto"
                Dim cmd As New SqlCommand(query, oconexion)
                cmd.Parameters.AddWithValue("@IdProducto", idProducto)

                oconexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al activar al producto: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function BuscarProductoPorCodigo(ByVal codigo As String) As DataTable
        Dim dtProductos As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta para buscar por código
                Dim query As String = "SELECT p.id_producto, p.Nombre, p.Descripcion, p.Codigo, p.Precio_vta, p.stock, c.c_descripcion AS Categoria " &
                                      "FROM Productos p " &
                                      "INNER JOIN Categorias c ON p.Categoria_id = c.Id_categoria " &
                                      "WHERE  CAST(p.codigo AS VARCHAR) LIKE '%' + @codigo + '%'"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtProductos)
                End Using

            Catch ex As Exception
                Throw New Exception("Error al buscar producto por código: " & ex.Message)
            End Try
        End Using

        Return dtProductos
    End Function

    ' Buscar producto por nombre
    Public Function BuscarProductoPorNombre(ByVal nombre As String) As DataTable
        Dim dtProductos As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta para buscar por nombre
                Dim query As String = "SELECT p.id_producto, p.Nombre, p.Descripcion, p.Codigo, p.Precio_vta, p.stock, c.c_descripcion AS Categoria " &
                                      "FROM Productos p " &
                                      "INNER JOIN Categorias c ON p.Categoria_id = c.Id_categoria " &
                                      "WHERE p.Nombre LIKE '%' + @Nombre + '%'"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtProductos)
                End Using

            Catch ex As Exception
                Throw New Exception("Error al buscar producto por nombre: " & ex.Message)
            End Try
        End Using

        Return dtProductos
    End Function

    ' Buscar producto por descripción
    Public Function BuscarProductoPorDescripcion(ByVal descripcion As String) As DataTable
        Dim dtProductos As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta para buscar por descripción
                Dim query As String = "SELECT p.id_producto, p.Nombre, p.Descripcion, p.Codigo, p.Precio_vta, p.stock, c.c_descripcion AS Categoria " &
                                      "FROM Productos p " &
                                      "INNER JOIN Categorias c ON p.Categoria_id = c.Id_categoria " &
                                      "WHERE p.Descripcion LIKE '%' + @Descripcion + '%'"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Descripcion", descripcion)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtProductos)
                End Using

            Catch ex As Exception
                Throw New Exception("Error al buscar producto por descripción: " & ex.Message)
            End Try
        End Using

        Return dtProductos
    End Function

    ' Buscar producto por categoría
    Public Function BuscarProductoPorCategoria(ByVal descripcion As String) As DataTable
        Dim dtProductos As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta para buscar por la descripción de la categoría
                Dim query As String = "SELECT p.id_producto, p.Nombre, p.Descripcion, p.Codigo, p.Precio_vta, p.stock, c.c_descripcion AS Categoria " &
                                      "FROM Productos p " &
                                      "INNER JOIN Categorias c ON p.Categoria_id = c.Id_categoria " &
                                      "WHERE c.c_descripcion LIKE '%' + @Descripcion + '%'"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Descripcion", descripcion)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtProductos)
                End Using

            Catch ex As Exception
                Throw New Exception("Error al buscar producto por la descripción de categoría: " & ex.Message)
            End Try
        End Using

        Return dtProductos
    End Function

    Public Function CodigoExiste(ByVal codigo As Integer) As Boolean
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Si es mayor a 0, el código ya existe
                End Using
            Catch ex As Exception
                Throw New Exception("Error al verificar si el código existe: " & ex.Message)
            End Try
        End Using
    End Function
    Public Function ObtenerProductosMasVendidosPorCategoria(fechaInicio As DateTime, fechaFin As DateTime, tope As Integer, categoriaDescripcion As String) As DataTable
        Dim query As String = "
        SELECT TOP (@Tope) 
            p.codigo AS CodigoProducto, 
            p.nombre AS NombreProducto, 
            c.c_descripcion AS Categoria, 
            SUM(vd.cantidad) AS CantidadVendida
        FROM Ventas_Detalles vd
        INNER JOIN Productos p ON vd.producto_id = p.id_producto
        INNER JOIN Categorias c ON p.categoria_id = c.id_categoria
        INNER JOIN Ventas_Cabecera vc ON vd.cabecera_id = vc.id_cabecera
        WHERE c.c_descripcion = @CategoriaDescripcion
            AND vc.FechaVenta BETWEEN @FechaInicio AND @FechaFin
        GROUP BY p.codigo, p.nombre, c.c_descripcion
        ORDER BY CantidadVendida DESC
    "

        Dim dt As New DataTable()
        Using connection As New SqlConnection(Conexion.cadena) ' Asegúrate de que tu clase `Conexion` tenga una cadena válida
            Using command As New SqlCommand(query, connection)
                ' Añadir los parámetros a la consulta
                command.Parameters.AddWithValue("@Tope", tope)
                command.Parameters.AddWithValue("@CategoriaDescripcion", categoriaDescripcion)
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

    Public Function ProductosVendidos(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        ' Crear la consulta SQL para obtener los productos más vendidos por categoría en el rango de fechas
        Dim query As String = "
        SELECT TOP (@Top) p.Nombre AS Producto, p.Descripcion, SUM(dv.Cantidad) AS TotalVendidos
        FROM productos p
        INNER JOIN ventas_detalles dv ON p.id_producto = dv.producto_id
        INNER JOIN ventas_cabecera vc ON dv.cabecera_id = vc.id_cabecera
        WHERE vc.FechaVenta BETWEEN @FechaInicio AND @FechaFin
        GROUP BY p.Nombre, p.Descripcion
        ORDER BY TotalVendidos DESC
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

    Public Function ObtenerStockActual(productoId As Integer) As Integer
        Dim stockActual As Integer = 0
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                Dim query As String = "SELECT stock FROM productos WHERE id_producto = @productoId"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@productoId", productoId)

                ' Abrir conexión y ejecutar consulta
                connection.Open()
                Dim result = command.ExecuteScalar()

                ' Si hay un valor en la consulta, lo asignamos a stockActual
                If result IsNot Nothing Then
                    stockActual = Convert.ToInt32(result)
                End If
            Catch ex As Exception
                Throw New Exception("Error al obtener el stock actual: " & ex.Message)
            Finally
                ' Cerrar la conexión
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

            Return stockActual
        End Using
    End Function

    ' Actualizar el stock de un producto en la base de datos
    Public Sub ActualizarStock(productoId As Integer, nuevoStock As Integer)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                Dim query As String = "UPDATE productos SET stock = @nuevoStock WHERE id_producto = @productoId"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nuevoStock", nuevoStock)
                command.Parameters.AddWithValue("@productoId", productoId)

                ' Abrir conexión y ejecutar comando de actualización
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al actualizar el stock: " & ex.Message)
            Finally
                ' Cerrar la conexión
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub



End Class

