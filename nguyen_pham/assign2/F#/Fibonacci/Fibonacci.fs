﻿module Fibonacci

let FibbinaciiIterative number =
    if number < 1 then
      [1]
    else 
      [ 1 .. number ]  |> List.map ( fun values -> [1; 1])
                       |> List.reduce ( fun values ignore -> values @ [values.[values.Length - 1] + values.[values.Length - 2]])

let rec FibbinaciiRecursive number =
    if number = 0 then
      [1]
    elif number = 1 then
      [1; 1]
    else
      let previous = FibbinaciiRecursive (number - 1)
      previous @ [previous.[previous.Length - 1] + previous.[previous.Length - 2]]

let rec FibbinaciiRecursiveIterative number = 
    let rec FibonacciMapper previous current num =
      if num = 0 then
          previous
      else
          FibonacciMapper current (previous + current) (num - 1) 
          
    if number < 0 then
      []
    else 
      FibbinaciiRecursiveIterative (number - 1) @ [FibonacciMapper 1 1 number]
