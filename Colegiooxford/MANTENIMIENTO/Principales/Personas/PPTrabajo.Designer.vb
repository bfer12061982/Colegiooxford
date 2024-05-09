<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPTrabajo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txttrabaja = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRABAJO = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANCIEROS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.Txtprofesionoficio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtgradoacademico = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtpuestoocupa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBmunicipio = New System.Windows.Forms.ComboBox()
        Me.CBdepartamento = New System.Windows.Forms.ComboBox()
        Me.CBpais = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PTdepartamento = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtcodigopostal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtzona = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtlugartrabajo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBno = New System.Windows.Forms.RadioButton()
        Me.RBsi = New System.Windows.Forms.RadioButton()
        Me.DTfechainicio = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtzona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Txttrabaja)
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.txt_ruta)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'Txttrabaja
        '
        Me.Txttrabaja.Location = New System.Drawing.Point(26, 401)
        Me.Txttrabaja.Name = "Txttrabaja"
        Me.Txttrabaja.Size = New System.Drawing.Size(100, 23)
        Me.Txttrabaja.TabIndex = 62
        Me.Txttrabaja.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.TRABAJO, Me.FINANCIEROS, Me.CALCULOMORA, Me.CONTRATOS})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 104)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GENERAL
        '
        Me.GENERAL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.GENERAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GENERAL.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.GENERAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GENERAL.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.GENERAL.Name = "GENERAL"
        Me.GENERAL.Size = New System.Drawing.Size(85, 20)
        Me.GENERAL.Text = "GENERAL"
        '
        'TRABAJO
        '
        Me.TRABAJO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TRABAJO.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.TRABAJO.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.TRABAJO.Name = "TRABAJO"
        Me.TRABAJO.Size = New System.Drawing.Size(94, 20)
        Me.TRABAJO.Text = "TRABAJOS"
        '
        'FINANCIEROS
        '
        Me.FINANCIEROS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FINANCIEROS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.FINANCIEROS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.FINANCIEROS.Name = "FINANCIEROS"
        Me.FINANCIEROS.Size = New System.Drawing.Size(112, 20)
        Me.FINANCIEROS.Text = "ADICIONALES"
        '
        'CALCULOMORA
        '
        Me.CALCULOMORA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CALCULOMORA.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.CALCULOMORA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CALCULOMORA.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CALCULOMORA.Name = "CALCULOMORA"
        Me.CALCULOMORA.Size = New System.Drawing.Size(144, 20)
        Me.CALCULOMORA.Text = "FAMILIA ASOCIADA"
        '
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(135, 20)
        Me.CONTRATOS.Text = "RETIRA ALUMNOS"
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(26, 372)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(100, 23)
        Me.txt_ruta.TabIndex = 61
        Me.txt_ruta.Visible = False
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Location = New System.Drawing.Point(26, 345)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(100, 23)
        Me.Txtcodigo.TabIndex = 60
        Me.Txtcodigo.Visible = False
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = CType(resources.GetObject("Btnregistrar.Image"), System.Drawing.Image)
        Me.Btnregistrar.Location = New System.Drawing.Point(9, 189)
        Me.Btnregistrar.Name = "Btnregistrar"
        Me.Btnregistrar.Size = New System.Drawing.Size(123, 45)
        Me.Btnregistrar.TabIndex = 59
        Me.Btnregistrar.Text = "GUARDAR"
        Me.Btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnregistrar.UseVisualStyleBackColor = False
        '
        'Btneditar
        '
        Me.Btneditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btneditar.FlatAppearance.BorderSize = 2
        Me.Btneditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btneditar.Image = CType(resources.GetObject("Btneditar.Image"), System.Drawing.Image)
        Me.Btneditar.Location = New System.Drawing.Point(9, 138)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(123, 45)
        Me.Btneditar.TabIndex = 57
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btneditar.UseVisualStyleBackColor = False
        '
        'GBDatos
        '
        Me.GBDatos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBDatos.Controls.Add(Me.DTfechainicio)
        Me.GBDatos.Controls.Add(Me.Txtprofesionoficio)
        Me.GBDatos.Controls.Add(Me.Label12)
        Me.GBDatos.Controls.Add(Me.Txtgradoacademico)
        Me.GBDatos.Controls.Add(Me.Label9)
        Me.GBDatos.Controls.Add(Me.Txtpuestoocupa)
        Me.GBDatos.Controls.Add(Me.Label3)
        Me.GBDatos.Controls.Add(Me.Label15)
        Me.GBDatos.Controls.Add(Me.Txtcorreo)
        Me.GBDatos.Controls.Add(Me.Label2)
        Me.GBDatos.Controls.Add(Me.Txttelefono)
        Me.GBDatos.Controls.Add(Me.Label11)
        Me.GBDatos.Controls.Add(Me.CBmunicipio)
        Me.GBDatos.Controls.Add(Me.CBdepartamento)
        Me.GBDatos.Controls.Add(Me.CBpais)
        Me.GBDatos.Controls.Add(Me.Label10)
        Me.GBDatos.Controls.Add(Me.PTdepartamento)
        Me.GBDatos.Controls.Add(Me.Label8)
        Me.GBDatos.Controls.Add(Me.Label7)
        Me.GBDatos.Controls.Add(Me.Txtcodigopostal)
        Me.GBDatos.Controls.Add(Me.Label13)
        Me.GBDatos.Controls.Add(Me.Label6)
        Me.GBDatos.Controls.Add(Me.Txtzona)
        Me.GBDatos.Controls.Add(Me.Label5)
        Me.GBDatos.Controls.Add(Me.Txtdireccion)
        Me.GBDatos.Controls.Add(Me.Label4)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.Txtlugartrabajo)
        Me.GBDatos.Controls.Add(Me.GroupBox3)
        Me.GBDatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBDatos.Location = New System.Drawing.Point(3, 4)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(842, 491)
        Me.GBDatos.TabIndex = 64
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "MANTENIMIENTO /Principales/Personas/Trabajo"
        '
        'Txtprofesionoficio
        '
        Me.Txtprofesionoficio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtprofesionoficio.Location = New System.Drawing.Point(24, 432)
        Me.Txtprofesionoficio.Name = "Txtprofesionoficio"
        Me.Txtprofesionoficio.Size = New System.Drawing.Size(812, 23)
        Me.Txtprofesionoficio.TabIndex = 157
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(21, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Profesión u oficio"
        '
        'Txtgradoacademico
        '
        Me.Txtgradoacademico.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtgradoacademico.Location = New System.Drawing.Point(24, 387)
        Me.Txtgradoacademico.Name = "Txtgradoacademico"
        Me.Txtgradoacademico.Size = New System.Drawing.Size(812, 23)
        Me.Txtgradoacademico.TabIndex = 155
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(21, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Grado académico"
        '
        'Txtpuestoocupa
        '
        Me.Txtpuestoocupa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtpuestoocupa.Location = New System.Drawing.Point(24, 346)
        Me.Txtpuestoocupa.Name = "Txtpuestoocupa"
        Me.Txtpuestoocupa.Size = New System.Drawing.Size(812, 23)
        Me.Txtpuestoocupa.TabIndex = 153
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(21, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Puesto que ocupa"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(21, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 15)
        Me.Label15.TabIndex = 152
        Me.Label15.Text = "Fecha Inicio"
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcorreo.Location = New System.Drawing.Point(333, 251)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(503, 23)
        Me.Txtcorreo.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(330, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Correo Electrónico"
        '
        'Txttelefono
        '
        Me.Txttelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txttelefono.Location = New System.Drawing.Point(24, 251)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(303, 23)
        Me.Txttelefono.TabIndex = 147
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(21, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Telefono trabajo"
        '
        'CBmunicipio
        '
        Me.CBmunicipio.FormattingEnabled = True
        Me.CBmunicipio.Location = New System.Drawing.Point(604, 210)
        Me.CBmunicipio.Name = "CBmunicipio"
        Me.CBmunicipio.Size = New System.Drawing.Size(232, 23)
        Me.CBmunicipio.TabIndex = 142
        '
        'CBdepartamento
        '
        Me.CBdepartamento.FormattingEnabled = True
        Me.CBdepartamento.Location = New System.Drawing.Point(333, 210)
        Me.CBdepartamento.Name = "CBdepartamento"
        Me.CBdepartamento.Size = New System.Drawing.Size(232, 23)
        Me.CBdepartamento.TabIndex = 141
        '
        'CBpais
        '
        Me.CBpais.FormattingEnabled = True
        Me.CBpais.Location = New System.Drawing.Point(24, 210)
        Me.CBpais.Name = "CBpais"
        Me.CBpais.Size = New System.Drawing.Size(303, 23)
        Me.CBpais.TabIndex = 140
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(601, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Municipio"
        '
        'PTdepartamento
        '
        Me.PTdepartamento.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PTdepartamento.Location = New System.Drawing.Point(565, 210)
        Me.PTdepartamento.Name = "PTdepartamento"
        Me.PTdepartamento.Size = New System.Drawing.Size(27, 23)
        Me.PTdepartamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTdepartamento.TabIndex = 145
        Me.PTdepartamento.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(330, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(21, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Pais"
        '
        'Txtcodigopostal
        '
        Me.Txtcodigopostal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcodigopostal.Location = New System.Drawing.Point(604, 150)
        Me.Txtcodigopostal.Name = "Txtcodigopostal"
        Me.Txtcodigopostal.Size = New System.Drawing.Size(232, 23)
        Me.Txtcodigopostal.TabIndex = 135
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(601, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Codigo Postal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(561, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Zona"
        '
        'Txtzona
        '
        Me.Txtzona.Location = New System.Drawing.Point(565, 149)
        Me.Txtzona.Name = "Txtzona"
        Me.Txtzona.Size = New System.Drawing.Size(27, 23)
        Me.Txtzona.TabIndex = 134
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(111, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 11)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "(Calle, Avenida, boulevard, carrertera, km, # casa, #departamento, nivel o piso)"
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtdireccion.Location = New System.Drawing.Point(24, 149)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(541, 23)
        Me.Txtdireccion.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Direccion trabajo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lugar de Trabajo"
        '
        'Txtlugartrabajo
        '
        Me.Txtlugartrabajo.Location = New System.Drawing.Point(24, 101)
        Me.Txtlugartrabajo.Name = "Txtlugartrabajo"
        Me.Txtlugartrabajo.Size = New System.Drawing.Size(541, 23)
        Me.Txtlugartrabajo.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBno)
        Me.GroupBox3.Controls.Add(Me.RBsi)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 49)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trabaja"
        '
        'RBno
        '
        Me.RBno.AutoSize = True
        Me.RBno.Location = New System.Drawing.Point(56, 22)
        Me.RBno.Name = "RBno"
        Me.RBno.Size = New System.Drawing.Size(41, 19)
        Me.RBno.TabIndex = 2
        Me.RBno.TabStop = True
        Me.RBno.Text = "No"
        Me.RBno.UseVisualStyleBackColor = True
        '
        'RBsi
        '
        Me.RBsi.AutoSize = True
        Me.RBsi.Location = New System.Drawing.Point(6, 22)
        Me.RBsi.Name = "RBsi"
        Me.RBsi.Size = New System.Drawing.Size(35, 19)
        Me.RBsi.TabIndex = 1
        Me.RBsi.TabStop = True
        Me.RBsi.Text = "Si"
        Me.RBsi.UseVisualStyleBackColor = True
        '
        'DTfechainicio
        '
        Me.DTfechainicio.Location = New System.Drawing.Point(24, 299)
        Me.DTfechainicio.Mask = "00/00/0000"
        Me.DTfechainicio.Name = "DTfechainicio"
        Me.DTfechainicio.Size = New System.Drawing.Size(146, 23)
        Me.DTfechainicio.TabIndex = 180
        Me.DTfechainicio.ValidatingType = GetType(Date)
        '
        'PPTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PPTrabajo"
        Me.Text = "MPtrabajoPe"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtzona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txttrabaja As TextBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents TRABAJO As ToolStripMenuItem
    Friend WithEvents FINANCIEROS As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents txt_ruta As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents GBDatos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtlugartrabajo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RBno As RadioButton
    Friend WithEvents RBsi As RadioButton
    Friend WithEvents Txtcodigopostal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtzona As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBmunicipio As ComboBox
    Friend WithEvents CBdepartamento As ComboBox
    Friend WithEvents CBpais As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PTdepartamento As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txttelefono As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtprofesionoficio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtgradoacademico As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtpuestoocupa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DTfechainicio As MaskedTextBox
End Class
