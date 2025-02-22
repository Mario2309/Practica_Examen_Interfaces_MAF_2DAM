Imports System.Data.SQLite

Module ModuloConexionBaseDeDatos
    Public CadenaConexion As String = "Data Source=C:\Users\alvar\source\repos\Mario2309\Practica_Examen_Interfaces_MAF_2DAM\Practica_Examen_Interfaces_MAF_2DAM\VideoClub_Interface.db; Version=3"
    Public ConexionNueva As New SQLiteConnection(CadenaConexion)

    Public AdaptadorDatos As SQLiteDataAdapter
    Public DatosConjuntos As DataSet
    Public fila As DataRow

    Public CadenaConsultarGeneros As String = "SELECT * FROM generos"



    Public Sub ConectarBD(CadenaConsultar As String)
        Try
            If String.IsNullOrWhiteSpace(CadenaConexion) Then
                MessageBox.Show("La cadena de conexión está vacía.")
                Exit Sub
            End If

            ConexionNueva = New SQLiteConnection(CadenaConexion)
            ConexionNueva.Open()

            AdaptadorDatos = New SQLiteDataAdapter(CadenaConsultar, ConexionNueva)
            DatosConjuntos = New DataSet()
            AdaptadorDatos.Fill(DatosConjuntos)

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            If ConexionNueva IsNot Nothing AndAlso ConexionNueva.State = ConnectionState.Open Then
                ConexionNueva.Close()
            End If
        End Try
    End Sub

    Public Sub DesconectarBD()
        Try
            If ConexionNueva IsNot Nothing AndAlso ConexionNueva.State = ConnectionState.Open Then
                ConexionNueva.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarAlListViewGeneros()
        Dim ListaPeliculas As ListViewItem

        FormGeneros.ListView1.Items.Clear()

        If DatosConjuntos Is Nothing OrElse DatosConjuntos.Tables.Count = 0 Then
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
            Exit Sub
        End If

        For pos As Integer = 0 To DatosConjuntos.Tables(0).Rows.Count - 1
            ListaPeliculas = FormGeneros.ListView1.Items.Add(DatosConjuntos.Tables(0).Rows(pos).Item(0).ToString())

            For col As Integer = 1 To DatosConjuntos.Tables(0).Columns.Count - 1
                ListaPeliculas.SubItems.Add(DatosConjuntos.Tables(0).Rows(pos).Item(col).ToString())
            Next
        Next
    End Sub

End Module
