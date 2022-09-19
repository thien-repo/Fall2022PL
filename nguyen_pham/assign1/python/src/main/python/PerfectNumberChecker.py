def sum_of_factors(number):
    sum = 0
    
    for i in range(1, number + 1):
        if number % i == 0:
            sum += i
    
    return sum


def is_perfect_imperative(number):
    return sum_of_factors(number) == 2 * number

def is_perfect_functional(number):
    return sum(filter(lambda factor: number % factor == 0, range(1, number + 1))) == number * 2