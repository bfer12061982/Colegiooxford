<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFConveniopago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PFConveniopago))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.Txtfechaingreso = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txtobservaciones = New System.Windows.Forms.TextBox()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADICIONALES = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULOMORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBSERVACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBdatos.SuspendLayout()
        Me.GB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 66
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
        Me.Txtcodigo.Location = New System.Drawing.Point(33, 236)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(92, 23)
        Me.Txtcodigo.TabIndex = 0
        '
        'GBdatos
        '
        Me.GBdatos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdatos.Controls.Add(Me.GB)
        Me.GBdatos.Enabled = False
        Me.GBdatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBdatos.Location = New System.Drawing.Point(3, 3)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(842, 491)
        Me.GBdatos.TabIndex = 67
        Me.GBdatos.TabStop = False
        Me.GBdatos.Text = "FAMILIAS / CONVENIO PAGO"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.Label17)
        Me.GB.Controls.Add(Me.Txtobservaciones)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.GroupBox1)
        Me.GB.Controls.Add(Me.Txtfechaingreso)
        Me.GB.Location = New System.Drawing.Point(9, 22)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(827, 463)
        Me.GB.TabIndex = 0
        Me.GB.TabStop = False
        Me.GB.Text = "Datos Generales"
        '
        'Txtfechaingreso
        '
        Me.Txtfechaingreso.Location = New System.Drawing.Point(6, 104)
        Me.Txtfechaingreso.Mask = "00/00/0000"
        Me.Txtfechaingreso.Name = "Txtfechaingreso"
        Me.Txtfechaingreso.Size = New System.Drawing.Size(201, 23)
        Me.Txtfechaingreso.TabIndex = 21
        Me.Txtfechaingreso.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Posee Convenio"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(111, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(43, 19)
        Me.RadioButton2.TabIndex = 129
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(51, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(36, 19)
        Me.RadioButton1.TabIndex = 128
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SI"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Fecha Convenio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 15)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "Observaciones"
        '
        'Txtobservaciones
        '
        Me.Txtobservaciones.Location = New System.Drawing.Point(9, 147)
        Me.Txtobservaciones.Multiline = True
        Me.Txtobservaciones.Name = "Txtobservaciones"
        Me.Txtobservaciones.Size = New System.Drawing.Size(812, 237)
        Me.Txtobservaciones.TabIndex = 129
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
        Me.Btnregistrar.Location = New System.Drawing.Point(16, 185)
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
        Me.Btneditar.Location = New System.Drawing.Point(16, 134)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(123, 45)
        Me.Btneditar.TabIndex = 57
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btneditar.UseVisualStyleBackColor = False
        '
        'PFConveniopago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PFConveniopago"
        Me.Text = "PFConveniopago"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBdatos.ResumeLayout(False)
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ADICIONALES As ToolStripMenuItem
    Friend WithEvents CALCULOMORA As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents OBSERVACIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents GB As GroupBox
    Friend WithEvents Txtfechaingreso As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Txtobservaciones As TextBox
End Class
