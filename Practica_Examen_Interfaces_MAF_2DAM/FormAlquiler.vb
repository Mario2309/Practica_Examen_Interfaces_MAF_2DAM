Public Class FormAlquiler
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuAlquileres()
    End Sub

    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.alquilar()
    End Sub

    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click
        ModuloCambioNombreFormularios.devolver()
    End Sub

    Private Sub ConcultarAlquileresDeUnSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcultarAlquileresDeUnSocioToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarAlquileresSocioConc()
    End Sub

    Private Sub HistorialDeAlquileresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeAlquileresToolStripMenuItem.Click
        ModuloCambioNombreFormularios.historialAlquileres()
    End Sub
End Class