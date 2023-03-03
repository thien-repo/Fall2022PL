package RandomNumberGuesser
import scala.math.signum


object Results extends Enumeration {
  type Results = Value
  val Lower, Equal, Higher = Value
}


def isGuessCorrect(guess: Int, answer: Int): Results.Value = signum(guess - answer) match {
  case -1 => Results.Lower
  case 0 => Results.Equal
  case 1 => Results.Higher
}


def evaluateGuess(target: Int, guess: Int, attempts: Int): (Results.Value, Int) = (isGuessCorrect(guess, target), attempts + 1)


def guess(target: Int, read: String => Int, report: String => Unit): Unit = {
  Iterator.from(0).find(turn => {
    val guess = read("Guess a number between 1 and 100: ")
    val (result, attempt) = evaluateGuess(target, guess, turn)
    val message = result match {
      case Results.Equal => s"You got it in $attempt attempt${if (attempt == 1) "" else "s"}"
      case _ => s"Your guess is $result, try again"
    }

    report(message)

    result == Results.Equal
  })
}

def createTarget(): Int = scala.util.Random.nextInt(100) + 1