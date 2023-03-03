import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class FactorialsList {
    public static List<Integer> factorials(int number) {
        return IntStream
          .rangeClosed(1, number)
          .mapToObj(value -> IntStream
            .rangeClosed(1, value).reduce(1, (a, b) -> a * b))
          .collect(Collectors.toList());
    }
    public static void main(String[] args) {
        System.out.println(factorials(1));
        System.out.println(factorials(4));
        System.out.println(factorials(7));
        System.out.println(factorials(10));

    }
}