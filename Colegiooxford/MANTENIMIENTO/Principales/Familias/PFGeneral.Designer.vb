<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PFGeneral))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtdireccionfactura = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtnitfactura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txtnombrefactura = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txtdireccionrecibos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtnitrecibo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtnombrerecibos = New System.Windows.Forms.TextBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtfechaingreso = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txttipoencargado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtparentezcoencargado = New System.Windows.Forms.TextBox()
        Me.Txtnombremadre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtnombrepadre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtnombreencargado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtapellidofamilia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtclavealterna = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PTdepartamento = New System.Windows.Forms.PictureBox()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADICIONALES = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBSERVACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBdatos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GB.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btnnuevo)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.ADICIONALES, Me.CALCULOMORA, Me.CONTRATOS, Me.OBSERVACIONESToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 104)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Location = New System.Drawing.Point(32, 303)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(92, 23)
        Me.Txtcodigo.TabIndex = 0
        '
        'GBdatos
        '
        Me.GBdatos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdatos.Controls.Add(Me.GroupBox4)
        Me.GBdatos.Controls.Add(Me.GB)
        Me.GBdatos.Enabled = False
        Me.GBdatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBdatos.Location = New System.Drawing.Point(3, 3)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(842, 491)
        Me.GBdatos.TabIndex = 66
        Me.GBdatos.TabStop = False
        Me.GBdatos.Text = "FAMILIAS / GENERAL"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Txtdireccionfactura)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Txtnitfactura)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Txtnombrefactura)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Txtdireccionrecibos)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txtnitrecibo)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Txtnombrerecibos)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(827, 185)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Fiscales"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(203, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(539, 19)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.Text = "Tomar datos para recibo y factura de familia  (si no se marca se tomara datos de " &
    "ficha de alumno)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(496, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 15)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Direccion Factura"
        '
        'Txtdireccionfactura
        '
        Me.Txtdireccionfactura.Location = New System.Drawing.Point(499, 112)
        Me.Txtdireccionfactura.Name = "Txtdireccionfactura"
        Me.Txtdireccionfactura.Size = New System.Drawing.Size(323, 23)
        Me.Txtdireccionfactura.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(368, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 15)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Nit"
        '
        'Txtnitfactura
        '
        Me.Txtnitfactura.Location = New System.Drawing.Point(371, 112)
        Me.Txtnitfactura.Name = "Txtnitfactura"
        Me.Txtnitfactura.Size = New System.Drawing.Size(122, 23)
        Me.Txtnitfactura.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Nombre Factura"
        '
        'Txtnombrefactura
        '
        Me.Txtnombrefactura.Location = New System.Drawing.Point(7, 112)
        Me.Txtnombrefactura.Name = "Txtnombrefactura"
        Me.Txtnombrefactura.Size = New System.Drawing.Size(358, 23)
        Me.Txtnombrefactura.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(495, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Direccion Recibos"
        '
        'Txtdireccionrecibos
        '
        Me.Txtdireccionrecibos.Location = New System.Drawing.Point(498, 69)
        Me.Txtdireccionrecibos.Name = "Txtdireccionrecibos"
        Me.Txtdireccionrecibos.Size = New System.Drawing.Size(323, 23)
        Me.Txtdireccionrecibos.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(367, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Nit"
        '
        'Txtnitrecibo
        '
        Me.Txtnitrecibo.Location = New System.Drawing.Point(370, 69)
        Me.Txtnitrecibo.Name = "Txtnitrecibo"
        Me.Txtnitrecibo.Size = New System.Drawing.Size(122, 23)
        Me.Txtnitrecibo.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Nombre Recibos"
        '
        'Txtnombrerecibos
        '
        Me.Txtnombrerecibos.Location = New System.Drawing.Point(6, 69)
        Me.Txtnombrerecibos.Name = "Txtnombrerecibos"
        Me.Txtnombrerecibos.Size = New System.Drawing.Size(358, 23)
        Me.Txtnombrerecibos.TabIndex = 24
        '
        'GB
        '
        Me.GB.Controls.Add(Me.PictureBox2)
        Me.GB.Controls.Add(Me.PictureBox1)
        Me.GB.Controls.Add(Me.PTdepartamento)
        Me.GB.Controls.Add(Me.Label10)
        Me.GB.Controls.Add(Me.Txtcorreo)
        Me.GB.Controls.Add(Me.Txtfechaingreso)
        Me.GB.Controls.Add(Me.Label9)
        Me.GB.Controls.Add(Me.Label8)
        Me.GB.Controls.Add(Me.Txttipoencargado)
        Me.GB.Controls.Add(Me.Label5)
        Me.GB.Controls.Add(Me.Txtparentezcoencargado)
        Me.GB.Controls.Add(Me.Txtnombremadre)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.Txtnombrepadre)
        Me.GB.Controls.Add(Me.Label6)
        Me.GB.Controls.Add(Me.Txtnombreencargado)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label3)
        Me.GB.Controls.Add(Me.Txtapellidofamilia)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Controls.Add(Me.Txtclavealterna)
        Me.GB.Location = New System.Drawing.Point(9, 22)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(827, 242)
        Me.GB.TabIndex = 0
        Me.GB.TabStop = False
        Me.GB.Text = "Datos Generales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(552, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Correo Electrónico"
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(552, 206)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(270, 23)
        Me.Txtcorreo.TabIndex = 22
        '
        'Txtfechaingreso
        '
        Me.Txtfechaingreso.Location = New System.Drawing.Point(424, 206)
        Me.Txtfechaingreso.Mask = "00/00/0000"
        Me.Txtfechaingreso.Name = "Txtfechaingreso"
        Me.Txtfechaingreso.Size = New System.Drawing.Size(122, 23)
        Me.Txtfechaingreso.TabIndex = 21
        Me.Txtfechaingreso.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(421, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha Ingreso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tipo Encargado"
        '
        'Txttipoencargado
        '
        Me.Txttipoencargado.Location = New System.Drawing.Point(7, 206)
        Me.Txttipoencargado.Name = "Txttipoencargado"
        Me.Txttipoencargado.Size = New System.Drawing.Size(411, 23)
        Me.Txttipoencargado.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Parentezco Encargado"
        '
        'Txtparentezcoencargado
        '
        Me.Txtparentezcoencargado.Location = New System.Drawing.Point(424, 155)
        Me.Txtparentezcoencargado.Name = "Txtparentezcoencargado"
        Me.Txtparentezcoencargado.Size = New System.Drawing.Size(398, 23)
        Me.Txtparentezcoencargado.TabIndex = 15
        '
        'Txtnombremadre
        '
        Me.Txtnombremadre.Location = New System.Drawing.Point(424, 104)
        Me.Txtnombremadre.Name = "Txtnombremadre"
        Me.Txtnombremadre.Size = New System.Drawing.Size(364, 23)
        Me.Txtnombremadre.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nombre de la Madre"
        '
        'Txtnombrepadre
        '
        Me.Txtnombrepadre.Location = New System.Drawing.Point(7, 104)
        Me.Txtnombrepadre.Name = "Txtnombrepadre"
        Me.Txtnombrepadre.Size = New System.Drawing.Size(378, 23)
        Me.Txtnombrepadre.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre Encargado"
        '
        'Txtnombreencargado
        '
        Me.Txtnombreencargado.Location = New System.Drawing.Point(7, 155)
        Me.Txtnombreencargado.Name = "Txtnombreencargado"
        Me.Txtnombreencargado.Size = New System.Drawing.Size(378, 23)
        Me.Txtnombreencargado.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre del Padre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos de la familia"
        '
        'Txtapellidofamilia
        '
        Me.Txtapellidofamilia.Location = New System.Drawing.Point(208, 50)
        Me.Txtapellidofamilia.Name = "Txtapellidofamilia"
        Me.Txtapellidofamilia.Size = New System.Drawing.Size(613, 23)
        Me.Txtapellidofamilia.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave Alterna"
        '
        'Txtclavealterna
        '
        Me.Txtclavealterna.Location = New System.Drawing.Point(7, 50)
        Me.Txtclavealterna.Name = "Txtclavealterna"
        Me.Txtclavealterna.Size = New System.Drawing.Size(195, 23)
        Me.Txtclavealterna.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PictureBox2.Location = New System.Drawing.Point(391, 155)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PictureBox1.Location = New System.Drawing.Point(794, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'PTdepartamento
        '
        Me.PTdepartamento.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PTdepartamento.Location = New System.Drawing.Point(391, 104)
        Me.PTdepartamento.Name = "PTdepartamento"
        Me.PTdepartamento.Size = New System.Drawing.Size(27, 23)
        Me.PTdepartamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTdepartamento.TabIndex = 123
        Me.PTdepartamento.TabStop = False
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
        Me.CALCULOMORA.Size = New System.Drawing.Size(148, 20)
        Me.CALCULOMORA.Text = "CONVENIO DE PAGO"
        '
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(90, 20)
        Me.CONTRATOS.Text = "INTERNET"
        '
        'OBSERVACIONESToolStripMenuItem
        '
        Me.OBSERVACIONESToolStripMenuItem.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.OBSERVACIONESToolStripMenuItem.Name = "OBSERVACIONESToolStripMenuItem"
        Me.OBSERVACIONESToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.OBSERVACIONESToolStripMenuItem.Text = "OBSERVACIONES"
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = CType(resources.GetObject("Btnregistrar.Image"), System.Drawing.Image)
        Me.Btnregistrar.Location = New System.Drawing.Point(16, 236)
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
        Me.Btneditar.Location = New System.Drawing.Point(16, 185)
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
        Me.Btnnuevo.Location = New System.Drawing.Point(16, 134)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(123, 45)
        Me.Btnnuevo.TabIndex = 56
        Me.Btnnuevo.Text = "NUEVO"
        Me.Btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnnuevo.UseVisualStyleBackColor = False
        '
        'PFGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PFGeneral"
        Me.Text = "MPFGeneral"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBdatos.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ADICIONALES As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents GB As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txtdireccionfactura As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtnitfactura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txtnombrefactura As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txtdireccionrecibos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtnitrecibo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtnombrerecibos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Txtfechaingreso As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txttipoencargado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtparentezcoencargado As TextBox
    Friend WithEvents Txtnombremadre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtnombrepadre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtnombreencargado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtapellidofamilia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtclavealterna As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PTdepartamento As PictureBox
    Friend WithEvents OBSERVACIONESToolStripMenuItem As ToolStripMenuItem
End Class
