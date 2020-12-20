namespace Sorting

module Main = 
    let rec quicksort list = 
        match list with 
        | [] -> []
        | firstElement::otherElements -> 
            let small = 
                otherElements 
                |> List.filter (fun e -> e < firstElement) 
                |> quicksort
            let larger = 
                otherElements 
                |> List.filter (fun e -> e >= firstElement) 
                |> quicksort
            List.concat [small; [firstElement]; larger;]
