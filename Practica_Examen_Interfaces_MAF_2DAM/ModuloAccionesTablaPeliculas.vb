Module ModuloAccionesTablaPeliculas

    Public CadenaConsultarPeliculas As String = "SELECT * FROM peliculas"

    Public Sub CargarAlListViewPeliculas()
        Dim ListaPeliculas As ListViewItem

        FormPeliculas.lwPeliculas.Items.Clear()

        If DatosConjuntos Is Nothing OrElse DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormPeliculas.lwPeliculas.Items.Add(DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

End Module
