Imports System.Data.SQLite

Module ModuloAccionesTablaAlquileres
    Public CadenaConsultarAlquileres As String = "SELECT * FROM Alquileres"
    Public CadenaInsertarReg As String = "INSERT INTO Alquileres (id_socio, id_pelicula, fecha_alquiler) VALUES (@idSo, @idPe, @feAl)"

    Public Sub CargarAlListViewAlquiler()
        Dim ListaPeliculas As ListViewItem

        FormAlquiler.lwAlquileres.Items.Clear()

        If DatosConjuntos Is Nothing OrElse DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormAlquiler.lwAlquileres.Items.Add(DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

    Public Sub limpiar()
        FormAlquiler.tbDNI.Clear()
        FormAlquiler.cbPeliculas.SelectedIndex = 0
    End Sub

    Public Sub Agregar()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

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
            Comando.Parameters.AddWithValue("@idSo", FormAlquiler.tbDNI.Text.Trim())
            Comando.Parameters.AddWithValue("@idPe", FormAlquiler.cbPeliculas.Text.Trim())
            Comando.Parameters.AddWithValue("@feAl", fechaAlquiler)

            ' Ejecutar la consulta directamente
            Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Alquiler registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("No se pudo alquilar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

End Module
