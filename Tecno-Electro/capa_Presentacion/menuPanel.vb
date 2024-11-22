
Imports System.Data.SqlClient
Imports capa_negocio
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class menuPanel
    Private formularioActual As Form ' Variable para mantener el formulario actualmente mostrado
    Public Property NombreUsuario As String
    Public Property Perfil As String
    Public Property idUsuario As Integer
    Public Property apellido As String

    Private Sub menu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        panelProductos.WindowState = FormWindowState.Normal : panelProductos.WindowState = FormWindowState.Maximized
        Ventas.WindowState = FormWindowState.Normal : Ventas.WindowState = FormWindowState.Maximized
        panelUsuario.WindowState = FormWindowState.Normal : panelUsuario.WindowState = FormWindowState.Maximized
        panelProveedores.WindowState = FormWindowState.Normal : panelProveedores.WindowState = FormWindowState.Maximized
        panel_clliente.WindowState = FormWindowState.Normal : panel_clliente.WindowState = FormWindowState.Maximized
        Panel_Reporte.WindowState = FormWindowState.Normal : Panel_Reporte.WindowState = FormWindowState.Maximized
        panel_Backup.WindowState = FormWindowState.Normal : panel_Backup.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        MostrarFormulario(panel_clliente)
        titulo.Text = "Panel Clientes"
    End Sub

    Private Sub MostrarFormulario(formulario As Form)
        ' Verificar si el formulario ya está abierto
        If formularioActual IsNot Nothing AndAlso formularioActual Is formulario Then
            ' Si el formulario que se va a abrir ya es el formulario actual, no hacer nada
            Return
        End If

        ' Cerrar el formulario actual (si hay uno)
        If formularioActual IsNot Nothing AndAlso Not formularioActual.IsDisposed Then
            formularioActual.Close()
        End If

        ' Mostrar el nuevo formulario en el contenedor
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        panelcontenedor.Controls.Add(formulario)
        formulario.Show()

        ' Actualizar el formulario actual
        formularioActual = formulario
    End Sub

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        MostrarFormulario(panelUsuario)
        titulo.Text = "Panel Usuarios"
    End Sub

    Private Sub BVentas_Click(sender As Object, e As EventArgs) Handles BVentas.Click
        Ventas.id_usuario = idUsuario
        Ventas.NombreUsuario = NombreUsuario
        Ventas.apellido = apellido
        MostrarFormulario(Ventas)
        titulo.Text = "Panel Ventas"

    End Sub

    Private Sub BProductos_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        MostrarFormulario(panelProductos)
        titulo.Text = "Panel Productos"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub BProveedores_Click(sender As Object, e As EventArgs) Handles BProveedores.Click
        MostrarFormulario(panelProveedores)
        titulo.Text = "Panel Proveedores"
    End Sub



    Private Sub menuPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarFormulario(inicio)
        titulo.Text = "Inicio"
        inicio.idUsuario = idUsuario

        LUsuario.Text = apellido & " " & NombreUsuario
        inicio.NombreUsuario = NombreUsuario
        inicio.apellido = apellido
        Select Case perfil
            Case "Administrador"
                ' Habilita todos los botones
                BVentas.Enabled = False
                BReportes.Enabled = False
                BBackup.Enabled = False
                BClientes.Enabled = True
                BProductos.Enabled = True
                BUsuarios.Enabled = True
                BProveedores.Enabled = True

            Case "Cajero"
                ' Habilita solo algunos botones
                BVentas.Enabled = True
                BReportes.Enabled = False
                BBackup.Enabled = False
                BClientes.Enabled = False
                BProductos.Enabled = False
                BUsuarios.Enabled = False
                BProveedores.Enabled = False

            Case Else
                ' Configuración predeterminada para perfiles no especificados
                BVentas.Enabled = False
                BReportes.Enabled = True
                BBackup.Enabled = True
                BClientes.Enabled = False
                BProductos.Enabled = False
                BUsuarios.Enabled = False
                BProveedores.Enabled = False

        End Select

    End Sub



    Private Sub BReportes_Click(sender As Object, e As EventArgs) Handles BReportes.Click
        MostrarFormulario(Panel_Reporte)
        titulo.Text = "Panel Reportes"
    End Sub



    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        MostrarFormulario(panel_Backup)
        titulo.Text = "Panel Backup"
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inicio.idUsuario = idUsuario
        inicio.apellido = apellido
        inicio.perfil = Perfil
        inicio.NombreUsuario = NombreUsuario
        titulo.Text = "Inicio"
        MostrarFormulario(inicio)
    End Sub





    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub panelcontenedor_Paint(sender As Object, e As PaintEventArgs) Handles panelcontenedor.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

