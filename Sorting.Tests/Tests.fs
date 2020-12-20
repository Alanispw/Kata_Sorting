module Tests

open System
open Xunit
open Sorting

[<Fact>]
let ``Test case 1 - [1;5;7;8;2;3] sorted is equal to [1;2;3;5;7;8]`` () =
    let actual = Main.quicksort [1;5;7;8;2;3] 
    let expected = [1;2;3;5;7;8]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)
