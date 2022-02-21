using System;

public class Program
{
  public static void Main()
  {
    int score = 0;
    Console.WriteLine("The SPHINX has a riddle for you! Please type your answer below. Your score currently is " + score + ".\n-------------\n");

    Sphinx sphinx = new Sphinx();
    Console.WriteLine(sphinx.GetRiddle(score));

    string answerGuess = Console.ReadLine();
    //Console.WriteLine(sphinx.CheckAnswer(score, answerGuess));

    bool isCorrect = sphinx.CheckAnswer(score, answerGuess);

    while (isCorrect)
    {
      score++;
      Console.WriteLine("\nYour score is " + score + ".\n\nNext Riddle:\n___________\n" + sphinx.GetRiddle(score));
      Console.WriteLine("What is your guess?\n");
      answerGuess = Console.ReadLine();
      isCorrect = sphinx.CheckAnswer(score, answerGuess);
      if (score == 5)
      {
        break;
      }
    }
    Console.WriteLine("The game is over. You got to a score of " + score + ".");

  }
}

