<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCalculomora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCalculomora))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CHBcalculo = New System.Windows.Forms.CheckBox()
        Me.GBtipomora = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtmoraminima = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtvalordemora = New System.Windows.Forms.TextBox()
        Me.RBvalordiarioymes = New System.Windows.Forms.RadioButton()
        Me.RBporcentajemensual = New System.Windows.Forms.RadioButton()
        Me.RBporcentajediario = New System.Windows.Forms.RadioButton()
        Me.RBvalorfijo = New System.Windows.Forms.RadioButton()
        Me.RBvalordiario = New System.Windows.Forms.RadioButton()
        Me.RBporcentajesobresaldo = New System.Windows.Forms.RadioButton()
        Me.GBformularcalculo = New System.Windows.Forms.GroupBox()
        Me.RBporcarrera = New System.Windows.Forms.RadioButton()
        Me.RBtipocargo = New System.Windows.Forms.RadioButton()
        Me.RBgeneral = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACADEMICOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANCIEROS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txtcalculobatch = New System.Windows.Forms.TextBox()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.TxtTipodemora = New System.Windows.Forms.TextBox()
        Me.Txtformuladecalculo = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GBtipomora.SuspendLayout()
        Me.GBformularcalculo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.CHBcalculo)
        Me.GroupBox1.Controls.Add(Me.GBtipomora)
        Me.GroupBox1.Controls.Add(Me.GBformularcalculo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 491)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COLEGIO / CALCULO MORA"
        '
        'CHBcalculo
        '
        Me.CHBcalculo.AutoSize = True
        Me.CHBcalculo.Location = New System.Drawing.Point(281, 22)
        Me.CHBcalculo.Name = "CHBcalculo"
        Me.CHBcalculo.Size = New System.Drawing.Size(404, 19)
        Me.CHBcalculo.TabIndex = 4
        Me.CHBcalculo.Text = "CÁLCULO DE MORA EN PROCESO BATCH, NO SE CALCULARÁ EN CAJA"
        Me.CHBcalculo.UseVisualStyleBackColor = True
        '
        'GBtipomora
        '
        Me.GBtipomora.Controls.Add(Me.Label3)
        Me.GBtipomora.Controls.Add(Me.Txtmoraminima)
        Me.GBtipomora.Controls.Add(Me.Label2)
        Me.GBtipomora.Controls.Add(Me.Txtvalordemora)
        Me.GBtipomora.Controls.Add(Me.RBvalordiarioymes)
        Me.GBtipomora.Controls.Add(Me.RBporcentajemensual)
        Me.GBtipomora.Controls.Add(Me.RBporcentajediario)
        Me.GBtipomora.Controls.Add(Me.RBvalorfijo)
        Me.GBtipomora.Controls.Add(Me.RBvalordiario)
        Me.GBtipomora.Controls.Add(Me.RBporcentajesobresaldo)
        Me.GBtipomora.Enabled = False
        Me.GBtipomora.Location = New System.Drawing.Point(6, 118)
        Me.GBtipomora.Name = "GBtipomora"
        Me.GBtipomora.Size = New System.Drawing.Size(830, 341)
        Me.GBtipomora.TabIndex = 3
        Me.GBtipomora.TabStop = False
        Me.GBtipomora.Text = "Tipo de Mora a Utilizar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mora mínima"
        '
        'Txtmoraminima
        '
        Me.Txtmoraminima.Location = New System.Drawing.Point(415, 70)
        Me.Txtmoraminima.Name = "Txtmoraminima"
        Me.Txtmoraminima.Size = New System.Drawing.Size(100, 23)
        Me.Txtmoraminima.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Valor de la Mora"
        '
        'Txtvalordemora
        '
        Me.Txtvalordemora.Location = New System.Drawing.Point(415, 34)
        Me.Txtvalordemora.Name = "Txtvalordemora"
        Me.Txtvalordemora.Size = New System.Drawing.Size(100, 23)
        Me.Txtvalordemora.TabIndex = 6
        '
        'RBvalordiarioymes
        '
        Me.RBvalordiarioymes.AutoSize = True
        Me.RBvalordiarioymes.Location = New System.Drawing.Point(28, 163)
        Me.RBvalordiarioymes.Name = "RBvalordiarioymes"
        Me.RBvalordiarioymes.Size = New System.Drawing.Size(145, 19)
        Me.RBvalordiarioymes.TabIndex = 5
        Me.RBvalordiarioymes.TabStop = True
        Me.RBvalordiarioymes.Text = "Valor Diario Hasta Mes"
        Me.RBvalordiarioymes.UseVisualStyleBackColor = True
        '
        'RBporcentajemensual
        '
        Me.RBporcentajemensual.AutoSize = True
        Me.RBporcentajemensual.Location = New System.Drawing.Point(28, 138)
        Me.RBporcentajemensual.Name = "RBporcentajemensual"
        Me.RBporcentajemensual.Size = New System.Drawing.Size(83, 19)
        Me.RBporcentajemensual.TabIndex = 4
        Me.RBporcentajemensual.TabStop = True
        Me.RBporcentajemensual.Text = "% Mensual"
        Me.RBporcentajemensual.UseVisualStyleBackColor = True
        '
        'RBporcentajediario
        '
        Me.RBporcentajediario.AutoSize = True
        Me.RBporcentajediario.Location = New System.Drawing.Point(28, 113)
        Me.RBporcentajediario.Name = "RBporcentajediario"
        Me.RBporcentajediario.Size = New System.Drawing.Size(70, 19)
        Me.RBporcentajediario.TabIndex = 3
        Me.RBporcentajediario.TabStop = True
        Me.RBporcentajediario.Text = "% Diario"
        Me.RBporcentajediario.UseVisualStyleBackColor = True
        '
        'RBvalorfijo
        '
        Me.RBvalorfijo.AutoSize = True
        Me.RBvalorfijo.Location = New System.Drawing.Point(28, 88)
        Me.RBvalorfijo.Name = "RBvalorfijo"
        Me.RBvalorfijo.Size = New System.Drawing.Size(74, 19)
        Me.RBvalorfijo.TabIndex = 2
        Me.RBvalorfijo.TabStop = True
        Me.RBvalorfijo.Text = "Valor Fijo"
        Me.RBvalorfijo.UseVisualStyleBackColor = True
        '
        'RBvalordiario
        '
        Me.RBvalordiario.AutoSize = True
        Me.RBvalordiario.Location = New System.Drawing.Point(28, 63)
        Me.RBvalordiario.Name = "RBvalordiario"
        Me.RBvalordiario.Size = New System.Drawing.Size(87, 19)
        Me.RBvalordiario.TabIndex = 1
        Me.RBvalordiario.TabStop = True
        Me.RBvalordiario.Text = "Valor Diario"
        Me.RBvalordiario.UseVisualStyleBackColor = True
        '
        'RBporcentajesobresaldo
        '
        Me.RBporcentajesobresaldo.AutoSize = True
        Me.RBporcentajesobresaldo.Location = New System.Drawing.Point(28, 38)
        Me.RBporcentajesobresaldo.Name = "RBporcentajesobresaldo"
        Me.RBporcentajesobresaldo.Size = New System.Drawing.Size(102, 19)
        Me.RBporcentajesobresaldo.TabIndex = 0
        Me.RBporcentajesobresaldo.TabStop = True
        Me.RBporcentajesobresaldo.Text = "% Sobre Saldo"
        Me.RBporcentajesobresaldo.UseVisualStyleBackColor = True
        '
        'GBformularcalculo
        '
        Me.GBformularcalculo.Controls.Add(Me.RBporcarrera)
        Me.GBformularcalculo.Controls.Add(Me.RBtipocargo)
        Me.GBformularcalculo.Controls.Add(Me.RBgeneral)
        Me.GBformularcalculo.Enabled = False
        Me.GBformularcalculo.Location = New System.Drawing.Point(6, 35)
        Me.GBformularcalculo.Name = "GBformularcalculo"
        Me.GBformularcalculo.Size = New System.Drawing.Size(342, 81)
        Me.GBformularcalculo.TabIndex = 0
        Me.GBformularcalculo.TabStop = False
        Me.GBformularcalculo.Text = "Fórmula de Cálculo"
        '
        'RBporcarrera
        '
        Me.RBporcarrera.AutoSize = True
        Me.RBporcarrera.Location = New System.Drawing.Point(244, 38)
        Me.RBporcarrera.Name = "RBporcarrera"
        Me.RBporcarrera.Size = New System.Drawing.Size(83, 19)
        Me.RBporcarrera.TabIndex = 2
        Me.RBporcarrera.TabStop = True
        Me.RBporcarrera.Text = "Por Carrera"
        Me.RBporcarrera.UseVisualStyleBackColor = True
        '
        'RBtipocargo
        '
        Me.RBtipocargo.AutoSize = True
        Me.RBtipocargo.Location = New System.Drawing.Point(108, 38)
        Me.RBtipocargo.Name = "RBtipocargo"
        Me.RBtipocargo.Size = New System.Drawing.Size(120, 19)
        Me.RBtipocargo.TabIndex = 1
        Me.RBtipocargo.TabStop = True
        Me.RBtipocargo.Text = "Por Tipo de Cargo"
        Me.RBtipocargo.UseVisualStyleBackColor = True
        '
        'RBgeneral
        '
        Me.RBgeneral.AutoSize = True
        Me.RBgeneral.Location = New System.Drawing.Point(28, 38)
        Me.RBgeneral.Name = "RBgeneral"
        Me.RBgeneral.Size = New System.Drawing.Size(65, 19)
        Me.RBgeneral.TabIndex = 0
        Me.RBgeneral.TabStop = True
        Me.RBgeneral.Text = "General"
        Me.RBgeneral.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Txtcalculobatch)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btnnuevo)
        Me.GroupBox2.Controls.Add(Me.TxtTipodemora)
        Me.GroupBox2.Controls.Add(Me.Txtformuladecalculo)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 62
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
        Me.MenuStrip1.TabIndex = 141
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
        Me.ACADEMICOS.Image = CType(resources.GetObject("ACADEMICOS.Image"), System.Drawing.Image)
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
        'Txtcalculobatch
        '
        Me.Txtcalculobatch.Location = New System.Drawing.Point(24, 321)
        Me.Txtcalculobatch.Name = "Txtcalculobatch"
        Me.Txtcalculobatch.Size = New System.Drawing.Size(100, 23)
        Me.Txtcalculobatch.TabIndex = 140
        Me.Txtcalculobatch.Visible = False
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = CType(resources.GetObject("Btnregistrar.Image"), System.Drawing.Image)
        Me.Btnregistrar.Location = New System.Drawing.Point(15, 270)
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
        Me.Btneditar.Location = New System.Drawing.Point(15, 216)
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
        Me.Btnnuevo.Location = New System.Drawing.Point(15, 165)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(123, 45)
        Me.Btnnuevo.TabIndex = 56
        Me.Btnnuevo.Text = "NUEVO"
        Me.Btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnnuevo.UseVisualStyleBackColor = False
        '
        'TxtTipodemora
        '
        Me.TxtTipodemora.Location = New System.Drawing.Point(12, 259)
        Me.TxtTipodemora.Name = "TxtTipodemora"
        Me.TxtTipodemora.Size = New System.Drawing.Size(100, 23)
        Me.TxtTipodemora.TabIndex = 139
        Me.TxtTipodemora.Visible = False
        '
        'Txtformuladecalculo
        '
        Me.Txtformuladecalculo.Location = New System.Drawing.Point(12, 230)
        Me.Txtformuladecalculo.Name = "Txtformuladecalculo"
        Me.Txtformuladecalculo.Size = New System.Drawing.Size(100, 23)
        Me.Txtformuladecalculo.TabIndex = 136
        Me.Txtformuladecalculo.Visible = False
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Location = New System.Drawing.Point(12, 201)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(100, 23)
        Me.Txtcodigo.TabIndex = 135
        Me.Txtcodigo.Visible = False
        '
        'MCCalculomora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MCCalculomora"
        Me.Text = "Calculomora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBtipomora.ResumeLayout(False)
        Me.GBtipomora.PerformLayout()
        Me.GBformularcalculo.ResumeLayout(False)
        Me.GBformularcalculo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents TxtTipodemora As TextBox
    Friend WithEvents Txtformuladecalculo As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents GBtipomora As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtmoraminima As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtvalordemora As TextBox
    Friend WithEvents RBvalordiarioymes As RadioButton
    Friend WithEvents RBporcentajemensual As RadioButton
    Friend WithEvents RBporcentajediario As RadioButton
    Friend WithEvents RBvalorfijo As RadioButton
    Friend WithEvents RBvalordiario As RadioButton
    Friend WithEvents RBporcentajesobresaldo As RadioButton
    Friend WithEvents GBformularcalculo As GroupBox
    Friend WithEvents RBporcarrera As RadioButton
    Friend WithEvents RBtipocargo As RadioButton
    Friend WithEvents RBgeneral As RadioButton
    Friend WithEvents CHBcalculo As CheckBox
    Friend WithEvents Txtcalculobatch As TextBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ACADEMICOS As ToolStripMenuItem
    Friend WithEvents FINANCIEROS As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
End Class
