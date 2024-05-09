Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class PPAdicionales
    Private Sub MPAdicionalesPe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBdatos.Enabled = False
        ADICIONALES.BackColor = Color.LightSteelBlue
        ADICIONALES.ForeColor = Color.White
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
        comandoregistro.CommandText = "SELECT * FROM p_adicional ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1
            GBdatos.Enabled = True
            Mensaje1.Hide()
        Else
            r.Read()
            Txtcodigo.Text = "1"
            GBdatos.Enabled = True
            Mensaje1.Hide()
        End If

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
        Dim cmm As New MySqlCommand("guardaradicional", conexionregistro)
        cmm.CommandType = CommandType.StoredProcedure
        cmm.Parameters.AddWithValue("p_codigo", Txtcodigo.Text)
        cmm.Parameters.AddWithValue("p_religion", CBreligion.Text)
        cmm.Parameters.AddWithValue("p_liecenciaconducir", Txtlicenciaconducir.Text)
        cmm.Parameters.AddWithValue("p_exalumno", CHexalumno.Text)
        cmm.Parameters.AddWithValue("p_promocion", Txtpromocion.Text)
        cmm.Parameters.AddWithValue("p_colegiograduo", Txtcolegiograduo.Text)
        cmm.Parameters.AddWithValue("p_ano", Txtañograduo.Text)
        cmm.Parameters.AddWithValue("p_nombre1", Txtnombreref1.Text)
        cmm.Parameters.AddWithValue("p_parentezco1", Txtparentezcoref1.Text)
        cmm.Parameters.AddWithValue("p_direccion1", Txtdireccionref1.Text)
        cmm.Parameters.AddWithValue("p_telefono1", Txttelefonoref1.Text)
        cmm.Parameters.AddWithValue("p_celular1", Txtcelularref1.Text)
        cmm.Parameters.AddWithValue("p_nombre2", Txtnombreref2.Text)
        cmm.Parameters.AddWithValue("p_parentezco2", Txtparentezcoref2.Text)
        cmm.Parameters.AddWithValue("p_direccion2", Txtdireccionref2.Text)
        cmm.Parameters.AddWithValue("p_telefono2", Txttelefonoref2.Text)
        cmm.Parameters.AddWithValue("p_celular2", Txtcelularref2.Text)
        cmm.Parameters.AddWithValue("p_nivelingles", Txtnivelingles.Text)
        cmm.Parameters.AddWithValue("p_observaciones", Txtobservaciones.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()
        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inactivarcontroles()
        limpiarcontroles()
    End Sub

    Public Sub inactivarcontroles()
        GBdatos.Enabled = False
    End Sub

    Public Sub limpiarcontroles()
        Txtcodigo.Text = ""
        CBreligion.Text = ""
        Txtlicenciaconducir.Text = ""
        CHexalumno.Checked = False
        Txtpromocion.ResetText()
        Txtcolegiograduo.Text = ""
        Txtañograduo.ResetText()
        Txtnombreref1.Text = ""
        Txtdireccionref1.Text = ""
        Txttelefonoref1.Text = ""
        Txtcelularref1.Text = ""
        Txtparentezcoref1.Text = ""
        Txtnombreref2.Text = ""
        Txtcelularref2.Text = ""
        Txtparentezcoref2.Text = ""
        Txtobservaciones.Text = ""
        RBfluido.Checked = False
        RBintermedio.Checked = False
        RBnada.Checked = False

    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs)
        generarcodigo()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBnada.CheckedChanged
        Txtnivelingles.Text = "Nada"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RBintermedio.CheckedChanged
        Txtnivelingles.Text = "Intermedio"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RBfluido.CheckedChanged
        Txtnivelingles.Text = "Fluido"
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()
    End Sub
End Class