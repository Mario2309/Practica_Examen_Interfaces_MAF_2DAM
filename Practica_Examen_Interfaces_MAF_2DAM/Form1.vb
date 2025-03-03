Public Class FormularioInicio

    ' Variable que lleva el seguimiento del progreso de la barra de progreso
    Private progreso As Integer = 0

    ' Evento del botón btnAbrirGestor que avanza al siguiente formulario
    Private Sub btnAbrirGestor_Click(sender As Object, e As EventArgs)
        MovimientoEntreFormularios.avanzarMenu()
    End Sub

    ' Evento que se ejecuta cuando el formulario se carga
    Private Sub FormularioInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración de la barra de progreso
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 20 ' 2 segundos (20 pasos de 100ms)
        ProgressBar1.Step = 1

        ' Configuración y comienzo del Timer automáticamente
        Timer1.Interval = 100 ' Intervalo de 100 ms
        Timer1.Start() ' Inicia la barra de carga al abrir el formulario
    End Sub

    ' Evento que se ejecuta cada vez que el temporizador alcanza su intervalo (100 ms)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progreso += 1
        ProgressBar1.PerformStep()

        If progreso >= 20 Then
            Timer1.Stop() ' Detiene el temporizador después de 2 segundos
            MovimientoEntreFormularios.avanzarMenu()
        End If
    End Sub
End Class

