﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AMineduc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AMineduc))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Txtinscripcionh = New System.Windows.Forms.TextBox()
        Me.Txttipoalumno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PTdepartamento = New System.Windows.Forms.PictureBox()
        Me.GENERAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRATOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MINEDUCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 492)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERAL, Me.ToolStripMenuItem1, Me.CONTRATOS, Me.MINEDUCToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 84)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Txtinscripcionh
        '
        Me.Txtinscripcionh.Location = New System.Drawing.Point(24, 320)
        Me.Txtinscripcionh.Name = "Txtinscripcionh"
        Me.Txtinscripcionh.Size = New System.Drawing.Size(100, 23)
        Me.Txtinscripcionh.TabIndex = 61
        Me.Txtinscripcionh.Visible = False
        '
        'Txttipoalumno
        '
        Me.Txttipoalumno.Location = New System.Drawing.Point(24, 291)
        Me.Txttipoalumno.Name = "Txttipoalumno"
        Me.Txttipoalumno.Size = New System.Drawing.Size(100, 23)
        Me.Txttipoalumno.TabIndex = 60
        Me.Txttipoalumno.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 491)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CARRERAS / MINEDUC"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PTdepartamento)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Txtnombre)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(830, 281)
        Me.GroupBox4.TabIndex = 129
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(6, 232)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(473, 23)
        Me.TextBox6.TabIndex = 224
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(3, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 15)
        Me.Label4.TabIndex = 223
        Me.Label4.Text = "Código Oficial Carrera (Rama Enseñanza)"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 182)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(500, 23)
        Me.TextBox2.TabIndex = 222
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "Nombre Secretaria"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 132)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(500, 23)
        Me.TextBox5.TabIndex = 220
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 219
        Me.Label5.Text = "Nombre Superior"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(6, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(500, 23)
        Me.TextBox1.TabIndex = 218
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Codigo Establecimiento"
        '
        'Txtnombre
        '
        Me.Txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txtnombre.Location = New System.Drawing.Point(6, 42)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(769, 23)
        Me.Txtnombre.TabIndex = 216
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Nombre Establecimiento"
        '
        'PTdepartamento
        '
        Me.PTdepartamento.Image = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.PTdepartamento.Location = New System.Drawing.Point(479, 232)
        Me.PTdepartamento.Name = "PTdepartamento"
        Me.PTdepartamento.Size = New System.Drawing.Size(27, 23)
        Me.PTdepartamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTdepartamento.TabIndex = 225
        Me.PTdepartamento.TabStop = False
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
        'CONTRATOS
        '
        Me.CONTRATOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CONTRATOS.Image = CType(resources.GetObject("CONTRATOS.Image"), System.Drawing.Image)
        Me.CONTRATOS.ImageTransparentColor = System.Drawing.Color.Gainsboro
        Me.CONTRATOS.Name = "CONTRATOS"
        Me.CONTRATOS.Size = New System.Drawing.Size(155, 20)
        Me.CONTRATOS.Text = "GRADOS ASIGNADOS"
        '
        'MINEDUCToolStripMenuItem
        '
        Me.MINEDUCToolStripMenuItem.Image = Global.Colegiooxford.My.Resources.Resources.Logo_22
        Me.MINEDUCToolStripMenuItem.Name = "MINEDUCToolStripMenuItem"
        Me.MINEDUCToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MINEDUCToolStripMenuItem.Text = "MINEDUC"
        '
        'Btnregistrar
        '
        Me.Btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btnregistrar.FlatAppearance.BorderSize = 2
        Me.Btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnregistrar.Image = CType(resources.GetObject("Btnregistrar.Image"), System.Drawing.Image)
        Me.Btnregistrar.Location = New System.Drawing.Point(14, 168)
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
        Me.Btneditar.Location = New System.Drawing.Point(14, 118)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(123, 45)
        Me.Btneditar.TabIndex = 57
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btneditar.UseVisualStyleBackColor = False
        '
        'AMineduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AMineduc"
        Me.Text = "Mineduc"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PTdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GENERAL As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CONTRATOS As ToolStripMenuItem
    Friend WithEvents MINEDUCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txtinscripcionh As TextBox
    Friend WithEvents Txttipoalumno As TextBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PTdepartamento As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
End Class
