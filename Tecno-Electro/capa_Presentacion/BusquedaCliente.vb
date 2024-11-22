Imports System.Data.SqlClient
Imports capa_negocio

Public Class BusquedaCliente
    Dim cn_cliente As New CN_Personas

    Private Sub BusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgCliente.AutoGenerateColumns = False
        LlenarDataGrid()
    End Sub

    Public Sub LlenarDataGrid()
        Try
            ' Llama a la capa de negocio para obtener los datos
            DgCliente.DataSource = cn_cliente.ListarClientesActivos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Verifica si la columna seleccionada es la columna "Cseleccionar"
            If DgCliente.Columns(e.ColumnIndex).Name = "Cseleccionar" Then
                If e.RowIndex >= 0 AndAlso e.RowIndex < DgCliente.Rows.Count Then
                    ' Obtiene la fila seleccionada
                    Dim filaSeleccionada As DataGridViewRow = DgCliente.Rows(e.RowIndex)

                    ' Obtén los valores de las celdas específicas que deseas cargar
                    Dim nombre As String = filaSeleccionada.Cells("CNombre").Value.ToString()
                    Dim Apellido As String = filaSeleccionada.Cells("CApellido").Value.ToString()
                    Dim dni As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cdni").Value)
                    Dim id_cliente As String = filaSeleccionada.Cells("CId_cliente").Value.ToString()

                    ' Llama al formulario Ventas para pasar los datos del cliente seleccionado
                    Ventas.seleccionarCliente(nombre, Apellido, Dni, id_cliente)
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
            Dim objNegocio As New CN_Personas()
            Dim dtClientes As DataTable

            Select Case criterio
                Case "Nombre"
                    dtClientes = objNegocio.BuscarClientesPorNombre(valorBuscar)
                Case "Apellido"
                    dtClientes = objNegocio.BuscarClientesPorApellido(valorBuscar)
                Case "DNI"
                    dtClientes = objNegocio.BuscarClientesPorDNI(valorBuscar)
                Case Else
                    Return
            End Select

            If dtClientes.Rows.Count > 0 Then
                ' Si hay resultados, mostrar en el DataGridView
                DgCliente.DataSource = dtClientes
            Else
                ' Si no hay resultados, limpiar el DataGridView
                DgCliente.DataSource = Nothing
            End If



        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
