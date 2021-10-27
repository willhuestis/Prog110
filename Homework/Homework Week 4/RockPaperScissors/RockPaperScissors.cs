using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Rock, Paper, or Scissors");
            Console.WriteLine("Type 1 for Rock");
            Console.WriteLine("Type 2 for Paper");
            Console.WriteLine("Type 3 for Scissors");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Random myRandom = new Random();
            int random = myRandom.Next(1, 4);



            switch (userInput)
            {
                case 1:

                    if (random == 1)
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (random == 2)
                    {
                        Console.WriteLine("Computer wins, you lose!");
                    }
                    else if (random == 3)
                    {
                        Console.WriteLine("Congrats, you win!");
                    }
                    break;

                case 2:
                    if (random == 1)
                    {
                        Console.WriteLine("Congrats, you win!");
                    }
                    else if (random == 2)
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (random == 3)
                    {
                        Console.WriteLine("Computer wins, you lose!");
                    }
                    break;

                case 3:
                    if (random == 1)
                    {
                        Console.WriteLine("Computer wins, you lose!");
                    }
                    else if (random == 2)
                    {
                        Console.WriteLine("Congrats, you win!");
                    }
                    else if (random == 3)
                    {
                        Console.WriteLine("Tie");
                    }
                    break;
            }

        }
    }
}