﻿module Fibonacci

let FibonacciIterative number =
    if number < 1 then
      [1]
    else 
      [ 1 .. number ]  |> List.map ( fun values -> [1; 1])
                       |> List.reduce ( fun values ignore -> values @ [values.[values.Length - 1] + values.[values.Length - 2]])

let rec FibonacciRecursive number =
    match number with
    | 0 -> [1]
    | 1 -> [1; 1]
    | _ -> let values = FibonacciRecursive (number - 1)
           values @ [values.[values.Length - 1] + values.[values.Length - 2]]


let FibonacciTailRecursive number = 
    let rec FibonacciSequence num sequence = 
        match num with
        | 0 -> [1]
        | 1 -> sequence 
        | _ -> FibonacciSequence (num - 1) (sequence @ [sequence.[sequence.Length - 1] + sequence.[sequence.Length - 2]])
    FibonacciSequence number [1;1]    
