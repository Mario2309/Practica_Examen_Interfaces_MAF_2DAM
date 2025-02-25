Module ModuloCambioEstadoAlquiler
    Public Sub alquilar()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 228
        FormAlquiler.btnAccionAlquileres.Text = "Alquilar"
        FormAlquiler.btnAccionAlquileres.Visible = True
        FormAlquiler.lblTituloAlquileres.Visible = False
        FormAlquiler.btnBuscarDNI.Visible = False
        FormAlquiler.lblDNI.Visible = True
        FormAlquiler.lbPelicula.Visible = True
        FormAlquiler.cbPeliculas.Visible = True
        FormAlquiler.cbPeliculas.Enabled = True
        FormAlquiler.tbDNI.Visible = True
        FormAlquiler.lwAlquileres.Visible = False
        FormAlquiler.btnLimpiar.Visible = False
    End Sub

    Public Sub devolver()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 228
        FormAlquiler.btnAccionAlquileres.Text = "Devolver"
        FormAlquiler.btnAccionAlquileres.Visible = True
        FormAlquiler.lblTituloAlquileres.Visible = False
        FormAlquiler.btnBuscarDNI.Visible = True
        FormAlquiler.lblDNI.Visible = True
        FormAlquiler.lbPelicula.Visible = True
        FormAlquiler.cbPeliculas.Visible = True
        FormAlquiler.cbPeliculas.Enabled = False
        FormAlquiler.tbDNI.Visible = True
        FormAlquiler.lwAlquileres.Visible = False
        FormAlquiler.btnLimpiar.Visible = False
    End Sub

    Public Sub alquileresSocioConc()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 373
        FormAlquiler.lblTituloAlquileres.Location = New Point(299, FormAlquiler.lblTituloAlquileres.Location.Y)
        FormAlquiler.btnAccionAlquileres.Visible = False
        FormAlquiler.lblTituloAlquileres.Visible = True
        FormAlquiler.btnBuscarDNI.Visible = True
        FormAlquiler.lblDNI.Visible = True
        FormAlquiler.lbPelicula.Visible = False
        FormAlquiler.cbPeliculas.Visible = False
        FormAlquiler.tbDNI.Visible = True
        FormAlquiler.lwAlquileres.Visible = True
        FormAlquiler.btnLimpiar.Visible = True
    End Sub

    Public Sub alquileresTotales()
        FormAlquiler.Width = 557
        FormAlquiler.Height = 373
        FormAlquiler.lblTituloAlquileres.Location = New Point(212, FormAlquiler.lblTituloAlquileres.Location.Y)
        FormAlquiler.btnAccionAlquileres.Visible = False
        FormAlquiler.lblTituloAlquileres.Visible = True
        FormAlquiler.btnBuscarDNI.Visible = False
        FormAlquiler.lblDNI.Visible = False
        FormAlquiler.lbPelicula.Visible = False
        FormAlquiler.cbPeliculas.Visible = False
        FormAlquiler.tbDNI.Visible = False
        FormAlquiler.lwAlquileres.Visible = True
        FormAlquiler.btnLimpiar.Visible = False
    End Sub


    Public Sub accionBnt()
        If FormAlquiler.Text = "Alquilar Pelicula" Then
            ModuloAccionesTablaAlquileres.Agregar()
        End If
    End Sub
End Module
