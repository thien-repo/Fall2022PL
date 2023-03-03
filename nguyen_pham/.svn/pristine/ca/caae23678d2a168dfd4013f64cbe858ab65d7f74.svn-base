module IsFirstRepeatedTest

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()

[<Test>]
let FindFirstRepeated () =
    let TestCases = [|
        ("hello", "l")
        ("hello there", "l")
        ("hello okay", "l")
        ("hello elmo", "l")
        ("hello", "l")
        ("hello sam", "l")
        ("and this oy", " ")
    |]
    for (input, expected) in TestCases do
        let actual = isFirstRepeated.FindFirstRepeated input
        Assert.AreEqual(expected, actual)


    