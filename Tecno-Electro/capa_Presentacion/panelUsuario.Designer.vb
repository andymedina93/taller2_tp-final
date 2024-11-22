<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelUsuario
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelUsuario))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel2 = New Panel()
        GroupBox3 = New GroupBox()
        n_usuarioid = New TextBox()
        BCancelar = New Button()
        BGuardar = New Button()
        BAgregar = New Button()
        TUsuario = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        TPerfil = New ComboBox()
        TContraseña = New TextBox()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        Label12 = New Label()
        CriterioBusqueda = New ComboBox()
        Label1 = New Label()
        BInactivos = New Button()
        BActivos = New Button()
        TxtBuscar = New TextBox()
        Label3 = New Label()
        DgUsuarios = New DataGridView()
        GroupBox1 = New GroupBox()
        n_personaid = New TextBox()
        Label11 = New Label()
        Label2 = New Label()
        TCelular = New TextBox()
        Label4 = New Label()
        TDireccion = New TextBox()
        Label5 = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TNombre = New TextBox()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        DataGridViewImageColumn2 = New DataGridViewImageColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CActivar = New DataGridViewImageColumn()
        CEliminar = New DataGridViewImageColumn()
        CModificar = New DataGridViewImageColumn()
        id_usuario = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        contraseña = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        Dni = New DataGridViewTextBoxColumn()
        celular = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        fecha_registro = New DataGridViewTextBoxColumn()
        Usuario = New DataGridViewTextBoxColumn()
        perfil = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DgUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(GroupBox3)
        Panel2.Controls.Add(GroupBox2)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.ForeColor = Color.DarkSlateGray
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1137, 728)
        Panel2.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox3.Controls.Add(n_usuarioid)
        GroupBox3.Controls.Add(BCancelar)
        GroupBox3.Controls.Add(BGuardar)
        GroupBox3.Controls.Add(BAgregar)
        GroupBox3.Controls.Add(TUsuario)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(TPerfil)
        GroupBox3.Controls.Add(TContraseña)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.Honeydew
        GroupBox3.Location = New Point(730, 22)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(379, 223)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "Iniciar Sesion"
        ' 
        ' n_usuarioid
        ' 
        n_usuarioid.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n_usuarioid.Location = New Point(341, 111)
        n_usuarioid.Margin = New Padding(2)
        n_usuarioid.Name = "n_usuarioid"
        n_usuarioid.Size = New Size(20, 27)
        n_usuarioid.TabIndex = 30
        n_usuarioid.Visible = False
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = Color.DarkRed
        BCancelar.FlatStyle = FlatStyle.Flat
        BCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancelar.Location = New Point(229, 165)
        BCancelar.Margin = New Padding(4, 3, 4, 3)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(123, 40)
        BCancelar.TabIndex = 28
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.DarkGreen
        BGuardar.FlatStyle = FlatStyle.Flat
        BGuardar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BGuardar.ForeColor = SystemColors.HighlightText
        BGuardar.Location = New Point(73, 165)
        BGuardar.Margin = New Padding(4, 3, 4, 3)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(128, 40)
        BGuardar.TabIndex = 29
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = SystemColors.HotTrack
        BAgregar.FlatStyle = FlatStyle.Flat
        BAgregar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.Location = New Point(73, 165)
        BAgregar.Margin = New Padding(4, 3, 4, 3)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(128, 40)
        BAgregar.TabIndex = 27
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' TUsuario
        ' 
        TUsuario.Font = New Font("Calibri", 12F)
        TUsuario.Location = New Point(122, 22)
        TUsuario.Margin = New Padding(4, 3, 4, 3)
        TUsuario.Name = "TUsuario"
        TUsuario.Size = New Size(230, 27)
        TUsuario.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Transparent
        Label10.Location = New Point(17, 29)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 20)
        Label10.TabIndex = 21
        Label10.Text = "Usuario"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(17, 67)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 22
        Label9.Text = "Contraseña"
        ' 
        ' TPerfil
        ' 
        TPerfil.DropDownStyle = ComboBoxStyle.DropDownList
        TPerfil.Font = New Font("Calibri", 12F)
        TPerfil.FormattingEnabled = True
        TPerfil.Items.AddRange(New Object() {"Admin", "Cajero", "Gerente"})
        TPerfil.Location = New Point(122, 113)
        TPerfil.Margin = New Padding(4, 3, 4, 3)
        TPerfil.Name = "TPerfil"
        TPerfil.Size = New Size(140, 27)
        TPerfil.TabIndex = 25
        ' 
        ' TContraseña
        ' 
        TContraseña.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TContraseña.Location = New Point(122, 67)
        TContraseña.Margin = New Padding(4, 3, 4, 3)
        TContraseña.Name = "TContraseña"
        TContraseña.PasswordChar = "."c
        TContraseña.Size = New Size(230, 31)
        TContraseña.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(26, 113)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 20)
        Label8.TabIndex = 23
        Label8.Text = "Perfil"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(CriterioBusqueda)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(BInactivos)
        GroupBox2.Controls.Add(BActivos)
        GroupBox2.Controls.Add(TxtBuscar)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(DgUsuarios)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(38, 263)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(1071, 357)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Usuarios"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(374, 31)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(109, 16)
        Label12.TabIndex = 47
        Label12.Text = "Ingresar Datos"
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre"})
        CriterioBusqueda.Location = New Point(142, 45)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(121, 26)
        CriterioBusqueda.TabIndex = 46
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 320)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 18)
        Label1.TabIndex = 8
        Label1.Text = "Total de Uusuarios:"
        ' 
        ' BInactivos
        ' 
        BInactivos.BackColor = Color.DarkRed
        BInactivos.FlatStyle = FlatStyle.Flat
        BInactivos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BInactivos.Location = New Point(889, 39)
        BInactivos.Margin = New Padding(4, 3, 4, 3)
        BInactivos.Name = "BInactivos"
        BInactivos.Size = New Size(132, 37)
        BInactivos.TabIndex = 7
        BInactivos.Text = "Inactivos"
        BInactivos.UseVisualStyleBackColor = False
        ' 
        ' BActivos
        ' 
        BActivos.BackColor = Color.DarkGreen
        BActivos.FlatStyle = FlatStyle.Flat
        BActivos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BActivos.Location = New Point(889, 39)
        BActivos.Margin = New Padding(4, 3, 4, 3)
        BActivos.Name = "BActivos"
        BActivos.Size = New Size(132, 36)
        BActivos.TabIndex = 6
        BActivos.Text = "Activos"
        BActivos.UseVisualStyleBackColor = False
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.BackColor = SystemColors.Window
        TxtBuscar.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBuscar.ForeColor = Color.Black
        TxtBuscar.Location = New Point(374, 50)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(242, 22)
        TxtBuscar.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 50)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 16)
        Label3.TabIndex = 5
        Label3.Text = "BUSCAR POR"
        ' 
        ' DgUsuarios
        ' 
        DgUsuarios.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.LightBlue
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DgUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgUsuarios.BackgroundColor = Color.LightSteelBlue
        DgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.Control
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgUsuarios.Columns.AddRange(New DataGridViewColumn() {CActivar, CEliminar, CModificar, id_usuario, Id, contraseña, Nombre, Apellido, Dni, celular, Direccion, fecha_registro, Usuario, perfil})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DgUsuarios.DefaultCellStyle = DataGridViewCellStyle6
        DgUsuarios.EnableHeadersVisualStyles = False
        DgUsuarios.Location = New Point(30, 91)
        DgUsuarios.Margin = New Padding(4, 3, 4, 3)
        DgUsuarios.MultiSelect = False
        DgUsuarios.Name = "DgUsuarios"
        DgUsuarios.ReadOnly = True
        DgUsuarios.RowHeadersVisible = False
        DgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgUsuarios.Size = New Size(1022, 206)
        DgUsuarios.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox1.Controls.Add(n_personaid)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TCelular)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TDireccion)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TDni)
        GroupBox1.Controls.Add(TApellido)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TNombre)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(38, 22)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(675, 223)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Altas de Usuario"
        ' 
        ' n_personaid
        ' 
        n_personaid.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n_personaid.Location = New Point(344, 18)
        n_personaid.Margin = New Padding(2)
        n_personaid.Name = "n_personaid"
        n_personaid.Size = New Size(20, 27)
        n_personaid.TabIndex = 31
        n_personaid.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(30, 143)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 23)
        Label11.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 47)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 23)
        Label2.TabIndex = 11
        Label2.Text = "Nombre"
        ' 
        ' TCelular
        ' 
        TCelular.Font = New Font("Calibri", 12F)
        TCelular.Location = New Point(452, 106)
        TCelular.Margin = New Padding(2)
        TCelular.Name = "TCelular"
        TCelular.Size = New Size(185, 27)
        TCelular.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Honeydew
        Label4.Location = New Point(30, 102)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 23)
        Label4.TabIndex = 12
        Label4.Text = "Apellido"
        ' 
        ' TDireccion
        ' 
        TDireccion.Font = New Font("Calibri", 12F)
        TDireccion.Location = New Point(452, 43)
        TDireccion.Margin = New Padding(2)
        TDireccion.Name = "TDireccion"
        TDireccion.Size = New Size(185, 27)
        TDireccion.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Honeydew
        Label5.Location = New Point(30, 163)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 23)
        Label5.TabIndex = 14
        Label5.Text = "DNI"
        ' 
        ' TDni
        ' 
        TDni.Font = New Font("Calibri", 12F)
        TDni.Location = New Point(117, 159)
        TDni.Margin = New Padding(2)
        TDni.Name = "TDni"
        TDni.Size = New Size(186, 27)
        TDni.TabIndex = 17
        ' 
        ' TApellido
        ' 
        TApellido.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TApellido.Location = New Point(117, 102)
        TApellido.Margin = New Padding(2)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(186, 27)
        TApellido.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Honeydew
        Label6.Location = New Point(344, 47)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 23)
        Label6.TabIndex = 13
        Label6.Text = "Direccion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Honeydew
        Label7.Location = New Point(344, 110)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 23)
        Label7.TabIndex = 15
        Label7.Text = "Celular"
        ' 
        ' TNombre
        ' 
        TNombre.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TNombre.Location = New Point(117, 43)
        TNombre.Margin = New Padding(2)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(186, 27)
        TNombre.TabIndex = 16
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle7.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.NullValue = resources.GetObject("DataGridViewCellStyle7.NullValue")
        DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle7
        DataGridViewImageColumn1.HeaderText = "Modificar"
        DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), Image)
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.True
        DataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' DataGridViewImageColumn2
        ' 
        DataGridViewImageColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.Red
        DataGridViewCellStyle8.NullValue = resources.GetObject("DataGridViewCellStyle8.NullValue")
        DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle8
        DataGridViewImageColumn2.HeaderText = "Eliminar"
        DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), Image)
        DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        DataGridViewImageColumn2.Resizable = DataGridViewTriState.True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' CActivar
        ' 
        CActivar.HeaderText = "Activar"
        CActivar.Image = CType(resources.GetObject("CActivar.Image"), Image)
        CActivar.Name = "CActivar"
        CActivar.ReadOnly = True
        ' 
        ' CEliminar
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Red
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.NullValue = resources.GetObject("DataGridViewCellStyle3.NullValue")
        DataGridViewCellStyle3.SelectionBackColor = Color.Red
        CEliminar.DefaultCellStyle = DataGridViewCellStyle3
        CEliminar.HeaderText = "Eliminar"
        CEliminar.Image = CType(resources.GetObject("CEliminar.Image"), Image)
        CEliminar.Name = "CEliminar"
        CEliminar.ReadOnly = True
        CEliminar.Resizable = DataGridViewTriState.True
        CEliminar.Width = 73
        ' 
        ' CModificar
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle4.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.NullValue = resources.GetObject("DataGridViewCellStyle4.NullValue")
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        CModificar.DefaultCellStyle = DataGridViewCellStyle4
        CModificar.HeaderText = "Modificar"
        CModificar.Image = CType(resources.GetObject("CModificar.Image"), Image)
        CModificar.Name = "CModificar"
        CModificar.ReadOnly = True
        CModificar.Resizable = DataGridViewTriState.False
        CModificar.Width = 82
        ' 
        ' id_usuario
        ' 
        id_usuario.DataPropertyName = "id_usuario"
        id_usuario.HeaderText = "id_usuario"
        id_usuario.Name = "id_usuario"
        id_usuario.ReadOnly = True
        id_usuario.Visible = False
        ' 
        ' Id
        ' 
        Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Id.DataPropertyName = "id_persona"
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        DataGridViewCellStyle5.ForeColor = Color.Black
        Id.DefaultCellStyle = DataGridViewCellStyle5
        Id.FillWeight = 191.7808F
        Id.HeaderText = "ID"
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Resizable = DataGridViewTriState.False
        Id.SortMode = DataGridViewColumnSortMode.NotSortable
        Id.Visible = False
        Id.Width = 40
        ' 
        ' contraseña
        ' 
        contraseña.DataPropertyName = "contraseña"
        contraseña.HeaderText = "contrasena"
        contraseña.Name = "contraseña"
        contraseña.ReadOnly = True
        contraseña.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        ' 
        ' Apellido
        ' 
        Apellido.DataPropertyName = "apellido"
        Apellido.HeaderText = "apellido"
        Apellido.Name = "Apellido"
        Apellido.ReadOnly = True
        ' 
        ' Dni
        ' 
        Dni.DataPropertyName = "n_documento"
        Dni.HeaderText = "Dni"
        Dni.Name = "Dni"
        Dni.ReadOnly = True
        ' 
        ' celular
        ' 
        celular.DataPropertyName = "celular"
        celular.HeaderText = "Celular"
        celular.Name = "celular"
        celular.ReadOnly = True
        ' 
        ' Direccion
        ' 
        Direccion.DataPropertyName = "direccion"
        Direccion.HeaderText = "Direccion"
        Direccion.Name = "Direccion"
        Direccion.ReadOnly = True
        ' 
        ' fecha_registro
        ' 
        fecha_registro.DataPropertyName = "fecha_resgistro"
        fecha_registro.HeaderText = "Fecha_Alta"
        fecha_registro.Name = "fecha_registro"
        fecha_registro.ReadOnly = True
        ' 
        ' Usuario
        ' 
        Usuario.DataPropertyName = "usuario"
        Usuario.HeaderText = "Usuario"
        Usuario.Name = "Usuario"
        Usuario.ReadOnly = True
        ' 
        ' perfil
        ' 
        perfil.DataPropertyName = "perfil"
        perfil.HeaderText = "Perfil"
        perfil.Name = "perfil"
        perfil.ReadOnly = True
        ' 
        ' panelUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(1137, 728)
        ControlBox = False
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "panelUsuario"
        Text = "panelUsuario"
        Panel2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DgUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgUsuarios As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TCelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents TPerfil As ComboBox
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents BInactivos As Button
    Friend WithEvents BActivos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents n_usuarioid As TextBox
    Friend WithEvents n_personaid As TextBox
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CActivar As DataGridViewImageColumn
    Friend WithEvents CEliminar As DataGridViewImageColumn
    Friend WithEvents CModificar As DataGridViewImageColumn
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Dni As DataGridViewTextBoxColumn
    Friend WithEvents celular As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents fecha_registro As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents perfil As DataGridViewTextBoxColumn
End Class
