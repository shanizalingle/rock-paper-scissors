using System;

namespace Game
{

  public class Program
  {

    public static void Main()
    {
      welcome();
      int p1Score = 0;
      int p2Score = 0; 

      bool replay = true;
      while (replay)
      {

        Console.WriteLine("\n" + "Player 1-- enter rock, paper, or scissors (q = quit game)");
        string p1Input = Console.ReadLine().ToLower();

        Console.WriteLine("\n" + "Player 2-- enter rock, paper, or scissors (q = quit game)");
        string p2Input = Console.ReadLine().ToLower();

        if (p1Input == "rock" && p2Input == "rock")
        {
          Console.WriteLine("\n" + "Results: tie");
          p1Score += 0;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "paper" && p2Input == "paper"){
          Console.WriteLine("\n" + "Results: tie");
          p1Score += 0;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "scissors" && p2Input == "scissors"){
          Console.WriteLine("\n" + "Results: tie");
          p1Score += 0;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "rock" && p2Input == "paper"){
          Console.WriteLine("\n" + "Results: Player 2 wins!");
          p1Score += 0;
          p2Score += 1;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");
        
        } else if (p1Input == "rock" && p2Input == "scissors"){
          Console.WriteLine("\n" + "Results: Player 1 wins!");
          p1Score += 1;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "paper" && p2Input == "rock"){
          Console.WriteLine("\n" + "Results: Player 1 wins!");
          p1Score += 1;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "scissors" && p2Input == "rock"){
          Console.WriteLine("\n" + "Results: Player 2 wins!");
          p1Score += 0;
          p2Score += 1;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "scissors" && p2Input == "paper"){
          Console.WriteLine("\n" + "Results: Player 1 wins!");
          p1Score += 1;
          p2Score += 0;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");
        
        } else if (p1Input == "paper" && p2Input == "scissors"){
          Console.WriteLine("\n" + "Results: Player 2 wins!");
          p1Score += 0;
          p2Score += 1;
          Console.WriteLine("Player 1 score: " + p1Score + "\n" + "Player 2 score: " + p2Score + "\n");

        } else if (p1Input == "q" || p2Input == "q"){
          replay = false;

        } else {
          Console.WriteLine("\n" + "There was an error");
        }
      }

      void welcome()
      {
        Console.WriteLine("Welcome to Rock, Paper, Scissors!" + "\n");       
      }
    }
  }
}