<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        LogoPictureBox = New PictureBox()
        Label1 = New Label()
        PasswordLabel = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnLogin = New Button()
        Cancel = New Button()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LogoPictureBox.BackColor = SystemColors.ActiveCaption
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(12, 41)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(236, 212)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(333, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 23)
        Label1.TabIndex = 1
        Label1.Text = "&Nombre de Usuario"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = SystemColors.ActiveCaption
        PasswordLabel.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordLabel.ForeColor = SystemColors.ButtonHighlight
        PasswordLabel.Location = New Point(332, 129)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(108, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(332, 81)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(287, 26)
        txtUsuario.TabIndex = 3
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContraseña.Location = New Point(332, 164)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(287, 26)
        txtContraseña.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ActiveCaptionText
        btnLogin.Location = New Point(334, 213)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(106, 40)
        btnLogin.TabIndex = 5
        btnLogin.Text = "&Aceptar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Cancel.ForeColor = SystemColors.ActiveCaptionText
        Cancel.Location = New Point(471, 213)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(114, 40)
        Cancel.TabIndex = 6
        Cancel.Text = "&Cancelar"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(6F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(686, 311)
        Controls.Add(Cancel)
        Controls.Add(btnLogin)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(PasswordLabel)
        Controls.Add(Label1)
        Controls.Add(LogoPictureBox)
        Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ButtonShadow
        Location = New Point(21, 24)
        Name = "Login"
        Text = "Login"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PasswordLabel As Label
	Friend WithEvents txtUsuario As TextBox
	Friend WithEvents txtContraseña As TextBox
	Friend WithEvents btnLogin As Button
	Friend WithEvents Cancel As Button

End Class
