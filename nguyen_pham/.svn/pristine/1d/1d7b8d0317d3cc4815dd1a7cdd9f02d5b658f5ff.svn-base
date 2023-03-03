def FibonacciIterative( number: Int) =
  (0 to number - 1).foldLeft(List(1)) ((values,_) => values :+ (values.takeRight(2).sum))

def FibonacciRecursive( number: Int) : List[Int] = number match
  case 0 => List(1)
  case _ => 
    val values = FibonacciRecursive(number - 1)
    values :+ (values.takeRight(2).sum)

def FibonacciTailRecursion( number: Int, values: List[Int] = List(1)) : List[Int] = number match
  case 0 => values
  case _ => FibonacciTailRecursion(number - 1, values :+ (values.takeRight(2).sum))
