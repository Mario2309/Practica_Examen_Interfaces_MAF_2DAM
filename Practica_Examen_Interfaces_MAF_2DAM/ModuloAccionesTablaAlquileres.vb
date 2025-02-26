﻿Imports System.Data.SQLite

Module ModuloAccionesTablaAlquileres
    Public CadenaConsultarAlquileres As String = "SELECT * FROM Alquileres"
    Public CadenaInsertarReg As String = "INSERT INTO Alquileres (id_socio, id_pelicula, fecha_alquiler, estado) VALUES (@idSo, @idPe, @feAl, @est)"
    Public CadenaConIdPeli As String = "SELECT id_pelicula FROM Alquileres WHERE id_socio = @idS"
    Public cadenaConsultarTitulos As String = "SELECT titulo FROM peliculas"
    Private CadenaConsultarPelisAlquiladas As String = "SELECT peliculas.titulo FROM Alquileres INNER JOIN peliculas ON Alquileres.id_pelicula = peliculas.id_peliculas WHERE Alquileres.id_socio = @idS AND estado = 'Alquilado' "
    Private cadenaUpdateEstado As String = "update Alquileres set fecha_devolucion=@fD, estado=@est WHERE id_socio=@idS AND id_pelicula=@idP"

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

    Public Sub CargarAlListViewAlquiler(idSocio As String)
        Dim ListaPeliculas As ListViewItem

        FormAlquiler.lwAlquileres.Items.Clear()

        ' Verificamos si hay datos disponibles
        If DatosConjuntos Is Nothing OrElse DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        ' Iteramos sobre las filas de la tabla
        For pos As Integer = 0 To DatosConjuntos.Tables(0).Rows.Count - 1
            ' Comprobamos si el id_socio de la fila actual coincide con el id_socio que se pasa a la función
            If DatosConjuntos.Tables(0).Rows(pos).Item("SOCIO").ToString() = idSocio Then
                ' Si coincide, agregamos los datos al ListView
                ListaPeliculas = FormAlquiler.lwAlquileres.Items.Add(DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

                ' Agregamos las columnas restantes al ListView
                For col As Integer = 1 To DatosConjuntos.Tables(0).Columns.Count - 1
                    ListaPeliculas.SubItems.Add(DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
                Next
            End If
        Next
    End Sub


    Public Sub limpiar()
        FormAlquiler.tbDNI.Clear()
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

            ' Obtener el DNI desde el formulario
            Dim dni As String = FormAlquiler.tbDNI.Text.Trim()

            ' Verificar que el DNI no esté vacío
            If String.IsNullOrEmpty(dni) Then
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Obtener el ID del socio a partir del DNI
            Dim idSocio As Integer? = ModuloAccionesTablaSocios.devolverIdMedianteDNI(dni)

            ' Verificar si el socio existe en la base de datos
            If idSocio >= 1 Then

                ' Crear comando SQL
                Dim Comando As New SQLiteCommand(CadenaInsertarReg, ModuloConexionBaseDeDatos.ConexionNueva)

                ' Asignar parámetros (sin @idPel si es autoincremento)
                Comando.Parameters.AddWithValue("@idSo", idSocio)
                Comando.Parameters.AddWithValue("@idPe", ModuloAccionesTablaPeliculas.devolverIdMedianteTitulo(FormAlquiler.cbPeliculas.Text.Trim()))
                Comando.Parameters.AddWithValue("@feAl", fechaAlquiler)
                Comando.Parameters.AddWithValue("@est", "Alquilado")

                ' Ejecutar la consulta directamente
                Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MessageBox.Show("Alquiler registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                Else
                    MessageBox.Show("No se pudo alquilar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("DNI no encontrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Public Sub cargarTitulosAlComboBox()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(cadenaConsultarTitulos, ModuloConexionBaseDeDatos.ConexionNueva)


            ' Ejecutar el comando y obtener los resultados
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            ' Limpiar el ComboBox antes de agregar los nuevos elementos
            FormAlquiler.cbPeliculas.Items.Clear()

            ' Leer los resultados y agregar al ComboBox
            While lector.Read()
                ' Supongamos que el título está en la primera columna (índice 0)
                FormAlquiler.cbPeliculas.Items.Add(lector.GetString(0))
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

    Public Sub CargarPeliculasAlquiladasSocioCB(dni As String)
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Verificar que el DNI no esté vacío
            If String.IsNullOrEmpty(dni.Trim()) Then
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Obtener el ID del socio a partir del DNI
            Dim idSocio As Integer? = ModuloAccionesTablaSocios.devolverIdMedianteDNI(dni.Trim())

            ' Verificar si el socio existe en la base de datos
            If idSocio.HasValue AndAlso idSocio.Value > 0 Then
                Dim Comando As New SQLiteCommand(CadenaConsultarPelisAlquiladas, ModuloConexionBaseDeDatos.ConexionNueva)

                ' Agregar el parámetro antes de ejecutar la consulta
                Comando.Parameters.AddWithValue("@idS", idSocio)

                ' Ejecutar el comando y obtener los resultados
                Dim lector As SQLiteDataReader = Comando.ExecuteReader()

                ' Limpiar el ComboBox antes de agregar nuevos elementos
                FormAlquiler.cbPeliculas.Items.Clear()

                ' Leer los resultados y agregar al ComboBox
                While lector.Read()
                    FormAlquiler.cbPeliculas.Items.Add(lector.GetString(0))
                End While

                ' Cerrar el lector
                lector.Close()

            Else
                MessageBox.Show("DNI no encontrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener las películas alquiladas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Sub devolver()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Convertir valores de fecha de alquiler
            Dim fechaDevolucion As Date

            ' Obtener la fecha actual del sistema
            Dim fechaActual As Date = DateTime.Now

            ' Usar el año ingresado para crear la fecha de alquiler con la fecha actual (mes y día del sistema)
            fechaDevolucion = New Date(fechaActual.Year, fechaActual.Month, fechaActual.Day)

            ' Verificar que la fecha es válida (esto no es estrictamente necesario si sabes que el año es válido)
            If fechaDevolucion > DateTime.Now Then
                MessageBox.Show("La fecha de alquiler no puede ser en el futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el DNI desde el formulario
            Dim dni = FormAlquiler.tbDNI.Text.Trim()

            ' Verificar que el DNI no esté vacío
            If String.IsNullOrEmpty(dni) Then
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Obtener el ID del socio a partir del DNI
            Dim idSocio As Integer? = ModuloAccionesTablaSocios.devolverIdMedianteDNI(dni)

            ' Verificar si el socio existe en la base de datos
            If idSocio >= 1 Then

                ' Crear comando SQL
                Dim Comando As New SQLiteCommand(cadenaUpdateEstado, ModuloConexionBaseDeDatos.ConexionNueva)

                ' Asignar parámetros (sin @idPel si es autoincremento)
                Comando.Parameters.AddWithValue("@idS", idSocio)
                Comando.Parameters.AddWithValue("@idP", ModuloAccionesTablaPeliculas.devolverIdMedianteTitulo(FormAlquiler.cbPeliculas.Text.Trim()))
                Comando.Parameters.AddWithValue("@fD", fechaDevolucion)
                Comando.Parameters.AddWithValue("@est", "Devuelto")

                ' Ejecutar la consulta directamente
                Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MessageBox.Show("Devolucion registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                Else
                    MessageBox.Show("No se pudo devolver la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("DNI no encontrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If



        Catch ex As Exception
            MessageBox.Show("Error al actualizar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

End Module
