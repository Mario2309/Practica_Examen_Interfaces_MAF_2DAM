Public Class FormAlquiler
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuAlquileres()
    End Sub

    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.alquilar()
        ModuloCambioEstadoAlquiler.alquilar()
        ModuloAccionesTablaAlquileres.cargarTitulosAlComboBox()
    End Sub

    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click
        ModuloCambioNombreFormularios.devolver()
        ModuloCambioEstadoAlquiler.devolver()
    End Sub

    Private Sub ConcultarAlquileresDeUnSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcultarAlquileresDeUnSocioToolStripMenuItem.Click
        lwAlquileres.Items.Clear()
        ModuloCambioNombreFormularios.consultarAlquileresSocioConc()
        ModuloCambioEstadoAlquiler.alquileresSocioConc()
    End Sub

    Private Sub HistorialDeAlquileresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeAlquileresToolStripMenuItem.Click
        lwAlquileres.Items.Clear()
        ModuloCambioNombreFormularios.historialAlquileres()
        ModuloCambioEstadoAlquiler.alquileresTotales()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaAlquileres.CadenaConsultarAlquileres)
        ModuloAccionesTablaAlquileres.CargarAlListViewAlquiler()
    End Sub

    Private Sub FormAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.alquilar()
        ModuloCambioEstadoAlquiler.alquilar()
    End Sub

    Private Sub lblTituloAlquileres_Click(sender As Object, e As EventArgs) Handles lblTituloAlquileres.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ModuloAccionesTablaAlquileres.limpiar()
    End Sub

    Private Sub btnAccionAlquileres_Click(sender As Object, e As EventArgs) Handles btnAccionAlquileres.Click
        ModuloCambioEstadoAlquiler.accionBnt()
    End Sub

    Private Sub tbDNI_TextChanged(sender As Object, e As EventArgs) Handles tbDNI.TextChanged

    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        If Text = "Devolver Pelicula" Then
            ModuloAccionesTablaAlquileres.CargarPeliculasAlquiladasSocioCB(tbDNI.Text.Trim())
            cbPeliculas.Enabled = True
        ElseIf Text = "Consultar Alquileres de un Socio" Then
            ModuloAccionesTablaAlquileres.CargarAlListViewAlquiler(ModuloAccionesTablaSocios.devolverIdMedianteDNI(tbDNI.Text.Trim()))

        End If
    End Sub

    Private Sub cbPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeliculas.SelectedIndexChanged

    End Sub
End Class