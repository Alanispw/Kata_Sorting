namespace Sorting

module Main = 
    let rec quicksort list = 
        match list with 
        | [] -> 
                []
        | first::res -> 
            let small = 
                res 
                |> List.filter (fun e -> e < first) 
                |> quicksort
            let larger = 
                res 
                |> List.filter (fun e -> e >= first) 
                |> quicksort
            List.concat [small; [first]; larger;]
