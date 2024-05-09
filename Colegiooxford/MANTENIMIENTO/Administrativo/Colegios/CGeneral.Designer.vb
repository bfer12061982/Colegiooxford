<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CGeneral))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACADEMICOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANCIEROS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txtinscripcionh = New System.Windows.Forms.TextBox()
        Me.Txttipoalumno = New System.Windows.Forms.TextBox()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btnbuscarimagen = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtnombrecorto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtzona = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcodigopostal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtfax = New System.Windows.Forms.TextBox()
        Me.Lblmensaje1 = New System.Windows.Forms.Label()
        Me.Lblmensaje2 = New System.Windows.Forms.Label()
        Me.GBdatosg1 = New System.Windows.Forms.GroupBox()
        Me.Txtdepartamento = New System.Windows.Forms.TextBox()
        Me.Dtfechaautorizacion = New System.Windows.Forms.MaskedTextBox()
        Me.Cmbmunicipio = New System.Windows.Forms.ComboBox()
        Me.Cmbdepartamento = New System.Windows.Forms.ComboBox()
        Me.CBpais = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtreligion = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rbambos = New System.Windows.Forms.RadioButton()
        Me.Rbsiguiente = New System.Windows.Forms.RadioButton()
        Me.Rbactual = New System.Windows.Forms.RadioButton()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Txtresolucion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Txtcentrocosto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Txtcoordinador = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txtdirector = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Rbmixto = New System.Windows.Forms.RadioButton()
        Me.Rbmujeres = New System.Windows.Forms.RadioButton()
        Me.Rbhombres = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Cmbmmunicipio = New System.Windows.Forms.ComboBox()
        Me.Cmbmdepartamento = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txtmatriculas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GBimagen = New System.Windows.Forms.GroupBox()
        Me.PTimagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBdatosg1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBimagen.SuspendLayout()
        CType(Me.PTimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Txtinscripcionh)
        Me.GroupBox2.Controls.Add(Me.Txttipoalumno)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btnbuscarimagen)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btnnuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.ACADEMICOS, Me.FINANCIEROS, Me.CALCULOMORA, Me.CONTRATOS})
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
        Me.GENERAL.Image = CType(resources.GetObject("GENERAL.Image"), System.Drawing.Image)
        Me.GENERAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GENERAL.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.GENERAL.Name = "GENERAL"
        Me.GENERAL.Size = New System.Drawing.Size(85, 20)
        Me.GENERAL.Text = "GENERAL"
        '
        'ACADEMICOS
        '
        Me.ACADEMICOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ACADEMICOS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ACADEMICOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.ACADEMICOS.Name = "ACADEMICOS"
        Me.ACADEMICOS.Size = New System.Drawing.Size(111, 20)
        Me.ACADEMICOS.Text = "ACADEMICOS"
        '
        'FINANCIEROS
        '
        Me.FINANCIEROS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FINANCIEROS.Image = CType(resources.GetObject("FINANCIEROS.Image"), System.Drawing.Image)
        Me.FINANCIEROS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.FINANCIEROS.Name = "FINANCIEROS"
        Me.FINANCIEROS.Size = New System.Drawing.Size(111, 20)
        Me.FINANCIEROS.Text = "FINANCIEROS"
        '
        'CALCULOMORA
        '
        Me.CALCULOMORA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CALCULOMORA.Image = CType(resources.GetObject("CALCULOMORA.Image"), System.Drawing.Image)
        Me.CALCULOMORA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CALCULOMORA.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CALCULOMORA.Name = "CALCULOMORA"
        Me.CALCULOMORA.Size = New System.Drawing.Size(124, 20)
        Me.CALCULOMORA.Text = "CALCULO MORA"
        '
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = CType(resources.GetObject("CONTRATOS.Image"), System.Drawing.Image)
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(104, 20)
        Me.CONTRATOS.Text = "CONTRATOS"
        '
        'Txtinscripcionh
        '
        Me.Txtinscripcionh.Location = New System.Drawing.Point(24, 420)
        Me.Txtinscripcionh.Name = "Txtinscripcionh"
        Me.Txtinscripcionh.Size = New System.Drawing.Size(100, 23)
        Me.Txtinscripcionh.TabIndex = 61
        Me.Txtinscripcionh.Visible = False
        '
        'Txttipoalumno
        '
        Me.Txttipoalumno.Location = New System.Drawing.Point(15, 391)
        Me.Txttipoalumno.Name = "Txttipoalumno"
        Me.Txttipoalumno.Size = New System.Drawing.Size(100, 23)
        Me.Txttipoalumno.TabIndex = 60
        Me.Txttipoalumno.Visible = False
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = CType(resources.GetObject("Btnregistrar.Image"), System.Drawing.Image)
        Me.Btnregistrar.Location = New System.Drawing.Point(14, 291)
        Me.Btnregistrar.Name = "Btnregistrar"
        Me.Btnregistrar.Size = New System.Drawing.Size(123, 45)
        Me.Btnregistrar.TabIndex = 59
        Me.Btnregistrar.Text = "GUARDAR"
        Me.Btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnregistrar.UseVisualStyleBackColor = False
        '
        'Btnbuscarimagen
        '
        Me.Btnbuscarimagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnbuscarimagen.FlatAppearance.BorderSize = 2
        Me.Btnbuscarimagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnbuscarimagen.Image = CType(resources.GetObject("Btnbuscarimagen.Image"), System.Drawing.Image)
        Me.Btnbuscarimagen.Location = New System.Drawing.Point(14, 240)
        Me.Btnbuscarimagen.Name = "Btnbuscarimagen"
        Me.Btnbuscarimagen.Size = New System.Drawing.Size(123, 45)
        Me.Btnbuscarimagen.TabIndex = 58
        Me.Btnbuscarimagen.Text = "BUSCAR"
        Me.Btnbuscarimagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnbuscarimagen.UseVisualStyleBackColor = False
        '
        'Btneditar
        '
        Me.Btneditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btneditar.FlatAppearance.BorderSize = 2
        Me.Btneditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btneditar.Image = CType(resources.GetObject("Btneditar.Image"), System.Drawing.Image)
        Me.Btneditar.Location = New System.Drawing.Point(14, 189)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(123, 45)
        Me.Btneditar.TabIndex = 57
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btneditar.UseVisualStyleBackColor = False
        '
        'Btnnuevo
        '
        Me.Btnnuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnnuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnnuevo.Image = CType(resources.GetObject("Btnnuevo.Image"), System.Drawing.Image)
        Me.Btnnuevo.Location = New System.Drawing.Point(14, 138)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(123, 45)
        Me.Btnnuevo.TabIndex = 56
        Me.Btnnuevo.Text = "NUEVO"
        Me.Btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnnuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo"
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcodigo.Location = New System.Drawing.Point(9, 32)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(106, 23)
        Me.Txtcodigo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(140, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre"
        '
        'Txtnombre
        '
        Me.Txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtnombre.Location = New System.Drawing.Point(143, 32)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(506, 23)
        Me.Txtnombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre corto"
        '
        'Txtnombrecorto
        '
        Me.Txtnombrecorto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtnombrecorto.Location = New System.Drawing.Point(9, 74)
        Me.Txtnombrecorto.Name = "Txtnombrecorto"
        Me.Txtnombrecorto.Size = New System.Drawing.Size(276, 23)
        Me.Txtnombrecorto.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(288, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Religion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección"
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtdireccion.Location = New System.Drawing.Point(9, 118)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(449, 23)
        Me.Txtdireccion.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(474, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Zona"
        '
        'Txtzona
        '
        Me.Txtzona.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtzona.Location = New System.Drawing.Point(477, 118)
        Me.Txtzona.Name = "Txtzona"
        Me.Txtzona.Size = New System.Drawing.Size(43, 23)
        Me.Txtzona.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(532, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Codigo postal"
        '
        'Txtcodigopostal
        '
        Me.Txtcodigopostal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcodigopostal.Location = New System.Drawing.Point(535, 118)
        Me.Txtcodigopostal.Name = "Txtcodigopostal"
        Me.Txtcodigopostal.Size = New System.Drawing.Size(114, 23)
        Me.Txtcodigopostal.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(6, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(319, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANTENIMIENTO /Administrativo/ Colegio / General  "
        '
        'Txttelefono
        '
        Me.Txttelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txttelefono.Location = New System.Drawing.Point(9, 201)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(255, 23)
        Me.Txttelefono.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(270, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 15)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Fax"
        '
        'Txtfax
        '
        Me.Txtfax.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtfax.Location = New System.Drawing.Point(270, 200)
        Me.Txtfax.Name = "Txtfax"
        Me.Txtfax.Size = New System.Drawing.Size(185, 23)
        Me.Txtfax.TabIndex = 65
        '
        'Lblmensaje1
        '
        Me.Lblmensaje1.AutoSize = True
        Me.Lblmensaje1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lblmensaje1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lblmensaje1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Lblmensaje1.Location = New System.Drawing.Point(267, 10)
        Me.Lblmensaje1.Name = "Lblmensaje1"
        Me.Lblmensaje1.Size = New System.Drawing.Size(0, 19)
        Me.Lblmensaje1.TabIndex = 83
        '
        'Lblmensaje2
        '
        Me.Lblmensaje2.AutoSize = True
        Me.Lblmensaje2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lblmensaje2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lblmensaje2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Lblmensaje2.Location = New System.Drawing.Point(285, 10)
        Me.Lblmensaje2.Name = "Lblmensaje2"
        Me.Lblmensaje2.Size = New System.Drawing.Size(0, 19)
        Me.Lblmensaje2.TabIndex = 84
        '
        'GBdatosg1
        '
        Me.GBdatosg1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdatosg1.Controls.Add(Me.Txtdepartamento)
        Me.GBdatosg1.Controls.Add(Me.Dtfechaautorizacion)
        Me.GBdatosg1.Controls.Add(Me.Cmbmunicipio)
        Me.GBdatosg1.Controls.Add(Me.Cmbdepartamento)
        Me.GBdatosg1.Controls.Add(Me.CBpais)
        Me.GBdatosg1.Controls.Add(Me.Label10)
        Me.GBdatosg1.Controls.Add(Me.Label9)
        Me.GBdatosg1.Controls.Add(Me.Label11)
        Me.GBdatosg1.Controls.Add(Me.Txtreligion)
        Me.GBdatosg1.Controls.Add(Me.GroupBox5)
        Me.GBdatosg1.Controls.Add(Me.txt_ruta)
        Me.GBdatosg1.Controls.Add(Me.Txtresolucion)
        Me.GBdatosg1.Controls.Add(Me.Label23)
        Me.GBdatosg1.Controls.Add(Me.Label22)
        Me.GBdatosg1.Controls.Add(Me.Txtcentrocosto)
        Me.GBdatosg1.Controls.Add(Me.Label20)
        Me.GBdatosg1.Controls.Add(Me.Txtcoordinador)
        Me.GBdatosg1.Controls.Add(Me.Label19)
        Me.GBdatosg1.Controls.Add(Me.Txtdirector)
        Me.GBdatosg1.Controls.Add(Me.Label18)
        Me.GBdatosg1.Controls.Add(Me.Rbmixto)
        Me.GBdatosg1.Controls.Add(Me.Rbmujeres)
        Me.GBdatosg1.Controls.Add(Me.Rbhombres)
        Me.GBdatosg1.Controls.Add(Me.Label17)
        Me.GBdatosg1.Controls.Add(Me.Cmbmmunicipio)
        Me.GBdatosg1.Controls.Add(Me.Cmbmdepartamento)
        Me.GBdatosg1.Controls.Add(Me.Label15)
        Me.GBdatosg1.Controls.Add(Me.Label16)
        Me.GBdatosg1.Controls.Add(Me.Txtmatriculas)
        Me.GBdatosg1.Controls.Add(Me.Label14)
        Me.GBdatosg1.Controls.Add(Me.GBimagen)
        Me.GBdatosg1.Controls.Add(Me.Lblmensaje2)
        Me.GBdatosg1.Controls.Add(Me.Lblmensaje1)
        Me.GBdatosg1.Controls.Add(Me.Txtfax)
        Me.GBdatosg1.Controls.Add(Me.Label13)
        Me.GBdatosg1.Controls.Add(Me.Txttelefono)
        Me.GBdatosg1.Controls.Add(Me.Label1)
        Me.GBdatosg1.Controls.Add(Me.Label12)
        Me.GBdatosg1.Controls.Add(Me.Txtcodigopostal)
        Me.GBdatosg1.Controls.Add(Me.Label8)
        Me.GBdatosg1.Controls.Add(Me.Txtzona)
        Me.GBdatosg1.Controls.Add(Me.Label7)
        Me.GBdatosg1.Controls.Add(Me.Txtdireccion)
        Me.GBdatosg1.Controls.Add(Me.Label6)
        Me.GBdatosg1.Controls.Add(Me.Label5)
        Me.GBdatosg1.Controls.Add(Me.Txtnombrecorto)
        Me.GBdatosg1.Controls.Add(Me.Label4)
        Me.GBdatosg1.Controls.Add(Me.Txtnombre)
        Me.GBdatosg1.Controls.Add(Me.Label3)
        Me.GBdatosg1.Controls.Add(Me.Txtcodigo)
        Me.GBdatosg1.Controls.Add(Me.Label2)
        Me.GBdatosg1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBdatosg1.Location = New System.Drawing.Point(3, 4)
        Me.GBdatosg1.Name = "GBdatosg1"
        Me.GBdatosg1.Size = New System.Drawing.Size(842, 491)
        Me.GBdatosg1.TabIndex = 58
        Me.GBdatosg1.TabStop = False
        Me.GBdatosg1.Text = "COLEGIOS / GENERAL"
        '
        'Txtdepartamento
        '
        Me.Txtdepartamento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtdepartamento.Location = New System.Drawing.Point(239, 159)
        Me.Txtdepartamento.Name = "Txtdepartamento"
        Me.Txtdepartamento.Size = New System.Drawing.Size(216, 23)
        Me.Txtdepartamento.TabIndex = 133
        Me.Txtdepartamento.Visible = False
        '
        'Dtfechaautorizacion
        '
        Me.Dtfechaautorizacion.Location = New System.Drawing.Point(385, 374)
        Me.Dtfechaautorizacion.Mask = "00/00/0000"
        Me.Dtfechaautorizacion.Name = "Dtfechaautorizacion"
        Me.Dtfechaautorizacion.Size = New System.Drawing.Size(200, 23)
        Me.Dtfechaautorizacion.TabIndex = 132
        Me.Dtfechaautorizacion.ValidatingType = GetType(Date)
        '
        'Cmbmunicipio
        '
        Me.Cmbmunicipio.FormattingEnabled = True
        Me.Cmbmunicipio.Location = New System.Drawing.Point(463, 159)
        Me.Cmbmunicipio.Name = "Cmbmunicipio"
        Me.Cmbmunicipio.Size = New System.Drawing.Size(186, 23)
        Me.Cmbmunicipio.TabIndex = 127
        '
        'Cmbdepartamento
        '
        Me.Cmbdepartamento.FormattingEnabled = True
        Me.Cmbdepartamento.Items.AddRange(New Object() {"Alta Verapaz", "Baja Verapaz", "Chimaltenango", "Chiquimula", "Petén", "El Progreso", "Quiché", "Escuintla", "Guatemala", "Huehuetenango", "Izabal", "Jalapa", "Jutiapa", "Quetzaltenango", "Retalhuleu", "Sacatepéquez", "San Marcos", "Santa Rosa", "Sololá", "Suchitepéquez", "Totonicapán", "Zacapa"})
        Me.Cmbdepartamento.Location = New System.Drawing.Point(239, 159)
        Me.Cmbdepartamento.Name = "Cmbdepartamento"
        Me.Cmbdepartamento.Size = New System.Drawing.Size(186, 23)
        Me.Cmbdepartamento.TabIndex = 126
        '
        'CBpais
        '
        Me.CBpais.FormattingEnabled = True
        Me.CBpais.Location = New System.Drawing.Point(11, 159)
        Me.CBpais.Name = "CBpais"
        Me.CBpais.Size = New System.Drawing.Size(222, 23)
        Me.CBpais.TabIndex = 125
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(461, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Municipio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(234, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Departamento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(8, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 15)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Pais"
        '
        'Txtreligion
        '
        Me.Txtreligion.FormattingEnabled = True
        Me.Txtreligion.Items.AddRange(New Object() {"Envangélica(o)", "Católica(o)", "Otras"})
        Me.Txtreligion.Location = New System.Drawing.Point(291, 76)
        Me.Txtreligion.Name = "Txtreligion"
        Me.Txtreligion.Size = New System.Drawing.Size(259, 23)
        Me.Txtreligion.TabIndex = 109
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Rbambos)
        Me.GroupBox5.Controls.Add(Me.Rbsiguiente)
        Me.GroupBox5.Controls.Add(Me.Rbactual)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 400)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 43)
        Me.GroupBox5.TabIndex = 108
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Inscripciones habilitada para ciclo"
        '
        'Rbambos
        '
        Me.Rbambos.AutoSize = True
        Me.Rbambos.Location = New System.Drawing.Point(246, 22)
        Me.Rbambos.Name = "Rbambos"
        Me.Rbambos.Size = New System.Drawing.Size(63, 19)
        Me.Rbambos.TabIndex = 82
        Me.Rbambos.TabStop = True
        Me.Rbambos.Text = "Ambos"
        Me.Rbambos.UseVisualStyleBackColor = True
        '
        'Rbsiguiente
        '
        Me.Rbsiguiente.AutoSize = True
        Me.Rbsiguiente.Location = New System.Drawing.Point(142, 22)
        Me.Rbsiguiente.Name = "Rbsiguiente"
        Me.Rbsiguiente.Size = New System.Drawing.Size(75, 19)
        Me.Rbsiguiente.TabIndex = 81
        Me.Rbsiguiente.TabStop = True
        Me.Rbsiguiente.Text = "Siguiente"
        Me.Rbsiguiente.UseVisualStyleBackColor = True
        '
        'Rbactual
        '
        Me.Rbactual.AutoSize = True
        Me.Rbactual.Location = New System.Drawing.Point(40, 22)
        Me.Rbactual.Name = "Rbactual"
        Me.Rbactual.Size = New System.Drawing.Size(59, 19)
        Me.Rbactual.TabIndex = 80
        Me.Rbactual.TabStop = True
        Me.Rbactual.Text = "Actual"
        Me.Rbactual.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ruta.Location = New System.Drawing.Point(692, 200)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(114, 23)
        Me.txt_ruta.TabIndex = 107
        '
        'Txtresolucion
        '
        Me.Txtresolucion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtresolucion.Location = New System.Drawing.Point(600, 374)
        Me.Txtresolucion.Name = "Txtresolucion"
        Me.Txtresolucion.Size = New System.Drawing.Size(138, 23)
        Me.Txtresolucion.TabIndex = 95
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(597, 358)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 15)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "No. Resolución"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(382, 356)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 15)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "Fecha Autorización"
        '
        'Txtcentrocosto
        '
        Me.Txtcentrocosto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcentrocosto.Location = New System.Drawing.Point(9, 374)
        Me.Txtcentrocosto.Name = "Txtcentrocosto"
        Me.Txtcentrocosto.Size = New System.Drawing.Size(370, 23)
        Me.Txtcentrocosto.TabIndex = 104
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(6, 358)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 15)
        Me.Label20.TabIndex = 103
        Me.Label20.Text = "Centro de Costo"
        '
        'Txtcoordinador
        '
        Me.Txtcoordinador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtcoordinador.Location = New System.Drawing.Point(385, 332)
        Me.Txtcoordinador.Name = "Txtcoordinador"
        Me.Txtcoordinador.Size = New System.Drawing.Size(353, 23)
        Me.Txtcoordinador.TabIndex = 102
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(382, 316)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 15)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "Coordinador General"
        '
        'Txtdirector
        '
        Me.Txtdirector.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtdirector.Location = New System.Drawing.Point(9, 332)
        Me.Txtdirector.Name = "Txtdirector"
        Me.Txtdirector.Size = New System.Drawing.Size(370, 23)
        Me.Txtdirector.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(6, 316)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(224, 15)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Director(a) General / Representante Legal"
        '
        'Rbmixto
        '
        Me.Rbmixto.AutoSize = True
        Me.Rbmixto.Location = New System.Drawing.Point(257, 296)
        Me.Rbmixto.Name = "Rbmixto"
        Me.Rbmixto.Size = New System.Drawing.Size(56, 19)
        Me.Rbmixto.TabIndex = 98
        Me.Rbmixto.TabStop = True
        Me.Rbmixto.Text = "Mixto"
        Me.Rbmixto.UseVisualStyleBackColor = True
        '
        'Rbmujeres
        '
        Me.Rbmujeres.AutoSize = True
        Me.Rbmujeres.Location = New System.Drawing.Point(153, 296)
        Me.Rbmujeres.Name = "Rbmujeres"
        Me.Rbmujeres.Size = New System.Drawing.Size(67, 19)
        Me.Rbmujeres.TabIndex = 97
        Me.Rbmujeres.TabStop = True
        Me.Rbmujeres.Text = "Mujeres"
        Me.Rbmujeres.UseVisualStyleBackColor = True
        '
        'Rbhombres
        '
        Me.Rbhombres.AutoSize = True
        Me.Rbhombres.Location = New System.Drawing.Point(51, 296)
        Me.Rbhombres.Name = "Rbhombres"
        Me.Rbhombres.Size = New System.Drawing.Size(74, 19)
        Me.Rbhombres.TabIndex = 96
        Me.Rbhombres.TabStop = True
        Me.Rbhombres.Text = "Hombres"
        Me.Rbhombres.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(6, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 15)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "Tipo Alumnos"
        '
        'Cmbmmunicipio
        '
        Me.Cmbmmunicipio.FormattingEnabled = True
        Me.Cmbmmunicipio.Location = New System.Drawing.Point(372, 251)
        Me.Cmbmmunicipio.Name = "Cmbmmunicipio"
        Me.Cmbmmunicipio.Size = New System.Drawing.Size(277, 23)
        Me.Cmbmmunicipio.TabIndex = 92
        '
        'Cmbmdepartamento
        '
        Me.Cmbmdepartamento.FormattingEnabled = True
        Me.Cmbmdepartamento.Location = New System.Drawing.Point(9, 251)
        Me.Cmbmdepartamento.Name = "Cmbmdepartamento"
        Me.Cmbmdepartamento.Size = New System.Drawing.Size(277, 23)
        Me.Cmbmdepartamento.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(369, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Municipio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(8, 233)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Departamento"
        '
        'Txtmatriculas
        '
        Me.Txtmatriculas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtmatriculas.Location = New System.Drawing.Point(463, 199)
        Me.Txtmatriculas.Name = "Txtmatriculas"
        Me.Txtmatriculas.Size = New System.Drawing.Size(186, 23)
        Me.Txtmatriculas.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(463, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Matrículas Extendidas"
        '
        'GBimagen
        '
        Me.GBimagen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBimagen.Controls.Add(Me.PTimagen)
        Me.GBimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBimagen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBimagen.Location = New System.Drawing.Point(665, 13)
        Me.GBimagen.Name = "GBimagen"
        Me.GBimagen.Size = New System.Drawing.Size(172, 186)
        Me.GBimagen.TabIndex = 85
        Me.GBimagen.TabStop = False
        Me.GBimagen.Text = "Imagen"
        '
        'PTimagen
        '
        Me.PTimagen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PTimagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PTimagen.Image = Global.Colegiooxford.My.Resources.Resources.siimagen
        Me.PTimagen.Location = New System.Drawing.Point(3, 19)
        Me.PTimagen.Name = "PTimagen"
        Me.PTimagen.Size = New System.Drawing.Size(166, 164)
        Me.PTimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTimagen.TabIndex = 4
        Me.PTimagen.TabStop = False
        '
        'MCGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GBdatosg1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MCGeneral"
        Me.Text = "GeneralCo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBdatosg1.ResumeLayout(False)
        Me.GBdatosg1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBimagen.ResumeLayout(False)
        CType(Me.PTimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btnbuscarimagen As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Txtinscripcionh As TextBox
    Friend WithEvents Txttipoalumno As TextBox
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ACADEMICOS As ToolStripMenuItem
    Friend WithEvents FINANCIEROS As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtnombrecorto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtzona As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtcodigopostal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txttelefono As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txtfax As TextBox
    Friend WithEvents Lblmensaje1 As Label
    Friend WithEvents Lblmensaje2 As Label
    Friend WithEvents GBdatosg1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Rbambos As RadioButton
    Friend WithEvents Rbsiguiente As RadioButton
    Friend WithEvents Rbactual As RadioButton
    Friend WithEvents txt_ruta As TextBox
    Friend WithEvents Txtresolucion As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Txtcentrocosto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Txtcoordinador As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Txtdirector As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Rbmixto As RadioButton
    Friend WithEvents Rbmujeres As RadioButton
    Friend WithEvents Rbhombres As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Cmbmmunicipio As ComboBox
    Friend WithEvents Cmbmdepartamento As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Txtmatriculas As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GBimagen As GroupBox
    Friend WithEvents PTimagen As PictureBox
    Friend WithEvents Txtreligion As ComboBox
    Friend WithEvents Cmbmunicipio As ComboBox
    Friend WithEvents Cmbdepartamento As ComboBox
    Friend WithEvents CBpais As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Dtfechaautorizacion As MaskedTextBox
    Friend WithEvents Txtdepartamento As TextBox
End Class
