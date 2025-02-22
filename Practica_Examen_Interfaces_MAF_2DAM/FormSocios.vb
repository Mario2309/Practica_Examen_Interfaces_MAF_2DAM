Public Class FormSocios
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuSocios()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.eliminarSocio()
        ModuloEstadoComponentesSocios.eliminarSocio()
    End Sub

    Private Sub ConsultarSocioConcretoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSocioConcretoToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocioConc()
        ModuloEstadoComponentesSocios.consultarSocioConc()
    End Sub

    Private Sub ConsultarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSociosToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocios()
        ModuloEstadoComponentesSocios.consultarSocios()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaSocios.CadenaConsultarSocios)
        ModuloAccionesTablaSocios.CargarAlListViewSocios()
    End Sub

    Private Sub FormSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.modificarSocio()
        ModuloEstadoComponentesSocios.modificarSocio()
    End Sub

End Class