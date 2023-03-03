class FibonacciTest extends munit.FunSuite {
  test("canary") {
    assert(true)
  }
  
  val testCasesForFibonacci = List(
    (0, List(1)),
    (1, List(1, 1)),
    (2, List(1, 1, 2)),
    (3, List(1, 1, 2, 3)),
    (4, List(1, 1, 2, 3, 5)),
    (5, List(1, 1, 2, 3, 5, 8)),
    (6, List(1, 1, 2, 3, 5, 8, 13)),
    (7, List(1, 1, 2, 3, 5, 8, 13, 21)),
    (8, List(1, 1, 2, 3, 5, 8, 13, 21, 34)),
    (9, List(1, 1, 2, 3, 5, 8, 13, 21, 34, 55)),
    (10, List(1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89)),
  )
  


  val testSetForFibonacci = (fibonacci: Int => List[Int], name: String) => {
    test(s"test for $name") {
      for ((number, expected) <- testCasesForFibonacci) {
        assertEquals(fibonacci(number), expected)
      }
    }
  }
  

  testSetForFibonacci(FibonacciIterative,"Iterative")
  testSetForFibonacci(FibonacciRecursive,"Recursive")
  test("test for TailRecursion") {
    for ((number, expected) <- testCasesForFibonacci) {
      assertEquals(FibonacciTailRecursion(number), expected)
    }
  }
}
