Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CContratos
    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        generarcodigo()
    End Sub

    Public Sub generarcodigo()
        Mensaje1.Show()
        ''Lblmensaje.Visible = True
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
        comandoregistro.CommandText = "SELECT * FROM c_contratos ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1

            activarcontroles()
            Mensaje1.Hide()
        Else
            r.Read()
            Txtcodigo.Text = "1"

            activarcontroles()
            Mensaje1.Hide()
        End If

    End Sub
    Public Sub activarcontroles()
        GBdatoscontrato.Enabled = True
    End Sub

    Public Sub registrar()
        Mensaje1.Show()
        Mensaje1.Timer1.Start()
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
        Dim cmm As New MySqlCommand("guardarcontrato", conexionregistro)
        cmm.CommandType = CommandType.StoredProcedure
        cmm.Parameters.AddWithValue("ct_codigo", Txtcodigo.Text)
        cmm.Parameters.AddWithValue("ct_lugaremision", Txtlugaremision.Text)
        cmm.Parameters.AddWithValue("ct_direccioncontrato", Txtdireccioncontrato.Text)
        cmm.Parameters.AddWithValue("ct_actanotarial", Txtactanotarial.Text)
        cmm.Parameters.AddWithValue("ct_autorizacioncuotasactual", Txtautorizacionca.Text)
        cmm.Parameters.AddWithValue("ct_autorizacioncuotasiguiente", Txtautorizacioncs.Text)
        cmm.Parameters.AddWithValue("ct_resoluciondiacoactual", Txtresolucionda.Text)
        cmm.Parameters.AddWithValue("ct_resoluciondiacosiguiente", Txtresolucionds.Text)
        cmm.Parameters.AddWithValue("ct_autorizacioncolegio", Txtautorizacioncolegio.Text)
        cmm.Parameters.AddWithValue("ct_nombreentidadcontrato", Txtnombreentidad.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()

        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inactivarcontroles()
        limpiarcontroles()

    End Sub

    Public Sub inactivarcontroles()
        GBdatoscontrato.Enabled = False
    End Sub

    Public Sub limpiarcontroles()
        Txtcodigo.Text = ""
        Txtlugaremision.Text = ""
        Txtdireccioncontrato.Text = ""
        Txtactanotarial.Text = ""
        Txtautorizacionca.Text = ""
        Txtautorizacioncs.Text = ""
        Txtautorizacioncolegio.Text = ""
        Txtnombreentidad.Text = ""
        Txtresolucionda.Text = ""
        Txtresolucionds.Text = ""


    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()
    End Sub

    Private Sub GENERAL_Click(sender As Object, e As EventArgs) Handles GENERAL.Click
        With CGeneral
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CGeneral)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub MCContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONTRATOS.BackColor = Color.DarkOliveGreen
        CONTRATOS.ForeColor = Color.White
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
End Class