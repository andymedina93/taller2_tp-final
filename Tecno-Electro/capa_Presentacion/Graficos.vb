Imports capa_negocio
Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.Axes
Imports OxyPlot.Annotations

Public Class Graficos
    Private Sub Graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MostrarGraficoVentasPorCategoria()
    End Sub
    ' En el formulario donde se desea mostrar el gráfico





    Public Sub MostrarGraficoVentasPorCategoria()
        ' Crear un nuevo modelo de gráfico
        Dim model As New PlotModel With {.Title = "Ventas por Categoría"}

        ' Llamar a la función para obtener los datos de ventas por categoría
        Dim objCN As New CN_Ventas()
        Dim dt As DataTable = objCN.ObtenerVentasPorCategoria()

        Dim barSeries As New BarSeries() With {
        .LabelFormatString = "{0}", ' Mostrar el valor dentro de la barra
        .BarWidth = 0.6 ' Ajustar el ancho de las barras
    }

        ' Crear una lista de categorías y una lista de valores
        Dim categorias As New List(Of String)()
        Dim valores As New List(Of Double)()

        ' Agregar los datos de las categorías y valores a las listas
        For Each row As DataRow In dt.Rows
            categorias.Add(row("Categoria").ToString())
            valores.Add(Convert.ToInt32(row("TotalVendidos")))
        Next

        ' Agregar los valores a la serie de barras
        For i As Integer = 0 To categorias.Count - 1
            barSeries.Items.Add(New BarItem With {.Value = valores(i)})
        Next

        ' Agregar la serie de barras al modelo de gráfico
        model.Series.Add(barSeries)

        ' Establecer el eje X con las categorías (usamos un eje de categorías)
        model.Axes.Add(New CategoryAxis() With {
        .Position = AxisPosition.Bottom,
        .Key = "Categorias",
        .Title = "Categorías",
        .ItemsSource = categorias ' Usamos la lista de categorías
    })

        ' Establecer el eje Y con la cantidad de productos vendidos (eje numérico)
        model.Axes.Add(New LinearAxis() With {
        .Position = AxisPosition.Left,
        .Key = "Ventas",
        .Title = "Cantidad Vendida",
        .Minimum = 0
    })

        ' Asignar el modelo al PlotView para mostrar el gráfico
        PlotView1.Model = model
    End Sub

End Class