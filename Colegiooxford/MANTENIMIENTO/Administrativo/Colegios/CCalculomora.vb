Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CCalculomora

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
        comandoregistro.CommandText = "SELECT * FROM c_calculomora ORDER BY id DESC;"
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
        GBformularcalculo.Enabled = True
        GBtipomora.Enabled = True
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
        Dim cmm As New MySqlCommand("guardarcalculo", conexionregistro)
        cmm.CommandType = CommandType.StoredProcedure
        cmm.Parameters.AddWithValue("cm_codigo", Txtcodigo.Text)
        cmm.Parameters.AddWithValue("cm_calculobatch", Txtcalculobatch.Text)
        cmm.Parameters.AddWithValue("cm_formuladecalculo", Txtformuladecalculo.Text)
        cmm.Parameters.AddWithValue("cm_tipodemora", TxtTipodemora.Text)
        cmm.Parameters.AddWithValue("cm_valordemora", Txtvalordemora.Text)
        cmm.Parameters.AddWithValue("cm_moraminimo", Txtmoraminima.Text)

        cmm.ExecuteNonQuery()
        Mensaje1.Hide()

        MessageBox.Show("DATOS REGISTRADOS CON EXITO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inactivarcontroles()
        limpiarcontroles()

    End Sub

    Public Sub inactivarcontroles()
        GBformularcalculo.Enabled = False
        GBtipomora.Enabled = False
    End Sub
    Public Sub limpiarcontroles()
        RBgeneral.Checked = False
        RBporcarrera.Checked = False
        RBporcentajediario.Checked = False
        RBporcentajemensual.Checked = False
        RBporcentajesobresaldo.Checked = False
        RBtipocargo.Checked = False
        RBvalordiario.Checked = False
        RBvalordiarioymes.Checked = False
        RBvalorfijo.Checked = False
        Txtcalculobatch.Text = ""
        Txtcodigo.Text = ""
        Txtformuladecalculo.Text = ""
        Txtmoraminima.Text = ""
        TxtTipodemora.Text = ""
        Txtvalordemora.Text = ""
    End Sub

    Private Sub RBgeneral_CheckedChanged(sender As Object, e As EventArgs) Handles RBgeneral.CheckedChanged
        Txtformuladecalculo.Text = "General"
    End Sub

    Private Sub RBtipocargo_CheckedChanged(sender As Object, e As EventArgs) Handles RBtipocargo.CheckedChanged
        Txtformuladecalculo.Text = "Tipocargo"
    End Sub

    Private Sub RBporcarrera_CheckedChanged(sender As Object, e As EventArgs) Handles RBporcarrera.CheckedChanged
        Txtformuladecalculo.Text = "Porcarrera"
    End Sub

    Private Sub RBporcentajesobresaldo_CheckedChanged(sender As Object, e As EventArgs) Handles RBporcentajesobresaldo.CheckedChanged
        TxtTipodemora.Text = "porcentajesaldo"
    End Sub

    Private Sub RBvalordiario_CheckedChanged(sender As Object, e As EventArgs) Handles RBvalordiario.CheckedChanged
        TxtTipodemora.Text = "valordiario"
    End Sub

    Private Sub RBvalorfijo_CheckedChanged(sender As Object, e As EventArgs) Handles RBvalorfijo.CheckedChanged
        TxtTipodemora.Text = "valorfijo"
    End Sub

    Private Sub RBporcentajediario_CheckedChanged(sender As Object, e As EventArgs) Handles RBporcentajediario.CheckedChanged
        TxtTipodemora.Text = "porcentajediario"
    End Sub

    Private Sub RBporcentajemensual_CheckedChanged(sender As Object, e As EventArgs) Handles RBporcentajemensual.CheckedChanged
        TxtTipodemora.Text = "porcentajemensual"
    End Sub

    Private Sub RBvalordiarioymes_CheckedChanged(sender As Object, e As EventArgs) Handles RBvalordiarioymes.CheckedChanged
        TxtTipodemora.Text = "valordiariomes"
    End Sub

    Private Sub CHBcalculo_CheckedChanged(sender As Object, e As EventArgs) Handles CHBcalculo.CheckedChanged
        Txtcalculobatch.Text = "si"
    End Sub

    Private Sub MCCalculomora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CALCULOMORA.BackColor = Color.DarkOliveGreen
        CALCULOMORA.ForeColor = Color.White
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
        With CFinanciero
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CFinanciero)
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

    Private Sub CALCULOMORA_Click(sender As Object, e As EventArgs) Handles CALCULOMORA.Click

    End Sub
End Class