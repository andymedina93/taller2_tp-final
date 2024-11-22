Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports capa_datos
Imports capa_entidad
Imports capa_negocio

Public Class Ventas
    Private WithEvents printDocument As New PrintDocument()
    Private ticketContent As String ' Aquí almacenaremos el contenido del ticket
    Private printPreview As New PrintPreviewDialog()
    Public Property id_usuario As Integer
    Public Property apellido As String
    Public Property NombreUsuario As String
    Dim productos As New CN_Productos
    Dim n_factura As Integer


    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'dim ultima as int32

        '' verificar si todos los campos están completos y la cantidad es válida
        'if me.validatechildren = true and txtbuscar.text <> "" and tapellido.text <> "" and tstock.text <> "" and tnombreusuario.text <> "" and tcodigo.text <> "" and tcantidad.text <> "" and tcantidad.value > 0 and tproducto.text <> "" and tprecioventa.text <> "" then
        '    ' verificar si el stock disponible es suficiente
        '    dim stockdisponible as integer = convert.toint32(tstock.text)


        '    if stockdisponible < convert.toint32(tcantidad.text) then
        '        messagebox.show("no hay suficiente stock disponible para agregar esta cantidad.")
        '    else
        '        ' si el stock es suficiente, agregar el producto a la venta
        '        bbuscarcliente.enabled = false

        '        dgventas.rows.add(tidproducto.text, tcodigo.text, tdescripcion.text, tproducto.text, tprecioventa.text, tcantidad.text, tprecioventa.text * tcantidad.text)
        '        total()
        '        limpiarproducto()
        '    end if
        'else
        '    ' si algún campo no está completo o la cantidad es inválida
        '    messagebox.show("cumple con todos los campos. la cantidad no puede ser 0 ni menor.")
        'end if

        'total()
        If Me.ValidateChildren = True And TxtBuscar.Text <> "" And TApellido.Text <> "" And TStock.Text <> "" And TNombreUsuario.Text <> "" And TCodigo.Text <> "" And TCantidad.Text <> "" And TCantidad.Value > 0 And TProducto.Text <> "" And TPrecioventa.Text <> "" Then
            Dim productoId As Integer = TidProducto.Text ' Obtiene el ID del producto seleccionado
            Dim cantidad As Integer = TCantidad.Text ' Obtiene la cantidad a agregar

            ' Verifica y agrega el producto
            If productos.VerificarStockYAgregarProducto(productoId, cantidad) Then
                BBuscarCliente.Enabled = False

                DgVentas.Rows.Add(TidProducto.Text, TCodigo.Text, TDescripcion.Text, TProducto.Text, TPrecioventa.Text, TCantidad.Text, TPrecioventa.Text * TCantidad.Text)
                total()
                LimpiarProducto()
            Else
                MessageBox.Show("No hay suficiente stock disponible.")
            End If
            total()
        Else
            '    ' si algún campo no está completo o la cantidad es inválida
            MessageBox.Show("cumple con todos los campos. la cantidad no puede ser 0 ni menor.")
        End If
    End Sub




    Sub LimpiarProducto()
        TCodigo.Text = ""
        TProducto.Text = ""
        TStock.Text = ""
        TCantidad.Value = 0
        TPrecioventa.Text = ""
    End Sub

    Sub LimpiarCliente()
        TxtBuscar.Text = ""
        TApellido.Text = ""

    End Sub


    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()

        ' Verificar si el TextBox está vacío
        If String.IsNullOrEmpty(valorBuscar) Then
            ' Si está vacío, limpiar el TextBox de nombre y apellido
            TNombre.Text = String.Empty
            TApellido.Text = String.Empty
            Return
        End If

        ' Verificar que el valor a buscar tenga al menos 1 carácter para evitar errores
        If valorBuscar.Length < 8 Then
            ' Evitar ejecutar búsquedas con menos de 1 carácter
            Return
        End If

        ' Llamar al método de la capa de negocio para buscar clientes por DNI
        Try
            Dim objNegocio As New CN_Personas()
            Dim dtClientes As DataTable

            ' Convertir a Long para evitar problemas con el tipo de dato
            Dim dni As Long
            If Long.TryParse(valorBuscar, dni) Then
                dtClientes = objNegocio.BuscarClientesPorDNI(dni)

                If dtClientes IsNot Nothing AndAlso dtClientes.Rows.Count > 0 Then
                    ' Si se encuentra el cliente, mostrar nombre y apellido en el TextBox
                    Dim nombre As String = dtClientes.Rows(0)("nombre").ToString()
                    Dim apellido As String = dtClientes.Rows(0)("apellido").ToString()
                    Dim idcliente As String = dtClientes.Rows(0)("id_persona").ToString()
                    TClienteId.Text = $"{idcliente}"
                    TNombre.Text = $"{nombre}"
                    TApellido.Text = $"{apellido}"
                Else
                    ' Si no se encuentra el cliente, mostrar mensaje en el TextBox
                    TNombre.Text = "No se encontró"
                    TApellido.Text = "No se encontró"
                    TClienteId.Text = String.Empty
                End If
            Else
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Limpiar el TextBox de nombre y apellido si el DNI no es válido
                TNombre.Text = String.Empty
                TApellido.Text = String.Empty
                TClienteId.Text = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Limpiar el TextBox de nombre y apellido en caso de error
            TNombre.Text = String.Empty
            TApellido.Text = String.Empty
            TClienteId.Text = String.Empty
        End Try
    End Sub

    Private Sub TCodigo_TextChanged(sender As Object, e As EventArgs) Handles TCodigo.TextChanged
        ' Obtener el valor ingresado desde el TextBox de código
        Dim valorBuscar As String = TCodigo.Text.Trim()

        ' Verificar si el TextBox está vacío
        If String.IsNullOrEmpty(valorBuscar) Then
            ' Si está vacío, limpiar los TextBox de nombre, precio de venta y stock
            TidProducto.Text = String.Empty
            TProducto.Text = String.Empty
            TPrecioventa.Text = String.Empty
            TStock.Text = String.Empty
            TDescripcion.Text = String.Empty
            Return
        End If

        ' Verificar que el valor a buscar tenga al menos 4 caracteres
        If valorBuscar.Length < 4 Then
            ' Evitar ejecutar búsquedas con menos de 4 caracteres
            Return
        End If

        ' Llamar al método de la capa de negocio para buscar productos por código
        Try
            Dim objNegocio As New CN_Productos()
            Dim dtProducto As DataTable

            ' Convertir a Integer para evitar problemas con el tipo de dato
            Dim codigo As Integer
            If Integer.TryParse(valorBuscar, codigo) Then
                dtProducto = objNegocio.BuscarPorCodigo(codigo)

                If dtProducto IsNot Nothing AndAlso dtProducto.Rows.Count > 0 Then
                    ' Si se encuentra el producto, mostrar nombre, precio de venta y stock en los TextBox
                    TProducto.Text = dtProducto.Rows(0)("nombre").ToString()
                    TPrecioventa.Text = dtProducto.Rows(0)("precio_vta").ToString()
                    TStock.Text = dtProducto.Rows(0)("stock").ToString()
                    TidProducto.Text = dtProducto.Rows(0)("id_producto").ToString()
                    TDescripcion.Text = dtProducto.Rows(0)("descripcion").ToString()
                Else
                    ' Si no se encuentra el producto, mostrar mensaje en los TextBox
                    TProducto.Text = "No se encontró"
                    TPrecioventa.Text = String.Empty
                    TStock.Text = String.Empty
                    TidProducto.Text = String.Empty
                    TDescripcion.Text = String.Empty
                End If
            Else
                MessageBox.Show("Por favor, ingrese un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Limpiar los TextBox de producto si el código no es válido
                TProducto.Text = String.Empty
                TPrecioventa.Text = String.Empty
                TStock.Text = String.Empty
                TidProducto.Text = String.Empty
                TDescripcion.Text = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Limpiar los TextBox de producto en caso de error
            TProducto.Text = String.Empty
            TPrecioventa.Text = String.Empty
            TStock.Text = String.Empty
            TidProducto.Text = String.Empty
            TDescripcion.Text = String.Empty
        End Try
    End Sub

    Sub total()
        Dim total As Decimal
        total = 0
        For i = 0 To DgVentas.Rows.Count - 1
            total = total + DgVentas.Item(6, i).Value
        Next
        TotalPagar.Text = total
    End Sub


    'Sub PagaCon()

    '    Dim pagoCon As Double

    '    If Double.TryParse(Tpagacon.Text, pagoCon) Then
    '        ' El valor en Tpagacon.Text es un número válido
    '        If pagoCon > Convert.ToDouble(TotalPagar.Text) Then
    '            Tvuelto.Text = (pagoCon - Convert.ToDouble(TotalPagar.Text)).ToString()
    '        Else
    '            MessageBox.Show("El dinero ingresado es menor al monto a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub ' Salir del procedimiento si la condición no se cumple
    '        End If
    '    Else
    '        MessageBox.Show("Ingrese un valor numérico válido en el campo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub ' Salir del procedimiento si el valor no es un número válido
    '    End If
    'End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click

        Try
            ' Verificar si hay productos en el DataGridView
            If DgVentas.Rows.Count = 0 Then
                MessageBox.Show("No hay productos seleccionados para la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Crear la cabecera de la venta
            Dim ventaCabecera As New CE_VentaCabecera With {
            .UsuarioId = Convert.ToInt32(TUsuarioId.Text),
            .ClienteId = Convert.ToInt32(TClienteId.Text),
            .MontoTotal = Convert.ToInt32(TotalPagar.Text),
            .fechaVenta = Tfecha.Text
        }

            ' Crear la lista de detalles de la venta
            Dim listaDetalles As New List(Of CE_VentaDetalle)()

            For Each row As DataGridViewRow In DgVentas.Rows
                Dim detalle As New CE_VentaDetalle With {
                .ProductoId = Convert.ToInt32(row.Cells("idproducto").Value),
                .Cantidad = Convert.ToInt32(row.Cells("Cantidad").Value),
                .Precio = Convert.ToDecimal(row.Cells("Precio").Value)
            }
                listaDetalles.Add(detalle)
            Next

            ' Llamar a la capa de negocio para registrar la venta
            Dim objCN_Ventas As New CN_Ventas()
            n_factura = objCN_Ventas.RegistrarVenta(ventaCabecera, listaDetalles)

            ' Mostrar mensaje de éxito
            MessageBox.Show("Venta realizada correctamente, N°Factura; " & n_factura, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            imprimirTicket()
            ' Limpiar la interfaz
            DgVentas.Rows.Clear()
            BBuscarCliente.Enabled = True
            LimpiarProducto()
            LimpiarCliente()
        Catch ex As Exception
            MessageBox.Show("Error al realizar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'private sub bguardar_click(sender as object, e as eventargs) handles bguardar.click

    '    try
    '        ' verificar si hay productos en el datagridview
    '        if dgventas.rows.count = 0 then
    '            messagebox.show("no hay productos seleccionados para la venta.", "error", messageboxbuttons.ok, messageboxicon.error)
    '            return
    '        end if

    '        ' crear la cabecera de la venta
    '        dim ventacabecera as new ce_ventacabecera with {
    '        .usuarioid = convert.toint32(tusuarioid.text),
    '        .clienteid = convert.toint32(tclienteid.text),
    '        .montototal = convert.toint32(totalpagar.text),
    '        .fechaventa = tfecha.text
    '    }

    '        ' crear la lista de detalles de la venta
    '        dim listadetalles as new list(of ce_ventadetalle)()

    '        for each row as datagridviewrow in dgventas.rows
    '            dim detalle as new ce_ventadetalle with {
    '            .productoid = convert.toint32(row.cells("idproducto").value),
    '            .cantidad = convert.toint32(row.cells("cantidad").value),
    '            .precio = convert.todecimal(row.cells("precio").value)
    '        }
    '            listadetalles.add(detalle)
    '        next

    '        ' llamar a la capa de negocio para registrar la venta
    '        dim objcn_ventas as new cn_ventas()
    '        objcn_ventas.registrarventa(ventacabecera, listadetalles)

    '        ' mostrar mensaje de éxito
    '        messagebox.show("venta realizada correctamente.", "éxito", messageboxbuttons.ok, messageboxicon.information)
    '        imprimirticket()
    '        ' limpiar la interfaz
    '        dgventas.rows.clear()
    '        limpiarproducto()

    '    catch ex as exception
    '        messagebox.show("error al realizar la venta: " & ex.message, "error", messageboxbuttons.ok, messageboxicon.error)
    '    end try
    'end sub


    Sub imprimirTicket()

        ' Guardamos el contenido del ticket en una variable


        ' Enlaza el evento PrintPage al manejador
        AddHandler printDocument.PrintPage, AddressOf PrintPageHandler

        ' Iniciar la vista previa de impresión
        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDocument
        printPreview.ShowDialog()
    End Sub



    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim fuente As New Font("Arial", 14)
        Dim margenIzquierdo As Integer = e.MarginBounds.Left
        Dim margenSuperior As Integer = e.MarginBounds.Top
        Dim lineaAltura As Single = fuente.GetHeight(e.Graphics)
        Dim ticket As New System.Text.StringBuilder()

        ' Obtener el nombre del vendedor y cliente desde los TextBox
        Dim nombreVendedor As String = TNombreUsuario.Text
        Dim nombreCliente As String = TApellido.Text & " "& TNombre.text


        ' Definir anchos fijos para cada columna
        Dim columnaProductoAncho As Integer = 100
        Dim columnaDescripcionAncho As Integer = 150
        Dim columnaCantidadAncho As Integer = 90
        Dim columnaPrecioAncho As Integer = 90
        Dim columnaSubtotalAncho As Integer = 100

        ' Imprimir encabezado del ticket
        e.Graphics.DrawString("***************************** TICKET DE VENTA *******************************", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura

        e.Graphics.DrawString("N° Factura: " & n_factura, fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura
        e.Graphics.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura
        e.Graphics.DrawString("Vendedor: " & nombreVendedor, fuente, Brushes.Black, margenIzquierdo, margenSuperior) ' Agregar el nombre del vendedor
        margenSuperior += lineaAltura
        e.Graphics.DrawString("Cliente: " & nombreCliente, fuente, Brushes.Black, margenIzquierdo, margenSuperior) ' Agregar el nombre del cliente
        margenSuperior += lineaAltura
        e.Graphics.DrawString("-----------------------------------------------------------------------------", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura

        ' Imprimir títulos de columnas
        e.Graphics.DrawString("Producto", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        e.Graphics.DrawString("Cantidad", fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho, margenSuperior)
        e.Graphics.DrawString("Precio", fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho + columnaCantidadAncho, margenSuperior)
        e.Graphics.DrawString("Sub-total", fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho + columnaCantidadAncho + columnaPrecioAncho, margenSuperior)
        margenSuperior += lineaAltura
        e.Graphics.DrawString("------------------------------------------------------------------------------", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura
     
        ' Imprimir los productos
        For Each row As DataGridViewRow In DgVentas.Rows
            If Not row.IsNewRow Then
                Dim producto As String = If(row.Cells("Producto").Value IsNot Nothing, row.Cells("Producto").Value.ToString(), "N/A")
                Dim cantidad As String = If(row.Cells("Cantidad").Value IsNot Nothing, row.Cells("Cantidad").Value.ToString(), "0")
                Dim precio As String = If(row.Cells("Precio").Value IsNot Nothing, row.Cells("Precio").Value.ToString(), "0.00")
                Dim subTotal As String = If(row.Cells("sub_total").Value IsNot Nothing, row.Cells("sub_total").Value.ToString(), "0.00")

                ' Imprimir cada columna en su posición correspondiente
                e.Graphics.DrawString(producto, fuente, Brushes.Black, margenIzquierdo, margenSuperior)

                e.Graphics.DrawString(cantidad, fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho, margenSuperior)
                e.Graphics.DrawString(precio, fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho + columnaCantidadAncho, margenSuperior)
                e.Graphics.DrawString(subTotal, fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho + columnaCantidadAncho + columnaPrecioAncho, margenSuperior)

                margenSuperior += lineaAltura ' Mover hacia abajo para la próxima fila
            End If
        Next
        e.Graphics.DrawString("------------------------------------------------------------------------------", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura
        e.Graphics.DrawString("Total: $ " & TotalPagar.Text, fuente, Brushes.Black, margenIzquierdo + columnaProductoAncho + columnaDescripcionAncho + columnaCantidadAncho + columnaPrecioAncho, margenSuperior)

        ' Pie del ticket
        margenSuperior += lineaAltura
        ' Pie del ticket
        e.Graphics.DrawString("---------------------------------------------------------------------------------------", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
        margenSuperior += lineaAltura
        e.Graphics.DrawString("Gracias por su compra!", fuente, Brushes.Black, margenIzquierdo, margenSuperior)
    End Sub


    Private Function CalcularMontoTotal() As Decimal
        Dim montoTotal As Decimal = 0

        For Each row As DataGridViewRow In DgVentas.Rows
            Dim precio As Decimal = Convert.ToDecimal(row.Cells("CPrecio").Value)
            Dim cantidad As Integer = Convert.ToInt32(row.Cells("CCantidad").Value)
            montoTotal += (precio * cantidad)
        Next

        Return montoTotal
    End Function

    Private Sub BBuscarCliente_Click(sender As Object, e As EventArgs) Handles BBuscarCliente.Click
        BusquedaCliente.Show()
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        BusquedaProducto.Show()
    End Sub

    Public Sub seleccionarProducto(vNombre As String, vPrecio As Double, vCodigo As Integer, vId As Integer, vdescripcion As String, vstock As Integer)

        ' carga los text box con el registro selccionado
        TidProducto.Text = vId
        TCodigo.Text = vCodigo
        TPrecioventa.Text = vPrecio
        TStock.Text = vstock
        TDescripcion.Text = vdescripcion
        TProducto.Text = vNombre

    End Sub

    Public Sub seleccionarCliente(valor1 As String, valor2 As String, valor3 As String, valor4 As String)

        ' carga los text box con el registro selccionado
        TApellido.Text = valor2
        TNombre.Text = valor1
        TxtBuscar.Text = valor3
        TClienteId.Text = valor4

    End Sub

    ' Agrega este código en el formulario donde inicializas el DataGridView


    ' Agrega este código en el evento CellClick del DataGridView
    Private Sub DgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVentas.CellClick
        ' Verifica si la columna seleccionada es la de botón (btnEliminar)
        If e.ColumnIndex = DgVentas.Columns("quitar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtiene el ID del producto y la cantidad de la fila seleccionada
            Dim productoId As Integer = Convert.ToInt32(DgVentas.Rows(e.RowIndex).Cells("idProducto").Value)
            Dim cantidad As Integer = Convert.ToInt32(DgVentas.Rows(e.RowIndex).Cells("Cantidad").Value)
            Dim stockActual As Integer = productos.ObtenerStock(productoId)

            ' Restaurar el stock sumando la cantidad vendida
            Dim nuevoStock As Integer = stockActual + cantidad
            ' Llama al método para restaurar el stock en la base de datos
            productos.RestaurarStock(productoId, nuevoStock)

            ' Elimina la fila del DataGridView
            DgVentas.Rows.RemoveAt(e.RowIndex)

        End If
    End Sub




    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TUsuarioId.Text = id_usuario
        TNombreUsuario.Text = apellido & " " & NombreUsuario
    End Sub

    Private Sub DgVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVentas.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BBuscarCliente.Enabled = True
        RestaurarStockDesdeDataGrid(DgVentas)
        LimpiarCliente()
        LimpiarProducto()
        LimpiarDataGrid()
        ' Restaura el stock si se cancela la venta
    End Sub
    Public Sub RestaurarStockDesdeDataGrid(dataGridView As DataGridView)
        For Each row As DataGridViewRow In dataGridView.Rows
            ' Obtén el productoId y la cantidad de la fila actual
            Dim productoId As Integer = Convert.ToInt32(row.Cells("idProducto").Value)
            Dim cantidadVendida As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)

            ' Obtener el stock actual
            Dim stockActual As Integer = productos.ObtenerStock(productoId)

            ' Restaurar el stock sumando la cantidad vendida
            Dim nuevoStock As Integer = stockActual + cantidadVendida
            productos.RestaurarStock(productoId, nuevoStock)
        Next

        MessageBox.Show("Venta Cancelada correctamente.", "Restaurar Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub LimpiarDataGrid()
        DgVentas.Rows.Clear()
    End Sub

End Class