module Fibonacci

let Iterative number =
    if number < 1 then
        [1]
    else 
        [ 1 .. number ]  |> List.map ( fun values -> [1; 1])
                         |> List.reduce ( fun values ignore -> values @ [values.[values.Length - 1] + values.[values.Length - 2]])

let rec Recursive number =
    if number = 0 then
        [1]
    elif number = 1 then
        [1; 1]
    else
        let previous = Recursive (number - 1)
        previous @ [previous.[previous.Length - 1] + previous.[previous.Length - 2]]

let RecursiveIterative number = 
    let rec FibonacciMapper previous current number =
        if number = 0 then
            previous
        else
            FibonacciMapper current (previous + current) (number - 1) 

    [0 .. number] |> List.map ( fun num -> FibonacciMapper 1 1 num)
