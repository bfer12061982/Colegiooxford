<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPAdicionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPAdicionales))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txtnivelingles = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRABAJO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADICIONALES = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.RBfluido = New System.Windows.Forms.RadioButton()
        Me.RBintermedio = New System.Windows.Forms.RadioButton()
        Me.RBnada = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtcelularref2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txttelefonoref2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtdireccionref2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtparentezcoref2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txtnombreref2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtcelularref1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txttelefonoref1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtdireccionref1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtparentezcoref1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtnombreref1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtañograduo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtcolegiograduo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpromocion = New System.Windows.Forms.NumericUpDown()
        Me.CHexalumno = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtlicenciaconducir = New System.Windows.Forms.TextBox()
        Me.CBreligion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBdatos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Txtpromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Txtnivelingles)
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.txt_ruta)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'Txtnivelingles
        '
        Me.Txtnivelingles.Location = New System.Drawing.Point(26, 401)
        Me.Txtnivelingles.Name = "Txtnivelingles"
        Me.Txtnivelingles.Size = New System.Drawing.Size(100, 23)
        Me.Txtnivelingles.TabIndex = 62
        Me.Txtnivelingles.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.TRABAJO, Me.ADICIONALES, Me.CALCULOMORA, Me.CONTRATOS})
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
        'ADICIONALES
        '
        Me.ADICIONALES.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ADICIONALES.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ADICIONALES.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.ADICIONALES.Name = "ADICIONALES"
        Me.ADICIONALES.Size = New System.Drawing.Size(112, 20)
        Me.ADICIONALES.Text = "ADICIONALES"
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
        'GBdatos
        '
        Me.GBdatos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdatos.Controls.Add(Me.RBfluido)
        Me.GBdatos.Controls.Add(Me.RBintermedio)
        Me.GBdatos.Controls.Add(Me.RBnada)
        Me.GBdatos.Controls.Add(Me.Label17)
        Me.GBdatos.Controls.Add(Me.Txtobservaciones)
        Me.GBdatos.Controls.Add(Me.Label16)
        Me.GBdatos.Controls.Add(Me.GroupBox3)
        Me.GBdatos.Controls.Add(Me.GroupBox1)
        Me.GBdatos.Enabled = False
        Me.GBdatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBdatos.Location = New System.Drawing.Point(3, 4)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(842, 491)
        Me.GBdatos.TabIndex = 65
        Me.GBdatos.TabStop = False
        Me.GBdatos.Text = "PERSONAS / ADICIONALES"
        '
        'RBfluido
        '
        Me.RBfluido.AutoSize = True
        Me.RBfluido.Location = New System.Drawing.Point(161, 444)
        Me.RBfluido.Name = "RBfluido"
        Me.RBfluido.Size = New System.Drawing.Size(58, 19)
        Me.RBfluido.TabIndex = 145
        Me.RBfluido.TabStop = True
        Me.RBfluido.Text = "Fluido"
        Me.RBfluido.UseVisualStyleBackColor = True
        '
        'RBintermedio
        '
        Me.RBintermedio.AutoSize = True
        Me.RBintermedio.Location = New System.Drawing.Point(71, 444)
        Me.RBintermedio.Name = "RBintermedio"
        Me.RBintermedio.Size = New System.Drawing.Size(84, 19)
        Me.RBintermedio.TabIndex = 144
        Me.RBintermedio.TabStop = True
        Me.RBintermedio.Text = "Intermedio"
        Me.RBintermedio.UseVisualStyleBackColor = True
        '
        'RBnada
        '
        Me.RBnada.AutoSize = True
        Me.RBnada.Location = New System.Drawing.Point(12, 444)
        Me.RBnada.Name = "RBnada"
        Me.RBnada.Size = New System.Drawing.Size(53, 19)
        Me.RBnada.TabIndex = 141
        Me.RBnada.TabStop = True
        Me.RBnada.Text = "Nada"
        Me.RBnada.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(228, 426)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Observaciones"
        '
        'Txtobservaciones
        '
        Me.Txtobservaciones.Location = New System.Drawing.Point(231, 442)
        Me.Txtobservaciones.Multiline = True
        Me.Txtobservaciones.Name = "Txtobservaciones"
        Me.Txtobservaciones.Size = New System.Drawing.Size(596, 43)
        Me.Txtobservaciones.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 426)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 15)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Nivel inglés"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Txtcelularref2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Txttelefonoref2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Txtdireccionref2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Txtparentezcoref2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Txtnombreref2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Txtcelularref1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Txttelefonoref1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Txtdireccionref1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txtparentezcoref1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Txtnombreref1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(830, 204)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referencias Familiares"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(673, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 15)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Celular"
        '
        'Txtcelularref2
        '
        Me.Txtcelularref2.Location = New System.Drawing.Point(673, 170)
        Me.Txtcelularref2.Name = "Txtcelularref2"
        Me.Txtcelularref2.Size = New System.Drawing.Size(148, 23)
        Me.Txtcelularref2.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(491, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Telefono"
        '
        'Txttelefonoref2
        '
        Me.Txttelefonoref2.Location = New System.Drawing.Point(491, 170)
        Me.Txttelefonoref2.Name = "Txttelefonoref2"
        Me.Txttelefonoref2.Size = New System.Drawing.Size(176, 23)
        Me.Txttelefonoref2.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Direccion"
        '
        'Txtdireccionref2
        '
        Me.Txtdireccionref2.Location = New System.Drawing.Point(6, 170)
        Me.Txtdireccionref2.Name = "Txtdireccionref2"
        Me.Txtdireccionref2.Size = New System.Drawing.Size(469, 23)
        Me.Txtdireccionref2.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(491, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Parentezco"
        '
        'Txtparentezcoref2
        '
        Me.Txtparentezcoref2.Location = New System.Drawing.Point(491, 126)
        Me.Txtparentezcoref2.Name = "Txtparentezcoref2"
        Me.Txtparentezcoref2.Size = New System.Drawing.Size(330, 23)
        Me.Txtparentezcoref2.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 15)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Nombre"
        '
        'Txtnombreref2
        '
        Me.Txtnombreref2.Location = New System.Drawing.Point(6, 126)
        Me.Txtnombreref2.Name = "Txtnombreref2"
        Me.Txtnombreref2.Size = New System.Drawing.Size(469, 23)
        Me.Txtnombreref2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(673, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Celular"
        '
        'Txtcelularref1
        '
        Me.Txtcelularref1.Location = New System.Drawing.Point(673, 80)
        Me.Txtcelularref1.Name = "Txtcelularref1"
        Me.Txtcelularref1.Size = New System.Drawing.Size(148, 23)
        Me.Txtcelularref1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(491, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Telefono"
        '
        'Txttelefonoref1
        '
        Me.Txttelefonoref1.Location = New System.Drawing.Point(491, 80)
        Me.Txttelefonoref1.Name = "Txttelefonoref1"
        Me.Txttelefonoref1.Size = New System.Drawing.Size(176, 23)
        Me.Txttelefonoref1.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Direccion"
        '
        'Txtdireccionref1
        '
        Me.Txtdireccionref1.Location = New System.Drawing.Point(6, 80)
        Me.Txtdireccionref1.Name = "Txtdireccionref1"
        Me.Txtdireccionref1.Size = New System.Drawing.Size(469, 23)
        Me.Txtdireccionref1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Parentezco"
        '
        'Txtparentezcoref1
        '
        Me.Txtparentezcoref1.Location = New System.Drawing.Point(491, 36)
        Me.Txtparentezcoref1.Name = "Txtparentezcoref1"
        Me.Txtparentezcoref1.Size = New System.Drawing.Size(330, 23)
        Me.Txtparentezcoref1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre"
        '
        'Txtnombreref1
        '
        Me.Txtnombreref1.Location = New System.Drawing.Point(6, 36)
        Me.Txtnombreref1.Name = "Txtnombreref1"
        Me.Txtnombreref1.Size = New System.Drawing.Size(469, 23)
        Me.Txtnombreref1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtañograduo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txtcolegiograduo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txtpromocion)
        Me.GroupBox1.Controls.Add(Me.CHexalumno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtlicenciaconducir)
        Me.GroupBox1.Controls.Add(Me.CBreligion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 194)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Txtañograduo
        '
        Me.Txtañograduo.Location = New System.Drawing.Point(479, 165)
        Me.Txtañograduo.Name = "Txtañograduo"
        Me.Txtañograduo.Size = New System.Drawing.Size(61, 23)
        Me.Txtañograduo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(478, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Colegio Gradúo"
        '
        'Txtcolegiograduo
        '
        Me.Txtcolegiograduo.Location = New System.Drawing.Point(6, 165)
        Me.Txtcolegiograduo.Name = "Txtcolegiograduo"
        Me.Txtcolegiograduo.Size = New System.Drawing.Size(469, 23)
        Me.Txtcolegiograduo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Primoción"
        '
        'Txtpromocion
        '
        Me.Txtpromocion.Location = New System.Drawing.Point(110, 118)
        Me.Txtpromocion.Name = "Txtpromocion"
        Me.Txtpromocion.Size = New System.Drawing.Size(59, 23)
        Me.Txtpromocion.TabIndex = 3
        '
        'CHexalumno
        '
        Me.CHexalumno.AutoSize = True
        Me.CHexalumno.Location = New System.Drawing.Point(6, 118)
        Me.CHexalumno.Name = "CHexalumno"
        Me.CHexalumno.Size = New System.Drawing.Size(86, 19)
        Me.CHexalumno.TabIndex = 2
        Me.CHexalumno.Text = "Ex-Alumno"
        Me.CHexalumno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Licencia de Conducir"
        '
        'Txtlicenciaconducir
        '
        Me.Txtlicenciaconducir.Location = New System.Drawing.Point(6, 75)
        Me.Txtlicenciaconducir.Name = "Txtlicenciaconducir"
        Me.Txtlicenciaconducir.Size = New System.Drawing.Size(330, 23)
        Me.Txtlicenciaconducir.TabIndex = 1
        '
        'CBreligion
        '
        Me.CBreligion.FormattingEnabled = True
        Me.CBreligion.Items.AddRange(New Object() {"Evangelica(o)", "Catolica(o)", "Otros"})
        Me.CBreligion.Location = New System.Drawing.Point(6, 35)
        Me.CBreligion.Name = "CBreligion"
        Me.CBreligion.Size = New System.Drawing.Size(330, 23)
        Me.CBreligion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Religion"
        '
        'PPAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PPAdicionales"
        Me.Text = "MPAdicionalesPe"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBdatos.ResumeLayout(False)
        Me.GBdatos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Txtpromocion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txtnivelingles As TextBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents TRABAJO As ToolStripMenuItem
    Friend WithEvents ADICIONALES As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents txt_ruta As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CHexalumno As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtlicenciaconducir As TextBox
    Friend WithEvents CBreligion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtpromocion As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Txtobservaciones As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtcelularref2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txttelefonoref2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txtdireccionref2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtparentezcoref2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txtnombreref2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtcelularref1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txttelefonoref1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtdireccionref1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtparentezcoref1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtnombreref1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtcolegiograduo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RBfluido As RadioButton
    Friend WithEvents RBintermedio As RadioButton
    Friend WithEvents RBnada As RadioButton
    Friend WithEvents Txtañograduo As TextBox
End Class
