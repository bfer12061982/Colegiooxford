Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class PPPersona


    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        generarcodigo()
        cargarpais()
    End Sub

    Public Sub generarcodigo()
        Mensaje1.Show()
        Dim IdRegistro As Integer = 0
        Dim conexionregistro As MySqlConnection = New MySqlConnection
        Dim comandoregistro As MySqlCommand = New MySqlCommand
        comandoregistro.Connection = conexionregistro
        ' Procesando.Visible = True
        Try
            conexionregistro.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
            conexionregistro.Open()
            'MsgBox("CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comandoregistro.CommandText = "SELECT * FROM p_general ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1
            GBdatos.Enabled = True
            Mensaje1.Hide()
            cargarpais()
        Else
            r.Read()
            Txtcodigo.Text = "1"
            GBdatos.Enabled = True
            Mensaje1.Hide()
            cargarpais()
        End If

    End Sub

    Private Sub cargarpais()
        llenarComboBox(CBpais)
        llenarComboBox(CBpaisorigen)
        llenarComboBox(CBpais2)
    End Sub

    Private Sub GBdatos_Enter(sender As Object, e As EventArgs) Handles GBdatos.Enter

    End Sub

    Private Sub MPGeneralPe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBdatos.Enabled = False
        GENERAL.BackColor = Color.LightSteelBlue
        GENERAL.ForeColor = Color.White
    End Sub

    Private Sub Btnbuscarimagen_Click(sender As Object, e As EventArgs) Handles Btnbuscarimagen.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            txt_ruta.Text = file.FileName
            PTimagen.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub PTdepartamento_Click(sender As Object, e As EventArgs) Handles PTdepartamento.Click
        'cargardepto()
    End Sub

    Private Sub cargardepto()

        If CBpais.Text = "Guatemala" Then
            Mensaje1.Show()
            CBdepartamento.Visible = True

        Else
            MsgBox("DIGITA NOMBRE DEPARTAMENTO Y MUNICIPIO")


        End If


    End Sub

    Private Sub cargarmunicipio()
        Dim conexion3 As MySqlConnection = New MySqlConnection
        Dim comando3 As MySqlCommand = New MySqlCommand

        comando3.Connection = conexion3

        Try
            conexion3.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
            conexion3.Open()
            '  MsgBox("CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando3.CommandText = "SELECT DISTINCT departamento, nombre FROM municipios WHERE departamento='" + CBdepartamento.Text + "'"

        'Dim dt As DataTable = New DataTable
        Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(comando3)
        Dim dt1 As New DataSet
        da1.Fill(dt1)

        CBmunicipio.DataSource = dt1.Tables(0)
        CBmunicipio.DisplayMember = "nombre"
        CBmunicipio.ValueMember = "nombre"
        CBmunicipio.DataSource = dt1.Tables(0)
        CBmunicipio.DisplayMember = "nombre"
        CBmunicipio.ValueMember = "nombre"
        conexion3.Close()
    End Sub

    Private Sub cargardepto1()

        If CBpais2.Text = "Guatemala" Then
            Mensaje1.Show()
            Dim conexion2 As MySqlConnection = New MySqlConnection
            Dim comando2 As MySqlCommand = New MySqlCommand
            comando2.Connection = conexion2

            Try
                conexion2.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
                conexion2.Open()
                '  MsgBox("CONEXION EXITOSA")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("select nombre, codigo from departamentos", conexion2)
            Dim ds As New DataSet
            da.Fill(ds)

            CBdepartamento2.DataSource = ds.Tables(0)
            CBdepartamento2.DisplayMember = "nombre"
            CBdepartamento2.ValueMember = "nombre"
            CBdepartamento2.DataSource = ds.Tables(0)
            CBdepartamento2.DisplayMember = "nombre"
            CBdepartamento2.ValueMember = "nombre"
            Mensaje1.Hide()

            conexion2.Close()

        Else
            MsgBox("DIGITA NOMBRE DEPARTAMENTO Y MUNICIPIO")


        End If


    End Sub

    Private Sub cargarmunicipio2()
        Dim conexion3 As MySqlConnection = New MySqlConnection
        Dim comando3 As MySqlCommand = New MySqlCommand

        comando3.Connection = conexion3

        Try
            conexion3.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
            conexion3.Open()
            '  MsgBox("CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando3.CommandText = "SELECT DISTINCT departamento, nombre FROM municipios WHERE departamento='" + CBdepartamento2.Text + "'"

        'Dim dt As DataTable = New DataTable
        Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(comando3)
        Dim dt1 As New DataSet
        da1.Fill(dt1)

        CBmunicipio2.DataSource = dt1.Tables(0)
        CBmunicipio2.DisplayMember = "nombre"
        CBmunicipio2.ValueMember = "nombre"
        CBmunicipio2.DataSource = dt1.Tables(0)
        CBmunicipio2.DisplayMember = "nombre"
        CBmunicipio2.ValueMember = "nombre"
        conexion3.Close()
    End Sub

    Private Sub CBdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBdepartamento.SelectedIndexChanged
        cargarmunicipio()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PTdepartamento1.Click
        cargardepto1()
    End Sub

    Private Sub CBdepartamento2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBdepartamento2.SelectedIndexChanged
        cargarmunicipio2()
    End Sub
    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()
    End Sub
    Public Sub registrar()
        If txt_ruta.Text = "" Then
            MessageBox.Show("TIENES QUE SELECCIONAR IMAGEN", "SISTEMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            Mensaje1.Show()

            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.PTimagen.Image)

            Dim conexionregistro As MySqlConnection = New MySqlConnection
            Dim comandoregistro As MySqlCommand = New MySqlCommand
            comandoregistro.Connection = conexionregistro
            Try
                conexionregistro.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
                conexionregistro.Open()
                ' MsgBox("CONEXION EXITOSA")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '  Dim cnn As New SqlConnection(conexionregistro)
            Dim cmm As New MySqlCommand("guardargeneralpersona", conexionregistro)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("p_codigo", Txtcodigo.Text)
            cmm.Parameters.AddWithValue("p_nombre", Txtnombres.Text)
            cmm.Parameters.AddWithValue("p_apellido", Txtapellidos.Text)
            cmm.Parameters.AddWithValue("p_apellidocasada", Txtapellidocasada.Text)
            cmm.Parameters.AddWithValue("p_estadocivil", CBestadocivil.Text)
            cmm.Parameters.AddWithValue("p_excluircirculares", CHcirculares.Text)
            cmm.Parameters.AddWithValue("p_excluirestadpscuenta", CHestadocuenta.Text)
            cmm.Parameters.AddWithValue("p_direccion", Txtdireccion.Text)
            cmm.Parameters.AddWithValue("p_zona", Txtzona.Text)
            cmm.Parameters.AddWithValue("p_codigopostal", Txtcodigopostal.Text)
            cmm.Parameters.AddWithValue("p_pais", CBpais.Text)
            cmm.Parameters.AddWithValue("p_departamento", CBdepartamento.Text)
            cmm.Parameters.AddWithValue("p_municipio", CBmunicipio.Text)
            cmm.Parameters.AddWithValue("p_telefono", Txttelefono.Text)
            cmm.Parameters.AddWithValue("p_celular", Txtcelular.Text)
            cmm.Parameters.AddWithValue("p_celularsms", Txtcelularsms.Text)
            cmm.Parameters.AddWithValue("p_correo", Txtcorreo.Text)
            cmm.Parameters.AddWithValue("p_fechanacimiento", DTfechanacimiento.Text)
            cmm.Parameters.AddWithValue("p_lugarnacimiento", Txtlugarnacimiento.Text)
            cmm.Parameters.AddWithValue("p_genero", Txtgenero.Text)
            cmm.Parameters.AddWithValue("p_qepd", CHqepd.Text)
            cmm.Parameters.AddWithValue("p_nacionalidad", CBnacionalidad.Text)
            cmm.Parameters.AddWithValue("p_paisorigen", CBpaisorigen.Text)
            cmm.Parameters.AddWithValue("p_nit", Txtnit.Text)
            cmm.Parameters.AddWithValue("p_tiposangre", Txttiposangre.Text)
            cmm.Parameters.AddWithValue("p_tipoidenrificacion", CBtipoidentificacion.Text)
            cmm.Parameters.AddWithValue("p_numeroidentificacion", Txtnumeroidentificacion.Text)
            cmm.Parameters.AddWithValue("p_pais2", CBpais2.Text)
            cmm.Parameters.AddWithValue("p_departamento2", CBdepartamento2.Text)
            cmm.Parameters.AddWithValue("p_municipio2", CBmunicipio2.Text)
            cmm.Parameters.AddWithValue("p_lugarextendida", Txtlugarextendida.Text)
            cmm.Parameters.AddWithValue("p_identificacioncontrato", Txtidentificacionc.Text)
            cmm.Parameters.AddWithValue("p_direccioncontrato", Txtdireccioncontrato.Text)
            cmm.Parameters.AddWithValue("p_imagen", Imag)

            cmm.ExecuteNonQuery()
            Mensaje1.Hide()
            MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PPTrabajo.Show()
            PPTrabajo.Txtcodigo.Text = Txtcodigo.Text
            '  inactivarcontroles()
            '  limpiarcontroles()
        End If
    End Sub

    Public Sub inactivarcontroles()
        GBdatos.Enabled = False
    End Sub

    Public Sub limpiarcontroles()
        txt_ruta.Text = ""
        Txtnombres.Text = ""
        Txtapellidos.Text = ""
        Txtapellidocasada.Text = ""
        Txtcelular.Text = ""
        Txtcelularsms.Text = ""
        Txtzona.TextAlign = ""
        Txtcodigopostal.Text = ""
        Txtdireccion.Text = ""
        Txtgenero.Text = ""
        Txtdireccioncontrato.Text = ""
        Txtidentificacionc.Text = ""
        Txtnit.Text = ""
        Txtlugarnacimiento.Text = ""
        Txttelefono.Text = ""
        Txttiposangre.Text = ""
        CBdepartamento.Text = ""
        CBdepartamento2.Text = ""
        CBestadocivil.Text = ""
        CBmunicipio.Text = ""
        CBmunicipio2.Text = ""
        CBnacionalidad.Text = ""
        CBpais.Text = ""
        CBpais2.Text = ""
        CBpaisorigen.Text = ""
        CBtipoidentificacion.Text = ""
        CHcirculares.Checked = False
        CHestadocuenta.Checked = False
        CHqepd.Checked = False

    End Sub

    Private Sub RBmasculino_CheckedChanged(sender As Object, e As EventArgs) Handles RBmasculino.CheckedChanged
        Txtgenero.Text = "Masculino"
    End Sub

    Private Sub RBfemenino_CheckedChanged(sender As Object, e As EventArgs) Handles RBfemenino.CheckedChanged
        Txtgenero.Text = "Femenino"
    End Sub

    Private Sub ACADEMICOS_Click(sender As Object, e As EventArgs) Handles ACADEMICOS.Click
        With PPTrabajo
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(PPTrabajo)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub FINANCIEROS_Click(sender As Object, e As EventArgs) Handles FINANCIEROS.Click
        With PPAdicionales
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(PPAdicionales)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub CBpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBpais.SelectedIndexChanged

    End Sub
End Class