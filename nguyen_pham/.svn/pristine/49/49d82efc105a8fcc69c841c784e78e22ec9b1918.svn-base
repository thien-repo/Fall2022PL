package perfectnumbers 

import "github.com/logic-building/functional-go/fp"

func sumOfFactors(number int) int {
	sum := 0

	for i := 1; i <= number; i++ {
		if number % i == 0 {
			sum += i
		}
	}

	return sum
}

func IsPerfectImperative(number int) bool {
	return sumOfFactors(number) == number * 2
}

func IsPerfectFunctional(number int) bool {
	isFactor := func(factor int) bool { return number % factor == 0}
	factors := fp.FilterInt(isFactor, fp.RangeInt(1, number + 1))
	add := func(acc int, next int) int { return acc + next}
	return fp.ReduceInt(add, factors) == number * 2
}
