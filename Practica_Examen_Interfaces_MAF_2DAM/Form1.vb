Public Class FormularioInicio

    Private progreso As Integer = 0

    Private Sub btnAbrirGestor_Click(sender As Object, e As EventArgs)
        MovimientoEntreFormularios.avanzarMenu()
    End Sub

    Private Sub FormularioInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar la barra de progreso
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 20 ' 2 segundos (20 pasos de 100ms)
        ProgressBar1.Step = 1

        ' Configurar y empezar el Timer automáticamente
        Timer1.Interval = 100 ' Intervalo de 100 ms
        Timer1.Start() ' Inicia la barra de carga al abrir el formulario
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progreso += 1
        ProgressBar1.PerformStep()

        If progreso >= 20 Then
            Timer1.Stop() ' Detiene la barra después de 2 segundos
            MovimientoEntreFormularios.avanzarMenu()
        End If
    End Sub
End Class
