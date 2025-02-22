Public Class FormPeliculas
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuPeliculas()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.agregarPelicula()
        ModuloEstadoComponentesPeliculas.agregarPelicula()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.eliminarPelicula()
        ModuloEstadoComponentesPeliculas.eliminarPelicula()
    End Sub

    Private Sub ConsultarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPeliculaToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarPeliculaConc()
        ModuloEstadoComponentesPeliculas.consultarPeliculaConc()
    End Sub

    Private Sub ConsultarPeliculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPeliculasToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarPeliculas()
        ModuloEstadoComponentesPeliculas.consultarPeliculas()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaPeliculas.CadenaConsultarPeliculas)
        ModuloAccionesTablaPeliculas.CargarAlListViewPeliculas()
    End Sub

    Private Sub FormPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.agregarPelicula()
        ModuloEstadoComponentesPeliculas.agregarPelicula()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.modificarPelicula()
        ModuloEstadoComponentesPeliculas.modificarrPelicula()
    End Sub

    Private Sub GenerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerosToolStripMenuItem.Click
        FormGeneros.Show()
        Me.Hide()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloConexionBaseDeDatos.CadenaConsultarGeneros)
        ModuloConexionBaseDeDatos.CargarAlListViewGeneros()
    End Sub
End Class