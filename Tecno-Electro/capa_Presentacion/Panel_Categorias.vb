Imports capa_datos
Imports capa_entidad
Imports capa_negocio

Public Class Panel_Categorias

    Public Sub LimpiarCampos()

        TID.Clear()
        TDescripcion.Clear()

        CEstado.SelectedItem = " "


    End Sub
    Private Sub MostrarCategorias()
        Try
            Dim objNegocio As New CN_Categorias() ' Instancia de la capa de negocio
            Dim dt As DataTable = objNegocio.ObtenerCategorias() ' Obtener las categorías

            ' Asignar el DataTable al DataGridView
            DgvCategorias.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al mostrar las categorías: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel_Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCategorias()
        BEliminar.Visible = False
        BModificar.Visible = False
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        Try
            ' Crear una instancia de la entidad categoría
            Dim nuevaCategoria As New CE_Categoria With {
            .c_Descripcion = TDescripcion.Text,
            .Estado = CEstado.SelectedItem.ToString() ' O el control que utilices para el estado
        }

            ' Llamar a la capa de negocio para insertar la nueva categoría
            Dim objNegocio As New CN_Categorias()
            objNegocio.AgregarCategoria(nuevaCategoria)

            ' Mensaje de éxito
            MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar el formulario si es necesario
            TDescripcion.Clear()
            CEstado.SelectedIndex = -1
            LimpiarCampos()
            MostrarCategorias()
        Catch ex As Exception
            MessageBox.Show("Error al agregar la categoría: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCategorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategorias.CellContentClick

        ' Verificar que no se seleccionen los encabezados
        If e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = DgvCategorias.Rows(e.RowIndex)

            ' Cargar los valores de la fila en los TextBox y ComboBox
            TDescripcion.Text = selectedRow.Cells("categoria").Value.ToString()
            TID.Text = selectedRow.Cells("id").Value.ToString()
            ' Asumiendo que el estado está en la columna "Estado"
            CEstado.SelectedItem = selectedRow.Cells("Estado").Value.ToString()
        End If
        BAgregar.Visible = False
        BEliminar.Visible = True
        BModificar.Visible = True
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim idCategoria As Integer = Convert.ToInt32(TID.Text)
                Dim objCN_Categorias As New CN_Categorias()
                objCN_Categorias.EliminarCategoria(idCategoria)

                MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarCategorias() ' Método que actualiza el DataGridView
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la categoría: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Try
            ' Verifica que los valores no sean nulos o vacíos antes de continuar
            If String.IsNullOrEmpty(TID.Text) Or String.IsNullOrEmpty(TDescripcion.Text) Or CEstado.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Crear una nueva instancia de CE_Categorias (o el nombre correcto de tu entidad)
            Dim categoria As New CE_Categoria With {
                .IdCategoria = Convert.ToInt32(TID.Text),
                .c_Descripcion = TDescripcion.Text, ' Verifica el nombre de esta propiedad
                .Estado = CEstado.SelectedItem.ToString()
            }

            ' Crear una instancia de CN_Categorias y llamar al método de modificar
            Dim objCN_Categorias As New CN_Categorias()
            objCN_Categorias.ModificarCategoria(categoria)

            ' Mostrar mensaje de éxito
            MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Actualizar el DataGrid con las categorías
            MostrarCategorias()
            LimpiarCampos()

        Catch ex As Exception
            ' Captura de cualquier error
            MessageBox.Show("Error al modificar la categoría: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BAgregar.Visible = True
        BEliminar.Visible = False
        BModificar.Visible = False
        LimpiarCampos()
    End Sub


End Class