Module ModuloAccionesTablaAlquileres
    Public CadenaConsultarAlquileres As String = "SELECT * FROM Alquileres"

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



End Module
