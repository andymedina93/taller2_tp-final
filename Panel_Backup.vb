
Imports System.Data.SqlClient

Public Class C
	Private btnBackup As Object

	Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Asociar el evento manualmente
		AddHandler btnCrearBackup.Click, AddressOf btnCrearBackup_Click

	End Sub

	Private Sub btnBackup_Click(sender As Object, e As EventArgs)
		' Especifica la ruta y nombre del archivo de respaldo
		Dim backupPath As String = "D:\backup t\Tecno_Electro_backup.bak"

		' Conexión a SQL Server
		Dim connectionString As String = "Server=DESKTOP-3OVO5KM\SQLEXPRESS;Database=Tecno_Electro;Integrated Security=True;"
		Dim query As String = $"BACKUP DATABASE Tecno_Electro TO DISK = '{backupPath}' WITH INIT, STATS=10;"

		Using connection As New SqlConnection(connectionString)
			Dim command As New SqlCommand(query, connection)
			Try
				connection.Open()
				command.ExecuteNonQuery()
				MessageBox.Show("Backup realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Catch ex As Exception
				MessageBox.Show("Error al realizar el backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Using
	End Sub

	Private Sub btnCrearBackup_Click(sender As Object, e As EventArgs) Handles btnCrearBackup.Click
		' Define los parámetros de conexión
		Dim servidor As String = "DESKTOP-3OVO5KM\SQLEXPRESS"
		Dim baseDatos As String = "Tecno_Electro"
		Dim rutaBackup As String = "C:\Respaldos\Tecno_Electro.bak" ' Cambia esta ruta si es necesario
		cbServidorLocal.Text = servidor
		cbBaseDeDatos.Text = baseDatos
		txtDirectorio.Text = rutaBackup

		' Cadena de conexión a SQL Server
		Dim connectionString As String = $"Server={servidor};Database={baseDatos};Integrated Security=True;"

		' Comando SQL para crear el backup
		Dim query As String = $"BACKUP DATABASE [{baseDatos}] TO DISK = '{rutaBackup}' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of Tecno_Electro';"

		Try
			' Conexión a SQL Server
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

	Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub cbServidorLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServidorLocal.SelectedIndexChanged

	End Sub
End Class
