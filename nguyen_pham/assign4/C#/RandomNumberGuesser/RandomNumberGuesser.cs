namespace RandomNumberGuesser;

public class RandomNumberGuesser
{
  public static void Main(string[] args)
  {
    var reader = new Func<string, int>(prompt =>
    {
      Console.Write(prompt);
      return int.Parse(Console.ReadLine());
    });

    NumberGuesser.Guess(NumberGuesser.CreateTarget(), reader, Console.WriteLine);
  }
}

