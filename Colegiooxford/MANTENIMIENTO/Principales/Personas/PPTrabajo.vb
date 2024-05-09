Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class PPTrabajo
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBDatos.Enter

    End Sub

    Private Sub MPtrabajoPe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBDatos.Enabled = False
        TRABAJO.BackColor = Color.LightSteelBlue
        TRABAJO.ForeColor = Color.White

        Txtdireccion.Enabled = False
        Txtlugartrabajo.Enabled = False
        CBdepartamento.Enabled = False
        CBmunicipio.Enabled = False
        Txttelefono.Enabled = False
        Txtcorreo.Enabled = False
        Txtzona.Enabled = False
        Txtcodigopostal.Enabled = False
        DTfechainicio.Enabled = False
        Txtpuestoocupa.Enabled = False
        Txtgradoacademico.Enabled = False
        Txtprofesionoficio.Enabled = False
    End Sub
    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs)
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
        comandoregistro.CommandText = "SELECT * FROM p_trabajo ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1
            GBDatos.Enabled = True
            Mensaje1.Hide()
        Else
            r.Read()
            Txtcodigo.Text = "1"
            GBDatos.Enabled = True
            Mensaje1.Hide()

        End If

    End Sub

    Private Sub cargarpais()
        llenarComboBox(CBpais)
    End Sub

    Private Sub GENERAL_Click(sender As Object, e As EventArgs) Handles GENERAL.Click
        With PPPersona
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(PPPersona)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()
    End Sub

    Public Sub registrar()
        Mensaje1.Show()
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
        Dim cmm As New MySqlCommand("guardardatostrabajo", conexionregistro)
        cmm.CommandType = CommandType.StoredProcedure
        cmm.Parameters.AddWithValue("p_codigo", Txtcodigo.Text)
        cmm.Parameters.AddWithValue("p_trabaja", Txttrabaja.Text)
        cmm.Parameters.AddWithValue("p_lugartrabajo", Txtlugartrabajo.Text)
        cmm.Parameters.AddWithValue("p_direcciontrabajo", Txtdireccion.Text)
        cmm.Parameters.AddWithValue("p_zonatrabajo", Txtzona.Text)
        cmm.Parameters.AddWithValue("p_codigopostal", Txtcodigopostal.Text)
        cmm.Parameters.AddWithValue("p_pais", CBpais.Text)
        cmm.Parameters.AddWithValue("p_departamento", CBdepartamento.Text)
        cmm.Parameters.AddWithValue("p_municipio", CBmunicipio.Text)
        cmm.Parameters.AddWithValue("p_telefono", Txttelefono.Text)
        cmm.Parameters.AddWithValue("p_correo", Txtcorreo.Text)
        cmm.Parameters.AddWithValue("p_fechainicio", DTfechainicio.Text)
        cmm.Parameters.AddWithValue("p_puesto", Txtpuestoocupa.Text)
        cmm.Parameters.AddWithValue("p_gradoacademico", Txtgradoacademico.Text)
        cmm.Parameters.AddWithValue("p_profesion", Txtprofesionoficio.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()
        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PPAdicionales.Show()
        PPAdicionales.Txtcodigo.Text = Txtcodigo.Text
        ' inactivarcontroles()
        ' limpiarcontroles()

    End Sub

    Private Sub RBsi_CheckedChanged(sender As Object, e As EventArgs) Handles RBsi.CheckedChanged
        Txttrabaja.Text = "Si"
        activarcontrolcb()
    End Sub

    Private Sub RBno_CheckedChanged(sender As Object, e As EventArgs) Handles RBno.CheckedChanged
        Txttrabaja.Text = "No"
        inactivarcontrolcb()
    End Sub

    Public Sub inactivarcontroles()
        GBDatos.Enabled = False
    End Sub
    Public Sub activarcontrolcb()
        Txtdireccion.Enabled = True
        Txtlugartrabajo.Enabled = True
        CBdepartamento.Enabled = True
        CBmunicipio.Enabled = True
        Txttelefono.Enabled = True
        Txtcorreo.Enabled = True
        Txtzona.Enabled = True
        Txtcodigopostal.Enabled = True
        DTfechainicio.Enabled = True
        Txtpuestoocupa.Enabled = True
        Txtgradoacademico.Enabled = True
        Txtprofesionoficio.Enabled = True
    End Sub
    Public Sub inactivarcontrolcb()
        Txtdireccion.Enabled = False
        Txtlugartrabajo.Enabled = False
        CBdepartamento.Enabled = False
        CBmunicipio.Enabled = False
        Txttelefono.Enabled = False
        Txtcorreo.Enabled = False
        Txtzona.Enabled = False
        Txtcodigopostal.Enabled = False
        DTfechainicio.Enabled = False
        Txtpuestoocupa.Enabled = False
        Txtgradoacademico.Enabled = False
        Txtprofesionoficio.Enabled = False
    End Sub
    Public Sub limpiarcontroles()
        RBsi.Checked = False
        RBno.Checked = False
        Txtdireccion.Text = ""
        Txtlugartrabajo.Text = ""
        CBdepartamento.Text = ""
        CBmunicipio.Text = ""
        Txttelefono.Text = ""
        Txtcorreo.Text = ""
        Txtzona.Text = "0"
        Txtcodigopostal.Text = ""
        DTfechainicio.Text = ""
        Txtpuestoocupa.Text = ""
        Txtgradoacademico.Text = ""
        Txtprofesionoficio.Text = ""

    End Sub

    Private Sub PTdepartamento_Click(sender As Object, e As EventArgs) Handles PTdepartamento.Click
        cargardepto()
    End Sub
    Private Sub cargardepto()

        If CBpais.Text = "Guatemala" Then
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

            CBdepartamento.DataSource = ds.Tables(0)
            CBdepartamento.DisplayMember = "nombre"
            CBdepartamento.ValueMember = "nombre"
            CBdepartamento.DataSource = ds.Tables(0)
            CBdepartamento.DisplayMember = "nombre"
            CBdepartamento.ValueMember = "nombre"
            Mensaje1.Hide()

            conexion2.Close()

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

    Private Sub CBdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBdepartamento.SelectedIndexChanged
        cargarmunicipio()
    End Sub
End Class