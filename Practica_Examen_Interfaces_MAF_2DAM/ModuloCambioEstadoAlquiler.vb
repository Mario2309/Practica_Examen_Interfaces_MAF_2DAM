Module ModuloCambioEstadoAlquiler
    Public Sub alquilar()
        FormAlquiler.Width = 146
        FormAlquiler.Height = 29
        FormAlquiler.btnAccionAlquileres.Text = "Alquilar"
        FormAlquiler.btnAccionAlquileres.Visible = True
        FormAlquiler.lblTituloAlquileres.Visible = False
        FormAlquiler.btnBuscarDNI.Visible = False
        FormAlquiler.lblDNI.Visible = True
        FormAlquiler.lbPelicula.Visible = True
        FormAlquiler.cbPeliculas.Visible = True
        FormAlquiler.tbDNI.Visible = True
        FormAlquiler.lwAlquileres.Visible = False
        FormAlquiler.btnLimpiar.Visible = False
    End Sub

    Public Sub devolver()
        FormAlquiler.Width = 146
        FormAlquiler.Height = 29
        FormAlquiler.btnAccionAlquileres.Text = "Devolver"
        FormAlquiler.btnAccionAlquileres.Visible = True

    End Sub

    Public Sub alquileresSocioConc()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 373
        FormAlquiler.btnAccionAlquileres.Visible = True

    End Sub

    Public Sub alquileresTotales()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 373
        FormAlquiler.btnAccionAlquileres.Visible = False

    End Sub

End Module
