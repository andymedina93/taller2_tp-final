<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelProductos))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        GroupBox4 = New GroupBox()
        BNuevaCategoria = New Button()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        CriterioBusqueda = New ComboBox()
        TxtBuscar = New TextBox()
        BInactivos = New Button()
        Label3 = New Label()
        BActivos = New Button()
        GroupBox2 = New GroupBox()
        tIdProducto = New TextBox()
        TPrecioCompra = New TextBox()
        Label9 = New Label()
        TStock = New TextBox()
        TCodigo = New TextBox()
        TCategoria = New ComboBox()
        TPrecioVenta = New TextBox()
        TDescripcion = New TextBox()
        TNombre = New TextBox()
        BCancelar = New Button()
        BAgregar = New Button()
        BGuardar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DgProductos = New DataGridView()
        CActivar = New DataGridViewImageColumn()
        CEliminar = New DataGridViewImageColumn()
        CModificar = New DataGridViewImageColumn()
        CId = New DataGridViewTextBoxColumn()
        CNombre = New DataGridViewTextBoxColumn()
        CCodigo = New DataGridViewTextBoxColumn()
        CDescripcion = New DataGridViewTextBoxColumn()
        CCategoria = New DataGridViewTextBoxColumn()
        CStock = New DataGridViewTextBoxColumn()
        CPrecioVenta = New DataGridViewTextBoxColumn()
        cPrecioCompra = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DgProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkGray
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(DgProductos)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(1131, 697)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox4.Controls.Add(BNuevaCategoria)
        GroupBox4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(13, 21)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(320, 98)
        GroupBox4.TabIndex = 19
        GroupBox4.TabStop = False
        GroupBox4.Text = "Agregar Categoria"
        ' 
        ' BNuevaCategoria
        ' 
        BNuevaCategoria.BackColor = Color.MidnightBlue
        BNuevaCategoria.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BNuevaCategoria.ForeColor = Color.White
        BNuevaCategoria.Location = New Point(58, 31)
        BNuevaCategoria.Margin = New Padding(4, 3, 4, 3)
        BNuevaCategoria.Name = "BNuevaCategoria"
        BNuevaCategoria.Size = New Size(205, 44)
        BNuevaCategoria.TabIndex = 29
        BNuevaCategoria.Text = "Nueva Categoria"
        BNuevaCategoria.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(CriterioBusqueda)
        GroupBox3.Controls.Add(TxtBuscar)
        GroupBox3.Controls.Add(BInactivos)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(BActivos)
        GroupBox3.ForeColor = Color.Indigo
        GroupBox3.Location = New Point(344, 21)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(776, 98)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(203, 30)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 16)
        Label8.TabIndex = 28
        Label8.Text = "Ingresar Datos"
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList
        CriterioBusqueda.Font = New Font("Calibri", 12F)
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"CODIGO", "NOMBRE", "DESCRIPCION", "CATEGORIA"})
        CriterioBusqueda.Location = New Point(16, 49)
        CriterioBusqueda.Margin = New Padding(4, 3, 4, 3)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(135, 27)
        CriterioBusqueda.TabIndex = 27
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBuscar.Location = New Point(203, 49)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(156, 26)
        TxtBuscar.TabIndex = 2
        ' 
        ' BInactivos
        ' 
        BInactivos.BackColor = Color.DarkRed
        BInactivos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BInactivos.ForeColor = Color.White
        BInactivos.Location = New Point(594, 30)
        BInactivos.Margin = New Padding(4, 3, 4, 3)
        BInactivos.Name = "BInactivos"
        BInactivos.Size = New Size(133, 45)
        BInactivos.TabIndex = 16
        BInactivos.Text = "Inactivos"
        BInactivos.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(16, 30)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 5
        Label3.Text = "Buscar Por:"
        ' 
        ' BActivos
        ' 
        BActivos.BackColor = Color.DarkGreen
        BActivos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BActivos.ForeColor = Color.White
        BActivos.Location = New Point(594, 30)
        BActivos.Margin = New Padding(4, 3, 4, 3)
        BActivos.Name = "BActivos"
        BActivos.Size = New Size(133, 45)
        BActivos.TabIndex = 17
        BActivos.Text = "Activos"
        BActivos.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        GroupBox2.Controls.Add(tIdProducto)
        GroupBox2.Controls.Add(TPrecioCompra)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(TStock)
        GroupBox2.Controls.Add(TCodigo)
        GroupBox2.Controls.Add(TCategoria)
        GroupBox2.Controls.Add(TPrecioVenta)
        GroupBox2.Controls.Add(TDescripcion)
        GroupBox2.Controls.Add(TNombre)
        GroupBox2.Controls.Add(BCancelar)
        GroupBox2.Controls.Add(BAgregar)
        GroupBox2.Controls.Add(BGuardar)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(13, 134)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(323, 486)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Registro de Productos"
        ' 
        ' tIdProducto
        ' 
        tIdProducto.Location = New Point(272, 14)
        tIdProducto.Margin = New Padding(4, 3, 4, 3)
        tIdProducto.Name = "tIdProducto"
        tIdProducto.Size = New Size(28, 24)
        tIdProducto.TabIndex = 29
        tIdProducto.Visible = False
        ' 
        ' TPrecioCompra
        ' 
        TPrecioCompra.Location = New Point(149, 310)
        TPrecioCompra.Margin = New Padding(4, 3, 4, 3)
        TPrecioCompra.Name = "TPrecioCompra"
        TPrecioCompra.Size = New Size(166, 24)
        TPrecioCompra.TabIndex = 30
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 359)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 29
        Label9.Text = "Precio Venta"
        ' 
        ' TStock
        ' 
        TStock.Location = New Point(149, 256)
        TStock.Margin = New Padding(4, 3, 4, 3)
        TStock.Name = "TStock"
        TStock.Size = New Size(166, 24)
        TStock.TabIndex = 28
        ' 
        ' TCodigo
        ' 
        TCodigo.Location = New Point(149, 148)
        TCodigo.Margin = New Padding(4, 3, 4, 3)
        TCodigo.Name = "TCodigo"
        TCodigo.Size = New Size(166, 24)
        TCodigo.TabIndex = 27
        ' 
        ' TCategoria
        ' 
        TCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        TCategoria.Font = New Font("Calibri", 12F)
        TCategoria.FormattingEnabled = True
        TCategoria.Location = New Point(149, 200)
        TCategoria.Margin = New Padding(4, 3, 4, 3)
        TCategoria.Name = "TCategoria"
        TCategoria.Size = New Size(166, 27)
        TCategoria.TabIndex = 26
        ' 
        ' TPrecioVenta
        ' 
        TPrecioVenta.Location = New Point(149, 359)
        TPrecioVenta.Margin = New Padding(4, 3, 4, 3)
        TPrecioVenta.Name = "TPrecioVenta"
        TPrecioVenta.Size = New Size(166, 24)
        TPrecioVenta.TabIndex = 22
        ' 
        ' TDescripcion
        ' 
        TDescripcion.Location = New Point(149, 97)
        TDescripcion.Margin = New Padding(4, 3, 4, 3)
        TDescripcion.Name = "TDescripcion"
        TDescripcion.Size = New Size(166, 24)
        TDescripcion.TabIndex = 19
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(149, 44)
        TNombre.Margin = New Padding(4, 3, 4, 3)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(166, 24)
        TNombre.TabIndex = 18
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = Color.DarkGreen
        BCancelar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancelar.Location = New Point(179, 420)
        BCancelar.Margin = New Padding(4, 3, 4, 3)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(121, 45)
        BCancelar.TabIndex = 15
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = Color.DarkRed
        BAgregar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.Location = New Point(9, 420)
        BAgregar.Margin = New Padding(4, 3, 4, 3)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(124, 45)
        BAgregar.TabIndex = 14
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.DarkBlue
        BGuardar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BGuardar.Location = New Point(9, 420)
        BGuardar.Margin = New Padding(4, 3, 4, 3)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(124, 45)
        BGuardar.TabIndex = 13
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 44)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 18)
        Label1.TabIndex = 6
        Label1.Text = "Nombre Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 148)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 18)
        Label2.TabIndex = 7
        Label2.Text = "Codigo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 310)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 18)
        Label6.TabIndex = 10
        Label6.Text = "Precio Compra"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 259)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 18)
        Label7.TabIndex = 11
        Label7.Text = "Stock"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 97)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 18)
        Label4.TabIndex = 8
        Label4.Text = "Descripcion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 209)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 18)
        Label5.TabIndex = 9
        Label5.Text = "Categoria"
        ' 
        ' DgProductos
        ' 
        DgProductos.AllowUserToAddRows = False
        DgProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DgProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgProductos.BackgroundColor = Color.LightSteelBlue
        DgProductos.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgProductos.Columns.AddRange(New DataGridViewColumn() {CActivar, CEliminar, CModificar, CId, CNombre, CCodigo, CDescripcion, CCategoria, CStock, CPrecioVenta, cPrecioCompra})
        DgProductos.Location = New Point(344, 134)
        DgProductos.Margin = New Padding(4, 3, 4, 3)
        DgProductos.MultiSelect = False
        DgProductos.Name = "DgProductos"
        DgProductos.ReadOnly = True
        DgProductos.RowHeadersVisible = False
        DgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgProductos.Size = New Size(776, 486)
        DgProductos.TabIndex = 0
        ' 
        ' CActivar
        ' 
        CActivar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        CActivar.FillWeight = 380.587677F
        CActivar.HeaderText = "Activar"
        CActivar.Image = CType(resources.GetObject("CActivar.Image"), Image)
        CActivar.Name = "CActivar"
        CActivar.ReadOnly = True
        CActivar.Resizable = DataGridViewTriState.True
        CActivar.SortMode = DataGridViewColumnSortMode.Automatic
        CActivar.Width = 84
        ' 
        ' CEliminar
        ' 
        CEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Red
        DataGridViewCellStyle3.NullValue = resources.GetObject("DataGridViewCellStyle3.NullValue")
        CEliminar.DefaultCellStyle = DataGridViewCellStyle3
        CEliminar.HeaderText = "Eliminar"
        CEliminar.Image = CType(resources.GetObject("CEliminar.Image"), Image)
        CEliminar.Name = "CEliminar"
        CEliminar.ReadOnly = True
        CEliminar.Resizable = DataGridViewTriState.True
        CEliminar.Width = 75
        ' 
        ' CModificar
        ' 
        CModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle4.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.NullValue = resources.GetObject("DataGridViewCellStyle4.NullValue")
        CModificar.DefaultCellStyle = DataGridViewCellStyle4
        CModificar.HeaderText = "Modificar"
        CModificar.Image = CType(resources.GetObject("CModificar.Image"), Image)
        CModificar.Name = "CModificar"
        CModificar.ReadOnly = True
        CModificar.Resizable = DataGridViewTriState.True
        CModificar.Width = 84
        ' 
        ' CId
        ' 
        CId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        CId.DataPropertyName = "id_producto"
        CId.FillWeight = 191.7808F
        CId.HeaderText = "ID"
        CId.Name = "CId"
        CId.ReadOnly = True
        CId.Resizable = DataGridViewTriState.False
        CId.SortMode = DataGridViewColumnSortMode.NotSortable
        CId.Visible = False
        CId.Width = 40
        ' 
        ' CNombre
        ' 
        CNombre.DataPropertyName = "Nombre"
        CNombre.FillWeight = 39.3050156F
        CNombre.HeaderText = "Nombre"
        CNombre.Name = "CNombre"
        CNombre.ReadOnly = True
        CNombre.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CCodigo
        ' 
        CCodigo.DataPropertyName = "codigo"
        CCodigo.FillWeight = 39.3050156F
        CCodigo.HeaderText = "Codigo"
        CCodigo.Name = "CCodigo"
        CCodigo.ReadOnly = True
        CCodigo.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CDescripcion
        ' 
        CDescripcion.DataPropertyName = "descripcion"
        CDescripcion.FillWeight = 39.3050156F
        CDescripcion.HeaderText = "Descripcion"
        CDescripcion.Name = "CDescripcion"
        CDescripcion.ReadOnly = True
        CDescripcion.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CCategoria
        ' 
        CCategoria.DataPropertyName = "c_descripcion"
        CCategoria.FillWeight = 39.3050156F
        CCategoria.HeaderText = "Categoria"
        CCategoria.Name = "CCategoria"
        CCategoria.ReadOnly = True
        CCategoria.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CStock
        ' 
        CStock.DataPropertyName = "Stock"
        CStock.FillWeight = 39.3050156F
        CStock.HeaderText = "Stock"
        CStock.Name = "CStock"
        CStock.ReadOnly = True
        CStock.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CPrecioVenta
        ' 
        CPrecioVenta.DataPropertyName = "precio_vta"
        CPrecioVenta.FillWeight = 46.40323F
        CPrecioVenta.HeaderText = "Precio Venta"
        CPrecioVenta.Name = "CPrecioVenta"
        CPrecioVenta.ReadOnly = True
        ' 
        ' cPrecioCompra
        ' 
        cPrecioCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        cPrecioCompra.DataPropertyName = "precio_compra"
        cPrecioCompra.HeaderText = "Precio Compra"
        cPrecioCompra.Name = "cPrecioCompra"
        cPrecioCompra.ReadOnly = True
        cPrecioCompra.Width = 80
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(237))
        Panel2.Controls.Add(GroupBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.ForeColor = Color.DarkSlateGray
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 748)
        Panel2.TabIndex = 3
        ' 
        ' panelProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 748)
        ControlBox = False
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "panelProductos"
        Text = "panel_producto"
        GroupBox1.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DgProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BInactivos As Button
    Friend WithEvents BActivos As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents TCategoria As ComboBox
    Friend WithEvents TPrecioVenta As TextBox
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgProductos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TPrecioCompra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BNuevaCategoria As Button
    Friend WithEvents tIdProducto As TextBox
    Friend WithEvents CActivar As DataGridViewImageColumn
    Friend WithEvents CEliminar As DataGridViewImageColumn
    Friend WithEvents CModificar As DataGridViewImageColumn
    Friend WithEvents CId As DataGridViewTextBoxColumn
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CCodigo As DataGridViewTextBoxColumn
    Friend WithEvents CDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents CCategoria As DataGridViewTextBoxColumn
    Friend WithEvents CStock As DataGridViewTextBoxColumn
    Friend WithEvents CPrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents cPrecioCompra As DataGridViewTextBoxColumn
End Class
