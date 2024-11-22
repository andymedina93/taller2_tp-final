<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panel_clliente
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panel_clliente))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgCliente = New DataGridView()
        CActivar = New DataGridViewImageColumn()
        CEliminar = New DataGridViewImageColumn()
        CModificar = New DataGridViewImageColumn()
        CId_cliente = New DataGridViewTextBoxColumn()
        CNombre = New DataGridViewTextBoxColumn()
        CApellido = New DataGridViewTextBoxColumn()
        CDni = New DataGridViewTextBoxColumn()
        CTelefono = New DataGridViewTextBoxColumn()
        CFechaAlta = New DataGridViewTextBoxColumn()
        CDireccion = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        TxtBuscar = New TextBox()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        CriterioBusqueda = New ComboBox()
        BInactivos = New Button()
        BActivos = New Button()
        Label7 = New Label()
        Label2 = New Label()
        LNombre = New Label()
        TApellido = New TextBox()
        Label1 = New Label()
        TNombre = New TextBox()
        TDni = New TextBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        id = New TextBox()
        TDireccion = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        BGuardar = New Button()
        BCancelar = New Button()
        BAgregar = New Button()
        TCelular = New TextBox()
        CType(DgCliente, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgCliente
        ' 
        DgCliente.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DgCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgCliente.BackgroundColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        DgCliente.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Gray
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgCliente.Columns.AddRange(New DataGridViewColumn() {CActivar, CEliminar, CModificar, CId_cliente, CNombre, CApellido, CDni, CTelefono, CFechaAlta, CDireccion})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle11.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = Color.LightBlue
        DataGridViewCellStyle11.SelectionForeColor = Color.Black
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DgCliente.DefaultCellStyle = DataGridViewCellStyle11
        DgCliente.EnableHeadersVisualStyles = False
        DgCliente.GridColor = SystemColors.ActiveCaption
        DgCliente.Location = New Point(27, 114)
        DgCliente.Margin = New Padding(4, 3, 4, 3)
        DgCliente.MultiSelect = False
        DgCliente.Name = "DgCliente"
        DgCliente.ReadOnly = True
        DgCliente.RowHeadersVisible = False
        DgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgCliente.Size = New Size(758, 367)
        DgCliente.TabIndex = 1
        ' 
        ' CActivar
        ' 
        CActivar.FillWeight = 80F
        CActivar.HeaderText = "Activar"
        CActivar.Image = CType(resources.GetObject("CActivar.Image"), Image)
        CActivar.Name = "CActivar"
        CActivar.ReadOnly = True
        ' 
        ' CEliminar
        ' 
        CEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Red
        DataGridViewCellStyle3.NullValue = resources.GetObject("DataGridViewCellStyle3.NullValue")
        CEliminar.DefaultCellStyle = DataGridViewCellStyle3
        CEliminar.FillWeight = 80F
        CEliminar.HeaderText = "Eliminar"
        CEliminar.Image = CType(resources.GetObject("CEliminar.Image"), Image)
        CEliminar.Name = "CEliminar"
        CEliminar.ReadOnly = True
        CEliminar.Resizable = DataGridViewTriState.True
        CEliminar.Width = 73
        ' 
        ' CModificar
        ' 
        CModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle4.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.NullValue = resources.GetObject("DataGridViewCellStyle4.NullValue")
        CModificar.DefaultCellStyle = DataGridViewCellStyle4
        CModificar.FillWeight = 80F
        CModificar.HeaderText = "Modificar"
        CModificar.Image = CType(resources.GetObject("CModificar.Image"), Image)
        CModificar.Name = "CModificar"
        CModificar.ReadOnly = True
        CModificar.Resizable = DataGridViewTriState.True
        CModificar.Width = 82
        ' 
        ' CId_cliente
        ' 
        CId_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        CId_cliente.DataPropertyName = "id_persona"
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.ForeColor = Color.Black
        CId_cliente.DefaultCellStyle = DataGridViewCellStyle5
        CId_cliente.FillWeight = 191.7808F
        CId_cliente.HeaderText = "ID"
        CId_cliente.Name = "CId_cliente"
        CId_cliente.ReadOnly = True
        CId_cliente.Resizable = DataGridViewTriState.True
        CId_cliente.SortMode = DataGridViewColumnSortMode.NotSortable
        CId_cliente.Visible = False
        CId_cliente.Width = 40
        ' 
        ' CNombre
        ' 
        CNombre.DataPropertyName = "nombre"
        DataGridViewCellStyle6.ForeColor = Color.Black
        CNombre.DefaultCellStyle = DataGridViewCellStyle6
        CNombre.HeaderText = "Nombre"
        CNombre.Name = "CNombre"
        CNombre.ReadOnly = True
        CNombre.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CApellido
        ' 
        CApellido.DataPropertyName = "apellido"
        DataGridViewCellStyle7.ForeColor = Color.Black
        CApellido.DefaultCellStyle = DataGridViewCellStyle7
        CApellido.HeaderText = "Apellido"
        CApellido.Name = "CApellido"
        CApellido.ReadOnly = True
        CApellido.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CDni
        ' 
        CDni.DataPropertyName = "N_Documento"
        DataGridViewCellStyle8.ForeColor = Color.Black
        CDni.DefaultCellStyle = DataGridViewCellStyle8
        CDni.HeaderText = "DNI"
        CDni.Name = "CDni"
        CDni.ReadOnly = True
        CDni.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CTelefono
        ' 
        CTelefono.DataPropertyName = "celular"
        DataGridViewCellStyle9.ForeColor = Color.Black
        CTelefono.DefaultCellStyle = DataGridViewCellStyle9
        CTelefono.HeaderText = "Telefono"
        CTelefono.Name = "CTelefono"
        CTelefono.ReadOnly = True
        ' 
        ' CFechaAlta
        ' 
        CFechaAlta.DataPropertyName = "fecha_resgistro"
        DataGridViewCellStyle10.ForeColor = Color.Black
        CFechaAlta.DefaultCellStyle = DataGridViewCellStyle10
        CFechaAlta.FillWeight = 110F
        CFechaAlta.HeaderText = "Fecha Alta"
        CFechaAlta.Name = "CFechaAlta"
        CFechaAlta.ReadOnly = True
        ' 
        ' CDireccion
        ' 
        CDireccion.DataPropertyName = "Direccion"
        CDireccion.HeaderText = "Domicilio"
        CDireccion.Name = "CDireccion"
        CDireccion.ReadOnly = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(35, 41)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 16)
        Label3.TabIndex = 7
        Label3.Text = "BUSCAR POR:"
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(274, 62)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(143, 24)
        TxtBuscar.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(CriterioBusqueda)
        GroupBox2.Controls.Add(BInactivos)
        GroupBox2.Controls.Add(BActivos)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TxtBuscar)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(DgCliente)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(323, 28)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(793, 571)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Clientes"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(274, 43)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 16)
        Label8.TabIndex = 46
        Label8.Text = "Ingresar Datos"
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre"})
        CriterioBusqueda.Location = New Point(35, 60)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(135, 26)
        CriterioBusqueda.TabIndex = 45
        ' 
        ' BInactivos
        ' 
        BInactivos.BackColor = Color.DarkRed
        BInactivos.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BInactivos.ForeColor = Color.White
        BInactivos.Location = New Point(628, 49)
        BInactivos.Margin = New Padding(4, 3, 4, 3)
        BInactivos.Name = "BInactivos"
        BInactivos.Size = New Size(132, 37)
        BInactivos.TabIndex = 44
        BInactivos.Text = "Inactivos"
        BInactivos.UseVisualStyleBackColor = False
        ' 
        ' BActivos
        ' 
        BActivos.BackColor = Color.DarkGreen
        BActivos.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BActivos.ForeColor = Color.White
        BActivos.Location = New Point(628, 49)
        BActivos.Margin = New Padding(4, 3, 4, 3)
        BActivos.Name = "BActivos"
        BActivos.Size = New Size(132, 37)
        BActivos.TabIndex = 43
        BActivos.Text = "Activos"
        BActivos.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 513)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 18)
        Label7.TabIndex = 9
        Label7.Text = "Total Clientes:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(21, 114)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 30
        Label2.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Transparent
        LNombre.Location = New Point(23, 50)
        LNombre.Margin = New Padding(4, 0, 4, 0)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(65, 20)
        LNombre.TabIndex = 29
        LNombre.Text = "Nombre"
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(100, 114)
        TApellido.Margin = New Padding(4, 3, 4, 3)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(171, 24)
        TApellido.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(26, 180)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 20)
        Label1.TabIndex = 31
        Label1.Text = "DNI"
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(100, 50)
        TNombre.Margin = New Padding(4, 3, 4, 3)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(171, 24)
        TNombre.TabIndex = 32
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(100, 180)
        TDni.Margin = New Padding(4, 3, 4, 3)
        TDni.Name = "TDni"
        TDni.Size = New Size(171, 24)
        TDni.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(23, 249)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 35
        Label4.Text = "Telefono"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox1.Controls.Add(id)
        GroupBox1.Controls.Add(TDireccion)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(BGuardar)
        GroupBox1.Controls.Add(BCancelar)
        GroupBox1.Controls.Add(BAgregar)
        GroupBox1.Controls.Add(TCelular)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TDni)
        GroupBox1.Controls.Add(TNombre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TApellido)
        GroupBox1.Controls.Add(LNombre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(14, 28)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(287, 571)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Altas de Clientes"
        ' 
        ' id
        ' 
        id.Location = New Point(187, 23)
        id.Margin = New Padding(4, 3, 4, 3)
        id.Name = "id"
        id.Size = New Size(21, 24)
        id.TabIndex = 48
        id.Visible = False
        ' 
        ' TDireccion
        ' 
        TDireccion.Location = New Point(100, 317)
        TDireccion.Margin = New Padding(4, 3, 4, 3)
        TDireccion.Name = "TDireccion"
        TDireccion.Size = New Size(171, 24)
        TDireccion.TabIndex = 47
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(17, 317)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 46
        Label6.Text = "Direccion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(8, 388)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 45
        Label5.Text = "Fecha Alta"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(100, 384)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(171, 24)
        DateTimePicker1.TabIndex = 44
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.DarkGreen
        BGuardar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BGuardar.ForeColor = Color.White
        BGuardar.Location = New Point(26, 453)
        BGuardar.Margin = New Padding(4, 3, 4, 3)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(113, 42)
        BGuardar.TabIndex = 43
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = Color.DarkRed
        BCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancelar.ForeColor = Color.White
        BCancelar.Location = New Point(160, 453)
        BCancelar.Margin = New Padding(4, 3, 4, 3)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(111, 42)
        BCancelar.TabIndex = 42
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = SystemColors.HotTrack
        BAgregar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.ForeColor = Color.White
        BAgregar.Location = New Point(26, 453)
        BAgregar.Margin = New Padding(4, 3, 4, 3)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(108, 42)
        BAgregar.TabIndex = 41
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' TCelular
        ' 
        TCelular.Location = New Point(100, 245)
        TCelular.Margin = New Padding(4, 3, 4, 3)
        TCelular.Name = "TCelular"
        TCelular.Size = New Size(171, 24)
        TCelular.TabIndex = 37
        ' 
        ' panel_clliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(237))
        ClientSize = New Size(1135, 749)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "panel_clliente"
        Text = "panel_clliente"
        CType(DgCliente, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents DgCliente As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TCelular As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents BInactivos As Button
    Friend WithEvents BActivos As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents CActivar As DataGridViewImageColumn
    Friend WithEvents CEliminar As DataGridViewImageColumn
    Friend WithEvents CModificar As DataGridViewImageColumn
    Friend WithEvents CId_cliente As DataGridViewTextBoxColumn
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CApellido As DataGridViewTextBoxColumn
    Friend WithEvents CDni As DataGridViewTextBoxColumn
    Friend WithEvents CTelefono As DataGridViewTextBoxColumn
    Friend WithEvents CFechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents CDireccion As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents CriterioBusqueda As ComboBox
End Class
