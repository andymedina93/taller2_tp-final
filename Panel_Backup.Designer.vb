<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class C
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
		btnCrearBackup = New Button()
		txtNombreBackup = New TextBox()
		TextBox1 = New TextBox()
		btnExaminar = New Button()
		txtDirectorio = New TextBox()
		cbBaseDeDatos = New ComboBox()
		cbServidorLocal = New ComboBox()
		Label5 = New Label()
		Label4 = New Label()
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
		txtObservacion.Controls.Add(btnCrearBackup)
		txtObservacion.Controls.Add(txtNombreBackup)
		txtObservacion.Controls.Add(TextBox1)
		txtObservacion.Controls.Add(btnExaminar)
		txtObservacion.Controls.Add(txtDirectorio)
		txtObservacion.Controls.Add(cbBaseDeDatos)
		txtObservacion.Controls.Add(cbServidorLocal)
		txtObservacion.Controls.Add(Label5)
		txtObservacion.Controls.Add(Label4)
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
		' btnCrearBackup
		' 
		btnCrearBackup.BackColor = Color.Maroon
		btnCrearBackup.FlatStyle = FlatStyle.Flat
		btnCrearBackup.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnCrearBackup.ForeColor = Color.White
		btnCrearBackup.ImageAlign = ContentAlignment.MiddleLeft
		btnCrearBackup.Location = New Point(262, 349)
		btnCrearBackup.Margin = New Padding(0)
		btnCrearBackup.Name = "btnCrearBackup"
		btnCrearBackup.Size = New Size(127, 35)
		btnCrearBackup.TabIndex = 385
		btnCrearBackup.Text = "Crear backup"
		btnCrearBackup.TextImageRelation = TextImageRelation.ImageBeforeText
		btnCrearBackup.UseVisualStyleBackColor = False
		' 
		' txtNombreBackup
		' 
		txtNombreBackup.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtNombreBackup.Location = New Point(262, 172)
		txtNombreBackup.Margin = New Padding(4, 3, 4, 3)
		txtNombreBackup.Name = "txtNombreBackup"
		txtNombreBackup.Size = New Size(488, 22)
		txtNombreBackup.TabIndex = 65
		' 
		' TextBox1
		' 
		TextBox1.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		TextBox1.Location = New Point(262, 216)
		TextBox1.Margin = New Padding(4, 3, 4, 3)
		TextBox1.Multiline = True
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(488, 105)
		TextBox1.TabIndex = 64
		' 
		' btnExaminar
		' 
		btnExaminar.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnExaminar.ForeColor = SystemColors.ControlDarkDark
		btnExaminar.Location = New Point(664, 113)
		btnExaminar.Margin = New Padding(4, 3, 4, 3)
		btnExaminar.Name = "btnExaminar"
		btnExaminar.Size = New Size(88, 27)
		btnExaminar.TabIndex = 63
		btnExaminar.Text = "Examinar"
		btnExaminar.UseVisualStyleBackColor = True
		' 
		' txtDirectorio
		' 
		txtDirectorio.Font = New Font("Perpetua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtDirectorio.Location = New Point(262, 117)
		txtDirectorio.Margin = New Padding(4, 3, 4, 3)
		txtDirectorio.Name = "txtDirectorio"
		txtDirectorio.Size = New Size(394, 22)
		txtDirectorio.TabIndex = 62
		' 
		' cbBaseDeDatos
		' 
		cbBaseDeDatos.FormattingEnabled = True
		cbBaseDeDatos.Location = New Point(582, 54)
		cbBaseDeDatos.Margin = New Padding(4, 3, 4, 3)
		cbBaseDeDatos.Name = "cbBaseDeDatos"
		cbBaseDeDatos.Size = New Size(168, 24)
		cbBaseDeDatos.TabIndex = 7
		' 
		' cbServidorLocal
		' 
		cbServidorLocal.FormattingEnabled = True
		cbServidorLocal.Location = New Point(262, 54)
		cbServidorLocal.Margin = New Padding(4, 3, 4, 3)
		cbServidorLocal.Name = "cbServidorLocal"
		cbServidorLocal.Size = New Size(168, 24)
		cbServidorLocal.TabIndex = 6
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.ForeColor = Color.White
		Label5.Location = New Point(456, 58)
		Label5.Margin = New Padding(4, 0, 4, 0)
		Label5.Name = "Label5"
		Label5.Size = New Size(112, 16)
		Label5.TabIndex = 5
		Label5.Text = "Base de datos:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.ForeColor = Color.White
		Label4.Location = New Point(103, 217)
		Label4.Margin = New Padding(4, 0, 4, 0)
		Label4.Name = "Label4"
		Label4.Size = New Size(99, 16)
		Label4.TabIndex = 4
		Label4.Text = "Observación:"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = Color.White
		Label3.Location = New Point(103, 172)
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
		Label1.Location = New Point(103, 58)
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
		Label2.Location = New Point(103, 117)
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
		' C
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.Gray
		ClientSize = New Size(1098, 762)
		Controls.Add(Box_realizar_backup)
		FormBorderStyle = FormBorderStyle.None
		Margin = New Padding(4, 3, 4, 3)
		Name = "C"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents cbBaseDeDatos As ComboBox
    Friend WithEvents cbServidorLocal As ComboBox
    Friend WithEvents txtNombreBackup As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents txtDirectorio As TextBox
    Private WithEvents btnCrearBackup As Button
    Private WithEvents Box_realizar_backup As GroupBox
End Class
