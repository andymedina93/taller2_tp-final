Imports System.Data.SqlClient
Imports capa_entidad
Imports capa_negocio

Public Class panelProductos

    Private cnProductos As New CN_Productos()

    Public Sub LimpiarCampos()

        TNombre.Clear()
        TDescripcion.Clear()
        TCodigo.Clear()
        TPrecioCompra.Clear()
        TPrecioVenta.Clear()
        TStock.Clear()
        TCategoria.SelectedItem = " "


    End Sub


    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        LimpiarCampos()
        BGuardar.Visible = False
        BAgregar.Visible = True
        TNombre.Enabled = True
    End Sub
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        MostrarProductosActivos()
        BGuardar.Visible = False
        BActivos.Visible = False
        BAgregar.Visible = True
        DgProductos.Columns(0).Visible = False
        DgProductos.Columns(1).Visible = True
    End Sub

    Private Sub CargarCategorias()
        Try
            ' Llamar a la capa de negocio para obtener las categorías
            Dim objCN_Categorias As New CN_Categorias()
            Dim dtCategorias As DataTable = objCN_Categorias.ListarCategorias()

            ' Asignar los datos al ComboBox
            With TCategoria
                .DataSource = dtCategorias
                .DisplayMember = "c_descripcion" ' Lo que se mostrará en el ComboBox
                .ValueMember = "Id_categoria"  ' El valor asociado con cada opción (clave primaria)
                .SelectedIndex = -1 ' Para que no seleccione nada al inicio
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar las categorías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarProductosActivos()
        Dim dt As DataTable = cnProductos.ObtenerProductosActivos()
        DgProductos.DataSource = dt
    End Sub

    ' Método para cargar productos inactivos en el DataGridView
    Private Sub MostrarProductosInactivos()
        Dim dt As DataTable = cnProductos.ObtenerProductosInactivos()
        DgProductos.DataSource = dt
    End Sub

    ' Botón para mostrar productos activos
    Private Sub BActivos_Click(sender As Object, e As EventArgs) Handles BActivos.Click
        MostrarProductosActivos()
        BInactivos.Visible = True
        BActivos.Visible = False
        DgProductos.Columns(0).Visible = False
        DgProductos.Columns(1).Visible = True
    End Sub

    ' Botón para mostrar productos inactivos
    Private Sub BInactivos_Click(sender As Object, e As EventArgs) Handles BInactivos.Click
        MostrarProductosInactivos()
        BInactivos.Visible = False
        BActivos.Visible = True
        DgProductos.Columns(0).Visible = True
        DgProductos.Columns(1).Visible = False
    End Sub
    Private Sub BAgregarProducto_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim idCategoriaSeleccionada As Integer = Convert.ToInt32(TCategoria.SelectedValue)
        If Not ValidarCampos() Then
            Exit Sub
        End If
        Try
            ' Validar que todos los campos necesarios estén llenos antes de proceder
            If String.IsNullOrEmpty(TNombre.Text) OrElse String.IsNullOrEmpty(TDescripcion.Text) Then
                MessageBox.Show("Complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Crear instancia de la entidad producto con los datos del formulario
            Dim nuevoProducto As New CE_Productos With {
                .Nombre = TNombre.Text,
                .Descripcion = TDescripcion.Text,
                .Codigo = Convert.ToInt32(TCodigo.Text),
                .PrecioVta = Convert.ToDouble(TPrecioVenta.Text),
                .PrecioCompra = Convert.ToDouble(TPrecioCompra.Text),
                .Stock = Convert.ToInt32(TStock.Text),
                .CategoriaId = idCategoriaSeleccionada,
                .Estado = "Activo"
            }

            ' Llamar a la capa de negocio para registrar el producto
            Dim objCN_Productos As New CN_Productos
            objCN_Productos.RegistrarProducto(nuevoProducto)

            MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos() ' Método que limpia los campos del formulario después de agregar
            MostrarProductosActivos()
        Catch ex As Exception
            MessageBox.Show("Error al registrar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProductos.CellClick
        ' Verificar que la celda que se ha clickeado no sea la cabecera
        If e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow = DgProductos.Rows(e.RowIndex)

            ' Verificar que la columna clickeada sea la columna de "Modificar"
            If DgProductos.Columns(e.ColumnIndex).Name = "CModificar" Then
                If MessageBox.Show("¿Está seguro de que desea modificar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                    ' Cargar los datos en los TextBox
                    tIdProducto.Text = selectedRow.Cells("Cid").Value.ToString
                    TNombre.Text = selectedRow.Cells("CNombre").Value.ToString
                    TDescripcion.Text = selectedRow.Cells("CDescripcion").Value.ToString
                    TStock.Text = selectedRow.Cells("CStock").Value.ToString
                    TCodigo.Text = selectedRow.Cells("CCodigo").Value.ToString
                    TCategoria.Text = selectedRow.Cells("CCategoria").Value.ToString
                    TPrecioCompra.Text = selectedRow.Cells("cPrecioCompra").Value.ToString '
                    TPrecioVenta.Text = selectedRow.Cells("CPrecioVenta").Value.ToString
                    TCodigo.Enabled = False

                    BGuardar.Visible = True
                    BAgregar.Visible = False

                End If
                ' Verificar si se hace clic en la columna "Eliminar"
            ElseIf DgProductos.Columns(e.ColumnIndex).Name = "CEliminar" Then
                Dim confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmResult = DialogResult.Yes Then
                    ' Cambiar el estado a inactivo
                    Dim obj_productos As New CN_Productos
                    Dim idProducto = Convert.ToInt32(selectedRow.Cells("cid").Value)
                    obj_productos.EliminarProducto(idProducto) ' Llama a la función para cambiar el estado

                    ' Actualizar el DataGridView
                    Dim dt = cnProductos.ObtenerProductosActivos ' O el método que uses para refrescar la lista
                    MostrarProductosActivos()
                End If

                ' Verificar si se hace clic en la columna "Activar"
            ElseIf DgProductos.Columns(e.ColumnIndex).Name = "CActivar" Then
                Dim confirmResult = MessageBox.Show("¿Está seguro de que desea activar este producto?", "Confirmar activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmResult = DialogResult.Yes Then
                    ' Cambiar el estado a activo
                    Dim idProducto = Convert.ToInt32(selectedRow.Cells("cid").Value)
                    Dim obj_productos As New CN_Productos
                    obj_productos.ActivarProducto(idProducto)

                    ' Actualizar el DataGridView
                    MostrarProductosInactivos() ' O el método que uses para refrescar la lista
                End If
            End If
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Not ValidarCampos() Then
            Exit Sub
        End If
        Try
            ' Crear una instancia de la entidad producto
            Dim producto As New CE_Productos With {
            .IdProducto = Convert.ToInt32(tIdProducto.Text),
            .Nombre = TNombre.Text,
            .Descripcion = TDescripcion.Text,
            .Codigo = Convert.ToInt32(TCodigo.Text),
            .PrecioVta = Convert.ToDouble(TPrecioVenta.Text),
            .PrecioCompra = Convert.ToDouble(TPrecioCompra.Text),
            .Stock = Convert.ToInt32(TStock.Text),
            .CategoriaId = Convert.ToInt32(TCategoria.SelectedValue)
        }

            ' Llamar a la capa de negocio para modificar el producto
            Dim objNegocio As New CN_Productos()
            objNegocio.ModificarProducto(producto)
            TCodigo.Enabled = True
            ' Mostrar mensaje de éxito
            MessageBox.Show("Producto modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            ' Actualizar el DataGridView o cualquier control que muestre la lista de productos
            MostrarProductosActivos()

        Catch ex As Exception
            MessageBox.Show("Error al modificar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado y el criterio seleccionado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()

        ' Verificar si el TextBox está vacío o si el criterio es nulo
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos
            MostrarProductosActivos()
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

    Private Sub BNuevaCategoria_Click(sender As Object, e As EventArgs) Handles BNuevaCategoria.Click
        Dim frmCategorias As New Panel_Categorias()

        ' Mostrar el formulario
        frmCategorias.Show()
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Validar el nombre del producto
        If String.IsNullOrWhiteSpace(TNombre.Text) Then
            MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TNombre.Focus()
            Return False
        End If

        ' Validar la descripción del producto
        If String.IsNullOrWhiteSpace(TDescripcion.Text) Then
            MessageBox.Show("La descripción del producto no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TDescripcion.Focus()
            Return False
        End If

        ' Validar el código del producto
        If String.IsNullOrWhiteSpace(TCodigo.Text) OrElse Not IsNumeric(TCodigo.Text) Then
            MessageBox.Show("El código del producto debe ser numérico y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TCodigo.Focus()
            Return False
        End If

        ' Validar el precio de venta
        Dim precioVenta As Decimal
        If Not Decimal.TryParse(TPrecioVenta.Text, precioVenta) OrElse precioVenta <= 0 Then
            MessageBox.Show("El precio de venta debe ser un número mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TPrecioVenta.Focus()
            Return False
        End If

        Dim precioCompra As Decimal
        If Not Decimal.TryParse(TPrecioCompra.Text, precioCompra) OrElse precioVenta <= 0 Then
            MessageBox.Show("El precio de venta debe ser un número mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TPrecioVenta.Focus()
            Return False
        End If
        ' Validar el stock
        Dim stock As Integer
        If Not Integer.TryParse(TStock.Text, stock) OrElse stock < 0 Then
            MessageBox.Show("El stock debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TStock.Focus()
            Return False
        End If

        ' Si todas las validaciones se cumplen
        Return True
    End Function

    Private Sub DgProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProductos.CellContentClick

    End Sub

    Private Sub TCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TCategoria.SelectedIndexChanged

    End Sub
End Class









