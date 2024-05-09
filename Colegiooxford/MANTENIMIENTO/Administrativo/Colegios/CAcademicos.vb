Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CAcademicos
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GBciclosescolares.Enter

    End Sub

    Private Sub Academicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBciclosescolares.Enabled = False
        GBConfiguracion.Enabled = False
        Txtcodigo.Visible = False
        Txtnotasmasestro.Visible = False
        Txtnotasextracur.Visible = False
        Txtremedialportarea.Visible = False
        Txtaproximarnotaunidad.Visible = False
        Txtaproximarnotapromocion.Visible = False
        Txtchequearcupon.Visible = False
        Txtbonofijo.Visible = False
        ACADEMICOS.BackColor = Color.DarkOliveGreen
        ACADEMICOS.ForeColor = Color.White
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click

        generarcodigo()
    End Sub

    Public Sub generarcodigo()
        Mensaje1.Show()
        Mensaje1.CircularProgressBar1.AnimationSpeed.ToString()
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
        comandoregistro.CommandText = "SELECT * FROM c_academicos ORDER BY id DESC;"
        Dim r As MySqlDataReader
        'Dim ds As DataSet
        r = comandoregistro.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Txtcodigo.Text = r.GetString("codigo") + 1

            activarcontroles()
            Lblmensaje1.Text = ""
            Mensaje1.Hide()
        Else
            r.Read()
            Txtcodigo.Text = "1"

            activarcontroles()
            Mensaje1.Hide()
        End If

    End Sub

    Public Sub activarcontroles()

        GBciclosescolares.Enabled = True
        GBConfiguracion.Enabled = True
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        registrar()
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
            Dim cmm As New MySqlCommand("guardaracademicos", conexionregistro)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("a_codigo", Txtcodigo.Text)
            cmm.Parameters.AddWithValue("a_inicioclases", Dtfechainicioclases.Text)
            cmm.Parameters.AddWithValue("a_actual", Txtactual.Text)
            cmm.Parameters.AddWithValue("a_siguiente", Txtsiguiente.Text)
            cmm.Parameters.AddWithValue("a_oficial", Txtoficial.Text)
            cmm.Parameters.AddWithValue("a_interno", Txtinterno.Text)
            cmm.Parameters.AddWithValue("a_cuadrohonor", Txtcuadrohonor.Text)
            cmm.Parameters.AddWithValue("a_unidadproceso", Txtunidadproceso.Text)
            cmm.Parameters.AddWithValue("a_maximoniveles", Txtmaximonivel.Text)
        cmm.Parameters.AddWithValue("a_chequearcupo", Txtchequearcupon.Text)
        cmm.Parameters.AddWithValue("a_notaspormaestro", Txtnotasmasestro.Text)
            cmm.Parameters.AddWithValue("a_notasextracurriculares", Txtnotasextracur.Text)
            cmm.Parameters.AddWithValue("a_materiasperdidas", Txtmateriaperdida.Text)
            cmm.Parameters.AddWithValue("a_llamadaatencion", Txtllamdaatencion.Text)
            cmm.Parameters.AddWithValue("a_felicitaciones", Txtfelicitaciones.Text)
        cmm.Parameters.AddWithValue("a_aproximarnotaunidad", Txtaproximarnotaunidad.Text)
        cmm.Parameters.AddWithValue("a_aproximarnotapromo", Txtaproximarnotapromocion.Text)
        cmm.Parameters.AddWithValue("a_bonofijo", Txtbonofijo.Text)
        cmm.Parameters.AddWithValue("a_aproximara60", Txtaproximar60.Text)
            cmm.Parameters.AddWithValue("a_puntosbonos", Txtpuntosbono.Text)
        cmm.Parameters.AddWithValue("a_remedialportarea", Txtremedialportarea.Text)
        cmm.Parameters.AddWithValue("a_porcentajenotaremedial", Txtporcentajeremedial.Text)
        cmm.Parameters.AddWithValue("a_fechafinalclases", DTfechafinalclases.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()

        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inactivarcontroles()
        limpiarcontroles()

    End Sub

    Public Sub inactivarcontroles()
        GBciclosescolares.Enabled = True
        GBConfiguracion.Enabled = True
    End Sub

    Public Sub limpiarcontroles()
        Dtfechainicioclases.ResetText()
        Txtactual.Text = ""
        Txtsiguiente.Text = ""
        Txtoficial.Text = ""
        Txtinterno.Text = ""
        Txtcuadrohonor.Text = ""
        Txtunidadproceso.Text = ""
        Txtmaximonivel.Text = ""
        Chbcupo.Checked = False
        Rb1a100.Checked = False
        Rbmaestrono.Checked = False
        Rbmaestrosi.Checked = False
        Rbnetas.Checked = False
        Rbremedialmayor.Checked = False
        Rbremedialremedial.Checked = False
        Cbaproximarnotaunidad.Checked = False
        CBaproximarnotapromocion.Checked = False
        Chbonofijo.Checked = False
        Txtmateriaperdida.Text = ""
        Txtaproximar60.Text = ""
        Txtpuntosbono.Text = ""
        Txtporcentajeremedial.Text = ""
        DTfechafinalclases.ResetText()
    End Sub
    Private Sub Rbmaestrosi_CheckedChanged(sender As Object, e As EventArgs) Handles Rbmaestrosi.CheckedChanged
        Txtnotasmasestro.Text = "Si"
    End Sub

    Private Sub Rbmaestrono_CheckedChanged(sender As Object, e As EventArgs) Handles Rbmaestrono.CheckedChanged
        Txtnotasmasestro.Text = "No"
    End Sub

    Private Sub Rb1a100_CheckedChanged(sender As Object, e As EventArgs) Handles Rb1a100.CheckedChanged
        Txtnotasextracur.Text = "1a100"
    End Sub

    Private Sub Rbnetas_CheckedChanged(sender As Object, e As EventArgs) Handles Rbnetas.CheckedChanged
        Txtnotasextracur.Text = "Netas"
    End Sub

    Private Sub Rbremedialmayor_CheckedChanged(sender As Object, e As EventArgs)
        Txtremedialportarea.Text = "Nota Mayor"
    End Sub

    Private Sub Rbremedialremedial_CheckedChanged(sender As Object, e As EventArgs)
        Txtremedialportarea.Text = "Nota Remedial"
    End Sub

    Private Sub Cbaproximarnotaunidad_CheckedChanged(sender As Object, e As EventArgs)
        Txtaproximarnotaunidad.Text = "Si"
    End Sub

    Private Sub CBaproximarnotapromocion_CheckedChanged(sender As Object, e As EventArgs)
        Txtaproximarnotapromocion.Text = "Si"
    End Sub

    Private Sub Chbcupo_CheckedChanged(sender As Object, e As EventArgs) Handles Chbcupo.CheckedChanged
        Txtchequearcupon.Text = "Si"
    End Sub

    Private Sub Chbonofijo_CheckedChanged(sender As Object, e As EventArgs)
        Txtbonofijo.Text = "Si"
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles Btneditar.Click
        With Informacionmant
            .TopLevel = False
            Mensaje1.Show()
            Informacionmant.PTsalir1.Visible = False
            Informacionmant.Ptsalir2.Visible = True
            Informacionmant.cargardatoacademico()
            Mantenimiento.Panel1.Controls.Add(Informacionmant)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub
    Private Sub GENERAL_Click(sender As Object, e As EventArgs) Handles GENERAL.Click
        With CGeneral
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CGeneral)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ACADEMICOS_Click(sender As Object, e As EventArgs) Handles ACADEMICOS.Click

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
End Class