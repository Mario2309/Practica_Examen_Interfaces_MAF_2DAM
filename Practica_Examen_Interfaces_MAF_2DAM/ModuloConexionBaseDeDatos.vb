Imports System.Data.SQLite

Module ModuloConexionBaseDeDatos
    Public CadenaConexion As String = "Data Source=C:\Users\alvar\source\repos\Mario2309\Practica_Examen_Interfaces_MAF_2DAM\Practica_Examen_Interfaces_MAF_2DAM\VideoClub_Interfaces; Version=3"
    Public ConexionNueva As New SQLiteConnection(CadenaConexion)

    Public AdaptadorDatosPelis As SQLiteDataAdapter
    Public DatosConjuntosPelis As DataSet
    Public fila As DataRow

    Public CadenaConsultarPeliculas As String = "SELECT * FROM peliculas"
    Public CadenaConsultarAlquileres As String = "SELECT * FROM Alquileres"
    Public CadenaConsultarSocios As String = "SELECT * FROM Socios"
    Public CadenaConsultarGeneros As String = "SELECT nombre_genero FROM Peliculas"



    Public Sub ConectarBD(CadenaConsultar As String)
        Try
            ConexionNueva.Open()

            If String.IsNullOrWhiteSpace(CadenaConexion) Then
                AdaptadorDatosPelis = New SQLiteDataAdapter(CadenaConsultar, ConexionNueva)

                DatosConjuntosPelis = New DataSet()
                AdaptadorDatosPelis.Fill(DatosConjuntosPelis)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
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


End Module
