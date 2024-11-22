
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports capa_datos
Imports capa_entidad
Imports capa_negocio

Public Class Panel_Reporte



    Private Sub BVentas_Click(sender As Object, e As EventArgs) Handles BVentas.Click
        Dim x As Boolean
        x = True
        If fechaI.Text = Nothing Or fechaF.Text = Nothing Then

            Dim fechaInicio = New DateTime(1999, 1, 1)
            Dim fechaFin = New DateTime(2124, 1, 1)
            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            frmReporte.fechaInicio = fechaInicio
            frmReporte.fechaFin = fechaFin
            frmReporte.x = x
            frmReporte.CargarcabeceraPorFecha(fechaInicio, fechaFin)
            frmReporte.ShowDialog()

        Else
            Dim fechaInicio = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
            Dim fechaFin = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")

            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            frmReporte.fechaInicio = fechaInicio
            frmReporte.fechaFin = fechaFin
            frmReporte.x = x
            frmReporte.CargarcabeceraPorFecha(fechaInicio, fechaFin)
            frmReporte.ShowDialog()
        End If
    End Sub

    Private Sub Bproductos_Click(sender As Object, e As EventArgs) Handles Bproductos.Click
        If String.IsNullOrWhiteSpace(Nproducto.Text) Then
            MessageBox.Show("Por favor, stock minimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: Establecer el foco en el TextBox
            Nproducto.Focus()
        Else
            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            Dim tope = Nproducto.Text
            frmReporte.CargarStock(tope)
            frmReporte.ShowDialog()
            Nproducto.Text = ""
        End If
    End Sub

    Private Sub BVendedor_Click(sender As Object, e As EventArgs) Handles BVendedor.Click
        If String.IsNullOrWhiteSpace(Nvendedor.Text) And fechaI.Text = Nothing Or fechaF.Text = Nothing Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: Establecer el foco en el TextBox
            Nvendedor.Focus()
        Else
            Dim fechaInicio = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
            Dim fechaFin = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")

            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            Dim tope = Nvendedor.Text
            frmReporte.mejorVendedor(fechaInicio, fechaFin, tope)
            frmReporte.ShowDialog()
            Nvendedor.Text = ""
        End If
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        If String.IsNullOrWhiteSpace(Ncliente.Text) And fechaI.Text = Nothing Or fechaF.Text = Nothing Then
            MessageBox.Show("Por favor, ingrese cantidad a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: Establecer el foco en el TextBox
            Ncliente.Focus()
        Else
            Dim fechaInicio = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
            Dim fechaFin = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")

            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            Dim tope = Ncliente.Text
            frmReporte.CargarClientes(fechaInicio, fechaFin, tope)
            frmReporte.ShowDialog()
            Ncliente.Text = ""
        End If
    End Sub


    Private Sub CargarCategorias()
        Try
            ' Llamar a la capa de negocio para obtener las categorías
            Dim objCN_Categorias As New CN_Categorias()
            Dim dtCategorias As DataTable = objCN_Categorias.ListarCategorias()

            ' Asignar los datos al ComboBox
            With Tcategoria
                .DataSource = dtCategorias
                .DisplayMember = "c_descripcion" ' Lo que se mostrará en el ComboBox
                .ValueMember = "Id_categoria"  ' El valor asociado con cada opción (clave primaria)
                .SelectedIndex = -1 ' Para que no seleccione nada al inicio
            End With

        Catch ex As Exception

            MessageBox.Show("Error al cargar las categorías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        Graficos.Visible = False
    End Sub

    Private Sub BProductoVendidos_Click(sender As Object, e As EventArgs) Handles BProductoVendidos.Click
        If String.IsNullOrWhiteSpace(Nvendidos.Text) And fechaI.Text = Nothing Or fechaF.Text = Nothing Or Tcategoria.Text = Nothing Then
            MessageBox.Show("Por favor, ingrese cantidad a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: Establecer el foco en el TextBoxs
            Nvendidos.Focus()
        Else
            Dim fechaInicio = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
            Dim fechaFin = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")

            ' Abre el formulario de reporte de ventas
            Dim frmReporte As New Reportes_Ventas
            Dim categoria = Tcategoria.Text
            Dim tope = Nvendidos.Text
            frmReporte.cargarProductos(fechaInicio, fechaFin, tope, categoria)
            frmReporte.ShowDialog()
            Nvendidos.Text = ""
            Tcategoria.Text = ""
        End If
    End Sub
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        fechaI.Text = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
    End Sub
    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        fechaF.Text = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Nproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nproducto.KeyPress
        ' Verificar si la tecla presionada no es numérica y no es una tecla de control
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancela la entrada de tecla no numérica

            ' Mostrar mensaje de advertencia solo si no es numérico
            MessageBox.Show("Solo se pueden ingresar números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub Nvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nvendedor.KeyPress
        ' Verificar si la tecla presionada no es numérica y no es una tecla de control
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancela la entrada de tecla no numérica

            ' Mostrar mensaje de advertencia solo si no es numérico
            MessageBox.Show("Solo se pueden ingresar números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub Nvendidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nvendidos.KeyPress
        ' Verificar si la tecla presionada no es numérica y no es una tecla de control
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancela la entrada de tecla no numérica

            ' Mostrar mensaje de advertencia solo si no es numérico
            MessageBox.Show("Solo se pueden ingresar números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub Ncliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ncliente.KeyPress
        ' Verificar si la tecla presionada no es numérica y no es una tecla de control
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancela la entrada de tecla no numérica

            ' Mostrar mensaje de advertencia solo si no es numérico
            MessageBox.Show("Solo se pueden ingresar números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Graficos_Click(sender As Object, e As EventArgs) Handles Graficos.Click
        Dim frmReporte As New Graficos

        frmReporte.ShowDialog()
    End Sub
End Class