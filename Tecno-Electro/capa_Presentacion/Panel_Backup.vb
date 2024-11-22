
Imports System.Data.SqlClient
Imports capa_negocio

Public Class panel_backup




    Private btnBackup As Object
    Dim servidor As String = "DESKTOP-2DEKO59"
    Dim baseDatos As String = "TecnoElectro"
    Dim rutaBackup As String = "C:\Respaldos\Tecno_Electro.bak" ' Cambia esta ruta si es necesario
    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SLocal.Text = servidor
        BasedeDatos.Text = baseDatos
        txtDirectorio.Text = rutaBackup
        txtNombreBackup.Text = "Tecno_Electro.bak"


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Define los parámetros de conexión


        'Cadena de conexión a SQL Server
        Dim connectionString As String = $"Server={servidor};Database={baseDatos};Integrated Security=True;"

        'Comando Sql para crear el backup
        Dim query As String = $"BACKUP DATABASE [{baseDatos}] TO DISK = '{rutaBackup}' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of Tecno_Electro';"

        Try
            'Conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Ejecuta el comando de backup
                Using command As New SqlCommand(query, connection)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Backup creado exitosamente en: " & rutaBackup, "Backup Completo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error al crear el backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
