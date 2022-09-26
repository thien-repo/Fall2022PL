module FibonacciTest

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Canary () =
    Assert.Pass()
    
[<Test>]
let FibonaciiImperativeTest () =
    let TestCases =  [| 
        (1, [0; 1]);
        (2, [0; 1; 1;]);
        (3, [0; 1; 1; 2]);
        (4, [0; 1; 1; 2; 3])
        (5, [0; 1; 1; 2; 3; 5])
        |]
    for (input, expected) in TestCases do
        let actual = Fibonacci.FibonaciiImperative input
        Assert.AreEqual(expected, actual)