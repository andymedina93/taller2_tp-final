<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCliente
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
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaCliente))
        Dim DataGridViewCellStyle26 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        TxtBuscar = New TextBox()
        Label3 = New Label()
        DgCliente = New DataGridView()
        CId_cliente = New DataGridViewTextBoxColumn()
        CNombre = New DataGridViewTextBoxColumn()
        CApellido = New DataGridViewTextBoxColumn()
        CDni = New DataGridViewTextBoxColumn()
        Cseleccionar = New DataGridViewImageColumn()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        DataGridViewImageColumn2 = New DataGridViewImageColumn()
        DataGridViewImageColumn3 = New DataGridViewImageColumn()
        CriterioBusqueda = New ComboBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(DgCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(237))
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(CriterioBusqueda)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TxtBuscar)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(DgCliente)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(-10, -58)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(955, 636)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Clientes"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(35, 598)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 18)
        Label7.TabIndex = 9
        Label7.Text = "Total Clientes:"
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(382, 107)
        TxtBuscar.Margin = New Padding(4, 3, 4, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(175, 24)
        TxtBuscar.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(159, 86)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 16)
        Label3.TabIndex = 7
        Label3.Text = "BUSCAR POR:"
        ' 
        ' DgCliente
        ' 
        DgCliente.AllowUserToAddRows = False
        DataGridViewCellStyle19.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle19.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DgCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        DgCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgCliente.BackgroundColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        DgCliente.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = Color.Gray
        DataGridViewCellStyle20.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = Color.White
        DataGridViewCellStyle20.SelectionBackColor = Color.Gray
        DataGridViewCellStyle20.SelectionForeColor = Color.Black
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        DgCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        DgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgCliente.Columns.AddRange(New DataGridViewColumn() {CId_cliente, CNombre, CApellido, CDni, Cseleccionar})
        DataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle25.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle25.ForeColor = Color.White
        DataGridViewCellStyle25.SelectionBackColor = Color.LightBlue
        DataGridViewCellStyle25.SelectionForeColor = Color.Black
        DataGridViewCellStyle25.WrapMode = DataGridViewTriState.False
        DgCliente.DefaultCellStyle = DataGridViewCellStyle25
        DgCliente.EnableHeadersVisualStyles = False
        DgCliente.GridColor = SystemColors.ActiveCaption
        DgCliente.Location = New Point(27, 147)
        DgCliente.Margin = New Padding(4, 3, 4, 3)
        DgCliente.MultiSelect = False
        DgCliente.Name = "DgCliente"
        DgCliente.ReadOnly = True
        DgCliente.RowHeadersVisible = False
        DgCliente.SelectionMode = DataGridViewSelectionMode.CellSelect
        DgCliente.Size = New Size(904, 419)
        DgCliente.TabIndex = 1
        ' 
        ' CId_cliente
        ' 
        CId_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        CId_cliente.DataPropertyName = "id_persona"
        DataGridViewCellStyle21.BackColor = Color.White
        DataGridViewCellStyle21.ForeColor = Color.Black
        CId_cliente.DefaultCellStyle = DataGridViewCellStyle21
        CId_cliente.FillWeight = 191.7808F
        CId_cliente.HeaderText = "ID"
        CId_cliente.Name = "CId_cliente"
        CId_cliente.ReadOnly = True
        CId_cliente.Resizable = DataGridViewTriState.False
        CId_cliente.SortMode = DataGridViewColumnSortMode.NotSortable
        CId_cliente.Width = 40
        ' 
        ' CNombre
        ' 
        CNombre.DataPropertyName = "nombre"
        DataGridViewCellStyle22.ForeColor = Color.Black
        CNombre.DefaultCellStyle = DataGridViewCellStyle22
        CNombre.FillWeight = 84.70319F
        CNombre.HeaderText = "Nombre"
        CNombre.Name = "CNombre"
        CNombre.ReadOnly = True
        CNombre.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CApellido
        ' 
        CApellido.DataPropertyName = "apellido"
        DataGridViewCellStyle23.ForeColor = Color.Black
        CApellido.DefaultCellStyle = DataGridViewCellStyle23
        CApellido.FillWeight = 84.70319F
        CApellido.HeaderText = "Apellido"
        CApellido.Name = "CApellido"
        CApellido.ReadOnly = True
        CApellido.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' CDni
        ' 
        CDni.DataPropertyName = "N_Documento"
        DataGridViewCellStyle24.ForeColor = Color.Black
        CDni.DefaultCellStyle = DataGridViewCellStyle24
        CDni.FillWeight = 84.70319F
        CDni.HeaderText = "DNI"
        CDni.Name = "CDni"
        CDni.ReadOnly = True
        CDni.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Cseleccionar
        ' 
        Cseleccionar.HeaderText = "Seleccionar"
        Cseleccionar.Image = CType(resources.GetObject("Cseleccionar.Image"), Image)
        Cseleccionar.Name = "Cseleccionar"
        Cseleccionar.ReadOnly = True
        Cseleccionar.Resizable = DataGridViewTriState.True
        Cseleccionar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle26.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle26.NullValue = resources.GetObject("DataGridViewCellStyle26.NullValue")
        DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle26
        DataGridViewImageColumn1.HeaderText = "Modificar"
        DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), Image)
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.True
        ' 
        ' DataGridViewImageColumn2
        ' 
        DataGridViewImageColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = Color.Red
        DataGridViewCellStyle27.NullValue = resources.GetObject("DataGridViewCellStyle27.NullValue")
        DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle27
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
        DataGridViewImageColumn3.Width = 95
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre"})
        CriterioBusqueda.Location = New Point(159, 105)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(135, 26)
        CriterioBusqueda.TabIndex = 46
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(382, 88)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 16)
        Label1.TabIndex = 47
        Label1.Text = "Ingresar Datos"
        ' 
        ' BusquedaCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(GroupBox2)
        Margin = New Padding(4, 3, 4, 3)
        Name = "BusquedaCliente"
        Text = "BusquedaCliente"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DgCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgCliente As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents CId_cliente As DataGridViewTextBoxColumn
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CApellido As DataGridViewTextBoxColumn
    Friend WithEvents CDni As DataGridViewTextBoxColumn
    Friend WithEvents Cseleccionar As DataGridViewImageColumn
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents Label1 As Label
End Class
