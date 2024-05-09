<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informacionmant
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGinformacion = New System.Windows.Forms.DataGridView()
        Me.PTsalir1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Ptsalir2 = New System.Windows.Forms.PictureBox()
        CType(Me.DGinformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTsalir1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ptsalir2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGinformacion
        '
        Me.DGinformacion.AllowUserToAddRows = False
        Me.DGinformacion.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DGinformacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGinformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGinformacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGinformacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGinformacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGinformacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGinformacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGinformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGinformacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGinformacion.EnableHeadersVisualStyles = False
        Me.DGinformacion.GridColor = System.Drawing.SystemColors.Control
        Me.DGinformacion.Location = New System.Drawing.Point(12, 82)
        Me.DGinformacion.Name = "DGinformacion"
        Me.DGinformacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGinformacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGinformacion.RowHeadersVisible = False
        Me.DGinformacion.Size = New System.Drawing.Size(990, 468)
        Me.DGinformacion.TabIndex = 60
        '
        'PTsalir1
        '
        Me.PTsalir1.Image = Global.Colegiooxford.My.Resources.Resources._1486564399_close_81512
        Me.PTsalir1.Location = New System.Drawing.Point(1069, 24)
        Me.PTsalir1.Name = "PTsalir1"
        Me.PTsalir1.Size = New System.Drawing.Size(28, 22)
        Me.PTsalir1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTsalir1.TabIndex = 65
        Me.PTsalir1.TabStop = False
        Me.PTsalir1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.MaterialTextBox21)
        Me.GroupBox1.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 63)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'MaterialTextBox21
        '
        Me.MaterialTextBox21.AnimateReadOnly = False
        Me.MaterialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox21.Depth = 0
        Me.MaterialTextBox21.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MaterialTextBox21.HideSelection = True
        Me.MaterialTextBox21.Hint = "Digita parametro de busqueda"
        Me.MaterialTextBox21.LeadingIcon = Nothing
        Me.MaterialTextBox21.Location = New System.Drawing.Point(6, 15)
        Me.MaterialTextBox21.MaxLength = 32767
        Me.MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox21.Name = "MaterialTextBox21"
        Me.MaterialTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox21.PrefixSuffixText = Nothing
        Me.MaterialTextBox21.ReadOnly = False
        Me.MaterialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox21.SelectedText = ""
        Me.MaterialTextBox21.SelectionLength = 0
        Me.MaterialTextBox21.SelectionStart = 0
        Me.MaterialTextBox21.ShortcutsEnabled = True
        Me.MaterialTextBox21.Size = New System.Drawing.Size(502, 48)
        Me.MaterialTextBox21.TabIndex = 69
        Me.MaterialTextBox21.TabStop = False
        Me.MaterialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaterialTextBox21.TrailingIcon = Global.Colegiooxford.My.Resources.Resources.buscar1
        Me.MaterialTextBox21.UseSystemPasswordChar = False
        '
        'Ptsalir2
        '
        Me.Ptsalir2.Image = Global.Colegiooxford.My.Resources.Resources._1486564399_close_81512
        Me.Ptsalir2.Location = New System.Drawing.Point(1069, 24)
        Me.Ptsalir2.Name = "Ptsalir2"
        Me.Ptsalir2.Size = New System.Drawing.Size(28, 22)
        Me.Ptsalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptsalir2.TabIndex = 69
        Me.Ptsalir2.TabStop = False
        Me.Ptsalir2.Visible = False
        '
        'Informacionmant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 503)
        Me.Controls.Add(Me.Ptsalir2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PTsalir1)
        Me.Controls.Add(Me.DGinformacion)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Informacionmant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LCgeneral"
        CType(Me.DGinformacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTsalir1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ptsalir2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGinformacion As DataGridView
    Friend WithEvents PTsalir1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Ptsalir2 As PictureBox
End Class
