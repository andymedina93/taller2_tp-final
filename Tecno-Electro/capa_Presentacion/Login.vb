Imports capa_entidad
Imports capa_negocio

Public Class Login
    ' En el evento de autenticación


    Private negocioUsuario As New CN_PersonasUsuarios()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContraseña.Text

        ' Crear una instancia de la Capa de Negocio para verificar el login
        Dim cnUsuarios As New CN_PersonasUsuarios()
        Dim resultado = cnUsuarios.VerificarLogin(usuario, contrasena)

        Dim exito As Boolean = resultado.Item1
        Dim idUsuario As Integer = resultado.Item2
        Dim nombre As String = resultado.Item3
        Dim perfil As String = resultado.Item4
        Dim apellido As String = resultado.Item5

        If exito Then
            ' Si el login fue exitoso, mostrar el id, nombre y perfil en un Label o en otro formulario
            MessageBox.Show("Bienvenido: " & nombre & " apellido: " & apellido & ", Perfil: " & perfil & ")", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            ' Redirigir al formulario principal si es necesario
            Dim formPrincipal As New menuPanel()
            formPrincipal.NombreUsuario = nombre
            formPrincipal.Perfil = perfil
            formPrincipal.idUsuario = idUsuario
            formPrincipal.apellido = apellido
            formPrincipal.Show()


            ' Cerrar el formulario de login si es necesario

        Else
            ' Si las credenciales no son válidas
            MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class
