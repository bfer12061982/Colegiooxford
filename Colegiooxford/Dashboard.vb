Public Class Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Dashb
            .TopLevel = False
            Panel5.Controls.Add(Dashb)
            .BringToFront()
            .Show()
            Button1.BackColor = Color.DarkOliveGreen
            Button1.ForeColor = Color.White
            Button6.BackColor = Color.White
            Button6.ForeColor = Color.FromArgb(60, 90, 130)

            CGeneral.Txtcodigo.Enabled = False
            CGeneral.Txtnombre.Enabled = False
            CGeneral.Txtnombrecorto.Enabled = False
            CGeneral.Txtreligion.Enabled = False
            CGeneral.Txtdireccion.Enabled = False
            CGeneral.Txtzona.Enabled = False
            CGeneral.Txtcodigopostal.Enabled = False
            ' GeneralCo.Cmbpais.Enabled = False
            CGeneral.Cmbdepartamento.Enabled = False
            CGeneral.Cmbmunicipio.Enabled = False
            CGeneral.Txttelefono.Enabled = False
            CGeneral.Txtfax.Enabled = False
            CGeneral.Txtmatriculas.Enabled = False
            CGeneral.Cmbmdepartamento.Enabled = False
            CGeneral.Cmbmmunicipio.Enabled = False
            CGeneral.Rbhombres.Enabled = False
            CGeneral.Rbmujeres.Enabled = False
            CGeneral.Rbmixto.Enabled = False
            CGeneral.Txtdirector.Enabled = False
            CGeneral.Dtfechaautorizacion.Enabled = False
            CGeneral.Txtresolucion.Enabled = False
            CGeneral.Rbactual.Enabled = False
            CGeneral.Rbsiguiente.Enabled = False
            CGeneral.Rbambos.Enabled = False
            CGeneral.Btneditar.Enabled = False
            CGeneral.Btnbuscarimagen.Enabled = False
            CGeneral.Btnregistrar.Enabled = False

        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With Mantenimiento
            .TopLevel = False
            Panel5.Controls.Add(Mantenimiento)
            .BringToFront()
            .Show()
            Button6.BackColor = Color.DarkOliveGreen
            Button6.ForeColor = Color.White
            Button1.BackColor = Color.White
            Button1.ForeColor = Color.FromArgb(60, 90, 130)
        End With
    End Sub
End Class