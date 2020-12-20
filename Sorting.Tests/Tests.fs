module Tests

open System
open Xunit
open Sorting

[<Fact>]
let ``Test case 1 - [1;5;7;8;2;3] sorted is equal to [1;2;3;5;7;8]`` () =
    let actual = Main.quicksort [1;5;7;8;2;3] 
    let expected = [1;2;3;5;7;8]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

[<Fact>]
let ``Test case 2 - [8;2;7;8;1;4] sorted is equal to [1;2;4;7;8;8]`` () =
    let actual = Main.quicksort [8;2;7;8;1;4]
    let expected = [1;2;4;7;8;8]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

[<Fact>]
let ``Test case 3 - [] sorted is equal to []`` () =
    let actual = Main.quicksort []
    let expected = []
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

[<Fact>]
let ``Test case 4 - [1;1;4;6;8;10] removed duplicates is equal to [1;4;6;8;10]`` () =
    let actual = Main.removeDuplicates [1;1;4;6;8;10]
    let expected = set [1;4;6;8;10]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)
