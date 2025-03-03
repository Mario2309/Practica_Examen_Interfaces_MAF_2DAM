Module ModuloEstadoComponentesPeliculas
    ' Método que configura la interfaz para agregar una nueva película
    Public Sub agregarPelicula()
        FormPeliculas.tbTitulo.Visible = True
        FormPeliculas.cbTitulo.Visible = False
        FormPeliculas.btnBuscarPelicula.Visible = False
        FormPeliculas.tbTitulo.Enabled = True
        FormPeliculas.tbTitulo.Visible = True
        FormPeliculas.cbTitulo.Enabled = False
        FormPeliculas.tbDirector.Enabled = True
        FormPeliculas.cbGenero.Enabled = True
        FormPeliculas.nudAnio.Enabled = True
        FormPeliculas.nudCalificacion.Enabled = True
        FormPeliculas.tbDescripcion.Enabled = True
        FormPeliculas.btnAccionPelicula.Text = "Agregar"
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
        FormPeliculas.lwPeliculas.Visible = False
        FormPeliculas.lblTituloPeliculas.Visible = False
        FormPeliculas.lblTituloPelicula.Visible = True
        FormPeliculas.lblDirector.Visible = True
        FormPeliculas.lblAnio.Visible = True
        FormPeliculas.lblGenero.Visible = True
        FormPeliculas.lblCalificacion.Visible = True
        FormPeliculas.lblDescripcion.Visible = True
        FormPeliculas.tbDirector.Visible = True
        FormPeliculas.cbGenero.Visible = True
        FormPeliculas.nudAnio.Visible = True
        FormPeliculas.nudCalificacion.Visible = True
        FormPeliculas.tbDescripcion.Visible = True
        FormPeliculas.btnAccionPelicula.Visible = True
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Visible = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
    End Sub
    ' Método que configura la interfaz para eliminar una película
    Public Sub eliminarPelicula()
        FormPeliculas.tbTitulo.Visible = False
        FormPeliculas.cbTitulo.Visible = True
        FormPeliculas.btnBuscarPelicula.Visible = True
        FormPeliculas.tbTitulo.Enabled = False
        FormPeliculas.cbTitulo.Enabled = True
        FormPeliculas.tbDirector.Enabled = False
        FormPeliculas.cbGenero.Enabled = False
        FormPeliculas.nudAnio.Enabled = False
        FormPeliculas.nudCalificacion.Enabled = False
        FormPeliculas.tbDescripcion.Enabled = False
        FormPeliculas.btnAccionPelicula.Text = "Eliminar"
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
        FormPeliculas.lwPeliculas.Visible = False
        FormPeliculas.lblTituloPeliculas.Visible = False
        FormPeliculas.lblTituloPelicula.Visible = True
        FormPeliculas.lblDirector.Visible = True
        FormPeliculas.lblAnio.Visible = True
        FormPeliculas.lblGenero.Visible = True
        FormPeliculas.lblCalificacion.Visible = True
        FormPeliculas.lblDescripcion.Visible = True
        FormPeliculas.tbDirector.Visible = True
        FormPeliculas.cbGenero.Visible = True
        FormPeliculas.nudAnio.Visible = True
        FormPeliculas.nudCalificacion.Visible = True
        FormPeliculas.tbDescripcion.Visible = True
        FormPeliculas.btnAccionPelicula.Visible = True
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Visible = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
    End Sub
    ' Método que configura la interfaz para modificar una película
    Public Sub modificarrPelicula()
        FormPeliculas.tbTitulo.Visible = False
        FormPeliculas.cbTitulo.Visible = True
        FormPeliculas.btnBuscarPelicula.Visible = True
        FormPeliculas.tbTitulo.Enabled = False
        FormPeliculas.cbTitulo.Enabled = True
        FormPeliculas.tbDirector.Enabled = False
        FormPeliculas.cbGenero.Enabled = False
        FormPeliculas.nudAnio.Enabled = False
        FormPeliculas.nudCalificacion.Enabled = False
        FormPeliculas.tbDescripcion.Enabled = False
        FormPeliculas.btnAccionPelicula.Text = "Modificar"
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
        FormPeliculas.lwPeliculas.Visible = False
        FormPeliculas.lblTituloPeliculas.Visible = False
        FormPeliculas.lblTituloPelicula.Visible = True
        FormPeliculas.lblDirector.Visible = True
        FormPeliculas.lblAnio.Visible = True
        FormPeliculas.lblGenero.Visible = True
        FormPeliculas.lblCalificacion.Visible = True
        FormPeliculas.lblDescripcion.Visible = True
        FormPeliculas.tbDirector.Visible = True
        FormPeliculas.cbGenero.Visible = True
        FormPeliculas.nudAnio.Visible = True
        FormPeliculas.nudCalificacion.Visible = True
        FormPeliculas.tbDescripcion.Visible = True
        FormPeliculas.btnAccionPelicula.Visible = True
        FormPeliculas.btnAccionPelicula.Enabled = True
        FormPeliculas.btnLimpiezaPeliculas.Visible = True
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
    End Sub
    ' Método que configura la interfaz para consultar una película
    Public Sub consultarPeliculaConc()
        FormPeliculas.tbTitulo.Visible = False
        FormPeliculas.cbTitulo.Visible = True
        FormPeliculas.btnBuscarPelicula.Visible = True
        FormPeliculas.tbTitulo.Enabled = False
        FormPeliculas.cbTitulo.Enabled = True
        FormPeliculas.tbDirector.Enabled = False
        FormPeliculas.cbGenero.Enabled = False
        FormPeliculas.nudAnio.Enabled = False
        FormPeliculas.nudCalificacion.Enabled = False
        FormPeliculas.tbDescripcion.Enabled = False
        FormPeliculas.btnAccionPelicula.Text = ""
        FormPeliculas.btnAccionPelicula.Enabled = False
        FormPeliculas.btnLimpiezaPeliculas.Enabled = True
        FormPeliculas.lwPeliculas.Visible = False
        FormPeliculas.lblTituloPeliculas.Visible = False
        FormPeliculas.lblTituloPelicula.Visible = True
        FormPeliculas.lblDirector.Visible = True
        FormPeliculas.lblAnio.Visible = True
        FormPeliculas.lblGenero.Visible = True
        FormPeliculas.lblCalificacion.Visible = True
        FormPeliculas.lblDescripcion.Visible = True
        FormPeliculas.tbDirector.Visible = True
        FormPeliculas.cbGenero.Visible = True
        FormPeliculas.nudAnio.Visible = True
        FormPeliculas.nudCalificacion.Visible = True
        FormPeliculas.tbDescripcion.Visible = True
        FormPeliculas.btnLimpiezaPeliculas.Visible = True
    End Sub
    ' Método que configura la interfaz para ver todas las películas
    Public Sub consultarPeliculas()
        FormPeliculas.cbTitulo.Visible = False
        FormPeliculas.tbTitulo.Visible = False
        FormPeliculas.btnBuscarPelicula.Visible = False
        FormPeliculas.tbDirector.Visible = False
        FormPeliculas.cbGenero.Visible = False
        FormPeliculas.nudAnio.Visible = False
        FormPeliculas.nudCalificacion.Visible = False
        FormPeliculas.tbDescripcion.Visible = False
        FormPeliculas.btnAccionPelicula.Text = ""
        FormPeliculas.btnAccionPelicula.Visible = False
        FormPeliculas.btnLimpiezaPeliculas.Visible = False
        FormPeliculas.lwPeliculas.Visible = True
        FormPeliculas.lblTituloPeliculas.Visible = True
        FormPeliculas.lblTituloPelicula.Visible = False
        FormPeliculas.lblDirector.Visible = False
        FormPeliculas.lblAnio.Visible = False
        FormPeliculas.lblGenero.Visible = False
        FormPeliculas.lblCalificacion.Visible = False
        FormPeliculas.lblDescripcion.Visible = False
    End Sub

    ' Método que ejecuta la acción correspondiente según el título del formulario (Agregar, Eliminar, Modificar)
    Public Sub accionBtn()
        If FormPeliculas.Text = "Agregar Pelicula" Then
            ModuloAccionesTablaPeliculas.Agregar()
        ElseIf FormPeliculas.Text = "Eliminar Pelicula" Then
            ModuloAccionesTablaPeliculas.eliminar()
        ElseIf FormPeliculas.Text = "Modificar Pelicula" Then
            ModuloAccionesTablaPeliculas.Modificar()
        End If
    End Sub
End Module
