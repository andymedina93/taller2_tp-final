<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Reporte
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
        Box_registrar_compra = New GroupBox()
        Graficos = New Button()
        GroupBox2 = New GroupBox()
        Nvendidos = New TextBox()
        BProductoVendidos = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Tcategoria = New ComboBox()
        GroupBox4 = New GroupBox()
        Label10 = New Label()
        Bproductos = New Button()
        Nproducto = New TextBox()
        GroupBox5 = New GroupBox()
        Nvendedor = New TextBox()
        Label9 = New Label()
        BVendedor = New Button()
        GroupBox3 = New GroupBox()
        BVentas = New Button()
        GroupBox6 = New GroupBox()
        Ncliente = New TextBox()
        BCliente = New Button()
        Label6 = New Label()
        Label7 = New Label()
        FF = New GroupBox()
        Label8 = New Label()
        Label2 = New Label()
        fechaF = New TextBox()
        fechaI = New TextBox()
        MonthCalendar2 = New MonthCalendar()
        MonthCalendar1 = New MonthCalendar()
        Label5 = New Label()
        Label1 = New Label()
        Box_registrar_compra.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox6.SuspendLayout()
        FF.SuspendLayout()
        SuspendLayout()
        ' 
        ' Box_registrar_compra
        ' 
        Box_registrar_compra.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Box_registrar_compra.Controls.Add(Graficos)
        Box_registrar_compra.Controls.Add(GroupBox2)
        Box_registrar_compra.Controls.Add(GroupBox4)
        Box_registrar_compra.Controls.Add(GroupBox5)
        Box_registrar_compra.Controls.Add(GroupBox3)
        Box_registrar_compra.Controls.Add(GroupBox6)
        Box_registrar_compra.Controls.Add(FF)
        Box_registrar_compra.Location = New Point(52, 12)
        Box_registrar_compra.Margin = New Padding(4, 3, 4, 3)
        Box_registrar_compra.Name = "Box_registrar_compra"
        Box_registrar_compra.Padding = New Padding(4, 3, 4, 3)
        Box_registrar_compra.Size = New Size(1002, 591)
        Box_registrar_compra.TabIndex = 394
        Box_registrar_compra.TabStop = False
        ' 
        ' Graficos
        ' 
        Graficos.BackColor = Color.LightBlue
        Graficos.FlatStyle = FlatStyle.Flat
        Graficos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Graficos.ForeColor = Color.Black
        Graficos.ImageAlign = ContentAlignment.MiddleLeft
        Graficos.Location = New Point(418, 306)
        Graficos.Margin = New Padding(0)
        Graficos.Name = "Graficos"
        Graficos.Size = New Size(108, 35)
        Graficos.TabIndex = 386
        Graficos.Text = "graficos"
        Graficos.TextImageRelation = TextImageRelation.ImageBeforeText
        Graficos.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox2.Controls.Add(Nvendidos)
        GroupBox2.Controls.Add(BProductoVendidos)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Tcategoria)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(617, 262)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(356, 160)
        GroupBox2.TabIndex = 390
        GroupBox2.TabStop = False
        GroupBox2.Text = "Productos Mas Vendidos"
        ' 
        ' Nvendidos
        ' 
        Nvendidos.Location = New Point(220, 84)
        Nvendidos.Name = "Nvendidos"
        Nvendidos.Size = New Size(121, 26)
        Nvendidos.TabIndex = 398
        ' 
        ' BProductoVendidos
        ' 
        BProductoVendidos.BackColor = Color.LightBlue
        BProductoVendidos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BProductoVendidos.ForeColor = Color.Black
        BProductoVendidos.Location = New Point(123, 115)
        BProductoVendidos.Name = "BProductoVendidos"
        BProductoVendidos.Size = New Size(108, 32)
        BProductoVendidos.TabIndex = 393
        BProductoVendidos.Text = "Generar "
        BProductoVendidos.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 18)
        Label4.TabIndex = 392
        Label4.Text = "Ingrese Tope"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 18)
        Label3.TabIndex = 391
        Label3.Text = "Ingrese Categoria"
        ' 
        ' Tcategoria
        ' 
        Tcategoria.DropDownStyle = ComboBoxStyle.DropDownList
        Tcategoria.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tcategoria.FormattingEnabled = True
        Tcategoria.Location = New Point(220, 38)
        Tcategoria.Name = "Tcategoria"
        Tcategoria.Size = New Size(121, 24)
        Tcategoria.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Bproductos)
        GroupBox4.Controls.Add(Nproducto)
        GroupBox4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(46, 347)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(331, 114)
        GroupBox4.TabIndex = 392
        GroupBox4.TabStop = False
        GroupBox4.Text = "Stock de Productos"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(17, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(172, 18)
        Label10.TabIndex = 397
        Label10.Text = "Ingrese Stock Minimo"
        ' 
        ' Bproductos
        ' 
        Bproductos.BackColor = Color.LightBlue
        Bproductos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bproductos.ForeColor = Color.Black
        Bproductos.Location = New Point(119, 76)
        Bproductos.Name = "Bproductos"
        Bproductos.Size = New Size(108, 32)
        Bproductos.TabIndex = 394
        Bproductos.Text = "Generar "
        Bproductos.UseVisualStyleBackColor = False
        ' 
        ' Nproducto
        ' 
        Nproducto.Location = New Point(211, 25)
        Nproducto.Name = "Nproducto"
        Nproducto.Size = New Size(100, 26)
        Nproducto.TabIndex = 396
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox5.Controls.Add(Nvendedor)
        GroupBox5.Controls.Add(Label9)
        GroupBox5.Controls.Add(BVendedor)
        GroupBox5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.ForeColor = Color.White
        GroupBox5.Location = New Point(46, 472)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(331, 105)
        GroupBox5.TabIndex = 395
        GroupBox5.TabStop = False
        GroupBox5.Text = "Mejor Vendedor"
        ' 
        ' Nvendedor
        ' 
        Nvendedor.Location = New Point(211, 29)
        Nvendedor.Name = "Nvendedor"
        Nvendedor.Size = New Size(100, 26)
        Nvendedor.TabIndex = 399
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 29)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 18)
        Label9.TabIndex = 396
        Label9.Text = "Ingrese Tope"
        ' 
        ' BVendedor
        ' 
        BVendedor.BackColor = Color.LightBlue
        BVendedor.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BVendedor.ForeColor = Color.Black
        BVendedor.Location = New Point(119, 67)
        BVendedor.Name = "BVendedor"
        BVendedor.Size = New Size(108, 32)
        BVendedor.TabIndex = 394
        BVendedor.Text = "Generar "
        BVendedor.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox3.Controls.Add(BVentas)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.Azure
        GroupBox3.Location = New Point(46, 262)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(331, 79)
        GroupBox3.TabIndex = 391
        GroupBox3.TabStop = False
        GroupBox3.Text = "Ventas"
        ' 
        ' BVentas
        ' 
        BVentas.BackColor = Color.LightBlue
        BVentas.FlatStyle = FlatStyle.Flat
        BVentas.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BVentas.ForeColor = Color.Black
        BVentas.ImageAlign = ContentAlignment.MiddleLeft
        BVentas.Location = New Point(109, 31)
        BVentas.Margin = New Padding(0)
        BVentas.Name = "BVentas"
        BVentas.Size = New Size(108, 35)
        BVentas.TabIndex = 385
        BVentas.Text = "Generar "
        BVentas.TextImageRelation = TextImageRelation.ImageBeforeText
        BVentas.UseVisualStyleBackColor = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox6.Controls.Add(Ncliente)
        GroupBox6.Controls.Add(BCliente)
        GroupBox6.Controls.Add(Label6)
        GroupBox6.Controls.Add(Label7)
        GroupBox6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.ForeColor = Color.White
        GroupBox6.Location = New Point(617, 428)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(356, 126)
        GroupBox6.TabIndex = 394
        GroupBox6.TabStop = False
        GroupBox6.Text = "Mejores Clientes"
        ' 
        ' Ncliente
        ' 
        Ncliente.Location = New Point(218, 36)
        Ncliente.Name = "Ncliente"
        Ncliente.Size = New Size(121, 26)
        Ncliente.TabIndex = 397
        ' 
        ' BCliente
        ' 
        BCliente.BackColor = Color.LightSteelBlue
        BCliente.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCliente.ForeColor = Color.Black
        BCliente.Location = New Point(124, 82)
        BCliente.Name = "BCliente"
        BCliente.Size = New Size(108, 32)
        BCliente.TabIndex = 393
        BCliente.Text = "Generar "
        BCliente.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(23, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 18)
        Label6.TabIndex = 392
        Label6.Text = "Ingrese Tope"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(23, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 18)
        Label7.TabIndex = 391
        ' 
        ' FF
        ' 
        FF.BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        FF.Controls.Add(Label8)
        FF.Controls.Add(Label2)
        FF.Controls.Add(fechaF)
        FF.Controls.Add(fechaI)
        FF.Controls.Add(MonthCalendar2)
        FF.Controls.Add(MonthCalendar1)
        FF.Controls.Add(Label5)
        FF.Controls.Add(Label1)
        FF.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FF.ForeColor = Color.Black
        FF.Location = New Point(46, 22)
        FF.Margin = New Padding(4, 3, 4, 3)
        FF.Name = "FF"
        FF.Padding = New Padding(4, 3, 4, 3)
        FF.Size = New Size(925, 228)
        FF.TabIndex = 393
        FF.TabStop = False
        FF.Text = "Información del reporte"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(679, 136)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 16)
        Label8.TabIndex = 391
        Label8.Text = "Fecha de Fin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(679, 64)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 16)
        Label2.TabIndex = 390
        Label2.Text = "Fecha de Inicio"
        ' 
        ' fechaF
        ' 
        fechaF.Enabled = False
        fechaF.Location = New Point(679, 155)
        fechaF.Name = "fechaF"
        fechaF.Size = New Size(173, 22)
        fechaF.TabIndex = 389
        ' 
        ' fechaI
        ' 
        fechaI.Enabled = False
        fechaI.Location = New Point(679, 83)
        fechaI.Name = "fechaI"
        fechaI.Size = New Size(173, 22)
        fechaI.TabIndex = 388
        ' 
        ' MonthCalendar2
        ' 
        MonthCalendar2.Location = New Point(337, 53)
        MonthCalendar2.Margin = New Padding(10)
        MonthCalendar2.Name = "MonthCalendar2"
        MonthCalendar2.TabIndex = 387
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(31, 53)
        MonthCalendar1.Margin = New Padding(10)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 386
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(337, 27)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 16)
        Label5.TabIndex = 5
        Label5.Text = "Fecha hasta:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(31, 27)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 16)
        Label1.TabIndex = 2
        Label1.Text = "Fecha desde:"
        ' 
        ' Panel_Reporte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(177), CByte(212), CByte(224))
        ClientSize = New Size(1098, 653)
        Controls.Add(Box_registrar_compra)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Panel_Reporte"
        StartPosition = FormStartPosition.CenterScreen
        Box_registrar_compra.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        FF.ResumeLayout(False)
        FF.PerformLayout()
        ResumeLayout(False)

    End Sub

    Private WithEvents Box_registrar_compra As GroupBox
    Friend WithEvents FF As GroupBox
    Private WithEvents BVentas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tcategoria As ComboBox
    Friend WithEvents BProductoVendidos As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bproductos As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BVendedor As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fechaF As TextBox
    Friend WithEvents fechaI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Nvendidos As TextBox
    Friend WithEvents Nproducto As TextBox
    Friend WithEvents Nvendedor As TextBox
    Friend WithEvents Ncliente As TextBox
    Private WithEvents Graficos As Button
End Class
