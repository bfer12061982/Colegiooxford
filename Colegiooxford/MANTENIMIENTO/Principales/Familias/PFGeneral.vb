Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class PFGeneral
    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
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
        comandoregistro.CommandText = "SELECT * FROM f_general ORDER BY id DESC;"
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'Txttomardatos.Text = "Si"
        Else
            ' Txttomardatos.Text = "No"
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class