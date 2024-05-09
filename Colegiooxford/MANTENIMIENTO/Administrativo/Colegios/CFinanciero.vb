Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CFinanciero
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

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
        comandoregistro.CommandText = "SELECT * FROM c_financiero ORDER BY id DESC;"
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

    Private Sub Financiero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBdatosfinancieros.Enabled = False
        GBdatoscuenta.Enabled = False
        FINANCIEROS.BackColor = Color.DarkOliveGreen
        FINANCIEROS.ForeColor = Color.White
    End Sub

    Public Sub activarcontroles()
        GBdatosfinancieros.Enabled = True
        GBdatoscuenta.Enabled = True
    End Sub

    Private Sub Rbactual_CheckedChanged(sender As Object, e As EventArgs) Handles RBsibus.CheckedChanged
        Txtbusescolar.Text = "Si"
        Txtcuotacompleta.Enabled = True
        Txtcuotamediobus.Enabled = True
        Txtcuotarutacorta.Enabled = True
        Txtmesesbus.Enabled = True
    End Sub

    Private Sub Rbsiguiente_CheckedChanged(sender As Object, e As EventArgs) Handles RBnobus.CheckedChanged
        Txtbusescolar.Text = "No"
        Txtcuotacompleta.Enabled = False
        Txtcuotamediobus.Enabled = False
        Txtcuotarutacorta.Enabled = False
        Txtmesesbus.Enabled = False
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
        Dim cmm As New MySqlCommand("guardarfinanciero", conexionregistro)
        cmm.CommandType = CommandType.StoredProcedure
        cmm.Parameters.AddWithValue("f_codigo", Txtcodigo.Text)
        cmm.Parameters.AddWithValue("f_busescolar", Txtbusescolar.Text)
        cmm.Parameters.AddWithValue("f_cuotabuscompleto", Txtcuotacompleta.Text)
        cmm.Parameters.AddWithValue("f_cuotamediobus", Txtcuotamediobus.Text)
        cmm.Parameters.AddWithValue("f_cuotarutacorta", Txtcuotarutacorta.Text)
        cmm.Parameters.AddWithValue("f_cuotamesesbus", Txtmesesbus.Text)
        cmm.Parameters.AddWithValue("f_denegardespuesde", Txtdenegardespues.Text)
        cmm.Parameters.AddWithValue("f_valorrecargo", Txtvalorrecargo.Text)
        cmm.Parameters.AddWithValue("f_valorremision", TxtValorremision.Text)
        cmm.Parameters.AddWithValue("f_permitirnohacercargo", Txtpermitirnohacercargo.Text)
        cmm.Parameters.AddWithValue("f_mensajeestadocuenta", Txtmensajesestadoc.Text)
        cmm.Parameters.AddWithValue("f_mostraranticiposec", Txtmostraranticipos.Text)
        cmm.Parameters.AddWithValue("f_plan1", Txtplan1.Text)
        cmm.Parameters.AddWithValue("f_vweb1", Txtvweb1.Text)
        cmm.Parameters.AddWithValue("f_colab1", Txtcolab1.Text)
        cmm.Parameters.AddWithValue("f_plan2", Txtplan2.Text)
        cmm.Parameters.AddWithValue("f_vweb2", Txtvweb2.Text)
        cmm.Parameters.AddWithValue("f_colab2", Txtcolab2.Text)
        cmm.Parameters.AddWithValue("f_plan3", Txtplan3.Text)
        cmm.Parameters.AddWithValue("f_vweb3", Txtvweb3.Text)
        cmm.Parameters.AddWithValue("f_colab3", Txtcolab3.Text)
        cmm.Parameters.AddWithValue("f_plan4", Txtplan4.Text)
        cmm.Parameters.AddWithValue("f_vweb4", Txtvweb4.Text)
        cmm.Parameters.AddWithValue("f_colab4", Txtcolab4.Text)
        cmm.Parameters.AddWithValue("f_fechamayora", DTFechamayores.Text)
        cmm.Parameters.AddWithValue("f_tipocargorecargo", Txttipocargotc.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()

        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inactivarcontroles()
        limpiarcontroles()

    End Sub
    Public Sub inactivarcontroles()
        GBdatosfinancieros.Enabled = True
        GBdatoscuenta.Enabled = True
    End Sub

    Public Sub limpiarcontroles()
        Txtcodigo.Text = ""
        RBnobus.Checked = False
        RBsibus.Checked = False
        Txtcuotacompleta.Text = ""
        Txtcuotamediobus.Text = ""
        Txtcuotarutacorta.Text = ""
        Txtmesesbus.Text = ""
        Txtdenegardespues.Text = ""
        Txtvalorrecargo.Text = ""
        Txtvalorrecargo.Text = ""
        TxtValorremision.Text = ""
        ChBPermitircargos.Checked = False
        Txtpermitirnohacercargo.Text = ""
        Txtmensajesestadoc.Text = ""
        CHBmostraranticipos.Checked = False
        Txtmostraranticipos.Text = ""
        Txtplan1.Text = ""
        Txtplan2.Text = ""
        Txtplan3.Text = ""
        Txtplan4.Text = ""
        CHBvweb1.Checked = False
        Txtvweb1.Text = ""
        CHBcolab1.Checked = False
        Txtcolab1.Text = ""
        CHBvweb2.Checked = False
        Txtvweb2.Text = ""
        CHBcolab2.Checked = False
        Txtcolab2.Text = ""
        CHBvweb3.Checked = False
        CHBcolab3.Checked = False
        Txtvweb3.Text = ""
        CHBvweb4.Checked = False
        Txtvweb4.Text = ""
        CHBcolab4.Checked = False
        Txtcolab4.Text = ""
        CHBhabilitarplanespago.Checked = False
        DTFechamayores.ResetText()
        Txttipocargotc.Text = ""


    End Sub
    Private Sub ChBPermitircargos_CheckedChanged(sender As Object, e As EventArgs) Handles ChBPermitircargos.CheckedChanged
        Txtpermitirnohacercargo.Text = "Si"
    End Sub

    Private Sub CHBmostraranticipos_CheckedChanged(sender As Object, e As EventArgs)
        Txtmostraranticipos.Text = "Si"
    End Sub

    Private Sub CHBvweb1_CheckedChanged(sender As Object, e As EventArgs)
        Txtvweb1.Text = "Si"
    End Sub

    Private Sub CHBcolab1_CheckedChanged(sender As Object, e As EventArgs)
        Txtcolab1.Text = "Si"
    End Sub

    Private Sub CHBvweb2_CheckedChanged(sender As Object, e As EventArgs)
        Txtvweb2.Text = "Si"
    End Sub

    Private Sub CHBcolab2_CheckedChanged(sender As Object, e As EventArgs)
        Txtcolab2.Text = "Si"
    End Sub

    Private Sub CHBvweb3_CheckedChanged(sender As Object, e As EventArgs)
        Txtvweb3.Text = "Si"
    End Sub

    Private Sub CHBcolab3_CheckedChanged(sender As Object, e As EventArgs)
        Txtcolab3.Text = "Si"
    End Sub

    Private Sub CHBvweb4_CheckedChanged(sender As Object, e As EventArgs)
        Txtvweb4.Text = "Si"
    End Sub

    Private Sub CHBcolab4_CheckedChanged(sender As Object, e As EventArgs)
        Txtcolab4.Text = "Si"
    End Sub

    Private Sub CHBhabilitarplanespago_CheckedChanged(sender As Object, e As EventArgs)
        DTFechamayores.Enabled = True
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

    Private Sub ACADEMICOS_Click(sender As Object, e As EventArgs) Handles ACADEMICOS.Click
        With CAcademicos
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CAcademicos)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub FINANCIEROS_Click(sender As Object, e As EventArgs) Handles FINANCIEROS.Click

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