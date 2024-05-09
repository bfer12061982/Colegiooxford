Imports MySql.Data.MySqlClient
Public Class Informacionmant


    Private Sub Informacionmant_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Public Sub cargardatogeneral()

        Dim conexionlinf As MySqlConnection = New MySqlConnection
        Dim comandolinf As MySqlCommand = New MySqlCommand
        comandolinf.Connection = conexionlinf
        'Lblcargando.Visible = True
        Try
            conexionlinf.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
            conexionlinf.Open()
            '  MsgBox("CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("Select * FROM c_general", conexionlinf)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGinformacion.DataSource = ds.Tables(0)
            Mensaje1.Hide()
            llenargridgeneral()

        Else
            DGinformacion.DataSource = ds.Tables(0)
            Mensaje1.Hide()
            ' configurargridjornada()

        End If
    End Sub

    Public Sub cargardatoacademico()
        ' Recarga.Show()
        Dim conexionlinf As MySqlConnection = New MySqlConnection
        Dim comandolinf As MySqlCommand = New MySqlCommand
        comandolinf.Connection = conexionlinf
        'Lblcargando.Visible = True
        Try
            conexionlinf.ConnectionString = "Server = 109.106.246.151; 
                                        Database=u308309252_sistema; 
                                        Uid=u308309252_sistema; 
                                        Password=Sistema2024@"
            conexionlinf.Open()
            '  MsgBox("CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("Select * FROM c_academicos", conexionlinf)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGinformacion.DataSource = ds.Tables(0)
            Mensaje1.Hide()
            llenargridacademico()

        Else
            DGinformacion.DataSource = ds.Tables(0)
            Mensaje1.Hide()
            ' configurargridjornada()

        End If
    End Sub
    Public Sub llenargridgeneral()

        Try
            DGinformacion.Columns(0).Visible = False
            DGinformacion.Columns(1).Visible = True
            DGinformacion.Columns(2).HeaderText = "Nombre"
            DGinformacion.Columns(3).HeaderText = "Nombre Corto"
            DGinformacion.Columns(4).HeaderText = "Religion"
            DGinformacion.Columns(5).HeaderText = "Direccion"
            DGinformacion.Columns(6).HeaderText = "Zona"
            DGinformacion.Columns(7).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(9).HeaderText = "Departamento"
            DGinformacion.Columns(10).HeaderText = "Municipio"
            DGinformacion.Columns(11).HeaderText = "Telefono"
            DGinformacion.Columns(12).Visible = False
            DGinformacion.Columns(13).Visible = False
            DGinformacion.Columns(14).Visible = False
            DGinformacion.Columns(15).Visible = False
            DGinformacion.Columns(16).Visible = False
            DGinformacion.Columns(17).HeaderText = "Director"
            DGinformacion.Columns(18).HeaderText = "Coordinador"
            DGinformacion.Columns(19).Visible = False
            DGinformacion.Columns(20).Visible = False
            DGinformacion.Columns(21).Visible = False
            DGinformacion.Columns(22).Visible = False
            DGinformacion.Columns(23).Visible = False
            DGinformacion.Columns(24).Visible = False
            DGinformacion.Columns(25).Visible = False
            DGinformacion.Columns(26).Visible = False
            DGinformacion.Columns(27).Visible = False
            DGinformacion.Columns(28).Visible = False



        Catch ex As Exception
        End Try

    End Sub

    Public Sub llenargridacademico()

        Try
            DGinformacion.Columns(0).Visible = False
            DGinformacion.Columns(1).Visible = True
            DGinformacion.Columns(2).HeaderText = "Inicio Clases"
            DGinformacion.Columns(3).HeaderText = "Actual"
            DGinformacion.Columns(4).HeaderText = "Siguiente"
            DGinformacion.Columns(5).HeaderText = "Punteo Oficial"
            DGinformacion.Columns(6).HeaderText = "Punteo Interno"
            DGinformacion.Columns(7).HeaderText = "Cuadro Honor"
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False
            DGinformacion.Columns(8).Visible = False

        Catch ex As Exception
        End Try

    End Sub

    Private Sub alternarColorFilasDatagridview(ByVal dgv As DataGridView)

        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PTsalir_Click_1(sender As Object, e As EventArgs) Handles PTsalir1.Click

        With CGeneral
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CGeneral)
            .BringToFront()
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub DGinformacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGinformacion.CellContentClick
        CGeneral.Txtcodigo.Text = DGinformacion.CurrentRow.Cells("codigo").Value.ToString
        CGeneral.Txtnombre.Text = DGinformacion.CurrentRow.Cells("nombre").Value.ToString
        CGeneral.Txtnombrecorto.Text = DGinformacion.CurrentRow.Cells("nombrecorto").Value.ToString
        CGeneral.Txtreligion.Text = DGinformacion.CurrentRow.Cells("religion").Value.ToString
        CGeneral.Txtdireccion.Text = DGinformacion.CurrentRow.Cells("direccion").Value.ToString
        CGeneral.Txtzona.Text = DGinformacion.CurrentRow.Cells("zona").Value.ToString
        CGeneral.Txtcodigopostal.Text = DGinformacion.CurrentRow.Cells("codigopostal").Value.ToString
        CGeneral.Cmbdepartamento.Text = DGinformacion.CurrentRow.Cells("departamento").Value.ToString
        CGeneral.Cmbmunicipio.Text = DGinformacion.CurrentRow.Cells("municipio").Value.ToString
        CGeneral.Txttelefono.Text = DGinformacion.CurrentRow.Cells("telefono").Value.ToString
        CGeneral.Txtfax.Text = DGinformacion.CurrentRow.Cells("fax").Value.ToString
        CGeneral.Txtmatriculas.Text = DGinformacion.CurrentRow.Cells("matriculasext").Value.ToString
        CGeneral.Txttipoalumno.Text = DGinformacion.CurrentRow.Cells("tipocolegio").Value.ToString
        CGeneral.Txtdirector.Text = DGinformacion.CurrentRow.Cells("directorrl").Value.ToString
        CGeneral.Txtcoordinador.Text = DGinformacion.CurrentRow.Cells("coordinadorge").Value.ToString
        CGeneral.Txtcentrocosto.Text = DGinformacion.CurrentRow.Cells("centrocosto").Value.ToString
        CGeneral.txt_ruta.Text = DGinformacion.CurrentRow.Cells("imagen").Value.ToString
        CGeneral.Dtfechaautorizacion.Text = DGinformacion.CurrentRow.Cells("fechaautorizacion").Value.ToString
        CGeneral.Txtinscripcionh.Text = DGinformacion.CurrentRow.Cells("inscripcionhabilitada").Value.ToString
        'GeneralCo.buscarimagen()
        If CGeneral.Txttipoalumno.Text = "hombres" Then
            CGeneral.Rbhombres.Checked = True
        End If

        If CGeneral.Txttipoalumno.Text = "mujeres" Then
            CGeneral.Rbmujeres.Checked = True
        End If

        If CGeneral.Txttipoalumno.Text = "mixto" Then
            CGeneral.Rbmixto.Checked = True
        End If

        If CGeneral.Txtinscripcionh.Text = "actual" Then
            CGeneral.Rbactual.Checked = True
        End If

        If CGeneral.Txtinscripcionh.Text = "siguiente" Then
            CGeneral.Rbsiguiente.Checked = True
        End If

        If CGeneral.Txtinscripcionh.Text = "ambos" Then
            CGeneral.Rbambos.Checked = True
        End If
        Me.Hide()
    End Sub

    Private Sub Ptsalir2_Click(sender As Object, e As EventArgs) Handles Ptsalir2.Click

        With CAcademicos
            .TopLevel = False
            Mantenimiento.Panel1.Controls.Add(CAcademicos)
            .BringToFront()
            .Show()
            Me.Hide()
        End With
    End Sub
End Class