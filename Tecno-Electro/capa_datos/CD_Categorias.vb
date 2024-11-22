Imports System.Data.SqlClient
Imports capa_entidad

Public Class CD_Categorias
    Public Function ObtenerCategorias() As DataTable
        Dim dtCategorias As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "SELECT Id_categoria, c_descripcion FROM Categorias WHERE estado = 'Activo'"

                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dtCategorias)
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al obtener las categorías: " & ex.Message)
            End Try
        End Using

        Return dtCategorias
    End Function

    Public Function ListarCategorias() As DataTable
        Dim dtCategorias As New DataTable()

        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()

                ' Consulta para obtener todas las categorías
                Dim query As String = "SELECT Id_categoria, c_descripcion, estado FROM Categorias"

                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtCategorias) ' Llenar el DataTable con las categorías obtenidas
                End Using

            Catch ex As Exception
                Throw New Exception("Error al listar categorías: " & ex.Message)
            End Try
        End Using

        Return dtCategorias
    End Function

    Public Sub InsertarCategoria(ByVal categoria As CE_Categoria)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Categorias (c_descripcion, estado) VALUES (@Descripcion, @Estado)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Descripcion", categoria.c_Descripcion)
                    command.Parameters.AddWithValue("@Estado", categoria.Estado)

                    command.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                Throw New Exception("Error al insertar la categoría: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Sub EliminarCategoria(ByVal idCategoria As Integer)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()


                Dim query As String = "DELETE FROM Categorias WHERE Id_categoria = @IdCategoria"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar la categoría: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' Capa de Datos (DAL) - Clase CD_Categorias
    Public Sub ModificarCategoria(ByVal categoria As CE_Categoria)
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                Dim query As String = "UPDATE Categorias SET c_descripcion = @Descripcion, estado = @Estado " &
                                  "WHERE Id_categoria = @IdCategoria"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria)
                    command.Parameters.AddWithValue("@Descripcion", categoria.c_Descripcion)
                    command.Parameters.AddWithValue("@Estado", categoria.Estado)

                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al modificar la categoría: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Function CategoriaExiste(ByVal descripcion As String) As Boolean
        Using connection As New SqlConnection(Conexion.cadena)
            Try
                connection.Open()
                ' Consulta para verificar si ya existe una categoría con la misma descripción
                Dim query As String = "SELECT COUNT(*) FROM Categorias WHERE c_descripcion = @Descripcion"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Descripcion", descripcion)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Si el recuento es mayor que 0, la categoría ya existe
                End Using
            Catch ex As Exception
                Throw New Exception("Error al verificar si la categoría existe: " & ex.Message)
            End Try
        End Using
    End Function



End Class

