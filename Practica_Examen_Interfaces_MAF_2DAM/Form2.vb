Public Class FormularioElecAccion

    Private Sub btnAbrirPeliculas_Click(sender As Object, e As EventArgs) Handles btnAbrirPeliculas.Click
        MovimientoEntreFormularios.avanzarPeliculas()
    End Sub

    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        ModuloConexionBaseDeDatos.DesconectarBD()
        MovimientoEntreFormularios.Salir()
    End Sub

    Private Sub btnAbrirSocios_Click(sender As Object, e As EventArgs) Handles btnAbrirSocios.Click
        MovimientoEntreFormularios.avanzarSocios()
    End Sub

    Private Sub btnAbrirAlquiler_Click(sender As Object, e As EventArgs) Handles btnAbrirAlquiler.Click
        MovimientoEntreFormularios.avanzarAlquileres()
    End Sub
End Class