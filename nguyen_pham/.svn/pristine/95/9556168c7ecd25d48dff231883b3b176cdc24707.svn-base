using Moq;
using RandomNumberGuesser;

namespace NumberGuesserTest;

public class Tests
{
  [Test]
  public void Canary() => Assert.Pass();

  [Test]
  [TestCase(1, 1, Results.Equal)]
  [TestCase(1, 2, Results.Lower)]
  [TestCase(2, 1, Results.Higher)]
  public void IsGuessCorrect(int guess, int target, Results expected) => Assert.AreEqual(expected, NumberGuesser.IsGuessCorrect(guess, target));

  [Test]
  [TestCase(20, 20, 0, Results.Equal, 1)]
  [TestCase(20, 20, 3, Results.Equal, 4)]
  [TestCase(20, 10, 1, Results.Higher, 2)]
  [TestCase(20, 40, 2, Results.Lower, 3)]
  public void EvaluateGuess(int guess, int target, int turn, Results result, int attempt) => Assert.AreEqual((result, attempt), NumberGuesser.EvaluateGuess(target, guess, turn));

  [Test]
  public void UserGuessCorrectlyInThe1stAttempt()
  {
    var reader = new Mock<Func<string, int>>();
    reader.Setup(read => read(It.IsAny<string>())).Returns(20);

    var reporter = new Mock<Action<string>>();
    reporter.Setup(report => report(It.IsAny<string>()));

    NumberGuesser.Guess(20, reader.Object, reporter.Object);

    reporter.Verify(report => report("You got it in 1 attempt"), Times.Once);
  }

  [Test]

  public void UserGuesssCorrectlyIn2Attempts()
  {

    var reader = new Mock<Func<string, int>>();
    reader.SetupSequence(read => read(It.IsAny<string>())).Returns(30)
                                                          .Returns(20);

    var reporter = new Mock<Action<string>>();
    reporter.Setup(report => report(It.IsAny<string>()));

    NumberGuesser.Guess(20, reader.Object, reporter.Object);

    reporter.Verify(report => report("Your guess is Higher, try again"), Times.Once);
    reporter.Verify(report => report("You got it in 2 attempts"), Times.Once);
  }

  [Test]

  public void UserGuesssCorrectlyIn3Attempts()
  {

    var reader = new Mock<Func<string, int>>();
    reader.SetupSequence(read => read(It.IsAny<string>())).Returns(30)
                                                          .Returns(20)
                                                          .Returns(25);

    var reporter = new Mock<Action<string>>();
    reporter.Setup(report => report(It.IsAny<string>()));

    NumberGuesser.Guess(25, reader.Object, reporter.Object);

    reporter.Verify(report => report("Your guess is Higher, try again"), Times.Once);
    reporter.Verify(report => report("Your guess is Lower, try again"), Times.Once);
    reporter.Verify(report => report("You got it in 3 attempts"), Times.Once);
  }

  [Test]

  public void UserGuesssCorrectlyInThe2ndAttempt()
  {

    var reader = new Mock<Func<string, int>>();
    reader.SetupSequence(read => read(It.IsAny<string>())).Returns(10)
                                                          .Returns(20);

    var reporter = new Mock<Action<string>>();
    reporter.Setup(report => report(It.IsAny<string>()));

    NumberGuesser.Guess(20, reader.Object, reporter.Object);

    reporter.Verify(report => report("Your guess is Lower, try again"), Times.Once);
    reporter.Verify(report => report("You got it in 2 attempts"), Times.Once);
  }

  [Test]
  public void CreatTargetGenerates2DifferentRandomNumbers() => Assert.AreNotEqual(NumberGuesser.CreateTarget(), NumberGuesser.CreateTarget());

}
