using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using Divisors;

var numbers = new List<int> { 2, 6 };
var result = Factors.Factor(numbers);
foreach (var item in result)
{
    Console.WriteLine(item);
}

