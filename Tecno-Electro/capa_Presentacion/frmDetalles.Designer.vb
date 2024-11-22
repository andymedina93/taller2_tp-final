<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalles))
        GroupBox2 = New GroupBox()
        total = New Label()
        Ttotal = New TextBox()
        cliente = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        factura = New TextBox()
        nombreVendedor = New TextBox()
        dgdetalles = New DataGridView()
        GroupBox1 = New GroupBox()
        TITULO = New Label()
        Bpdf = New Button()
        GroupBox2.SuspendLayout()
        CType(dgdetalles, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        GroupBox2.Controls.Add(total)
        GroupBox2.Controls.Add(Ttotal)
        GroupBox2.Controls.Add(cliente)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(factura)
        GroupBox2.Controls.Add(nombreVendedor)
        GroupBox2.Controls.Add(dgdetalles)
        GroupBox2.Location = New Point(31, 138)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(739, 363)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total.Location = New Point(536, 337)
        total.Name = "total"
        total.Size = New Size(44, 20)
        total.TabIndex = 8
        total.Text = "Total"
        ' 
        ' Ttotal
        ' 
        Ttotal.Location = New Point(586, 334)
        Ttotal.Name = "Ttotal"
        Ttotal.Size = New Size(128, 23)
        Ttotal.TabIndex = 7
        ' 
        ' cliente
        ' 
        cliente.Location = New Point(135, 59)
        cliente.Name = "cliente"
        cliente.Size = New Size(151, 23)
        cliente.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(72, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 5
        Label3.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(440, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 4
        Label2.Text = "N° Factura"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 3
        Label1.Text = " Vendedor"
        ' 
        ' factura
        ' 
        factura.Location = New Point(529, 22)
        factura.Name = "factura"
        factura.Size = New Size(151, 23)
        factura.TabIndex = 1
        ' 
        ' nombreVendedor
        ' 
        nombreVendedor.Location = New Point(135, 22)
        nombreVendedor.Name = "nombreVendedor"
        nombreVendedor.Size = New Size(151, 23)
        nombreVendedor.TabIndex = 2
        ' 
        ' dgdetalles
        ' 
        dgdetalles.AllowUserToAddRows = False
        dgdetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgdetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgdetalles.Location = New Point(33, 88)
        dgdetalles.Name = "dgdetalles"
        dgdetalles.RowHeadersVisible = False
        dgdetalles.Size = New Size(683, 223)
        dgdetalles.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        GroupBox1.Controls.Add(TITULO)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(31, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(739, 81)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' TITULO
        ' 
        TITULO.AutoSize = True
        TITULO.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TITULO.Location = New Point(250, 30)
        TITULO.Name = "TITULO"
        TITULO.Size = New Size(88, 32)
        TITULO.TabIndex = 0
        TITULO.Text = "Label1"
        TITULO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Bpdf
        ' 
        Bpdf.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Bpdf.BackgroundImage = CType(resources.GetObject("Bpdf.BackgroundImage"), Image)
        Bpdf.BackgroundImageLayout = ImageLayout.None
        Bpdf.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bpdf.ForeColor = Color.White
        Bpdf.Location = New Point(617, 518)
        Bpdf.Name = "Bpdf"
        Bpdf.Size = New Size(153, 47)
        Bpdf.TabIndex = 4
        Bpdf.Text = "Generar PDF"
        Bpdf.TextAlign = ContentAlignment.MiddleRight
        Bpdf.TextImageRelation = TextImageRelation.ImageBeforeText
        Bpdf.UseVisualStyleBackColor = False
        ' 
        ' frmDetalles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(6), CByte(30), CByte(71))
        ClientSize = New Size(800, 577)
        Controls.Add(Bpdf)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmDetalles"
        Text = "DatosVentas"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgdetalles, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TITULO As Label
    Friend WithEvents dgdetalles As DataGridView
    Friend WithEvents Bpdf As Button
    Friend WithEvents factura As TextBox
    Friend WithEvents nombreVendedor As TextBox
    Friend WithEvents cliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents total As Label
    Friend WithEvents Ttotal As TextBox
End Class
