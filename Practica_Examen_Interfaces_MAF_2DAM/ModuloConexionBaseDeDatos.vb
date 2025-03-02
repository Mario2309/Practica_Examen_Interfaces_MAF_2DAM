Imports System.Data.SQLite

Module ModuloConexionBaseDeDatos
    Public CadenaConexion As String = "Data Source=C:\Users\alvar\source\repos\Practica_Examen_Interfaces_MAF_2DAM\Practica_Examen_Interfaces_MAF_2DAM\Resources\VideoClub_Interface.db; Version=3"
    Public ConexionNueva As New SQLiteConnection(CadenaConexion)

    Public AdaptadorDatos As SQLiteDataAdapter
    Public DatosConjuntos As DataSet
    Public fila As DataRow




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

End Module
