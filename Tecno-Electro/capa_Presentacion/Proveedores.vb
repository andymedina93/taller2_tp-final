Imports capa_entidad
Imports capa_negocio
Public Class panelProveedores


    Private objCapaNegocio As New CN_Proveedores()

    Private Sub panel_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProveedoresActivos()
        DgProveedores.Columns(1).Visible = False
        DgProveedores.Columns(0).Visible = True
        BGuardar.Visible = False
        BAgregar.Visible = True
    End Sub


    Public Sub Limpiar()

        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        Tcelular.Clear()
        TDireccion.Clear()
    End Sub




    Private Sub MostrarProveedoresInactivos()
        Try
            ' Instanciar la capa de negocio
            Dim objCapaNegocio As New CN_Proveedores()

            ' Obtener los datos y enlazarlos al DataGridView
            Dim dtClientesInactivos As DataTable = objCapaNegocio.ListarProveedorInactivos()
            DgProveedores.DataSource = dtClientesInactivos

            ' Ajustar las columnas del DataGridView

        Catch ex As Exception
            MessageBox.Show("Error al mostrar clientes inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MostrarProveedoresActivos()
        Try
            ' Instanciar la capa de negocio
            Dim objCapaNegocio As New CN_Proveedores()

            ' Obtener los datos y enlazarlos al DataGridView
            Dim dtClientesActivos As DataTable = objCapaNegocio.ListarProveedorActivos()
            DgProveedores.DataSource = dtClientesActivos

            ' Ajustar las columnas del DataGridView
            DgProveedores.Columns(0).Visible = False
            DgProveedores.Columns(1).Visible = True ' Ocultar columna id_persona si no es necesario
            BActivo.Visible = False
            BInactivo.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error al mostrar clientes inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Evento para permitir solo números en el TextBox de DNI
    Private Sub TDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDNI.KeyPress
        ' Permitir solo dígitos numéricos y teclas de control como "Backspace"
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Evento para validar la longitud del DNI o el formato de CUIL
    Private Sub TDocumento_TextChanged(sender As Object, e As EventArgs) Handles TDNI.TextChanged
        Dim input As String = TDNI.Text

        ' Verificar si la longitud es exactamente 8 para DNI
        If input.Length = 8 AndAlso IsNumeric(input) Then
            ' Validación de DNI correcto, puedes agregar lógica adicional si es necesario
            TDNI.BackColor = Color.White ' Indica que el valor es válido
        ElseIf EsFormatoCuilValido(input) Then
            ' Si el formato coincide con CUIL
            TDNI.BackColor = Color.White ' Indica que el valor es válido
        Else
            ' Si no es válido, resalta el campo en otro color (opcional)
            TDNI.BackColor = Color.LightCoral ' Indica que el valor es inválido
        End If
    End Sub

    Private Sub Tcelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tcelular.KeyPress
        ' Permitir solo dígitos numéricos y teclas de control como "Backspace"
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Tcelular_TextChanged(sender As Object, e As EventArgs) Handles Tcelular.TextChanged
        Dim input As String = Tcelular.Text

        ' Verificar si la longitud es exactamente 8 para DNI
        If input.Length < 6 AndAlso IsNumeric(input) Then

            TDNI.BackColor = Color.White ' Indica que el valor es válido
        ElseIf EsFormatoCuilValido(input) Then
            ' Si el formato coincide con CUIL
            TDNI.BackColor = Color.White ' Indica que el valor es válido
        Else
            ' Si no es válido, resalta el campo en otro color (opcional)
            TDNI.BackColor = Color.LightCoral ' Indica que el valor es inválido
        End If
    End Sub


    ' Función para validar el formato de CUIL (ejemplo simple)
    Private Function EsFormatoCuilValido(cuil As String) As Boolean
        ' Ejemplo de validación básica de CUIL: formato 99-99999999-9
        Dim regex As New System.Text.RegularExpressions.Regex("^\d{2}-\d{8}-\d{1}$")
        Return regex.IsMatch(cuil)
    End Function


    Private Sub TNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
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

    Private Sub TNom_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
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



    Private Sub TApe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
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

    Private Sub TApe_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
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


    Private Sub BAgrega_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Try
            ' Validar el número de documento (DNI)
            If TDNI.Text.Length < 7 Or TDNI.Text.Length > 8 Or Not IsNumeric(TDNI.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular
            If Tcelular.Text.Length < 6 Or Not IsNumeric(Tcelular.Text) Then
                MessageBox.Show("El celular debe tener más de 5 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            ' Crear el objeto persona con los datos del formulario
            Dim nuevaPersona As New CE_Personas With {
            .Nombre = TNombre.Text,
            .Apellido = TApellido.Text,
            .NDocumento = TDNI.Text,
            .Celular = Tcelular.Text,
            .Direccion = TDireccion.Text,
            .estado = "Activo",
            .FechaRegistro = DateTime.Now  ' Fecha actual como fecha de registro
        }

            ' Crear el objeto proveedor con los datos adicionales
            Dim nuevoProveedor As New CE_Proveedores With {
            .RazonSocial = TRazonSocial.Text
        }

            ' Llamar a la capa de negocio para registrar a la persona y el proveedor
            Dim objCN_Proveedor As New CN_Proveedores()
            objCN_Proveedor.RegistrarProveedor(nuevaPersona, nuevoProveedor) ' Ahora se registra tanto persona como proveedor

            MostrarProveedoresActivos() ' Actualiza la lista de proveedores activos en el DataGridView
            Limpiar() ' Limpia el formulario
            MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub DgProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProveedores.CellClick
        ' Verificar que la celda clickeada no sea el encabezado
        If e.RowIndex >= 0 Then
            ' Verificar si es la columna "Modificar"
            If DgProveedores.Columns(e.ColumnIndex).Name = "CModificar" Then
                ' Obtener la fila seleccionada
                If MessageBox.Show("¿Está seguro de que desea modificar a este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        Dim selectedRow As DataGridViewRow = DgProveedores.Rows(e.RowIndex)

                        ' Cargar los datos en los TextBox para modificar
                        TNombre.Text = selectedRow.Cells("CNombre").Value.ToString()
                        TApellido.Text = selectedRow.Cells("CApellido").Value.ToString()
                        TDNI.Text = selectedRow.Cells("CDNI").Value.ToString()
                        Tcelular.Text = selectedRow.Cells("Ccelular").Value.ToString()
                        TDireccion.Text = selectedRow.Cells("CDireccion").Value.ToString()
                        id.Text = selectedRow.Cells("CIdpersona").Value.ToString()

                        ' Obtener la razón social del proveedor
                        TRazonSocial.Text = If(selectedRow.Cells("CRazonsocial").Value IsNot Nothing AndAlso Not IsDBNull(selectedRow.Cells("CRazonsocial").Value),
                                            selectedRow.Cells("CRazonsocial").Value.ToString(), String.Empty)

                        ' Mostrar el botón de Guardar y ocultar el de Agregar
                        BGuardar.Visible = True
                        BAgregar.Visible = False
                    Catch ex As Exception
                        MessageBox.Show("Error al modificar al proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                ' Verificar si es la columna "Eliminar"
            ElseIf DgProveedores.Columns(e.ColumnIndex).Name = "CEliminar" Then
                ' Confirmar la eliminación lógica (cambiar el estado a "Inactivo")
                Dim idPersona As Integer = Convert.ToInt32(DgProveedores.Rows(e.RowIndex).Cells("CIdpersona").Value)
                If MessageBox.Show("¿Está seguro de que desea marcar como inactiva a esta persona?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        ' Llamar a la capa de negocio para cambiar el estado a inactivo
                        Dim objCapaNegocio As New CN_Personas()
                        objCapaNegocio.EliminarPersona(idPersona)

                        MostrarProveedoresActivos() ' Método que actualiza el DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error al marcar como inactiva a la persona: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                ' Verificar si es la columna "Activar"
            ElseIf DgProveedores.Columns(e.ColumnIndex).Name = "CActivar" Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DgProveedores.Rows(e.RowIndex)
                Dim idPersona As Integer = Convert.ToInt32(selectedRow.Cells("CIdpersona").Value) ' Cambié "id_persona" por "CId_cliente"

                ' Confirmar activación
                Dim confirmacion As DialogResult = MessageBox.Show("¿Deseas activar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmacion = DialogResult.Yes Then
                    Try
                        ' Llamar a la capa de negocio para activar al cliente
                        Dim objNegocio As New CN_Personas()
                        objNegocio.ActivarCliente(idPersona)

                        ' Refrescar el DataGridView
                        MostrarProveedoresInactivos()
                        MessageBox.Show("Cliente activado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error al activar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub LlenarDataGridProveedores()
        Dim objCN As New CN_Personas() ' Instancia de la capa de negocio
        Dim dtClientes As DataTable = objCN.ListarClientesActivos()
        DgProveedores.DataSource = dtClientes
    End Sub

    Private Sub BActivo_Click(sender As Object, e As EventArgs) Handles BActivo.Click
        MostrarProveedoresActivos()
        DgProveedores.Columns(0).Visible = True
        DgProveedores.Columns(1).Visible = False ' Ocultar columna id_persona si no es necesario
        BActivo.Visible = False
        BInactivo.Visible = True
    End Sub

    Private Sub BInactivo_Click(sender As Object, e As EventArgs) Handles BInactivo.Click
        MostrarProveedoresInactivos()
        DgProveedores.Columns(0).Visible = False
        DgProveedores.Columns(1).Visible = True ' Ocultar columna id_persona si no es necesario
        BActivo.Visible = True
        BInactivo.Visible = False
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Try
            ' Validar el número de documento (DNI)
            If TDNI.Text.Length < 7 Or TDNI.Text.Length > 8 Or Not IsNumeric(TDNI.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular
            If Tcelular.Text.Length < 7 Or Not IsNumeric(Tcelular.Text) Then
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
            If apellidos.Length > 2 Then
                MessageBox.Show("Se permiten hasta 2 apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Crear instancia de la entidad CE_Personas
            Dim proveedor As New CE_Personas With {
            .IdPersona = Convert.ToInt32(id.Text), ' ID del proveedor
            .Nombre = TNombre.Text,
            .Apellido = TApellido.Text,
            .NDocumento = Convert.ToInt32(TDNI.Text),
            .Celular = Convert.ToInt32(Tcelular.Text),
            .Direccion = TDireccion.Text
        }

            ' Crear instancia de la entidad CE_Proveedores para la razón social
            Dim proveedorNuevo As New CE_Proveedores With {
            .RazonSocial = TRazonSocial.Text,
            .IdProveedor = Convert.ToInt32(id.Text) ' Suponiendo que el ID de proveedor es el mismo que el de persona
        }

            ' Llamar a la capa de negocio para modificar el proveedor
            Dim objCN_Proveedores As New CN_Proveedores()

            ' Llamamos a la función que modifica el proveedor
            objCN_Proveedores.ModificarProveedor(proveedor, proveedorNuevo)

            ' Mostrar mensaje de éxito y actualizar DataGridView
            MessageBox.Show("Proveedor modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarProveedoresActivos() ' Método para llenar el DataGrid con los proveedores
            Limpiar() ' Limpiar los campos del formulario

        Catch ex As Exception
            MessageBox.Show("Error al modificar proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TxtBusca_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado y el criterio seleccionado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()

        ' Verificar si el TextBox está vacío o si el criterio es nulo
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos
            LlenarDataGridProveedores()
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
                DgProveedores.DataSource = dtClientes
            Else
                ' Si no hay resultados, limpiar el DataGridView
                DgProveedores.DataSource = Nothing
            End If



        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BCancela_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Limpiar()
        BGuardar.Visible = False
        BAgregar.Visible = True
    End Sub


End Class