<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaProducto))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label3 = New Label()
        DgProductos = New DataGridView()
        CId = New DataGridViewTextBoxColumn()
        CNombre = New DataGridViewTextBoxColumn()
        CCodigo = New DataGridViewTextBoxColumn()
        CDescripcion = New DataGridViewTextBoxColumn()
        CStock = New DataGridViewTextBoxColumn()
        CPrecio = New DataGridViewTextBoxColumn()
        CSeleccionar = New DataGridViewImageColumn()
        TxtBuscar = New TextBox()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        DataGridViewImageColumn2 = New DataGridViewImageColumn()
        DataGridViewImageColumn3 = New DataGridViewImageColumn()
        CriterioBusqueda = New ComboBox()
        Label1 = New Label()
        CType(DgProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(83, 44)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 16)
        Label3.TabIndex = 20
        Label3.Text = "BUSCAR POR:"
        ' 
        ' DgProductos
        ' 
        DgProductos.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DgProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgProductos.BackgroundColor = SystemColors.ActiveCaption
        DgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgProductos.Columns.AddRange(New DataGridViewColumn() {CId, CNombre, CCodigo, CDescripcion, CStock, CPrecio, CSeleccionar})
        DgProductos.Location = New Point(30, 107)
        DgProductos.Margin = New Padding(4, 3, 4, 3)
        DgProductos.MultiSelect = False
        DgProductos.Name = "DgProductos"
        DgProductos.ReadOnly = True
        DgProductos.RowHeadersVisible = False
        DgProductos.SelectionMode = DataGridViewSelectionMode.CellSelect
        DgProductos.Size = New Size(876, 384)
        DgProductos.TabIndex = 18
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
        CNombre.FillWeight = 84.70319F
        CNombre.HeaderText = "Nombre"
        CNombre.Name = "CNombre"
        CNombre.ReadOnly = True
        CNombre.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CCodigo
        ' 
        CCodigo.DataPropertyName = "codigo"
        CCodigo.FillWeight = 84.70319F
        CCodigo.HeaderText = "Codigo"
        CCodigo.Name = "CCodigo"
        CCodigo.ReadOnly = True
        CCodigo.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CDescripcion
        ' 
        CDescripcion.DataPropertyName = "descripcion"
        CDescripcion.FillWeight = 84.70319F
        CDescripcion.HeaderText = "Descripcion"
        CDescripcion.Name = "CDescripcion"
        CDescripcion.ReadOnly = True
        CDescripcion.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CStock
        ' 
        CStock.DataPropertyName = "Stock"
        CStock.FillWeight = 84.70319F
        CStock.HeaderText = "Stock"
        CStock.Name = "CStock"
        CStock.ReadOnly = True
        CStock.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CPrecio
        ' 
        CPrecio.DataPropertyName = "precio_vta"
        CPrecio.HeaderText = "Precio"
        CPrecio.Name = "CPrecio"
        CPrecio.ReadOnly = True
        ' 
        ' CSeleccionar
        ' 
        CSeleccionar.HeaderText = "Seleccionar"
        CSeleccionar.Image = CType(resources.GetObject("CSeleccionar.Image"), Image)
        CSeleccionar.Name = "CSeleccionar"
        CSeleccionar.ReadOnly = True
        CSeleccionar.Resizable = DataGridViewTriState.True
        CSeleccionar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBuscar.Location = New Point(302, 63)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(173, 27)
        TxtBuscar.TabIndex = 19
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.NullValue = resources.GetObject("DataGridViewCellStyle2.NullValue")
        DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewImageColumn1.HeaderText = "Modificar"
        DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), Image)
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.True
        ' 
        ' DataGridViewImageColumn2
        ' 
        DataGridViewImageColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Red
        DataGridViewCellStyle3.NullValue = resources.GetObject("DataGridViewCellStyle3.NullValue")
        DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewImageColumn2.HeaderText = "Eliminar"
        DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), Image)
        DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        DataGridViewImageColumn2.Resizable = DataGridViewTriState.True
        ' 
        ' DataGridViewImageColumn3
        ' 
        DataGridViewImageColumn3.HeaderText = "Activar"
        DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), Image)
        DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        DataGridViewImageColumn3.Resizable = DataGridViewTriState.True
        DataGridViewImageColumn3.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewImageColumn3.Width = 85
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList
        CriterioBusqueda.Font = New Font("Calibri", 12F)
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"CODIGO", "NOMBRE", "DESCRIPCION", "CATEGORIA"})
        CriterioBusqueda.Location = New Point(83, 63)
        CriterioBusqueda.Margin = New Padding(4, 3, 4, 3)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(144, 27)
        CriterioBusqueda.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(302, 44)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 18)
        Label1.TabIndex = 29
        Label1.Text = "Ingresar Datos"
        ' 
        ' BusquedaProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(933, 519)
        Controls.Add(Label1)
        Controls.Add(CriterioBusqueda)
        Controls.Add(TxtBuscar)
        Controls.Add(DgProductos)
        Controls.Add(Label3)
        Margin = New Padding(4, 3, 4, 3)
        Name = "BusquedaProducto"
        Text = "BusquedaProducto"
        CType(DgProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DgProductos As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents CId As DataGridViewTextBoxColumn
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CCodigo As DataGridViewTextBoxColumn
    Friend WithEvents CDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents CStock As DataGridViewTextBoxColumn
    Friend WithEvents CPrecio As DataGridViewTextBoxColumn
    Friend WithEvents CSeleccionar As DataGridViewImageColumn
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents Label1 As Label
End Class
