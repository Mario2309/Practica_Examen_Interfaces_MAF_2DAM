Public Class FormAlquiler
    ' Maneja el evento de clic en el item de menú "Volver", llama a la función para volver al menú de alquileres
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuAlquileres()
    End Sub

    ' Maneja el evento de clic en el item de menú "Alquilar", cambia el nombre del formulario y gestiona los componentes para alquilar una película
    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.alquilar()
        ModuloCambioEstadoAlquiler.alquilar()
        ModuloAccionesTablaAlquileres.cargarTitulosAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Devolver", cambia el nombre del formulario y gestiona los componentes para devolver una película
    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click
        ModuloCambioNombreFormularios.devolver()
        ModuloCambioEstadoAlquiler.devolver()
    End Sub

    ' Maneja el evento de clic en el item de menú "Consultar Alquileres de un Socio", limpia el ListView y cambia el nombre del formulario
    Private Sub ConcultarAlquileresDeUnSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcultarAlquileresDeUnSocioToolStripMenuItem.Click
        lwAlquileres.Items.Clear()
        ModuloCambioNombreFormularios.consultarAlquileresSocioConc()
        ModuloCambioEstadoAlquiler.alquileresSocioConc()
    End Sub

    ' Maneja el evento de clic en el item de menú "Historial de Alquileres", limpia el ListView, cambia el nombre del formulario y carga todos los alquileres
    Private Sub HistorialDeAlquileresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeAlquileresToolStripMenuItem.Click
        lwAlquileres.Items.Clear()
        ModuloCambioNombreFormularios.historialAlquileres()
        ModuloCambioEstadoAlquiler.alquileresTotales()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaAlquileres.CadenaConsultarAlquileres)
        ModuloAccionesTablaAlquileres.CargarAlListViewAlquiler()
    End Sub

    ' Maneja el evento de carga del formulario, configura el formulario para alquilar y gestiona los componentes necesarios
    Private Sub FormAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.alquilar()
        ModuloCambioEstadoAlquiler.alquilar()
    End Sub

    ' Maneja el evento de clic en el botón de limpieza de alquileres, llama al método de limpieza
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ModuloAccionesTablaAlquileres.limpiar()
    End Sub

    ' Maneja el evento de clic en el botón de acción de alquileres, ejecuta la acción correspondiente
    Private Sub btnAccionAlquileres_Click(sender As Object, e As EventArgs) Handles btnAccionAlquileres.Click
        ModuloCambioEstadoAlquiler.accionBnt()
    End Sub

    ' Maneja el evento de clic en el botón de búsqueda de DNI, realiza la búsqueda de alquileres o películas de acuerdo con el formulario
    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        If Text = "Devolver Pelicula" Then
            ModuloAccionesTablaAlquileres.CargarPeliculasAlquiladasSocioCB(tbDNI.Text.Trim())
            cbPeliculas.Enabled = True
        ElseIf Text = "Consultar Alquileres de un Socio" Then
            ModuloAccionesTablaAlquileres.CargarAlListViewAlquiler(ModuloAccionesTablaSocios.devolverIdMedianteDNI(tbDNI.Text.Trim()))
        End If
    End Sub

End Class