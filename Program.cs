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
    Console.WriteLine(sphinx.CheckAnswer(score, answerGuess));

  }
}

