Imports System.Data.SqlClient
Imports capa_negocio

Public Class BusquedaProducto
    ' Instancia de la capa de negocio
    Private cnProducto As New CN_Productos

    Private Sub BusquedaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgProductos.AutoGenerateColumns = False
        LlenarDataGrid()
    End Sub

    ' Método para llenar el DataGridView con los productos
    Public Sub LlenarDataGrid()
        Try
            ' Llamamos a la capa de negocio para obtener los productos
            Dim dtProductos As DataTable = cnProducto.ObtenerProductosActivos()
            DgProductos.DataSource = dtProductos
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento al hacer clic en una celda del DataGridView
    Private Sub DgProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProductos.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Verifica si la columna seleccionada es la de "Seleccionar"
            If DgProductos.Columns(e.ColumnIndex).Name = "CSeleccionar" Then
                ' Si hay una fila válida seleccionada
                If e.RowIndex >= 0 AndAlso e.RowIndex < DgProductos.Rows.Count Then
                    ' Obtén la fila seleccionada
                    Dim filaSeleccionada As DataGridViewRow = DgProductos.Rows(e.RowIndex)

                    ' Obtiene los valores de la fila seleccionada
                    Dim nombre As String = filaSeleccionada.Cells("CNombre").Value.ToString()
                    Dim codigo As Integer = Convert.ToInt32(filaSeleccionada.Cells("Ccodigo").Value)
                    Dim stock As Integer = Convert.ToInt32(filaSeleccionada.Cells("CStock").Value)
                    Dim precio As Decimal = Convert.ToDecimal(filaSeleccionada.Cells("CPrecio").Value)
                    Dim descripcion As String = filaSeleccionada.Cells("Cdescripcion").Value.ToString()
                    Dim idProducto As Integer = Convert.ToInt32(filaSeleccionada.Cells("CId").Value)

                    ' Pasar los valores al formulario de ventas
                    Ventas.seleccionarProducto(nombre, precio, codigo, idProducto, descripcion, stock)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado y el criterio seleccionado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()

        ' Verificar si el TextBox está vacío o si el criterio es nulo
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos
            LlenarDataGrid()
            Return
        End If

        ' Verificar que el valor a buscar tenga al menos 3 caracteres para evitar errores
        If valorBuscar.Length < 1 Then
            ' Evitar ejecutar búsquedas con menos de 3 caracteres
            Return
        End If

        ' Llamar al método de la capa de negocio para buscar clientes según el criterio
        Try
            Dim objNegocio As New CN_Productos()
            Dim dtProductos As DataTable

            Select Case criterio
                Case "CODIGO"
                    dtProductos = objNegocio.BuscarPorCodigo(valorBuscar)
                Case "NOMBRE"
                    dtProductos = objNegocio.BuscarPorNombre(valorBuscar)
                Case "CATEGORIA"
                    dtProductos = objNegocio.BuscarPorCategoria(valorBuscar)
                Case "DESCRIPCION"
                    dtProductos = objNegocio.BuscarPorDescripcion(valorBuscar)
                Case Else
                    Return
            End Select

            If dtProductos.Rows.Count > 0 Then
                ' Si hay resultados, mostrar en el DataGridView
                DgProductos.DataSource = dtProductos
            Else
                ' Si no hay resultados, limpiar el DataGridView
                DgProductos.DataSource = Nothing
            End If



        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProductos.CellContentClick

    End Sub
End Class
