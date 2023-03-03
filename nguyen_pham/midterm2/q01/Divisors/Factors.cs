using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;

namespace Divisors;

public class Factors
{
    public static IEnumerable<int> Factor(IEnumerable<int> numbers)
        => numbers.SelectMany(number => Enumerable.Range(1, number).Where(factor => number % factor == 0).Select(factor => new[] { number, factor })).SelectMany(item => item).Distinct().OrderBy(item => item);


}
