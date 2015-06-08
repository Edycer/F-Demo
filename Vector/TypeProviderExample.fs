module TypeProviderExample

open FSharp.Data

type Stocks = CsvProvider<"./MSFT.csv">

let msft = Stocks.Load("./MSFT.csv")

let firstRow = msft.Rows |> Seq.head
//let lastDate = firstRow