<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panel_backup
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtObservacion = New GroupBox()
        BasedeDatos = New TextBox()
        SLocal = New TextBox()
        Button1 = New Button()
        txtNombreBackup = New TextBox()
        txtDirectorio = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Box_realizar_backup = New GroupBox()
        txtObservacion.SuspendLayout()
        Box_realizar_backup.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtObservacion
        ' 
        txtObservacion.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtObservacion.Controls.Add(BasedeDatos)
        txtObservacion.Controls.Add(SLocal)
        txtObservacion.Controls.Add(Button1)
        txtObservacion.Controls.Add(txtNombreBackup)
        txtObservacion.Controls.Add(txtDirectorio)
        txtObservacion.Controls.Add(Label5)
        txtObservacion.Controls.Add(Label3)
        txtObservacion.Controls.Add(Label1)
        txtObservacion.Controls.Add(Label2)
        txtObservacion.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtObservacion.ForeColor = Color.White
        txtObservacion.Location = New Point(87, 64)
        txtObservacion.Margin = New Padding(4, 3, 4, 3)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Padding = New Padding(4, 3, 4, 3)
        txtObservacion.Size = New Size(882, 428)
        txtObservacion.TabIndex = 2
        txtObservacion.TabStop = False
        txtObservacion.Text = "Información del backup"
        ' 
        ' BasedeDatos
        ' 
        BasedeDatos.Enabled = False
        BasedeDatos.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BasedeDatos.Location = New Point(578, 84)
        BasedeDatos.Margin = New Padding(4, 3, 4, 3)
        BasedeDatos.Name = "BasedeDatos"
        BasedeDatos.Size = New Size(172, 22)
        BasedeDatos.TabIndex = 68
        ' 
        ' SLocal
        ' 
        SLocal.Enabled = False
        SLocal.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SLocal.Location = New Point(262, 84)
        SLocal.Margin = New Padding(4, 3, 4, 3)
        SLocal.Name = "SLocal"
        SLocal.Size = New Size(172, 22)
        SLocal.TabIndex = 67
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.Location = New Point(543, 327)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 45)
        Button1.TabIndex = 66
        Button1.Text = "Crear Backup"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtNombreBackup
        ' 
        txtNombreBackup.Enabled = False
        txtNombreBackup.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombreBackup.Location = New Point(262, 229)
        txtNombreBackup.Margin = New Padding(4, 3, 4, 3)
        txtNombreBackup.Name = "txtNombreBackup"
        txtNombreBackup.Size = New Size(488, 22)
        txtNombreBackup.TabIndex = 65
        ' 
        ' txtDirectorio
        ' 
        txtDirectorio.Enabled = False
        txtDirectorio.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDirectorio.Location = New Point(262, 149)
        txtDirectorio.Margin = New Padding(4, 3, 4, 3)
        txtDirectorio.Name = "txtDirectorio"
        txtDirectorio.Size = New Size(488, 22)
        txtDirectorio.TabIndex = 62
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(458, 90)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 16)
        Label5.TabIndex = 5
        Label5.Text = "Base de datos:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(85, 235)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 16)
        Label3.TabIndex = 3
        Label3.Text = "Nombre del backup:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(85, 90)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 16)
        Label1.TabIndex = 2
        Label1.Text = "Servidor Local:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(85, 164)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 16)
        Label2.TabIndex = 1
        Label2.Text = "Directorio:"
        ' 
        ' Box_realizar_backup
        ' 
        Box_realizar_backup.BackColor = Color.Gray
        Box_realizar_backup.Controls.Add(txtObservacion)
        Box_realizar_backup.Location = New Point(22, 14)
        Box_realizar_backup.Margin = New Padding(4, 3, 4, 3)
        Box_realizar_backup.Name = "Box_realizar_backup"
        Box_realizar_backup.Padding = New Padding(4, 3, 4, 3)
        Box_realizar_backup.Size = New Size(1054, 567)
        Box_realizar_backup.TabIndex = 393
        Box_realizar_backup.TabStop = False
        ' 
        ' panel_backup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(1098, 762)
        Controls.Add(Box_realizar_backup)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "panel_backup"
        StartPosition = FormStartPosition.CenterScreen
        txtObservacion.ResumeLayout(False)
        txtObservacion.PerformLayout()
        Box_realizar_backup.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents txtObservacion As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtNombreBackup As TextBox
	Friend WithEvents txtDirectorio As TextBox
	Private WithEvents btnCrearBackup As Button
	Private WithEvents Box_realizar_backup As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SLocal As TextBox
    Friend WithEvents BasedeDatos As TextBox
End Class
