<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Categorias
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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        CEstado = New ComboBox()
        BCancelar = New Button()
        BAgregar = New Button()
        BEliminar = New Button()
        BModificar = New Button()
        TDescripcion = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        DgvCategorias = New DataGridView()
        Seleccionar = New DataGridViewButtonColumn()
        Categoria = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        TID = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DgvCategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(CEstado)
        GroupBox1.Controls.Add(BCancelar)
        GroupBox1.Controls.Add(BAgregar)
        GroupBox1.Controls.Add(BEliminar)
        GroupBox1.Controls.Add(BModificar)
        GroupBox1.Controls.Add(TDescripcion)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(25, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(535, 128)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(335, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 7
        Label2.Text = "Estado"
        ' 
        ' CEstado
        ' 
        CEstado.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CEstado.FormattingEnabled = True
        CEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        CEstado.Location = New Point(397, 21)
        CEstado.Name = "CEstado"
        CEstado.Size = New Size(121, 28)
        CEstado.TabIndex = 6
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = SystemColors.Highlight
        BCancelar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancelar.ForeColor = Color.White
        BCancelar.Location = New Point(346, 72)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(104, 43)
        BCancelar.TabIndex = 5
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' BAgregar
        ' 
        BAgregar.BackColor = Color.DarkGreen
        BAgregar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BAgregar.ForeColor = Color.White
        BAgregar.Location = New Point(71, 71)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(101, 42)
        BAgregar.TabIndex = 4
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = False
        ' 
        ' BEliminar
        ' 
        BEliminar.BackColor = Color.DarkRed
        BEliminar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BEliminar.ForeColor = Color.White
        BEliminar.Location = New Point(216, 72)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(100, 42)
        BEliminar.TabIndex = 3
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = False
        ' 
        ' BModificar
        ' 
        BModificar.BackColor = Color.DarkOrange
        BModificar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BModificar.ForeColor = Color.White
        BModificar.Location = New Point(71, 71)
        BModificar.Name = "BModificar"
        BModificar.Size = New Size(96, 42)
        BModificar.TabIndex = 2
        BModificar.Text = "Modificar"
        BModificar.UseVisualStyleBackColor = False
        ' 
        ' TDescripcion
        ' 
        TDescripcion.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TDescripcion.Location = New Point(161, 22)
        TDescripcion.Name = "TDescripcion"
        TDescripcion.Size = New Size(130, 27)
        TDescripcion.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 21)
        Label1.TabIndex = 0
        Label1.Text = "Ingresar Categoria"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DgvCategorias)
        GroupBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(25, 176)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(535, 148)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Todas las Categorias"
        ' 
        ' DgvCategorias
        ' 
        DgvCategorias.AllowUserToAddRows = False
        DgvCategorias.AllowUserToDeleteRows = False
        DgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvCategorias.Columns.AddRange(New DataGridViewColumn() {Seleccionar, Categoria, Estado, Id})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DgvCategorias.DefaultCellStyle = DataGridViewCellStyle1
        DgvCategorias.Location = New Point(17, 22)
        DgvCategorias.Name = "DgvCategorias"
        DgvCategorias.RowHeadersVisible = False
        DgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvCategorias.Size = New Size(501, 106)
        DgvCategorias.TabIndex = 0
        ' 
        ' Seleccionar
        ' 
        Seleccionar.HeaderText = "Seleccionar"
        Seleccionar.Name = "Seleccionar"
        ' 
        ' Categoria
        ' 
        Categoria.DataPropertyName = "c_descripcion"
        Categoria.HeaderText = "Categoria"
        Categoria.Name = "Categoria"
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "estado"
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        ' 
        ' Id
        ' 
        Id.DataPropertyName = "Id_categoria"
        Id.HeaderText = "Id"
        Id.Name = "Id"
        Id.Visible = False
        ' 
        ' TID
        ' 
        TID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TID.Location = New Point(186, 3)
        TID.Name = "TID"
        TID.Size = New Size(22, 27)
        TID.TabIndex = 8
        TID.Visible = False
        ' 
        ' Panel_Categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(584, 336)
        Controls.Add(TID)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Panel_Categorias"
        Text = "Panel_Categorias"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DgvCategorias, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BAgregar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvCategorias As DataGridView
    Friend WithEvents BCancelar As Button
    Friend WithEvents Seleccionar As DataGridViewButtonColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents CEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TID As TextBox
End Class
