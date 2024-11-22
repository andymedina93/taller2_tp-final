Imports System.IO
Imports capa_negocio
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports OxyPlot.Reporting


Public Class frmDetalles
    Property idcabecera As Integer


    Public Sub MostrarDetallesVenta(idVentaCabecera As Integer)
        TITULO.Text = "Detalles  Ventas"
        ' Instancia de la capa de negocio
        Dim ventasNegocio As New CN_Ventas()

        ' Obtener los detalles de la venta
        Dim detallesVenta As DataTable = ventasNegocio.ObtenerDetallesPorVentaId(idVentaCabecera)
        Dim cabeceraVentas = ventasNegocio.obtenerventasn_factura(idVentaCabecera)
        Dim idUsuario As Integer = cabeceraVentas.Item2
        Dim nombre As String = cabeceraVentas.Item3
        Dim nombrecliente As String = cabeceraVentas.Item4
        Dim apellido As String = cabeceraVentas.Item5
        Dim apellidoCliente As String = cabeceraVentas.Item6
        Dim total As Double = cabeceraVentas.Item7
        Ttotal.Text = total
        nombreVendedor.Text = nombre & "" & apellido
        factura.Text = idcabecera
        cliente.Text = apellidoCliente & " " & nombrecliente
        dgdetalles.DataSource = detallesVenta
    End Sub

    Private Sub Bpdf_Click(sender As Object, e As EventArgs) Handles Bpdf.Click
        ' Crear y configurar el diálogo de guardado
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Guardar reporte como PDF"
        saveFileDialog.FileName = "Reporte.pdf"
        Dim datosVentas As Tuple(Of DataTable, Decimal)
        ' Mostrar el diálogo y verificar si el usuario selecciona una ruta
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim rutaPDF As String = saveFileDialog.FileName

            ' Supongamos que tienes un DataTable con los datos a exportar
            datosVentas = ObtenerDatosDeVentas() 'Método que obtiene los datos del DataGridView

            ' Llama a la capa de negocio para generar el PDF
            Dim reporteVentas As New CN_Ventas()
            Try
                reporteVentas.GenerarReporteVentasPDF(datosVentas, rutaPDF, TITULO.Text, nombreVendedor.Text, cliente.Text, factura.Text, Ttotal.Text)
                MessageBox.Show("PDF generado correctamente en: " & rutaPDF, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Guardado cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ObtenerDatosDeVentas() As Tuple(Of DataTable, Decimal)
        ' Crear un nuevo DataTable
        Dim dt As New DataTable()

        ' Variable para almacenar el total de ventas
        Dim totalVentas As Decimal = 0

        ' Asegúrate de que el DataGridView tenga datos
        If dgdetalles.Rows.Count > 0 Then
            ' Agregar columnas al DataTable según las columnas del DataGridView
            For Each columna As DataGridViewColumn In dgdetalles.Columns
                ' Agregar la columna al DataTable con el mismo nombre
                dt.Columns.Add(columna.Name)
                ' Depuración: Ver los nombres de las columnas
                Console.WriteLine("Columna: " & columna.Name)
            Next

            ' Recorrer las filas del DataGridView
            For Each fila As DataGridViewRow In dgdetalles.Rows
                ' Verificar si la fila no es una fila nueva (de edición)
                If Not fila.IsNewRow Then
                    ' Crear una nueva fila en el DataTable
                    Dim nuevaFila As DataRow = dt.NewRow()

                    ' Recorrer cada celda de la fila y agregar los valores al DataRow
                    For i As Integer = 0 To fila.Cells.Count - 1
                        nuevaFila(i) = fila.Cells(i).Value
                        ' Verificar si la columna es la de "totalVenta" y calcular el total
                        If dgdetalles.Columns(i).Name = "TotalVenta" Then
                            ' Depuración: Ver el valor de la celda
                            Console.WriteLine("Valor en totalVenta: " & fila.Cells(i).Value.ToString())

                            ' Asegúrate de que el valor sea un número y sumarlo al total
                            Dim valorVenta As Decimal
                            Dim valorCelda As String = fila.Cells(i).Value.ToString().Trim()

                            ' Verificar si la celda no está vacía y convertir el valor a decimal
                            If Not String.IsNullOrEmpty(valorCelda) AndAlso Decimal.TryParse(valorCelda, valorVenta) Then
                                totalVentas += valorVenta
                                ' Depuración: Ver el total acumulado
                                Console.WriteLine("Total acumulado: " & totalVentas.ToString())
                            Else
                                ' Si no es un valor válido, agregar un mensaje de advertencia
                                Console.WriteLine("Valor no válido en la columna 'totalVenta' en la fila: " & fila.Index)
                            End If
                        End If

                    Next

                    ' Agregar la fila al DataTable
                    dt.Rows.Add(nuevaFila)
                End If
            Next

        End If



        ' Devolver el DataTable con los datos y el total de ventas
        Return New Tuple(Of DataTable, Decimal)(dt, totalVentas)
    End Function

    Private Sub frmDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class