
Imports MySql.Data.MySqlClient

Public Class Login
    Dim contador As Byte = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        ProgressBar.Visible = False
        ' Lblverificando.Visible = False
        ' Lbelbienvenido.Visible = False
        Lblincorrecto.Visible = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Then
            MessageBox.Show("Digita tu Usuario de Acceso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If txtPass.Text = "" Then
                MessageBox.Show("Digita tu Password de Acceso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Mensaje1.Show()
                'Lblverificando.Text = "VALIDANDO"
                Dim ccn As MySqlConnection = New MySqlConnection
                Dim cmd As MySqlCommand = New MySqlCommand
                ccn.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
                ccn.Open()

                Dim cmm As New MySqlCommand("validar_usuario", ccn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("v_usuario", txtUser.Text)
                cmm.Parameters.AddWithValue("v_contraseña", txtPass.Text)
                Dim r As MySqlDataReader
                r = cmm.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()

                    Dashboard.Lblnombreusuario.Text = r.GetString("nombre")
                    Dashboard.Lbltipousuario.Text = r.GetString("tipo")
                    Lbelbienvenido.Text = r.GetString("nombre")
                    Mensaje1.Hide()
                    Lblverificando.Text = "BIENVENIDO"
                    Timer1.Enabled = True
                    Lblincorrecto.Visible = False
                Else
                    Mensaje1.Hide()
                    Lblincorrecto.Visible = True
                End If
            End If
        End If


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar.Value < 100 Then
            contador = contador + 25
            ProgressBar.Value = contador
            Dashboard.Show()
            'Principal.Show()
            Me.Hide()
        Else
            Me.Hide()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub ProgressBar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
