

Imports capa_datos
Imports capa_entidad
Imports capa_negocio

Public Class panel_clliente
    Private objCapaNegocio As New CN_Personas()
    Private Sub panel_clliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDataGridClientes()
        DgCliente.Columns(0).Visible = False
        BGuardar.Visible = False
        BAgregar.Visible = True
    End Sub


    Public Sub LimpiarCampos()

        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        TCelular.Clear()
        TDireccion.Clear()


    End Sub




    Private Sub MostrarClientesInactivos()
        Try
            ' Instanciar la capa de negocio
            Dim objCapaNegocio As New CN_Personas()

            ' Obtener los datos y enlazarlos al DataGridView
            Dim dtClientesInactivos As DataTable = objCapaNegocio.ListarClientesInactivos()
            DgCliente.DataSource = dtClientesInactivos

            ' Ajustar las columnas del DataGridView

        Catch ex As Exception
            MessageBox.Show("Error al mostrar clientes inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MostrarClientesActivos()
        Try
            ' Instanciar la capa de negocio
            Dim objCapaNegocio As New CN_Personas()

            ' Obtener los datos y enlazarlos al DataGridView
            Dim dtClientesActivos As DataTable = objCapaNegocio.ListarClientesActivos()
            DgCliente.DataSource = dtClientesActivos

            ' Ajustar las columnas del DataGridView
            DgCliente.Columns(0).Visible = False
            DgCliente.Columns(1).Visible = True ' Ocultar columna id_persona si no es necesario
            BActivos.Visible = False
            BInactivos.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error al mostrar clientes inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub Ttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCelular.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("ingrese Solo caracteres numericos")
            e.Handled = True
            Return
        End If

    End Sub

    ' Evento para permitir solo números en el TextBox de DNI
    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        ' Permitir solo dígitos numéricos y teclas de control como "Backspace"
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Evento para validar la longitud del DNI o el formato de CUIL
    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
        Dim input As String = TDni.Text

        ' Verificar si la longitud es exactamente 8 para DNI
        If input.Length = 8 AndAlso IsNumeric(input) Then
            ' Validación de DNI correcto, puedes agregar lógica adicional si es necesario
            TDni.BackColor = Color.White ' Indica que el valor es válido
        ElseIf IsFormatoCuilValido(input) Then
            ' Si el formato coincide con CUIL
            TDni.BackColor = Color.White ' Indica que el valor es válido
        Else
            ' Si no es válido, resalta el campo en otro color (opcional)
            TDni.BackColor = Color.LightCoral ' Indica que el valor es inválido
        End If
    End Sub

    ' Función para validar el formato de CUIL (ejemplo simple)
    Private Function IsFormatoCuilValido(cuil As String) As Boolean
        ' Ejemplo de validación básica de CUIL: formato 99-99999999-9
        Dim regex As New System.Text.RegularExpressions.Regex("^\d{2}-\d{8}-\d{1}$")
        Return regex.IsMatch(cuil)
    End Function


    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        ' Permitir solo letras y espacios
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If

        ' Limitar a 3 nombres
        Dim nombres() As String = TNombre.Text.Split(" "c)

        ' Comprobar si hay 3 nombres y si no es un control (ej. Backspace)
        If nombres.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Eliminar espacios adicionales al final
        If e.KeyChar = " "c AndAlso TNombre.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        ' Convertir a mayúscula la primera letra de cada nombre
        Dim nombres As String() = TNombre.Text.ToLower().Split(" "c)

        For i As Integer = 0 To nombres.Length - 1
            If nombres(i).Length > 0 Then
                nombres(i) = Char.ToUpper(nombres(i)(0)) & nombres(i).Substring(1)
            End If
        Next

        ' Unir los nombres en una sola cadena
        TNombre.Text = String.Join(" ", nombres)

        ' Mover el cursor al final del TextBox
        TNombre.SelectionStart = TNombre.Text.Length
    End Sub



    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        ' Permitir solo letras y espacios
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If

        ' Limitar a 2 apellidos
        Dim apellidos() As String = TApellido.Text.Split(" "c)

        ' Comprobar si hay 2 apellidos y si no es un control (ej. Backspace)
        If apellidos.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Eliminar espacios adicionales al final
        If e.KeyChar = " "c AndAlso TApellido.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
        ' Convertir a mayúscula la primera letra de cada apellido
        Dim apellidos As String() = TApellido.Text.ToLower().Split(" "c)

        For i As Integer = 0 To apellidos.Length - 1
            If apellidos(i).Length > 0 Then
                apellidos(i) = Char.ToUpper(apellidos(i)(0)) & apellidos(i).Substring(1)
            End If
        Next

        ' Unir los apellidos en una sola cadena
        TApellido.Text = String.Join(" ", apellidos)

        ' Mover el cursor al final del TextBox
        TApellido.SelectionStart = TApellido.Text.Length
    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Try
            ' Validar el número de documento (DNI)
            If TDni.Text.Length < 7 Or TDni.Text.Length > 8 Or Not IsNumeric(TDni.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular
            If TCelular.Text.Length < 7 Or Not IsNumeric(TCelular.Text) Then
                MessageBox.Show("El celular debe tener más de 6 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar nombres
            Dim nombres() As String = TNombre.Text.Split(" "c)
            If nombres.Length > 3 Then
                MessageBox.Show("Se permiten hasta 3 nombres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar apellidos
            Dim apellidos() As String = TApellido.Text.Split(" "c)
            If apellidos.Length > 3 Then
                MessageBox.Show("Se permiten hasta 2 apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Crear el objeto cliente con los datos del formulario
            Dim nuevoCliente As New CE_Personas With {
            .Nombre = TNombre.Text,
            .Apellido = TApellido.Text,
            .NDocumento = TDni.Text,
            .Celular = TCelular.Text,
            .Direccion = TDireccion.Text,
            .estado = "Activo",
            .FechaRegistro = DateTime.Now
        }

            ' Llamar a la capa de negocio para registrar al cliente
            Dim objCN_Personas As New CN_Personas()
            objCN_Personas.RegistrarCliente(nuevoCliente)
            MostrarClientesActivos()
            LimpiarCampos()
            MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DgCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellClick
        ' Verificar que la celda clickeada no sea el encabezado
        If e.RowIndex >= 0 Then
            ' Verificar si es la columna "Modificar"
            If DgCliente.Columns(e.ColumnIndex).Name = "CModificar" Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DgCliente.Rows(e.RowIndex)

                ' Cargar los datos en los TextBox para modificar
                TNombre.Text = selectedRow.Cells("CNombre").Value.ToString()
                TApellido.Text = selectedRow.Cells("CApellido").Value.ToString()
                TDni.Text = selectedRow.Cells("CDNI").Value.ToString()
                TCelular.Text = selectedRow.Cells("CTELEFONO").Value.ToString()
                TDireccion.Text = selectedRow.Cells("CDireccion").Value.ToString()
                id.Text = selectedRow.Cells("CId_cliente").Value.ToString()

                ' Mostrar el botón de Guardar y ocultar el de Agregar
                BGuardar.Visible = True
                BAgregar.Visible = False

                ' Verificar si es la columna "Eliminar"
            ElseIf DgCliente.Columns(e.ColumnIndex).Name = "CEliminar" Then
                ' Confirmar la eliminación lógica (cambiar el estado a "Inactivo")
                Dim idPersona As Integer = Convert.ToInt32(DgCliente.Rows(e.RowIndex).Cells("CId_cliente").Value)
                If MessageBox.Show("¿Está seguro de que desea marcar como inactiva a esta persona?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        ' Llamar a la capa de negocio para cambiar el estado a inactivo
                        Dim objCapaNegocio As New CN_Personas()
                        objCapaNegocio.EliminarPersona(idPersona)

                        MostrarClientesActivos() ' Método que actualiza el DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error al marcar como inactiva a la persona: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                ' Verificar si es la columna "Activar"
            ElseIf DgCliente.Columns(e.ColumnIndex).Name = "CActivar" Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DgCliente.Rows(e.RowIndex)
                Dim idPersona As Integer = Convert.ToInt32(selectedRow.Cells("CId_cliente").Value) ' Cambié "id_persona" por "CId_cliente"

                ' Confirmar activación
                Dim confirmacion As DialogResult = MessageBox.Show("¿Deseas activar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmacion = DialogResult.Yes Then
                    Try
                        ' Llamar a la capa de negocio para activar al cliente
                        Dim objNegocio As New CN_Personas()
                        objNegocio.ActivarCliente(idPersona)

                        ' Refrescar el DataGridView
                        MostrarClientesInactivos()
                        MessageBox.Show("Cliente activado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error al activar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub LlenarDataGridClientes()
        Dim objCN As New CN_Personas() ' Instancia de la capa de negocio
        Dim dtClientes As DataTable = objCN.ListarClientesActivos()
        DgCliente.DataSource = dtClientes
    End Sub

    Private Sub BActivos_Click(sender As Object, e As EventArgs) Handles BActivos.Click
        MostrarClientesActivos()
    End Sub

    Private Sub BInactivos_Click(sender As Object, e As EventArgs) Handles BInactivos.Click
        MostrarClientesInactivos()
        DgCliente.Columns(0).Visible = True
        DgCliente.Columns(1).Visible = False ' Ocultar columna id_persona si no es necesario
        BActivos.Visible = True
        BInactivos.Visible = False
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Try
            ' Validar el número de documento (DNI)
            If TDni.Text.Length < 7 Or TDni.Text.Length > 8 Or Not IsNumeric(TDni.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular
            If TCelular.Text.Length < 7 Or Not IsNumeric(TCelular.Text) Then
                MessageBox.Show("El celular debe tener más de 6 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar nombres
            Dim nombres() As String = TNombre.Text.Split(" "c)
            If nombres.Length > 3 Then
                MessageBox.Show("Se permiten hasta 3 nombres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar apellidos
            Dim apellidos() As String = TApellido.Text.Split(" "c)
            If apellidos.Length > 3 Then
                MessageBox.Show("Se permiten hasta 2 apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Crear instancia de la entidad CE_Personas (suponiendo que Cliente también hereda o es similar a CE_Personas)
            Dim cliente As New CE_Personas With {
            .IdPersona = Convert.ToInt32(id.Text), ' Suponiendo que id_cliente es el ID del cliente en la interfaz
            .Nombre = TNombre.Text,
            .Apellido = TApellido.Text,
            .NDocumento = TDni.Text,
            .Celular = TCelular.Text,
            .Direccion = TDireccion.Text
    }

            ' Llamar al método de la capa de negocio para modificar cliente

            Dim objCN_Clientes As New CN_Personas() ' Asumiendo que la capa de negocio para personas maneja clientes

            ' Llamamos a la función que modifica el cliente
            objCN_Clientes.ModificarCliente(cliente)

            ' Mostrar mensaje de éxito y actualizar DataGridView
            MessageBox.Show("Cliente modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LlenarDataGridClientes() ' Método para llenar el DataGrid con los clientes
            LimpiarCampos() ' Limpiar los campos del formulario

        Catch ex As Exception
            MessageBox.Show("Error al modificar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado y el criterio seleccionado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()

        ' Verificar si el TextBox está vacío o si el criterio es nulo
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos
            LlenarDataGridClientes()
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

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        LimpiarCampos()
        BGuardar.Visible = False
        BAgregar.Visible = True
    End Sub

    Private Sub DgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellContentClick

    End Sub

    Private Sub CriterioBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CriterioBusqueda.SelectedIndexChanged

    End Sub
End Class
