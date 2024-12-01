open System 

let parseLine (input:string) =
    let split = input.Split [|' '|]
    let id, zipCode = split.[0], Int32.Parse split.[1]
    let firstList = split.[0]
    let secondList = split.[1]
    (firstList, secondList)

let printLine (id, zipCode, street) = sprintf "%s|%i|%s" id zipCode street

let lines = 
    IO.File.ReadLines @"./input.txt"
    |> Seq.map parseLine

