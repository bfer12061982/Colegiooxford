<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GSSecciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GSSecciones))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MINEDUCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATERIASASIGNADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENDEGRADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENDEGRADOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txtinscripcionh = New System.Windows.Forms.TextBox()
        Me.Txttipoalumno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Btnregistrar)
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Txtinscripcionh)
        Me.GroupBox2.Controls.Add(Me.Txttipoalumno)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.MINEDUCToolStripMenuItem, Me.MATERIASASIGNADASToolStripMenuItem, Me.ORDENDEGRADOToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 124)
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 20)
        Me.ToolStripMenuItem1.Text = "DISTRIBUCION NOTA"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(97, 20)
        Me.ToolStripMenuItem2.Text = "SECCIONES"
        '
        'MINEDUCToolStripMenuItem
        '
        Me.MINEDUCToolStripMenuItem.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.MINEDUCToolStripMenuItem.Name = "MINEDUCToolStripMenuItem"
        Me.MINEDUCToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MINEDUCToolStripMenuItem.Text = "MINEDUC"
        '
        'MATERIASASIGNADASToolStripMenuItem
        '
        Me.MATERIASASIGNADASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORDENDEGRADOToolStripMenuItem})
        Me.MATERIASASIGNADASToolStripMenuItem.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.MATERIASASIGNADASToolStripMenuItem.Name = "MATERIASASIGNADASToolStripMenuItem"
        Me.MATERIASASIGNADASToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.MATERIASASIGNADASToolStripMenuItem.Text = "MATERIAS ASIGNADAS"
        '
        'ORDENDEGRADOToolStripMenuItem
        '
        Me.ORDENDEGRADOToolStripMenuItem.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ORDENDEGRADOToolStripMenuItem.Name = "ORDENDEGRADOToolStripMenuItem"
        Me.ORDENDEGRADOToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ORDENDEGRADOToolStripMenuItem.Text = "ORDEN DE GRADO"
        '
        'ORDENDEGRADOToolStripMenuItem1
        '
        Me.ORDENDEGRADOToolStripMenuItem1.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.ORDENDEGRADOToolStripMenuItem1.Name = "ORDENDEGRADOToolStripMenuItem1"
        Me.ORDENDEGRADOToolStripMenuItem1.Size = New System.Drawing.Size(137, 20)
        Me.ORDENDEGRADOToolStripMenuItem1.Text = "ORDEN DE GRADO"
        '
        'Txtinscripcionh
        '
        Me.Txtinscripcionh.Location = New System.Drawing.Point(30, 341)
        Me.Txtinscripcionh.Name = "Txtinscripcionh"
        Me.Txtinscripcionh.Size = New System.Drawing.Size(100, 23)
        Me.Txtinscripcionh.TabIndex = 61
        Me.Txtinscripcionh.Visible = False
        '
        'Txttipoalumno
        '
        Me.Txttipoalumno.Location = New System.Drawing.Point(30, 312)
        Me.Txttipoalumno.Name = "Txttipoalumno"
        Me.Txttipoalumno.Size = New System.Drawing.Size(100, 23)
        Me.Txttipoalumno.TabIndex = 60
        Me.Txttipoalumno.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 491)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GRADOS SECCIONES / SECCIONES"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(830, 467)
        Me.DataGridView1.TabIndex = 1
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.Btnregistrar.Location = New System.Drawing.Point(13, 146)
        Me.Btnregistrar.Name = "Btnregistrar"
        Me.Btnregistrar.Size = New System.Drawing.Size(123, 45)
        Me.Btnregistrar.TabIndex = 64
        Me.Btnregistrar.Text = "BUSCAR"
        Me.Btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnregistrar.UseVisualStyleBackColor = False
        '
        'GSSecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GSSecciones"
        Me.Text = "GSSecciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MINEDUCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MATERIASASIGNADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDENDEGRADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDENDEGRADOToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Txtinscripcionh As TextBox
    Friend WithEvents Txttipoalumno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btnregistrar As Button
End Class
