Imports capa_entidad
Imports capa_negocio
Imports OxyPlot.Reporting

Public Class inicio
    Property idUsuario As Integer
    Property NombreUsuario As String
    Property perfil As String
    Property apellido As String
    Dim ocultar As Boolean
    Private cnUsuarios As New CN_PersonasUsuarios
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMejorVendedorDelMes()
        CargarProductos()
        Select Case perfil
            Case "Administrador"
                ' Habilita todos los botones
                BVentas.Enabled = False
                Button2.Enabled = False


            Case "Cajero"
                ' Habilita solo algunos botones
                BVentas.Enabled = True
                Button2.Enabled = True


            Case Else
                ' Configuración predeterminada para perfiles no especificados
                BVentas.Enabled = False
                Button2.Enabled = False


        End Select
    End Sub

    Public Sub MostrarMejorVendedorDelMes()
        ' Obtener la fecha de inicio del mes actual
        Dim fechaInicio As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        ' Obtener la fecha de fin del mes actual
        Dim fechaFin As DateTime = fechaInicio.AddMonths(1).AddDays(-1)

        ' Crear una instancia de CN_PersonasUsuarios
        Dim cnVentas As New CN_PersonasUsuarios()

        ' Obtenemos el mejor vendedor del mes
        Dim dtVentas As DataTable = cnVentas.MejorVendedor(fechaInicio, fechaFin, 1) ' El "1" es para obtener solo el mejor vendedor

        ' Verificar si hay al menos un registro en el resultado
        If dtVentas.Rows.Count > 0 Then
            ' Obtener el nombre y apellido del mejor vendedor
            Dim nombreVendedor As String = dtVentas.Rows(0)("Nombre").ToString()
            Dim apellidoVendedor As String = dtVentas.Rows(0)("Apellido").ToString()

            ' Mostrar el nombre y apellido en el Label
            Nombre.Text = nombreVendedor & " " & apellidoVendedor
        Else
            ' En caso de no haber ventas en el mes actual
            Nombre.Text = "No se encontró un mejor vendedor para este mes."
        End If
    End Sub

    Public Sub CargarProductos()
        ' Dim fechaI As DateTime = DateTime.Now.Date
        ' Obtener la fecha de fin del mes actual
        'Dim fechaF As DateTime = DateTime.Now.Date
        ' Crear una instancia de la capa de negocio CN_Productos
        Dim fechaI As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        ' Obtener la fecha de fin del mes actual
        Dim fechaF As DateTime = fechaI.AddMonths(1).AddDays(-1)
        Dim cnProductos As New CN_Productos()



        ' Obtener los productos más vendidos en el rango de fechas y por categoría
        Dim dtProductos As DataTable = cnProductos.productosquemasseVendio(fechaI, fechaF, 1)

        ' Asignar los datos al DataGridView


        ' Verificar si el DataTable contiene algún registro
        If dtProductos.Rows.Count > 0 Then
            ' Obtener el nombre del producto y la categoría del primer registro
            Dim nombreProducto As String = dtProductos.Rows(0)("Producto").ToString()


            ' Mostrar el nombre del producto y la categoría en el Label
            producto.Text = "Producto: " & nombreProducto
        Else
            ' En caso de no haber productos en el rango de fechas y categoría seleccionada
            producto.Text = "No se encontraron productos para el rango y categoría seleccionados."
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        ' Establece la fecha de inicio y fin en los TextBox
        txtFechaInicio.Text = e.Start.ToString("dd/MM/yyyy") ' Formato de fecha deseado

    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        ' Establece la fecha de inicio y fin en los TextBox
        ' Formato de fecha deseado
        txtFechaFin.Text = e.Start.ToString("dd/MM/yyyy")
    End Sub

    Private Sub BVentas_Click(sender As Object, e As EventArgs) Handles BVentas.Click
        ocultar = False
        If txtFechaInicio.Text = Nothing Or txtFechaFin.Text = Nothing Then
            MessageBox.Show("Por favor, ingrese las fechas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: Establecer el foco en el TextBoxs

        Else
            Dim fechaInicio = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
            Dim fechaFin = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")

            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            frmReporte.usuarioid = idUsuario
            frmReporte.fechaInicio = fechaInicio
            frmReporte.fechaFin = fechaFin
            frmReporte.CargarCabecera(idUsuario, fechaInicio, fechaFin, ocultar)
            frmReporte.ShowDialog()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim fechaInicio = DateTime.Today
        Dim fechaFin = DateTime.Now
        ocultar = True
        ' Abre el formulario de reporte de ventas
        Dim frmReporte As New Reportes_Ventas
        frmReporte.usuarioid = idUsuario
        frmReporte.apellidous = apellido
        frmReporte.Nombreus = NombreUsuario

        frmReporte.CargarCabecera(idUsuario, fechaInicio, fechaFin, ocultar)
        frmReporte.ShowDialog()


    End Sub

    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click
        Try
            ' Obtener valores del formulario

            Dim nuevaContraseña As String = txtNuevaContraseña.Text
            Dim confirmarContraseña As String = txtConfirmarContraseña.Text

            ' Validar que ambas contraseñas coincidan
            If nuevaContraseña <> confirmarContraseña Then
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Llamar a la capa de negocio para cambiar la contraseña
            If cnUsuarios.CambiarContraseña(idUsuario, nuevaContraseña) Then
                MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNuevaContraseña.Text = " "
                txtConfirmarContraseña.Text = " "

            Else
                MessageBox.Show("No se pudo cambiar la contraseña. Verifique el ID de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        txtNuevaContraseña.Text = " "
        txtConfirmarContraseña.Text = " "
    End Sub

    Private Sub Nombre_Click(sender As Object, e As EventArgs) Handles Nombre.Click

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
End Class