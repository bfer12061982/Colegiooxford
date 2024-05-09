<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PGGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PGGeneral))
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
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PTdepartamento = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Txtinscripcionh)
        Me.GroupBox2.Controls.Add(Me.Txttipoalumno)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btnnuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 58
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
        Me.ACADEMICOS.Text = "TIPOS CARGO"
        '
        'FINANCIEROS
        '
        Me.FINANCIEROS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FINANCIEROS.Image = CType(resources.GetObject("FINANCIEROS.Image"), System.Drawing.Image)
        Me.FINANCIEROS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.FINANCIEROS.Name = "FINANCIEROS"
        Me.FINANCIEROS.Size = New System.Drawing.Size(111, 20)
        Me.FINANCIEROS.Text = "ACADEMICOS"
        '
        'CALCULOMORA
        '
        Me.CALCULOMORA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CALCULOMORA.Image = CType(resources.GetObject("CALCULOMORA.Image"), System.Drawing.Image)
        Me.CALCULOMORA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CALCULOMORA.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CALCULOMORA.Name = "CALCULOMORA"
        Me.CALCULOMORA.Size = New System.Drawing.Size(121, 20)
        Me.CALCULOMORA.Text = "CONTABILIDAD"
        '
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = CType(resources.GetObject("CONTRATOS.Image"), System.Drawing.Image)
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(122, 20)
        Me.CONTRATOS.Text = "PROCESOS WEB"
        '
        'Txtinscripcionh
        '
        Me.Txtinscripcionh.Location = New System.Drawing.Point(15, 420)
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
        Me.Btnregistrar.Location = New System.Drawing.Point(14, 240)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 491)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PARAMETROS GENERALES / GENERAL"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.PTdepartamento)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(827, 463)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'PTdepartamento
        '
        Me.PTdepartamento.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PTdepartamento.Location = New System.Drawing.Point(417, 53)
        Me.PTdepartamento.Name = "PTdepartamento"
        Me.PTdepartamento.Size = New System.Drawing.Size(27, 23)
        Me.PTdepartamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTdepartamento.TabIndex = 126
        Me.PTdepartamento.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(127, 53)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(291, 23)
        Me.TextBox5.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(124, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Familia"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(124, 79)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 15)
        Me.Label28.TabIndex = 212
        Me.Label28.Text = "% IVA"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(124, 96)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown1.TabIndex = 211
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox5)
        Me.GroupBox4.Controls.Add(Me.CheckBox4)
        Me.GroupBox4.Controls.Add(Me.CheckBox3)
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(50, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(666, 155)
        Me.GroupBox4.TabIndex = 213
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccion"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(158, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(266, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "NO IMPRIMIR DETALLE DE FORMA DE PAGO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(158, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(277, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "PERMITE MODIFICAR FECHA DE DOCUMENTO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(159, 69)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(310, 19)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "ELIMINAR CARGOS CUANDO SE RETIRA EL ALUMNO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(159, 94)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(402, 19)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "MODIFICAR PORCENTAJES EN ASIGNACION DE BECAS POR ALUMNO"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(158, 119)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(352, 19)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "NO CREAR CARGOS CUANDO SE REINCORPORA EL ALUMNO"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(124, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Porcentaje Recargo TC"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(124, 326)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(126, 23)
        Me.NumericUpDown2.TabIndex = 214
        '
        'PGGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PGGeneral"
        Me.Text = "PGGeneral"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ACADEMICOS As ToolStripMenuItem
    Friend WithEvents FINANCIEROS As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents Txtinscripcionh As TextBox
    Friend WithEvents Txttipoalumno As TextBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PTdepartamento As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
