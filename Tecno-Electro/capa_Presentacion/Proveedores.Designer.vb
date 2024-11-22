<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelProveedores
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelProveedores))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TRazonSocial = New TextBox()
        TNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        DgProveedores = New DataGridView()
        BGuardar = New Button()
        BCancelar = New Button()
        GroupBox1 = New GroupBox()
        id = New TextBox()
        Tcelular = New TextBox()
        TDireccion = New TextBox()
        Label4 = New Label()
        TDNI = New TextBox()
        Label8 = New Label()
        TApellido = New TextBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        BInactivo = New Button()
        BActivo = New Button()
        Label12 = New Label()
        CriterioBusqueda = New ComboBox()
        TxtBuscar = New TextBox()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        BAgregar = New Button()
        CEliminar = New DataGridViewImageColumn()
        CActivar = New DataGridViewImageColumn()
        CModificar = New DataGridViewImageColumn()
        CNombre = New DataGridViewTextBoxColumn()
        CApellido = New DataGridViewTextBoxColumn()
        CidPersona = New DataGridViewTextBoxColumn()
        cdni = New DataGridViewTextBoxColumn()
        CRazonsocial = New DataGridViewTextBoxColumn()
        CCelular = New DataGridViewTextBoxColumn()
        CDireccion = New DataGridViewTextBoxColumn()
        CType(DgProveedores, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TRazonSocial
        ' 
        TRazonSocial.Font = New Font("Segoe UI", 12F)
        TRazonSocial.Location = New Point(462, 73)
        TRazonSocial.Margin = New Padding(4, 3, 4, 3)
        TRazonSocial.Name = "TRazonSocial"
        TRazonSocial.Size = New Size(166, 29)
        TRazonSocial.TabIndex = 27
        ' 
        ' TNombre
        ' 
        TNombre.Font = New Font("Segoe UI", 12F)
        TNombre.Location = New Point(39, 73)
        TNombre.Margin = New Padding(4, 3, 4, 3)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(166, 29)
        TNombre.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(39, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 21)
        Label1.TabIndex = 6
        Label1.Text = "Nombre "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(462, 49)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 21)
        Label2.TabIndex = 7
        Label2.Text = "Razon Social"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(39, 126)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 21)
        Label5.TabIndex = 33
        Label5.Text = "Telefono"
        ' 
        ' DgProveedores
        ' 
        DgProveedores.AllowUserToAddRows = False
        DgProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgProveedores.BackgroundColor = SystemColors.ControlDarkDark
        DgProveedores.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkSlateBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgProveedores.Columns.AddRange(New DataGridViewColumn() {CEliminar, CActivar, CModificar, CNombre, CApellido, CidPersona, cdni, CRazonsocial, CCelular, CDireccion})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DgProveedores.DefaultCellStyle = DataGridViewCellStyle4
        DgProveedores.Dock = DockStyle.Bottom
        DgProveedores.EnableHeadersVisualStyles = False
        DgProveedores.GridColor = SystemColors.ControlText
        DgProveedores.Location = New Point(3, 126)
        DgProveedores.Name = "DgProveedores"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgProveedores.RowHeadersVisible = False
        DgProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Silver
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DgProveedores.RowsDefaultCellStyle = DataGridViewCellStyle6
        DgProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgProveedores.Size = New Size(997, 234)
        DgProveedores.TabIndex = 34
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.DarkGreen
        BGuardar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BGuardar.ForeColor = SystemColors.ControlLightLight
        BGuardar.Location = New Point(31, 40)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(131, 50)
        BGuardar.TabIndex = 0
        BGuardar.Text = "GUARDAR"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = SystemColors.HotTrack
        BCancelar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancelar.ForeColor = Color.White
        BCancelar.Location = New Point(31, 115)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(129, 48)
        BCancelar.TabIndex = 2
        BCancelar.Text = "CANCELAR"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox1.Controls.Add(id)
        GroupBox1.Controls.Add(Tcelular)
        GroupBox1.Controls.Add(TDireccion)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TDNI)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TApellido)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TNombre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TRazonSocial)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(63, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(784, 202)
        GroupBox1.TabIndex = 36
        GroupBox1.TabStop = False
        GroupBox1.Text = "Proveedores"
        ' 
        ' id
        ' 
        id.Location = New Point(200, 22)
        id.Name = "id"
        id.Size = New Size(21, 29)
        id.TabIndex = 44
        id.Visible = False
        ' 
        ' Tcelular
        ' 
        Tcelular.Location = New Point(39, 150)
        Tcelular.Name = "Tcelular"
        Tcelular.Size = New Size(166, 29)
        Tcelular.TabIndex = 43
        ' 
        ' TDireccion
        ' 
        TDireccion.Location = New Point(244, 150)
        TDireccion.Name = "TDireccion"
        TDireccion.Size = New Size(159, 29)
        TDireccion.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(487, 115)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 21)
        Label4.TabIndex = 41
        Label4.Text = "DNI"
        ' 
        ' TDNI
        ' 
        TDNI.Font = New Font("Segoe UI", 12F)
        TDNI.Location = New Point(462, 150)
        TDNI.Margin = New Padding(4, 3, 4, 3)
        TDNI.Name = "TDNI"
        TDNI.Size = New Size(153, 29)
        TDNI.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(237, 49)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 39
        Label8.Text = "Apellido"
        ' 
        ' TApellido
        ' 
        TApellido.Font = New Font("Segoe UI", 12F)
        TApellido.Location = New Point(237, 73)
        TApellido.Margin = New Padding(4, 3, 4, 3)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(166, 29)
        TApellido.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(244, 126)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 21)
        Label7.TabIndex = 37
        Label7.Text = "Direccion"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox2.Controls.Add(BInactivo)
        GroupBox2.Controls.Add(BActivo)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(CriterioBusqueda)
        GroupBox2.Controls.Add(TxtBuscar)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(DgProveedores)
        GroupBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(63, 254)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1003, 363)
        GroupBox2.TabIndex = 37
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Proveedores"
        ' 
        ' BInactivo
        ' 
        BInactivo.BackColor = Color.DarkRed
        BInactivo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BInactivo.ForeColor = Color.White
        BInactivo.Location = New Point(840, 43)
        BInactivo.Name = "BInactivo"
        BInactivo.Size = New Size(121, 40)
        BInactivo.TabIndex = 53
        BInactivo.Text = "Inactivos"
        BInactivo.UseVisualStyleBackColor = False
        ' 
        ' BActivo
        ' 
        BActivo.BackColor = Color.DarkGreen
        BActivo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BActivo.ForeColor = Color.White
        BActivo.Location = New Point(840, 43)
        BActivo.Name = "BActivo"
        BActivo.Size = New Size(121, 40)
        BActivo.TabIndex = 52
        BActivo.Text = "Activos"
        BActivo.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(369, 38)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(109, 16)
        Label12.TabIndex = 51
        Label12.Text = "Ingresar Datos"
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre"})
        CriterioBusqueda.Location = New Point(151, 51)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(121, 28)
        CriterioBusqueda.TabIndex = 50
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.BackColor = SystemColors.Window
        TxtBuscar.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBuscar.ForeColor = Color.Black
        TxtBuscar.Location = New Point(373, 57)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(242, 22)
        TxtBuscar.TabIndex = 48
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(39, 57)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 16)
        Label6.TabIndex = 49
        Label6.Text = "BUSCAR POR"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox3.Controls.Add(BAgregar)
        GroupBox3.Controls.Add(BGuardar)
        GroupBox3.Controls.Add(BCancelar)
        GroupBox3.Location = New Point(872, 26)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(194, 202)
        GroupBox3.TabIndex = 38
        GroupBox3.TabStop = False
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = Color.DarkGreen
        BAgregar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.ForeColor = SystemColors.ControlLightLight
        BAgregar.Location = New Point(31, 40)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(131, 50)
        BAgregar.TabIndex = 3
        BAgregar.Text = "AGREGAR"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' CEliminar
        ' 
        CEliminar.HeaderText = "Eliminar"
        CEliminar.Image = CType(resources.GetObject("CEliminar.Image"), Image)
        CEliminar.Name = "CEliminar"
        ' 
        ' CActivar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.RosyBrown
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.NullValue = resources.GetObject("DataGridViewCellStyle2.NullValue")
        CActivar.DefaultCellStyle = DataGridViewCellStyle2
        CActivar.HeaderText = "Activar"
        CActivar.Image = CType(resources.GetObject("CActivar.Image"), Image)
        CActivar.Name = "CActivar"
        CActivar.Resizable = DataGridViewTriState.True
        CActivar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' CModificar
        ' 
        CModificar.HeaderText = "Modificar"
        CModificar.Image = CType(resources.GetObject("CModificar.Image"), Image)
        CModificar.Name = "CModificar"
        ' 
        ' CNombre
        ' 
        CNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle3.BackColor = Color.RosyBrown
        DataGridViewCellStyle3.ForeColor = Color.Black
        CNombre.DefaultCellStyle = DataGridViewCellStyle3
        CNombre.HeaderText = "Nombre"
        CNombre.Name = "CNombre"
        ' 
        ' CApellido
        ' 
        CApellido.DataPropertyName = "Apellido"
        CApellido.HeaderText = "Apellido"
        CApellido.Name = "CApellido"
        ' 
        ' CidPersona
        ' 
        CidPersona.DataPropertyName = "id_persona"
        CidPersona.HeaderText = "ID"
        CidPersona.Name = "CidPersona"
        CidPersona.Visible = False
        ' 
        ' cdni
        ' 
        cdni.DataPropertyName = "N_documento"
        cdni.HeaderText = "N_Documento"
        cdni.Name = "cdni"
        ' 
        ' CRazonsocial
        ' 
        CRazonsocial.DataPropertyName = "Razon_Social"
        CRazonsocial.HeaderText = "Razon Social"
        CRazonsocial.Name = "CRazonsocial"
        ' 
        ' CCelular
        ' 
        CCelular.DataPropertyName = "celular"
        CCelular.HeaderText = "Celular"
        CCelular.Name = "CCelular"
        ' 
        ' CDireccion
        ' 
        CDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        CDireccion.DataPropertyName = "direccion"
        CDireccion.HeaderText = "Direccion"
        CDireccion.Name = "CDireccion"
        CDireccion.Width = 99
        ' 
        ' panelProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(1130, 643)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "panelProveedores"
        Text = "Proveedores "
        CType(DgProveedores, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TRazonSocial As TextBox
	Friend WithEvents TNombre As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents DgProveedores As DataGridView
	Friend WithEvents BGuardar As Button
	Friend WithEvents BCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents BInactivo As Button
    Friend WithEvents BActivo As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TDNI As TextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents Tcelular As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents CEliminar As DataGridViewImageColumn
    Friend WithEvents CActivar As DataGridViewImageColumn
    Friend WithEvents CModificar As DataGridViewImageColumn
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CApellido As DataGridViewTextBoxColumn
    Friend WithEvents CidPersona As DataGridViewTextBoxColumn
    Friend WithEvents cdni As DataGridViewTextBoxColumn
    Friend WithEvents CRazonsocial As DataGridViewTextBoxColumn
    Friend WithEvents CCelular As DataGridViewTextBoxColumn
    Friend WithEvents CDireccion As DataGridViewTextBoxColumn

End Class
