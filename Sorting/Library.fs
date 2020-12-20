namespace Sorting

module Main = 
    let rec quicksort list = 
        match list with 
        | [] -> []
        | firstElement::otherElements -> 
            let small, larger = List.partition ((>=) firstElement) otherElements
            List.concat [quicksort small; [firstElement]; quicksort larger]

    let removeDuplicates list:Set<int> = 
        let notDuplicates = Set.ofList list
        notDuplicates