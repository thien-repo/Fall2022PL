package assign1;

import java.util.stream.IntStream;

public class PerfectNumberChecker {

  public static int sumOfFactors(int number) {
    int sum = 0;

    for (int i = 1; i <= number; i++) {
      if (number % i == 0) {
        sum += i;
      }
    }

    return sum;
  }

  public static boolean isPerfectImperative(int number) {
    return sumOfFactors(number) == number * 2;
  }

  public static boolean isPerfectFunctional(int number) {
    return IntStream
        .rangeClosed(1, number)
        .filter(factor -> number % factor == 0) 
        .sum() == number * 2;
  }
}
