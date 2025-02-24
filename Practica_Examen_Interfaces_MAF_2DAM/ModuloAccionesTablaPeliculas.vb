Imports System.Data.SQLite

Module ModuloAccionesTablaPeliculas

    Public CadenaConsultarPeliculas As String = "SELECT * FROM peliculas"
    Public CadenaInsertarReg As String = "INSERT INTO peliculas (titulo, director, id_genero, anio, calificacion, descripcion) VALUES (@Tl, @Dir, @IdGen, @Anio, @Cal, @Desc)"
    Public CadenaModificar As String = "update Peliculas set titulo=@Tl, director=@Dir, id_genero=@IdGen,  anio_publicacion=@Anio, calificacion=@Cal, descripcion=@Desc where num_registro=@idP"
    Public CadenaEliminarReg As String = "delete from Peliculas where num_registro=@idP"

    Public Sub CargarAlListViewPeliculas()
        Dim ListaPeliculas As ListViewItem

        FormPeliculas.lwPeliculas.Items.Clear()

        If ModuloConexionBaseDeDatos.DatosConjuntos Is Nothing OrElse ModuloConexionBaseDeDatos.DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormPeliculas.lwPeliculas.Items.Add(ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

    Public Sub limpiar()
        FormPeliculas.tbTitulo.Clear()
        FormPeliculas.tbDirector.Clear()
        FormPeliculas.cbGenero.SelectedIndex = 0
        FormPeliculas.nudAnio.Value = 0
        FormPeliculas.nudCalificacion.Value = 0
        FormPeliculas.tbDescripcion.Clear()
    End Sub


    Public Sub Agregar()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Validar campos
            validarCampos()

            ' Convertir valores numéricos con seguridad
            Dim anio As Integer
            Dim calificacion As Decimal

            ' Verificar el año
            If Not Integer.TryParse(FormPeliculas.nudAnio.Text, anio) Then
                MessageBox.Show("Año debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Verificar la calificación
            If Not Decimal.TryParse(FormPeliculas.nudCalificacion.Text, calificacion) Then
                MessageBox.Show("Calificación debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaInsertarReg, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar parámetros (sin @idPel si es autoincremento)
            Comando.Parameters.AddWithValue("@Tl", FormPeliculas.tbTitulo.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormPeliculas.tbDirector.Text.Trim())
            Comando.Parameters.AddWithValue("@IdGen", FormPeliculas.cbGenero.Text.Trim())
            Comando.Parameters.AddWithValue("@Anio", anio)
            Comando.Parameters.AddWithValue("@Cal", calificacion)
            Comando.Parameters.AddWithValue("@Desc", FormPeliculas.tbDescripcion.Text.Trim())

            ' Ejecutar la consulta directamente
            Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Película agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("No se pudo agregar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
