Public Class FormSocios
    ' Maneja el evento de clic en el item de menú "Volver", llama a la función para volver al menú de socios
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverMenuSocios()
    End Sub

    ' Maneja el evento de clic en el item de menú "Agregar", cambia el nombre del formulario y gestiona los componentes para agregar un socio
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    ' Maneja el evento de clic en el item de menú "Eliminar", cambia el nombre del formulario y gestiona los componentes para eliminar un socio
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.eliminarSocio()
        ModuloEstadoComponentesSocios.eliminarSocio()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Consultar Socio Concreto", cambia el nombre del formulario y carga los nombres de los socios
    Private Sub ConsultarSocioConcretoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSocioConcretoToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocioConc()
        ModuloEstadoComponentesSocios.consultarSocioConc()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    ' Maneja el evento de clic en el item de menú "Consultar Socios", cambia el nombre del formulario, conecta la base de datos y carga todos los socios
    Private Sub ConsultarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSociosToolStripMenuItem.Click
        ModuloCambioNombreFormularios.consultarSocios()
        ModuloEstadoComponentesSocios.consultarSocios()
        ModuloConexionBaseDeDatos.ConectarBD(ModuloAccionesTablaSocios.CadenaConsultarSocios)
        ModuloAccionesTablaSocios.CargarAlListViewSocios()
    End Sub

    ' Maneja el evento de carga del formulario, configura el formulario de agregar socio y gestiona los componentes necesarios
    Private Sub FormSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloCambioNombreFormularios.agregarSocio()
        ModuloEstadoComponentesSocios.agregarSocio()
    End Sub

    ' Maneja el evento de clic en el item de menú "Modificar", cambia el nombre del formulario y prepara los componentes para modificar un socio
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModuloCambioNombreFormularios.modificarSocio()
        ModuloEstadoComponentesSocios.modificarSocio()
        ModuloAccionesTablaSocios.cargarNombresAlComboBox()
    End Sub

    ' Maneja el evento de clic en el botón de limpieza de socios, llama al método de limpieza
    Private Sub btnLimpiezaSocio_Click(sender As Object, e As EventArgs) Handles btnLimpiezaSocio.Click
        ModuloAccionesTablaSocios.limpiar()
    End Sub

    ' Maneja el evento de clic en el botón de acción de socio, ejecuta la acción de acuerdo al formulario actual
    Private Sub btnAccionSocio_Click(sender As Object, e As EventArgs) Handles btnAccionSocio.Click
        ModuloEstadoComponentesSocios.acctionBtn()
    End Sub

    ' Maneja el evento de clic en el botón de búsqueda de socio, carga los campos correspondientes según la acción seleccionada
    Private Sub btnBuscarSocio_Click(sender As Object, e As EventArgs) Handles btnBuscarSocio.Click
        If Text = "Eliminar Socio" Or Text = "Consultar Socio" Then
            ModuloAccionesTablaSocios.cargarCampos(ModuloAccionesTablaSocios.devolverIdMedianteDNI(cbDNI.Text.Trim()))
        ElseIf Text = "Modificar Socio" Then
            ModuloAccionesTablaSocios.cargarCampos(ModuloAccionesTablaSocios.devolverIdMedianteDNI(cbDNI.Text.Trim()))
            ModuloAccionesTablaSocios.activarCampos()
        End If
    End Sub

End Class