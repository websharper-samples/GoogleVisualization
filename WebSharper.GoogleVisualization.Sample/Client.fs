namespace WebSharper.GoogleVisualization.Sample

open WebSharper
open WebSharper.JavaScript
open WebSharper.Html.Client
open WebSharper.Google.Visualization
open WebSharper.Google.Visualization.Base

[<JavaScript>]
module Client =

    let AreaChartData () =
        let data = new DataTable()
        data.addColumn(ColumnType.StringType,"Year") |> ignore
        data.addColumn(ColumnType.NumberType,"Sales") |> ignore
        data.addColumn(ColumnType.NumberType,"Expenses") |> ignore
        data.addRows [| ("2014", 1000, 400)
                        ("2015", 1170, 460)
                        ("2016", 1660, 1120)
                        ("2017", 1030, 540) |]
        |> ignore
        data

    let Main =
        Div []
        |>! OnAfterRender (fun container ->
            let visualization = new BarChart(container.Dom)
            let options =
                BarChartOptions(
                    height = 400,
                    legend = Legend(position=LegendPosition.Bottom),
                    title  = "Company Performance")
            visualization.draw(AreaChartData(), options))
        |> fun el ->
            el.AppendTo "main"
