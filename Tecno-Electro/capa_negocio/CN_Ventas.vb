Imports System.Data.SqlClient
Imports capa_datos
Imports capa_entidad
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Microsoft.VisualBasic.Logging

Public Class CN_Ventas

    Private ventasCabecera As New CD_VentasCabecera()
    Private ventasDetalle As New CD_VentasDetalles()
    ' En la capa de negocio (CN_Ventas)
    Public Function ObtenerVentasPorCategoria() As DataTable
        Dim cdVentas As New CD_VentasDetalles()
        Return cdVentas.ObtenerVentasPorCategoria()
    End Function

    Public Function RegistrarVenta(ventaCabecera As CE_VentaCabecera, listaDetalles As List(Of CE_VentaDetalle)) As Integer
        Dim idVenta As Integer

        ' Registrar la cabecera y obtener el ID de la venta
        idVenta = ventasCabecera.insertarventacabecera(ventaCabecera)

        ' Registrar los detalles
        For Each detalle As CE_VentaDetalle In listaDetalles
            detalle.IdDetalle = idVenta  ' Asignar el ID de la cabecera a cada detalle
            ventasDetalle.InsertarVentaDetalle(detalle)
        Next

        Return idVenta
    End Function

    ' Función para realizar una venta
    'Public Function RegistrarVenta(ByVal cabecera As CE_VentaCabecera, ByVal detalles As List(Of CE_VentaDetalle)) As Boolean
    '    Try
    '        Insertar la cabecera de la venta
    '        Dim idVentaCabecera As Integer = ventasCabecera.insertarventacabecera(cabecera)

    '        If idVentaCabecera > 0 Then
    '            Insertar los detalles de la venta
    '            For Each detalle As CE_VentaDetalle In detalles
    '                detalle.IdDetalle = idVentaCabecera
    '                ventasDetalle.InsertarVentaDetalle(detalle)

    '                Actualizar el stock

    '            Next
    '        End If

    '        Return True
    '    Catch ex As Exception
    '        Manejar errores
    '        Throw New Exception("Error al realizar la venta: " & ex.Message)
    '    End Try
    'End Function




    ' Método para actualizar el stock
    Private Sub ActualizarStock(ByVal productoId As Integer, ByVal cantidadVendida As Integer)
        Dim producto As New CN_Productos()
        producto.DescontarStock(productoId, cantidadVendida)
    End Sub

    Public Function obtenerventasUsuario(ByVal usuarioid As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date)
        Dim ventasDataTable As New DataTable()
        Dim datos As New CD_VentasCabecera()

        ' Llamada a la capa de datos para obtener las ventas
        ventasDataTable = datos.ObtenerVentasPorFechaYUsuario(usuarioid, fechaInicio, fechaFin)

        ' Puedes agregar lógica adicional si es necesario antes de devolver los datos

        Return ventasDataTable
    End Function

    Public Function obtenerventasn_factura(ByVal factura As Integer) As (Boolean, Integer, String, String, String, String, Double)
        Dim dt As New DataTable()
        Dim datos As New CD_VentasCabecera()

        ' Llamada a la capa de datos para obtener las ventas
        dt = datos.ObtenerVentasPorFactura(factura)

        If dt.Rows.Count > 0 Then
            ' Si el usuario existe, devuelve los datos
            Dim idUsuario As Integer = Convert.ToInt32(dt.Rows(0)("Numero_Factura"))
            Dim nombre As String = dt.Rows(0)("NombreUsuario").ToString()
            Dim nombreCliente As String = dt.Rows(0)("NombreCliente").ToString()
            Dim apellido As String = dt.Rows(0)("ApellidoUsuario").ToString()
            Dim apellidocliente As String = dt.Rows(0)("ApellidoCliente").ToString()
            Dim total As Integer = Convert.ToInt32(dt.Rows(0)("monto_total"))

            ' Retorna True indicando que el login fue exitoso y los datos
            Return (True, idUsuario, nombre, nombreCliente, apellido, apellidocliente, total)
        Else
            ' Si no se encuentra el usuario o la contraseña, retorna False
            Return (False, 0, String.Empty, String.Empty, String.Empty, String.Empty, 0)
        End If
    End Function


    Public Function ObtenerDetallesPorVentaId(idVentaCabecera As Integer) As DataTable
        Dim datosVentasDetalle As New CD_VentasDetalles()
        Return datosVentasDetalle.ObtenerDetallesPorVentaId(idVentaCabecera)
    End Function


    Public Function ObtenerReporteVentas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim dtcabecera As DataTable = ventasCabecera.ObtenerVentasCabecera(fechaInicio, fechaFin)
        ' Llamada a la capa de datos para obtener las ventas

        ' Puedes agregar lógica adicional si es necesario antes de devolver los datos

        Return dtcabecera

    End Function

    Public Function BuscarDNIcliente(ByVal dni As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        ' Implementar la lógica para buscar por Apellido
        Dim dtcabecera As DataTable = ventasCabecera.BuscarClientePorDNI(dni, fechaInicio, fechaFin)
        Return dtcabecera
    End Function
    Public Function BuscardniUsuario(ByVal dni As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim dtcabecera As DataTable = ventasCabecera.BuscarUsuarioPorDNI(dni, fechaInicio, fechaFin)
        Return dtcabecera
    End Function
    Public Function ObtenerStock(tope As Integer) As DataTable
        ' Crear la consulta SQL para obtener los productos
        Dim query As String = "
       SELECT  Codigo, Nombre,Descripcion,Stock FROM productos
          WHERE Stock <= @tope
          ORDER BY  Stock ASC;"


        ' Crear el DataTable que devolverá los resultados
        Dim dt As New DataTable()

        ' Establecer la conexión a la base de datos
        Using connection As New SqlConnection(Conexion.cadena)
            Using command As New SqlCommand(query, connection)
                ' Agregar los parámetros a la consulta

                command.Parameters.AddWithValue("@Tope", tope)

                ' Llenar el DataTable con los datos obtenidos de la consulta
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using

        ' Devolver el DataTable con los resultados
        Return dt
    End Function

    ' Método para generar el reporte de ventas en PDF


    Public Sub GenerarReporteVentasPDF(resultado As Tuple(Of DataTable, Decimal), filePath As String, reporte As String, cliente As String, usuario As String, factura As Integer, total As Double)
        Dim datos As DataTable = resultado.Item1

        ' Obtener el total de ventas
        Dim totalVentas As Decimal = resultado.Item2
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)

        Try
            Dim writer = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()
            Try
                ' Cargar la imagen (asegúrate de que la ruta sea correcta)
                Dim img As Image = Image.GetInstance("C:\Users\andim\OneDrive\Escritorio\G30_MbenitezAugusto_MedinaAndrea\imagenes\logo.jpg")

                ' Establecer el tamaño de la imagen (opcional)


                ' Establecer la posición de la imagen (opcional)
                img.SetAbsolutePosition(480, 770) ' Ajusta la posición de la imagen

                ' Agregar la imagen al documento
                doc.Add(img)
            Catch ex As Exception
                Console.WriteLine("Error al agregar la imagen: " & ex.Message)
            End Try
            ' Título del reporte
            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim subtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            doc.Add(New Paragraph(" "))
            Dim titleParagraph As New Paragraph(reporte, titleFont)
            titleParagraph.Alignment = Element.ALIGN_CENTER
            doc.Add(titleParagraph)
            doc.Add(New Paragraph("N° Factura : " & factura))
            doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")))
            doc.Add(New Paragraph("vendedor : " & usuario))
            doc.Add(New Paragraph("Cliente : " & cliente))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))

            ' Creación de la tabla en el PDF
            Dim pdfTable As New PdfPTable(datos.Columns.Count)
            pdfTable.WidthPercentage = 100

            ' Agregar encabezados al PDF
            For Each column As DataColumn In datos.Columns
                Dim cell = New PdfPCell(New Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(cell)
            Next

            ' Agregar datos del DataTable a la tabla
            For Each row As DataRow In datos.Rows
                For Each cellValue In row.ItemArray
                    pdfTable.AddCell(cellValue.ToString())
                Next
            Next

            doc.Add(pdfTable)
            doc.Add(New Paragraph(" "))
            If reporte = "Detalles  Ventas" Then
                doc.Add(New Paragraph("Total de Ventas: $ " & total))
            End If
            doc.Add(New Paragraph("Generado por el vendedor : Tecno_ Elector"))
        Catch ex As Exception
            Throw New Exception("Error al generar el reporte de ventas en PDF: " & ex.Message)
        Finally
            doc.Close()
        End Try
    End Sub

    Public Sub GenerarPDF(resultado As Tuple(Of DataTable, Decimal), filePath As String, reporte As String, usuario As String, apellido As String)
        Dim datos As DataTable = resultado.Item1

        ' Obtener el total de la columna "Monto_Total"
        Dim totalVentas As Decimal = datos.AsEnumerable().Sum(Function(row) Convert.ToDecimal(row("Monto_Total")))

        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)

        Try
            Dim writer = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()
            Try
                ' Cargar la imagen (asegúrate de que la ruta sea correcta)
                Dim img As Image = Image.GetInstance("C:\Users\andim\OneDrive\Escritorio\G30_MbenitezAugusto_MedinaAndrea\imagenes\logo.jpg")

                ' Establecer el tamaño de la imagen (opcional)

                ' Establecer la posición de la imagen (opcional)
                img.SetAbsolutePosition(480, 770) ' Ajusta la posición de la imagen

                ' Agregar la imagen al documento
                doc.Add(img)
            Catch ex As Exception
                Console.WriteLine("Error al agregar la imagen: " & ex.Message)
            End Try

            ' Título del reporte
            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim subtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            doc.Add(New Paragraph(" "))
            Dim titleParagraph As New Paragraph(reporte, titleFont)
            titleParagraph.Alignment = Element.ALIGN_CENTER
            doc.Add(titleParagraph)
            doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")))
            doc.Add(New Paragraph("Vendedor: " & usuario & " " & apellido))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))

            ' Crear la tabla en el PDF, excluyendo la columna "detalles"
            Dim columnNames = datos.Columns.Cast(Of DataColumn)().
            Where(Function(col) col.ColumnName.ToLower() <> "detalles").ToList()

            Dim pdfTable As New PdfPTable(columnNames.Count)
            pdfTable.WidthPercentage = 100

            ' Agregar encabezados al PDF
            For Each column As DataColumn In columnNames
                Dim cell = New PdfPCell(New Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(cell)
            Next

            ' Agregar datos del DataTable a la tabla
            For Each row As DataRow In datos.Rows
                For Each column As DataColumn In columnNames
                    pdfTable.AddCell(row(column.ColumnName).ToString())
                Next
            Next

            doc.Add(pdfTable)
            doc.Add(New Paragraph(" "))

            ' Agregar el total de ventas al final
            doc.Add(New Paragraph("Total de Ventas: $ " & totalVentas.ToString("F2")))

            doc.Add(New Paragraph("Generado por el vendedor: Tecno_Electro"))
        Catch ex As Exception
            Throw New Exception("Error al generar el reporte de ventas en PDF: " & ex.Message)
        Finally
            doc.Close()
        End Try
    End Sub



    Private ventasData As New CD_VentasCabecera

    Public Function ObtenerReporteDeCierre(idUsuario As Integer, fechaInicio As Date, fechaFin As Date) As Tuple(Of DataTable, Decimal)
        Dim ventas As DataTable = ventasData.ObtenerVentasPorUsuario(idUsuario, fechaInicio, fechaFin)
        Dim totalVentas As Decimal = ventas.AsEnumerable().Sum(Function(row) Convert.ToDecimal(row("TotalVenta")))

        Return Tuple.Create(ventas, totalVentas)
    End Function

    Public Function Buscarfactura(ByVal codigo As String, fechaInicio As Date, fechaFin As Date) As DataTable
        Dim datosVentasDetalle As New CD_VentasCabecera()
        Return datosVentasDetalle.BuscarPorFactura(codigo, fechaInicio, fechaFin)
    End Function

End Class



