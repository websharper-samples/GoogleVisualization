namespace WebSharper.GoogleVisualization.Sample

open WebSharper
open WebSharper.UI
open WebSharper.UI.Html
open WebSharper.UI.Client
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

    [<SPAEntryPoint>]
    let Main() =
        div [
            on.afterRender (fun container ->
                let visualization = new BarChart(container)
                let options =
                    BarChartOptions(
                        height = 400,
                        legend = Legend(position=LegendPosition.Bottom),
                        title  = "Company Performance")
                visualization.draw(AreaChartData(), options))
        ] []
        |> Doc.RunById "main"
