Public Class Mantenimiento
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GENERALESToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DefiniciónDeActitudesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GeneralToolStripMenuItem9_Click(sender As Object, e As EventArgs)
        ''With Cageneral
        ' .TopLevel = False
        '    Panel1.Controls.Add(Cageneral)
        ' .BringToFront()
        ' .Show()
        ' End With

        '  My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


    End Sub

    Private Sub JornadaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        '  My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


    End Sub

    Private Sub Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub ColegiosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Colegio.Click
        With CGeneral
            .TopLevel = False
            Panel1.Controls.Add(CGeneral)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        With PPPersona
            .TopLevel = False
            Panel1.Controls.Add(PPPersona)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub FamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliasToolStripMenuItem.Click
        With PFGeneral
            .TopLevel = False
            Panel1.Controls.Add(PFGeneral)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class