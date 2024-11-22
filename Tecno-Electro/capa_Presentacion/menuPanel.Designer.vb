<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPanel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PictureBox1 As PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPanel))
        Panel1 = New Panel()
        BBackup = New Button()
        BProveedores = New Button()
        BVentas = New Button()
        BProductos = New Button()
        BClientes = New Button()
        BUsuarios = New Button()
        BReportes = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        titulo = New Label()
        Button1 = New Button()
        BSalir = New Button()
        Bienvenido = New Label()
        LUsuario = New Label()
        panelcontenedor = New Panel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.ImageLocation = "center"
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(12, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(20), CByte(32), CByte(46))
        Panel1.Controls.Add(BBackup)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(BProveedores)
        Panel1.Controls.Add(BVentas)
        Panel1.Controls.Add(BProductos)
        Panel1.Controls.Add(BClientes)
        Panel1.Controls.Add(BUsuarios)
        Panel1.Controls.Add(BReportes)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 749)
        Panel1.TabIndex = 3
        ' 
        ' BBackup
        ' 
        BBackup.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BBackup.BackgroundImage = CType(resources.GetObject("BBackup.BackgroundImage"), Image)
        BBackup.BackgroundImageLayout = ImageLayout.None
        BBackup.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BBackup.Location = New Point(12, 619)
        BBackup.Margin = New Padding(4, 3, 4, 3)
        BBackup.Name = "BBackup"
        BBackup.Padding = New Padding(70, 0, 0, 0)
        BBackup.Size = New Size(198, 61)
        BBackup.TabIndex = 13
        BBackup.Text = "Backup"
        BBackup.TextImageRelation = TextImageRelation.ImageBeforeText
        BBackup.UseVisualStyleBackColor = False
        ' 
        ' BProveedores
        ' 
        BProveedores.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BProveedores.BackgroundImage = CType(resources.GetObject("BProveedores.BackgroundImage"), Image)
        BProveedores.BackgroundImageLayout = ImageLayout.None
        BProveedores.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BProveedores.Location = New Point(14, 438)
        BProveedores.Margin = New Padding(4, 3, 4, 3)
        BProveedores.Name = "BProveedores"
        BProveedores.Padding = New Padding(70, 0, 0, 0)
        BProveedores.Size = New Size(198, 70)
        BProveedores.TabIndex = 12
        BProveedores.Text = "Proveedores"
        BProveedores.TextImageRelation = TextImageRelation.ImageBeforeText
        BProveedores.UseVisualStyleBackColor = False
        ' 
        ' BVentas
        ' 
        BVentas.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BVentas.BackgroundImage = CType(resources.GetObject("BVentas.BackgroundImage"), Image)
        BVentas.BackgroundImageLayout = ImageLayout.None
        BVentas.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BVentas.Location = New Point(13, 84)
        BVentas.Margin = New Padding(4, 3, 4, 3)
        BVentas.Name = "BVentas"
        BVentas.Padding = New Padding(70, 0, 0, 0)
        BVentas.Size = New Size(198, 67)
        BVentas.TabIndex = 7
        BVentas.Text = "Ventas"
        BVentas.UseVisualStyleBackColor = False
        ' 
        ' BProductos
        ' 
        BProductos.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BProductos.BackgroundImage = CType(resources.GetObject("BProductos.BackgroundImage"), Image)
        BProductos.BackgroundImageLayout = ImageLayout.None
        BProductos.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BProductos.Location = New Point(14, 168)
        BProductos.Margin = New Padding(4, 3, 4, 3)
        BProductos.Name = "BProductos"
        BProductos.Padding = New Padding(70, 0, 0, 0)
        BProductos.Size = New Size(198, 71)
        BProductos.TabIndex = 8
        BProductos.Text = "Productos"
        BProductos.TextImageRelation = TextImageRelation.ImageBeforeText
        BProductos.UseVisualStyleBackColor = False
        ' 
        ' BClientes
        ' 
        BClientes.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BClientes.BackgroundImage = CType(resources.GetObject("BClientes.BackgroundImage"), Image)
        BClientes.BackgroundImageLayout = ImageLayout.None
        BClientes.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BClientes.Location = New Point(14, 255)
        BClientes.Margin = New Padding(4, 3, 4, 3)
        BClientes.Name = "BClientes"
        BClientes.Padding = New Padding(70, 0, 0, 0)
        BClientes.Size = New Size(198, 69)
        BClientes.TabIndex = 9
        BClientes.Text = "Clientes"
        BClientes.TextImageRelation = TextImageRelation.ImageBeforeText
        BClientes.UseVisualStyleBackColor = False
        ' 
        ' BUsuarios
        ' 
        BUsuarios.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BUsuarios.BackgroundImage = CType(resources.GetObject("BUsuarios.BackgroundImage"), Image)
        BUsuarios.BackgroundImageLayout = ImageLayout.None
        BUsuarios.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BUsuarios.Location = New Point(13, 341)
        BUsuarios.Margin = New Padding(4, 3, 4, 3)
        BUsuarios.Name = "BUsuarios"
        BUsuarios.Padding = New Padding(70, 0, 0, 0)
        BUsuarios.Size = New Size(198, 75)
        BUsuarios.TabIndex = 10
        BUsuarios.Text = "Usuarios"
        BUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText
        BUsuarios.UseVisualStyleBackColor = False
        ' 
        ' BReportes
        ' 
        BReportes.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BReportes.BackgroundImage = CType(resources.GetObject("BReportes.BackgroundImage"), Image)
        BReportes.BackgroundImageLayout = ImageLayout.None
        BReportes.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BReportes.Location = New Point(14, 529)
        BReportes.Margin = New Padding(4, 3, 4, 3)
        BReportes.Name = "BReportes"
        BReportes.Padding = New Padding(70, 0, 0, 0)
        BReportes.Size = New Size(198, 69)
        BReportes.TabIndex = 11
        BReportes.Text = "Reporte"
        BReportes.TextImageRelation = TextImageRelation.ImageBeforeText
        BReportes.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(20), CByte(32), CByte(46))
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(titulo)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(BSalir)
        Panel2.Controls.Add(Bienvenido)
        Panel2.Controls.Add(LUsuario)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(233, 0)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1137, 89)
        Panel2.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(911, 10)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 58)
        Button2.TabIndex = 10
        Button2.Text = "v"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' titulo
        ' 
        titulo.AutoSize = True
        titulo.BackColor = Color.FromArgb(CByte(20), CByte(32), CByte(46))
        titulo.Font = New Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titulo.ForeColor = Color.Transparent
        titulo.Location = New Point(438, 19)
        titulo.Margin = New Padding(4, 0, 4, 0)
        titulo.Name = "titulo"
        titulo.Size = New Size(126, 41)
        titulo.TabIndex = 9
        titulo.Text = "Titulo"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(997, 10)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(35, 0, 0, 0)
        Button1.Size = New Size(113, 58)
        Button1.TabIndex = 8
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BSalir
        ' 
        BSalir.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        BSalir.BackgroundImage = CType(resources.GetObject("BSalir.BackgroundImage"), Image)
        BSalir.BackgroundImageLayout = ImageLayout.None
        BSalir.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BSalir.Location = New Point(1194, 14)
        BSalir.Margin = New Padding(4, 3, 4, 3)
        BSalir.Name = "BSalir"
        BSalir.Padding = New Padding(35, 0, 0, 0)
        BSalir.Size = New Size(113, 63)
        BSalir.TabIndex = 0
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = False
        ' 
        ' Bienvenido
        ' 
        Bienvenido.AutoSize = True
        Bienvenido.BackColor = Color.FromArgb(CByte(20), CByte(32), CByte(46))
        Bienvenido.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Bienvenido.ForeColor = Color.Transparent
        Bienvenido.Location = New Point(7, 30)
        Bienvenido.Margin = New Padding(4, 0, 4, 0)
        Bienvenido.Name = "Bienvenido"
        Bienvenido.Size = New Size(149, 25)
        Bienvenido.TabIndex = 7
        Bienvenido.Text = "Bienvenido/a :"
        ' 
        ' LUsuario
        ' 
        LUsuario.AutoSize = True
        LUsuario.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LUsuario.ForeColor = Color.Transparent
        LUsuario.Location = New Point(188, 31)
        LUsuario.Margin = New Padding(4, 0, 4, 0)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New Size(72, 24)
        LUsuario.TabIndex = 6
        LUsuario.Text = "usuario"
        ' 
        ' panelcontenedor
        ' 
        panelcontenedor.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        panelcontenedor.Location = New Point(233, 84)
        panelcontenedor.Margin = New Padding(4, 3, 4, 3)
        panelcontenedor.Name = "panelcontenedor"
        panelcontenedor.Size = New Size(1137, 629)
        panelcontenedor.TabIndex = 7
        ' 
        ' menuPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1370, 749)
        ControlBox = False
        Controls.Add(panelcontenedor)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        IsMdiContainer = True
        Margin = New Padding(4, 3, 4, 3)
        Name = "menuPanel"
        RightToLeftLayout = True
        Text = "Tecno Electro"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BVentas As Button
    Friend WithEvents BProductos As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents BReportes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BSalir As Button
    Friend WithEvents Bienvenido As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents BProveedores As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BBackup As Button
    Friend WithEvents panelcontenedor As Panel
    Friend WithEvents titulo As Label
    Friend WithEvents Button2 As Button
End Class
