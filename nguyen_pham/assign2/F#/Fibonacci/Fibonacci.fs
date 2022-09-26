module Fibonacci

let FibonaciiImperative number =
    [ 1 .. number ]  |> List.map ( fun values -> [0; 1])
                     |> List.reduce ( fun values ignore -> values @ [values.[values.Length - 1] + values.[values.Length - 2]])


