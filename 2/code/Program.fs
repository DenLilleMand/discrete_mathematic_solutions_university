// Learn more about F# at http://fsharp.org

open System

let countInversions (A : int array) = 
    let mutable inversionCount = 0
    for i in 0 .. A.Length-2 do
        for j in i+1 .. A.Length-1 do
            if A.[i] > A.[j] then
                inversionCount <- inversionCount + 1
    (inversionCount)


[<EntryPoint>]
let main argv = 
    let A = [| 2; 1; 8; 4; 3; 6|]
    let inversionCount = countInversions A
    printf "Inversion count: %i" inversionCount
    
    0 // return an integer exit code
