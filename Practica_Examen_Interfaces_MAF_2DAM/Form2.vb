Public Class FormularioElecAccion

    ' Evento del botón btnAbrirPeliculas que avanza al formulario de películas
    Private Sub btnAbrirPeliculas_Click(sender As Object, e As EventArgs) Handles btnAbrirPeliculas.Click
        MovimientoEntreFormularios.avanzarPeliculas()
    End Sub

    ' Evento del botón btnVolverInicio que desconecta la base de datos y sale de la aplicación
    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        ModuloConexionBaseDeDatos.DesconectarBD() ' Desconecta la base de datos
        MovimientoEntreFormularios.Salir() ' Sale de la aplicación
    End Sub

    ' Evento del botón btnAbrirSocios que avanza al formulario de socios
    Private Sub btnAbrirSocios_Click(sender As Object, e As EventArgs) Handles btnAbrirSocios.Click
        MovimientoEntreFormularios.avanzarSocios()
    End Sub

    ' Evento del botón btnAbrirAlquiler que avanza al formulario de alquileres
    Private Sub btnAbrirAlquiler_Click(sender As Object, e As EventArgs) Handles btnAbrirAlquiler.Click
        MovimientoEntreFormularios.avanzarAlquileres()
    End Sub
End Class
