Module MovimientoEntreFormularios
    Public Sub avanzarMenu()
        FormularioInicio.Hide()
        FormularioElecAccion.Show()
    End Sub
    Public Sub volverInicio()
        FormularioInicio.Show()
        FormularioElecAccion.Hide()
    End Sub
    Public Sub volverMenuPeliculas()
        FormPeliculas.Hide()
        FormularioElecAccion.Show()
    End Sub
    Public Sub avanzarPeliculas()
        FormularioElecAccion.Hide()
        FormPeliculas.Show()
    End Sub
    Public Sub volverMenuSocios()
        FormularioElecAccion.Show()
        FormSocios.Hide()
    End Sub
    Public Sub avanzarSocios()
        FormSocios.Show()
        FormularioElecAccion.Hide()
    End Sub
    Public Sub volverMenuAlquileres()
        FormAlquiler.Hide()
        FormularioElecAccion.Show()
    End Sub
    Public Sub avanzarAlquileres()
        FormularioElecAccion.Hide()
        FormAlquiler.Show()
    End Sub

    Public Sub volverGeneroPeliculas()
        FormPeliculas.Show()
        FormGeneros.Hide()
    End Sub
End Module
