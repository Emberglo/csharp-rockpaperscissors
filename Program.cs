using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int compChoice = randomizer.Next(1, 10);
            string computer;
            if (compChoice <= 3)
            {
                computer = "rock";
            }
            else if (compChoice >= 4 && compChoice <= 6)
            {
                computer = "paper";
            }
            else
            {
                computer = "scissors";
            }

            Console.WriteLine("Rock, Paper, or Scissors?");
            string playerChoice = Console.ReadLine().ToLower();

            switch (playerChoice)
            {
                case "rock":
                    if (computer == "paper")
                    {
                        System.Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == "scissors")
                    {
                        System.Console.WriteLine("You Win!");
                    }
                    else
                    {
                        System.Console.WriteLine("It's a tie");
                    }
                    break;
                case "paper":
                    if (computer == "scissors")
                    {
                        System.Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == "rock")
                    {
                        System.Console.WriteLine("You Win!");
                    }
                    else
                    {
                        System.Console.WriteLine("It's a tie");
                    }
                    break;
                case "scissors":
                    if (computer == "rock")
                    {
                        System.Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == "paper")
                    {
                        System.Console.WriteLine("You Win!");
                    }
                    else
                    {
                        System.Console.WriteLine("It's a tie");
                    }
                    break;
                default:
                    System.Console.WriteLine("Not A Valid Choice!");
                    break;
            }

        }
    }
}
