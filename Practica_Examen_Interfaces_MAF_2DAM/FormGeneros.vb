Public Class FormGeneros
    ' Evento que maneja el clic en el item de menú "Volver", llamando a un método para volver a la pantalla de películas
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        MovimientoEntreFormularios.volverGeneroPeliculas()
    End Sub

End Class