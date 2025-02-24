Imports System.Data.SQLite

Module ModuloAccionesTablaSocios

    Public CadenaConsultarSocios As String = "SELECT * FROM Socios"
    Public CadenaInsertarReg As String = "INSERT INTO Socios (Nombre, Apellido, DNI, Direccion, Telefono, Email, Fecha_Nacimiento, Fecha_Registro, Estado) VALUES (@Nm, @Apl, @DNI, @Dir, @Tel, @Eml, @fN, @fR, @est)"
    Public CadenaModificar As String = "update Peliculas set titulo=@Tl, director=@Dir, id_genero=@IdGen,  anio_publicacion=@Anio, calificacion=@Cal, descripcion=@Desc where num_registro=@idP"
    Public CadenaEliminarReg As String = "delete from Peliculas where num_registro=@idP"

    Public Sub CargarAlListViewSocios()
        Dim ListaPeliculas As ListViewItem

        FormSocios.lwSocios.Items.Clear()

        If DatosConjuntos Is Nothing OrElse DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormSocios.lwSocios.Items.Add(DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

    Public Sub limpiar()
        FormSocios.tbDNI.Clear()
        FormSocios.tbNombre.Clear()
        FormSocios.tbApellido.Clear()
        FormSocios.tbDireccion.Clear()
        FormSocios.tbTelefono.Clear()
        FormSocios.tbCorreo.Clear()
        FormSocios.cbEstado.SelectedIndex = 0
    End Sub

    Public Sub Agregar()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Validar campos
            ' validarCampos()

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaInsertarReg, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar parámetros (sin @idPel si es autoincremento)
            Comando.Parameters.AddWithValue("@Nm", FormSocios.tbDNI.Text.Trim())
            Comando.Parameters.AddWithValue("@Apl", FormSocios.tbApellido.Text.Trim())
            Comando.Parameters.AddWithValue("@DNI", FormSocios.tbDNI.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormSocios.tbDireccion.Text.Trim())
            Comando.Parameters.AddWithValue("@Tel", FormSocios.tbTelefono.Text.Trim())
            Comando.Parameters.AddWithValue("@Eml", FormSocios.tbCorreo.Text.Trim())

            ' Usar el valor de la fecha de nacimiento correctamente
            Comando.Parameters.AddWithValue("@fN", FormSocios.dtpNacimiento.Value)

            ' Registrar la fecha actual correctamente
            Comando.Parameters.AddWithValue("@fR", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            ' Asignar el estado
            Comando.Parameters.AddWithValue("@est", FormSocios.cbEstado.SelectedValue)

            ' Ejecutar la consulta directamente
            Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Socio agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("No se pudo agregar el socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al agregar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub


    Private Sub validarCampos()
        If String.IsNullOrWhiteSpace(FormPeliculas.tbTitulo.Text) OrElse
                   String.IsNullOrWhiteSpace(FormPeliculas.tbDirector.Text) OrElse
                   String.IsNullOrWhiteSpace(FormPeliculas.cbGenero.Text) OrElse
                   String.IsNullOrWhiteSpace(FormPeliculas.nudAnio.Text) OrElse
                   String.IsNullOrWhiteSpace(FormPeliculas.nudCalificacion.Text) OrElse
                   String.IsNullOrWhiteSpace(FormPeliculas.tbDescripcion.Text) Then

            MessageBox.Show("Todos los campos deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

End Module
