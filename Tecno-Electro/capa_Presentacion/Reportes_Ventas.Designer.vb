<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes_Ventas))
        GroupBox1 = New GroupBox()
        TITULO = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        TxtBuscar = New TextBox()
        Label1 = New Label()
        CriterioBusqueda = New ComboBox()
        dgvReportes = New DataGridView()
        detalles = New DataGridViewTextBoxColumn()
        Bpdf = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        GroupBox1.Controls.Add(TITULO)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(55, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(932, 81)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' TITULO
        ' 
        TITULO.AutoSize = True
        TITULO.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TITULO.Location = New Point(337, 30)
        TITULO.Name = "TITULO"
        TITULO.Size = New Size(88, 32)
        TITULO.TabIndex = 0
        TITULO.Text = "Label1"
        TITULO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(TxtBuscar)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(CriterioBusqueda)
        GroupBox2.Controls.Add(dgvReportes)
        GroupBox2.Location = New Point(55, 124)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(932, 307)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(710, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 21)
        Label3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(282, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 21)
        Label2.TabIndex = 3
        Label2.Text = "Ingresar"
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(360, 43)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(122, 23)
        TxtBuscar.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 1
        Label1.Text = "Buscar por"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CriterioBusqueda
        ' 
        CriterioBusqueda.FormattingEnabled = True
        CriterioBusqueda.Items.AddRange(New Object() {"N° Factura"})
        CriterioBusqueda.Location = New Point(125, 41)
        CriterioBusqueda.Name = "CriterioBusqueda"
        CriterioBusqueda.Size = New Size(121, 23)
        CriterioBusqueda.TabIndex = 1
        ' 
        ' dgvReportes
        ' 
        dgvReportes.AllowUserToAddRows = False
        dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Columns.AddRange(New DataGridViewColumn() {detalles})
        dgvReportes.Location = New Point(29, 80)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.RowHeadersVisible = False
        dgvReportes.Size = New Size(884, 194)
        dgvReportes.TabIndex = 0
        ' 
        ' detalles
        ' 
        detalles.HeaderText = "Ver Detalles"
        detalles.Name = "detalles"
        ' 
        ' Bpdf
        ' 
        Bpdf.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Bpdf.BackgroundImage = CType(resources.GetObject("Bpdf.BackgroundImage"), Image)
        Bpdf.BackgroundImageLayout = ImageLayout.None
        Bpdf.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bpdf.ForeColor = Color.White
        Bpdf.Location = New Point(828, 437)
        Bpdf.Name = "Bpdf"
        Bpdf.Size = New Size(153, 47)
        Bpdf.TabIndex = 2
        Bpdf.Text = "Generar PDF"
        Bpdf.TextAlign = ContentAlignment.MiddleRight
        Bpdf.TextImageRelation = TextImageRelation.ImageBeforeText
        Bpdf.UseVisualStyleBackColor = False
        ' 
        ' Reportes_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1021, 496)
        Controls.Add(Bpdf)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Reportes_Ventas"
        Text = "Reportes_Ventas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bpdf As Button
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents TITULO As Label
    Friend WithEvents detalles As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CriterioBusqueda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label3 As Label
End Class
