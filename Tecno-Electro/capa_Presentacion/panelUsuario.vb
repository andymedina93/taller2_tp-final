Imports capa_datos
Imports capa_entidad
Imports capa_negocio
Public Class panelUsuario
    Private objCapaNegocio As New CN_PersonasUsuarios()
    Dim n_perfil As Integer
    Dim perfi As String

    Dim id_persona As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDataGridPersonas()
        BGuardar.Visible = False
        BActivos.Visible = False
        DgUsuarios.Columns(0).Visible = False
        DgUsuarios.Columns(1).Visible = True
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        limpiarCampos()
        BAgregar.Visible = True
        BGuardar.Visible = False
        TUsuario.ReadOnly = False

    End Sub

    'validacines de campos de string y enteros

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


    Private Sub TContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TContraseña.KeyPress
        ' Verificar si el carácter es un número o una tecla de control (como retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Ingrese solo caracteres numéricos")
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub TContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TContraseña.Validating
        ' Verificar que el número tenga al menos 5 caracteres cuando el usuario termina de ingresar
        If TContraseña.Text.Length < 5 Then
            MessageBox.Show("La contraseña debe tener al menos 5 caracteres.")
            e.Cancel = True ' Prevenir que el usuario abandone el campo hasta que cumpla con la condición
        End If
    End Sub


    Private Sub Tdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("ingrese Solo caracteres numericos")
            e.Handled = True
            Return
        End If

    End Sub
    Private Sub TCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCelular.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("ingrese Solo caracteres numericos")
            e.Handled = True
            Return
        End If

    End Sub


    Private Sub TPerfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TPerfil.SelectedIndexChanged
        If TPerfil.SelectedItem IsNot Nothing Then
            ' Guardar la selección en la variable
            perfi = TPerfil.SelectedItem.ToString
            ' Puedes usar ToString() para obtener el valor seleccionado como cadena
            If perfi = "Admin" Then
                n_perfil = 1
            Else
                If perfi = "Cajero" Then
                    n_perfil = 2
                Else
                    If perfi = "Gerente" Then
                        n_perfil = 3
                    End If
                End If
            End If
        Else
            ' El ComboBox está vacío o no se ha seleccionado ningún elemento
            MessageBox.Show("Selecciona una opción primero.")
        End If

    End Sub


    Private Sub limpiarCampos()
        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        TDireccion.Clear()
        TCelular.Clear()
        TUsuario.Clear()
        TContraseña.Clear()
        TPerfil.SelectedItem = " "

    End Sub
    Private Sub LlenarDataGridPersonas()
        Try
            ' Obtener el DataTable desde la capa de negocio
            Dim dtPersonasYUsuarios As DataTable = objCapaNegocio.ObtenerPersonasYUsuariosActivos()

            ' Asignar los datos al DataGridView
            DgUsuarios.DataSource = dtPersonasYUsuarios
        Catch ex As Exception
            MessageBox.Show("Error al mostrar personas y usuarios: " & ex.Message)
        End Try
    End Sub



    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        Try
            ' Validar el número de documento (DNI)
            If TDni.Text.Length < 7 Or TDni.Text.Length > 8 Or Not IsNumeric(TDni.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular


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

            ' Verificar que todos los campos estén llenos
            If String.IsNullOrWhiteSpace(TNombre.Text) OrElse
           String.IsNullOrWhiteSpace(TApellido.Text) OrElse
           String.IsNullOrWhiteSpace(TDni.Text) OrElse
           String.IsNullOrWhiteSpace(TDireccion.Text) OrElse
           String.IsNullOrWhiteSpace(TCelular.Text) OrElse
           String.IsNullOrWhiteSpace(TUsuario.Text) OrElse
           TPerfil.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(TContraseña.Text) Then

                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si hay campos incompletos
            End If

            ' Crear objeto para la persona
            Dim nuevaPersona As New CE_Personas With {
            .Nombre = TNombre.Text,
            .Apellido = TApellido.Text,
            .NDocumento = TDni.Text,
            .Direccion = TDireccion.Text,
            .Celular = TCelular.Text,
            .estado = "Activo",
            .FechaRegistro = DateTime.Now ' O puedes tomar la fecha de un control DateTimePicker
            }

            ' Crear objeto para el usuario
            Dim nuevoUsuario As New ce_Usuarios With {
            .usuario = TUsuario.Text,
            .contraseña = TContraseña.Text,
            .idPerfil = n_perfil
        }

            ' Llamar a la capa de negocio para verificar si el usuario ya existe
            Dim obj_PersonasUsuarios As New CN_PersonasUsuarios()

            ' Verificar si el usuario ya existe
            If Not obj_PersonasUsuarios.EsUsuarioUnico(nuevoUsuario.usuario) Then
                MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el usuario no es único
            End If

            ' Si el usuario es único, proceder a guardar la persona y el usuario
            obj_PersonasUsuarios.GuardarPersonaYUsuario(nuevaPersona, nuevoUsuario)

            MessageBox.Show("Usuario y persona guardados con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LlenarDataGridPersonas()
            limpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar usuario y persona: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click

        Try
            ' Validar el número de documento (DNI)
            If TDni.Text.Length < 7 Or TDni.Text.Length > 8 Or Not IsNumeric(TDni.Text) Then
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el número de celular


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
            ' Crear instancia de la entidad CE_Personas
            Dim persona As New CE_Personas With {
                .IdPersona = n_personaid.Text,
                .Nombre = TNombre.Text,
                .Apellido = TApellido.Text,
                .NDocumento = TDni.Text,
                .Celular = TCelular.Text,
                .Direccion = TDireccion.Text
            }

            ' Crear instancia de la entidad CE_Usuarios
            Dim usuario As New ce_Usuarios With {
                .id_usuario = n_usuarioid.Text,
                .usuario = TUsuario.Text,
                .contraseña = TContraseña.Text,
                .idPerfil = n_perfil
    }

            ' Llamar al método de la capa de negocio

            Dim objCN_PersonasUsuarios As New CN_PersonasUsuarios()
            objCN_PersonasUsuarios.ModificarPersonaYUsuario(persona, usuario)

            MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LlenarDataGridPersonas()
            limpiarCampos()
            BAgregar.Visible = True
            BGuardar.Visible = False
            TUsuario.ReadOnly = False
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BInactivos_Click(sender As Object, e As EventArgs) Handles BInactivos.Click
        Try
            Dim dtPersonasYUsuarios As DataTable = objCapaNegocio.ObtenerPersonasYUsuariosInactivos()

            ' Asignar los datos al DataGridView
            DgUsuarios.DataSource = dtPersonasYUsuarios
            DgUsuarios.Columns(0).Visible = True
            DgUsuarios.Columns(1).Visible = False
            BActivos.Visible = True
            BInactivos.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error al mostrar usuarios inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BActivos_Click(sender As Object, e As EventArgs) Handles BActivos.Click
        Try
            Dim dtPersonasYUsuarios As DataTable = objCapaNegocio.ObtenerPersonasYUsuariosActivos()

            ' Asignar los datos al DataGridView
            DgUsuarios.DataSource = dtPersonasYUsuarios
            DgUsuarios.Columns(0).Visible = False
            DgUsuarios.Columns(1).Visible = True
            BActivos.Visible = False
            BInactivos.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error al mostrar usuarios inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub DgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgUsuarios.CellClick
        ' Verificar que la celda que se ha clickeado no sea la cabecera
        If e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = DgUsuarios.Rows(e.RowIndex)

            ' Verificar que la columna clickeada sea la columna de "Modificar"
            If DgUsuarios.Columns(e.ColumnIndex).Name = "CModificar" Then
                If MessageBox.Show("¿Está seguro de que desea modificar a este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                    ' Cargar los datos en los TextBox
                    TNombre.Text = selectedRow.Cells("Nombre").Value.ToString()
                    TApellido.Text = selectedRow.Cells("Apellido").Value.ToString()
                    TDni.Text = selectedRow.Cells("Dni").Value.ToString()
                    TCelular.Text = selectedRow.Cells("Celular").Value.ToString()
                    TDireccion.Text = selectedRow.Cells("Direccion").Value.ToString()
                    TUsuario.Text = selectedRow.Cells("Usuario").Value.ToString()
                    n_usuarioid.Text = selectedRow.Cells("id_usuario").Value.ToString()
                    n_personaid.Text = selectedRow.Cells("id").Value.ToString()
                    TPerfil.SelectedValue = selectedRow.Cells("perfil").Value.ToString()
                    TContraseña.Text = selectedRow.Cells("contraseña").Value.ToString()
                    BGuardar.Visible = True
                    BAgregar.Visible = False
                    TUsuario.ReadOnly = True
                End If
                ' Verificar si se hace clic en la columna "Eliminar"
            ElseIf DgUsuarios.Columns(e.ColumnIndex).Name = "CEliminar" Then
                Dim confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmResult = DialogResult.Yes Then
                    ' Cambiar el estado a inactivo
                    Dim obj_PersonasUsuarios As New CN_PersonasUsuarios()
                    Dim idPersona As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                    obj_PersonasUsuarios.EliminarPersona(idPersona) ' Llama a la función para cambiar el estado

                    ' Actualizar el DataGridView
                    Dim dtPersonasYUsuarios As DataTable = objCapaNegocio.ObtenerPersonasYUsuariosInactivos() ' O el método que uses para refrescar la lista
                End If

                ' Verificar si se hace clic en la columna "Activar"
            ElseIf DgUsuarios.Columns(e.ColumnIndex).Name = "CActivar" Then
                Dim confirmResult = MessageBox.Show("¿Está seguro de que desea activar este usuario?", "Confirmar activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmResult = DialogResult.Yes Then
                    ' Cambiar el estado a activo
                    Dim idPersona As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                    Dim obj_PersonasUsuarios As New CN_PersonasUsuarios()
                    obj_PersonasUsuarios.ActivarPersona(idPersona)

                    ' Actualizar el DataGridView
                    LlenarDataGridPersonas() ' O el método que uses para refrescar la lista
                End If
            End If
        End If
    End Sub

    ' Método para cambiar el estado del usuario


    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Obtener el valor ingresado y el criterio seleccionado
        Dim valorBuscar As String = TxtBuscar.Text.Trim()
        Dim criterio As String = CriterioBusqueda.SelectedItem?.ToString()

        ' Verificar si el TextBox está vacío o si el criterio es nulo
        If String.IsNullOrEmpty(valorBuscar) OrElse String.IsNullOrEmpty(criterio) Then
            ' Si está vacío, limpiar el DataGridView o volver a mostrar todos los clientes activos
            LlenarDataGridPersonas()
            Return
        End If

        ' Verificar que el valor a buscar tenga al menos 3 caracteres para evitar errores
        If valorBuscar.Length < 1 Then
            ' Evitar ejecutar búsquedas con menos de 3 caracteres
            Return
        End If

        ' Llamar al método de la capa de negocio para buscar clientes según el criterio
        Try
            Dim objNegocio As New CN_PersonasUsuarios()
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
                DgUsuarios.DataSource = dtClientes
            Else
                ' Si no hay resultados, limpiar el DataGridView
                DgUsuarios.DataSource = Nothing
            End If



        Catch ex As Exception
            MessageBox.Show("Error al buscar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgUsuarios.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TCelular_TextChanged(sender As Object, e As EventArgs) Handles TCelular.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class