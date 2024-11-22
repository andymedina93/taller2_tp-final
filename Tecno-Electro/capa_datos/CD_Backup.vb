Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class CD_Backup
    ' Capa de Datos: CD_Backup.vb

    ' Método para realizar el backup de la base de datos
    Public Sub RealizarBackup(rutaArchivo As String)
        Dim connectionString As String = Conexion.cadena
        Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()

                ' Comando SQL para realizar el backup
                Dim backupCommand As String = "BACKUP DATABASE [tecno_electro] TO DISK = @FilePath"
                Using command As New SqlCommand(backupCommand, connection)
                        ' Parámetro para la ruta del archivo
                        command.Parameters.AddWithValue("@FilePath", rutaArchivo)

                        ' Ejecutar el comando de backup
                        command.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al realizar el backup: " & ex.Message)
                End Try
            End Using
        End Sub


    End Class
