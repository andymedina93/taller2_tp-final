Imports capa_datos
Imports capa_entidad
Public Class CN_Categorias
    Private objCD_Categorias As New CD_Categorias()

    Public Function ListarCategorias() As DataTable
        Return objCD_Categorias.ObtenerCategorias()
    End Function

    Public Function ObtenerCategorias() As DataTable
        Try

            Return objCD_Categorias.ListarCategorias() ' Llamar a la función que trae las categorías
        Catch ex As Exception
            Throw New Exception("Error al obtener las categorías: " & ex.Message)
        End Try
    End Function



    ' Capa de Negocio (BLL) - Clase CN_Categorias
    Public Sub EliminarCategoria(ByVal idCategoria As Integer)
        Dim objCD_Categorias As New CD_Categorias()
        objCD_Categorias.EliminarCategoria(idCategoria)
    End Sub

    Public Sub AgregarCategoria(ByVal categoria As CE_Categoria)
        Dim objCD_Categorias As New CD_Categorias()

        ' Validar si la categoría ya existe antes de agregarla
        If objCD_Categorias.CategoriaExiste(categoria.c_Descripcion) Then
            Throw New Exception("La categoría ya existe. No se puede agregar una categoría duplicada.")
        End If

        ' Si no existe, procede con la inserción
        objCD_Categorias.InsertarCategoria(categoria)
    End Sub

    Public Sub ModificarCategoria(ByVal categoria As CE_Categoria)
        Dim objCD_Categorias As New CD_Categorias()

        ' Validar si la categoría ya existe antes de modificarla
        If objCD_Categorias.CategoriaExiste(categoria.c_Descripcion) Then
            Throw New Exception("La categoría ya existe. No se puede modificar a una categoría duplicada.")
        End If

        ' Si no existe, procede con la modificación
        objCD_Categorias.ModificarCategoria(categoria)
    End Sub

End Class

