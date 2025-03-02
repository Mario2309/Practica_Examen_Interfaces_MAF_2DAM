Imports System.Data.SQLite

Module ModuloAccionesTablaPeliculas

    Public CadenaConsultarPeliculas As String = "SELECT * FROM peliculas"
    Private CadenaConsultarPeliculasPorId As String = "SELECT titulo, director, id_genero, anio, calificacion, descripcion FROM peliculas Where id_peliculas = @idP"
    Private CadenaInsertarReg As String = "INSERT INTO peliculas (titulo, director, id_genero, anio, calificacion, descripcion) VALUES (@Tl, @Dir, @IdGen, @Anio, @Cal, @Desc)"
    Private CadenaModificar As String = "update peliculas set titulo=@Tl, director=@Dir, id_genero=@IdGen,  anio=@Anio, calificacion=@Cal, descripcion=@Desc where id_peliculas=@idP"
    Private CadenaEliminarReg As String = "delete from peliculas where id_peliculas=@idP"
    Public cadenaConsultarTitulos As String = "SELECT titulo FROM peliculas"
    Private cadenaConsIdPorTitulo As String = "SELECT id_peliculas FROM peliculas WHERE titulo = @Tl"

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
        If FormPeliculas.Text = "Eliminar Pelicula" Or FormPeliculas.Text = "Modificar Pelicula" Or FormPeliculas.Text = "Consultar Pelicula" Then
            FormPeliculas.cbTitulo.SelectedIndex = 0
            FormPeliculas.cbTitulo.Enabled = True
            FormPeliculas.btnBuscarPelicula.Visible = True
            FormPeliculas.cbTitulo.Visible = True
            If FormPeliculas.Text = "Modificar Pelicula" Then
                ModuloEstadoComponentesPeliculas.modificarrPelicula()
            End If
        End If
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

            Dim genero As String = ModuloAccionesTablaGeneros.devolverIdMedianteTitulo(FormPeliculas.cbGenero.Text.Trim())

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaInsertarReg, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar parámetros (sin @idPel si es autoincremento)
            Comando.Parameters.AddWithValue("@Tl", FormPeliculas.tbTitulo.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormPeliculas.tbDirector.Text.Trim())
            Comando.Parameters.AddWithValue("@IdGen", genero)
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
            FormPeliculas.cbTitulo.Items.Clear()

            ' Leer los resultados y agregar al ComboBox
            While lector.Read()
                ' Supongamos que el título está en la primera columna (índice 0)
                FormPeliculas.cbTitulo.Items.Add(lector.GetString(0))
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


    Public Function devolverIdMedianteTitulo(titulo As String) As Integer
        Dim id As Integer = -1 ' Valor por defecto en caso de no encontrar el resultado
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(cadenaConsIdPorTitulo, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Agregar parámetro al comando SQL
            Comando.Parameters.AddWithValue("@Tl", titulo)

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
            Dim Comando As New SQLiteCommand(CadenaConsultarPeliculasPorId, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar el parámetro @id al comando
            Comando.Parameters.AddWithValue("@idP", id)

            ' Ejecutar el comando y obtener los resultados
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            If lector.Read() Then
                ' Ocultar el ComboBox de Títulos y el botón de búsqueda
                FormPeliculas.cbTitulo.Visible = False
                FormPeliculas.btnBuscarPelicula.Visible = False

                ' Mostrar el TextBox de Títulos
                FormPeliculas.tbTitulo.Visible = True

                ' Asignar los valores a los controles del formulario
                FormPeliculas.tbTitulo.Text = If(lector.IsDBNull(0), "", lector.GetString(0)) ' Título (índice 1)
                FormPeliculas.tbDirector.Text = If(lector.IsDBNull(1), "", lector.GetString(1)) ' Director (índice 2)
                FormPeliculas.cbGenero.Text = If(lector.IsDBNull(2), "", lector.GetInt32(2)) ' Género (índice 3)
                FormPeliculas.nudAnio.Value = If(lector.IsDBNull(3), 0, lector.GetInt32(3)) ' Año (índice 4)
                FormPeliculas.nudCalificacion.Value = If(lector.IsDBNull(4), 0, lector.GetInt32(4)) ' Calificación (índice 5)
                FormPeliculas.tbDescripcion.Text = If(lector.IsDBNull(5), "", lector.GetString(5)) ' Descripción (índice 6)
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
            Comando.Parameters.AddWithValue("@idP", devolverIdMedianteTitulo(FormPeliculas.cbTitulo.Text))

            Comando.ExecuteNonQuery()

            MessageBox.Show("Película eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            Dim genero As String = ModuloAccionesTablaGeneros.devolverIdMedianteTitulo(FormPeliculas.cbGenero.Text.Trim())

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaModificar, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Asignar parámetros (sin @idPel si es autoincremento)
            Comando.Parameters.AddWithValue("@Tl", FormPeliculas.tbTitulo.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormPeliculas.tbDirector.Text.Trim())
            Comando.Parameters.AddWithValue("@IdGen", genero)
            Comando.Parameters.AddWithValue("@Anio", anio)
            Comando.Parameters.AddWithValue("@Cal", calificacion)
            Comando.Parameters.AddWithValue("@Desc", FormPeliculas.tbDescripcion.Text.Trim())
            Comando.Parameters.AddWithValue("@idP", devolverIdMedianteTitulo(FormPeliculas.cbTitulo.Text.Trim()))

            ' Ejecutar la consulta directamente
            Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Película modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("No se pudo modificar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al modificar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Open Then
                ModuloConexionBaseDeDatos.ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Sub ActivarCamposModificarPelis()
        FormPeliculas.tbDirector.Enabled = True
        FormPeliculas.cbGenero.Enabled = True
        FormPeliculas.nudAnio.Enabled = True
        FormPeliculas.nudCalificacion.Enabled = True
        FormPeliculas.tbDescripcion.Enabled = True
    End Sub

End Module
