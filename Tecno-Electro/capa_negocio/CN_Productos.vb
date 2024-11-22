Imports System.Data.SqlClient
Imports capa_datos
Imports capa_entidad

Public Class CN_Productos
    Private objCD_Productos As New CD_Productos()

    Public Sub RegistrarProducto(ByVal producto As CE_Productos)
        If objCD_Productos.CodigoExiste(producto.Codigo) Then
            Throw New Exception("El código del producto ya existe. Ingrese un código único.")
        End If
        ' Aquí puedes añadir más validaciones o lógica de negocio si es necesario
        objCD_Productos.InsertarProducto(producto)
    End Sub

    ' Método para obtener productos activos
    Public Function ObtenerProductosActivos() As DataTable
        Return objCD_Productos.ListarProductosPorEstado("Activo")
    End Function

    ' Método para obtener productos inactivos
    Public Function ObtenerProductosInactivos() As DataTable
        Return objCD_Productos.ListarProductosPorEstado("Inactivo")
    End Function

    Public Sub ModificarProducto(ByVal producto As CE_Productos)
        ' Puedes agregar aquí validaciones adicionales antes de modificar el producto

        If String.IsNullOrEmpty(producto.Nombre) Then
            Throw New Exception("El nombre del producto no puede estar vacío.")
        End If

        If producto.PrecioVta <= 0 Then
            Throw New Exception("El precio de venta debe ser mayor a cero.")
        End If
        If producto.PrecioCompra <= 1 Then
            Throw New Exception("El precio de compra debe ser mayor a cero.")
        End If
        ' Llamar a la capa de datos para modificar el producto
        objCD_Productos.ModificarProducto(producto)
    End Sub

    Public Sub EliminarProducto(ByVal idProducto As Integer)
        Try
            ' Llamada a la capa de datos para cambiar el estado de la persona a "Inactivo"

            objCD_Productos.DarDeBajaProducto(idProducto)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja al producto: " & ex.Message)
        End Try
    End Sub

    Public Sub ActivarProducto(ByVal idProducto As Integer)
        Try

            objCD_Productos.ActivarProducto(idProducto)
        Catch ex As Exception
            Throw New Exception("Error al activar al producto: " & ex.Message)
        End Try
    End Sub

    Public Function BuscarPorCodigo(ByVal codigo As String) As DataTable
        Return objCD_Productos.BuscarProductoPorCodigo(codigo)
    End Function

    ' Buscar productos por nombre
    Public Function BuscarPorNombre(ByVal nombre As String) As DataTable
        Return objCD_Productos.BuscarProductoPorNombre(nombre)
    End Function

    ' Buscar productos por descripción
    Public Function BuscarPorDescripcion(ByVal descripcion As String) As DataTable
        Return objCD_Productos.BuscarProductoPorDescripcion(descripcion)
    End Function

    ' Buscar productos por categoría
    Public Function BuscarPorCategoria(ByVal categoria As String) As DataTable
        Return objCD_Productos.BuscarProductoPorCategoria(categoria)
    End Function

    ' Método para descontar el stock
    Public Sub DescontarStock(ByVal productoId As Integer, ByVal cantidad As Integer)
        Try
            Using connection As New SqlConnection(Conexion.cadena)
                connection.Open()

                ' Verificar el stock actual del producto
                Dim checkStockQuery As String = "SELECT stock FROM Productos WHERE id_producto = @ProductoId"
                Dim currentStock As Integer

                Using checkCommand As New SqlCommand(checkStockQuery, connection)
                    checkCommand.Parameters.AddWithValue("@ProductoId", productoId)
                    currentStock = Convert.ToInt32(checkCommand.ExecuteScalar())
                End Using

                ' Verificar si el stock es suficiente
                If currentStock < cantidad Then
                    Throw New Exception("No hay suficiente stock disponible para descontar.")
                End If

                ' Si el stock es suficiente, realizar el descuento
                Dim query As String = "UPDATE Productos SET stock = stock - @Cantidad WHERE id_producto = @ProductoId"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Cantidad", cantidad)
                    command.Parameters.AddWithValue("@ProductoId", productoId)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al descontar stock: " & ex.Message)
        End Try
    End Sub

    Public Function productosVendidos(fechaInicio As DateTime, fechaFin As DateTime, top As Integer, categoria As String) As DataTable
        Return objCD_Productos.ObtenerProductosMasVendidosPorCategoria(fechaInicio, fechaFin, top, categoria)

    End Function
    Public Function productosquemasseVendio(fechaInicio As DateTime, fechaFin As DateTime, top As Integer) As DataTable
        Return objCD_Productos.ProductosVendidos(fechaInicio, fechaFin, top)
    End Function

    Private datosProductos As New CD_Productos() ' Instancia de la capa de datos
    Private cambiosStock As New List(Of Tuple(Of Integer, Integer)) ' Lista de cambios de stock temporales

    ' Verifica y agrega el producto si hay stock suficiente
    Public Function VerificarStockYAgregarProducto(productoId As Integer, cantidad As Integer) As Boolean
        Dim stockActual As Integer = datosProductos.ObtenerStockActual(productoId)

        If cantidad > stockActual Then
            Return False ' No hay suficiente stock
        End If

        ' Resta stock temporalmente y agrega a la lista de cambios
        stockActual -= cantidad
        cambiosStock.Add(Tuple.Create(productoId, stockActual))
        datosProductos.ActualizarStock(productoId, stockActual) ' Actualización temporal en la base de datos
        Return True
    End Function
    Public Function ObtenerStock(productoid As Integer)
        Return objCD_Productos.ObtenerStockActual(productoid)
    End Function
    ' Restaura el stock si se cancela la venta
    Public Sub RestaurarStock(productoId As Integer, stockOriginal As Integer)

        objCD_Productos.ActualizarStock(productoId, stockOriginal)
        objCD_Productos.ActivarProducto(productoId)
    End Sub
End Class


