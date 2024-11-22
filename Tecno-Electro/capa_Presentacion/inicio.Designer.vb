<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        producto = New Label()
        Label2 = New Label()
        GroupBox5 = New GroupBox()
        GroupBox2 = New GroupBox()
        Nombre = New Label()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox6 = New GroupBox()
        GroupBox7 = New GroupBox()
        BCancelar = New Button()
        txtConfirmarContraseña = New TextBox()
        txtNuevaContraseña = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        btnCambiarContraseña = New Button()
        Button2 = New Button()
        BVentas = New Button()
        MonthCalendar2 = New MonthCalendar()
        Label4 = New Label()
        Label3 = New Label()
        txtFechaFin = New TextBox()
        txtFechaInicio = New TextBox()
        MonthCalendar1 = New MonthCalendar()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(552, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 252)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(6), CByte(30), CByte(71))
        GroupBox3.Controls.Add(producto)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(GroupBox5)
        GroupBox3.Location = New Point(839, 278)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(269, 325)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' producto
        ' 
        producto.AutoSize = True
        producto.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        producto.ForeColor = Color.White
        producto.Location = New Point(44, 286)
        producto.Name = "producto"
        producto.Size = New Size(79, 21)
        producto.TabIndex = 5
        producto.Text = "producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(44, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 21)
        Label2.TabIndex = 4
        Label2.Text = "Producto Mas Vendido"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), Image)
        GroupBox5.Location = New Point(19, 60)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(233, 214)
        GroupBox5.TabIndex = 3
        GroupBox5.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(6), CByte(30), CByte(71))
        GroupBox2.Controls.Add(Nombre)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Location = New Point(552, 278)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 325)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Nombre.ForeColor = Color.White
        Nombre.Location = New Point(49, 286)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(68, 21)
        Nombre.TabIndex = 6
        Nombre.Text = "nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(21, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 21)
        Label1.TabIndex = 3
        Label1.Text = "Mejor Vendedor del mes"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), Image)
        GroupBox4.Location = New Point(21, 60)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(229, 214)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.FromArgb(CByte(6), CByte(30), CByte(71))
        GroupBox6.Controls.Add(GroupBox7)
        GroupBox6.Controls.Add(Button2)
        GroupBox6.Controls.Add(BVentas)
        GroupBox6.Controls.Add(MonthCalendar2)
        GroupBox6.Controls.Add(Label4)
        GroupBox6.Controls.Add(Label3)
        GroupBox6.Controls.Add(txtFechaFin)
        GroupBox6.Controls.Add(txtFechaInicio)
        GroupBox6.Controls.Add(MonthCalendar1)
        GroupBox6.Location = New Point(12, 12)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(534, 591)
        GroupBox6.TabIndex = 3
        GroupBox6.TabStop = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(BCancelar)
        GroupBox7.Controls.Add(txtConfirmarContraseña)
        GroupBox7.Controls.Add(txtNuevaContraseña)
        GroupBox7.Controls.Add(Label6)
        GroupBox7.Controls.Add(Label5)
        GroupBox7.Controls.Add(btnCambiarContraseña)
        GroupBox7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.ForeColor = Color.White
        GroupBox7.Location = New Point(39, 393)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(462, 180)
        GroupBox7.TabIndex = 8
        GroupBox7.TabStop = False
        GroupBox7.Text = "Cambiar Contraseña"
        ' 
        ' BCancelar
        ' 
        BCancelar.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BCancelar.Location = New Point(328, 124)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(111, 40)
        BCancelar.TabIndex = 6
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmarContraseña
        ' 
        txtConfirmarContraseña.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtConfirmarContraseña.Location = New Point(181, 83)
        txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        txtConfirmarContraseña.Size = New Size(207, 25)
        txtConfirmarContraseña.TabIndex = 4
        ' 
        ' txtNuevaContraseña
        ' 
        txtNuevaContraseña.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNuevaContraseña.Location = New Point(181, 46)
        txtNuevaContraseña.Name = "txtNuevaContraseña"
        txtNuevaContraseña.Size = New Size(207, 25)
        txtNuevaContraseña.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 17)
        Label6.TabIndex = 2
        Label6.Text = "Confirmar Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 17)
        Label5.TabIndex = 1
        Label5.Text = "Nueva Contraseña"
        ' 
        ' btnCambiarContraseña
        ' 
        btnCambiarContraseña.BackColor = Color.LightSteelBlue
        btnCambiarContraseña.ForeColor = Color.Black
        btnCambiarContraseña.Location = New Point(49, 124)
        btnCambiarContraseña.Name = "btnCambiarContraseña"
        btnCambiarContraseña.Size = New Size(172, 40)
        btnCambiarContraseña.TabIndex = 0
        btnCambiarContraseña.Text = "Cambiar Contraseña"
        btnCambiarContraseña.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSteelBlue
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(39, 326)
        Button2.Name = "Button2"
        Button2.Size = New Size(462, 61)
        Button2.TabIndex = 7
        Button2.Text = "Cerrar Caja"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BVentas
        ' 
        BVentas.BackColor = Color.LightSteelBlue
        BVentas.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BVentas.Location = New Point(39, 247)
        BVentas.Name = "BVentas"
        BVentas.Size = New Size(462, 62)
        BVentas.TabIndex = 6
        BVentas.Text = "Ventas Realizadas"
        BVentas.UseVisualStyleBackColor = False
        ' 
        ' MonthCalendar2
        ' 
        MonthCalendar2.Location = New Point(272, 28)
        MonthCalendar2.Name = "MonthCalendar2"
        MonthCalendar2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(272, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 4
        Label4.Text = "Fecha Fin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(12, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 3
        Label3.Text = "Fecha Inicio"
        ' 
        ' txtFechaFin
        ' 
        txtFechaFin.Enabled = False
        txtFechaFin.Location = New Point(367, 211)
        txtFechaFin.Name = "txtFechaFin"
        txtFechaFin.Size = New Size(134, 23)
        txtFechaFin.TabIndex = 2
        ' 
        ' txtFechaInicio
        ' 
        txtFechaInicio.Enabled = False
        txtFechaInicio.Location = New Point(114, 207)
        txtFechaInicio.Name = "txtFechaInicio"
        txtFechaInicio.Size = New Size(134, 23)
        txtFechaInicio.TabIndex = 1
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(12, 28)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(157), CByte(190), CByte(209))
        ClientSize = New Size(1370, 622)
        ControlBox = False
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ControlText
        MaximizeBox = False
        MinimizeBox = False
        Name = "inicio"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Nombre As Label
    Friend WithEvents producto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents BVentas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents txtNuevaContraseña As TextBox
    Friend WithEvents BCancelar As Button
End Class
