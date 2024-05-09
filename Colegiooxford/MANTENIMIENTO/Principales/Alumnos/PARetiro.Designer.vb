<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PARetiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PARetiro))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PTdepartamento = New System.Windows.Forms.PictureBox()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACADEMICOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANCIEROS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBSERVACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.txt_ruta)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.ACADEMICOS, Me.FINANCIEROS, Me.CALCULOMORA, Me.CONTRATOS, Me.OTROSToolStripMenuItem, Me.OBSERVACIONESToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 144)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(26, 401)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(100, 23)
        Me.txt_ruta.TabIndex = 61
        Me.txt_ruta.Visible = False
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Location = New System.Drawing.Point(26, 374)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(100, 23)
        Me.Txtcodigo.TabIndex = 60
        Me.Txtcodigo.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PTdepartamento)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 491)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ALUMNOS / RETIRO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 55)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Retirado"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(9, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(291, 23)
        Me.TextBox5.TabIndex = 128
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(9, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Tipo de retiro"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(40, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(36, 19)
        Me.RadioButton1.TabIndex = 130
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SI"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(96, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(43, 19)
        Me.RadioButton2.TabIndex = 131
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(9, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Motivo de retiro"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 158)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(681, 100)
        Me.TextBox1.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(9, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Usuario que retiro"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 281)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(291, 23)
        Me.TextBox2.TabIndex = 133
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Location = New System.Drawing.Point(325, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(179, 55)
        Me.GroupBox4.TabIndex = 134
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pepeleria retirada"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(96, 22)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(43, 19)
        Me.RadioButton3.TabIndex = 131
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "NO"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(40, 22)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(36, 19)
        Me.RadioButton4.TabIndex = 130
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "SI"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(527, 281)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(163, 23)
        Me.MaskedTextBox1.TabIndex = 236
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(524, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 235
        Me.Label9.Text = "Fecha retiro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 15)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = "Nombre persona que retiro"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 337)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(684, 23)
        Me.TextBox3.TabIndex = 238
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "Observaciones"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 385)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(681, 100)
        Me.TextBox4.TabIndex = 240
        '
        'PTdepartamento
        '
        Me.PTdepartamento.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PTdepartamento.Location = New System.Drawing.Point(299, 112)
        Me.PTdepartamento.Name = "PTdepartamento"
        Me.PTdepartamento.Size = New System.Drawing.Size(27, 23)
        Me.PTdepartamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTdepartamento.TabIndex = 129
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
        'ACADEMICOS
        '
        Me.ACADEMICOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ACADEMICOS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ACADEMICOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.ACADEMICOS.Name = "ACADEMICOS"
        Me.ACADEMICOS.Size = New System.Drawing.Size(104, 20)
        Me.ACADEMICOS.Text = "FINANCIERO"
        '
        'FINANCIEROS
        '
        Me.FINANCIEROS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FINANCIEROS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.FINANCIEROS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.FINANCIEROS.Name = "FINANCIEROS"
        Me.FINANCIEROS.Size = New System.Drawing.Size(148, 20)
        Me.FINANCIEROS.Text = "GRADOS SECCIONES"
        '
        'CALCULOMORA
        '
        Me.CALCULOMORA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CALCULOMORA.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.CALCULOMORA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CALCULOMORA.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CALCULOMORA.Name = "CALCULOMORA"
        Me.CALCULOMORA.Size = New System.Drawing.Size(163, 20)
        Me.CALCULOMORA.Text = "PAPELERIA EXPEDIENTE"
        '
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(75, 20)
        Me.CONTRATOS.Text = "RETIRO"
        '
        'OTROSToolStripMenuItem
        '
        Me.OTROSToolStripMenuItem.Image = CType(resources.GetObject("OTROSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OTROSToolStripMenuItem.Name = "OTROSToolStripMenuItem"
        Me.OTROSToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.OTROSToolStripMenuItem.Text = "OTROS"
        '
        'OBSERVACIONESToolStripMenuItem
        '
        Me.OBSERVACIONESToolStripMenuItem.Image = CType(resources.GetObject("OBSERVACIONESToolStripMenuItem.Image"), System.Drawing.Image)
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
        Me.Btnregistrar.Location = New System.Drawing.Point(14, 227)
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
        Me.Btneditar.Location = New System.Drawing.Point(14, 177)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(123, 45)
        Me.Btneditar.TabIndex = 57
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btneditar.UseVisualStyleBackColor = False
        '
        'PARetiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PARetiro"
        Me.Text = "PARetiro"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ACADEMICOS As ToolStripMenuItem
    Friend WithEvents FINANCIEROS As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents OTROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OBSERVACIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_ruta As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PTdepartamento As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
