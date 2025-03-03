Imports System.Data.SQLite

Module ModuloAccionesTablaGeneros

    Public CadenaConsultarGeneros As String = "SELECT * FROM generos"
    Public CadenaConsultarNombreGeneros As String = "SELECT nombre_genero FROM generos"
    Public cadenaConsultarIdPorNombre As String = "SELECT id_genero FROM generos WHERE nombre_genero = @genero"

    ' Carga los géneros desde la base de datos al ListView en el formulario de géneros
    Public Sub CargarAlListViewGeneros()
        Dim ListaPeliculas As ListViewItem

        FormGeneros.ListView1.Items.Clear()

        If ModuloConexionBaseDeDatos.DatosConjuntos Is Nothing OrElse ModuloConexionBaseDeDatos.DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormGeneros.ListView1.Items.Add(ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(ModuloConexionBaseDeDatos.DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

    ' Devuelve el ID de un género mediante su nombre
    Public Function devolverIdMedianteTitulo(genero As String) As Integer
        Dim id As Integer = -1 ' Valor por defecto en caso de no encontrar el resultado
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(cadenaConsultarIdPorNombre, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Agregar parámetro al comando SQL
            Comando.Parameters.AddWithValue("@genero", genero)

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

    ' Carga los géneros desde la base de datos al ComboBox en el formulario de películas
    Public Sub cargarGenerosAlComboBox()
        Try
            ' Verificar conexión
            If ModuloConexionBaseDeDatos.ConexionNueva.State = ConnectionState.Closed Then
                ModuloConexionBaseDeDatos.ConexionNueva.Open()
            End If

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaConsultarNombreGeneros, ModuloConexionBaseDeDatos.ConexionNueva)

            ' Ejecutar el comando y obtener los resultados
            Dim lector As SQLiteDataReader = Comando.ExecuteReader()

            ' Limpiar el ComboBox antes de agregar los nuevos elementos
            FormPeliculas.cbGenero.Items.Clear()

            ' Leer los resultados y agregar al ComboBox
            While lector.Read()
                ' Supongamos que el título está en la primera columna (índice 0)
                FormPeliculas.cbGenero.Items.Add(lector.GetString(0))
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

End Module
