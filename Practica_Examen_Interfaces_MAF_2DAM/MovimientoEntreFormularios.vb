Module MovimientoEntreFormularios

    ' Muestra el formulario de selección de acciones y oculta el formulario de inicio
    Public Sub avanzarMenu()
        FormularioInicio.Hide()
        FormularioElecAccion.Show()
    End Sub

    ' Cierra la aplicación
    Public Sub Salir()
        Application.Exit()
    End Sub

    ' Vuelve al menú de películas y oculta el formulario de géneros
    Public Sub volverMenuPeliculas()
        FormPeliculas.Hide()
        FormularioElecAccion.Show()
    End Sub

    ' Muestra el formulario de películas y oculta el formulario de selección de acciones
    Public Sub avanzarPeliculas()
        FormularioElecAccion.Hide()
        FormPeliculas.Show()
    End Sub

    ' Vuelve al menú de socios y oculta el formulario de socios
    Public Sub volverMenuSocios()
        FormularioElecAccion.Show()
        FormSocios.Hide()
    End Sub

    ' Muestra el formulario de socios y oculta el formulario de selección de acciones
    Public Sub avanzarSocios()
        FormSocios.Show()
        FormularioElecAccion.Hide()
    End Sub

    ' Vuelve al menú de alquileres y oculta el formulario de alquileres
    Public Sub volverMenuAlquileres()
        FormAlquiler.Hide()
        FormularioElecAccion.Show()
    End Sub

    ' Muestra el formulario de alquileres y oculta el formulario de selección de acciones
    Public Sub avanzarAlquileres()
        FormularioElecAccion.Hide()
        FormAlquiler.Show()
    End Sub

    ' Vuelve al formulario de películas y oculta el formulario de géneros
    Public Sub volverGeneroPeliculas()
        FormPeliculas.Show()
        FormGeneros.Hide()
    End Sub

End Module
