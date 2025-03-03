Module ModuloEstadoComponentesSocios
    ' Método para configurar los componentes de la interfaz cuando se agrega un nuevo socio
    Public Sub agregarSocio()
        FormSocios.lblDNI.Visible = True
        FormSocios.tbDNI.Visible = True
        FormSocios.cbDNI.Visible = False
        FormSocios.btnBuscarSocio.Visible = False
        FormSocios.lblNombre.Visible = True
        FormSocios.tbNombre.Visible = True
        FormSocios.lblApellido.Visible = True
        FormSocios.tbApellido.Visible = True
        FormSocios.lblDireccion.Visible = True
        FormSocios.tbDireccion.Visible = True
        FormSocios.lblTelefono.Visible = True
        FormSocios.tbTelefono.Visible = True
        FormSocios.lblCorreo.Visible = True
        FormSocios.tbCorreo.Visible = True
        FormSocios.lblFechaNacimiento.Visible = True
        FormSocios.dtpNacimiento.Visible = True
        FormSocios.lblEstado.Visible = True
        FormSocios.cbEstado.Visible = True
        FormSocios.lblTituloSocios.Visible = False
        FormSocios.lwSocios.Visible = False
        FormSocios.btnAccionSocio.Text = "Agregar"


        FormSocios.tbDNI.Enabled = True
        FormSocios.tbNombre.Enabled = True
        FormSocios.tbApellido.Enabled = True
        FormSocios.tbDireccion.Enabled = True
        FormSocios.tbTelefono.Enabled = True
        FormSocios.tbCorreo.Enabled = True
        FormSocios.dtpNacimiento.Enabled = True
        FormSocios.cbEstado.Enabled = True
        FormSocios.btnAccionSocio.Enabled = True
    End Sub
    ' Método para configurar los componentes de la interfaz cuando se va a modificar un socio
    Public Sub modificarSocio()
        FormSocios.lblDNI.Visible = True
        FormSocios.tbDNI.Visible = False
        FormSocios.cbDNI.Visible = True
        FormSocios.btnBuscarSocio.Visible = True
        FormSocios.lblNombre.Visible = True
        FormSocios.tbNombre.Visible = True
        FormSocios.lblApellido.Visible = True
        FormSocios.tbApellido.Visible = True
        FormSocios.lblDireccion.Visible = True
        FormSocios.tbDireccion.Visible = True
        FormSocios.lblTelefono.Visible = True
        FormSocios.tbTelefono.Visible = True
        FormSocios.lblCorreo.Visible = True
        FormSocios.tbCorreo.Visible = True
        FormSocios.lblFechaNacimiento.Visible = True
        FormSocios.dtpNacimiento.Visible = True
        FormSocios.lblEstado.Visible = True
        FormSocios.cbEstado.Visible = True
        FormSocios.lblTituloSocios.Visible = False
        FormSocios.lwSocios.Visible = False

        FormSocios.tbNombre.Enabled = False
        FormSocios.tbApellido.Enabled = False
        FormSocios.tbDireccion.Enabled = False
        FormSocios.tbTelefono.Enabled = False
        FormSocios.tbCorreo.Enabled = False
        FormSocios.dtpNacimiento.Enabled = False
        FormSocios.cbEstado.Enabled = False
        FormSocios.btnAccionSocio.Enabled = False
        FormSocios.btnAccionSocio.Text = "Modificar"
    End Sub
    ' Método para configurar los componentes de la interfaz cuando se va a eliminar un socio
    Public Sub eliminarSocio()
        FormSocios.lblDNI.Visible = True
        FormSocios.tbDNI.Visible = False
        FormSocios.cbDNI.Visible = True
        FormSocios.btnBuscarSocio.Visible = True
        FormSocios.lblNombre.Visible = True
        FormSocios.tbNombre.Visible = True
        FormSocios.lblApellido.Visible = True
        FormSocios.tbApellido.Visible = True
        FormSocios.lblDireccion.Visible = True
        FormSocios.tbDireccion.Visible = True
        FormSocios.lblTelefono.Visible = True
        FormSocios.tbTelefono.Visible = True
        FormSocios.lblCorreo.Visible = True
        FormSocios.tbCorreo.Visible = True
        FormSocios.lblFechaNacimiento.Visible = True
        FormSocios.dtpNacimiento.Visible = True
        FormSocios.lblEstado.Visible = True
        FormSocios.cbEstado.Visible = True
        FormSocios.lblTituloSocios.Visible = False
        FormSocios.lwSocios.Visible = False

        FormSocios.tbNombre.Enabled = False
        FormSocios.tbApellido.Enabled = False
        FormSocios.tbDireccion.Enabled = False
        FormSocios.tbTelefono.Enabled = False
        FormSocios.tbCorreo.Enabled = False
        FormSocios.dtpNacimiento.Enabled = False
        FormSocios.cbEstado.Enabled = False
        FormSocios.btnAccionSocio.Enabled = True
        FormSocios.btnAccionSocio.Text = "Eliminar"
    End Sub

    ' Método para configurar los componentes de la interfaz cuando se va a consultar un socio
    Public Sub consultarSocioConc()
        FormSocios.lblDNI.Visible = True
        FormSocios.tbDNI.Visible = False
        FormSocios.cbDNI.Visible = True
        FormSocios.btnBuscarSocio.Visible = True
        FormSocios.lblNombre.Visible = True
        FormSocios.tbNombre.Visible = True
        FormSocios.lblApellido.Visible = True
        FormSocios.tbApellido.Visible = True
        FormSocios.lblDireccion.Visible = True
        FormSocios.tbDireccion.Visible = True
        FormSocios.lblTelefono.Visible = True
        FormSocios.tbTelefono.Visible = True
        FormSocios.lblCorreo.Visible = True
        FormSocios.tbCorreo.Visible = True
        FormSocios.lblFechaNacimiento.Visible = True
        FormSocios.dtpNacimiento.Visible = True
        FormSocios.lblEstado.Visible = True
        FormSocios.cbEstado.Visible = True
        FormSocios.lblTituloSocios.Visible = False
        FormSocios.lwSocios.Visible = False

        FormSocios.tbNombre.Enabled = False
        FormSocios.tbApellido.Enabled = False
        FormSocios.tbDireccion.Enabled = False
        FormSocios.tbTelefono.Enabled = False
        FormSocios.tbCorreo.Enabled = False
        FormSocios.dtpNacimiento.Enabled = False
        FormSocios.cbEstado.Enabled = False
        FormSocios.btnLimpiezaSocio.Visible = True
        FormSocios.btnAccionSocio.Enabled = False
    End Sub
    ' Método para ocultar todos los campos de edición y mostrar solo la lista de socios
    Public Sub consultarSocios()
        FormSocios.lblDNI.Visible = False
        FormSocios.tbDNI.Visible = False
        FormSocios.cbDNI.Visible = False
        FormSocios.btnBuscarSocio.Visible = False
        FormSocios.lblNombre.Visible = False
        FormSocios.tbNombre.Visible = False
        FormSocios.lblApellido.Visible = False
        FormSocios.tbApellido.Visible = False
        FormSocios.lblDireccion.Visible = False
        FormSocios.tbDireccion.Visible = False
        FormSocios.lblTelefono.Visible = False
        FormSocios.tbTelefono.Visible = False
        FormSocios.lblCorreo.Visible = False
        FormSocios.tbCorreo.Visible = False
        FormSocios.lblFechaNacimiento.Visible = False
        FormSocios.dtpNacimiento.Visible = False
        FormSocios.lblEstado.Visible = False
        FormSocios.cbEstado.Visible = False
        FormSocios.lblTituloSocios.Visible = True
        FormSocios.lwSocios.Visible = True
        FormSocios.btnAccionSocio.Visible = False
        FormSocios.btnLimpiezaSocio.Visible = False
    End Sub

    ' Método para determinar la acción a realizar (Agregar, Modificar o Eliminar) según el título del formulario
    Public Sub acctionBtn()
        If FormSocios.Text = "Agregar Socio" Then
            ModuloAccionesTablaSocios.Agregar()
        ElseIf FormSocios.Text = "Eliminar Socio" Then
            ModuloAccionesTablaSocios.eliminar()
        ElseIf FormSocios.Text = "Modificar Socio" Then
            ModuloAccionesTablaSocios.Modificar()
        End If
    End Sub
End Module
