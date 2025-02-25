Imports System.Data.SQLite

Module ModuloAccionesTablaSocios

    Public CadenaConsultarSocios As String = "SELECT * FROM Socios"
    Public CadenaInsertarReg As String = "INSERT INTO Socios (Nombre, Apellido, DNI, Direccion, Telefono, Email, Fecha_Nacimiento, Fecha_Registro, Estado) VALUES (@Nm, @Apl, @DNI, @Dir, @Tel, @Eml, @fN, @fR, @est)"
    Public CadenaModificar As String = "update Peliculas set titulo=@Tl, director=@Dir, id_genero=@IdGen,  anio_publicacion=@Anio, calificacion=@Cal, descripcion=@Desc where num_registro=@idP"
    Public CadenaEliminarReg As String = "delete from Peliculas where num_registro=@idP"
    Public cadenaConsultarDNIs As String = "SELECT DNI FROM Socios"
    Public cadenaConsIdPorTitulo As String = "SELECT ID_Socio FROM Socios WHERE DNI = @dni"



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

            ' Convertir valores de fecha de alquiler
            Dim fechaAlquiler As Date

            ' Obtener la fecha actual del sistema
            Dim fechaActual As Date = DateTime.Now

            ' Usar el año ingresado para crear la fecha de alquiler con la fecha actual (mes y día del sistema)
            fechaAlquiler = New Date(fechaActual.Year, fechaActual.Month, fechaActual.Day)

            ' Verificar que la fecha es válida (esto no es estrictamente necesario si sabes que el año es válido)
            If fechaAlquiler > DateTime.Now Then
                MessageBox.Show("La fecha de alquiler no puede ser en el futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

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
            Comando.Parameters.AddWithValue("@fR", fechaAlquiler)

            ' Asignar el estado
            Comando.Parameters.AddWithValue("@est", FormSocios.cbEstado.Text.Trim())

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

    Public Sub cargarNombresAlComboBox()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(cadenaConsultarDNIs, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Ejecutar el comando y obtener los resultados
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            ' Limpiar el ComboBox antes de agregar los nuevos elementos
            FormSocios.cbDNI.Items.Clear()

            ' Leer los resultados y agregar al ComboBox
            While lector.Read()
                ' Supongamos que el título está en la primera columna (índice 0)
                FormSocios.cbDNI.Items.Add(lector.GetString(0))
            End While

            ' Cerrar el lector
            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al agregar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Function devolverIdMedianteDNI(dni As String) As Integer
        Dim id As Integer = -1 ' Valor por defecto en caso de no encontrar el resultado
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(cadenaConsIdPorTitulo, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Agregar parámetro al comando SQL
            Comando.Parameters.AddWithValue("@dni", dni)

            ' Ejecutar el comando y obtener el resultado
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            ' Si encontramos un registro, obtener el id
            If lector.Read() Then
                id = lector.GetInt32(0) ' Suponiendo que el id está en la primera columna (índice 0)
            End If

            ' Cerrar el lector
            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Retornar el id (o -1 si no se encontró)
        Return id
    End Function

End Module
