Imports System.IO
Imports capa_datos
Public Class CN_Backup
    Dim backupDatos As New CD_Backup()
    Public Sub RealizarBackup(rutaArchivo As String)
        Dim cdBackup As New CD_Backup()
        cdBackup.RealizarBackup(rutaArchivo)
    End Sub
End Class
