using System;

public class Sphinx
{


  private string[] riddleQuestions = {
    "What has to be broken before you can use it?",
    "I’m tall when I’m young, and I’m short when I’m old. What am I?",
    "What month of the year has 28 days?",
    "What is full of holes but still holds water?",
    "What question can you never answer yes to?",
    "What is always in front of you but can’t be seen?"
  };
  private string[] riddleAnswers = {
    "An egg",
    "A candle",
    "All of them",
    "A sponge",
    "Are you asleep yet?",
    "The future"
  };


  public string GetRiddle(int score)
  {
    return riddleQuestions[score];
  }

  public bool CheckAnswer(int score, string answerGuess)
  {
    if (riddleAnswers[score] == answerGuess)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}
