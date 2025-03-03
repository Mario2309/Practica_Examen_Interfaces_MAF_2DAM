Public Class FormPeliculas
    ' Maneja el evento de clic en el item de menú "Volver", llama a la función para volver al menú de películas
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuPeliculas()
    End Sub

    ' Maneja el evento de clic en el item de menú "Agregar", cambia el nombre del formulario y carga los generos y componentes relacionados
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.agregarPelicula()
        ModuloAccionesTablaGeneros.cargarGenerosAlComboBox()
        ModuloEstadoComponentesPeliculas.agregarPelicula()
    End Sub

    ' Maneja el evento de clic en el item de menú "Eliminar", cambia el nombre del formulario y gestiona los componentes para eliminación
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.eliminarPelicula()
        ModuloEstadoComponentesPeliculas.eliminarPelicula()
        ModuloAccionesTablaPeliculas.cargarTitulosAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Consultar Pelicula", cambia el nombre del formulario y carga los títulos para consulta
    Private Sub ConsultarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPeliculaToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarPeliculaConc()
        ModuloEstadoComponentesPeliculas.consultarPeliculaConc()
        ModuloAccionesTablaPeliculas.cargarTitulosAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Consultar Peliculas", cambia el nombre del formulario y carga todos los registros de películas
    Private Sub ConsultarPeliculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPeliculasToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarPeliculas()
        ModuloEstadoComponentesPeliculas.consultarPeliculas()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaPeliculas.CadenaConsultarPeliculas)
        ModuloAccionesTablaPeliculas.CargarAlListViewPeliculas()
    End Sub

    ' Maneja el evento de carga del formulario, configura el formulario de agregar película y carga los géneros
    Private Sub FormPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.agregarPelicula()
        ModuloAccionesTablaGeneros.cargarGenerosAlComboBox()
        ModuloEstadoComponentesPeliculas.agregarPelicula()
    End Sub

    ' Maneja el evento de clic en el item de menú "Modificar", cambia el nombre del formulario y prepara los componentes para modificar
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.modificarPelicula()
        ModuloEstadoComponentesPeliculas.modificarrPelicula()
        ModuloAccionesTablaPeliculas.cargarTitulosAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Generos", abre el formulario de géneros y carga los géneros
    Private Sub GenerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerosToolStripMenuItem.Click
        FormGeneros.Show()
        Me.Hide()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaGeneros.CadenaConsultarGeneros)
        ModuloAccionesTablaGeneros.CargarAlListViewGeneros()
    End Sub

    ' Maneja el evento de clic en el botón de limpieza de películas, llama al método de limpieza
    Private Sub btnLimpiezaPeliculas_Click(sender As Object, e As EventArgs) Handles btnLimpiezaPeliculas.Click
        ModuloAccionesTablaPeliculas.limpiar()
    End Sub

    ' Maneja el evento de clic en el botón de acción de película, ejecuta la acción de acuerdo al formulario actual
    Private Sub btnAccionPelicula_Click(sender As Object, e As EventArgs) Handles btnAccionPelicula.Click
        ModuloEstadoComponentesPeliculas.accionBtn()
    End Sub

    ' Maneja el evento de clic en el botón de búsqueda de película, carga los campos correspondientes según la acción seleccionada
    Private Sub btnBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btnBuscarPelicula.Click
        If Text = "Eliminar Pelicula" Or Text = "Consultar Pelicula" Then
            ModuloAccionesTablaPeliculas.cargarCampos(ModuloAccionesTablaPeliculas.devolverIdMedianteTitulo(cbTitulo.Text.Trim()))
        ElseIf Text = "Modificar Pelicula" Then
            ModuloAccionesTablaPeliculas.cargarCampos(ModuloAccionesTablaPeliculas.devolverIdMedianteTitulo(cbTitulo.Text.Trim()))
            ModuloAccionesTablaPeliculas.ActivarCamposModificarPelis()
        End If
    End Sub

End Class