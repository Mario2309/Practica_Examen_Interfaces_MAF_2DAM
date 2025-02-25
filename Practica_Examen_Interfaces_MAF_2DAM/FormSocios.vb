Public Class FormSocios
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuSocios()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.eliminarSocio()
        ModuloEstadoComponentesSocios.eliminarSocio()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    Private Sub ConsultarSocioConcretoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSocioConcretoToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocioConc()
        ModuloEstadoComponentesSocios.consultarSocioConc()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    Private Sub ConsultarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSociosToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocios()
        ModuloEstadoComponentesSocios.consultarSocios()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaSocios.CadenaConsultarSocios)
        ModuloAccionesTablaSocios.CargarAlListViewSocios()
    End Sub

    Private Sub FormSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.modificarSocio()
        ModuloEstadoComponentesSocios.modificarSocio()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    Private Sub btnLimpiezaSocio_Click(sender As Object, e As EventArgs) Handles btnLimpiezaSocio.Click
        ModuloAccionesTablaSocios.limpiar()
    End Sub

    Private Sub btnAccionSocio_Click(sender As Object, e As EventArgs) Handles btnAccionSocio.Click
        ModuloEstadoComponentesSocios.acctionBtn()
    End Sub

    Private Sub btnBuscarSocio_Click(sender As Object, e As EventArgs) Handles btnBuscarSocio.Click
        If Text = "Eliminar Socio" Or Text = "Consultar Socio" Then
            ModuloAccionesTablaSocios.cargarCampos(ModuloAccionesTablaSocios.devolverIdMedianteDNI(cbDNI.Text.Trim()))
        ElseIf Text = "Modificar Socio" Then
            ModuloAccionesTablaSocios.cargarCampos(ModuloAccionesTablaSocios.devolverIdMedianteDNI(cbDNI.Text.Trim()))
            ModuloAccionesTablaSocios.activarCampos()
        End If
    End Sub
End Class