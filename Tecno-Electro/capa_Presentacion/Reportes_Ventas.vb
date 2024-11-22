Imports capa_negocio
Imports System.Data.SqlClient
Imports capa_datos
Imports capa_entidad
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Reportes_Ventas
    Dim reportes As String
    Public Property usuarioid As String
    Public Property Nombreus As String
    Public Property apellidous As String
    Public Property fechaInicio As DateTime
    Public Property fechaFin As DateTime
    Dim oculta As Boolean
    Public Property x As Boolean
    Public Sub CargarCabecera(usuarioid As Integer, fechaInicio As DateTime, fechaFin As DateTime, ocultar As Boolean)
        If ocultar = True Then
            CriterioBusqueda.Visible = False
            TxtBuscar.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        End If
        Dim cnVentas As New CN_Ventas()
        Dim dtVentas As DataTable = cnVentas.obtenerventasUsuario(usuarioid, fechaInicio, fechaFin)
        dgvReportes.DataSource = dtVentas
        TITULO.Text = "Ventas realizadas"
        reportes = TITULO.Text
    End Sub
    Public Sub CargarcabeceraPorFecha(fechaInicio As DateTime, fechaFin As DateTime)

        Dim cnVentas As New CN_Ventas()
        Dim dtVentas As DataTable = cnVentas.ObtenerReporteVentas(fechaInicio, fechaFin)
        dgvReportes.DataSource = dtVentas
        TITULO.Text = "Reportes de Ventas"
        reportes = TITULO.Text
    End Sub
    Public Sub CargarStock(top As Integer)
        CriterioBusqueda.Visible = False
        TxtBuscar.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TITULO.Text = "Stock de Productos"
        reportes = TITULO.Text
        Dim cnVentas As New CN_Ventas()
        Dim dtVentas As DataTable = cnVentas.ObtenerStock(top)
        dgvReportes.DataSource = dtVentas
    End Sub

    Public Sub CargarClientes(fechaInicio As DateTime, fechaFin As DateTime, top As Integer)
        CriterioBusqueda.Visible = False
        TxtBuscar.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TITULO.Text = "Reporte Clientes"
        reportes = TITULO.Text
        Dim cnVentas As New CN_Personas
        Dim dtVentas As DataTable = cnVentas.obtenerClientes(fechaInicio, fechaFin, top)
        dgvReportes.DataSource = dtVentas
    End Sub

    Public Sub mejorVendedor(fechaInicio As DateTime, fechaFin As DateTime, top As Integer)
        CriterioBusqueda.Visible = False
        TxtBuscar.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TITULO.Text = "Reporte Vendedor"
        reportes = TITULO.Text
        Dim cnVentas As New CN_PersonasUsuarios
        Dim dtVentas As DataTable = cnVentas.MejorVendedor(fechaInicio, fechaFin, top)
        dgvReportes.DataSource = dtVentas
    End Sub
    Public Sub cargarProductos(fechaInicio As DateTime, fechaFin As DateTime, top As Integer, categoria As String)
        CriterioBusqueda.Visible = False
        TxtBuscar.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TITULO.Text = "Reporte Productos "
        reportes = TITULO.Text
        Dim cnVentas As New CN_Productos
        Dim dtVentas As DataTable = cnVentas.productosVendidos(fechaInicio, fechaFin, top, categoria)
        dgvReportes.DataSource = dtVentas
    End Sub
    Private Sub bpdf_click(sender As Object, e As EventArgs) Handles Bpdf.Click

        Dim savefiledialog As New SaveFileDialog()
        savefiledialog.Filter = "pdf files (*.pdf)|*.pdf"
        savefiledialog.Title = "guardar reporte como pdf"
        savefiledialog.FileName = "reporte.pdf"
        Dim datosventas As Tuple(Of DataTable, Decimal)

        If savefiledialog.ShowDialog() = DialogResult.OK Then
            Dim rutapdf As String = savefiledialog.FileName
            If reportes = "reportes de ventas" Then

                datosventas = ObtenerDatosDeVentas() 'método que obtiene los datos del datagridview
            Else
                datosventas = ObtenerDatosDeVentas()
            End If

            Dim reporteventas As New CN_Ventas()
            Try
                reporteventas.GenerarPDF(datosventas, rutapdf, reportes, Nombreus, apellidous)
                MessageBox.Show("pdf generado correctamente en: " & rutapdf, "éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("error al generar el pdf: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("guardado cancelado.", "cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ObtenerDatosDeVentas() As Tuple(Of DataTable, Decimal)
        ' Crear un nuevo DataTable
        Dim dt As New DataTable()

        ' Variable para almacenar el total de ventas
        Dim totalVentas As Decimal = 0

        ' Asegúrate de que el DataGridView tenga datos
        If dgvReportes.Rows.Count > 0 Then
            ' Agregar columnas al DataTable según las columnas del DataGridView
            For Each columna As DataGridViewColumn In dgvReportes.Columns
                ' Agregar la columna al DataTable con el mismo nombre
                dt.Columns.Add(columna.Name)
                ' Depuración: Ver los nombres de las columnas
                Console.WriteLine("Columna: " & columna.Name)
            Next

            ' Recorrer las filas del DataGridView
            For Each fila As DataGridViewRow In dgvReportes.Rows
                ' Verificar si la fila no es una fila nueva (de edición)
                If Not fila.IsNewRow Then
                    ' Crear una nueva fila en el DataTable
                    Dim nuevaFila As DataRow = dt.NewRow()

                    ' Recorrer cada celda de la fila y agregar los valores al DataRow
                    For i As Integer = 0 To fila.Cells.Count - 1
                        nuevaFila(i) = fila.Cells(i).Value
                        If reportes = "Reportes de Ventas" Then
                            ' Verificar si la columna es la de "totalVenta" y calcular el total
                            If dgvReportes.Columns(i).Name = "TotalVenta" Then
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

    Private Sub dgvReportes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReportes.CellClick
        ' Verifica si la columna seleccionada es la de botón (btnEliminar)
        If e.ColumnIndex = dgvReportes.Columns("Detalles").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el ID de la venta de la fila seleccionada
            Dim idCabecera As Integer = CInt(dgvReportes.Rows(e.RowIndex).Cells("Numero_Factura").Value)
            Dim frmReporte As New frmDetalles
            ' Llamar a la función para mostrar los detalles de la venta
            frmReporte.idcabecera = idCabecera
            frmReporte.MostrarDetallesVenta(idCabecera)
            frmReporte.ShowDialog()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        ' Obtener el valor ingresado y el criterio seleccionado
        oculta = False
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            If x = True Then
                CargarcabeceraPorFecha(fechaInicio, fechaFin)
                Return
            Else
                CargarCabecera(usuarioid, fechaInicio, fechaFin, oculta)
                Return
            End If
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos

        End If
        ' Verificar si el TextBox está vacío o si el criterio es nulo

        ' Verificar que el valor a buscar tenga al menos 3 caracteres para evitar errores
        If valorBuscar.Length < 1 Then
            ' Evitar ejecutar búsquedas con menos de 3 caracteres
            Return
        End If

        ' Llamar al método de la capa de negocio para buscar clientes según el criterio
        Try
            Dim objNegocio As New CN_Ventas()
            Dim dtProductos As DataTable


            Select Case criterio.Trim() ' Eliminamos espacios adicionales
                Case "N° Factura"
                    dtProductos = objNegocio.Buscarfactura(valorBuscar, fechaInicio, fechaFin)

                Case "DNI Usuario"
                    dtProductos = objNegocio.BuscardniUsuario(valorBuscar, fechaInicio, fechaFin)

                Case "DNI Cliente"
                    dtProductos = objNegocio.BuscarDNIcliente(valorBuscar, fechaInicio, fechaFin)

                Case Else
                    MessageBox.Show("Criterio no válido. Por favor, selecciona una opción válida.")
                    Return
            End Select


            If dtProductos.Rows.Count > 0 Then
                ' Si hay resultados, mostrar en el DataGridView
                dgvReportes.DataSource = dtProductos
            Else
                ' Si no hay resultados, limpiar el DataGridView
                dgvReportes.DataSource = Nothing
            End If



        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reportes_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If x = True Then
            CriterioBusqueda.Items.Clear()
            CriterioBusqueda.Items.AddRange(New String() {"N° Factura", "DNI Usuario", "DNI Cliente"})
        Else
            CriterioBusqueda.Items.Clear()
            CriterioBusqueda.Items.AddRange(New String() {"N° Factura"})
        End If
    End Sub
End Class