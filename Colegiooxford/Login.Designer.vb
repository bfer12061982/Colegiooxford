<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    ' Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lblincorrecto = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Lbelbienvenido = New System.Windows.Forms.Label()
        Me.Lblverificando = New System.Windows.Forms.Label()
        Me.btnLogin = New MaterialSkin.Controls.MaterialButton()
        Me.txtPass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtUser = New MaterialSkin.Controls.MaterialTextBox2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Lblincorrecto)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.Lbelbienvenido)
        Me.Panel1.Controls.Add(Me.Lblverificando)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(547, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 367)
        Me.Panel1.TabIndex = 12
        '
        'Lblincorrecto
        '
        Me.Lblincorrecto.AutoSize = True
        Me.Lblincorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblincorrecto.ForeColor = System.Drawing.Color.Red
        Me.Lblincorrecto.Location = New System.Drawing.Point(45, 323)
        Me.Lblincorrecto.Name = "Lblincorrecto"
        Me.Lblincorrecto.Size = New System.Drawing.Size(202, 20)
        Me.Lblincorrecto.TabIndex = 19
        Me.Lblincorrecto.Text = "DATOS INCORRECTOS"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(13, 230)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 18
        '
        'Lbelbienvenido
        '
        Me.Lbelbienvenido.AutoSize = True
        Me.Lbelbienvenido.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lbelbienvenido.ForeColor = System.Drawing.Color.Green
        Me.Lbelbienvenido.Location = New System.Drawing.Point(68, 323)
        Me.Lbelbienvenido.Name = "Lbelbienvenido"
        Me.Lbelbienvenido.Size = New System.Drawing.Size(0, 19)
        Me.Lbelbienvenido.TabIndex = 17
        '
        'Lblverificando
        '
        Me.Lblverificando.AutoSize = True
        Me.Lblverificando.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lblverificando.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Lblverificando.Location = New System.Drawing.Point(94, 304)
        Me.Lblverificando.Name = "Lblverificando"
        Me.Lblverificando.Size = New System.Drawing.Size(0, 19)
        Me.Lblverificando.TabIndex = 16
        '
        'btnLogin
        '
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLogin.Depth = 0
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.HighEmphasis = True
        Me.btnLogin.Icon = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(58, 262)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLogin.Size = New System.Drawing.Size(170, 36)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "INGRESAR A SISTEMA"
        Me.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLogin.UseAccentColor = False
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.AnimateReadOnly = False
        Me.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPass.Depth = 0
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtPass.HideSelection = True
        Me.txtPass.Hint = "PASSWORD"
        Me.txtPass.LeadingIcon = Nothing
        Me.txtPass.Location = New System.Drawing.Point(13, 177)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PrefixSuffixText = Nothing
        Me.txtPass.ReadOnly = False
        Me.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(258, 48)
        Me.txtPass.TabIndex = 11
        Me.txtPass.TabStop = False
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.TrailingIcon = Nothing
        Me.txtPass.UseSystemPasswordChar = False
        '
        'txtUser
        '
        Me.txtUser.AnimateReadOnly = False
        Me.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUser.Depth = 0
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtUser.HideSelection = True
        Me.txtUser.Hint = "USUARIO"
        Me.txtUser.LeadingIcon = Nothing
        Me.txtUser.Location = New System.Drawing.Point(13, 123)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PrefixSuffixText = Nothing
        Me.txtUser.ReadOnly = False
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(258, 48)
        Me.txtUser.TabIndex = 10
        Me.txtUser.TabStop = False
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUser.TrailingIcon = Nothing
        Me.txtUser.UseSystemPasswordChar = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Colegiooxford.My.Resources.Resources.logosistema1
        Me.PictureBox2.Location = New System.Drawing.Point(58, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Colegiooxford.My.Resources.Resources.fondo3
        Me.PictureBox1.Location = New System.Drawing.Point(3, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1364, 721)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1370, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Tag = ""
        Me.Text = "OXFORD BILINGUAL SCHOOL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtPass As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtUser As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lblverificando As Label
    Friend WithEvents Lbelbienvenido As Label
    Friend WithEvents ProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents Lblincorrecto As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
