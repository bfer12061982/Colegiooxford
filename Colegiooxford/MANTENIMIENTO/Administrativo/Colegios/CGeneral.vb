Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CGeneral
    Private Sub Btnbuscarimagen_Click(sender As Object, e As EventArgs) Handles Btnbuscarimagen.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            txt_ruta.Text = file.FileName
            PTimagen.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub GeneralCo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBdatosg1.Enabled = False
        GBimagen.Enabled = False
        Btneditar.Enabled = False
        Btnbuscarimagen.Enabled = False
        Btnregistrar.Enabled = False
        GENERAL.BackColor = Color.LightSteelBlue
        GENERAL.ForeColor = Color.White
        Txtdepartamento.Visible = False
    End Sub

    Private Sub cargarpais()
        llenarComboBox(CBpais)
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        cargarpais()
        generarcodigo()

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
        comandoregistro.CommandText = "SELECT * FROM c_general ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1
            cargardepto()
            activarcontroles()

        Else
            r.Read()
            Txtcodigo.Text = "1"
            cargardepto()
            activarcontroles()
        End If

    End Sub

    Public Sub inactivarcontroles()

        GBdatosg1.Enabled = False
        GBimagen.Enabled = False
        Btneditar.Enabled = False
        Btneditar.Enabled = False
        Btnbuscarimagen.Enabled = False
        Btnregistrar.Enabled = False
    End Sub

    Public Sub activarcontroles()

        GBdatosg1.Enabled = True
        GBimagen.Enabled = True
        Btneditar.Enabled = True
        Btneditar.Enabled = True
        Btnbuscarimagen.Enabled = True
        Btnregistrar.Enabled = True
        Lblmensaje1.Text = ""
    End Sub

    Public Sub limpiarcontroles()
        Txtcodigo.Text = ""
        Txtnombre.Text = ""
        Txtnombrecorto.Text = ""
        Txtreligion.Text = ""
        Txtdireccion.Text = ""
        Txtzona.Text = ""
        Txtcodigopostal.Text = ""
        Cmbdepartamento.Text = "Seleccione Departamento"
        Cmbmunicipio.Text = ""
        Txttelefono.Text = ""
        Txtmatriculas.Text = ""
        Cmbmdepartamento.Text = ""
        Cmbmmunicipio.Text = ""
        Rbhombres.Checked = False
        Rbmujeres.Checked = False
        Rbmixto.Checked = False
        Txtdirector.Text = ""
        ''Dtfechaautorizacion.Enabled = True
        Txtresolucion.Text = ""
        Rbactual.Text = ""
        Rbsiguiente.Text = ""
        Rbambos.Enabled = True
        Btneditar.Enabled = True
        Btnbuscarimagen.Enabled = True
        Btnregistrar.Enabled = True
        Lblmensaje1.Text = ""
    End Sub

    Private Sub cargardepto()

        If CBpais.Text = "Guatemala" Then

            Cmbdepartamento.Visible = True
            Txtdepartamento.Visible = False
            Mensaje1.Hide()

        Else
            Cmbdepartamento.Visible = False
            Txtdepartamento.Visible = True
            Mensaje1.Hide()

        End If


    End Sub


    Private Sub cargarmunicipio()
        Mensaje1.Show()
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

        comando3.CommandText = "SELECT DISTINCT departamento, nombre FROM municipios WHERE departamento='" + Cmbdepartamento.Text + "'"

        'Dim dt As DataTable = New DataTable
        Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(comando3)
        Dim dt1 As New DataSet
        da1.Fill(dt1)

        Cmbmunicipio.DataSource = dt1.Tables(0)
        Cmbmunicipio.DisplayMember = "nombre"
        Cmbmunicipio.ValueMember = "nombre"
        Cmbmmunicipio.DataSource = dt1.Tables(0)
        Cmbmmunicipio.DisplayMember = "nombre"
        Cmbmmunicipio.ValueMember = "nombre"
        Mensaje1.Hide()
        conexion3.Close()
    End Sub

    Private Sub Cmbdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Lblmensaje2.Text = "CARGANDO MUNICIPIO"
        cargarmunicipio()
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()

    End Sub

    Public Sub registrar()
        If txt_ruta.Text = "" Then
            MessageBox.Show("TIENES QUE SELECCIONAR IMAGEN", "SISTEMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            Lblmensaje1.Text = "REGISTRANDO DATOS"
            ' Dim strPath As String
            ' strPath = txt_ruta.Text
            ' Dim ruta As New FileStream(strPath, FileMode.Open, FileAccess.Read)
            '  Dim binario(ruta.Length) As Byte
            ' ruta.Read(binario, 0, ruta.Length) 'Leo el archivo y lo convierto a binario 
            ' ruta.Close() 'Cierro el FileStream 

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
            Dim cmm As New MySqlCommand("guardargeneralcolegio", conexionregistro)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("g_codigo", Txtcodigo.Text)
            cmm.Parameters.AddWithValue("g_nombre", Txtnombre.Text)
            cmm.Parameters.AddWithValue("g_nombrecorto", Txtnombrecorto.Text)
            cmm.Parameters.AddWithValue("g_religion", Txtreligion.Text)
            cmm.Parameters.AddWithValue("g_direccion", Txtdireccion.Text)
            cmm.Parameters.AddWithValue("g_zona", Txtzona.Text)
            cmm.Parameters.AddWithValue("g_codigopostal", Txtcodigopostal.Text)
            cmm.Parameters.AddWithValue("g_pais", txt_ruta.Text)
            cmm.Parameters.AddWithValue("g_departamento", Cmbdepartamento.Text)
            cmm.Parameters.AddWithValue("g_municipio", Cmbmunicipio.Text)
            cmm.Parameters.AddWithValue("g_telefono", Txttelefono.Text)
            cmm.Parameters.AddWithValue("g_fax", Txtfax.Text)
            cmm.Parameters.AddWithValue("g_matriculasext", Txtmatriculas.Text)
            cmm.Parameters.AddWithValue("g_departamentomat", Cmbdepartamento.Text)
            cmm.Parameters.AddWithValue("g_municipiomat", Cmbmunicipio.Text)
            cmm.Parameters.AddWithValue("g_tipocolegio", Txttipoalumno.Text)
            cmm.Parameters.AddWithValue("g_directorrl", Txtdirector.Text)
            cmm.Parameters.AddWithValue("g_coordinadorge", Txtcoordinador.Text)
            cmm.Parameters.AddWithValue("g_centrocosto", Txtcentrocosto.Text)
            cmm.Parameters.AddWithValue("g_inscripcionhabilitada", Txtinscripcionh.Text)
            cmm.Parameters.AddWithValue("g_imagen", Imag)
            cmm.Parameters.AddWithValue("g_fechaautorizacion", Dtfechaautorizacion.Text)
            cmm.Parameters.AddWithValue("g_resolucion", Txtresolucion.Text)

            cmm.ExecuteNonQuery()
            Lblmensaje1.Text = ""
            MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            inactivarcontroles()
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

    Private Sub Rbhombres_CheckedChanged(sender As Object, e As EventArgs)
        Txttipoalumno.Text = "hombres"
    End Sub

    Private Sub Rbmujeres_CheckedChanged(sender As Object, e As EventArgs)
        Txttipoalumno.Text = "mujeres"
    End Sub

    Private Sub Rbmixto_CheckedChanged(sender As Object, e As EventArgs)
        Txttipoalumno.Text = "mixto"
    End Sub

    Private Sub Rbactual_CheckedChanged_1(sender As Object, e As EventArgs)
        Txtinscripcionh.Text = "actual"
    End Sub

    Private Sub Rbsiguiente_CheckedChanged(sender As Object, e As EventArgs)
        Txtinscripcionh.Text = "siguiente"
    End Sub

    Private Sub Rbambos_CheckedChanged(sender As Object, e As EventArgs)
        Txtinscripcionh.Text = "ambos"
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles Btneditar.Click
        Mensaje1.Show()
        With Informacionmant
            .TopLevel = False

            Informacionmant.PTsalir1.Visible = True
            Informacionmant.Ptsalir2.Visible = False
            Informacionmant.cargardatogeneral()
            Mantenimiento.Panel1.Controls.Add(Informacionmant)
            .BringToFront()
            .Show()
        End With
    End Sub
    Public Sub buscarimagen()
        Dim conexionimagen As MySqlConnection = New MySqlConnection
        Dim comandoimagen As MySqlCommand = New MySqlCommand
        comandoimagen.Connection = conexionimagen

        conexionimagen.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
        conexionimagen.Open()

        Try
            Dim Sql As String = "select * from c_general where imagen=" & Me.txt_ruta.Text & ""
            Dim lector As MySqlDataReader
            ' cnn = New MySqlConnection(conexionregistro)
            'conexionregistro.Open()
            If conexionimagen.State = ConnectionState.Open Then
                Dim Imag As Byte()
                Dim Comando As New MySqlCommand(Sql, conexionimagen)
                lector = Comando.ExecuteReader
                While lector.Read
                    Imag = lector("imagen")
                    Me.PTimagen.Image = Bytes_Imagen(Imag)
                End While
            End If
            ' conexionregistro.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub abrir_inventario_existente()
        Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then  'Evalua si el usuario hace click en el boton abrir
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Me.PTimagen.Image = Image.FromFile(filename)
        End If
    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub Cmbmdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ACADEMICOS_Click(sender As Object, e As EventArgs) Handles ACADEMICOS.Click
        With CAcademicos
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CAcademicos)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub FINANCIEROS_Click(sender As Object, e As EventArgs) Handles FINANCIEROS.Click
        With CFinanciero
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CFinanciero)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub CALCULOMORA_Click(sender As Object, e As EventArgs) Handles CALCULOMORA.Click
        With CCalculomora
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CCalculomora)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub CONTRATOS_Click(sender As Object, e As EventArgs) Handles CONTRATOS.Click
        With CContratos
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CContratos)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub INTERNET_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GENERAL_Click(sender As Object, e As EventArgs) Handles GENERAL.Click

    End Sub

    Private Sub Cmbmdepartamento_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cmbmdepartamento.SelectedIndexChanged

    End Sub

    Private Sub PTdepartamento_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CBpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBpais.SelectedIndexChanged
        cargardepto()
    End Sub

    Private Sub Cmbdepartamento_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cmbdepartamento.SelectedIndexChanged
        cargarmunicipio()
    End Sub
End Class