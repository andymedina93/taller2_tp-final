<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        TxtBuscar = New TextBox()
        DgVentas = New DataGridView()
        idProducto = New DataGridViewTextBoxColumn()
        codigo = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        producto = New DataGridViewTextBoxColumn()
        precio = New DataGridViewTextBoxColumn()
        cantidad = New DataGridViewTextBoxColumn()
        sub_total = New DataGridViewTextBoxColumn()
        Quitar = New DataGridViewButtonColumn()
        GroupBox2 = New GroupBox()
        TUsuarioId = New TextBox()
        Tfecha = New DateTimePicker()
        TNombreUsuario = New TextBox()
        GroupBox3 = New GroupBox()
        TClienteId = New TextBox()
        Label13 = New Label()
        TNombre = New TextBox()
        BBuscarCliente = New Button()
        TApellido = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label14 = New Label()
        TDescripcion = New TextBox()
        TidProducto = New TextBox()
        BBuscarProducto = New Button()
        TCantidad = New NumericUpDown()
        TStock = New TextBox()
        TPrecioventa = New TextBox()
        TProducto = New TextBox()
        TCodigo = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox4 = New GroupBox()
        Button1 = New Button()
        BGuardar = New Button()
        TotalPagar = New TextBox()
        Label10 = New Label()
        BAgregar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(TCantidad, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(191), CByte(215), CByte(237))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1370, 749)
        DataGridView1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        Label2.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(183, 22)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 18)
        Label2.TabIndex = 2
        Label2.Text = "Nombre Vendedor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        Label3.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(21, 23)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 18)
        Label3.TabIndex = 6
        Label3.Text = "N° de Documento"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        Label6.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(23, 21)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 18)
        Label6.TabIndex = 8
        Label6.Text = "Fecha"
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(24, 46)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(156, 24)
        TxtBuscar.TabIndex = 10
        ' 
        ' DgVentas
        ' 
        DgVentas.AllowUserToAddRows = False
        DgVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgVentas.Columns.AddRange(New DataGridViewColumn() {idProducto, codigo, Descripcion, producto, precio, cantidad, sub_total, Quitar})
        DgVentas.Location = New Point(19, 265)
        DgVentas.Margin = New Padding(4, 3, 4, 3)
        DgVentas.Name = "DgVentas"
        DgVentas.RowHeadersVisible = False
        DgVentas.Size = New Size(844, 312)
        DgVentas.TabIndex = 17
        ' 
        ' idProducto
        ' 
        idProducto.HeaderText = "id producto"
        idProducto.Name = "idProducto"
        idProducto.Visible = False
        ' 
        ' codigo
        ' 
        codigo.HeaderText = "codigo"
        codigo.Name = "codigo"
        ' 
        ' Descripcion
        ' 
        Descripcion.HeaderText = "Descripcion"
        Descripcion.Name = "Descripcion"
        ' 
        ' producto
        ' 
        DataGridViewCellStyle1.ForeColor = Color.Black
        producto.DefaultCellStyle = DataGridViewCellStyle1
        producto.HeaderText = "Producto"
        producto.Name = "producto"
        ' 
        ' precio
        ' 
        precio.HeaderText = "Precio"
        precio.Name = "precio"
        ' 
        ' cantidad
        ' 
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        cantidad.DefaultCellStyle = DataGridViewCellStyle2
        cantidad.HeaderText = "Cantidad"
        cantidad.Name = "cantidad"
        ' 
        ' sub_total
        ' 
        DataGridViewCellStyle3.ForeColor = Color.Black
        sub_total.DefaultCellStyle = DataGridViewCellStyle3
        sub_total.HeaderText = "Sub Total"
        sub_total.Name = "sub_total"
        ' 
        ' Quitar
        ' 
        Quitar.HeaderText = "Quitar"
        Quitar.Name = "Quitar"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox2.Controls.Add(TUsuarioId)
        GroupBox2.Controls.Add(Tfecha)
        GroupBox2.Controls.Add(TNombreUsuario)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(19, 28)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(424, 89)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informacion de Compra"
        ' 
        ' TUsuarioId
        ' 
        TUsuarioId.Location = New Point(128, 20)
        TUsuarioId.Margin = New Padding(4, 3, 4, 3)
        TUsuarioId.Name = "TUsuarioId"
        TUsuarioId.Size = New Size(23, 22)
        TUsuarioId.TabIndex = 29
        TUsuarioId.Visible = False
        ' 
        ' Tfecha
        ' 
        Tfecha.Enabled = False
        Tfecha.Location = New Point(23, 48)
        Tfecha.Name = "Tfecha"
        Tfecha.Size = New Size(106, 22)
        Tfecha.TabIndex = 29
        ' 
        ' TNombreUsuario
        ' 
        TNombreUsuario.Enabled = False
        TNombreUsuario.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TNombreUsuario.Location = New Point(183, 48)
        TNombreUsuario.Margin = New Padding(4, 3, 4, 3)
        TNombreUsuario.Name = "TNombreUsuario"
        TNombreUsuario.Size = New Size(223, 24)
        TNombreUsuario.TabIndex = 19
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox3.Controls.Add(TClienteId)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(TNombre)
        GroupBox3.Controls.Add(BBuscarCliente)
        GroupBox3.Controls.Add(TApellido)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(TxtBuscar)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(506, 22)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(564, 89)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Informacion de Cliente"
        ' 
        ' TClienteId
        ' 
        TClienteId.Enabled = False
        TClienteId.Location = New Point(201, 17)
        TClienteId.Margin = New Padding(4, 3, 4, 3)
        TClienteId.Name = "TClienteId"
        TClienteId.Size = New Size(23, 24)
        TClienteId.TabIndex = 30
        TClienteId.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(404, 25)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(62, 18)
        Label13.TabIndex = 18
        Label13.Text = "Nombre"
        ' 
        ' TNombre
        ' 
        TNombre.Enabled = False
        TNombre.Location = New Point(404, 46)
        TNombre.Margin = New Padding(4, 3, 4, 3)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(139, 24)
        TNombre.TabIndex = 17
        ' 
        ' BBuscarCliente
        ' 
        BBuscarCliente.FlatStyle = FlatStyle.Popup
        BBuscarCliente.Image = CType(resources.GetObject("BBuscarCliente.Image"), Image)
        BBuscarCliente.Location = New Point(201, 42)
        BBuscarCliente.Margin = New Padding(4, 3, 4, 3)
        BBuscarCliente.Name = "BBuscarCliente"
        BBuscarCliente.Size = New Size(34, 33)
        BBuscarCliente.TabIndex = 16
        BBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' TApellido
        ' 
        TApellido.Enabled = False
        TApellido.Location = New Point(254, 46)
        TApellido.Margin = New Padding(4, 3, 4, 3)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(139, 24)
        TApellido.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(254, 21)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 18)
        Label1.TabIndex = 11
        Label1.Text = "Apellido"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(TDescripcion)
        GroupBox1.Controls.Add(TidProducto)
        GroupBox1.Controls.Add(BBuscarProducto)
        GroupBox1.Controls.Add(TCantidad)
        GroupBox1.Controls.Add(TStock)
        GroupBox1.Controls.Add(TPrecioventa)
        GroupBox1.Controls.Add(TProducto)
        GroupBox1.Controls.Add(TCodigo)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(19, 142)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(870, 103)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de Producto"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(453, 32)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(87, 18)
        Label14.TabIndex = 20
        Label14.Text = "Descripcion"
        Label14.UseMnemonic = False
        ' 
        ' TDescripcion
        ' 
        TDescripcion.Enabled = False
        TDescripcion.Location = New Point(453, 53)
        TDescripcion.Margin = New Padding(4, 3, 4, 3)
        TDescripcion.Name = "TDescripcion"
        TDescripcion.Size = New Size(121, 24)
        TDescripcion.TabIndex = 19
        ' 
        ' TidProducto
        ' 
        TidProducto.Location = New Point(152, 22)
        TidProducto.Margin = New Padding(4, 3, 4, 3)
        TidProducto.Name = "TidProducto"
        TidProducto.Size = New Size(31, 24)
        TidProducto.TabIndex = 18
        TidProducto.Visible = False
        ' 
        ' BBuscarProducto
        ' 
        BBuscarProducto.FlatStyle = FlatStyle.Flat
        BBuscarProducto.Image = CType(resources.GetObject("BBuscarProducto.Image"), Image)
        BBuscarProducto.Location = New Point(152, 52)
        BBuscarProducto.Margin = New Padding(4, 3, 4, 3)
        BBuscarProducto.Name = "BBuscarProducto"
        BBuscarProducto.Size = New Size(31, 31)
        BBuscarProducto.TabIndex = 17
        BBuscarProducto.UseVisualStyleBackColor = True
        ' 
        ' TCantidad
        ' 
        TCantidad.Location = New Point(733, 53)
        TCantidad.Margin = New Padding(4, 3, 4, 3)
        TCantidad.Name = "TCantidad"
        TCantidad.Size = New Size(111, 24)
        TCantidad.TabIndex = 15
        ' 
        ' TStock
        ' 
        TStock.Enabled = False
        TStock.Location = New Point(591, 53)
        TStock.Margin = New Padding(4, 3, 4, 3)
        TStock.Name = "TStock"
        TStock.Size = New Size(131, 24)
        TStock.TabIndex = 14
        ' 
        ' TPrecioventa
        ' 
        TPrecioventa.Enabled = False
        TPrecioventa.Location = New Point(342, 54)
        TPrecioventa.Margin = New Padding(4, 3, 4, 3)
        TPrecioventa.Name = "TPrecioventa"
        TPrecioventa.Size = New Size(94, 24)
        TPrecioventa.TabIndex = 13
        ' 
        ' TProducto
        ' 
        TProducto.Enabled = False
        TProducto.Location = New Point(201, 52)
        TProducto.Margin = New Padding(4, 3, 4, 3)
        TProducto.Name = "TProducto"
        TProducto.Size = New Size(121, 24)
        TProducto.TabIndex = 12
        ' 
        ' TCodigo
        ' 
        TCodigo.Location = New Point(8, 53)
        TCodigo.Margin = New Padding(4, 3, 4, 3)
        TCodigo.Name = "TCodigo"
        TCodigo.Size = New Size(125, 24)
        TCodigo.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(733, 32)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 18)
        Label9.TabIndex = 4
        Label9.Text = "Cantidad"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(591, 32)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 18)
        Label8.TabIndex = 3
        Label8.Text = "Stock"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(342, 33)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 18)
        Label7.TabIndex = 2
        Label7.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(201, 32)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 18)
        Label5.TabIndex = 1
        Label5.Text = "Producto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 32)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 18)
        Label4.TabIndex = 0
        Label4.Text = "Codigo Producto"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox4.Controls.Add(Button1)
        GroupBox4.Controls.Add(BGuardar)
        GroupBox4.Controls.Add(TotalPagar)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(BAgregar)
        GroupBox4.Controls.Add(GroupBox2)
        GroupBox4.Controls.Add(DgVentas)
        GroupBox4.Controls.Add(GroupBox1)
        GroupBox4.Controls.Add(GroupBox3)
        GroupBox4.FlatStyle = FlatStyle.System
        GroupBox4.Location = New Point(13, 12)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(1094, 660)
        GroupBox4.TabIndex = 21
        GroupBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(910, 485)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 40)
        Button1.TabIndex = 29
        Button1.Text = "Cancelar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.FromArgb(CByte(12), CByte(45), CByte(72))
        BGuardar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BGuardar.ForeColor = Color.White
        BGuardar.Location = New Point(910, 363)
        BGuardar.Margin = New Padding(4, 3, 4, 3)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(160, 81)
        BGuardar.TabIndex = 28
        BGuardar.Text = "Confirmar Venta"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' TotalPagar
        ' 
        TotalPagar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalPagar.Location = New Point(910, 288)
        TotalPagar.Margin = New Padding(4, 3, 4, 3)
        TotalPagar.Name = "TotalPagar"
        TotalPagar.Size = New Size(160, 24)
        TotalPagar.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(910, 265)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 20)
        Label10.TabIndex = 22
        Label10.Text = "Total  a Pagar"
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BAgregar.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.ForeColor = Color.White
        BAgregar.Location = New Point(910, 142)
        BAgregar.Margin = New Padding(4, 3, 4, 3)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(160, 106)
        BAgregar.TabIndex = 21
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(DataGridView1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Ventas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Productos"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DgVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(TCantidad, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgVentas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents TPrecioventa As TextBox
    Friend WithEvents TProducto As TextBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents TCantidad As NumericUpDown
    Friend WithEvents BAgregar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents TotalPagar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BBuscarCliente As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TNombreUsuario As TextBox
    Friend WithEvents Tfecha As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TUsuarioId As TextBox
    Friend WithEvents TClienteId As TextBox
    Friend WithEvents TidProducto As TextBox
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Quitar As DataGridViewButtonColumn
    Friend WithEvents Button1 As Button
End Class
