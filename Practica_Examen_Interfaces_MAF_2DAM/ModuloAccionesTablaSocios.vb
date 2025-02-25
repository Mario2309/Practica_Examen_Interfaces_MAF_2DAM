Imports System.Data.SQLite

Module ModuloAccionesTablaSocios

    Public CadenaConsultarSocios As String = "SELECT * FROM Socios"
    Private CadenaInsertarReg As String = "INSERT INTO Socios (DNI, Nombre, Apellido, Direccion, Telefono, Email, Fecha_Nacimiento, Fecha_Registro, Estado) VALUES (@DNI, @Nm, @Apl, @Dir, @Tel, @Eml, @fN, @fR, @est)"
    Private CadenaModificar As String = "update Socios set Nombre=@Nm, Apellido=@Apl, DNI=@DNI, Direccion=@Dir, Telefono=@Tel, Email=@Eml, Fecha_Nacimiento=@fN, Estado=@est WHERE ID_Socio = @idS"
    Private CadenaEliminarReg As String = "delete from Socios where ID_Socio = @idS"
    Private cadenaConsultarDNIs As String = "SELECT DNI FROM Socios"
    Private cadenaConsultarPorDnis As String = "SELECT Nombre, Apellido, DNI, Direccion, Telefono, Email, Fecha_Nacimiento, Fecha_Registro, Estado FROM Socios WHERE ID_Socio = @idS"
    Private cadenaConsIdPorTitulo As String = "SELECT ID_Socio FROM Socios WHERE DNI = @dni"



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

    Public Sub cargarCampos(id As String)
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL con parámetro
            Dim Comando As New SQLiteCommand(cadenaConsultarPorDnis, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar el parámetro @id al comando
            Comando.Parameters.AddWithValue("@idS", id)

            ' Ejecutar el comando y obtener los resultados
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            If lector.Read() Then
                ' Ocultar el ComboBox de Títulos y el botón de búsqueda
                FormSocios.cbDNI.Visible = False
                FormSocios.btnBuscarSocio.Visible = False

                ' Mostrar el TextBox de Títulos
                FormSocios.tbDNI.Visible = True

                ' Asignar los valores a los controles del formulario
                FormSocios.tbNombre.Text = If(lector.IsDBNull(0), "", lector.GetString(0)) ' Nombre (índice 1)
                FormSocios.tbApellido.Text = If(lector.IsDBNull(1), "", lector.GetString(1)) ' Apellido (índice 2)
                FormSocios.tbDNI.Text = If(lector.IsDBNull(2), "", lector.GetString(2)) ' DNI (índice 2)
                FormSocios.tbDireccion.Text = If(lector.IsDBNull(3), 0, lector.GetString(3)) ' Direccion (índice 4)
                FormSocios.tbTelefono.Text = If(lector.IsDBNull(4), 0, lector.GetString(4)) ' Telefono (índice 5)
                FormSocios.tbCorreo.Text = If(lector.IsDBNull(5), "", lector.GetString(5)) ' Correo (índice 6)
                FormSocios.dtpNacimiento.Text = If(lector.IsDBNull(6), "", lector.GetDateTime(6)) ' Fecha nacimiento (indice 7)
                FormSocios.cbEstado.Text = If(lector.IsDBNull(8), "", lector.GetString(8)) ' Estado del socio (indice 9 (el 8 es la fecha de registro))
            End If

            ' Cerrar el lector
            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Sub eliminar()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            Dim Comando = New SQLiteCommand(CadenaEliminarReg, ConexionNueva)


            ' Add a parameter for the command (ensure the value is correct, like a number)
            Comando.Parameters.AddWithValue("@idS", devolverIdMedianteDNI(FormSocios.cbDNI.Text))

            Comando.ExecuteNonQuery()


            limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Sub Modificar()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Validar campos


            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaModificar, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar parámetros (sin @idPel si es autoincremento)
            Comando.Parameters.AddWithValue("@DNI", FormSocios.tbDNI.Text.Trim())
            Comando.Parameters.AddWithValue("@Nm", FormSocios.tbNombre.Text.Trim())
            Comando.Parameters.AddWithValue("@Apl", FormSocios.tbApellido.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormSocios.tbDireccion.Text.Trim())
            Comando.Parameters.AddWithValue("@Eml", FormSocios.tbCorreo.Text.Trim())
            Comando.Parameters.AddWithValue("@Tel", FormSocios.tbTelefono.Text.Trim())

            ' Usar el valor de la fecha de nacimiento correctamente
            Comando.Parameters.AddWithValue("@fN", FormSocios.dtpNacimiento.Value)

            ' Asignar el estado
            Comando.Parameters.AddWithValue("@est", FormSocios.cbEstado.Text.Trim())

            ' Determinar el id
            Comando.Parameters.AddWithValue("@idS", devolverIdMedianteDNI(FormSocios.cbDNI.Text.Trim()))

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

    Public Sub activarCampos()
        FormSocios.tbNombre.Enabled = True
        FormSocios.tbApellido.Enabled = True
        FormSocios.tbDireccion.Enabled = True
        FormSocios.tbTelefono.Enabled = True
        FormSocios.tbCorreo.Enabled = True
        FormSocios.dtpNacimiento.Enabled = False
        FormSocios.cbEstado.Enabled = True
        FormSocios.btnAccionSocio.Enabled = True
        FormSocios.tbDNI.Visible = True
        FormSocios.cbDNI.Visible = False
        FormSocios.tbDNI.Enabled = True
    End Sub
End Module
