namespace RandomNumberGuesser;

public class NumberGuesser
{
  public static Results IsGuessCorrect(int guess, int answer) => new Results[] { Results.Lower, Results.Equal, Results.Higher }[Math.Sign(guess - answer) + 1];

  public static (Results, int) EvaluateGuess(int target, int guess, int attempts) => (IsGuessCorrect(guess, target), attempts + 1);

  public static void Guess(int target, Func<string, int> read, Action<string> report) =>
  Enumerable.Range(0, int.MaxValue).First(turn =>
  {
    var guess = read("Guess a number between 1 and 100: ");
    var (result, attempt) = EvaluateGuess(target, guess, turn);
    var message = result == Results.Equal
              ? $"You got it in {attempt} attempt{(attempt == 1 ? "" : "s")}"
              : $"Your guess is {result.ToString()}, try again";

    report(message);

    return result == Results.Equal;
  });

  public static int CreateTarget() => new Random().Next(1, 101);

}

